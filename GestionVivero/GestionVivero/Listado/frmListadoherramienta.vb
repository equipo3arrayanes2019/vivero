Imports Dominio
Imports Entidades
Public Class frmListadoherramienta
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim com As New clsDHerramienta
        Dim listarHerramienta As List(Of clsHerramienta)
        dgvTools.ClearSelection()
        listarHerramienta = com.listarHerramienta()
        For Each unaM In listarHerramienta
            dgvTools.Rows.Add(unaM.uso, unaM.tipo_Herramienta, unaM.Zona_nombre.Zona_nombre, unaM.id_Producto)
        Next
    End Sub
End Class