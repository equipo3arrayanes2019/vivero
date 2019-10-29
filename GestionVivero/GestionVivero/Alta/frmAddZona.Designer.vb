<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddZona
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
        Me.mktTime = New System.Windows.Forms.MaskedTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDrop = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.txtEspecie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'mktTime
        '
        Me.mktTime.Location = New System.Drawing.Point(175, 38)
        Me.mktTime.Mask = "0000 m"
        Me.mktTime.Name = "mktTime"
        Me.mktTime.Size = New System.Drawing.Size(252, 20)
        Me.mktTime.TabIndex = 37
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(343, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Guardar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDrop
        '
        Me.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDrop.Location = New System.Drawing.Point(179, 108)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(75, 23)
        Me.btnDrop.TabIndex = 33
        Me.btnDrop.Text = "Quitar"
        Me.btnDrop.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModify.Location = New System.Drawing.Point(262, 108)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 32
        Me.btnModify.Text = "Modificar"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'txtEspecie
        '
        Me.txtEspecie.Location = New System.Drawing.Point(175, 64)
        Me.txtEspecie.Name = "txtEspecie"
        Me.txtEspecie.Size = New System.Drawing.Size(252, 20)
        Me.txtEspecie.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tamaño:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(175, 11)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(252, 20)
        Me.txtID.TabIndex = 25
        '
        'frmAddZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 146)
        Me.Controls.Add(Me.mktTime)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDrop)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.txtEspecie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Name = "frmAddZona"
        Me.Text = "frmAddZona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mktTime As MaskedTextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDrop As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents txtEspecie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
End Class
