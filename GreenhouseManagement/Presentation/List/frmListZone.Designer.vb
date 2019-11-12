<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListZone
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListZone))
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tamaño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvZones = New System.Windows.Forms.DataGridView()
        Me.btnByType = New System.Windows.Forms.Button()
        Me.cmsInteract = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiDeleteZones = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvZones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInteract.SuspendLayout()
        Me.SuspendLayout()
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        '
        'tamaño
        '
        Me.tamaño.DataPropertyName = "tamaño"
        Me.tamaño.HeaderText = "Tamaño"
        Me.tamaño.Name = "tamaño"
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'dgvZones
        '
        Me.dgvZones.AllowUserToAddRows = False
        Me.dgvZones.AllowUserToDeleteRows = False
        Me.dgvZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.tamaño, Me.tipo})
        Me.dgvZones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvZones.Location = New System.Drawing.Point(12, 12)
        Me.dgvZones.Name = "dgvZones"
        Me.dgvZones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZones.Size = New System.Drawing.Size(656, 314)
        Me.dgvZones.TabIndex = 1
        '
        'btnByType
        '
        Me.btnByType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnByType.Location = New System.Drawing.Point(506, 332)
        Me.btnByType.Name = "btnByType"
        Me.btnByType.Size = New System.Drawing.Size(75, 23)
        Me.btnByType.TabIndex = 2
        Me.btnByType.Text = "Por Tipo"
        Me.btnByType.UseVisualStyleBackColor = True
        '
        'cmsInteract
        '
        Me.cmsInteract.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDeleteZones})
        Me.cmsInteract.Name = "cmsInteract"
        Me.cmsInteract.Size = New System.Drawing.Size(227, 26)
        '
        'tsmiDeleteZones
        '
        Me.tsmiDeleteZones.Name = "tsmiDeleteZones"
        Me.tsmiDeleteZones.Size = New System.Drawing.Size(226, 22)
        Me.tsmiDeleteZones.Text = "Eliminar zonas seleccionadas"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(593, 332)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmListZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 367)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnByType)
        Me.Controls.Add(Me.dgvZones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListZone"
        Me.Text = "Ver Zonas"
        CType(Me.dgvZones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInteract.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents tamaño As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvZones As DataGridView
    Friend WithEvents btnByType As Button
    Friend WithEvents cmsInteract As ContextMenuStrip
    Friend WithEvents tsmiDeleteZones As ToolStripMenuItem
    Friend WithEvents btnClose As Button
End Class
