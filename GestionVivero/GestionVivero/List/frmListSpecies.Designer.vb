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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ichName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichFamily = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichZone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichMoon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichHumifity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerPlantadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerALaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(374, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(57, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(612, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Familia:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(660, 11)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ichName, Me.ichFamily, Me.ichType, Me.ichZone, Me.ichTime, Me.ichMoon, Me.ichHumifity})
        Me.ListView1.Location = New System.Drawing.Point(12, 39)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(860, 407)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ichName
        '
        Me.ichName.Text = "Nombre"
        Me.ichName.Width = 202
        '
        'ichFamily
        '
        Me.ichFamily.Text = "Familia"
        Me.ichFamily.Width = 154
        '
        'ichType
        '
        Me.ichType.Text = "Tipo"
        Me.ichType.Width = 128
        '
        'ichZone
        '
        Me.ichZone.Text = "Zona"
        Me.ichZone.Width = 76
        '
        'ichTime
        '
        Me.ichTime.Text = "Tiempo de cultivo"
        Me.ichTime.Width = 112
        '
        'ichMoon
        '
        Me.ichMoon.Text = "Luna"
        Me.ichMoon.Width = 103
        '
        'ichHumifity
        '
        Me.ichHumifity.Text = "Humedad"
        Me.ichHumifity.Width = 75
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPlantadasToolStripMenuItem, Me.VerALaVentaToolStripMenuItem, Me.VerLotesToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(146, 114)
        '
        'VerPlantadasToolStripMenuItem
        '
        Me.VerPlantadasToolStripMenuItem.Name = "VerPlantadasToolStripMenuItem"
        Me.VerPlantadasToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VerPlantadasToolStripMenuItem.Text = "Ver plantadas"
        '
        'VerALaVentaToolStripMenuItem
        '
        Me.VerALaVentaToolStripMenuItem.Name = "VerALaVentaToolStripMenuItem"
        Me.VerALaVentaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VerALaVentaToolStripMenuItem.Text = "Ver a la venta"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'VerLotesToolStripMenuItem
        '
        Me.VerLotesToolStripMenuItem.Name = "VerLotesToolStripMenuItem"
        Me.VerLotesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VerLotesToolStripMenuItem.Text = "Ver Lotes"
        '
        'frmListSpecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 458)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListSpecies"
        Me.Text = "Ver especies"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ichName As ColumnHeader
    Friend WithEvents ichFamily As ColumnHeader
    Friend WithEvents ichType As ColumnHeader
    Friend WithEvents ichZone As ColumnHeader
    Friend WithEvents ichTime As ColumnHeader
    Friend WithEvents ichMoon As ColumnHeader
    Friend WithEvents ichHumifity As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents VerPlantadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerALaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
