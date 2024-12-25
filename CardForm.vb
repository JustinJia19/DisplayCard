Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class CardForm
    Private isFrontVisible As Boolean = True
    Private currentCard As FlashCard
    ' 确保窗体可以预览键盘事件
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub
    Public Sub New(card As FlashCard)
        InitializeComponent()
        currentCard = card
        UpdateDisplay()
        Me.KeyPreview = True
    End Sub

    Private Sub CardForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' 检查是否按下了A键
        If e.KeyCode = Keys.D Then
            ' 触发 Click 事件
            btnRight.PerformClick()
        ElseIf e.KeyCode = Keys.a Then
            btnWrong.PerformClick()
        End If
    End Sub

    ' 更新显示内容
    Private Sub UpdateDisplay()
        If isFrontVisible Then
            lblCardContent.Text = currentCard.Front
        Else
            lblCardContent.Text = currentCard.Back
        End If
        rightLabel.Text = $"正确次数 {currentCard.rightNum}"
        wrongLabel.Text = $"错误次数 {currentCard.wrongNum}"
        seqLabel.Text = $"连续正确次数 {currentCard.sequentNum}"

        ' 启用/禁用重用按钮基于卡片是否被隐藏
        btn_Reuse.Enabled = currentCard.IsHidden
    End Sub

    ' 翻转卡片
    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        isFrontVisible = Not isFrontVisible
        UpdateDisplay()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        currentCard.rightNum = currentCard.rightNum + 1
        currentCard.sequentNum = currentCard.sequentNum + 1
        currentCard.memoryIndex += 1
        ' 检查连续正确次数是否达到3，如果达到则隐藏卡片
        If currentCard.sequentNum >= 3 Then
            currentCard.IsHidden = True
        End If
        Me.Close()
    End Sub

    Private Sub btnWrong_Click(sender As Object, e As EventArgs) Handles btnWrong.Click
        currentCard.wrongNum = currentCard.wrongNum + 1
        currentCard.sequentNum = 0
        currentCard.memoryIndex = 0
        Me.Close()
    End Sub

    Private Sub btn_Reuse_Click(sender As Object, e As EventArgs) Handles btn_Reuse.Click
        If currentCard IsNot Nothing AndAlso currentCard.IsHidden Then
            currentCard.IsHidden = False
            MessageBox.Show("卡片已重新启用。")
            Me.Close() ' 关闭当前窗口，返回主窗体以反映更改
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        ' 删除当前卡片
        If currentCard IsNot Nothing Then
            ' 通过事件或委托通知主窗体删除该卡片
            OnCardDeleted(currentCard)
            Me.Close()
        End If
    End Sub

    ' 定义一个事件，用于通知主窗体有卡片被删除
    Public Event CardDeleted(card As FlashCard)

    ' 触发 CardDeleted 事件的方法
    Protected Overridable Sub OnCardDeleted(card As FlashCard)
        RaiseEvent CardDeleted(card)
    End Sub

    Private Sub btn_Renew_Click(sender As Object, e As EventArgs) Handles btn_Renew.Click
        currentCard.rightNum = 0
        currentCard.wrongNum = 0
        currentCard.sequentNum = 0
        currentCard.memoryIndex = 0
        currentCard.IsHidden = False
        MessageBox.Show("卡片已重置。")
        UpdateDisplay()
    End Sub
End Class
