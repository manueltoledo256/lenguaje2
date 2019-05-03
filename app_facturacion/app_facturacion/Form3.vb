Public Class Factura
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre.Text = matriz_cliente(0)
        apellido.Text = matriz_cliente(1)
        cuit.Text = matriz_cliente(2)
        tipo_factura.Text = matriz_cliente(3)
        domicilio.Text = matriz_cliente(4)
        localidad.Text = matriz_cliente(5)
        provincia.Text = matriz_cliente(6)
        Cod1.Text = matriz_producto(0, 0)
        Desc1.Text = matriz_producto(1, 0)
        Cant1.Text = matriz_producto(2, 0)
        Pre1.Text = matriz_producto(3, 0)
        Cod2.Text = matriz_producto(0, 1)
        Desc2.Text = matriz_producto(1, 1)
        Cant2.Text = matriz_producto(2, 1)
        Pre2.Text = matriz_producto(3, 1)
        Cod3.Text = matriz_producto(0, 2)
        Desc3.Text = matriz_producto(1, 2)
        Cant3.Text = matriz_producto(2, 2)
        Pre3.Text = matriz_producto(3, 2)
        Cod4.Text = matriz_producto(0, 3)
        Desc4.Text = matriz_producto(1, 3)
        Cant4.Text = matriz_producto(2, 3)
        Pre4.Text = matriz_producto(3, 3)
        Cod5.Text = matriz_producto(0, 4)
        Desc5.Text = matriz_producto(1, 4)
        Cant5.Text = matriz_producto(2, 4)
        Pre5.Text = matriz_producto(3, 4)
        Dim op_cant As Double
        Dim op_precio As Double
        Dim subtotal As Double
        Dim total As Double = 0
        '===================================================
        op_cant = CDbl(matriz_producto(2, 0))
        op_precio = CDbl(matriz_producto(3, 0))
        subtotal = op_cant * op_precio
        Sub1.Text = subtotal
        total = total + subtotal
        op_cant = 0
        op_precio = 0
        subtotal = 0
        '======================================================
        op_cant = CDbl(matriz_producto(2, 1))
        op_precio = CDbl(matriz_producto(3, 1))
        subtotal = op_cant * op_precio
        Sub2.Text = subtotal
        total = total + subtotal
        op_cant = 0
        op_precio = 0
        subtotal = 0
        Total1.Text = total
        '====================================================
        op_cant = CDbl(matriz_producto(2, 2))
        op_precio = CDbl(matriz_producto(3, 2))
        subtotal = op_cant * op_precio
        Sub3.Text = subtotal
        total = total + subtotal
        op_cant = 0
        op_precio = 0
        subtotal = 0
        Total1.Text = total
        '=======================
        op_cant = CDbl(matriz_producto(2, 3))
        op_precio = CDbl(matriz_producto(3, 3))
        subtotal = op_cant * op_precio
        Sub4.Text = subtotal
        total = total + subtotal
        op_cant = 0
        op_precio = 0
        subtotal = 0
        Total1.Text = total
        '=======================
        op_cant = CDbl(matriz_producto(2, 4))
        op_precio = CDbl(matriz_producto(3, 4))
        subtotal = op_cant * op_precio
        Sub5.Text = subtotal
        total = total + subtotal
        op_cant = 0
        op_precio = 0
        subtotal = 0
        Total1.Text = total
        '=======================
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Tipo_factura_Click(sender As Object, e As EventArgs) Handles tipo_factura.Click

    End Sub

    Private Sub Cod1_Click(sender As Object, e As EventArgs) Handles Cod1.Click

    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total1.Click

    End Sub
End Class