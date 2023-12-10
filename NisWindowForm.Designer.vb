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
        OpenCostTab = New Button()
        OpenEmployeeTab = New Button()
        Search = New Label()
        Menu = New Label()
        OpenAndCloseMenu = New Button()
        MenuTabs = New TabControl()
        EmployeeInfoTab = New TabPage()
        CloseEmployeeInfoTab = New Button()
        EmployeeDetailTab = New TabPage()
        CloseEmployeeDetailTab = New Button()
        TransportExpensesTab = New TabPage()
        CloseTransportExpensesTab = New Button()
        PostEmployeeInfo = New Button()
        ShowEmployeeInfo = New ListView()
        EmployeeIDColumn = New ColumnHeader()
        EmployeeNameColumn = New ColumnHeader()
        GenderColumn = New ColumnHeader()
        BelongingToColumn = New ColumnHeader()
        CType(SplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer.Panel1.SuspendLayout()
        SplitContainer.Panel2.SuspendLayout()
        SplitContainer.SuspendLayout()
        MenuTabs.SuspendLayout()
        EmployeeInfoTab.SuspendLayout()
        EmployeeDetailTab.SuspendLayout()
        TransportExpensesTab.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer
        ' 
        SplitContainer.Dock = DockStyle.Fill
        SplitContainer.Location = New Point(0, 0)
        SplitContainer.Name = "SplitContainer"
        ' 
        ' SplitContainer.Panel1
        ' 
        SplitContainer.Panel1.Controls.Add(SearchEmployeeTextBox)
        SplitContainer.Panel1.Controls.Add(SearchEmployee)
        SplitContainer.Panel1.Controls.Add(OpenCostTab)
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
        ' OpenCostTab
        ' 
        OpenCostTab.Location = New Point(39, 90)
        OpenCostTab.Name = "OpenCostTab"
        OpenCostTab.Size = New Size(75, 23)
        OpenCostTab.TabIndex = 6
        OpenCostTab.Text = "交通費管理"
        OpenCostTab.UseVisualStyleBackColor = True
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
        MenuTabs.Controls.Add(TransportExpensesTab)
        MenuTabs.Location = New Point(3, 31)
        MenuTabs.Name = "MenuTabs"
        MenuTabs.SelectedIndex = 0
        MenuTabs.Size = New Size(640, 416)
        MenuTabs.TabIndex = 0
        ' 
        ' EmployeeInfoTab
        ' 
        EmployeeInfoTab.Controls.Add(ShowEmployeeInfo)
        EmployeeInfoTab.Controls.Add(PostEmployeeInfo)
        EmployeeInfoTab.Controls.Add(CloseEmployeeInfoTab)
        EmployeeInfoTab.Location = New Point(4, 24)
        EmployeeInfoTab.Name = "EmployeeInfoTab"
        EmployeeInfoTab.Padding = New Padding(3)
        EmployeeInfoTab.Size = New Size(632, 388)
        EmployeeInfoTab.TabIndex = 0
        EmployeeInfoTab.Text = "従業員一覧"
        EmployeeInfoTab.UseVisualStyleBackColor = True
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
        EmployeeDetailTab.Controls.Add(CloseEmployeeDetailTab)
        EmployeeDetailTab.Location = New Point(4, 24)
        EmployeeDetailTab.Name = "EmployeeDetailTab"
        EmployeeDetailTab.Padding = New Padding(3)
        EmployeeDetailTab.Size = New Size(632, 388)
        EmployeeDetailTab.TabIndex = 1
        EmployeeDetailTab.Text = "従業員詳細"
        EmployeeDetailTab.UseVisualStyleBackColor = True
        ' 
        ' CloseEmployeeDetailTab
        ' 
        CloseEmployeeDetailTab.Location = New Point(551, 6)
        CloseEmployeeDetailTab.Name = "CloseEmployeeDetailTab"
        CloseEmployeeDetailTab.Size = New Size(75, 23)
        CloseEmployeeDetailTab.TabIndex = 1
        CloseEmployeeDetailTab.Text = "閉じる"
        CloseEmployeeDetailTab.UseVisualStyleBackColor = True
        ' 
        ' TransportExpensesTab
        ' 
        TransportExpensesTab.Controls.Add(CloseTransportExpensesTab)
        TransportExpensesTab.Location = New Point(4, 24)
        TransportExpensesTab.Name = "TransportExpensesTab"
        TransportExpensesTab.Size = New Size(632, 388)
        TransportExpensesTab.TabIndex = 2
        TransportExpensesTab.Text = "交通費"
        TransportExpensesTab.UseVisualStyleBackColor = True
        ' 
        ' CloseTransportExpensesTab
        ' 
        CloseTransportExpensesTab.Location = New Point(551, 6)
        CloseTransportExpensesTab.Name = "CloseTransportExpensesTab"
        CloseTransportExpensesTab.Size = New Size(75, 23)
        CloseTransportExpensesTab.TabIndex = 2
        CloseTransportExpensesTab.Text = "閉じる"
        CloseTransportExpensesTab.UseVisualStyleBackColor = True
        ' 
        ' PostEmployeeInfo
        ' 
        PostEmployeeInfo.Location = New Point(6, 6)
        PostEmployeeInfo.Name = "PostEmployeeInfo"
        PostEmployeeInfo.Size = New Size(75, 23)
        PostEmployeeInfo.TabIndex = 11
        PostEmployeeInfo.Text = "登録"
        PostEmployeeInfo.UseVisualStyleBackColor = True
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
        ' NisWindowForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer)
        Name = "NisWindowForm"
        Text = "NisWindowForm"
        SplitContainer.Panel1.ResumeLayout(False)
        SplitContainer.Panel1.PerformLayout()
        SplitContainer.Panel2.ResumeLayout(False)
        CType(SplitContainer, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer.ResumeLayout(False)
        MenuTabs.ResumeLayout(False)
        EmployeeInfoTab.ResumeLayout(False)
        EmployeeDetailTab.ResumeLayout(False)
        TransportExpensesTab.ResumeLayout(False)
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
    Friend WithEvents OpenCostTab As Button
    Friend WithEvents OpenEmployeeTab As Button
    Friend WithEvents TransportExpensesTab As TabPage
    Friend WithEvents CloseEmployeeInfoTab As Button
    Friend WithEvents CloseEmployeeDetailTab As Button
    Friend WithEvents CloseTransportExpensesTab As Button
    Friend WithEvents PostEmployeeInfo As Button
    Friend WithEvents ShowEmployeeInfo As ListView
    Friend WithEvents EmployeeIDColumn As ColumnHeader
    Friend WithEvents EmployeeNameColumn As ColumnHeader
    Friend WithEvents GenderColumn As ColumnHeader
    Friend WithEvents BelongingToColumn As ColumnHeader
End Class
