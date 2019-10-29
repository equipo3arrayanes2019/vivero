Imports Dominio
Imports Entidades
Public Class frmAddPerson
    Dim unEE As New clsPersona
    Dim unDE As New clsDPerson
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        unEE.cedula = CInt(Int(mskCedula.Text))
        unEE.nombre = txtName.Text
        unEE.direccion = txtAddress.Text
        unEE.tele = txtPhone.Text
        unEE.user = txtUser.Text
        unEE.contra = txtClave.Text
        unEE.cargo = cxType.Text
        unEE.fecha = mTime.Text
        unDE.altaPersona(unEE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        unDE.bajaPersona(mskCedula.Text)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        unEE.cedula = CInt(Int(mskCedula.Text))
        unEE.nombre = txtName.Text
        unEE.direccion = txtAddress.Text
        unEE.tele = txtPhone.Text
        unEE.user = txtUser.Text
        unEE.contra = txtClave.Text
        unEE.cargo = cxType.Text
        unEE.fecha = mTime.Text
        unDE.modificarPersona(unEE)
    End Sub
End Class