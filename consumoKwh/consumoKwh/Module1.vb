Module Module1
    Public Kwh As Double
    Public lista_consumo(4, 5) As Double
    Public consum As Double = 0
    Public total = 0

    Public Function Consumo(Kwh As Double) As Double
        Dim consumo_Kwh As Double
        consumo_Kwh = Kwh
        If consumo_Kwh < 30 Then
            total = consumo_Kwh * 0.5

        ElseIf consumo_Kwh < 100 Then
            total = consumo_Kwh - 30
            total = (total * 0.7) + 15

        ElseIf consumo_Kwh < 200 Then
            total = consumo_Kwh - 100
            total = (total * 0.85) + 64

        Else
            total = consumo_Kwh - 200
            total = (total * 1.7) + 149
        End If
        Return total
    End Function
End Module
