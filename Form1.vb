Public Class Form1
    Private cards As New List(Of FlashCard)
    Private currentIndex As Integer = -1

    ' 加载一些示例卡片
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddSampleCards()
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        If cards.Count = 0 Then
            lblStatus.Text = "没有卡片"
        End If
    End Sub

    Private Sub AddSampleCards()
        cards.Add(New FlashCard("基本的推导式", "numbers=[x for x in numbers]"))
        cards.Add(New FlashCard("指定筛选条件的推导式", "odd_numbers=[x for x in numbers if x % 2 == 1]"))
        cards.Add(New FlashCard("执行某种计算的推导式", "[x * x for x in numbers]"))
        cards.Add(New FlashCard("指定筛选条件并执行某种计算的推导式", "squares= [x * x for x in numbers if x > 25]"))
    End Sub

    ' 显示下一张卡片
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < cards.Count - 1 Then
            currentIndex += 1
            ShowCurrentCard()
        Else
            currentIndex = 0
            ShowCurrentCard()
        End If
    End Sub

    ' 显示上一张卡片
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowCurrentCard()
        Else
            MessageBox.Show("已经是第一张卡片了。")
        End If
    End Sub

    ' 显示当前卡片
    Private Sub ShowCurrentCard()
        If cards.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < cards.Count Then
            UpdateStatus()
            Dim card As FlashCard = cards(currentIndex)
            Using cardForm As New CardForm(card)
                cardForm.ShowDialog()
            End Using
        Else
            lblStatus.Text = "没有卡片"
        End If
    End Sub

    ' 更新状态提示
    Private Sub UpdateStatus()
        If cards.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < cards.Count Then
            lblStatus.Text = $"卡片 {currentIndex + 1}/{cards.Count}"
        Else
            lblStatus.Text = "没有卡片"
        End If
    End Sub

    ' 打开添加新卡片窗口
    Private Sub BtnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click
        Using addEditForm As New AddEditCardForm()
            If addEditForm.ShowDialog() = DialogResult.OK Then
                Dim newCard As FlashCard = addEditForm.GetNewCard()
                cards.Add(newCard)
                currentIndex = cards.Count - 1
                ShowCurrentCard()
            End If
        End Using
    End Sub

    ' 开始浏览卡片
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cards.Count > 0 Then
            btnStart.Hide()
            currentIndex = 0
            ShowCurrentCard()
            btnNext.Enabled = True
            btnPrevious.Enabled = True
        Else
            MessageBox.Show("没有可用的卡片。")
        End If
    End Sub
End Class