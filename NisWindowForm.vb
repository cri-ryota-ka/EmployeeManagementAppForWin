' インポート群、画面は非表示にするけど機能はそのまま残しておきたい
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports PublicFunction = EmployeeManagementAppForWin.PublicFunction
Imports PublicDbSetting = EmployeeManagementAppForWin.PublicDbSetting
Imports EmployeeManagementAppForWin.ConstructorEmployeeDetail
Imports EmployeeInfo = EmployeeManagementAppForWin.EmployeeInfoForm ' 機能はそのまま使う、画面は残すけど表示はしない
Imports EmployeeDetail = EmployeeManagementAppForWin.EmployeeDetailFrom ' 機能はそのまま使う、画面は残すけど表示はしない

Public Class NisWindowForm
    Private Sub ExecuteTabList(TabPage As TabPage)
        If TabPage.Name = EmployeeInfoTab.Name Then
            ShowEmployeeInfo.Items.Clear()
            EmployeeInfo.SubShowEmployeeInfo(ShowEmployeeInfo)
            EmployeeInfo.SubEmployeeIDAutofill(EmployeeIDAutofill)
        ElseIf TabPage.Name = CostInfoTab.Name Then
            Debug.Write("opne cost info tab, ")
            ' ElseIf TabPage.Name = EmployeeDetailTab.Name Then
            '     Dim ConstructorEmployeeDetail As ConstructorEmployeeDetail = GetConstructorEmployeeDetail
            '     Debug.Write(ConstructorEmployeeDetail.EmployeeID)
        Else
            PublicFunction.ShowErrorMessageBox("ExecuteList Item not exist")
        End If
    End Sub

    Private Sub OpenTabPage(TabPage As TabPage)
        If MenuTabs.Controls.Contains(TabPage) Then
            MenuTabs.SelectedTab = TabPage
        Else
            MenuTabs.Controls.Add(TabPage)
            ExecuteTabList(TabPage)
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

    Private Sub ReturnShowEmployeeInfo()
        If ShowEmployeeInfo.Visible Then
            Return
        ElseIf PostEmployeeInfoPanel.Visible Then ' 登録用のグループが表示されていることを判定する
            PostEmployeeInfoPanel.Hide()
            ShowEmployeeInfo.Show()
            ChangeDisplayEmployeeInfoTab.Text = "登録"
        ElseIf EmployeeDetailPanel.Visible Then ' 詳細用のグループが表示されていることを判定する
            EmployeeDetailPanel.Hide()
            If Not ShowEmployeeInfo.SelectedItems.Count = 0 Then
                ShowEmployeeInfo.SelectedItems(0).Selected = False
            End If
            ShowEmployeeInfo.Show()
            ChangeDisplayEmployeeInfoTab.Text = "登録"
        Else
            PublicFunction.ShowErrorMessageBox("設定されていない表示です。")
        End If
    End Sub

    ' form designer function
    Private Sub ShownNisWindowForm() Handles Me.Shown
        MenuTabs.Controls.Clear()
        PostEmployeeInfoFormTab.Controls.Remove(PostEmployeeInfoPanel)
        EmployeeDetailTab.Controls.Remove(EmployeeDetailPanel)
        EmployeeInfoTab.Controls.Add(PostEmployeeInfoPanel)
        EmployeeInfoTab.Controls.Add(EmployeeDetailPanel)
        PostEmployeeInfoPanel.Hide()
        EmployeeDetailPanel.Hide()
    End Sub

    Private Sub OpenEmployeeTab_Click(sender As Object, e As EventArgs) Handles OpenEmployeeTab.Click
        OpenTabPage(EmployeeInfoTab)
        ReturnShowEmployeeInfo()
    End Sub

    Private Sub CloseEmployeeInfoTab_Click(sender As Object, e As EventArgs) Handles CloseEmployeeInfoTab.Click
        CloseTabPage(EmployeeInfoTab, "従業員一覧タブは開いていません。")
    End Sub
    Private Sub OpenCostTab_Click(sender As Object, e As EventArgs) Handles OpenCostInfoTab.Click
        OpenTabPage(CostInfoTab)
    End Sub

    Private Sub CloseTransportExpensesTab_Click(sender As Object, e As EventArgs) Handles CloseCostInfoTab.Click
        CloseTabPage(CostInfoTab, "交通費一覧タブは開いていません。")
    End Sub

    Private Sub SearchEmployee_Click(sender As Object, e As EventArgs) Handles SearchEmployee.Click
        OpenTabPage(EmployeeInfoTab)
        ReturnShowEmployeeInfo()
        EmployeeInfo.SubSearchEmployee(ShowEmployeeInfo, SearchEmployeeTextBox.Text)
    End Sub

    Private Sub CloseMenu_Click(sender As Object, e As EventArgs) Handles OpenAndCloseMenu.Click
        If SplitContainer.Panel1.Visible Then
            SplitContainer.Panel1.Hide()
            OpenAndCloseMenu.Text = ">"
            SplitContainer.SplitterDistance = 150 - 150
            MenuTabs.Size = New Size(640 + 125, 416)
            CloseEmployeeInfoTab.Location = New Point(551 + 125, 6)
            DummyButtonCloseEmployeeInfoTab2.Location = New Point(551 + 125, 6)
            CloseCostInfoTab.Location = New Point(551 + 125, 6)
        Else
            SplitContainer.Panel1.Show()
            OpenAndCloseMenu.Text = "<"
            SplitContainer.SplitterDistance = 150
            MenuTabs.Size = New Size(640, 416)
            CloseEmployeeInfoTab.Location = New Point(551, 6)
            DummyButtonCloseEmployeeInfoTab2.Location = New Point(551, 6)
            CloseCostInfoTab.Location = New Point(551, 6)
        End If
    End Sub

    Private Sub ChangeDisplayEmployeeInfoTab_Click(sender As Object, e As EventArgs) Handles ChangeDisplayEmployeeInfoTab.Click
        If ShowEmployeeInfo.Visible Then
            ShowEmployeeInfo.Hide()
            PostEmployeeInfoPanel.Show()
            ChangeDisplayEmployeeInfoTab.Text = "一覧に戻る"
        Else
            ReturnShowEmployeeInfo()
        End If
    End Sub

    Private Sub PostEmployeeInfo_Click(sender As Object, e As EventArgs) Handles PostEmployeeInfo.Click
        Dim InitializePostEmployeeInputArray() As Control = {EmployeeNameTextBox, Male, BelongingToSelectBox, EmployeeIDAutofill}

        Dim EmployeeNameText As String = InitializePostEmployeeInputArray(0).Text
        Dim BelongingToText As Integer = PublicFunction.ConvertBelongingToToFlag(InitializePostEmployeeInputArray(2).Text)
        If Not EmployeeInfo.CheckPostEmployeeInput(EmployeeNameText, BelongingToText) Then
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
        Dim GenderText As Integer = EmployeeInfo.ConvertGenderToFlag(GenderTextString)
        Dim EmployeeIDText As Integer = EmployeeIDAutofill.Text
        Dim SqlInsertStr As String = $"INSERT INTO dbo.EmployeeInfo(EmployeeID, EmployeeName, GenderFlag, BelongingToFlag) VALUES({EmployeeIDText}, N'{EmployeeNameText}', {GenderText}, {BelongingToText});"
        EmployeeInfo.SubPostEmployeeInfo(ShowEmployeeInfo, SqlInsertStr, InitializePostEmployeeInputArray)
        ReturnShowEmployeeInfo()
    End Sub

    Private Sub ShowEmployeeInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShowEmployeeInfo.SelectedIndexChanged
        If ShowEmployeeInfo.SelectedItems.Count = 0 Then
            Return
        End If
        EmployeeInfo.SubSelectedIndexShowEmployeeInfo(ShowEmployeeInfo)
        ShowEmployeeInfo.Hide()
        EmployeeDetailPanel.Show()
        ChangeDisplayEmployeeInfoTab.Text = "一覧に戻る"

        If GetConstructorEmployeeDetail.EmployeeID = EmployeeDetailIDAutofill.Text Then
            Return
        Else
            EmployeeDetailNameTextBox.Text = GetConstructorEmployeeDetail.EmployeeName
            EmployeeDetailBelongingToSelectBox.Text = GetConstructorEmployeeDetail.EmployeeBelongingTo
            EmployeeDetailIDAutofill.Text = GetConstructorEmployeeDetail.EmployeeID
        End If
    End Sub

    Private Sub UpdateEmployeeInfo_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeInfo.Click
        Dim EmployeeNameText As String = EmployeeDetailNameTextBox.Text
        Dim BelongingToText As Integer = PublicFunction.ConvertBelongingToToFlag(EmployeeDetailBelongingToSelectBox.Text)
        Dim EmployeeIDText As Integer = EmployeeDetailIDAutofill.Text
        If Not EmployeeInfo.CheckPostEmployeeInput(EmployeeNameText, BelongingToText) Then
            Return
        End If
        EmployeeDetail.SubUpdateEmployeeInfo(EmployeeIDText, EmployeeNameText, BelongingToText)
    End Sub
End Class