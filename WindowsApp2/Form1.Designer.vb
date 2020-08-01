<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.llbnum1 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.optsuma = New System.Windows.Forms.RadioButton()
        Me.optresta = New System.Windows.Forms.RadioButton()
        Me.optmultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optmod = New System.Windows.Forms.RadioButton()
        Me.optdivision = New System.Windows.Forms.RadioButton()
        Me.optporcentaje = New System.Windows.Forms.RadioButton()
        Me.optexponente = New System.Windows.Forms.RadioButton()
        Me.lblcalcu = New System.Windows.Forms.Label()
        Me.blbprogra = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'llbnum1
        '
        Me.llbnum1.AutoSize = True
        Me.llbnum1.Location = New System.Drawing.Point(120, 84)
        Me.llbnum1.Name = "llbnum1"
        Me.llbnum1.Size = New System.Drawing.Size(43, 17)
        Me.llbnum1.TabIndex = 0
        Me.llbnum1.Text = "num1"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(170, 81)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 22)
        Me.txtnum1.TabIndex = 1
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(303, 152)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular.TabIndex = 2
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(335, 84)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(43, 17)
        Me.lblnum2.TabIndex = 3
        Me.lblnum2.Text = "num2"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(384, 84)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 22)
        Me.txtnum2.TabIndex = 4
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(511, 89)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(83, 17)
        Me.lblrespuesta.TabIndex = 5
        Me.lblrespuesta.Text = "respuesta:?"
        '
        'optsuma
        '
        Me.optsuma.AutoSize = True
        Me.optsuma.Location = New System.Drawing.Point(102, 127)
        Me.optsuma.Name = "optsuma"
        Me.optsuma.Size = New System.Drawing.Size(37, 21)
        Me.optsuma.TabIndex = 7
        Me.optsuma.TabStop = True
        Me.optsuma.Text = "+"
        Me.optsuma.UseVisualStyleBackColor = True
        '
        'optresta
        '
        Me.optresta.AutoSize = True
        Me.optresta.Location = New System.Drawing.Point(102, 154)
        Me.optresta.Name = "optresta"
        Me.optresta.Size = New System.Drawing.Size(34, 21)
        Me.optresta.TabIndex = 8
        Me.optresta.TabStop = True
        Me.optresta.Text = "-"
        Me.optresta.UseVisualStyleBackColor = True
        '
        'optmultiplicacion
        '
        Me.optmultiplicacion.AutoSize = True
        Me.optmultiplicacion.Location = New System.Drawing.Point(102, 181)
        Me.optmultiplicacion.Name = "optmultiplicacion"
        Me.optmultiplicacion.Size = New System.Drawing.Size(34, 21)
        Me.optmultiplicacion.TabIndex = 9
        Me.optmultiplicacion.TabStop = True
        Me.optmultiplicacion.Text = "*"
        Me.optmultiplicacion.UseVisualStyleBackColor = True
        '
        'optmod
        '
        Me.optmod.AutoSize = True
        Me.optmod.Location = New System.Drawing.Point(102, 289)
        Me.optmod.Name = "optmod"
        Me.optmod.Size = New System.Drawing.Size(61, 21)
        Me.optmod.TabIndex = 10
        Me.optmod.TabStop = True
        Me.optmod.Text = "MOD"
        Me.optmod.UseVisualStyleBackColor = True
        '
        'optdivision
        '
        Me.optdivision.AutoSize = True
        Me.optdivision.Location = New System.Drawing.Point(102, 208)
        Me.optdivision.Name = "optdivision"
        Me.optdivision.Size = New System.Drawing.Size(33, 21)
        Me.optdivision.TabIndex = 12
        Me.optdivision.TabStop = True
        Me.optdivision.Text = "/"
        Me.optdivision.UseVisualStyleBackColor = True
        '
        'optporcentaje
        '
        Me.optporcentaje.AutoSize = True
        Me.optporcentaje.Location = New System.Drawing.Point(102, 262)
        Me.optporcentaje.Name = "optporcentaje"
        Me.optporcentaje.Size = New System.Drawing.Size(41, 21)
        Me.optporcentaje.TabIndex = 13
        Me.optporcentaje.TabStop = True
        Me.optporcentaje.Text = "%"
        Me.optporcentaje.UseVisualStyleBackColor = True
        '
        'optexponente
        '
        Me.optexponente.AutoSize = True
        Me.optexponente.Location = New System.Drawing.Point(102, 235)
        Me.optexponente.Name = "optexponente"
        Me.optexponente.Size = New System.Drawing.Size(36, 21)
        Me.optexponente.TabIndex = 14
        Me.optexponente.TabStop = True
        Me.optexponente.Text = "^"
        Me.optexponente.UseVisualStyleBackColor = True
        '
        'lblcalcu
        '
        Me.lblcalcu.AutoSize = True
        Me.lblcalcu.Location = New System.Drawing.Point(559, 421)
        Me.lblcalcu.Name = "lblcalcu"
        Me.lblcalcu.Size = New System.Drawing.Size(85, 17)
        Me.lblcalcu.TabIndex = 15
        Me.lblcalcu.Text = "calculadora."
        '
        'blbprogra
        '
        Me.blbprogra.AutoSize = True
        Me.blbprogra.Location = New System.Drawing.Point(26, 421)
        Me.blbprogra.Name = "blbprogra"
        Me.blbprogra.Size = New System.Drawing.Size(58, 17)
        Me.blbprogra.TabIndex = 16
        Me.blbprogra.Text = "Progra I"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 450)
        Me.Controls.Add(Me.blbprogra)
        Me.Controls.Add(Me.lblcalcu)
        Me.Controls.Add(Me.optexponente)
        Me.Controls.Add(Me.optporcentaje)
        Me.Controls.Add(Me.optdivision)
        Me.Controls.Add(Me.optmod)
        Me.Controls.Add(Me.optmultiplicacion)
        Me.Controls.Add(Me.optresta)
        Me.Controls.Add(Me.optsuma)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.llbnum1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents llbnum1 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents Btncalcular As Button
    Friend WithEvents lblnum2 As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents optsuma As RadioButton
    Friend WithEvents optresta As RadioButton
    Friend WithEvents optmultiplicacion As RadioButton
    Friend WithEvents optmod As RadioButton
    Friend WithEvents optdivision As RadioButton
    Friend WithEvents optporcentaje As RadioButton
    Friend WithEvents optexponente As RadioButton
    Friend WithEvents lblcalcu As Label
    Friend WithEvents blbprogra As Label
End Class
