Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports PublicFunction = EmployeeManagementAppForWin.PublicFunction
Imports PublicDbSetting = EmployeeManagementAppForWin.PublicDbSetting
Imports EmployeeManagementAppForWin.ConstructorEmployeeDetail

Public Class EmployeeInfoForm
    ' convert flag to str or str to flag
    Public Shared Function ConvertFlagToGender(ByVal GenderFlag As Integer) As String
        Dim GenderString As String
        If GenderFlag = 0 Then
            GenderString = "男性"
        ElseIf GenderFlag = 1 Then
            GenderString = "女性"
        Else
            GenderString = "Error"
        End If
        Return GenderString
    End Function
    Public Shared Function ConvertFlagToBelongingTo(ByVal BelongingToFlag As Integer) As String
        Dim BelongingToString As String
        If BelongingToFlag = 0 Then
            BelongingToString = "営業部"
        ElseIf BelongingToFlag = 1 Then
            BelongingToString = "事業部"
        Else
            BelongingToString = "Error"
        End If
        Return BelongingToString
    End Function
    Private Function ConvertGenderToFlag(ByVal GenderString As String) As Integer
        Dim GenderFlag As Integer
        If GenderString = "男性" Then
            GenderFlag = 0
        ElseIf GenderString = "女性" Then
            GenderFlag = 1
        Else
            GenderFlag = -1
        End If
        Return GenderFlag
    End Function

    ' return submit text
    Private Function ReturnEmployeeNameText() As String
        Dim EmployeeNameText As String = EmployeeNameTextBox.Text
        EmployeeNameTextBox.Text = ""
        Return EmployeeNameText
    End Function
    Private Function ReturnGenderText() As Integer
        Dim GenderText As String
        If Male.Checked Then
            GenderText = "男性"
        ElseIf Female.Checked Then
            GenderText = "女性"
            Male.Checked = True
        Else
            GenderText = "Error"
            Male.Checked = True
        End If
        Return ConvertGenderToFlag(GenderText)
    End Function
    Private Function ReturnBelongingToText() As Integer
        Dim BelongingToText As Integer = PublicFunction.ConvertBelongingToToFlag(BelongingToSelectBox.Text)
        BelongingToSelectBox.Text = "事業部"
        Return BelongingToText
    End Function
    Private Function ReturnEmployeeIDText() As Integer
        Dim EmployeeIDText As Integer = EmployeeIDAutofill.Text
        EmployeeIDAutofill.Text += 1
        Return EmployeeIDText
    End Function
    Private Function ReturnSearchNameTextStr() As String
        Dim SearchNameText As String = SearchName.Text
        Return SearchNameText
    End Function

    ' db connection and sqlstrings
    Public Shared LocalDbConn = PublicDbSetting.LocalDbConn

    Public Shared Sub AddShownEmployeeInfoItems(ByVal SqlReadObject As Object, ListView As ListView)
        ListView.Items.AddRange(New ListViewItem() {
            New ListViewItem(New String() {$"{SqlReadObject(0)}",
                                            $"{SqlReadObject(1)}",
                                            $"{ConvertFlagToGender(SqlReadObject(2))}",
                                            $"{ConvertFlagToBelongingTo(SqlReadObject(3))}"}, -1)
            }
        )
    End Sub
    Public Shared Function ReturnDBLatestRow(LocalDbConn)
        Dim SqlDBLatestRowStr As String = "SELECT TOP(1)* FROM dbo.EmployeeInfo ORDER BY EmployeeID DESC;"
        Dim SqlDBLatestRowDB As New SqlCommand(SqlDBLatestRowStr, LocalDbConn)
        Dim SqlDBLatestRowRead = SqlDBLatestRowDB.ExecuteReader()
        Return SqlDBLatestRowRead
    End Function

    Public Shared Sub SubShowEmployeeInfo(ListView As ListView)
        Try
            Dim SqlSelectStr As String = "SELECT * FROM dbo.EmployeeInfo;"
            Dim SqlCommandDb As New SqlCommand(SqlSelectStr, LocalDbConn)
            LocalDbConn.Open()
            Dim SqlSelectRead = SqlCommandDb.ExecuteReader()
            While SqlSelectRead.Read()
                AddShownEmployeeInfoItems(SqlSelectRead, ListView)
            End While
            SqlSelectRead.Close()
        Catch ex As Exception
            PublicFunction.ShowErrorMessageBox(ex.Message)
        Finally
            PublicDbSetting.CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Public Shared Sub SubEmployeeIDAutofill(Label As Label)
        Try
            LocalDbConn.Open()
            Dim SqlEmployeeIDAutofillRead = ReturnDBLatestRow(LocalDbConn)
            SqlEmployeeIDAutofillRead.Read()
            Label.Text = SqlEmployeeIDAutofillRead(0) + 1
            SqlEmployeeIDAutofillRead.Close()
        Catch ex As Exception
            PublicFunction.ShowErrorMessageBox(ex.Message)
        Finally
            PublicDbSetting.CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Private Sub ShownEmployeeInfoForm() Handles Me.Shown
        SubShowEmployeeInfo(ShowEmployeeInfo)
        SubEmployeeIDAutofill(EmployeeIDAutofill)
    End Sub

    Private Sub PostEmployeeInfo_Click(sender As Object, e As EventArgs) Handles PostEmployeeInfo.Click
        Dim EmployeeNameText As String = ReturnEmployeeNameText()
        If Not PublicFunction.CheckInputText(EmployeeNameText) Then
            MessageBox.Show("従業員名を入力してください", "登録失敗")
            Return
        End If
        Dim GenderText As Integer = ReturnGenderText()
        Dim BelongingToText As Integer = ReturnBelongingToText()
        If BelongingToText = -1 Then
            MessageBox.Show("選択肢から所属を選んでください", "登録失敗")
            Return
        End If
        Dim EmployeeIDText As Integer = ReturnEmployeeIDText()
        Dim SqlInsertStr As String = $"INSERT INTO dbo.EmployeeInfo(EmployeeID, EmployeeName, GenderFlag, BelongingToFlag) VALUES({EmployeeIDText}, N'{EmployeeNameText}', {GenderText}, {BelongingToText});"
        Try
            LocalDbConn.Open()
            Dim DbTransaction As SqlTransaction
            DbTransaction = LocalDbConn.BeginTransaction()
            Try
                Dim SqlInsertDb As New SqlCommand(SqlInsertStr, LocalDbConn, DbTransaction)
                SqlInsertDb.ExecuteNonQuery()
                DbTransaction.Commit()
                Dim SqlEmployeeLatestRowRead = ReturnDBLatestRow(LocalDbConn)
                SqlEmployeeLatestRowRead.Read()
                AddShownEmployeeInfoItems(SqlEmployeeLatestRowRead, ShowEmployeeInfo)
            Catch ex As Exception
                PublicFunction.ShowErrorMessageBox(ex.Message)
                DbTransaction.Rollback()
            End Try
        Catch ex As Exception
            PublicFunction.ShowErrorMessageBox(ex.Message)
        Finally
            PublicDbSetting.CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim SearchNameTextStr As String = ReturnSearchNameTextStr()
        Dim SqlSearchStr As String = $"SELECT * FROM dbo.EmployeeInfo WHERE EmployeeID LIKE '%{SearchNameTextStr}%' OR EmployeeName LIKE N'%{SearchNameTextStr}%';"
        Try
            LocalDbConn.Open()
            Dim SqlSearchtDb As New SqlCommand(SqlSearchStr, LocalDbConn)
            Dim SqlSearchRead = SqlSearchtDb.ExecuteReader()
            ShowEmployeeInfo.Clear()
            ShowEmployeeInfo.Columns.AddRange(New ColumnHeader() {EmployeeIDColumn, EmployeeNameColumn, GenderColumn, BelongingToColumn})
            While SqlSearchRead.Read()
                AddShownEmployeeInfoItems(SqlSearchRead, ShowEmployeeInfo)
            End While
            SqlSearchRead.Close()
        Catch ex As Exception
            PublicFunction.ShowErrorMessageBox(ex.Message)
        Finally
            PublicDbSetting.CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Private Sub ShowEmployeeInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShowEmployeeInfo.SelectedIndexChanged
        Dim SelectedItemShowEmployeeInfo As ListViewItem = ShowEmployeeInfo.SelectedItems(0)
        Dim ConstructorEmployeeDetail As New ConstructorEmployeeDetail()
        ConstructorEmployeeDetail.EmployeeID = SelectedItemShowEmployeeInfo.Text
        ConstructorEmployeeDetail.EmployeeName = SelectedItemShowEmployeeInfo.SubItems(1).Text
        ConstructorEmployeeDetail.EmployeeGender = SelectedItemShowEmployeeInfo.SubItems(2).Text
        ConstructorEmployeeDetail.EmployeeBelongingTo = SelectedItemShowEmployeeInfo.SubItems(3).Text
        SetConstructorEmployeeDetail = ConstructorEmployeeDetail
        EmployeeDetailFrom.Show()
    End Sub

    ' 一時対応、画面を差し替えたら処理は削除する
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MoveNisWindowFrom.Click
        NisWindowForm.Show()
        Me.Close()
    End Sub
End Class
