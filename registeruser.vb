Imports Microsoft.VisualBasic.Logging

Public Class registeruser
    Private Sub registeruser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database5DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database5DataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo saveerror
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Database5DataSet.Table1)
        MessageBox.Show("data has been saved")
        Me.Close()
        loginpage.Show()
saveerror:
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        loginpage.Show()
    End Sub
End Class