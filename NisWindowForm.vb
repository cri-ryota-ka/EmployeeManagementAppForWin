' インポート群、画面は非表示にするけど機能はそのまま残しておきたい、引数の書き換えは必須だけど置き換え時に対応する、共有の設定も画面を作る時に実施する
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports PublicFunction = EmployeeManagementAppForWin.PublicFunction
Imports PublicDbSetting = EmployeeManagementAppForWin.PublicDbSetting
Imports EmployeeManagementAppForWin.ConstructorEmployeeDetail
Imports EmployeeInfo = EmployeeManagementAppForWin.EmployeeInfoForm ' 機能はそのまま使う、画面は残すけど表示はしない、引数は書き換え必須
Imports EmployeeDetail = EmployeeManagementAppForWin.EmployeeDetailFrom ' 機能はそのまま使う、画面は残すけど表示はしない、引数は書き換え必須

Public Class NisWindowForm
    Private Sub ExecuteList(Item As String)
        If Item = "EmployeeInfoTab" Then
            ShowEmployeeInfo.Items.Clear()
            EmployeeInfo.SubShowEmployeeInfo(ShowEmployeeInfo)
        Else
            PublicFunction.ShowErrorMessageBox("ExecuteList Item not exist")
        End If
    End Sub

    Private Sub OpenTabPage(TabPage As TabPage)
        If MenuTabs.Controls.Contains(TabPage) Then
            MenuTabs.SelectedTab = TabPage
        Else
            MenuTabs.Controls.Add(TabPage)
            ExecuteList("EmployeeInfoTab")
            MenuTabs.SelectedTab = TabPage
        End If
    End Sub

    Private Sub CloseTabPage(TabPage As TabPage, ErrorMessage As String)
        If MenuTabs.Controls.Contains(TabPage) Then
            MenuTabs.Controls.Remove(TabPage)
        Else
            PublicFunction.ShowErrorMessageBox(ErrorMessage)
        End If
    End Sub

    Private Sub ShownNisWindowForm() Handles Me.Shown
        MenuTabs.Controls.Clear()
    End Sub

    Private Sub OpenEmployeeTab_Click(sender As Object, e As EventArgs) Handles OpenEmployeeTab.Click
        OpenTabPage(EmployeeInfoTab)
    End Sub

    Private Sub CloseEmployeeInfoTab_Click(sender As Object, e As EventArgs) Handles CloseEmployeeInfoTab.Click
        CloseTabPage(EmployeeInfoTab, "従業員一覧タブは開いていません。")
    End Sub
    Private Sub CloseMenu_Click(sender As Object, e As EventArgs) Handles OpenAndCloseMenu.Click
        If SplitContainer.Panel1.Visible Then
            SplitContainer.Panel1.Hide()
            OpenAndCloseMenu.Text = ">"
            'SplitContainer.SplitterDistance = 0
            'SplitContainer.Panel2.Size = New Size(800, 450)
            'MenuTabs.Size = New Size(794, 416)
            'EmployeeInfoTab.Size = New Size(786, 388)
        Else
            SplitContainer.Panel1.Show()
            OpenAndCloseMenu.Text = "<"
            'SplitContainer.SplitterDistance = 150
            'MenuTabs.Size = New Size(640, 416)
            'EmployeeInfoTab.Size = New Size(632, 388)
            'Debug.Write(SplitContainer.Panel1.Size)
            'Debug.Write(SplitContainer.Panel2.Size)
        End If
    End Sub
End Class