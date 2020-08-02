Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'Dim es una palabra reservada para declarar una variable y as es el tipo de variable que sera
        Dim num1, num2, respuesta As Double 'Declaro las variables en una misma linea al mismo tiempo, en este caso "Double" 

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

        Select Case cboOperaciones.SelectedIndex
            Case 0
                lblrespuesta.Text = num1 + num2

            Case 1
                lblrespuesta.Text = num1 - num2

            Case 2
                lblrespuesta.Text = num1 * num2

            Case 3
                lblrespuesta.Text = num1 / num2

            Case 4
                lblrespuesta.Text = num1 ^ num2

            Case 5
                lblrespuesta.Text = num1 * num2 / 100

            Case 6
                lblrespuesta.Text = num1 Mod num2

        End Select


    End Sub
End Class
