Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing.Text
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database4DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter2.Fill(Me.Database4DataSet.Table1)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("please fill all the information")
        Else
            On Error GoTo saveerror
            Table1BindingSource5.EndEdit()
            Table1TableAdapter2.Update(Database4DataSet.Table1)
            MessageBox.Show("data has been saved")
        End If
saveerror:
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource5.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Table1BindingSource5.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1BindingSource5.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        MAIN.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource5.AddNew()
    End Sub


End Class
