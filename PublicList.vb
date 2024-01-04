Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class PublicDbSetting
    ' db connection
    Public Shared LocalDbConn As New SqlConnection("Server=(localdb)\MSSQLLocalDB;" &
                                        "Initial Catalog=C:\USERS\HOUSE\SOURCE\REPOS\EMPLOYEEMANAGEMENTAPPFORWIN\EMPLOYEEINFO.MDF;" &
                                        "Integrated Security=True;")

    ' close DB
    Public Shared Sub CloseDBConnection(LocalDbConn)
        If (LocalDbConn.State = ConnectionState.Open) Then
            LocalDbConn.Close()
        End If
    End Sub
End Class

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

    Public Shared Function CheckInputText(ByVal InputText As String) As Boolean
        Dim CheckResult As Boolean
        Dim rgx As New Regex("\S+")
        If String.IsNullOrEmpty(InputText) Or Not rgx.IsMatch(InputText) Then
            CheckResult = False
        Else
            CheckResult = True
        End If
        Return CheckResult
    End Function
End Class

Public Class ConstructorEmployeeDetail
    Public EmployeeName As String
    Public EmployeeGender As String
    Public EmployeeBelongingTo As String
    Public EmployeeID As Integer
    Public Shared EmployeeDetail As ConstructorEmployeeDetail

    Public Shared WriteOnly Property SetConstructorEmployeeDetail As ConstructorEmployeeDetail
        Set(value As ConstructorEmployeeDetail)
            EmployeeDetail = value
        End Set
    End Property

    Public Shared ReadOnly Property GetConstructorEmployeeDetail As ConstructorEmployeeDetail
        Get
            Return EmployeeDetail
        End Get
    End Property
End Class
