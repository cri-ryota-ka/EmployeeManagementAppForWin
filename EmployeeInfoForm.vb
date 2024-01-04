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
    Public Shared Function ConvertGenderToFlag(ByVal GenderString As String) As Integer
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
    Public Shared Function CheckPostEmployeeInput(EmployeeNameText As String, BelongingToText As Integer) As Boolean
        If Not PublicFunction.CheckInputText(EmployeeNameText) Then
            MessageBox.Show("従業員名を入力してください", "登録失敗")
            Return False
        End If
        If BelongingToText = -1 Then
            MessageBox.Show("選択肢から所属を選んでください", "登録失敗")
            Return False
        End If
        Return True
    End Function

    Public Shared Sub InitializePostEmployeeInput(Array() As Control)
        Array(0).Text = ""
        Dim RadioButton As RadioButton = Array(1)
        RadioButton.Checked = True
        Array(2).Text = "事業部"
        Array(3).Text += 1
    End Sub

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

    Public Shared Sub SubPostEmployeeInfo(ListView As ListView, SqlInsertStr As String, Array() As Control)
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
                AddShownEmployeeInfoItems(SqlEmployeeLatestRowRead, ListView)
                InitializePostEmployeeInput(Array)
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

    Public Shared Sub SubSearchEmployee(ListView As ListView, SearchNameTextStr As String)
        Dim SqlSearchStr As String = $"SELECT * FROM dbo.EmployeeInfo WHERE EmployeeID LIKE '%{SearchNameTextStr}%' OR EmployeeName LIKE N'%{SearchNameTextStr}%';"
        Try
            LocalDbConn.Open()
            Dim SqlSearchtDb As New SqlCommand(SqlSearchStr, LocalDbConn)
            Dim SqlSearchRead = SqlSearchtDb.ExecuteReader()
            ListView.Items.Clear()
            While SqlSearchRead.Read()
                AddShownEmployeeInfoItems(SqlSearchRead, ListView)
            End While
            SqlSearchRead.Close()
        Catch ex As Exception
            PublicFunction.ShowErrorMessageBox(ex.Message)
        Finally
            PublicDbSetting.CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Public Shared Sub SubSelectedIndexShowEmployeeInfo(ListView As ListView)
        Dim SelectedItemShowEmployeeInfo As ListViewItem = ListView.SelectedItems(0)
        Dim ConstructorEmployeeDetail As New ConstructorEmployeeDetail()
        ConstructorEmployeeDetail.EmployeeID = SelectedItemShowEmployeeInfo.Text
        ConstructorEmployeeDetail.EmployeeName = SelectedItemShowEmployeeInfo.SubItems(1).Text
        ConstructorEmployeeDetail.EmployeeGender = SelectedItemShowEmployeeInfo.SubItems(2).Text
        ConstructorEmployeeDetail.EmployeeBelongingTo = SelectedItemShowEmployeeInfo.SubItems(3).Text
        SetConstructorEmployeeDetail = ConstructorEmployeeDetail
    End Sub

    ' form designer function
    Private Sub ShownEmployeeInfoForm()
        SubShowEmployeeInfo(ShowEmployeeInfo)
        SubEmployeeIDAutofill(EmployeeIDAutofill)
    End Sub

    Private Sub PostEmployeeInfo_Click(sender As Object, e As EventArgs) Handles PostEmployeeInfo.Click
        Dim InitializePostEmployeeInputArray() As Control = {EmployeeNameTextBox, Male, BelongingToSelectBox, EmployeeIDAutofill}

        Dim EmployeeNameText As String = InitializePostEmployeeInputArray(0).Text
        Dim BelongingToText As Integer = PublicFunction.ConvertBelongingToToFlag(InitializePostEmployeeInputArray(2).Text)
        If Not CheckPostEmployeeInput(EmployeeNameText, BelongingToText) Then
            Return
        End If

        Dim GenderTextString As String
        If Male.Checked Then
            GenderTextString = "男性"
        ElseIf Female.Checked Then
            GenderTextString = "女性"
        Else
            GenderTextString = "Error"
        End If
        Dim GenderText As Integer = ConvertGenderToFlag(GenderTextString)
        Dim EmployeeIDText As Integer = EmployeeIDAutofill.Text
        Dim SqlInsertStr As String = $"INSERT INTO dbo.EmployeeInfo(EmployeeID, EmployeeName, GenderFlag, BelongingToFlag) VALUES({EmployeeIDText}, N'{EmployeeNameText}', {GenderText}, {BelongingToText});"

        SubPostEmployeeInfo(ShowEmployeeInfo, SqlInsertStr, InitializePostEmployeeInputArray)
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SubSearchEmployee(ShowEmployeeInfo, SearchName.Text)
    End Sub

    Private Sub ShowEmployeeInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShowEmployeeInfo.SelectedIndexChanged
        SubSelectedIndexShowEmployeeInfo(ShowEmployeeInfo)
        EmployeeDetailFrom.Show()
    End Sub

    ' 一時対応、画面を差し替えたら処理は削除する
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MoveNisWindowFrom.Click
        NisWindowForm.Show()
        Me.Close()
    End Sub
End Class
