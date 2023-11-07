<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetailFrom
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
        ReturnEmployeeInfoButton = New Button()
        Title = New Label()
        EmployeeName = New Label()
        Gender = New Label()
        BelongingTo = New Label()
        EmployeeID = New Label()
        EmployeeGenderAutofill = New Label()
        EmployeeIDAutofill = New Label()
        UpdateEmployeeInfo = New Button()
        BelongingToSelectBox = New ComboBox()
        EmployeeNameTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' ReturnEmployeeInfoButton
        ' 
        ReturnEmployeeInfoButton.Location = New Point(614, 235)
        ReturnEmployeeInfoButton.Name = "ReturnEmployeeInfoButton"
        ReturnEmployeeInfoButton.Size = New Size(75, 23)
        ReturnEmployeeInfoButton.TabIndex = 0
        ReturnEmployeeInfoButton.Text = "一覧に戻る"
        ReturnEmployeeInfoButton.UseVisualStyleBackColor = True
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Yu Gothic UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Title.Location = New Point(516, 22)
        Title.Name = "Title"
        Title.Size = New Size(152, 37)
        Title.TabIndex = 1
        Title.Text = "従業員詳細"
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
        ' EmployeeGenderAutofill
        ' 
        EmployeeGenderAutofill.AutoSize = True
        EmployeeGenderAutofill.Location = New Point(614, 116)
        EmployeeGenderAutofill.Name = "EmployeeGenderAutofill"
        EmployeeGenderAutofill.Size = New Size(31, 15)
        EmployeeGenderAutofill.TabIndex = 6
        EmployeeGenderAutofill.Text = "性別"
        ' 
        ' EmployeeIDAutofill
        ' 
        EmployeeIDAutofill.AutoSize = True
        EmployeeIDAutofill.Location = New Point(614, 196)
        EmployeeIDAutofill.Name = "EmployeeIDAutofill"
        EmployeeIDAutofill.Size = New Size(31, 15)
        EmployeeIDAutofill.TabIndex = 7
        EmployeeIDAutofill.Text = "1000"
        ' 
        ' UpdateEmployeeInfo
        ' 
        UpdateEmployeeInfo.Location = New Point(495, 235)
        UpdateEmployeeInfo.Name = "UpdateEmployeeInfo"
        UpdateEmployeeInfo.Size = New Size(75, 23)
        UpdateEmployeeInfo.TabIndex = 8
        UpdateEmployeeInfo.Text = "更新"
        UpdateEmployeeInfo.UseVisualStyleBackColor = True
        ' 
        ' BelongingToSelectBox
        ' 
        BelongingToSelectBox.FormattingEnabled = True
        BelongingToSelectBox.Items.AddRange(New Object() {"事業部", "営業部"})
        BelongingToSelectBox.Location = New Point(614, 154)
        BelongingToSelectBox.Name = "BelongingToSelectBox"
        BelongingToSelectBox.Size = New Size(91, 23)
        BelongingToSelectBox.TabIndex = 9
        ' 
        ' EmployeeNameTextBox
        ' 
        EmployeeNameTextBox.Location = New Point(614, 76)
        EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        EmployeeNameTextBox.PlaceholderText = "入力してください"
        EmployeeNameTextBox.Size = New Size(150, 23)
        EmployeeNameTextBox.TabIndex = 10
        ' 
        ' EmployeeDetailFrom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 681)
        Controls.Add(EmployeeNameTextBox)
        Controls.Add(BelongingToSelectBox)
        Controls.Add(UpdateEmployeeInfo)
        Controls.Add(EmployeeIDAutofill)
        Controls.Add(EmployeeGenderAutofill)
        Controls.Add(EmployeeID)
        Controls.Add(BelongingTo)
        Controls.Add(Gender)
        Controls.Add(EmployeeName)
        Controls.Add(Title)
        Controls.Add(ReturnEmployeeInfoButton)
        Name = "EmployeeDetailFrom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "従業員情報管理アプリ"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ReturnEmployeeInfoButton As Button
    Friend WithEvents Title As Label
    Friend WithEvents EmployeeName As Label
    Friend WithEvents Gender As Label
    Friend WithEvents BelongingTo As Label
    Friend WithEvents EmployeeID As Label
    Friend WithEvents EmployeeGenderAutofill As Label
    Friend WithEvents EmployeeIDAutofill As Label
    Friend WithEvents UpdateEmployeeInfo As Button
    Friend WithEvents BelongingToSelectBox As ComboBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents UpdateInfo As Label
End Class
