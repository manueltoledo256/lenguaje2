<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.cuit = New System.Windows.Forms.TextBox()
        Me.domicilio = New System.Windows.Forms.TextBox()
        Me.localidad = New System.Windows.Forms.TextBox()
        Me.provincia = New System.Windows.Forms.TextBox()
        Me.tipofact = New System.Windows.Forms.ComboBox()
        Me.btn_aceptar1 = New System.Windows.Forms.Button()
        Me.btn_borrar1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos del cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "cuit/cuil"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo de factura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Domicilio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Localidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(294, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Provincia"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(374, 64)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 8
        '
        'apellido
        '
        Me.apellido.Location = New System.Drawing.Point(374, 91)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(100, 20)
        Me.apellido.TabIndex = 9
        '
        'cuit
        '
        Me.cuit.Location = New System.Drawing.Point(374, 122)
        Me.cuit.Name = "cuit"
        Me.cuit.Size = New System.Drawing.Size(100, 20)
        Me.cuit.TabIndex = 10
        '
        'domicilio
        '
        Me.domicilio.Location = New System.Drawing.Point(374, 184)
        Me.domicilio.Name = "domicilio"
        Me.domicilio.Size = New System.Drawing.Size(100, 20)
        Me.domicilio.TabIndex = 12
        '
        'localidad
        '
        Me.localidad.Location = New System.Drawing.Point(374, 211)
        Me.localidad.Name = "localidad"
        Me.localidad.Size = New System.Drawing.Size(100, 20)
        Me.localidad.TabIndex = 13
        '
        'provincia
        '
        Me.provincia.Location = New System.Drawing.Point(373, 238)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(100, 20)
        Me.provincia.TabIndex = 14
        '
        'tipofact
        '
        Me.tipofact.FormattingEnabled = True
        Me.tipofact.Items.AddRange(New Object() {"factura A", "factura B", "factura C"})
        Me.tipofact.Location = New System.Drawing.Point(374, 155)
        Me.tipofact.Name = "tipofact"
        Me.tipofact.Size = New System.Drawing.Size(100, 21)
        Me.tipofact.TabIndex = 15
        '
        'btn_aceptar1
        '
        Me.btn_aceptar1.Location = New System.Drawing.Point(389, 289)
        Me.btn_aceptar1.Name = "btn_aceptar1"
        Me.btn_aceptar1.Size = New System.Drawing.Size(85, 23)
        Me.btn_aceptar1.TabIndex = 16
        Me.btn_aceptar1.Text = "Cargar datos"
        Me.btn_aceptar1.UseVisualStyleBackColor = True
        '
        'btn_borrar1
        '
        Me.btn_borrar1.Location = New System.Drawing.Point(288, 289)
        Me.btn_borrar1.Name = "btn_borrar1"
        Me.btn_borrar1.Size = New System.Drawing.Size(85, 23)
        Me.btn_borrar1.TabIndex = 17
        Me.btn_borrar1.Text = "Borrar todo"
        Me.btn_borrar1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(82, 214)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(82, 98)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_borrar1)
        Me.Controls.Add(Me.btn_aceptar1)
        Me.Controls.Add(Me.tipofact)
        Me.Controls.Add(Me.provincia)
        Me.Controls.Add(Me.localidad)
        Me.Controls.Add(Me.domicilio)
        Me.Controls.Add(Me.cuit)
        Me.Controls.Add(Me.apellido)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents apellido As TextBox
    Friend WithEvents cuit As TextBox
    Friend WithEvents domicilio As TextBox
    Friend WithEvents localidad As TextBox
    Friend WithEvents provincia As TextBox
    Friend WithEvents tipofact As ComboBox
    Friend WithEvents btn_aceptar1 As Button
    Friend WithEvents btn_borrar1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
