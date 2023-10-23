Public Class PublicFunction
    Public Shared Function ConvertBelongingToToFlag(ByVal BelongingToString As String) As Integer
        Dim BelongingToFlag As Integer
        If BelongingToString = "営業部" Then
            BelongingToFlag = 0
        ElseIf BelongingToString = "事業部" Then
            BelongingToFlag = 1
        Else
            BelongingToFlag = -1
        End If
        Return BelongingToFlag
    End Function

    Public Shared Sub ShowErrorMessageBox(ByVal ErrorMessage As String)
        Dim MessageBoxMessage As String = $"処理に失敗しました。{ErrorMessage}"
        Dim MessageBoxCaption As String = "Error"
        MessageBox.Show(MessageBoxMessage, MessageBoxCaption)
    End Sub
End Class

Public Class ConstructorEmployeeDetail
    Public EmployeeName As String
    Public EmployeeGender As String
    Public EmployeeBelongingTo As String
    Public EmployeeID As Integer
End Class
