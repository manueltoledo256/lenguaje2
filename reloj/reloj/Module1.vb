Module Module1
    Public horas As Integer = 23
    Public minutos As Integer = 0
    Public segundos As Integer = 0

    Public Sub Funcion_tiempo()

        Module1.segundos = Module1.segundos + 1
        If Module1.segundos = 59 Then
            Module1.segundos = 0
            Module1.minutos = Module1.minutos + 1
        End If
        If Module1.minutos = 59 Then
            Module1.minutos = 0
            Module1.horas = Module1.horas + 1
        End If
        If Module1.horas = 25 Then
            Module1.segundos = 0
            Module1.minutos = 0
            Module1.horas = 0
        End If
        Form1.lbl_segundos.Text = Module1.segundos
        Form1.lbl_minutos.Text = Module1.minutos
        Form1.lbl_horas.Text = Module1.horas
    End Sub
End Module
