Imports Dominio
Imports Entidades
Public Class frmListadorSensor

    Private Sub btnUpdateSensor_Click(sender As Object, e As EventArgs) Handles btnUpdateSensor.Click
        Dim com As New clsDSensor
        Dim listarSensor As List(Of clsSensor)
        listarSensor = com.listarSensor()
        dgvSensor.DataSource = listarSensor
        dgvSensor.ClearSelection()
    End Sub
End Class