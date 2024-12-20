Public Class FlashCard
    Public Property Front As String
    Public Property Back As String
    Public Property rightNum As Integer
    Public Property wrongNum As Integer
    Public Property sequentNum As Integer

    Public Sub New(frontText As String, backText As String)
        Front = frontText
        Back = backText
    End Sub
End Class
