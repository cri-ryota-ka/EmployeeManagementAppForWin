Imports System.Data.SqlClient
Imports PublicFunction = EmployeeManagementAppForWin.PublicFunction
Imports PublicDbSetting = EmployeeManagementAppForWin.PublicDbSetting
Imports EmployeeManagementAppForWin.ConstructorEmployeeDetail
Imports EmployeeInfo = EmployeeManagementAppForWin.EmployeeInfoForm

Public Class EmployeeDetailFrom
    Private Sub ShownEmployeeDetailFrom() Handles Me.Shown
        AddHandler Application.Idle, AddressOf ShownEmployeeDetailFrom_Idle
        Dim ConstructorEmployeeDetail As ConstructorEmployeeDetail = GetConstructorEmployeeDetail
        EmployeeNameTextBox.Text = ConstructorEmployeeDetail.EmployeeName
        EmployeeGenderAutofill.Text = ConstructorEmployeeDetail.EmployeeGender
        BelongingToSelectBox.Text = ConstructorEmployeeDetail.EmployeeBelongingTo
        EmployeeIDAutofill.Text = ConstructorEmployeeDetail.EmployeeID
    End Sub
    Private Sub ShownEmployeeDetailFrom_Idle(sender As Object, e As EventArgs)
        EmployeeInfoForm.Close()
        RemoveHandler Application.Idle, AddressOf ShownEmployeeDetailFrom_Idle
    End Sub

    Public Shared Sub SubUpdateEmployeeInfo(EmployeeIDText As Integer, EmployeeNameText As String, BelongingToText As Integer)
        Dim LocalDbConn = PublicDbSetting.LocalDbConn
        Dim SqlUpdateStr As String = $"UPDATE dbo.EmployeeInfo SET EmployeeName = N'{EmployeeNameText}', BelongingToFlag = {BelongingToText} WHERE EmployeeID = {EmployeeIDText};"
        Try
            LocalDbConn.Open()
            Dim DbTransaction As SqlTransaction
            DbTransaction = LocalDbConn.BeginTransaction()
            Try
                Dim SqlUpdateDb As New SqlCommand(SqlUpdateStr, LocalDbConn, DbTransaction)
                SqlUpdateDb.ExecuteNonQuery()
                DbTransaction.Commit()
                Dim UpdateSuccessText As String = "成功" & vbCrLf & "一覧には、開き直すと反映されます。"
                MessageBox.Show(UpdateSuccessText, "更新結果")
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

    Private Sub UpdateEmployeeInfo_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeInfo.Click
        Dim EmployeeNameText As String = EmployeeNameTextBox.Text
        Dim BelongingToText As Integer = PublicFunction.ConvertBelongingToToFlag(BelongingToSelectBox.Text)
        Dim EmployeeIDText As Integer = EmployeeIDAutofill.Text
        If Not EmployeeInfo.CheckPostEmployeeInput(EmployeeNameText, BelongingToText) Then
            Return
        End If
        SubUpdateEmployeeInfo(EmployeeIDText, EmployeeNameText, BelongingToText)
    End Sub

    Private Sub ReturnEmployeeInfoButton_Click(sender As Object, e As EventArgs) Handles ReturnEmployeeInfoButton.Click
        EmployeeInfoForm.Show()
        Me.Close()
    End Sub
End Class