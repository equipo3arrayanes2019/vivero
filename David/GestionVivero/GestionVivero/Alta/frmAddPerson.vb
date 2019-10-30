Imports Dominio
Imports Entidades
Public Class frmAddPerson
    Dim com As New clsDPerson
    Private Sub frmAddPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaPersona As List(Of clsPersona)
        listaPersona = com.listar()
        dgvPerson.DataSource = listaPersona
    End Sub
    Dim unDE As New clsDPerson
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unEE As New clsPersona
        unEE.cedula = mskCedula.Text
        unEE.nombre = txtName.Text
        unEE.apellido = txtLastName.Text
        unEE.direccion = txtAddress.Text
        unEE.tele = txtPhone.Text
        unDE.altaPersona(unEE)
    End Sub

End Class