<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaDOUPLantPot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaDOUPLantPot))
        Me.dgvPlantPotList = New System.Windows.Forms.DataGridView()
        Me.dgvcName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnList = New System.Windows.Forms.Button()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.cmsInteract = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiModify = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvPlantPotList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInteract.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPlantPotList
        '
        Me.dgvPlantPotList.AllowUserToAddRows = False
        Me.dgvPlantPotList.AllowUserToDeleteRows = False
        Me.dgvPlantPotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlantPotList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcName, Me.dgvcMaterial, Me.dgvcSize})
        Me.dgvPlantPotList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPlantPotList.Location = New System.Drawing.Point(12, 12)
        Me.dgvPlantPotList.Name = "dgvPlantPotList"
        Me.dgvPlantPotList.Size = New System.Drawing.Size(776, 385)
        Me.dgvPlantPotList.TabIndex = 0
        '
        'dgvcName
        '
        Me.dgvcName.HeaderText = "Nombre"
        Me.dgvcName.Name = "dgvcName"
        '
        'dgvcMaterial
        '
        Me.dgvcMaterial.HeaderText = "Material"
        Me.dgvcMaterial.Name = "dgvcMaterial"
        '
        'dgvcSize
        '
        Me.dgvcSize.HeaderText = "Tamaño"
        Me.dgvcSize.Name = "dgvcSize"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 420)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Material:"
        '
        'btnList
        '
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnList.Location = New System.Drawing.Point(713, 415)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 2
        Me.btnList.Text = "Listar"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(65, 417)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(236, 20)
        Me.txtMaterial.TabIndex = 3
        '
        'cmsInteract
        '
        Me.cmsInteract.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDelete, Me.tsmiModify})
        Me.cmsInteract.Name = "cmsInteract"
        Me.cmsInteract.Size = New System.Drawing.Size(181, 70)
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(180, 22)
        Me.tsmiDelete.Text = "Eliminar"
        '
        'tsmiModify
        '
        Me.tsmiModify.Name = "tsmiModify"
        Me.tsmiModify.Size = New System.Drawing.Size(180, 22)
        Me.tsmiModify.Text = "Modificar"
        '
        'frmListaDOUPLantPot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMaterial)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPlantPotList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaDOUPLantPot"
        Me.Text = "Lista de Macetas"
        CType(Me.dgvPlantPotList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInteract.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPlantPotList As DataGridView
    Friend WithEvents dgvcName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcMaterial As DataGridViewTextBoxColumn
    Friend WithEvents dgvcSize As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnList As Button
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents cmsInteract As ContextMenuStrip
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents tsmiModify As ToolStripMenuItem
End Class
