Public Class Form1
    Private Sub Btn_calcular_Click(sender As Object, e As EventArgs) Handles Btn_calcular.Click
        Dim puente As Double
        Kwh = Txt_Kwh.Text
        Kwh = CDbl(Kwh)
        puente = Module1.Consumo(Kwh)
        Lbl_Resultado.Text = puente
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txt_Kwh_TextChanged(sender As Object, e As EventArgs) Handles Txt_Kwh.TextChanged

    End Sub
End Class
