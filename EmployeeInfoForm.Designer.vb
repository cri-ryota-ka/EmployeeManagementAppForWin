<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeInfoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Title = New Label()
        EmployeeName = New Label()
        Gender = New Label()
        BelongingTo = New Label()
        EmployeeID = New Label()
        SearchName = New TextBox()
        SearchButton = New Button()
        ShowEmployeeInfo = New ListView()
        EmployeeIDColumn = New ColumnHeader()
        EmployeeNameColumn = New ColumnHeader()
        GenderColumn = New ColumnHeader()
        BelongingToColumn = New ColumnHeader()
        PostEmployeeInfo = New Button()
        EmployeeIDAutofill = New Label()
        Male = New RadioButton()
        Female = New RadioButton()
        EmployeeNameTextBox = New TextBox()
        BelongingToSelectBox = New ComboBox()
        MoveNisWindowFrom = New Button()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Yu Gothic UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Title.Location = New Point(516, 22)
        Title.Name = "Title"
        Title.Size = New Size(152, 37)
        Title.TabIndex = 1
        Title.Text = "従業員情報"
        ' 
        ' EmployeeName
        ' 
        EmployeeName.AutoSize = True
        EmployeeName.Location = New Point(527, 79)
        EmployeeName.Name = "EmployeeName"
        EmployeeName.Size = New Size(43, 15)
        EmployeeName.TabIndex = 2
        EmployeeName.Text = "氏名："
        ' 
        ' Gender
        ' 
        Gender.AutoSize = True
        Gender.Location = New Point(527, 118)
        Gender.Name = "Gender"
        Gender.Size = New Size(43, 15)
        Gender.TabIndex = 3
        Gender.Text = "性別："
        ' 
        ' BelongingTo
        ' 
        BelongingTo.AutoSize = True
        BelongingTo.Location = New Point(503, 157)
        BelongingTo.Name = "BelongingTo"
        BelongingTo.Size = New Size(67, 15)
        BelongingTo.TabIndex = 4
        BelongingTo.Text = "所属部署："
        ' 
        ' EmployeeID
        ' 
        EmployeeID.AutoSize = True
        EmployeeID.Location = New Point(504, 196)
        EmployeeID.Name = "EmployeeID"
        EmployeeID.Size = New Size(66, 15)
        EmployeeID.TabIndex = 5
        EmployeeID.Text = "従業員ID："
        ' 
        ' SearchName
        ' 
        SearchName.Location = New Point(516, 329)
        SearchName.Name = "SearchName"
        SearchName.PlaceholderText = "氏名で検索"
        SearchName.Size = New Size(152, 23)
        SearchName.TabIndex = 7
        ' 
        ' SearchButton
        ' 
        SearchButton.Location = New Point(629, 329)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(39, 23)
        SearchButton.TabIndex = 8
        SearchButton.Text = "検索"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' ShowEmployeeInfo
        ' 
        ShowEmployeeInfo.Activation = ItemActivation.OneClick
        ShowEmployeeInfo.Columns.AddRange(New ColumnHeader() {EmployeeIDColumn, EmployeeNameColumn, GenderColumn, BelongingToColumn})
        ShowEmployeeInfo.FullRowSelect = True
        ShowEmployeeInfo.Location = New Point(410, 358)
        ShowEmployeeInfo.Name = "ShowEmployeeInfo"
        ShowEmployeeInfo.Size = New Size(364, 250)
        ShowEmployeeInfo.TabIndex = 9
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
        ' PostEmployeeInfo
        ' 
        PostEmployeeInfo.Location = New Point(555, 235)
        PostEmployeeInfo.Name = "PostEmployeeInfo"
        PostEmployeeInfo.Size = New Size(75, 23)
        PostEmployeeInfo.TabIndex = 10
        PostEmployeeInfo.Text = "登録"
        PostEmployeeInfo.UseVisualStyleBackColor = True
        ' 
        ' EmployeeIDAutofill
        ' 
        EmployeeIDAutofill.AutoSize = True
        EmployeeIDAutofill.Location = New Point(614, 196)
        EmployeeIDAutofill.Name = "EmployeeIDAutofill"
        EmployeeIDAutofill.Size = New Size(31, 15)
        EmployeeIDAutofill.TabIndex = 11
        EmployeeIDAutofill.Text = "1000"
        ' 
        ' Male
        ' 
        Male.AutoSize = True
        Male.Checked = True
        Male.Location = New Point(614, 116)
        Male.Name = "Male"
        Male.Size = New Size(49, 19)
        Male.TabIndex = 12
        Male.TabStop = True
        Male.Text = "男性"
        Male.UseVisualStyleBackColor = True
        ' 
        ' Female
        ' 
        Female.AutoSize = True
        Female.Location = New Point(669, 116)
        Female.Name = "Female"
        Female.Size = New Size(49, 19)
        Female.TabIndex = 13
        Female.TabStop = True
        Female.Text = "女性"
        Female.UseVisualStyleBackColor = True
        ' 
        ' EmployeeNameTextBox
        ' 
        EmployeeNameTextBox.Location = New Point(614, 76)
        EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        EmployeeNameTextBox.PlaceholderText = "入力してください"
        EmployeeNameTextBox.Size = New Size(150, 23)
        EmployeeNameTextBox.TabIndex = 14
        ' 
        ' BelongingToSelectBox
        ' 
        BelongingToSelectBox.BackColor = SystemColors.Window
        BelongingToSelectBox.FormattingEnabled = True
        BelongingToSelectBox.Items.AddRange(New Object() {"事業部", "営業部"})
        BelongingToSelectBox.Location = New Point(614, 154)
        BelongingToSelectBox.Name = "BelongingToSelectBox"
        BelongingToSelectBox.Size = New Size(91, 23)
        BelongingToSelectBox.TabIndex = 15
        BelongingToSelectBox.Text = "事業部"
        ' 
        ' MoveNisWindowFrom
        ' 
        MoveNisWindowFrom.Location = New Point(915, 36)
        MoveNisWindowFrom.Name = "MoveNisWindowFrom"
        MoveNisWindowFrom.Size = New Size(117, 23)
        MoveNisWindowFrom.TabIndex = 16
        MoveNisWindowFrom.Text = "MoveNisWindow"
        MoveNisWindowFrom.UseVisualStyleBackColor = True
        ' 
        ' EmployeeInfoForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 681)
        Controls.Add(MoveNisWindowFrom)
        Controls.Add(BelongingToSelectBox)
        Controls.Add(EmployeeNameTextBox)
        Controls.Add(Female)
        Controls.Add(Male)
        Controls.Add(EmployeeIDAutofill)
        Controls.Add(PostEmployeeInfo)
        Controls.Add(ShowEmployeeInfo)
        Controls.Add(SearchButton)
        Controls.Add(SearchName)
        Controls.Add(EmployeeID)
        Controls.Add(BelongingTo)
        Controls.Add(Gender)
        Controls.Add(EmployeeName)
        Controls.Add(Title)
        Name = "EmployeeInfoForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "従業員情報管理アプリ"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Female As RadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Title As Label
    Friend WithEvents EmployeeName As Label
    Friend WithEvents Gender As Label
    Friend WithEvents BelongingTo As Label
    Friend WithEvents EmployeeID As Label
    Friend WithEvents SearchName As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ShowEmployeeInfo As ListView
    Friend WithEvents EmployeeNameColumn As ColumnHeader
    Friend WithEvents GenderColumn As ColumnHeader
    Friend WithEvents BelongingToColumn As ColumnHeader
    Friend WithEvents EmployeeIDColumn As ColumnHeader
    Friend WithEvents PostEmployeeInfo As Button
    Friend WithEvents EmployeeIDAutofill As Label
    Friend WithEvents Male As RadioButton
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents BelongingToSelectBox As ComboBox
    Friend WithEvents MoveNisWindowFrom As Button
End Class
