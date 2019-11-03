Imports Entities
Imports Domain
Public Class frmListadorSensor
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
    Private Sub btnUpdateSensor_Click(sender As Object, e As EventArgs) Handles btnUpdateSensor.Click
        Dim com As New DSensor
        Dim listarSensor As List(Of ESensor)
        listarSensor = com.List()
        dgvSensor.DataSource = listarSensor
        dgvSensor.ClearSelection()
    End Sub
End Class