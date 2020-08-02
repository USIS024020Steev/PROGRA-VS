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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.optsuma = New System.Windows.Forms.RadioButton()
        Me.optresta = New System.Windows.Forms.RadioButton()
        Me.optmultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optdivision = New System.Windows.Forms.RadioButton()
        Me.optexponente = New System.Windows.Forms.RadioButton()
        Me.optporcentaje = New System.Windows.Forms.RadioButton()
        Me.optmod = New System.Windows.Forms.RadioButton()
        Me.cboOperaciones = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(82, 35)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(43, 17)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "num1"
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(246, 37)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(43, 17)
        Me.lblnum2.TabIndex = 1
        Me.lblnum2.Text = "num2"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(131, 32)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 22)
        Me.txtnum1.TabIndex = 2
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(295, 32)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 22)
        Me.txtnum2.TabIndex = 3
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(445, 37)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(83, 17)
        Me.lblrespuesta.TabIndex = 4
        Me.lblrespuesta.Text = "respuesta ?"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(228, 78)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 5
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'optsuma
        '
        Me.optsuma.AutoSize = True
        Me.optsuma.Location = New System.Drawing.Point(85, 139)
        Me.optsuma.Name = "optsuma"
        Me.optsuma.Size = New System.Drawing.Size(37, 21)
        Me.optsuma.TabIndex = 6
        Me.optsuma.TabStop = True
        Me.optsuma.Text = "+"
        Me.optsuma.UseVisualStyleBackColor = True
        '
        'optresta
        '
        Me.optresta.AutoSize = True
        Me.optresta.Location = New System.Drawing.Point(85, 166)
        Me.optresta.Name = "optresta"
        Me.optresta.Size = New System.Drawing.Size(34, 21)
        Me.optresta.TabIndex = 7
        Me.optresta.TabStop = True
        Me.optresta.Text = "-"
        Me.optresta.UseVisualStyleBackColor = True
        '
        'optmultiplicacion
        '
        Me.optmultiplicacion.AutoSize = True
        Me.optmultiplicacion.Location = New System.Drawing.Point(85, 193)
        Me.optmultiplicacion.Name = "optmultiplicacion"
        Me.optmultiplicacion.Size = New System.Drawing.Size(34, 21)
        Me.optmultiplicacion.TabIndex = 8
        Me.optmultiplicacion.TabStop = True
        Me.optmultiplicacion.Text = "*"
        Me.optmultiplicacion.UseVisualStyleBackColor = True
        '
        'optdivision
        '
        Me.optdivision.AutoSize = True
        Me.optdivision.Location = New System.Drawing.Point(85, 220)
        Me.optdivision.Name = "optdivision"
        Me.optdivision.Size = New System.Drawing.Size(33, 21)
        Me.optdivision.TabIndex = 9
        Me.optdivision.TabStop = True
        Me.optdivision.Text = "/"
        Me.optdivision.UseVisualStyleBackColor = True
        '
        'optexponente
        '
        Me.optexponente.AutoSize = True
        Me.optexponente.Location = New System.Drawing.Point(85, 247)
        Me.optexponente.Name = "optexponente"
        Me.optexponente.Size = New System.Drawing.Size(36, 21)
        Me.optexponente.TabIndex = 10
        Me.optexponente.TabStop = True
        Me.optexponente.Text = "^"
        Me.optexponente.UseVisualStyleBackColor = True
        '
        'optporcentaje
        '
        Me.optporcentaje.AutoSize = True
        Me.optporcentaje.Location = New System.Drawing.Point(85, 274)
        Me.optporcentaje.Name = "optporcentaje"
        Me.optporcentaje.Size = New System.Drawing.Size(41, 21)
        Me.optporcentaje.TabIndex = 11
        Me.optporcentaje.TabStop = True
        Me.optporcentaje.Text = "%"
        Me.optporcentaje.UseVisualStyleBackColor = True
        '
        'optmod
        '
        Me.optmod.AutoSize = True
        Me.optmod.Location = New System.Drawing.Point(85, 301)
        Me.optmod.Name = "optmod"
        Me.optmod.Size = New System.Drawing.Size(61, 21)
        Me.optmod.TabIndex = 12
        Me.optmod.TabStop = True
        Me.optmod.Text = "MOD"
        Me.optmod.UseVisualStyleBackColor = True
        '
        'cboOperaciones
        '
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.Items.AddRange(New Object() {"+", "-", "*", "/", "^", "%", "MOD"})
        Me.cboOperaciones.Location = New System.Drawing.Point(274, 139)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(131, 24)
        Me.cboOperaciones.TabIndex = 13
        Me.cboOperaciones.Text = "elige una opcion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboOperaciones)
        Me.Controls.Add(Me.optmod)
        Me.Controls.Add(Me.optporcentaje)
        Me.Controls.Add(Me.optexponente)
        Me.Controls.Add(Me.optdivision)
        Me.Controls.Add(Me.optmultiplicacion)
        Me.Controls.Add(Me.optresta)
        Me.Controls.Add(Me.optsuma)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum1 As Label
    Friend WithEvents lblnum2 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents optsuma As RadioButton
    Friend WithEvents optresta As RadioButton
    Friend WithEvents optmultiplicacion As RadioButton
    Friend WithEvents optdivision As RadioButton
    Friend WithEvents optexponente As RadioButton
    Friend WithEvents optporcentaje As RadioButton
    Friend WithEvents optmod As RadioButton
    Friend WithEvents cboOperaciones As ComboBox
End Class
