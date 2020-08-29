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
        Me.lbldepto = New System.Windows.Forms.Label()
        Me.lblmun = New System.Windows.Forms.Label()
        Me.cbxDepto = New System.Windows.Forms.ComboBox()
        Me.cbxMun = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbldepto
        '
        Me.lbldepto.AutoSize = True
        Me.lbldepto.Location = New System.Drawing.Point(28, 54)
        Me.lbldepto.Name = "lbldepto"
        Me.lbldepto.Size = New System.Drawing.Size(98, 17)
        Me.lbldepto.TabIndex = 1
        Me.lbldepto.Text = "Departamento"
        '
        'lblmun
        '
        Me.lblmun.AutoSize = True
        Me.lblmun.Location = New System.Drawing.Point(282, 54)
        Me.lblmun.Name = "lblmun"
        Me.lblmun.Size = New System.Drawing.Size(67, 17)
        Me.lblmun.TabIndex = 7
        Me.lblmun.Text = "Municipio"
        '
        'cbxDepto
        '
        Me.cbxDepto.FormattingEnabled = True
        Me.cbxDepto.Location = New System.Drawing.Point(132, 47)
        Me.cbxDepto.Name = "cbxDepto"
        Me.cbxDepto.Size = New System.Drawing.Size(121, 24)
        Me.cbxDepto.TabIndex = 8
        '
        'cbxMun
        '
        Me.cbxMun.FormattingEnabled = True
        Me.cbxMun.Location = New System.Drawing.Point(355, 47)
        Me.cbxMun.Name = "cbxMun"
        Me.cbxMun.Size = New System.Drawing.Size(121, 24)
        Me.cbxMun.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 318)
        Me.Controls.Add(Me.cbxMun)
        Me.Controls.Add(Me.cbxDepto)
        Me.Controls.Add(Me.lblmun)
        Me.Controls.Add(Me.lbldepto)
        Me.Name = "Form1"
        Me.Text = "Conversor de numeros decimales a romanos "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldepto As Label
    Friend WithEvents lblmun As Label
    Friend WithEvents cbxDepto As ComboBox
    Friend WithEvents cbxMun As ComboBox
End Class
