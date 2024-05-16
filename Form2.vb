Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "enter name"
        Label2.Text = "rollno"
        Button1.Text = "submit"
        Label3.Text = "Name"
        Label4.Text = "rollno"
        Button2.Text = "submit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        n = TextBox1.Text
        Label3.Text = n
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer
        a = TextBox2.Text
        Label4.Text = a
    End Sub

End Class