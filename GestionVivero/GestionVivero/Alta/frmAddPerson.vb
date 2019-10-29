Imports Dominio
Imports Entidades
Public Class frmAddPerson
    Dim unEE As New clsPersona
    Dim unDE As New clsControlador
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        unEE.cedula = CInt(Int(mskCedula.Text))
        unEE.nombre = txtName.Text
        unEE.direccion = txtAddress.Text
        unEE.tele = txtPhone.Text
        unEE.user = txtUser.Text
        unEE.contra = txtClave.Text
        unEE.cargo = cxType.Text
        unEE.fecha = CDate(dtpFecha.Text)
        unDE.altaPersona(unEE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        unDE.bajaPersona(mskCedula.Text)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Está Seguro Que Quiere Realizar lo cambios", MsgBoxStyle.OkCancel)
        If MsgBoxResult.Ok = 1 Then
            unEE.cedula = CInt(Int(mskCedula.Text))
            unEE.nombre = txtName.Text
            unEE.direccion = txtAddress.Text
            unEE.tele = txtPhone.Text
            unEE.user = txtUser.Text
            unEE.contra = txtClave.Text
            unEE.cargo = cxType.Text
            unEE.fecha = CDate(dtpFecha.Text)
            unDE.modificarPersona(unEE)
        End If

    End Sub
End Class