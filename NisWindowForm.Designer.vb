<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NisWindowForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        SplitContainer = New SplitContainer()
        SearchEmployeeTextBox = New TextBox()
        SearchEmployee = New Button()
        OpenCostInfoTab = New Button()
        OpenEmployeeTab = New Button()
        Search = New Label()
        Menu = New Label()
        OpenAndCloseMenu = New Button()
        MenuTabs = New TabControl()
        EmployeeInfoTab = New TabPage()
        ShowEmployeeInfo = New ListView()
        EmployeeIDColumn = New ColumnHeader()
        EmployeeNameColumn = New ColumnHeader()
        GenderColumn = New ColumnHeader()
        BelongingToColumn = New ColumnHeader()
        ChangeDisplayEmployeeInfoTab = New Button()
        CloseEmployeeInfoTab = New Button()
        EmployeeDetailTab = New TabPage()
        DummyButtonShowEmployeeDetail = New Button()
        DummyButtonCloseEmployeeInfoTab2 = New Button()
        EmployeeDetailPanel = New Panel()
        EmployeeDetailBelongingToSelectBox = New ComboBox()
        EmployeeDetailNameTextBox = New TextBox()
        EmployeeDetailIDAutofill = New Label()
        UpdateEmployeeInfo = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        CostInfoTab = New TabPage()
        CloseCostInfoTab = New Button()
        PostEmployeeInfoFormTab = New TabPage()
        DummyButtonCloseEmployeeInfoTab = New Button()
        DummyButtonPostEmployeeInfo = New Button()
        PostEmployeeInfoPanel = New Panel()
        BelongingToSelectBox = New ComboBox()
        EmployeeNameTextBox = New TextBox()
        Female = New RadioButton()
        Male = New RadioButton()
        EmployeeIDAutofill = New Label()
        PostEmployeeInfo = New Button()
        EmployeeID = New Label()
        BelongingTo = New Label()
        Gender = New Label()
        EmployeeName = New Label()
        CType(SplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer.Panel1.SuspendLayout()
        SplitContainer.Panel2.SuspendLayout()
        SplitContainer.SuspendLayout()
        MenuTabs.SuspendLayout()
        EmployeeInfoTab.SuspendLayout()
        EmployeeDetailTab.SuspendLayout()
        EmployeeDetailPanel.SuspendLayout()
        CostInfoTab.SuspendLayout()
        PostEmployeeInfoFormTab.SuspendLayout()
        PostEmployeeInfoPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer
        ' 
        SplitContainer.Dock = DockStyle.Fill
        SplitContainer.IsSplitterFixed = True
        SplitContainer.Location = New Point(0, 0)
        SplitContainer.Name = "SplitContainer"
        ' 
        ' SplitContainer.Panel1
        ' 
        SplitContainer.Panel1.Controls.Add(SearchEmployeeTextBox)
        SplitContainer.Panel1.Controls.Add(SearchEmployee)
        SplitContainer.Panel1.Controls.Add(OpenCostInfoTab)
        SplitContainer.Panel1.Controls.Add(OpenEmployeeTab)
        SplitContainer.Panel1.Controls.Add(Search)
        SplitContainer.Panel1.Controls.Add(Menu)
        ' 
        ' SplitContainer.Panel2
        ' 
        SplitContainer.Panel2.Controls.Add(OpenAndCloseMenu)
        SplitContainer.Panel2.Controls.Add(MenuTabs)
        SplitContainer.Size = New Size(800, 450)
        SplitContainer.SplitterDistance = 150
        SplitContainer.TabIndex = 0
        ' 
        ' SearchEmployeeTextBox
        ' 
        SearchEmployeeTextBox.Location = New Point(25, 243)
        SearchEmployeeTextBox.Name = "SearchEmployeeTextBox"
        SearchEmployeeTextBox.PlaceholderText = "ID・氏名"
        SearchEmployeeTextBox.Size = New Size(100, 23)
        SearchEmployeeTextBox.TabIndex = 8
        ' 
        ' SearchEmployee
        ' 
        SearchEmployee.Location = New Point(38, 272)
        SearchEmployee.Name = "SearchEmployee"
        SearchEmployee.Size = New Size(75, 23)
        SearchEmployee.TabIndex = 7
        SearchEmployee.Text = "従業員検索"
        SearchEmployee.UseVisualStyleBackColor = True
        ' 
        ' OpenCostInfoTab
        ' 
        OpenCostInfoTab.Location = New Point(39, 90)
        OpenCostInfoTab.Name = "OpenCostInfoTab"
        OpenCostInfoTab.Size = New Size(75, 23)
        OpenCostInfoTab.TabIndex = 6
        OpenCostInfoTab.Text = "交通費管理"
        OpenCostInfoTab.UseVisualStyleBackColor = True
        ' 
        ' OpenEmployeeTab
        ' 
        OpenEmployeeTab.Location = New Point(38, 47)
        OpenEmployeeTab.Name = "OpenEmployeeTab"
        OpenEmployeeTab.Size = New Size(75, 23)
        OpenEmployeeTab.TabIndex = 5
        OpenEmployeeTab.Text = "従業員管理"
        OpenEmployeeTab.UseVisualStyleBackColor = True
        ' 
        ' Search
        ' 
        Search.AutoSize = True
        Search.Location = New Point(21, 210)
        Search.Name = "Search"
        Search.Size = New Size(31, 15)
        Search.TabIndex = 4
        Search.Text = "検索"
        ' 
        ' Menu
        ' 
        Menu.AutoSize = True
        Menu.Location = New Point(21, 8)
        Menu.Name = "Menu"
        Menu.Size = New Size(40, 15)
        Menu.TabIndex = 2
        Menu.Text = "メニュー"
        ' 
        ' OpenAndCloseMenu
        ' 
        OpenAndCloseMenu.Location = New Point(3, 3)
        OpenAndCloseMenu.Name = "OpenAndCloseMenu"
        OpenAndCloseMenu.Size = New Size(22, 24)
        OpenAndCloseMenu.TabIndex = 1
        OpenAndCloseMenu.Text = "<"
        OpenAndCloseMenu.UseVisualStyleBackColor = True
        ' 
        ' MenuTabs
        ' 
        MenuTabs.Controls.Add(EmployeeInfoTab)
        MenuTabs.Controls.Add(EmployeeDetailTab)
        MenuTabs.Controls.Add(CostInfoTab)
        MenuTabs.Controls.Add(PostEmployeeInfoFormTab)
        MenuTabs.Location = New Point(3, 31)
        MenuTabs.Name = "MenuTabs"
        MenuTabs.SelectedIndex = 0
        MenuTabs.Size = New Size(640, 416)
        MenuTabs.TabIndex = 0
        ' 
        ' EmployeeInfoTab
        ' 
        EmployeeInfoTab.Controls.Add(ShowEmployeeInfo)
        EmployeeInfoTab.Controls.Add(ChangeDisplayEmployeeInfoTab)
        EmployeeInfoTab.Controls.Add(CloseEmployeeInfoTab)
        EmployeeInfoTab.Location = New Point(4, 24)
        EmployeeInfoTab.Name = "EmployeeInfoTab"
        EmployeeInfoTab.Padding = New Padding(3)
        EmployeeInfoTab.Size = New Size(632, 388)
        EmployeeInfoTab.TabIndex = 0
        EmployeeInfoTab.Text = "従業員"
        EmployeeInfoTab.UseVisualStyleBackColor = True
        ' 
        ' ShowEmployeeInfo
        ' 
        ShowEmployeeInfo.Activation = ItemActivation.OneClick
        ShowEmployeeInfo.Columns.AddRange(New ColumnHeader() {EmployeeIDColumn, EmployeeNameColumn, GenderColumn, BelongingToColumn})
        ShowEmployeeInfo.FullRowSelect = True
        ShowEmployeeInfo.Location = New Point(6, 35)
        ShowEmployeeInfo.Name = "ShowEmployeeInfo"
        ShowEmployeeInfo.Size = New Size(364, 353)
        ShowEmployeeInfo.TabIndex = 12
        ShowEmployeeInfo.UseCompatibleStateImageBehavior = False
        ShowEmployeeInfo.View = View.Details
        ' 
        ' EmployeeIDColumn
        ' 
        EmployeeIDColumn.Text = "従業員ID"
        EmployeeIDColumn.Width = 75
        ' 
        ' EmployeeNameColumn
        ' 
        EmployeeNameColumn.Text = "氏名"
        EmployeeNameColumn.Width = 150
        ' 
        ' GenderColumn
        ' 
        GenderColumn.Text = "性別"
        GenderColumn.Width = 55
        ' 
        ' BelongingToColumn
        ' 
        BelongingToColumn.Text = "所属部署"
        BelongingToColumn.Width = 80
        ' 
        ' ChangeDisplayEmployeeInfoTab
        ' 
        ChangeDisplayEmployeeInfoTab.Location = New Point(6, 6)
        ChangeDisplayEmployeeInfoTab.Name = "ChangeDisplayEmployeeInfoTab"
        ChangeDisplayEmployeeInfoTab.Size = New Size(75, 23)
        ChangeDisplayEmployeeInfoTab.TabIndex = 11
        ChangeDisplayEmployeeInfoTab.Text = "登録"
        ChangeDisplayEmployeeInfoTab.UseVisualStyleBackColor = True
        ' 
        ' CloseEmployeeInfoTab
        ' 
        CloseEmployeeInfoTab.Location = New Point(551, 6)
        CloseEmployeeInfoTab.Name = "CloseEmployeeInfoTab"
        CloseEmployeeInfoTab.Size = New Size(75, 23)
        CloseEmployeeInfoTab.TabIndex = 0
        CloseEmployeeInfoTab.Text = "閉じる"
        CloseEmployeeInfoTab.UseVisualStyleBackColor = True
        ' 
        ' EmployeeDetailTab
        ' 
        EmployeeDetailTab.Controls.Add(DummyButtonShowEmployeeDetail)
        EmployeeDetailTab.Controls.Add(DummyButtonCloseEmployeeInfoTab2)
        EmployeeDetailTab.Controls.Add(EmployeeDetailPanel)
        EmployeeDetailTab.Location = New Point(4, 24)
        EmployeeDetailTab.Name = "EmployeeDetailTab"
        EmployeeDetailTab.Padding = New Padding(3)
        EmployeeDetailTab.Size = New Size(632, 388)
        EmployeeDetailTab.TabIndex = 1
        EmployeeDetailTab.Text = "従業員詳細"
        EmployeeDetailTab.UseVisualStyleBackColor = True
        ' 
        ' DummyButtonShowEmployeeDetail
        ' 
        DummyButtonShowEmployeeDetail.Location = New Point(6, 6)
        DummyButtonShowEmployeeDetail.Name = "DummyButtonShowEmployeeDetail"
        DummyButtonShowEmployeeDetail.Size = New Size(75, 23)
        DummyButtonShowEmployeeDetail.TabIndex = 12
        DummyButtonShowEmployeeDetail.Text = "一覧に戻る"
        DummyButtonShowEmployeeDetail.UseVisualStyleBackColor = True
        ' 
        ' DummyButtonCloseEmployeeInfoTab2
        ' 
        DummyButtonCloseEmployeeInfoTab2.Location = New Point(551, 6)
        DummyButtonCloseEmployeeInfoTab2.Name = "DummyButtonCloseEmployeeInfoTab2"
        DummyButtonCloseEmployeeInfoTab2.Size = New Size(75, 23)
        DummyButtonCloseEmployeeInfoTab2.TabIndex = 1
        DummyButtonCloseEmployeeInfoTab2.Text = "閉じる"
        DummyButtonCloseEmployeeInfoTab2.UseVisualStyleBackColor = True
        ' 
        ' EmployeeDetailPanel
        ' 
        EmployeeDetailPanel.Controls.Add(EmployeeDetailBelongingToSelectBox)
        EmployeeDetailPanel.Controls.Add(EmployeeDetailNameTextBox)
        EmployeeDetailPanel.Controls.Add(EmployeeDetailIDAutofill)
        EmployeeDetailPanel.Controls.Add(UpdateEmployeeInfo)
        EmployeeDetailPanel.Controls.Add(Label2)
        EmployeeDetailPanel.Controls.Add(Label3)
        EmployeeDetailPanel.Controls.Add(Label5)
        EmployeeDetailPanel.Location = New Point(0, 0)
        EmployeeDetailPanel.Name = "EmployeeDetailPanel"
        EmployeeDetailPanel.Size = New Size(632, 388)
        EmployeeDetailPanel.TabIndex = 13
        ' 
        ' EmployeeDetailBelongingToSelectBox
        ' 
        EmployeeDetailBelongingToSelectBox.BackColor = SystemColors.Window
        EmployeeDetailBelongingToSelectBox.FormattingEnabled = True
        EmployeeDetailBelongingToSelectBox.Items.AddRange(New Object() {"事業部", "営業部"})
        EmployeeDetailBelongingToSelectBox.Location = New Point(83, 76)
        EmployeeDetailBelongingToSelectBox.Name = "EmployeeDetailBelongingToSelectBox"
        EmployeeDetailBelongingToSelectBox.Size = New Size(91, 23)
        EmployeeDetailBelongingToSelectBox.TabIndex = 35
        EmployeeDetailBelongingToSelectBox.Text = "事業部"
        ' 
        ' EmployeeDetailNameTextBox
        ' 
        EmployeeDetailNameTextBox.Location = New Point(82, 37)
        EmployeeDetailNameTextBox.Name = "EmployeeDetailNameTextBox"
        EmployeeDetailNameTextBox.PlaceholderText = "入力してください"
        EmployeeDetailNameTextBox.Size = New Size(150, 23)
        EmployeeDetailNameTextBox.TabIndex = 34
        ' 
        ' EmployeeDetailIDAutofill
        ' 
        EmployeeDetailIDAutofill.AutoSize = True
        EmployeeDetailIDAutofill.Location = New Point(83, 118)
        EmployeeDetailIDAutofill.Name = "EmployeeDetailIDAutofill"
        EmployeeDetailIDAutofill.Size = New Size(31, 15)
        EmployeeDetailIDAutofill.TabIndex = 31
        EmployeeDetailIDAutofill.Text = "1000"
        ' 
        ' UpdateEmployeeInfo
        ' 
        UpdateEmployeeInfo.Location = New Point(6, 157)
        UpdateEmployeeInfo.Name = "UpdateEmployeeInfo"
        UpdateEmployeeInfo.Size = New Size(75, 23)
        UpdateEmployeeInfo.TabIndex = 30
        UpdateEmployeeInfo.Text = "更新"
        UpdateEmployeeInfo.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 29
        Label2.Text = "従業員ID："
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 28
        Label3.Text = "所属部署："
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 26
        Label5.Text = "氏名："
        ' 
        ' CostInfoTab
        ' 
        CostInfoTab.Controls.Add(CloseCostInfoTab)
        CostInfoTab.Location = New Point(4, 24)
        CostInfoTab.Name = "CostInfoTab"
        CostInfoTab.Size = New Size(632, 388)
        CostInfoTab.TabIndex = 2
        CostInfoTab.Text = "交通費"
        CostInfoTab.UseVisualStyleBackColor = True
        ' 
        ' CloseCostInfoTab
        ' 
        CloseCostInfoTab.Location = New Point(551, 6)
        CloseCostInfoTab.Name = "CloseCostInfoTab"
        CloseCostInfoTab.Size = New Size(75, 23)
        CloseCostInfoTab.TabIndex = 2
        CloseCostInfoTab.Text = "閉じる"
        CloseCostInfoTab.UseVisualStyleBackColor = True
        ' 
        ' PostEmployeeInfoFormTab
        ' 
        PostEmployeeInfoFormTab.Controls.Add(DummyButtonCloseEmployeeInfoTab)
        PostEmployeeInfoFormTab.Controls.Add(DummyButtonPostEmployeeInfo)
        PostEmployeeInfoFormTab.Controls.Add(PostEmployeeInfoPanel)
        PostEmployeeInfoFormTab.Location = New Point(4, 24)
        PostEmployeeInfoFormTab.Name = "PostEmployeeInfoFormTab"
        PostEmployeeInfoFormTab.Padding = New Padding(3)
        PostEmployeeInfoFormTab.Size = New Size(632, 388)
        PostEmployeeInfoFormTab.TabIndex = 3
        PostEmployeeInfoFormTab.Text = "従業員追加"
        PostEmployeeInfoFormTab.UseVisualStyleBackColor = True
        ' 
        ' DummyButtonCloseEmployeeInfoTab
        ' 
        DummyButtonCloseEmployeeInfoTab.Location = New Point(551, 6)
        DummyButtonCloseEmployeeInfoTab.Name = "DummyButtonCloseEmployeeInfoTab"
        DummyButtonCloseEmployeeInfoTab.Size = New Size(75, 23)
        DummyButtonCloseEmployeeInfoTab.TabIndex = 13
        DummyButtonCloseEmployeeInfoTab.Text = "閉じる"
        DummyButtonCloseEmployeeInfoTab.UseVisualStyleBackColor = True
        ' 
        ' DummyButtonPostEmployeeInfo
        ' 
        DummyButtonPostEmployeeInfo.Location = New Point(6, 6)
        DummyButtonPostEmployeeInfo.Name = "DummyButtonPostEmployeeInfo"
        DummyButtonPostEmployeeInfo.Size = New Size(75, 23)
        DummyButtonPostEmployeeInfo.TabIndex = 12
        DummyButtonPostEmployeeInfo.Text = "一覧に戻る"
        DummyButtonPostEmployeeInfo.UseVisualStyleBackColor = True
        ' 
        ' PostEmployeeInfoPanel
        ' 
        PostEmployeeInfoPanel.Controls.Add(BelongingToSelectBox)
        PostEmployeeInfoPanel.Controls.Add(EmployeeNameTextBox)
        PostEmployeeInfoPanel.Controls.Add(Female)
        PostEmployeeInfoPanel.Controls.Add(Male)
        PostEmployeeInfoPanel.Controls.Add(EmployeeIDAutofill)
        PostEmployeeInfoPanel.Controls.Add(PostEmployeeInfo)
        PostEmployeeInfoPanel.Controls.Add(EmployeeID)
        PostEmployeeInfoPanel.Controls.Add(BelongingTo)
        PostEmployeeInfoPanel.Controls.Add(Gender)
        PostEmployeeInfoPanel.Controls.Add(EmployeeName)
        PostEmployeeInfoPanel.Location = New Point(0, 0)
        PostEmployeeInfoPanel.Name = "PostEmployeeInfoPanel"
        PostEmployeeInfoPanel.Size = New Size(632, 388)
        PostEmployeeInfoPanel.TabIndex = 14
        ' 
        ' BelongingToSelectBox
        ' 
        BelongingToSelectBox.BackColor = SystemColors.Window
        BelongingToSelectBox.FormattingEnabled = True
        BelongingToSelectBox.Items.AddRange(New Object() {"事業部", "営業部"})
        BelongingToSelectBox.Location = New Point(83, 115)
        BelongingToSelectBox.Name = "BelongingToSelectBox"
        BelongingToSelectBox.Size = New Size(91, 23)
        BelongingToSelectBox.TabIndex = 25
        BelongingToSelectBox.Text = "事業部"
        ' 
        ' EmployeeNameTextBox
        ' 
        EmployeeNameTextBox.Location = New Point(82, 37)
        EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        EmployeeNameTextBox.PlaceholderText = "入力してください"
        EmployeeNameTextBox.Size = New Size(150, 23)
        EmployeeNameTextBox.TabIndex = 24
        ' 
        ' Female
        ' 
        Female.AutoSize = True
        Female.Location = New Point(138, 77)
        Female.Name = "Female"
        Female.Size = New Size(49, 19)
        Female.TabIndex = 23
        Female.TabStop = True
        Female.Text = "女性"
        Female.UseVisualStyleBackColor = True
        ' 
        ' Male
        ' 
        Male.AutoSize = True
        Male.Checked = True
        Male.Location = New Point(83, 77)
        Male.Name = "Male"
        Male.Size = New Size(49, 19)
        Male.TabIndex = 22
        Male.TabStop = True
        Male.Text = "男性"
        Male.UseVisualStyleBackColor = True
        ' 
        ' EmployeeIDAutofill
        ' 
        EmployeeIDAutofill.AutoSize = True
        EmployeeIDAutofill.Location = New Point(82, 157)
        EmployeeIDAutofill.Name = "EmployeeIDAutofill"
        EmployeeIDAutofill.Size = New Size(31, 15)
        EmployeeIDAutofill.TabIndex = 21
        EmployeeIDAutofill.Text = "1000"
        ' 
        ' PostEmployeeInfo
        ' 
        PostEmployeeInfo.Location = New Point(6, 196)
        PostEmployeeInfo.Name = "PostEmployeeInfo"
        PostEmployeeInfo.Size = New Size(75, 23)
        PostEmployeeInfo.TabIndex = 20
        PostEmployeeInfo.Text = "登録"
        PostEmployeeInfo.UseVisualStyleBackColor = True
        ' 
        ' EmployeeID
        ' 
        EmployeeID.AutoSize = True
        EmployeeID.Location = New Point(10, 157)
        EmployeeID.Name = "EmployeeID"
        EmployeeID.Size = New Size(66, 15)
        EmployeeID.TabIndex = 19
        EmployeeID.Text = "従業員ID："
        ' 
        ' BelongingTo
        ' 
        BelongingTo.AutoSize = True
        BelongingTo.Location = New Point(10, 118)
        BelongingTo.Name = "BelongingTo"
        BelongingTo.Size = New Size(67, 15)
        BelongingTo.TabIndex = 18
        BelongingTo.Text = "所属部署："
        ' 
        ' Gender
        ' 
        Gender.AutoSize = True
        Gender.Location = New Point(10, 79)
        Gender.Name = "Gender"
        Gender.Size = New Size(43, 15)
        Gender.TabIndex = 17
        Gender.Text = "性別："
        ' 
        ' EmployeeName
        ' 
        EmployeeName.AutoSize = True
        EmployeeName.Location = New Point(10, 40)
        EmployeeName.Name = "EmployeeName"
        EmployeeName.Size = New Size(43, 15)
        EmployeeName.TabIndex = 16
        EmployeeName.Text = "氏名："
        ' 
        ' NisWindowForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer)
        Name = "NisWindowForm"
        Text = "従業員情報管理アプリ"
        SplitContainer.Panel1.ResumeLayout(False)
        SplitContainer.Panel1.PerformLayout()
        SplitContainer.Panel2.ResumeLayout(False)
        CType(SplitContainer, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer.ResumeLayout(False)
        MenuTabs.ResumeLayout(False)
        EmployeeInfoTab.ResumeLayout(False)
        EmployeeDetailTab.ResumeLayout(False)
        EmployeeDetailPanel.ResumeLayout(False)
        EmployeeDetailPanel.PerformLayout()
        CostInfoTab.ResumeLayout(False)
        PostEmployeeInfoFormTab.ResumeLayout(False)
        PostEmployeeInfoPanel.ResumeLayout(False)
        PostEmployeeInfoPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents MenuTabs As TabControl
    Friend WithEvents EmployeeInfoTab As TabPage
    Friend WithEvents EmployeeDetailTab As TabPage
    Friend WithEvents OpenAndCloseMenu As Button
    Friend WithEvents Menu As Label
    Friend WithEvents Search As Label
    Friend WithEvents SearchEmployeeTextBox As TextBox
    Friend WithEvents SearchEmployee As Button
    Friend WithEvents OpenCostInfoTab As Button
    Friend WithEvents OpenEmployeeTab As Button
    Friend WithEvents CostInfoTab As TabPage
    Friend WithEvents CloseEmployeeInfoTab As Button
    Friend WithEvents DummyButtonCloseEmployeeInfoTab2 As Button
    Friend WithEvents CloseCostInfoTab As Button
    Friend WithEvents ChangeDisplayEmployeeInfoTab As Button
    Friend WithEvents ShowEmployeeInfo As ListView
    Friend WithEvents EmployeeIDColumn As ColumnHeader
    Friend WithEvents EmployeeNameColumn As ColumnHeader
    Friend WithEvents GenderColumn As ColumnHeader
    Friend WithEvents BelongingToColumn As ColumnHeader
    Friend WithEvents PostEmployeeInfoFormTab As TabPage
    Friend WithEvents DummyButtonCloseEmployeeInfoTab As Button
    Friend WithEvents DummyButtonPostEmployeeInfo As Button
    Friend WithEvents DummyButtonShowEmployeeDetail As Button
    Friend WithEvents PostEmployeeInfoPanel As Panel
    Friend WithEvents BelongingToSelectBox As ComboBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents Female As RadioButton
    Friend WithEvents Male As RadioButton
    Friend WithEvents EmployeeIDAutofill As Label
    Friend WithEvents PostEmployeeInfo As Button
    Friend WithEvents EmployeeID As Label
    Friend WithEvents BelongingTo As Label
    Friend WithEvents Gender As Label
    Friend WithEvents EmployeeName As Label
    Friend WithEvents EmployeeDetailPanel As Panel
    Friend WithEvents EmployeeDetailBelongingToSelectBox As ComboBox
    Friend WithEvents EmployeeDetailNameTextBox As TextBox
    Friend WithEvents EmployeeDetailIDAutofill As Label
    Friend WithEvents UpdateEmployeeInfo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
