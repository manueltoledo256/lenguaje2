Public Class Form1


    Private Sub Borrartodo_Click(sender As Object, e As EventArgs) Handles btn_borrar1.Click



    End Sub
    Private Sub Cargardatos_Click(sender As Object, e As EventArgs) Handles btn_aceptar1.Click
        matriz_cliente(0) = nombre.Text
        matriz_cliente(1) = apellido.Text
        matriz_cliente(2) = cuit.Text
        matriz_cliente(3) = tipofact.Text
        matriz_cliente(4) = domicilio.Text
        matriz_cliente(5) = localidad.Text
        matriz_cliente(6) = provincia.Text
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub FormCargaDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged

    End Sub

    Private Sub Apellido_TextChanged(sender As Object, e As EventArgs) Handles apellido.TextChanged

    End Sub

    Private Sub Cuit_TextChanged(sender As Object, e As EventArgs) Handles cuit.TextChanged

    End Sub

    Private Sub Domicilio_TextChanged(sender As Object, e As EventArgs) Handles domicilio.TextChanged

    End Sub

    Private Sub Localidad_TextChanged(sender As Object, e As EventArgs) Handles localidad.TextChanged

    End Sub
    Private Sub Provincia_TextChanged(sender As Object, e As EventArgs) Handles provincia.TextChanged

    End Sub

    Private Sub Tipofact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipofact.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
