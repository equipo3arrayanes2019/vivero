<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlant
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
        Me.dtpDatePlanted = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCommonName = New System.Windows.Forms.Label()
        Me.lblScientificName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPickPlant = New System.Windows.Forms.Button()
        Me.cbxLocation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDatePlanted
        '
        Me.dtpDatePlanted.Location = New System.Drawing.Point(122, 13)
        Me.dtpDatePlanted.Name = "dtpDatePlanted"
        Me.dtpDatePlanted.Size = New System.Drawing.Size(200, 20)
        Me.dtpDatePlanted.TabIndex = 0
        Me.dtpDatePlanted.Value = New Date(2019, 5, 27, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(328, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 392)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Planta:"
        '
        'lblCommonName
        '
        Me.lblCommonName.AutoSize = True
        Me.lblCommonName.Location = New System.Drawing.Point(119, 46)
        Me.lblCommonName.Name = "lblCommonName"
        Me.lblCommonName.Size = New System.Drawing.Size(47, 13)
        Me.lblCommonName.TabIndex = 4
        Me.lblCommonName.Text = "Ninguna"
        '
        'lblScientificName
        '
        Me.lblScientificName.AutoSize = True
        Me.lblScientificName.Location = New System.Drawing.Point(119, 59)
        Me.lblScientificName.Name = "lblScientificName"
        Me.lblScientificName.Size = New System.Drawing.Size(47, 13)
        Me.lblScientificName.TabIndex = 6
        Me.lblScientificName.Text = "Ninguna"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre científico:"
        '
        'btnPickPlant
        '
        Me.btnPickPlant.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPickPlant.Location = New System.Drawing.Point(12, 75)
        Me.btnPickPlant.Name = "btnPickPlant"
        Me.btnPickPlant.Size = New System.Drawing.Size(75, 23)
        Me.btnPickPlant.TabIndex = 7
        Me.btnPickPlant.Text = "Elejir Planta"
        Me.btnPickPlant.UseVisualStyleBackColor = True
        '
        'cbxLocation
        '
        Me.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxLocation.FormattingEnabled = True
        Me.cbxLocation.Location = New System.Drawing.Point(122, 106)
        Me.cbxLocation.Name = "cbxLocation"
        Me.cbxLocation.Size = New System.Drawing.Size(200, 21)
        Me.cbxLocation.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Locación:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(122, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Zona:"
        '
        'frmPlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 416)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxLocation)
        Me.Controls.Add(Me.btnPickPlant)
        Me.Controls.Add(Me.lblScientificName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCommonName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDatePlanted)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPlant"
        Me.Text = "Plantar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDatePlanted As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCommonName As Label
    Friend WithEvents lblScientificName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPickPlant As Button
    Friend WithEvents cbxLocation As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
