Imports Entities
Imports Domain
Public Class frmAddPerson

    Public Sub New(p As EPerson, pp As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        mskCedula.Text = pp.CI.ToString()
        txtName.Text = pp.Name
        txtAddress.Text = pp.Address
        txtPhone.Text = pp.Phone
        txtUser.Text = pp.User
        txtClave.Text = pp.Password
        cbxType.SelectedItem = pp.Charge
        dtpBirthDate.Value = pp.BirthDate

        Person = p
        mUpdate = False
    End Sub

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        mUpdate = False
    End Sub

    Private mUpdate As Boolean
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
        unEE.Charge = cbxType.Text
        unEE.BirthDate = dtpBirthDate.Value

        If mUpdate Then
            Dim err As Boolean = False
            Try
                unDE.ModifyPerson(unEE)
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
                err = True
            End Try
            If Not err Then
                Me.Close()
            End If
        Else
            Try
                unDE.AddPerson(unEE)
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
            End Try
        End If

    End Sub
End Class