<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoherramienta
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
        Me.dgvTools = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zona_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.dgvTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTools
        '
        Me.dgvTools.AllowUserToAddRows = False
        Me.dgvTools.AllowUserToDeleteRows = False
        Me.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo, Me.Zona_nombre, Me.id_Producto})
        Me.dgvTools.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTools.Location = New System.Drawing.Point(12, 12)
        Me.dgvTools.Name = "dgvTools"
        Me.dgvTools.Size = New System.Drawing.Size(571, 196)
        Me.dgvTools.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "uso"
        Me.id.HeaderText = "Uso"
        Me.id.Name = "id"
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo_Herramienta"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        '
        'Zona_nombre
        '
        Me.Zona_nombre.DataPropertyName = "Zona_nombre"
        Me.Zona_nombre.HeaderText = "Nombre_Zona"
        Me.Zona_nombre.Name = "Zona_nombre"
        '
        'id_Producto
        '
        Me.id_Producto.DataPropertyName = "id_Producto"
        Me.id_Producto.HeaderText = "Producto_ID"
        Me.id_Producto.Name = "id_Producto"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 235)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(110, 235)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmListadoherramienta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 281)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvTools)
        Me.Name = "frmListadoherramienta"
        Me.Text = "frmListadoherramienta"
        CType(Me.dgvTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTools As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents Zona_nombre As DataGridViewTextBoxColumn
    Friend WithEvents id_Producto As DataGridViewTextBoxColumn
End Class
