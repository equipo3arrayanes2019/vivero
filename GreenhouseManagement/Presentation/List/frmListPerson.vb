Imports Entities
Imports Domain
Public Class frmListPerson

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
        Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property
    Dim com As New Controller
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim listaPersona As List(Of EPerson)
        listaPersona = com.ListPerson()
        dgvPerson.DataSource = listaPersona
        dgvPerson.ClearSelection()
    End Sub
End Class