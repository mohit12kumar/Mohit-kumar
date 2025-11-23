Public Class Form5
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        Dim i As Integer
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 600
        For i = 0 To 600
            ProgressBar1.Value = i


        Next
        Me.Close()
        MAIN.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        loginpage.Show()
    End Sub

End Class