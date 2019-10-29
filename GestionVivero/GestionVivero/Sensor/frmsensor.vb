Imports Dominio
Imports Entidades
Public Class frmsensor


    Private Sub btnEstado_Click(sender As Object, e As EventArgs) Handles btnEstado.Click
        Dim com As New clsDMedicion
        Dim listarMedicion As List(Of clsMedicion)
        'listarMedicion = com.listarMedicion()
        'dgvSensors.DataSource = listarMedicion
        dgvSensors.ClearSelection()
        listarMedicion = com.listarMedicion()
        For Each unaM In listarMedicion
            dgvSensors.Rows.Add(unaM.id, unaM.fecha, unaM.valor, unaM.Zona_nombre.Zona_nombre, unaM.Sensor_id.Sensor_id)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmtemp.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmGraphic.Show()
    End Sub
End Class