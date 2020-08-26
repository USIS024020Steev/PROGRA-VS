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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.lbltiempo = New System.Windows.Forms.Label()
        Me.lblinteres = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.txttiempo = New System.Windows.Forms.TextBox()
        Me.lblInteressimple = New System.Windows.Forms.Label()
        Me.lblinteresCompuesto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(240, 253)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(156, 62)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(117, 123)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(49, 17)
        Me.lblCapital.TabIndex = 1
        Me.lblCapital.Text = "capital"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(187, 123)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 22)
        Me.txtCapital.TabIndex = 2
        '
        'lbltiempo
        '
        Me.lbltiempo.AutoSize = True
        Me.lbltiempo.Location = New System.Drawing.Point(548, 128)
        Me.lbltiempo.Name = "lbltiempo"
        Me.lbltiempo.Size = New System.Drawing.Size(101, 17)
        Me.lbltiempo.TabIndex = 3
        Me.lbltiempo.Text = "Tiempo (Años)"
        '
        'lblinteres
        '
        Me.lblinteres.AutoSize = True
        Me.lblinteres.Location = New System.Drawing.Point(345, 128)
        Me.lblinteres.Name = "lblinteres"
        Me.lblinteres.Size = New System.Drawing.Size(51, 17)
        Me.lblinteres.TabIndex = 4
        Me.lblinteres.Text = "interes"
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(402, 128)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(100, 22)
        Me.txtinteres.TabIndex = 5
        '
        'txttiempo
        '
        Me.txttiempo.Location = New System.Drawing.Point(655, 128)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(100, 22)
        Me.txttiempo.TabIndex = 6
        '
        'lblInteressimple
        '
        Me.lblInteressimple.AutoSize = True
        Me.lblInteressimple.Location = New System.Drawing.Point(153, 193)
        Me.lblInteressimple.Name = "lblInteressimple"
        Me.lblInteressimple.Size = New System.Drawing.Size(107, 17)
        Me.lblInteressimple.TabIndex = 7
        Me.lblInteressimple.Text = "Interes simple ?"
        '
        'lblinteresCompuesto
        '
        Me.lblinteresCompuesto.AutoSize = True
        Me.lblinteresCompuesto.Location = New System.Drawing.Point(336, 193)
        Me.lblinteresCompuesto.Name = "lblinteresCompuesto"
        Me.lblinteresCompuesto.Size = New System.Drawing.Size(138, 17)
        Me.lblinteresCompuesto.TabIndex = 8
        Me.lblinteresCompuesto.Text = "Interes Compuesto ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblinteresCompuesto)
        Me.Controls.Add(Me.lblInteressimple)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.lblinteres)
        Me.Controls.Add(Me.lbltiempo)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblCapital As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents lbltiempo As Label
    Friend WithEvents lblinteres As Label
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents txttiempo As TextBox
    Friend WithEvents lblInteressimple As Label
    Friend WithEvents lblinteresCompuesto As Label
End Class
