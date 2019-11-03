Imports Entities
Imports Domain
Public Class frmAddPerson

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
    End Sub

    Private mPerson As EPerson
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Private Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property
    Dim unEE As New EPerson
    Dim unDE As New Controller
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        unEE.CI = CInt(Int(mskCedula.Text))
        unEE.Name = txtName.Text
        unEE.Address = txtAddress.Text
        unEE.Phone = txtPhone.Text
        unEE.User = txtUser.Text
        unEE.Password = txtClave.Text
        unEE.Charge = cxType.Text
        unEE.BirthDate = CDate(dtpFecha.Text)
        unDE.AddPerson(unEE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        unDE.RemovePerson(mskCedula.Text)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Está Seguro Que Quiere Realizar lo cambios", MsgBoxStyle.OkCancel)
        If MsgBoxResult.Ok = 1 Then
            unEE.CI = CInt(Int(mskCedula.Text))
            unEE.Name = txtName.Text
            unEE.Address = txtAddress.Text
            unEE.Phone = txtPhone.Text
            unEE.User = txtUser.Text
            unEE.Password = txtClave.Text
            unEE.Charge = cxType.Text
            unEE.BirthDate = CDate(dtpFecha.Text)
            unDE.ModifyPerson(unEE)
        End If

    End Sub
End Class