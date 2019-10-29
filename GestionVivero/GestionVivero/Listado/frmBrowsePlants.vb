Imports Dominio
Imports Entidades
Public Class frmBrowsePlants
    Dim com As New clsControlador
    Private Sub ChkSpecies_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecies.CheckedChanged
        cbxSpecies.Enabled = chkSpecies.Checked
    End Sub

    Private Sub frmBrowsePlants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaPlanta As List(Of clsPlanta)
        listaPlanta = com.listar()
        dgvPlanta.DataSource = listaPlanta
    End Sub

    Private Sub dgvPlanta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanta.CellDoubleClick
        Dim indice = e.RowIndex
        Dim filaSeleccionada As DataGridViewRow
        If (indice = 1) Then Return
        filaSeleccionada = dgvPlanta.Rows(indice)
        frmAddPlants.txtCantidad.Text = filaSeleccionada.Cells(3).Value.ToString
        frmAddPlants.mktTime.Text = filaSeleccionada.Cells(1).Value.ToString

        Me.Hide()
        frmAddPlants.Show()
    End Sub

End Class