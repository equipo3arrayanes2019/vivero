Imports Dominio
Imports Entidades
Public Class frmListadoZona
    Dim com As New clsDZona
    Private Sub btnUpdateZona_Click(sender As Object, e As EventArgs) Handles btnUpdateZona.Click
        Dim listarZona As List(Of clsZona)
        listarZona = com.listarZona()
        dgvZona.DataSource = listarZona
        dgvZona.ClearSelection()
    End Sub
End Class