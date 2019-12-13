Public Class Form1

    Private Property larger As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer

        x = TextBox1.Text
        y = TextBox2.Text


        For x = 0 To TextBox2.Text Step 10
            ListBox1.Items.Add(x)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
