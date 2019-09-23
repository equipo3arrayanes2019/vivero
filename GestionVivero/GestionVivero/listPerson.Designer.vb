<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listPerson
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
        Me.dgvPerson = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Location = New System.Drawing.Point(12, 35)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.Size = New System.Drawing.Size(443, 207)
        Me.dgvPerson.TabIndex = 0
        '
        'listPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 254)
        Me.Controls.Add(Me.dgvPerson)
        Me.Name = "listPerson"
        Me.Text = "listPerson"
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPerson As DataGridView
End Class
