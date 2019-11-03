<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtemp
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
        Me.components = New System.ComponentModel.Container()
        Me.labeltxt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefress = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'labeltxt
        '
        Me.labeltxt.AutoSize = True
        Me.labeltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltxt.Location = New System.Drawing.Point(60, 126)
        Me.labeltxt.Name = "labeltxt"
        Me.labeltxt.Size = New System.Drawing.Size(78, 55)
        Me.labeltxt.TabIndex = 2
        Me.labeltxt.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "°C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Temperatura"
        '
        'btnRefress
        '
        Me.btnRefress.Location = New System.Drawing.Point(127, 12)
        Me.btnRefress.Name = "btnRefress"
        Me.btnRefress.Size = New System.Drawing.Size(85, 44)
        Me.btnRefress.TabIndex = 7
        Me.btnRefress.Text = "Ver/Update"
        Me.btnRefress.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmtemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(224, 218)
        Me.Controls.Add(Me.btnRefress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labeltxt)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmtemp"
        Me.Text = "frmtemp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labeltxt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefress As Button
    Friend WithEvents Timer1 As Timer
End Class
