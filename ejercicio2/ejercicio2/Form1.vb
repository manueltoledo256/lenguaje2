Public Class Form1
    Private Sub BtnMensaje_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.mensaje = TextBox1.Text
        Dim f2 As New Form2()
        Me.Hide()
        f2.Show()
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LblNombre_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
