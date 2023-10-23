Public Class EmployeeDetailFrom
    Private Sub ShownEmployeeDetailFrom() Handles Me.Shown
        AddHandler Application.Idle, AddressOf ShownEmployeeDetailFrom_Idle
    End Sub
    Private Sub ShownEmployeeDetailFrom_Idle(sender As Object, e As EventArgs)
        EmployeeInfoForm.Close()
        RemoveHandler Application.Idle, AddressOf ShownEmployeeDetailFrom_Idle
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ReturnEmployeeInfoButton.Click
        EmployeeInfoForm.Show()
        Me.Close()
    End Sub
End Class