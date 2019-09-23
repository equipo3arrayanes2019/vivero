Imports Dominio
Imports Entidades
Public Class frmAddPerson
    Private Sub frmAddPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
<<<<<<< HEAD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

=======
    Dim unDE As New clsDPerson
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unEE As New clsPersona
        unEE.setcedula(mskCedula.Text)
        unEE.setnombre(txtName.Text)
        unEE.setapellido(txtLastName.Text)
        unEE.setdireccion(txtAddress.Text)
        unEE.settelefono(txtPhone.Text)
        unDE.altaPersona(unEE)
>>>>>>> gui-rafael
    End Sub
End Class