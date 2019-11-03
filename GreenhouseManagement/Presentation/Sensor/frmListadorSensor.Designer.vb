<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadorSensor
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
        Me.dgvSensor = New System.Windows.Forms.DataGridView()
        Me.btnUpdateSensor = New System.Windows.Forms.Button()
        CType(Me.dgvSensor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSensor
        '
        Me.dgvSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSensor.Location = New System.Drawing.Point(32, 40)
        Me.dgvSensor.Name = "dgvSensor"
        Me.dgvSensor.Size = New System.Drawing.Size(240, 150)
        Me.dgvSensor.TabIndex = 0
        '
        'btnUpdateSensor
        '
        Me.btnUpdateSensor.BackColor = System.Drawing.Color.DarkBlue
        Me.btnUpdateSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSensor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateSensor.Location = New System.Drawing.Point(32, 219)
        Me.btnUpdateSensor.Name = "btnUpdateSensor"
        Me.btnUpdateSensor.Size = New System.Drawing.Size(99, 31)
        Me.btnUpdateSensor.TabIndex = 1
        Me.btnUpdateSensor.Text = "Actualizar"
        Me.btnUpdateSensor.UseVisualStyleBackColor = False
        '
        'frmListadorSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnUpdateSensor)
        Me.Controls.Add(Me.dgvSensor)
        Me.Name = "frmListadorSensor"
        Me.Text = "frmListadorSensor"
        CType(Me.dgvSensor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSensor As DataGridView
    Friend WithEvents btnUpdateSensor As Button
End Class
