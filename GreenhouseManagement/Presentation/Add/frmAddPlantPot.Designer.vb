<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPlantPot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPlantPot))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(102, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(214, 20)
        Me.txtName.TabIndex = 10
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(102, 45)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(214, 20)
        Me.txtMaterial.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Material:"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(102, 71)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(214, 20)
        Me.txtSize.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tamaño:"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(344, 100)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAddPlantPot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 135)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaterial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddPlantPot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Maceta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
End Class
