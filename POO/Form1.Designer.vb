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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCalculosEstadisticos = New System.Windows.Forms.Button()
        Me.lblrespuestamedia = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lblrespuestavarianza = New System.Windows.Forms.Label()
        Me.lbldesvti = New System.Windows.Forms.Label()
        Me.lbldesvtipica = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "serie"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(232, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'btnCalculosEstadisticos
        '
        Me.btnCalculosEstadisticos.Location = New System.Drawing.Point(145, 327)
        Me.btnCalculosEstadisticos.Name = "btnCalculosEstadisticos"
        Me.btnCalculosEstadisticos.Size = New System.Drawing.Size(292, 62)
        Me.btnCalculosEstadisticos.TabIndex = 2
        Me.btnCalculosEstadisticos.Text = "Calculos estadisticos"
        Me.btnCalculosEstadisticos.UseVisualStyleBackColor = True
        '
        'lblrespuestamedia
        '
        Me.lblrespuestamedia.AutoSize = True
        Me.lblrespuestamedia.Location = New System.Drawing.Point(261, 162)
        Me.lblrespuestamedia.Name = "lblrespuestamedia"
        Me.lblrespuestamedia.Size = New System.Drawing.Size(16, 17)
        Me.lblrespuestamedia.TabIndex = 4
        Me.lblrespuestamedia.Text = "?"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(153, 162)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(46, 17)
        Me.lblMedia.TabIndex = 5
        Me.lblMedia.Text = "Media"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(153, 198)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(64, 17)
        Me.lblVarianza.TabIndex = 6
        Me.lblVarianza.Text = "Varianza"
        '
        'lblrespuestavarianza
        '
        Me.lblrespuestavarianza.AutoSize = True
        Me.lblrespuestavarianza.Location = New System.Drawing.Point(261, 207)
        Me.lblrespuestavarianza.Name = "lblrespuestavarianza"
        Me.lblrespuestavarianza.Size = New System.Drawing.Size(16, 17)
        Me.lblrespuestavarianza.TabIndex = 7
        Me.lblrespuestavarianza.Text = "?"
        '
        'lbldesvti
        '
        Me.lbldesvti.AutoSize = True
        Me.lbldesvti.Location = New System.Drawing.Point(392, 217)
        Me.lbldesvti.Name = "lbldesvti"
        Me.lbldesvti.Size = New System.Drawing.Size(16, 17)
        Me.lbldesvti.TabIndex = 8
        Me.lbldesvti.Text = "?"
        '
        'lbldesvtipica
        '
        Me.lbldesvtipica.AutoSize = True
        Me.lbldesvtipica.Location = New System.Drawing.Point(153, 238)
        Me.lbldesvtipica.Name = "lbldesvtipica"
        Me.lbldesvtipica.Size = New System.Drawing.Size(86, 17)
        Me.lbldesvtipica.TabIndex = 9
        Me.lbldesvtipica.Text = "Desv. Tipica"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbldesvtipica)
        Me.Controls.Add(Me.lbldesvti)
        Me.Controls.Add(Me.lblrespuestavarianza)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.lblrespuestamedia)
        Me.Controls.Add(Me.btnCalculosEstadisticos)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCalculosEstadisticos As Button
    Friend WithEvents lblrespuestamedia As Label
    Friend WithEvents lblMedia As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lblrespuestavarianza As Label
    Friend WithEvents lbldesvti As Label
    Friend WithEvents lbldesvtipica As Label
End Class
