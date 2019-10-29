Imports Entidades
Imports Dominio
Public Class listPerson
    Dim com As New clsDPerson
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim listaPersona As List(Of clsPersona)
        listaPersona = com.listar()
        dgvPerson.DataSource = listaPersona
        dgvPerson.ClearSelection()
    End Sub
    Private Sub dgvPerson_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerson.CellClick
        Dim indice = e.RowIndex
        Dim filaSeleccionada As DataGridViewRow
        If (indice = 1) Then Return
        filaSeleccionada = dgvPerson.Rows(indice)
        frmAddPerson.mskCedula.Text = filaSeleccionada.Cells(1).Value.ToString()
        frmAddPerson.txtName.Text = filaSeleccionada.Cells(0).Value.ToString()
        frmAddPerson.txtAddress.Text = filaSeleccionada.Cells(3).Value.ToString()
        frmAddPerson.txtPhone.Text = filaSeleccionada.Cells(2).Value.ToString()
        frmAddPerson.cxType.Text = filaSeleccionada.Cells(4).Value.ToString()
        frmAddPerson.txtUser.Text = filaSeleccionada.Cells(5).Value.ToString()
        frmAddPerson.mTime.Text = filaSeleccionada.Cells(7).Value.ToString()
        'frmAddPerson.txtUser.Text = filaSeleccionada.Cells(9).Value.ToString()
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        Me.Hide()
        frmAddPerson.Show()
        frmAddPerson.mskCedula.ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Hide()
        frmAddPerson.Show()
    End Sub
End Class