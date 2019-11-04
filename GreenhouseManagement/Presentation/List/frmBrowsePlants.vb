Imports Entities
Imports Domain
Public Class frmBrowsePlants

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
    Dim com As New Controller
    Private Sub ChkSpecies_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecies.CheckedChanged
        cbxSpecies.Enabled = chkSpecies.Checked
    End Sub

    Private Sub frmBrowsePlants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaPlanta As List(Of EPlant)
        'listaPlanta = com.ListPlants()
        dgvPlanta.DataSource = listaPlanta
    End Sub

End Class