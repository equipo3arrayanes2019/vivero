<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListPlants
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
        Me.dgvPlantList = New System.Windows.Forms.DataGridView()
        Me.dgvcSpecies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcZone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSpecies = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.cmsInteract = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiModify = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvPlantList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInteract.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPlantList
        '
        Me.dgvPlantList.AllowUserToAddRows = False
        Me.dgvPlantList.AllowUserToDeleteRows = False
        Me.dgvPlantList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlantList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcSpecies, Me.dgvcId, Me.dgvcZone, Me.dgvcDate})
        Me.dgvPlantList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPlantList.Location = New System.Drawing.Point(12, 12)
        Me.dgvPlantList.Name = "dgvPlantList"
        Me.dgvPlantList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlantList.Size = New System.Drawing.Size(860, 402)
        Me.dgvPlantList.TabIndex = 7
        '
        'dgvcSpecies
        '
        Me.dgvcSpecies.HeaderText = "Especie"
        Me.dgvcSpecies.Name = "dgvcSpecies"
        '
        'dgvcId
        '
        Me.dgvcId.HeaderText = "ID"
        Me.dgvcId.Name = "dgvcId"
        '
        'dgvcZone
        '
        Me.dgvcZone.HeaderText = "Zona"
        Me.dgvcZone.Name = "dgvcZone"
        '
        'dgvcDate
        '
        Me.dgvcDate.HeaderText = "Fecha"
        Me.dgvcDate.Name = "dgvcDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre especie:"
        '
        'txtSpecies
        '
        Me.txtSpecies.Location = New System.Drawing.Point(102, 430)
        Me.txtSpecies.Name = "txtSpecies"
        Me.txtSpecies.Size = New System.Drawing.Size(206, 20)
        Me.txtSpecies.TabIndex = 9
        '
        'btnBrowse
        '
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Location = New System.Drawing.Point(797, 428)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "Buscar"
        Me.btnBrowse.UseVisualStyleBackColor = True
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
        Me.tsmiModify.Size = New System.Drawing.Size(125, 22)
        Me.tsmiModify.Text = "Modificar"
        '
        'frmListPlants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtSpecies)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPlantList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmListPlants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Plantas"
        CType(Me.dgvPlantList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInteract.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPlantList As DataGridView
    Friend WithEvents dgvcSpecies As DataGridViewTextBoxColumn
    Friend WithEvents dgvcId As DataGridViewTextBoxColumn
    Friend WithEvents dgvcZone As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDate As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSpecies As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents cmsInteract As ContextMenuStrip
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents tsmiModify As ToolStripMenuItem
End Class
