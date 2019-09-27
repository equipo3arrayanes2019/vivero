Imports Entidades
Imports Dominio
Public Class listPerson
    Dim com As New clsDPerson

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub

    Private Sub listPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaPersona As List(Of clsPersona)
        listaPersona = com.listar()
        dgvPerson.DataSource = listaPersona
    End Sub

    Private Sub dgvPerson_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerson.CellContentClick
    End Sub


End Class