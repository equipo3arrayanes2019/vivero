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
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnModify = New System.Windows.Forms.Button()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(12, 272)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(138, 37)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "Actualizar"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.nombre, Me.apellido, Me.direccion, Me.telefono})
        Me.dgvPerson.Location = New System.Drawing.Point(12, 12)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.Size = New System.Drawing.Size(580, 254)
        Me.dgvPerson.TabIndex = 2
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "cedula"
        Me.cedula.HeaderText = "cedula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "apellido"
        Me.apellido.Name = "apellido"
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "direccion"
        Me.direccion.Name = "direccion"
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "tele"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(227, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(138, 37)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(454, 272)
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
        Me.ClientSize = New System.Drawing.Size(604, 313)
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
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnModify As Button
End Class
