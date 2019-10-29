Imports Entidades
Imports Dominio
Public Class frmAddZona
    Dim unDZ As New clsDZona
    Dim unEZ As New clsZona
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        unEZ.Zona_nombre = txtID.Text
        unEZ.tamaño = mktTime.Text
        unEZ.tipo = txtEspecie.Text
        unDZ.altaZona(unEZ)
    End Sub
End Class