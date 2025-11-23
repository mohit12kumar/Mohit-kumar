Imports System.Data.OleDb

Public Class loginpage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim pass As String
        Dim passs As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("please fill all the information")
        Else
            name = TextBox1.Text
            pass = TextBox2.Text

            Dim querry As String = " select password from table1 where user = '" & name & "' ;"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\riyam\OneDrive\Desktop\data base\login\database5.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                passs = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show("user not does not exist")
            End Try
            If (pass = passs) Then
                MessageBox.Show("login success")
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
                Form5.Show()
            Else
                MessageBox.Show("login failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        registeruser.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub




End Class