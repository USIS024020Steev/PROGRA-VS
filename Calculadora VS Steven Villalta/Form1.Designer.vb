<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.lblRespuestaromano = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(73, 123)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(108, 17)
        Me.lblnum.TabIndex = 1
        Me.lblnum.Text = "numero romano"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(187, 123)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 22)
        Me.txtnumero.TabIndex = 2
        '
        'lblRespuestaromano
        '
        Me.lblRespuestaromano.AutoSize = True
        Me.lblRespuestaromano.Location = New System.Drawing.Point(293, 128)
        Me.lblRespuestaromano.Name = "lblRespuestaromano"
        Me.lblRespuestaromano.Size = New System.Drawing.Size(127, 17)
        Me.lblRespuestaromano.TabIndex = 7
        Me.lblRespuestaromano.Text = "Numero Romano ?"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(161, 188)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(156, 62)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 318)
        Me.Controls.Add(Me.lblRespuestaromano)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Conversor de numeros decimales a romanos "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lblRespuestaromano As Label
    Friend WithEvents btnCalcular As Button
End Class
