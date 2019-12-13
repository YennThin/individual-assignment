Public Class Form4

    Dim numbers(10) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To 10
            numbers(i) = CInt(InputBox("Enter integers"))
            ListBox1.Items.Add(numbers(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Array.Sort(numbers)
        displaySortedNumbers()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Array.Sort(numbers)
        Array.Reverse(numbers)
        displaySortedNumbers()
    End Sub

    Private Sub displaySortedNumbers()
        For Each item As Integer In numbers
            ListBox1.Items.Add(item)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class