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
        Me.Txt_Kwh = New System.Windows.Forms.TextBox()
        Me.Btn_calcular = New System.Windows.Forms.Button()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese consumo en Kwh"
        '
        'Txt_Kwh
        '
        Me.Txt_Kwh.Location = New System.Drawing.Point(402, 113)
        Me.Txt_Kwh.Name = "Txt_Kwh"
        Me.Txt_Kwh.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Kwh.TabIndex = 1
        '
        'Btn_calcular
        '
        Me.Btn_calcular.Location = New System.Drawing.Point(342, 166)
        Me.Btn_calcular.Name = "Btn_calcular"
        Me.Btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.Btn_calcular.TabIndex = 2
        Me.Btn_calcular.Text = "Calcular"
        Me.Btn_calcular.UseVisualStyleBackColor = True
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(339, 228)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(85, 13)
        Me.Lbl_Resultado.TabIndex = 3
        Me.Lbl_Resultado.Text = "_____________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Btn_calcular)
        Me.Controls.Add(Me.Txt_Kwh)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Kwh As TextBox
    Friend WithEvents Btn_calcular As Button
    Friend WithEvents Lbl_Resultado As Label
End Class
