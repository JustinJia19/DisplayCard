<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnAddCard = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btn_OverviewHiddenCard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(218, 307)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(137, 45)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "下一张"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(64, 306)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(137, 44)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "上一张"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnAddCard
        '
        Me.btnAddCard.Location = New System.Drawing.Point(590, 307)
        Me.btnAddCard.Name = "btnAddCard"
        Me.btnAddCard.Size = New System.Drawing.Size(137, 44)
        Me.btnAddCard.TabIndex = 2
        Me.btnAddCard.Text = "添加新卡片"
        Me.btnAddCard.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblStatus.Location = New System.Drawing.Point(60, 34)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(69, 20)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Label1"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(334, 171)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(137, 45)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "开始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btn_OverviewHiddenCard
        '
        Me.btn_OverviewHiddenCard.Location = New System.Drawing.Point(590, 367)
        Me.btn_OverviewHiddenCard.Name = "btn_OverviewHiddenCard"
        Me.btn_OverviewHiddenCard.Size = New System.Drawing.Size(137, 43)
        Me.btn_OverviewHiddenCard.TabIndex = 5
        Me.btn_OverviewHiddenCard.Text = "查看已隐藏卡片"
        Me.btn_OverviewHiddenCard.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_OverviewHiddenCard)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnAddCard)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnAddCard As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btn_OverviewHiddenCard As Button
End Class
