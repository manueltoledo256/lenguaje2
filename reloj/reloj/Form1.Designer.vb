<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl_horas = New System.Windows.Forms.Label()
        Me.lbl_minutos = New System.Windows.Forms.Label()
        Me.lbl_segundos = New System.Windows.Forms.Label()
        Me.tiempoapp = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbl_horas
        '
        Me.lbl_horas.AutoSize = True
        Me.lbl_horas.Location = New System.Drawing.Point(87, 13)
        Me.lbl_horas.Name = "lbl_horas"
        Me.lbl_horas.Size = New System.Drawing.Size(13, 13)
        Me.lbl_horas.TabIndex = 0
        Me.lbl_horas.Text = "0"
        '
        'lbl_minutos
        '
        Me.lbl_minutos.AutoSize = True
        Me.lbl_minutos.Location = New System.Drawing.Point(189, 13)
        Me.lbl_minutos.Name = "lbl_minutos"
        Me.lbl_minutos.Size = New System.Drawing.Size(13, 13)
        Me.lbl_minutos.TabIndex = 1
        Me.lbl_minutos.Text = "0"
        '
        'lbl_segundos
        '
        Me.lbl_segundos.AutoSize = True
        Me.lbl_segundos.Location = New System.Drawing.Point(304, 13)
        Me.lbl_segundos.Name = "lbl_segundos"
        Me.lbl_segundos.Size = New System.Drawing.Size(13, 13)
        Me.lbl_segundos.TabIndex = 2
        Me.lbl_segundos.Text = "0"
        '
        'tiempoapp
        '
        Me.tiempoapp.Enabled = True
        Me.tiempoapp.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_segundos)
        Me.Controls.Add(Me.lbl_minutos)
        Me.Controls.Add(Me.lbl_horas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_horas As Label
    Friend WithEvents lbl_minutos As Label
    Friend WithEvents lbl_segundos As Label
    Friend WithEvents tiempoapp As Timer
End Class
