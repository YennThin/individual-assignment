Imports System.IO
Imports System.Text
Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\user\Documents\Visual Studio 2013\Projects\WindowsApplication5\testFile.txt", True)

        file.WriteLine("BAHASA MELAYU")
        file.WriteLine("BAHASA INGGERIS")
        file.WriteLine("SEJARAH")
        file.WriteLine("BIOLOGI")
        file.WriteLine("KIMIA")
        file.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim line As String
        Dim readFile As System.IO.TextReader = New  _
            StreamReader("C:\Users\user\Documents\Visual Studio 2013\Projects\WindowsApplication5\testFile.txt")
        While True
            line = readFile.ReadLine()
            If line Is Nothing Then
                Exit While
            Else
                MsgBox(line)
            End If
        End While
        readFile.Close()
        readFile = Nothing
    End Sub
End Class