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
        SuspendLayout()
        ' 
        ' ReturnEmployeeInfoButton
        ' 
        ReturnEmployeeInfoButton.Location = New Point(674, 29)
        ReturnEmployeeInfoButton.Name = "ReturnEmployeeInfoButton"
        ReturnEmployeeInfoButton.Size = New Size(75, 30)
        ReturnEmployeeInfoButton.TabIndex = 0
        ReturnEmployeeInfoButton.Text = "一覧に戻る"
        ReturnEmployeeInfoButton.UseVisualStyleBackColor = True
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Yu Gothic UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        Title.Location = New Point(516, 22)
        Title.Name = "Title"
        Title.Size = New Size(152, 37)
        Title.TabIndex = 1
        Title.Text = "従業員詳細"
        ' 
        ' EmployeeDetailFrom
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 681)
        Controls.Add(Title)
        Controls.Add(ReturnEmployeeInfoButton)
        Name = "EmployeeDetailFrom"
        Text = "従業員情報管理アプリ"
        ResumeLayout(False)
        PerformLayout()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Friend WithEvents ReturnEmployeeInfoButton As Button
    Friend WithEvents Title As Label
End Class
