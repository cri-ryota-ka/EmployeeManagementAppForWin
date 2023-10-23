Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports EmployeeManagementAppForWin.PublicFunction

Public Class EmployeeInfoForm
    ' convert flag to str or str to flag
    Private Function ConvertFlagToGender(ByVal GenderFlag As Integer) As String
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
    Private Function ConvertFlagToBelongingTo(ByVal BelongingToFlag As Integer) As String
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
        Dim BelongingToText As Integer = ConvertBelongingToToFlag(BelongingToSelectBox.Text)
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
    Dim LocalDbConn As New SqlConnection("Server=(localdb)\MSSQLLocalDB;" &
                                        "Initial Catalog=C:\USERS\HOUSE\SOURCE\REPOS\EMPLOYEEMANAGEMENTAPPFORWIN\EMPLOYEEINFO.MDF;" &
                                        "Integrated Security=True;")

    Private Sub AddShownEmployeeInfoItems(ByVal SqlReadObject As Object)
        ShowEmployeeInfo.Items.AddRange(New ListViewItem() {
            New ListViewItem(New String() {$"{SqlReadObject(0)}",
                                            $"{SqlReadObject(1)}",
                                            $"{ConvertFlagToGender(SqlReadObject(2))}",
                                            $"{ConvertFlagToBelongingTo(SqlReadObject(3))}"}, -1)
            }
        )
    End Sub
    Private Function ReturnDBLatestRow(LocalDbConn)
        Dim SqlDBLatestRowStr As String = "SELECT TOP(1)* FROM dbo.EmployeeInfo ORDER BY EmployeeID DESC;"
        Dim SqlDBLatestRowDB As New SqlCommand(SqlDBLatestRowStr, LocalDbConn)
        Dim SqlDBLatestRowRead = SqlDBLatestRowDB.ExecuteReader()
        Return SqlDBLatestRowRead
    End Function

    ' close DB
    Private Sub CloseDBConnection(LocalDbConn)
        If (LocalDbConn.State = ConnectionState.Open) Then
            LocalDbConn.Close()
        End If
    End Sub

    Private Sub ShownEmployeeInfoForm() Handles Me.Shown
        Try
            Dim SqlSelectStr As String = "SELECT * FROM dbo.EmployeeInfo;"
            Dim SqlCommandDb As New SqlCommand(SqlSelectStr, LocalDbConn)
            LocalDbConn.Open()
            Dim SqlSelectRead = SqlCommandDb.ExecuteReader()
            While SqlSelectRead.Read()
                AddShownEmployeeInfoItems(SqlSelectRead)
            End While
            SqlSelectRead.Close()
        Catch ex As Exception
            ShowErrorMessageBox(ex.Message)
        Finally
            CloseDBConnection(LocalDbConn)
        End Try
        Try
            LocalDbConn.Open()
            Dim SqlEmployeeIDAutofillRead = ReturnDBLatestRow(LocalDbConn)
            SqlEmployeeIDAutofillRead.Read()
            EmployeeIDAutofill.Text = SqlEmployeeIDAutofillRead(0) + 1
            SqlEmployeeIDAutofillRead.Close()
        Catch ex As Exception
            ShowErrorMessageBox(ex.Message)
        Finally
            CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Private Sub PostEmployeeInfo_Click(sender As Object, e As EventArgs) Handles PostEmployeeInfo.Click
        Dim EmployeeNameText As String = ReturnEmployeeNameText()
        Dim GenderText As Integer = ReturnGenderText()
        Dim BelongingToText As Integer = ReturnBelongingToText()
        Dim EmployeeIDText As Integer = ReturnEmployeeIDText()
        Dim SqlInsertStr As String = $"INSERT INTO dbo.EmployeeInfo(EmployeeID, EmployeeName, GenderFlag, BelongingToFlag) VALUES({EmployeeIDText}, N'{EmployeeNameText}', {GenderText}, {BelongingToText});"
        Try
            LocalDbConn.Open()
            Dim DbTransaction As SqlTransaction
            DbTransaction = LocalDbConn.BeginTransaction()
            Try
                Dim SqlInsertDb As New SqlCommand(SqlInsertStr, LocalDbConn, DbTransaction)
                Dim SqlInsertRead As Object = SqlInsertDb.ExecuteNonQuery()
                DbTransaction.Commit()
                Dim SqlEmployeeLatestRowRead = ReturnDBLatestRow(LocalDbConn)
                SqlEmployeeLatestRowRead.Read()
                AddShownEmployeeInfoItems(SqlEmployeeLatestRowRead)
            Catch ex As Exception
                ShowErrorMessageBox(ex.Message)
                DbTransaction.Rollback()
            End Try
        Catch ex As Exception
            ShowErrorMessageBox(ex.Message)
        Finally
            CloseDBConnection(LocalDbConn)
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
                AddShownEmployeeInfoItems(SqlSearchRead)
            End While
            SqlSearchRead.Close()
        Catch ex As Exception
            ShowErrorMessageBox(ex.Message)
        Finally
            CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Private Sub ShowEmployeeInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShowEmployeeInfo.SelectedIndexChanged
        Dim SelectedItemShowEmployeeInfo As ListViewItem = ShowEmployeeInfo.SelectedItems(0)
        Debug.Write(SelectedItemShowEmployeeInfo)
        EmployeeDetailFrom.Show()
    End Sub
End Class
