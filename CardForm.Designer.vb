<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardForm
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
        Me.lblCardContent = New System.Windows.Forms.Label()
        Me.btnFlip = New System.Windows.Forms.Button()
        Me.rightLabel = New System.Windows.Forms.Label()
        Me.wrongLabel = New System.Windows.Forms.Label()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnWrong = New System.Windows.Forms.Button()
        Me.seqLabel = New System.Windows.Forms.Label()
        Me.btn_Reuse = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCardContent
        '
        Me.lblCardContent.AutoSize = True
        Me.lblCardContent.Location = New System.Drawing.Point(113, 86)
        Me.lblCardContent.Name = "lblCardContent"
        Me.lblCardContent.Size = New System.Drawing.Size(55, 15)
        Me.lblCardContent.TabIndex = 0
        Me.lblCardContent.Text = "Label1"
        '
        'btnFlip
        '
        Me.btnFlip.Location = New System.Drawing.Point(192, 328)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(126, 38)
        Me.btnFlip.TabIndex = 1
        Me.btnFlip.Text = "翻转"
        Me.btnFlip.UseVisualStyleBackColor = True
        '
        'rightLabel
        '
        Me.rightLabel.AutoSize = True
        Me.rightLabel.Location = New System.Drawing.Point(12, 388)
        Me.rightLabel.Name = "rightLabel"
        Me.rightLabel.Size = New System.Drawing.Size(55, 15)
        Me.rightLabel.TabIndex = 2
        Me.rightLabel.Text = "Label1"
        '
        'wrongLabel
        '
        Me.wrongLabel.AutoSize = True
        Me.wrongLabel.Location = New System.Drawing.Point(138, 388)
        Me.wrongLabel.Name = "wrongLabel"
        Me.wrongLabel.Size = New System.Drawing.Size(55, 15)
        Me.wrongLabel.TabIndex = 3
        Me.wrongLabel.Text = "Label1"
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(51, 328)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(126, 38)
        Me.btnRight.TabIndex = 4
        Me.btnRight.Text = "正确"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnWrong
        '
        Me.btnWrong.Location = New System.Drawing.Point(335, 328)
        Me.btnWrong.Name = "btnWrong"
        Me.btnWrong.Size = New System.Drawing.Size(126, 37)
        Me.btnWrong.TabIndex = 5
        Me.btnWrong.Text = "错误"
        Me.btnWrong.UseVisualStyleBackColor = True
        '
        'seqLabel
        '
        Me.seqLabel.AutoSize = True
        Me.seqLabel.Location = New System.Drawing.Point(12, 415)
        Me.seqLabel.Name = "seqLabel"
        Me.seqLabel.Size = New System.Drawing.Size(55, 15)
        Me.seqLabel.TabIndex = 6
        Me.seqLabel.Text = "Label1"
        '
        'btn_Reuse
        '
        Me.btn_Reuse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Reuse.Location = New System.Drawing.Point(335, 381)
        Me.btn_Reuse.Name = "btn_Reuse"
        Me.btn_Reuse.Size = New System.Drawing.Size(126, 34)
        Me.btn_Reuse.TabIndex = 7
        Me.btn_Reuse.Text = "取消隐藏"
        Me.btn_Reuse.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(344, 12)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(126, 35)
        Me.btn_Delete.TabIndex = 8
        Me.btn_Delete.Text = "删除卡片"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'CardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Reuse)
        Me.Controls.Add(Me.seqLabel)
        Me.Controls.Add(Me.btnWrong)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.wrongLabel)
        Me.Controls.Add(Me.rightLabel)
        Me.Controls.Add(Me.btnFlip)
        Me.Controls.Add(Me.lblCardContent)
        Me.Name = "CardForm"
        Me.Text = "CardForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCardContent As Label
    Friend WithEvents btnFlip As Button
    Friend WithEvents rightLabel As Label
    Friend WithEvents wrongLabel As Label
    Friend WithEvents btnRight As Button
    Friend WithEvents btnWrong As Button
    Friend WithEvents seqLabel As Label
    Friend WithEvents btn_Reuse As Button
    Friend WithEvents btn_Delete As Button
End Class
