<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listPerson
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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.dgvPerson = New System.Windows.Forms.DataGridView()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnModify = New System.Windows.Forms.Button()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(12, 288)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(138, 37)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "Actualizar"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.usuario, Me.contraseña, Me.nombre, Me.telefono, Me.direccion, Me.cargo})
        Me.dgvPerson.Location = New System.Drawing.Point(5, 12)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPerson.Size = New System.Drawing.Size(913, 270)
        Me.dgvPerson.TabIndex = 2
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "cedula"
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "user"
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        '
        'contraseña
        '
        Me.contraseña.DataPropertyName = "contra"
        Me.contraseña.HeaderText = "Contraseña"
        Me.contraseña.Name = "contraseña"
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "tele"
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(170, 288)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(138, 37)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(332, 288)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(138, 37)
        Me.BtnModify.TabIndex = 4
        Me.BtnModify.Text = "Modificar"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'listPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 348)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvPerson)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Name = "listPerson"
        Me.Text = "listPerson"
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents dgvPerson As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnModify As Button
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents contraseña As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
End Class
