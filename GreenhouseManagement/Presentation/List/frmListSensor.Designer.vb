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
        CType(Me.dgvSensorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInteract.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSensorList
        '
        Me.dgvSensorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSensorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcId, Me.dgvcType, Me.dgvcZone})
        Me.dgvSensorList.Location = New System.Drawing.Point(12, 12)
        Me.dgvSensorList.Name = "dgvSensorList"
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
        Me.cmsInteract.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDelete})
        Me.cmsInteract.Name = "cmsInteract"
        Me.cmsInteract.Size = New System.Drawing.Size(118, 26)
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(117, 22)
        Me.tsmiDelete.Text = "Eliminar"
        '
        'frmListSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 377)
        Me.Controls.Add(Me.dgvSensorList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListSensor"
        Me.Text = "Lista de sensores"
        CType(Me.dgvSensorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInteract.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSensorList As DataGridView
    Friend WithEvents dgvcId As DataGridViewTextBoxColumn
    Friend WithEvents dgvcType As DataGridViewTextBoxColumn
    Friend WithEvents dgvcZone As DataGridViewTextBoxColumn
    Friend WithEvents cmsInteract As ContextMenuStrip
    Friend WithEvents tsmiDelete As ToolStripMenuItem
End Class
