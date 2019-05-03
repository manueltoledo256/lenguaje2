Public Class Form1
    Private Sub Txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Nombre_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_mensaje_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.mensaje = TextBox1.Text

        Dim f2 As New Form2()
        f2.Show()
    End Sub
End Class
