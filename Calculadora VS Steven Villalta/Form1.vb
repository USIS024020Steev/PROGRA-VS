Public Class Form1

    Private Sub btnCalcular_Click_1(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim ntabla, i As Int64
        ntabla = txtntabla.Text
        i = 1

        lstTablas.Items.Clear()
        Do While i <= 10
            lstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            i = i + 1
        Loop


    End Sub
End Class
