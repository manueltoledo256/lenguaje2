<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cod_articulo = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.btn_borrartodo = New System.Windows.Forms.Button()
        Me.btn_cargarprductos = New System.Windows.Forms.Button()
        Me.genera_factura = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carga de producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod_artículo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio"
        '
        'cod_articulo
        '
        Me.cod_articulo.Location = New System.Drawing.Point(319, 57)
        Me.cod_articulo.Name = "cod_articulo"
        Me.cod_articulo.Size = New System.Drawing.Size(100, 20)
        Me.cod_articulo.TabIndex = 5
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(319, 87)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(100, 20)
        Me.descripcion.TabIndex = 6
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(319, 120)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 20)
        Me.cantidad.TabIndex = 7
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(319, 149)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(100, 20)
        Me.precio.TabIndex = 8
        '
        'btn_borrartodo
        '
        Me.btn_borrartodo.Location = New System.Drawing.Point(231, 233)
        Me.btn_borrartodo.Name = "btn_borrartodo"
        Me.btn_borrartodo.Size = New System.Drawing.Size(94, 23)
        Me.btn_borrartodo.TabIndex = 9
        Me.btn_borrartodo.Text = "Borrar todo"
        Me.btn_borrartodo.UseVisualStyleBackColor = True
        '
        'btn_cargarprductos
        '
        Me.btn_cargarprductos.Location = New System.Drawing.Point(355, 233)
        Me.btn_cargarprductos.Name = "btn_cargarprductos"
        Me.btn_cargarprductos.Size = New System.Drawing.Size(94, 23)
        Me.btn_cargarprductos.TabIndex = 10
        Me.btn_cargarprductos.Text = "Cargar producto"
        Me.btn_cargarprductos.UseVisualStyleBackColor = True
        '
        'genera_factura
        '
        Me.genera_factura.Location = New System.Drawing.Point(231, 283)
        Me.genera_factura.Name = "genera_factura"
        Me.genera_factura.Size = New System.Drawing.Size(218, 23)
        Me.genera_factura.TabIndex = 11
        Me.genera_factura.Text = "Generar factura"
        Me.genera_factura.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.genera_factura)
        Me.Controls.Add(Me.btn_cargarprductos)
        Me.Controls.Add(Me.btn_borrartodo)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.cod_articulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cod_articulo As TextBox
    Friend WithEvents descripcion As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents precio As TextBox
    Friend WithEvents btn_borrartodo As Button
    Friend WithEvents btn_cargarprductos As Button
    Friend WithEvents genera_factura As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
