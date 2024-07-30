Module Module1

    Class Pictures

        Private Description As String
        Private Width As Integer
        Private Height As Integer
        Private FrameColour As String

        Public Sub New(ByVal D As String, ByVal W As Integer, ByVal H As Integer, ByVal F As String)
            Description = D
            Width = W
            Height = H
            FrameColour = F
        End Sub

        Public Sub SetDescription(ByVal D As String)
            Description = D

        End Sub
        Public Function GetDescription() As String
            Return Description
        End Function

        Public Function GetHeight() As Integer
            Return Height
        End Function

        Public Function GetWidth() As Integer
            Return Width
        End Function

        Public Function GetColour() As String
            Return FrameColour
        End Function

    End Class
    Function ReadData() As Pictures
        Dim PicArray(100) As Pictures
        Dim lineoftext As String
        Dim filehandle As IO.StreamReader
        Dim count As Integer
        Dim D, W, H, F As String
        Dim Picture As Integer

        filehandle = New IO.StreamReader("Pictures.txt")
        count = 0

        Do

            D = filehandle.ReadLine()
            W = filehandle.ReadLine()
            H = filehandle.ReadLine()
            F = filehandle.ReadLine()
            count = count + 1
            PicArray(count) = New Pictures(D, W, H, F)
            If count Mod 4 = 0 Then
                Picture = Picture + 1
            End If
        Loop Until filehandle.EndOfStream
        Return Get
    End Function
    Sub Main()
        Call ReadData()

    End Sub

End Module
