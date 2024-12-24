Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class CardForm
    Private isFrontVisible As Boolean = True
    Private currentCard As FlashCard

    Public Sub New(card As FlashCard)
        InitializeComponent()
        currentCard = card
        UpdateDisplay()
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
        ' 检查连续正确次数是否达到3，如果达到则隐藏卡片
        If currentCard.sequentNum >= 3 Then
            currentCard.IsHidden = True
        End If
        Me.Close()
    End Sub

    Private Sub btnWrong_Click(sender As Object, e As EventArgs) Handles btnWrong.Click
        currentCard.wrongNum = currentCard.wrongNum + 1
        currentCard.sequentNum = 0
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

    End Sub
End Class
