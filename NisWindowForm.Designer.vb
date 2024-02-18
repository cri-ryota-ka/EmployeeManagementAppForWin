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
        CostInfoCreatedAtColumn = New ColumnHeader()
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
        ShowCostInfo = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        AnnotationDeleteCostInfo = New Label()
        ChangeDisplayCostTab = New Button()
        CloseCostInfoTab = New Button()
        PostEmployeeInfoTab = New TabPage()
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
        PostCostInfoTab = New TabPage()
        DummyCloseCostInfoTab = New Button()
        DummyChangeDisplayCostTab = New Button()
        PostCostInfoPanel = New Panel()
        PaymentCost = New TextBox()
        CostContent = New TextBox()
        CostDay = New ComboBox()
        CostMonth = New ComboBox()
        CostYear = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        CostEmpoyeeId = New ComboBox()
        PaymentName = New TextBox()
        AdvancePaymentOff = New RadioButton()
        AdvancePaymentOn = New RadioButton()
        Label1 = New Label()
        PostCostInfo = New Button()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(SplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer.Panel1.SuspendLayout()
        SplitContainer.Panel2.SuspendLayout()
        SplitContainer.SuspendLayout()
        MenuTabs.SuspendLayout()
        EmployeeInfoTab.SuspendLayout()
        EmployeeDetailTab.SuspendLayout()
        EmployeeDetailPanel.SuspendLayout()
        CostInfoTab.SuspendLayout()
        PostEmployeeInfoTab.SuspendLayout()
        PostEmployeeInfoPanel.SuspendLayout()
        PostCostInfoTab.SuspendLayout()
        PostCostInfoPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' CostInfoCreatedAtColumn
        ' 
        CostInfoCreatedAtColumn.Text = "CreatedAt"
        CostInfoCreatedAtColumn.Width = 0
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
        MenuTabs.Controls.Add(PostEmployeeInfoTab)
        MenuTabs.Controls.Add(PostCostInfoTab)
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
        ShowEmployeeInfo.Size = New Size(314, 353)
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
        EmployeeNameColumn.Width = 100
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
        CostInfoTab.Controls.Add(ShowCostInfo)
        CostInfoTab.Controls.Add(AnnotationDeleteCostInfo)
        CostInfoTab.Controls.Add(ChangeDisplayCostTab)
        CostInfoTab.Controls.Add(CloseCostInfoTab)
        CostInfoTab.Location = New Point(4, 24)
        CostInfoTab.Name = "CostInfoTab"
        CostInfoTab.Size = New Size(632, 388)
        CostInfoTab.TabIndex = 2
        CostInfoTab.Text = "交通費"
        CostInfoTab.UseVisualStyleBackColor = True
        ' 
        ' ShowCostInfo
        ' 
        ShowCostInfo.Activation = ItemActivation.OneClick
        ShowCostInfo.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, CostInfoCreatedAtColumn})
        ShowCostInfo.FullRowSelect = True
        ShowCostInfo.Location = New Point(6, 35)
        ShowCostInfo.Name = "ShowCostInfo"
        ShowCostInfo.Size = New Size(620, 353)
        ShowCostInfo.TabIndex = 14
        ShowCostInfo.UseCompatibleStateImageBehavior = False
        ShowCostInfo.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "従業員ID"
        ColumnHeader1.Width = 75
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "氏名"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "支払日"
        ColumnHeader3.Width = 75
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "支払先"
        ColumnHeader4.Width = 150
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "内容"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "立替"
        ColumnHeader6.Width = 50
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "金額"
        ColumnHeader7.Width = 75
        ' 
        ' AnnotationDeleteCostInfo
        ' 
        AnnotationDeleteCostInfo.AutoSize = True
        AnnotationDeleteCostInfo.Location = New Point(87, 10)
        AnnotationDeleteCostInfo.Name = "AnnotationDeleteCostInfo"
        AnnotationDeleteCostInfo.Size = New Size(216, 15)
        AnnotationDeleteCostInfo.TabIndex = 13
        AnnotationDeleteCostInfo.Text = "※削除する場合は交通費を選択してください"
        ' 
        ' ChangeDisplayCostTab
        ' 
        ChangeDisplayCostTab.Location = New Point(6, 6)
        ChangeDisplayCostTab.Name = "ChangeDisplayCostTab"
        ChangeDisplayCostTab.Size = New Size(75, 23)
        ChangeDisplayCostTab.TabIndex = 12
        ChangeDisplayCostTab.Text = "登録"
        ChangeDisplayCostTab.UseVisualStyleBackColor = True
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
        ' PostEmployeeInfoTab
        ' 
        PostEmployeeInfoTab.Controls.Add(DummyButtonCloseEmployeeInfoTab)
        PostEmployeeInfoTab.Controls.Add(DummyButtonPostEmployeeInfo)
        PostEmployeeInfoTab.Controls.Add(PostEmployeeInfoPanel)
        PostEmployeeInfoTab.Location = New Point(4, 24)
        PostEmployeeInfoTab.Name = "PostEmployeeInfoTab"
        PostEmployeeInfoTab.Padding = New Padding(3)
        PostEmployeeInfoTab.Size = New Size(632, 388)
        PostEmployeeInfoTab.TabIndex = 3
        PostEmployeeInfoTab.Text = "従業員登録"
        PostEmployeeInfoTab.UseVisualStyleBackColor = True
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
        ' PostCostInfoTab
        ' 
        PostCostInfoTab.Controls.Add(DummyCloseCostInfoTab)
        PostCostInfoTab.Controls.Add(DummyChangeDisplayCostTab)
        PostCostInfoTab.Controls.Add(PostCostInfoPanel)
        PostCostInfoTab.Location = New Point(4, 24)
        PostCostInfoTab.Name = "PostCostInfoTab"
        PostCostInfoTab.Size = New Size(632, 388)
        PostCostInfoTab.TabIndex = 4
        PostCostInfoTab.Text = "交通費登録"
        PostCostInfoTab.UseVisualStyleBackColor = True
        ' 
        ' DummyCloseCostInfoTab
        ' 
        DummyCloseCostInfoTab.Location = New Point(551, 6)
        DummyCloseCostInfoTab.Name = "DummyCloseCostInfoTab"
        DummyCloseCostInfoTab.Size = New Size(75, 23)
        DummyCloseCostInfoTab.TabIndex = 14
        DummyCloseCostInfoTab.Text = "閉じる"
        DummyCloseCostInfoTab.UseVisualStyleBackColor = True
        ' 
        ' DummyChangeDisplayCostTab
        ' 
        DummyChangeDisplayCostTab.Location = New Point(6, 6)
        DummyChangeDisplayCostTab.Name = "DummyChangeDisplayCostTab"
        DummyChangeDisplayCostTab.Size = New Size(75, 23)
        DummyChangeDisplayCostTab.TabIndex = 13
        DummyChangeDisplayCostTab.Text = "一覧に戻る"
        DummyChangeDisplayCostTab.UseVisualStyleBackColor = True
        ' 
        ' PostCostInfoPanel
        ' 
        PostCostInfoPanel.Controls.Add(PaymentCost)
        PostCostInfoPanel.Controls.Add(CostContent)
        PostCostInfoPanel.Controls.Add(CostDay)
        PostCostInfoPanel.Controls.Add(CostMonth)
        PostCostInfoPanel.Controls.Add(CostYear)
        PostCostInfoPanel.Controls.Add(Label10)
        PostCostInfoPanel.Controls.Add(Label9)
        PostCostInfoPanel.Controls.Add(CostEmpoyeeId)
        PostCostInfoPanel.Controls.Add(PaymentName)
        PostCostInfoPanel.Controls.Add(AdvancePaymentOff)
        PostCostInfoPanel.Controls.Add(AdvancePaymentOn)
        PostCostInfoPanel.Controls.Add(Label1)
        PostCostInfoPanel.Controls.Add(PostCostInfo)
        PostCostInfoPanel.Controls.Add(Label4)
        PostCostInfoPanel.Controls.Add(Label6)
        PostCostInfoPanel.Controls.Add(Label7)
        PostCostInfoPanel.Controls.Add(Label8)
        PostCostInfoPanel.Location = New Point(0, 0)
        PostCostInfoPanel.Name = "PostCostInfoPanel"
        PostCostInfoPanel.Size = New Size(632, 388)
        PostCostInfoPanel.TabIndex = 15
        ' 
        ' PaymentCost
        ' 
        PaymentCost.Location = New Point(82, 232)
        PaymentCost.Name = "PaymentCost"
        PaymentCost.PlaceholderText = "数字のみ入力してください"
        PaymentCost.Size = New Size(150, 23)
        PaymentCost.TabIndex = 42
        ' 
        ' CostContent
        ' 
        CostContent.Location = New Point(82, 154)
        CostContent.Name = "CostContent"
        CostContent.PlaceholderText = "空欄 可"
        CostContent.Size = New Size(150, 23)
        CostContent.TabIndex = 41
        ' 
        ' CostDay
        ' 
        CostDay.FormattingEnabled = True
        CostDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        CostDay.Location = New Point(182, 76)
        CostDay.Name = "CostDay"
        CostDay.Size = New Size(36, 23)
        CostDay.TabIndex = 40
        CostDay.Text = "1"
        ' 
        ' CostMonth
        ' 
        CostMonth.FormattingEnabled = True
        CostMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        CostMonth.Location = New Point(140, 76)
        CostMonth.Name = "CostMonth"
        CostMonth.Size = New Size(36, 23)
        CostMonth.TabIndex = 39
        CostMonth.Text = "1"
        ' 
        ' CostYear
        ' 
        CostYear.FormattingEnabled = True
        CostYear.Items.AddRange(New Object() {"2023", "2024", "2025", "2026"})
        CostYear.Location = New Point(82, 76)
        CostYear.Name = "CostYear"
        CostYear.Size = New Size(52, 23)
        CostYear.TabIndex = 38
        CostYear.Text = "2024"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(10, 235)
        Label10.Name = "Label10"
        Label10.Size = New Size(43, 15)
        Label10.TabIndex = 37
        Label10.Text = "金額："
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(10, 196)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 15)
        Label9.TabIndex = 36
        Label9.Text = "立替："
        ' 
        ' CostEmpoyeeId
        ' 
        CostEmpoyeeId.BackColor = SystemColors.Window
        CostEmpoyeeId.FormattingEnabled = True
        CostEmpoyeeId.Location = New Point(82, 37)
        CostEmpoyeeId.Name = "CostEmpoyeeId"
        CostEmpoyeeId.Size = New Size(150, 23)
        CostEmpoyeeId.TabIndex = 35
        CostEmpoyeeId.Text = "9999 ダミー"
        ' 
        ' PaymentName
        ' 
        PaymentName.Location = New Point(82, 115)
        PaymentName.Name = "PaymentName"
        PaymentName.PlaceholderText = "入力してください"
        PaymentName.Size = New Size(150, 23)
        PaymentName.TabIndex = 34
        ' 
        ' AdvancePaymentOff
        ' 
        AdvancePaymentOff.AutoSize = True
        AdvancePaymentOff.Location = New Point(151, 194)
        AdvancePaymentOff.Name = "AdvancePaymentOff"
        AdvancePaymentOff.Size = New Size(62, 19)
        AdvancePaymentOff.TabIndex = 33
        AdvancePaymentOff.TabStop = True
        AdvancePaymentOff.Text = "× (なし)"
        AdvancePaymentOff.UseVisualStyleBackColor = True
        ' 
        ' AdvancePaymentOn
        ' 
        AdvancePaymentOn.AutoSize = True
        AdvancePaymentOn.Checked = True
        AdvancePaymentOn.Location = New Point(82, 194)
        AdvancePaymentOn.Name = "AdvancePaymentOn"
        AdvancePaymentOn.Size = New Size(66, 19)
        AdvancePaymentOn.TabIndex = 32
        AdvancePaymentOn.TabStop = True
        AdvancePaymentOn.Text = "○ (あり)"
        AdvancePaymentOn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(279, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 31
        ' 
        ' PostCostInfo
        ' 
        PostCostInfo.Location = New Point(6, 274)
        PostCostInfo.Name = "PostCostInfo"
        PostCostInfo.Size = New Size(75, 23)
        PostCostInfo.TabIndex = 30
        PostCostInfo.Text = "登録"
        PostCostInfo.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 29
        Label4.Text = "内容："
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 28
        Label6.Text = "支払先："
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 79)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 27
        Label7.Text = "支払日："
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 40)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 15)
        Label8.TabIndex = 26
        Label8.Text = "従業員："
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
        CostInfoTab.PerformLayout()
        PostEmployeeInfoTab.ResumeLayout(False)
        PostEmployeeInfoPanel.ResumeLayout(False)
        PostEmployeeInfoPanel.PerformLayout()
        PostCostInfoTab.ResumeLayout(False)
        PostCostInfoPanel.ResumeLayout(False)
        PostCostInfoPanel.PerformLayout()
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
    Friend WithEvents PostEmployeeInfoTab As TabPage
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
    Friend WithEvents ChangeDisplayCostTab As Button
    Friend WithEvents PostCostInfoTab As TabPage
    Friend WithEvents DummyCloseCostInfoTab As Button
    Friend WithEvents DummyChangeDisplayCostTab As Button
    Friend WithEvents AnnotationDeleteCostInfo As Label
    Friend WithEvents PostCostInfoPanel As Panel
    Friend WithEvents CostEmpoyeeId As ComboBox
    Friend WithEvents PaymentName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PostCostInfo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CostYear As ComboBox
    Friend WithEvents CostMonth As ComboBox
    Friend WithEvents CostDay As ComboBox
    Friend WithEvents PaymentCost As TextBox
    Friend WithEvents CostContent As TextBox
    Friend WithEvents AdvancePaymentOff As RadioButton
    Friend WithEvents AdvancePaymentOn As RadioButton
    Friend WithEvents ShowCostInfo As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents CostInfoCreatedAtColumn As ColumnHeader
End Class
