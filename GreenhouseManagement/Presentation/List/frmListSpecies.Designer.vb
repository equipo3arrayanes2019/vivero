<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListSpecies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListSpecies))
        Me.dgvSpeciesList = New System.Windows.Forms.DataGridView()
        Me.dgvcName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcFamily = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcZoneType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcGrowTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMoonType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcHumidity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmsInteract = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiModify = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvSpeciesList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInteract.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSpeciesList
        '
        Me.dgvSpeciesList.AllowUserToAddRows = False
        Me.dgvSpeciesList.AllowUserToDeleteRows = False
        Me.dgvSpeciesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSpeciesList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcName, Me.dgvcType, Me.dgvcFamily, Me.dgvcZoneType, Me.dgvcGrowTime, Me.dgvcMoonType, Me.dgvcHumidity})
        Me.dgvSpeciesList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSpeciesList.Location = New System.Drawing.Point(12, 12)
        Me.dgvSpeciesList.Name = "dgvSpeciesList"
        Me.dgvSpeciesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSpeciesList.Size = New System.Drawing.Size(776, 379)
        Me.dgvSpeciesList.TabIndex = 0
        '
        'dgvcName
        '
        Me.dgvcName.HeaderText = "Nombre"
        Me.dgvcName.Name = "dgvcName"
        '
        'dgvcType
        '
        Me.dgvcType.HeaderText = "Tipo"
        Me.dgvcType.Name = "dgvcType"
        '
        'dgvcFamily
        '
        Me.dgvcFamily.HeaderText = "Familia"
        Me.dgvcFamily.Name = "dgvcFamily"
        '
        'dgvcZoneType
        '
        Me.dgvcZoneType.HeaderText = "Tipo de zona"
        Me.dgvcZoneType.Name = "dgvcZoneType"
        '
        'dgvcGrowTime
        '
        Me.dgvcGrowTime.HeaderText = "Tiempo de cultivo"
        Me.dgvcGrowTime.Name = "dgvcGrowTime"
        '
        'dgvcMoonType
        '
        Me.dgvcMoonType.HeaderText = "Tipo de luna"
        Me.dgvcMoonType.Name = "dgvcMoonType"
        '
        'dgvcHumidity
        '
        Me.dgvcHumidity.HeaderText = "Humedad"
        Me.dgvcHumidity.Name = "dgvcHumidity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo:"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(65, 402)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(144, 20)
        Me.txtType.TabIndex = 2
        '
        'btnList
        '
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnList.Location = New System.Drawing.Point(713, 415)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 3
        Me.btnList.Text = "Listar"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(268, 402)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(144, 20)
        Me.txtName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'cmsInteract
        '
        Me.cmsInteract.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDelete, Me.tsmiModify})
        Me.cmsInteract.Name = "cmsInteract"
        Me.cmsInteract.Size = New System.Drawing.Size(126, 48)
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(125, 22)
        Me.tsmiDelete.Text = "Eliminar"
        '
        'tsmiModify
        '
        Me.tsmiModify.Name = "tsmiModify"
        Me.tsmiModify.Size = New System.Drawing.Size(125, 22)
        Me.tsmiModify.Text = "Modificar"
        '
        'frmListSpecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSpeciesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListSpecies"
        Me.Text = "Lista de especies"
        CType(Me.dgvSpeciesList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInteract.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSpeciesList As DataGridView
    Friend WithEvents dgvcName As DataGridViewTextBoxColumn
    Friend WithEvents dgvcType As DataGridViewTextBoxColumn
    Friend WithEvents dgvcFamily As DataGridViewTextBoxColumn
    Friend WithEvents dgvcZoneType As DataGridViewTextBoxColumn
    Friend WithEvents dgvcGrowTime As DataGridViewTextBoxColumn
    Friend WithEvents dgvcMoonType As DataGridViewTextBoxColumn
    Friend WithEvents dgvcHumidity As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents btnList As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmsInteract As ContextMenuStrip
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents tsmiModify As ToolStripMenuItem
End Class
