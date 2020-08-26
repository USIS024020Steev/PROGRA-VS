Public Class Form1

    Dim objinteres As New interes()
    Private Sub btnCapital_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        objinteres.interesdado = txtinteres.Text
        objinteres.tiempodado = txttiempo.Text
        objinteres.capitaldado = txtCapital.Text
        lblInteressimple.Text = "Interes simple: $" & objInteres.interesSimple()
        lblinteresCompuesto.Text = "Interes Compuesto: $" & objInteres.interesCompuesto()
    End Sub
End Class


Class interes
    Dim interesrecibido As Double
    Dim tiemporecibido As Int16
    Dim capitalrecibido As Double

    Public Property interesdado


    Public Function interesSimple(ByVal interes As Int16, ByVal ntiempo As Int16, ByVal capital As Double)
        Dim ins = capital * (interes / 100) * (ntiempo / 12)
        Math.Round(ins, 2)
    End Function

    Public Function interesCompuesto(ByVal interes As Int16, ByVal ntiempo As Int16, ByVal capital As Double)
        Dim inC = capital * (1 + interes / 100) ^ 2

    End Function
End Class
