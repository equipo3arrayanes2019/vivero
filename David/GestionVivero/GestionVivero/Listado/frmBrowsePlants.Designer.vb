<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowsePlants
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbxSpecies = New System.Windows.Forms.ComboBox()
        Me.chkSpecies = New System.Windows.Forms.CheckBox()
        Me.chkScintificName = New System.Windows.Forms.CheckBox()
        Me.chkCommonName = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lchCommonName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lchScientificName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lchSpecies = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 430)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(860, 20)
        Me.txtSearch.TabIndex = 0
        '
        'cbxSpecies
        '
        Me.cbxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSpecies.Enabled = False
        Me.cbxSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxSpecies.FormattingEnabled = True
        Me.cbxSpecies.Location = New System.Drawing.Point(674, 278)
        Me.cbxSpecies.Name = "cbxSpecies"
        Me.cbxSpecies.Size = New System.Drawing.Size(198, 21)
        Me.cbxSpecies.Sorted = True
        Me.cbxSpecies.TabIndex = 1
        '
        'chkSpecies
        '
        Me.chkSpecies.AutoSize = True
        Me.chkSpecies.Location = New System.Drawing.Point(598, 280)
        Me.chkSpecies.Name = "chkSpecies"
        Me.chkSpecies.Size = New System.Drawing.Size(64, 17)
        Me.chkSpecies.TabIndex = 2
        Me.chkSpecies.Text = "Especie"
        Me.chkSpecies.UseVisualStyleBackColor = True
        '
        'chkScintificName
        '
        Me.chkScintificName.AutoSize = True
        Me.chkScintificName.Checked = True
        Me.chkScintificName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScintificName.Location = New System.Drawing.Point(598, 305)
        Me.chkScintificName.Name = "chkScintificName"
        Me.chkScintificName.Size = New System.Drawing.Size(155, 17)
        Me.chkScintificName.TabIndex = 3
        Me.chkScintificName.Text = "Coincidir: Nombre Cientifico"
        Me.chkScintificName.UseVisualStyleBackColor = True
        '
        'chkCommonName
        '
        Me.chkCommonName.AutoSize = True
        Me.chkCommonName.Checked = True
        Me.chkCommonName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCommonName.Location = New System.Drawing.Point(598, 328)
        Me.chkCommonName.Name = "chkCommonName"
        Me.chkCommonName.Size = New System.Drawing.Size(145, 17)
        Me.chkCommonName.TabIndex = 4
        Me.chkCommonName.Text = "Coincidir: Nombre Común"
        Me.chkCommonName.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lchCommonName, Me.lchScientificName, Me.lchSpecies})
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(580, 412)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(598, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 236)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lchCommonName
        '
        Me.lchCommonName.Text = "Nombre Común"
        Me.lchCommonName.Width = 156
        '
        'lchScientificName
        '
        Me.lchScientificName.Text = "Nombre Cientifico"
        Me.lchScientificName.Width = 186
        '
        'lchSpecies
        '
        Me.lchSpecies.Text = "Especie"
        Me.lchSpecies.Width = 233
        '
        'frmBrowsePlants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.chkCommonName)
        Me.Controls.Add(Me.chkScintificName)
        Me.Controls.Add(Me.chkSpecies)
        Me.Controls.Add(Me.cbxSpecies)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBrowsePlants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Plantas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbxSpecies As ComboBox
    Friend WithEvents chkSpecies As CheckBox
    Friend WithEvents chkScintificName As CheckBox
    Friend WithEvents chkCommonName As CheckBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lchCommonName As ColumnHeader
    Friend WithEvents lchScientificName As ColumnHeader
    Friend WithEvents lchSpecies As ColumnHeader
End Class
