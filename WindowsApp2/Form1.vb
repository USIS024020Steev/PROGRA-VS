Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnum1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles llbnum1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        'Dim es la palabra reservada para poder declarar una variable
        Dim num1, num2, respuesta As Double 'Declaro las variables en una misma lina del mismo tipo, en este caso "double"

        num1 = txtnum1.Text 'Se captura el valor que digite el usario en la caja de texto numero 1 
        num2 = txtnum2.Text 'Se captura el valor que digite el usario en la caja de texto numero 2

        If optsuma.Checked Then
            lblrespuesta.Text = num1 + num2
        End If

        If optresta.Checked Then
            lblrespuesta.Text = num1 - num2
        End If

        If optmultiplicacion.Checked Then
            lblrespuesta.Text = num1 * num2
        End If

        If optdivision.Checked Then
            lblrespuesta.Text = num1 / num2
        End If

        If optexponente.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If

        If optporcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100
        End If

        If optmod.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optsuma.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles optresta.CheckedChanged

    End Sub

    Private Sub lblrespuesta_Click(sender As Object, e As EventArgs) Handles lblrespuesta.Click

    End Sub

    Private Sub lblcalcu_Click(sender As Object, e As EventArgs) Handles lblcalcu.Click

    End Sub

    Private Sub blbprogra_Click(sender As Object, e As EventArgs) Handles blbprogra.Click

    End Sub
End Class
