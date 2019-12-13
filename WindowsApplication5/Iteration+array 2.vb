Public Class Form5

    Private hobby(5) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearList()

        hobby(0) = "reading"
        hobby(1) = "dancing"
        hobby(2) = "singing"
        hobby(3) = "travelling"
        hobby(4) = "hiking"
        hobby(5) = "walking"
       

        For num As Integer = 0 To hobby.Length - 1
            ListBox1.Items.Add(hobby(num))
        Next
    End Sub

    Private Sub clearList()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearList()

        Array.Sort(hobby)

        For number As Integer = 0 To hobby.Length - 1
            ListBox1.Items.Add(hobby(number))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
