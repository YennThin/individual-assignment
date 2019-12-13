Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer
        Dim i As Integer

        x = TextBox1.Text
        y = TextBox2.Text

        For i = TextBox1.Text To TextBox2.Text
            i = x + y
            ListBox1.Items.Add(i)
            If i Mod 2 = 0 Then
                ListBox1.Items.Clear()
                MsgBox("Error!")
            End If
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