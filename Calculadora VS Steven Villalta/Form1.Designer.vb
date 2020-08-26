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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lstejercicios = New System.Windows.Forms.ListBox()
        Me.btnparImpar = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.btnprimo = New System.Windows.Forms.Button()
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(62, 338)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(186, 49)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Pares e Impares"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lstejercicios
        '
        Me.lstejercicios.FormattingEnabled = True
        Me.lstejercicios.ItemHeight = 16
        Me.lstejercicios.Location = New System.Drawing.Point(62, 43)
        Me.lstejercicios.Name = "lstejercicios"
        Me.lstejercicios.Size = New System.Drawing.Size(186, 276)
        Me.lstejercicios.TabIndex = 1
        '
        'btnparImpar
        '
        Me.btnparImpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnparImpar.Location = New System.Drawing.Point(358, 150)
        Me.btnparImpar.Name = "btnparImpar"
        Me.btnparImpar.Size = New System.Drawing.Size(173, 49)
        Me.btnparImpar.TabIndex = 2
        Me.btnparImpar.Text = "Par o Impar?"
        Me.btnparImpar.UseVisualStyleBackColor = True
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(499, 88)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(100, 22)
        Me.txtnum.TabIndex = 3
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(417, 91)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(62, 17)
        Me.lblnum.TabIndex = 4
        Me.lblnum.Text = "Numero:"
        '
        'btnprimo
        '
        Me.btnprimo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprimo.Location = New System.Drawing.Point(558, 150)
        Me.btnprimo.Name = "btnprimo"
        Me.btnprimo.Size = New System.Drawing.Size(173, 49)
        Me.btnprimo.TabIndex = 5
        Me.btnprimo.Text = "Primo?"
        Me.btnprimo.UseVisualStyleBackColor = True
        '
        'btnCajero
        '
        Me.btnCajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.Location = New System.Drawing.Point(485, 214)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(126, 66)
        Me.btnCajero.TabIndex = 6
        Me.btnCajero.Text = "Cajero "
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 450)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnprimo)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnparImpar)
        Me.Controls.Add(Me.lstejercicios)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "Form1"
        Me.Text = "Ejercicios con estructuras de control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents lstejercicios As ListBox
    Friend WithEvents btnparImpar As Button
    Friend WithEvents txtnum As TextBox
    Friend WithEvents lblnum As Label
    Friend WithEvents btnprimo As Button
    Friend WithEvents btnCajero As Button
End Class
