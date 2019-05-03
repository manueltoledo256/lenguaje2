Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cod_articulo.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles cantidad.TextChanged

    End Sub


    Private Sub Btn_cargarprductos_Click(sender As Object, e As EventArgs) Handles btn_cargarprductos.Click
        'Module1.cod_articulo = cod_articulo.Text
        'Module1.descripcion = descripcion.Text
        ' Module1.cantidad = cantidad.Text
        'Module1.precio = precio.Text
        matriz_producto(0, fila) = cod_articulo.Text
        matriz_producto(1, fila) = descripcion.Text
        matriz_producto(2, fila) = cantidad.Text
        matriz_producto(3, fila) = precio.Text
        fila = fila + 1
        cod_articulo.Text = ""
        descripcion.Text = ""
        cantidad.Text = ""
        precio.Text = ""
        'Console.WriteLine(fila)
    End Sub

    Private Sub Btn_borrartodo_Click(sender As Object, e As EventArgs) Handles btn_borrartodo.Click
        cod_articulo.Text = ""
        descripcion.Text = ""
        cantidad.Text = ""
        precio.Text = ""
    End Sub

    Private Sub Genera_factura_Click(sender As Object, e As EventArgs) Handles genera_factura.Click

        Me.Hide()
        Factura.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class