<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListDistOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListDistOrder))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ichProducts = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichDistributor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ichDeliveryDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfirmarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(74, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(367, 12)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Fecha"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(280, 17)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Entrega"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(573, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Seleccionar producto..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(708, 16)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "Entregado"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(262, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(12, 44)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "Proveedor"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ichProducts, Me.ichDistributor, Me.ichDate, Me.ichDeliveryDate})
        Me.ListView1.Location = New System.Drawing.Point(12, 67)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(860, 383)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ichProducts
        '
        Me.ichProducts.Text = "Productos"
        Me.ichProducts.Width = 477
        '
        'ichDistributor
        '
        Me.ichDistributor.Text = "Proveedor"
        Me.ichDistributor.Width = 147
        '
        'ichDate
        '
        Me.ichDate.Text = "Fecha"
        Me.ichDate.Width = 105
        '
        'ichDeliveryDate
        '
        Me.ichDeliveryDate.Text = "Fecha de entrega"
        Me.ichDeliveryDate.Width = 121
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelarToolStripMenuItem, Me.ConfirmarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 70)
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'ConfirmarToolStripMenuItem
        '
        Me.ConfirmarToolStripMenuItem.Name = "ConfirmarToolStripMenuItem"
        Me.ConfirmarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ConfirmarToolStripMenuItem.Text = "Confirmar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'frmListDistOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListDistOrder"
        Me.Text = "Ver ordenes."
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ichProducts As ColumnHeader
    Friend WithEvents ichDistributor As ColumnHeader
    Friend WithEvents ichDate As ColumnHeader
    Friend WithEvents ichDeliveryDate As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfirmarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
End Class
