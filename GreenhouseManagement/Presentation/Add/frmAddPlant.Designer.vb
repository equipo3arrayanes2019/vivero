<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPlant
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.btnPickSpecies = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlantpot = New System.Windows.Forms.Label()
        Me.btnPickPlantPot = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Especie:"
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Location = New System.Drawing.Point(119, 46)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(113, 13)
        Me.lblSpecies.TabIndex = 4
        Me.lblSpecies.Text = "Ninguna seleccionada"
        '
        'btnPickSpecies
        '
        Me.btnPickSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPickSpecies.Location = New System.Drawing.Point(296, 41)
        Me.btnPickSpecies.Name = "btnPickSpecies"
        Me.btnPickSpecies.Size = New System.Drawing.Size(123, 23)
        Me.btnPickSpecies.TabIndex = 20
        Me.btnPickSpecies.Text = "Seleccionar especie..."
        Me.btnPickSpecies.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(12, 19)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Precio:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(122, 16)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(297, 20)
        Me.txtPrice.TabIndex = 10
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(122, 70)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha:"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(337, 170)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 23)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Maceta:"
        '
        'lblPlantpot
        '
        Me.lblPlantpot.AutoSize = True
        Me.lblPlantpot.Location = New System.Drawing.Point(119, 114)
        Me.lblPlantpot.Name = "lblPlantpot"
        Me.lblPlantpot.Size = New System.Drawing.Size(113, 13)
        Me.lblPlantpot.TabIndex = 33
        Me.lblPlantpot.Text = "Ninguna seleccionada"
        '
        'btnPickPlantPot
        '
        Me.btnPickPlantPot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPickPlantPot.Location = New System.Drawing.Point(250, 109)
        Me.btnPickPlantPot.Name = "btnPickPlantPot"
        Me.btnPickPlantPot.Size = New System.Drawing.Size(169, 23)
        Me.btnPickPlantPot.TabIndex = 40
        Me.btnPickPlantPot.Text = "Seleccionar tipo de maceta..."
        Me.btnPickPlantPot.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Cantidad:"
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(122, 145)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 20)
        Me.nudQuantity.TabIndex = 50
        '
        'frmAddPlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(444, 211)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPickPlantPot)
        Me.Controls.Add(Me.lblPlantpot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnPickSpecies)
        Me.Controls.Add(Me.lblSpecies)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPrice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddPlant"
        Me.Text = "Plantar"
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSpecies As Label
    Friend WithEvents btnPickSpecies As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlantpot As Label
    Friend WithEvents btnPickPlantPot As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents nudQuantity As NumericUpDown
End Class
