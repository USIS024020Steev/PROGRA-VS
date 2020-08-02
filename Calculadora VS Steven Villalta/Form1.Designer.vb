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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(85, 128)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButton1)
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
    Friend WithEvents RadioButton1 As RadioButton
End Class
