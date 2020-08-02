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
        Me.lblntabla = New System.Windows.Forms.Label()
        Me.txtntabla = New System.Windows.Forms.TextBox()
        Me.lstTablas = New System.Windows.Forms.ListBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblntabla
        '
        Me.lblntabla.AutoSize = True
        Me.lblntabla.Location = New System.Drawing.Point(102, 117)
        Me.lblntabla.Name = "lblntabla"
        Me.lblntabla.Size = New System.Drawing.Size(48, 17)
        Me.lblntabla.TabIndex = 0
        Me.lblntabla.Text = "Tabla:"
        '
        'txtntabla
        '
        Me.txtntabla.Location = New System.Drawing.Point(164, 114)
        Me.txtntabla.Name = "txtntabla"
        Me.txtntabla.Size = New System.Drawing.Size(100, 22)
        Me.txtntabla.TabIndex = 1
        '
        'lstTablas
        '
        Me.lstTablas.FormattingEnabled = True
        Me.lstTablas.ItemHeight = 16
        Me.lstTablas.Location = New System.Drawing.Point(290, 73)
        Me.lstTablas.Name = "lstTablas"
        Me.lstTablas.Size = New System.Drawing.Size(465, 292)
        Me.lstTablas.TabIndex = 2
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(96, 198)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(168, 83)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Generar tabla"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lstTablas)
        Me.Controls.Add(Me.txtntabla)
        Me.Controls.Add(Me.lblntabla)
        Me.Name = "Form1"
        Me.Text = "Tabla de multiplicar "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblntabla As Label
    Friend WithEvents txtntabla As TextBox
    Friend WithEvents lstTablas As ListBox
    Friend WithEvents btnCalcular As Button
End Class
