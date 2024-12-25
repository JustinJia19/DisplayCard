Public Class AddEditCardForm
    Private newCard As FlashCard

    ' 获取新建或编辑后的卡片
    Public Function GetNewCard() As FlashCard
        Return newCard
    End Function

    ' 确认按钮点击事件处理程序
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        newCard = New FlashCard(txtFront.Text, txtBack.Text)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' 取消按钮点击事件处理程序
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class