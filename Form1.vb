Imports Newtonsoft.Json
Imports System.IO

Public Class Form1
    Private cards As New List(Of FlashCard)
    Private currentIndex As Integer = -1
    Private showHiddenCards As Boolean = False ' 状态变量，默认为False表示显示未隐藏卡片
    Private dataFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FlashCardApp", "cards.json")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCards() ' 加载卡片数据
        If cards.Count = 0 Then
            'AddSampleCards() ' 如果没有加载到卡片，则添加示例卡片
        End If
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        lblStatus.Text = "没有卡片"

        ' 初始化按钮文字
        btn_OverviewHiddenCard.Text = "查看隐藏卡片" ' 默认情况下显示隐藏卡片
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveCards() ' 保存卡片数据
    End Sub

    Private Function GetVisibleCards() As List(Of FlashCard)
        Return cards.Where(Function(c) Not c.IsHidden).ToList()
    End Function

    Private Sub SaveCards()
        ' 确保 dataFilePath 是一个变量，它包含了要保存的文件的完整路径
        ' 使用 Path.Combine 来构建文件路径
        Dim directory2 As String = Path.GetDirectoryName(dataFilePath)

        ' 检查目录是否存在，如果不存在，则创建它
        If Not Directory.Exists(directory2) Then
            Directory.CreateDirectory(directory2)
        End If

        ' 将 cards 集合序列化为 JSON 字符串
        Dim json As String = JsonConvert.SerializeObject(cards, Formatting.Indented)

        ' 使用 StreamWriter 将 JSON 字符串写入文件
        Using writer As StreamWriter = New StreamWriter(dataFilePath, False, System.Text.Encoding.UTF8)
            writer.Write(json)
        End Using
    End Sub


    Private Sub LoadCards()
        If File.Exists(dataFilePath) Then
            Try
                Using reader As StreamReader = New StreamReader(dataFilePath)
                    Dim json As String = reader.ReadToEnd()
                    cards = JsonConvert.DeserializeObject(Of List(Of FlashCard))(json)
                    If cards Is Nothing Then
                        cards = New List(Of FlashCard)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("加载卡片数据时发生错误: " & ex.Message)
                cards = New List(Of FlashCard)()
            End Try
        End If
    End Sub

    'Private Sub AddSampleCards()
    'cards.Add(New FlashCard("基本的推导式", "numbers=[x for x in numbers]"))
    'cards.Add(New FlashCard("指定筛选条件的推导式", "odd_numbers=[x for x in numbers if x % 2 == 1]"))
    'cards.Add(New FlashCard("执行某种计算的推导式", "[x * x for x in numbers]"))
    'cards.Add(New FlashCard("指定筛选条件并执行某种计算的推导式", "squares= [x * x for x in numbers if x > 25]"))
    'End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim filteredCards = If(showHiddenCards, cards.Where(Function(c) c.IsHidden).ToList(), GetVisibleCards())
        If filteredCards.Count = 0 Then
            MessageBox.Show("当前设置下没有符合条件的卡片。")
            Return
        End If

        If currentIndex < filteredCards.Count - 1 Then
            currentIndex += 1
            ShowCurrentCard()
        ElseIf filteredCards.Count > 0 Then
            currentIndex = 0
            ShowCurrentCard()
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim filteredCards = If(showHiddenCards, cards.Where(Function(c) c.IsHidden).ToList(), GetVisibleCards())
        If filteredCards.Count = 0 Then
            MessageBox.Show("暂无卡片，请添加！")
            Return
        End If

        If currentIndex > 0 Then
            currentIndex -= 1
            ShowCurrentCard()
        ElseIf currentIndex = 0 AndAlso filteredCards.Count > 0 Then
            MessageBox.Show("已经是第一张卡片了。")
        End If
    End Sub

    Private Sub ShowCurrentCard()
        Dim filteredCards As List(Of FlashCard) = If(showHiddenCards, cards.Where(Function(c) c.IsHidden).ToList(), GetVisibleCards())

        If filteredCards.Count = 0 Then
            lblStatus.Text = "没有卡片"
            MessageBox.Show("当前设置下没有符合条件的卡片。")
            Return
        End If

        If currentIndex >= 0 AndAlso currentIndex < filteredCards.Count Then
            UpdateStatus(filteredCards)
            Dim card As FlashCard = filteredCards(currentIndex)

            ' 使用匿名方法订阅 CardForm 的 CardDeleted 事件
            Using cardForm As New CardForm(card) With {.Tag = card}
                AddHandler cardForm.CardDeleted, Sub(deletedCard)
                                                     ' 在 UI 线程上执行卡片删除操作
                                                     Invoke(Sub()
                                                                RemoveCard(deletedCard)
                                                            End Sub)
                                                 End Sub
                cardForm.ShowDialog()
            End Using
        Else
            lblStatus.Text = "没有卡片"
        End If
    End Sub

    ' 移除卡片的方法
    Private Sub RemoveCard(card As FlashCard)
        If cards.Contains(card) Then
            cards.Remove(card)
            ' 如果删除的是当前显示的卡片，更新索引和界面
            If card Is GetVisibleCards().ElementAtOrDefault(currentIndex) Then
                UpdateVisibleCards()
            End If
        End If
    End Sub

    Private Sub UpdateVisibleCards()
        currentIndex = Math.Max(0, Math.Min(currentIndex, GetVisibleCards().Count - 1))
        ShowCurrentCard()
        UpdateStatus()
    End Sub

    Private Sub UpdateStatus(Optional filteredCards As List(Of FlashCard) = Nothing)
        If filteredCards Is Nothing Then
            filteredCards = If(showHiddenCards, cards.Where(Function(c) c.IsHidden).ToList(), GetVisibleCards())
        End If

        If filteredCards.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < filteredCards.Count Then
            lblStatus.Text = $"卡片 {currentIndex + 1}/{filteredCards.Count}"
        Else
            lblStatus.Text = "没有卡片"
        End If
    End Sub

    Private Sub BtnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click
        Using addEditForm As New AddEditCardForm()
            If addEditForm.ShowDialog() = DialogResult.OK Then
                Dim newCard As FlashCard = addEditForm.GetNewCard()
                cards.Add(newCard)

            End If
            MessageBox.Show("卡片添加成功！")
        End Using
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim visibleCards = GetVisibleCards()
        If visibleCards.Count > 0 Then
            btnStart.Hide()
            currentIndex = 0
            ShowCurrentCard()
            btnNext.Enabled = True
            btnPrevious.Enabled = True
        Else
            MessageBox.Show("没有可见卡片可以开始浏览。")
        End If
    End Sub

    Private Sub btn_OverviewHiddenCard_Click(sender As Object, e As EventArgs) Handles btn_OverviewHiddenCard.Click
        ' 切换显示隐藏或可见卡片
        showHiddenCards = Not showHiddenCards

        ' 更新按钮文字以反映新的状态
        If showHiddenCards Then
            btn_OverviewHiddenCard.Text = "查看未隐藏卡片"
        Else
            btn_OverviewHiddenCard.Text = "查看隐藏卡片"
        End If

        ' 重置索引以确保从头开始浏览
        currentIndex = 0

        ' 更新界面以反映新的卡片集
        ShowCurrentCard()
    End Sub

    Private Sub btn_Random_Click(sender As Object, e As EventArgs) Handles btn_Random.Click
        ' 获取可见卡片列表
        Dim visibleCards = GetVisibleCards()

        If visibleCards.Count > 0 Then
            ' 随机选取一张卡片
            Dim randomIndex As Integer = New Random().Next(visibleCards.Count)
            currentIndex = visibleCards.FindIndex(Function(c) c Is visibleCards(randomIndex))

            ' 显示随机卡片
            ShowCurrentCard()
        Else
            MessageBox.Show("当前没有可用的卡片。")
        End If
    End Sub
End Class