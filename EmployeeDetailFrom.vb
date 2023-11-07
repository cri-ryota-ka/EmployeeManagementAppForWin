Imports System.Data.SqlClient
Imports PublicFunction = EmployeeManagementAppForWin.PublicFunction
Imports PublicDbSetting = EmployeeManagementAppForWin.PublicDbSetting
Imports EmployeeManagementAppForWin.ConstructorEmployeeDetail

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

    Private Sub UpdateEmployeeInfo_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeInfo.Click
        Dim LocalDbConn = PublicDbSetting.LocalDbConn
        Dim EmployeeNameText As String = EmployeeNameTextBox.Text
        If Not PublicFunction.CheckInputText(EmployeeNameText) Then
            MessageBox.Show("従業員名を入力してください", "登録失敗")
            Return
        End If
        Dim BelongingToText As Integer = PublicFunction.ConvertBelongingToToFlag(BelongingToSelectBox.Text)
        If BelongingToText = -1 Then
            MessageBox.Show("選択肢から所属を選んでください", "登録失敗")
            Return
        End If
        Dim EmployeeIDText As Integer = EmployeeIDAutofill.Text
        Dim SqlUpdateStr As String = $"UPDATE dbo.EmployeeInfo SET EmployeeName = N'{EmployeeNameText}', BelongingToFlag = {BelongingToText} WHERE EmployeeID = {EmployeeIDText};"
        Try
            LocalDbConn.Open()
            Dim DbTransaction As SqlTransaction
            DbTransaction = LocalDbConn.BeginTransaction()
            Try
                Dim SqlUpdateDb As New SqlCommand(SqlUpdateStr, LocalDbConn, DbTransaction)
                SqlUpdateDb.ExecuteNonQuery()
                DbTransaction.Commit()
                MessageBox.Show("成功", "更新結果")
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

    Private Sub ReturnEmployeeInfoButton_Click(sender As Object, e As EventArgs) Handles ReturnEmployeeInfoButton.Click
        EmployeeInfoForm.Show()
        Me.Close()
    End Sub
End Class