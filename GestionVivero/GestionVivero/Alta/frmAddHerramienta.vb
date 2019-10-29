Imports Entidades
Imports Dominio
Public Class frmAddHerramienta
    Dim com As clsDHerramienta
    Dim unDZ As New clsDZona
    Dim com1 As clsDPlant
    Dim unHE As clsHerramienta
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        unHE.uso = txtUso.Text
        unHE.tipo_Herramienta = cbxTipo.Text
        unHE.Zona_nombre.Zona_nombre = cbxZona.Text
        unHE.Nombre_Producto = txtNombre.text
        com.altaHerramienta(unHE)
    End Sub

    Private Sub frmAddHerramienta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim colZonas = unDZ.listarZona
        cbxZona.ValueMember = "Zona_nombre"
        cbxZona.DisplayMember = "Zona_nombre"
        cbxZona.DataSource = colZonas
    End Sub
End Class