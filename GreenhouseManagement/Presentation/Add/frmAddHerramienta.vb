Imports Entities
Imports Domain
Public Class frmAddHerramienta
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
    Dim com As DTool
    Dim unDZ As New DZone
    Dim com1 As DPlant
    Dim unHE As ETool
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        unHE.Use = txtUso.Text
        unHE.Type = cbxTipo.Text
        unHE.ZoneName.ZoneName = cbxZona.Text
        unHE.ProductName = txtNombre.Text
        com.altaHerramienta(unHE)
    End Sub

    Private Sub frmAddHerramienta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim colZonas = unDZ.List
        cbxZona.ValueMember = "Zona_nombre"
        cbxZona.DisplayMember = "Zona_nombre"
        cbxZona.DataSource = colZonas
    End Sub
End Class