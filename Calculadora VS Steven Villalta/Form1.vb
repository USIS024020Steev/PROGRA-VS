Public Class Form1

    Private Sub btnCalcular_Click_1(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim ntabla, i As SByte
        ntabla = txtntabla.Text

        lstTablas.Items.Clear()

        If ntabla <= 12 Then
            For i = 1 To 10
                lstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            lstTablas.Items.Add("por favor ingrese solo tablas menores o iguales a 12")
        End If

    End Sub
End Class
