<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditCardForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFront = New System.Windows.Forms.TextBox()
        Me.txtBack = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFront
        '
        Me.txtFront.Location = New System.Drawing.Point(245, 74)
        Me.txtFront.Multiline = True
        Me.txtFront.Name = "txtFront"
        Me.txtFront.Size = New System.Drawing.Size(322, 96)
        Me.txtFront.TabIndex = 0
        '
        'txtBack
        '
        Me.txtBack.Location = New System.Drawing.Point(245, 230)
        Me.txtBack.Multiline = True
        Me.txtBack.Name = "txtBack"
        Me.txtBack.Size = New System.Drawing.Size(321, 104)
        Me.txtBack.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(124, 362)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(108, 35)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "确认"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(459, 363)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 34)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(120, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "正面内容"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(120, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "反面内容"
        '
        'AddLabel
        '
        Me.AddLabel.AutoSize = True
        Me.AddLabel.Font = New System.Drawing.Font("楷体", 16.0!)
        Me.AddLabel.Location = New System.Drawing.Point(287, 18)
        Me.AddLabel.Name = "AddLabel"
        Me.AddLabel.Size = New System.Drawing.Size(152, 27)
        Me.AddLabel.TabIndex = 6
        Me.AddLabel.Text = "添加新卡片"
        '
        'AddEditCardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtBack)
        Me.Controls.Add(Me.txtFront)
        Me.Name = "AddEditCardForm"
        Me.Text = "AddEditCardForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFront As TextBox
    Friend WithEvents txtBack As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddLabel As Label
End Class
