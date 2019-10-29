Imports Entidades
Imports Dominio
Public Class frmaddAditivo
    Dim com As New clsDAditivo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim unEE As New clsAditivo
        unEE.id = CInt(Int(txtID.Text))
        unEE.tipo = txtProducto.Text
        unEE.descripcion = txtObsv.Text
        unEE.producto = CInt(Int(txtProducto.Text))
        com.altaAditivo(unEE)
    End Sub
End Class