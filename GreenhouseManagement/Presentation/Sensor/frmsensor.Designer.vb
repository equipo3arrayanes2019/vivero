<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsensor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvSensors = New System.Windows.Forms.DataGridView()
        Me.TimeTemp = New System.Windows.Forms.Timer(Me.components)
        Me.TimeGraph = New System.Windows.Forms.Timer(Me.components)
        Me.TimerHelp = New System.Windows.Forms.Timer(Me.components)
        Me.btnEstado = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zona_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sensor_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSensors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSensors
        '
        Me.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSensors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.valor, Me.Zona_Nombre, Me.Sensor_id})
        Me.dgvSensors.Location = New System.Drawing.Point(2, 12)
        Me.dgvSensors.Name = "dgvSensors"
        Me.dgvSensors.Size = New System.Drawing.Size(657, 163)
        Me.dgvSensors.TabIndex = 0
        '
        'TimeTemp
        '
        Me.TimeTemp.Interval = 1000
        '
        'TimeGraph
        '
        Me.TimeGraph.Interval = 1000
        '
        'btnEstado
        '
        Me.btnEstado.Location = New System.Drawing.Point(390, 225)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.Size = New System.Drawing.Size(85, 39)
        Me.btnEstado.TabIndex = 8
        Me.btnEstado.Text = "Estado"
        Me.btnEstado.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 39)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Temperatura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(572, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 39)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Grafica"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'valor
        '
        Me.valor.DataPropertyName = "fecha"
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        '
        'Zona_Nombre
        '
        Me.Zona_Nombre.DataPropertyName = "Zona_nombre"
        Me.Zona_Nombre.HeaderText = "Zona Nombre"
        Me.Zona_Nombre.Name = "Zona_Nombre"
        '
        'Sensor_id
        '
        Me.Sensor_id.DataPropertyName = "Sensor_id"
        Me.Sensor_id.HeaderText = "Sensor ID"
        Me.Sensor_id.Name = "Sensor_id"
        '
        'frmsensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(671, 276)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEstado)
        Me.Controls.Add(Me.dgvSensors)
        Me.Name = "frmsensor"
        Me.Text = "frmsensor"
        CType(Me.dgvSensors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSensors As DataGridView
    Friend WithEvents TimeTemp As Timer
    Friend WithEvents TimeGraph As Timer
    Friend WithEvents TimerHelp As Timer
    Friend WithEvents btnEstado As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents Zona_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Sensor_id As DataGridViewTextBoxColumn
End Class
