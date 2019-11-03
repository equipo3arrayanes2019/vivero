Imports Entities
Imports Domain
Public Class frmAddPlants

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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim unEE As New EPlant
        unEE.Id = txtID.Text
        unEE.DatePlanted = mktTime.Text
        unEE.Count = CInt(Int(txtCantidad.Text))
        unEE.Species = txtEspecie.Text
        com.AddPlant(unEE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim unEE As New EPlant
        unEE.Id = txtID.Text
        com.AddPlant(unEE)
    End Sub
End Class