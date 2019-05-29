Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tiempoapp.Tick
        Module1.Funcion_tiempo()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tiempoapp.Enabled = True

    End Sub

    Private Sub Lbl_segundos_Click(sender As Object, e As EventArgs) Handles lbl_segundos.Click

    End Sub
End Class
