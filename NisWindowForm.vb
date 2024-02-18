' インポート群、画面は非表示にするけど機能はそのまま残しておきたい
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports PublicFunction = EmployeeManagementAppForWin.PublicFunction
Imports PublicDbSetting = EmployeeManagementAppForWin.PublicDbSetting
Imports EmployeeManagementAppForWin.ConstructorEmployeeDetail
Imports EmployeeInfo = EmployeeManagementAppForWin.EmployeeInfoForm ' 機能はそのまま使う、画面は残すけど表示はしない
Imports EmployeeDetail = EmployeeManagementAppForWin.EmployeeDetailFrom ' 機能はそのまま使う、画面は残すけど表示はしない
Imports System.Text.RegularExpressions

Public Class NisWindowForm
    Private Sub ExecuteTabList(TabPage As TabPage)
        If TabPage.Name = EmployeeInfoTab.Name Then
            ShowEmployeeInfo.Items.Clear()
            EmployeeInfo.SubShowEmployeeInfo(ShowEmployeeInfo)
            EmployeeInfo.SubEmployeeIDAutofill(EmployeeIDAutofill)
        ElseIf TabPage.Name = CostInfoTab.Name Then
            ShowCostInfo.Items.Clear()
            Dim SqlStr As String = $"SELECT Employee.EmployeeID, EmployeeName, CostDate, PaymentName, CostContent, AdvancePaymentFlag, PaymentCost, CreatedAt " &
                                   $"FROM dbo.EmployeeInfo AS Employee " &
                                   $"INNER JOIN dbo.CostInfo AS Cost " &
                                   $"    ON Employee.EmployeeID = Cost.EmployeeID " &
                                   $"WHERE DeleteFlag = 0 " &
                                   $"ORDER BY CreatedAt ASC;"
            SubShowCostInfo(SqlStr, CostInfoTab)
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
            PublicFunction.ShowErrorMessageBox("設定されていない表示です")
        End If
    End Sub

    Private Sub ReturnShowCostInfo()
        If ShowCostInfo.Visible Then
            Return
        ElseIf PostCostInfoPanel.Visible Then
            PostCostInfoPanel.Hide()
            ShowCostInfo.Show()
            AnnotationDeleteCostInfo.Show()
            ChangeDisplayCostTab.Text = "登録"
        Else
            PublicFunction.ShowErrorMessageBox("設定されていない表示です")
        End If
    End Sub

    Private Function CheckCostInputText(CheckList(,) As Object) As Boolean
        For i As Integer = 0 To CheckList.GetLength(0) - 1
            If Not PublicFunction.CheckInputText(CheckList(i, 0)) Then
                MessageBox.Show(CheckList(i, 1), "登録失敗")
                Return False
            End If
        Next
        Return True
    End Function

    Private Function ShowDateErrorMessage() As Boolean
        MessageBox.Show($"年月日が範囲外です{vbCrLf}年月日を選び直してください", "登録失敗")
        Return False
    End Function

    Private Function CheckDateInputText(Year As Integer, Month As Integer, Day As Integer) As Boolean
        If Year < 2020 OrElse 2030 < Year Then
            Return ShowDateErrorMessage()
        End If
        If Month < 1 OrElse 12 < Month Then
            Return ShowDateErrorMessage()
        End If
        If Day < 1 Then
            Return ShowDateErrorMessage()
        End If

        Dim RgxMonthNotThirtyOne As New Regex("4|6|9|11")
        If Year Mod 4 = 0 AndAlso Month = 2 Then
            If 29 < Day Then
                Return ShowDateErrorMessage()
            End If
        ElseIf Month = 2 Then
            If 28 < Day Then
                Return ShowDateErrorMessage()
            End If
        ElseIf RgxMonthNotThirtyOne.IsMatch(Month) Then
            If 30 < Day Then
                Return ShowDateErrorMessage()
            End If
        Else
            If 31 < Day Then
                Return ShowDateErrorMessage()
            End If
        End If

        Return True
    End Function

    ' db connection
    Dim LocalDbConn As SqlConnection = PublicDbSetting.LocalDbConn

    Private Function FixFormatShowCostInfo(BeforeFixCostDate As Integer, BeforeFixAdvancePaymentFlag As Integer) As String()
        Dim AfterFixCostDate As String = BeforeFixCostDate.ToString.Substring(0, 4)
        If BeforeFixCostDate.ToString.Substring(4, 1) = 0 Then
            AfterFixCostDate += $"/{BeforeFixCostDate.ToString.Substring(5, 1)}"
        Else
            AfterFixCostDate += $"/{BeforeFixCostDate.ToString.Substring(4, 2)}"
        End If

        If BeforeFixCostDate.ToString.Substring(6, 1) = 0 Then
            AfterFixCostDate += $"/{BeforeFixCostDate.ToString.Substring(7, 1)}"
        Else
            AfterFixCostDate += $"/{BeforeFixCostDate.ToString.Substring(6, 2)}"
        End If

        Dim AfterFixAdvancePaymentFlag As String = If(BeforeFixAdvancePaymentFlag = 1, "○", "×")

        Return {AfterFixCostDate, AfterFixAdvancePaymentFlag}
    End Function

    Private Sub AddShowDbItems(SqlReadObject As SqlDataReader, AddControl As Control, TabPage As TabPage)
        If TypeOf AddControl Is ListView Then
            Dim AddListView As ListView = AddControl
            Dim AddItem As New ListViewItem($"{SqlReadObject(0)}", -1)
            For i As Integer = 1 To SqlReadObject.FieldCount - 1
                AddItem.SubItems.Add($"{SqlReadObject(i)}")
            Next

            If TabPage.Name = CostInfoTab.Name Then
                Dim AfterFixFormat As String() = FixFormatShowCostInfo(AddItem.SubItems(2).Text, AddItem.SubItems(5).Text)
                AddItem.SubItems(2).Text = AfterFixFormat(0)
                AddItem.SubItems(5).Text = AfterFixFormat(1)
            ElseIf TabPage.Name = EmployeeInfoTab.Name And EmployeeDetailPanel.Visible Then
            Else
                PublicFunction.ShowErrorMessageBox("Cost List not open")
            End If

            AddListView.Items.AddRange(New ListViewItem() {AddItem})
        ElseIf TypeOf AddControl Is ComboBox Then
            Dim AddComboBox As ComboBox = AddControl
            Dim AddObject As String = SqlReadObject(0)
            For i As Integer = 1 To SqlReadObject.FieldCount - 1
                AddObject += $" {SqlReadObject(i)}"
            Next
            AddComboBox.Items.Add(AddObject)
        End If
    End Sub

    Private Sub SubShowCostInfo(SqlStr As String, TabPage As TabPage)
        Try
            LocalDbConn.Open()
            If TabPage.Name = CostInfoTab.Name Then
                Dim SqlCostInfoRead As SqlDataReader = EmployeeInfo.ReturnDBLatestRow(LocalDbConn, SqlStr)
                While SqlCostInfoRead.Read()
                    AddShowDbItems(SqlCostInfoRead, ShowCostInfo, CostInfoTab)
                End While
                SqlCostInfoRead.Close()
            ElseIf TabPage.Name = EmployeeInfoTab.Name And EmployeeDetailPanel.Visible Then
                '           ' CostInfoテーブルのみ読み取り
                '          CostDbConn.Open()
                'While dummy.Read()
                'If dummy.DeleteFlag = 1 Then
                'Continue While
                'End If
                '               AddShowEmployeeDetailItems("dummy")
                'End While
            Else
                PublicFunction.ShowErrorMessageBox("Cost List not open")
            End If
        Catch ex As Exception
            PublicFunction.ShowErrorMessageBox(ex.Message)
        Finally
            PublicDbSetting.CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Private Sub SubPostCostInfo(SqlInsertStr As String, SqlSelectStr As String, ListView As ListView, TabPage As TabPage)
        Try
            LocalDbConn.Open()
            Dim DbTransaction As SqlTransaction
            DbTransaction = LocalDbConn.BeginTransaction()
            Try
                Dim SqlInsertDb As New SqlCommand(SqlInsertStr, LocalDbConn, DbTransaction)
                SqlInsertDb.ExecuteNonQuery()
                DbTransaction.Commit()
            Catch ex As Exception
                PublicFunction.ShowErrorMessageBox(ex.Message)
                DbTransaction.Rollback()
            End Try

            Dim SqlCostInfoLatestRowRead As SqlDataReader = EmployeeInfo.ReturnDBLatestRow(LocalDbConn, SqlSelectStr)
            SqlCostInfoLatestRowRead.Read()
            AddShowDbItems(SqlCostInfoLatestRowRead, ListView, TabPage)
            SqlCostInfoLatestRowRead.Close()
        Catch ex As Exception
            PublicFunction.ShowErrorMessageBox(ex.Message)
        Finally
            PublicDbSetting.CloseDBConnection(LocalDbConn)
        End Try
    End Sub

    Private Function DeleteCostInfoMessageBox(DeleteMessage As String) As DialogResult
        Dim DeleteCaption As String = "交通費削除"
        Dim DeleteButtons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim DeleteResult As DialogResult = MessageBox.Show(DeleteMessage, DeleteCaption, DeleteButtons)
        Return DeleteResult
    End Function

    Private Sub SubDeleteCostInfo(SqlDeleteStr As String, ListView As ListView)
        Try
            LocalDbConn.Open()
            Dim DbTransaction As SqlTransaction
            DbTransaction = LocalDbConn.BeginTransaction()
            Try
                Dim SqlDeleteDb As New SqlCommand(SqlDeleteStr, LocalDbConn, DbTransaction)
                SqlDeleteDb.ExecuteNonQuery()
                DbTransaction.Commit()
                ListView.SelectedItems(0).Remove()
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

    ' form designer function
    Private Sub ShownNisWindowForm() Handles Me.Shown
        MenuTabs.Controls.Clear()
        PostEmployeeInfoTab.Controls.Remove(PostEmployeeInfoPanel)
        EmployeeDetailTab.Controls.Remove(EmployeeDetailPanel)
        EmployeeInfoTab.Controls.Add(PostEmployeeInfoPanel)
        EmployeeInfoTab.Controls.Add(EmployeeDetailPanel)
        PostEmployeeInfoPanel.Hide()
        EmployeeDetailPanel.Hide()

        PostCostInfoTab.Controls.Remove(PostCostInfoPanel)
        CostInfoTab.Controls.Add(PostCostInfoPanel)
        PostCostInfoPanel.Hide()
    End Sub

    Private Sub OpenEmployeeTab_Click(sender As Object, e As EventArgs) Handles OpenEmployeeTab.Click
        OpenTabPage(EmployeeInfoTab)
        ReturnShowEmployeeInfo()
    End Sub

    Private Sub CloseEmployeeInfoTab_Click(sender As Object, e As EventArgs) Handles CloseEmployeeInfoTab.Click
        CloseTabPage(EmployeeInfoTab, "従業員一覧タブは開いていません")
    End Sub
    Private Sub OpenCostTab_Click(sender As Object, e As EventArgs) Handles OpenCostInfoTab.Click
        OpenTabPage(CostInfoTab)
        ReturnShowCostInfo()
    End Sub

    Private Sub CloseTransportExpensesTab_Click(sender As Object, e As EventArgs) Handles CloseCostInfoTab.Click
        CloseTabPage(CostInfoTab, "交通費一覧タブは開いていません")
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
            ShowCostInfo.Size = New Size(679, 353)
        Else
            SplitContainer.Panel1.Show()
            OpenAndCloseMenu.Text = "<"
            SplitContainer.SplitterDistance = 150
            MenuTabs.Size = New Size(640, 416)
            CloseEmployeeInfoTab.Location = New Point(551, 6)
            DummyButtonCloseEmployeeInfoTab2.Location = New Point(551, 6)
            CloseCostInfoTab.Location = New Point(551, 6)
            ShowCostInfo.Size = New Size(620, 353)
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
        Dim SqlInsertStr As String = $"INSERT INTO dbo.EmployeeInfo(EmployeeID, EmployeeName, GenderFlag, BelongingToFlag) " &
                                     $"VALUES({EmployeeIDText}, N'{EmployeeNameText}', {GenderText}, {BelongingToText});"
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

    Private Sub ChangeDisplayCostTab_Click(sender As Object, e As EventArgs) Handles ChangeDisplayCostTab.Click
        If ShowCostInfo.Visible Then
            ShowCostInfo.Hide()
            PostCostInfoPanel.Show()
            AnnotationDeleteCostInfo.Hide()
            ChangeDisplayCostTab.Text = "一覧に戻る"
            Try
                CostEmpoyeeId.Items.Clear()
                LocalDbConn.Open()
                Dim SplReadStr As String = $"SELECT EmployeeID, EmployeeName " &
                                           $"FROM dbo.EmployeeInfo " &
                                           $"ORDER BY EmployeeID ASC;"
                Dim SqlEmployeeInfoRead As SqlDataReader = EmployeeInfo.ReturnDBLatestRow(LocalDbConn, SplReadStr)
                While SqlEmployeeInfoRead.Read()
                    AddShowDbItems(SqlEmployeeInfoRead, CostEmpoyeeId, CostInfoTab)
                End While
                SqlEmployeeInfoRead.Close()

                ' 入力欄初期化
                CostEmpoyeeId.Text = CostEmpoyeeId.Items(0)
                CostYear.Text = "2024"
                CostMonth.Text = "1"
                CostDay.Text = "1"
                PaymentName.Text = ""
                CostContent.Text = ""
                AdvancePaymentOn.Checked = True
                PaymentCost.Text = ""
            Catch ex As Exception
                PublicFunction.ShowErrorMessageBox(ex.Message)
            Finally
                PublicDbSetting.CloseDBConnection(LocalDbConn)
            End Try
        Else
            ReturnShowCostInfo()
        End If
    End Sub

    Private Sub PostCostInfo_Click(sender As Object, e As EventArgs) Handles PostCostInfo.Click
        ' 入力内容を確認しながら型変換を実施
        Dim CheckList As Object(,) = {
            {CostEmpoyeeId.Text, "従業員を選んでください"},
            {CostYear.Text, "年を選んでください"},
            {CostMonth.Text, "月を選んでください"},
            {CostDay.Text, "日を選んでください"},
            {PaymentName.Text, "支払先を入力してください"},
            {PaymentCost.Text, "金額を入力してください"}
        }
        If Not CheckCostInputText(CheckList) Then
            Return
        End If

        Dim EmployeeId As Integer
        Try
            EmployeeId = CInt(CostEmpoyeeId.Text.Substring(0, 4))
        Catch ex As Exception
            MessageBox.Show("選択肢から従業員を選んでください", "登録失敗")
            Return
        End Try

        Dim CostDate As Integer
        Try
            If Not CheckDateInputText(CostYear.Text, CostMonth.Text, CostDay.Text) Then
                Return
            End If
            Dim FixCostMonth As String
            Dim FixCostDay As String
            Dim RgxOneDigit As New Regex("\d{2}")
            If RgxOneDigit.IsMatch(CostMonth.Text) Then
                FixCostMonth = CostMonth.Text
            Else
                FixCostMonth = "0" + CostMonth.Text
            End If

            If RgxOneDigit.IsMatch(CostDay.Text) Then
                FixCostDay = CostDay.Text
            Else
                FixCostDay = "0" + CostDay.Text
            End If
            CostDate = CostYear.Text + FixCostMonth + FixCostDay
        Catch ex As Exception
            MessageBox.Show("選択肢から年月日を選んでください", "登録失敗")
            Return
        End Try

        Dim PaymentCostText As Integer
        Try
            PaymentCostText = PaymentCost.Text
            If 0 > PaymentCostText Then
                MessageBox.Show("金額は0以上で入力してください", "登録失敗")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("金額は数字で入力してください", "登録失敗")
            Return
        End Try
        Dim PaymentNameText As String = PaymentName.Text
        Dim CostContentText As String = CostContent.Text
        Dim AdvancePaymentFlag As Integer = If(AdvancePaymentOn.Checked(), 1, 0)
        Dim CreatedAt As DateTime = DateTime.Now
        Dim FixDateTimeDate As String = CreatedAt.ToString.Substring(0, 4) + CreatedAt.ToString.Substring(5, 2) + CreatedAt.ToString.Substring(8, 2)
        Dim FixDateTimeTime As String
        If CreatedAt.Hour < 10 Then ' 時間が1桁の場合の0埋め判定
            FixDateTimeTime = "0" + CreatedAt.ToString.Substring(11, 1) + CreatedAt.ToString.Substring(13, 2) + CreatedAt.ToString.Substring(16, 2)
        Else
            FixDateTimeTime = CreatedAt.ToString.Substring(11, 2) + CreatedAt.ToString.Substring(14, 2) + CreatedAt.ToString.Substring(17, 2)
        End If
        Dim FixCreatedAt As Long = FixDateTimeDate + FixDateTimeTime

        Dim SqlInsertStr As String = $"INSERT INTO dbo.CostInfo(EmployeeId, CostDate, PaymentName, CostContent, AdvancePaymentFlag, PaymentCost, CreatedAt, DeleteFlag) " &
                               $"VALUES({EmployeeId}, {CostDate}, N'{PaymentNameText}', N'{CostContentText}', {AdvancePaymentFlag}, {PaymentCostText}, {FixCreatedAt}, 0);"

        Dim SqlSelectStr As String = $"SELECT Top(1) Employee.EmployeeID, EmployeeName, CostDate, PaymentName, CostContent, AdvancePaymentFlag, PaymentCost, CreatedAt " &
                                     $"FROM dbo.EmployeeInfo AS Employee " &
                                     $"INNER JOIN dbo.CostInfo AS Cost " &
                                     $"    ON Employee.EmployeeID = Cost.EmployeeID " &
                                     $"WHERE DeleteFlag = 0 " &
                                     $"ORDER BY CreatedAt DESC;"

        SubPostCostInfo(SqlInsertStr, SqlSelectStr, ShowCostInfo, CostInfoTab)
        ReturnShowCostInfo()
    End Sub

    'Private Sub ShowCostInfo_ItemSelectionChanged(sender As Object, e As EventArgs) Handles ShowCostInfo.ItemSelectionChanged
    'Private Sub ShowCostInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShowCostInfo.SelectedIndexChanged
    Private Sub ShowCostInfo_ItemActivate(sender As Object, e As EventArgs) Handles ShowCostInfo.ItemActivate
        If ShowCostInfo.SelectedItems.Count = 0 Then
            Return
        End If

        Dim SelectedItemInfo As ListViewItem = ShowCostInfo.SelectedItems(0)
        Dim DeleteMessage As String = $"{SelectedItemInfo.SubItems(2).Text}の支払先: {SelectedItemInfo.SubItems(3).Text}を削除します{vbCrLf}" &
                                      $"よろしいですか？"
        Dim DeleteResult As DialogResult = DeleteCostInfoMessageBox(DeleteMessage)

        If DeleteResult = System.Windows.Forms.DialogResult.Yes Then
            ' Dim SqlStr As String = $"UPDATE dbo.CostInfo " &
            '             $"SET DeleteFlag = 1 " &
            '             $"WHERE EmployeeID = {SelectedItemInfo.SubItems(0)} " &
            '             $"      AND CreatedAt = {SelectedItemInfo.SubItems(7)};"
            Dim SqlStr As String = $"DELETE FROM dbo.CostInfo " &
                                   $"WHERE EmployeeID = {SelectedItemInfo.SubItems(0).Text} " &
                                   $"      AND CreatedAt = {SelectedItemInfo.SubItems(7).Text};"
            SubDeleteCostInfo(SqlStr, ShowCostInfo)
        End If

        AddHandler Application.Idle, AddressOf ShowCostInfoSelectedIndexChanged_Idle
    End Sub

    Private Sub ShowCostInfoSelectedIndexChanged_Idle(sender As Object, e As EventArgs)
        If Not ShowCostInfo.SelectedItems.Count = 0 Then
            ShowCostInfo.SelectedItems(0).Selected = False
        End If

        RemoveHandler Application.Idle, AddressOf ShowCostInfoSelectedIndexChanged_Idle
    End Sub
End Class