<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoZona
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
        Me.btnUpdateZona = New System.Windows.Forms.Button()
        Me.dgvZona = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tamaño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateZona
        '
        Me.btnUpdateZona.BackColor = System.Drawing.Color.DarkBlue
        Me.btnUpdateZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateZona.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateZona.Location = New System.Drawing.Point(12, 227)
        Me.btnUpdateZona.Name = "btnUpdateZona"
        Me.btnUpdateZona.Size = New System.Drawing.Size(99, 31)
        Me.btnUpdateZona.TabIndex = 0
        Me.btnUpdateZona.Text = "Actualizar"
        Me.btnUpdateZona.UseVisualStyleBackColor = False
        '
        'dgvZona
        '
        Me.dgvZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.tamaño, Me.tipo})
        Me.dgvZona.Location = New System.Drawing.Point(12, 12)
        Me.dgvZona.Name = "dgvZona"
        Me.dgvZona.Size = New System.Drawing.Size(340, 209)
        Me.dgvZona.TabIndex = 1
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'tamaño
        '
        Me.tamaño.DataPropertyName = "tamaño"
        Me.tamaño.HeaderText = "Tamaño"
        Me.tamaño.Name = "tamaño"
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        '
        'frmListadoZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 264)
        Me.Controls.Add(Me.dgvZona)
        Me.Controls.Add(Me.btnUpdateZona)
        Me.Name = "frmListadoZona"
        Me.Text = "frmListadoZona"
        CType(Me.dgvZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdateZona As Button
    Friend WithEvents dgvZona As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents tamaño As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
End Class
