<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSpecies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSpecies))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbxZoneType = New System.Windows.Forms.ComboBox()
        Me.txtFamily = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.nudGrowTime = New System.Windows.Forms.NumericUpDown()
        Me.cbxMoonType = New System.Windows.Forms.ComboBox()
        Me.nudHumidity = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.nudGrowTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Familia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de zona:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tiempo de cultivo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo de luna:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Humedad:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(117, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(263, 20)
        Me.txtName.TabIndex = 7
        '
        'cbxZoneType
        '
        Me.cbxZoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxZoneType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxZoneType.FormattingEnabled = True
        Me.cbxZoneType.Items.AddRange(New Object() {"Invernáculo", "Sombráculo", "Aire Libre"})
        Me.cbxZoneType.Location = New System.Drawing.Point(117, 98)
        Me.cbxZoneType.Name = "cbxZoneType"
        Me.cbxZoneType.Size = New System.Drawing.Size(174, 21)
        Me.cbxZoneType.TabIndex = 10
        '
        'txtFamily
        '
        Me.txtFamily.Location = New System.Drawing.Point(117, 72)
        Me.txtFamily.Name = "txtFamily"
        Me.txtFamily.Size = New System.Drawing.Size(263, 20)
        Me.txtFamily.TabIndex = 11
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(117, 46)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(263, 20)
        Me.txtType.TabIndex = 12
        '
        'nudGrowTime
        '
        Me.nudGrowTime.Location = New System.Drawing.Point(117, 135)
        Me.nudGrowTime.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudGrowTime.Name = "nudGrowTime"
        Me.nudGrowTime.Size = New System.Drawing.Size(120, 20)
        Me.nudGrowTime.TabIndex = 13
        '
        'cbxMoonType
        '
        Me.cbxMoonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMoonType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxMoonType.FormattingEnabled = True
        Me.cbxMoonType.Items.AddRange(New Object() {"Creciente", "Cuarto creciente", "Cuarto menguante", "Luna menguante", "Gibosa creciente", "Gibosa menguante"})
        Me.cbxMoonType.Location = New System.Drawing.Point(117, 161)
        Me.cbxMoonType.Name = "cbxMoonType"
        Me.cbxMoonType.Size = New System.Drawing.Size(174, 21)
        Me.cbxMoonType.TabIndex = 14
        '
        'nudHumidity
        '
        Me.nudHumidity.DecimalPlaces = 2
        Me.nudHumidity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudHumidity.Location = New System.Drawing.Point(117, 188)
        Me.nudHumidity.Name = "nudHumidity"
        Me.nudHumidity.Size = New System.Drawing.Size(120, 20)
        Me.nudHumidity.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(323, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAddSpecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 259)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.nudHumidity)
        Me.Controls.Add(Me.cbxMoonType)
        Me.Controls.Add(Me.nudGrowTime)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtFamily)
        Me.Controls.Add(Me.cbxZoneType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddSpecies"
        Me.Text = "Agregar Especie"
        CType(Me.nudGrowTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHumidity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbxZoneType As ComboBox
    Friend WithEvents txtFamily As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents nudGrowTime As NumericUpDown
    Friend WithEvents cbxMoonType As ComboBox
    Friend WithEvents nudHumidity As NumericUpDown
    Friend WithEvents btnSave As Button
End Class
