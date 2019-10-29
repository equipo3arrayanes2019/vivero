Imports Dominio
Imports Entidades
Public Class frmBrowsePlants
    Private Sub ChkSpecies_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecies.CheckedChanged
        cbxSpecies.Enabled = chkSpecies.Checked
    End Sub
    Dim com As New clsDPlant

    Private Sub frmBrowsePlants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaPlanta As List(Of clsPlanta)
        listaPlanta = com.listar()
        dgvPlanta.DataSource = listaPlanta
    End Sub
End Class