Public Class FlashCard
    Public Property Front As String
    Public Property Back As String
    Public Property rightNum As Integer
    Public Property wrongNum As Integer
    Public Property sequentNum As Integer
    Public Property IsHidden As Boolean ' 新增属性


    Public Sub New(frontText As String, backText As String)
        Front = frontText
        Back = backText
        IsHidden = False ' 初始化为不隐藏
        rightNum = 0
        wrongNum = 0
        sequentNum = 0
    End Sub
End Class
