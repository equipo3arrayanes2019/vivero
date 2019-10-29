Imports Entidades
Imports Dominio
Public Class frmAddPlants
    Dim com As New clsControlador
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim unEE As New clsPlanta
        unEE.id = txtID.Text
        unEE.fecha = mktTime.Text
        unEE.cantidad = CInt(Int(txtCantidad.Text))
        unEE.especie = txtEspecie.Text
        com.altaPlanta(unEE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim unEE As New clsPlanta
        unEE.id = txtID.Text
        com.altaPlanta(unEE)
    End Sub
End Class