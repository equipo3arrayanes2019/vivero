<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListSensor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListSensor))
        Me.dgvSensorList = New System.Windows.Forms.DataGridView()
        Me.dgvcId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcZone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsInteract = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiModify = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSelectZone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblZone = New System.Windows.Forms.Label()
        CType(Me.dgvSensorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInteract.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSensorList
        '
        Me.dgvSensorList.AllowUserToAddRows = False
        Me.dgvSensorList.AllowUserToDeleteRows = False
        Me.dgvSensorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSensorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcId, Me.dgvcType, Me.dgvcZone})
        Me.dgvSensorList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSensorList.Location = New System.Drawing.Point(12, 12)
        Me.dgvSensorList.Name = "dgvSensorList"
        Me.dgvSensorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSensorList.Size = New System.Drawing.Size(776, 329)
        Me.dgvSensorList.TabIndex = 0
        '
        'dgvcId
        '
        Me.dgvcId.HeaderText = "ID de Hardware"
        Me.dgvcId.Name = "dgvcId"
        '
        'dgvcType
        '
        Me.dgvcType.HeaderText = "Tipo"
        Me.dgvcType.Name = "dgvcType"
        '
        'dgvcZone
        '
        Me.dgvcZone.HeaderText = "Zona"
        Me.dgvcZone.Name = "dgvcZone"
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
        'btnSelectZone
        '
        Me.btnSelectZone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelectZone.Location = New System.Drawing.Point(660, 347)
        Me.btnSelectZone.Name = "btnSelectZone"
        Me.btnSelectZone.Size = New System.Drawing.Size(128, 23)
        Me.btnSelectZone.TabIndex = 1
        Me.btnSelectZone.Text = "Seleccionar Zona..."
        Me.btnSelectZone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Zona:"
        '
        'lblZone
        '
        Me.lblZone.AutoSize = True
        Me.lblZone.Location = New System.Drawing.Point(496, 352)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(99, 13)
        Me.lblZone.TabIndex = 3
        Me.lblZone.Text = "Nada seleccionado"
        '
        'frmListSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 378)
        Me.Controls.Add(Me.lblZone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectZone)
        Me.Controls.Add(Me.dgvSensorList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListSensor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de sensores"
        CType(Me.dgvSensorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInteract.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSensorList As DataGridView
    Friend WithEvents dgvcId As DataGridViewTextBoxColumn
    Friend WithEvents dgvcType As DataGridViewTextBoxColumn
    Friend WithEvents dgvcZone As DataGridViewTextBoxColumn
    Friend WithEvents cmsInteract As ContextMenuStrip
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents btnSelectZone As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblZone As Label
    Friend WithEvents tsmiModify As ToolStripMenuItem
End Class
