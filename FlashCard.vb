Public Class FlashCard
    Public Property Front As String
    Public Property Back As String
    Public Property rightNum As Integer
    Public Property wrongNum As Integer
    Public Property sequentNum As Integer
    Public Property memoryIndex As Integer
    Public Property IsHidden As Boolean ' 新增属性
    Public Property NextReviewDate As DateTime ' 下次复习日期
    Public Property EFactor As Double = 2.5 ' 易度因子，默认值为2.5


    Public Sub New(frontText As String, backText As String)
        Front = frontText
        Back = backText
        IsHidden = False ' 初始化为不隐藏
        rightNum = 0
        wrongNum = 0
        sequentNum = 0
        memoryIndex = 0
    End Sub

    Public Sub UpdateRepetition()
        ' ... SM-2算法或其他复习策略 ...
        ' 根据回答情况更新 memoryIndex
        If sequentNum <= 1 Then
            NextReviewDate = DateTime.Now.AddDays(1)
            memoryIndex = 1
        ElseIf sequentNum = 2 Then
            NextReviewDate = DateTime.Now.AddDays(6)
            memoryIndex = 2
        Else
            Dim interval As Double = Math.Floor(EFactor)
            NextReviewDate = DateTime.Now.AddDays(interval)
            memoryIndex = CInt(interval) + 1 ' 或者使用更复杂的规则来设定 memoryIndex
            EFactor = Math.Max(EFactor + 0.1, 1.3)
        End If
        sequentNum += 1
    End Sub
End Class
