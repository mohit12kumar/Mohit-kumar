Imports System.Diagnostics.Eventing.Reader

Public Class Form4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyPicture As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        With OpenFileDialog1
            .Filter = "JPG,JPEG image|*.jpg,jpeg|PNG image|*.png|BMP image|*.bmp|" & "All files (*.*)|*.*"
            .Title = " choose the picture ..."
            .FilterIndex = 1
            .Multiselect = False
            .ValidateNames = True
            .InitialDirectory = MyPicture
            .RestoreDirectory = True
            If (.ShowDialog = DialogResult.OK) Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database6DataSet.Table1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("please fill all the information")
        Else
            On Error GoTo saveerror
            Table1BindingSource.EndEdit()
            Table1TableAdapter.Update(Database6DataSet.Table1)
            MessageBox.Show("data has been saved")
saveerror:
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        MAIN.Show()
    End Sub
End Class