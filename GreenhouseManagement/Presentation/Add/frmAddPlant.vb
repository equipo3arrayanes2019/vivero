Imports Entities

Public Class frmAddPlant


    Public Sub New(p As EPerson, pl As EPlant)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        mSpecies = pl.Species
        mUpdate = False
        txtPrice.Text = pl.Price.ToString()
        lblSpecies.Text = pl.Species.Name
        dtpDate.Value = pl.DatePlanted
    End Sub
    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtPrice.Visible = False
        lblPrice.Visible = False
        Person = p
        mUpdate = False
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

    Private mUpdate As Boolean
    Private mSpecies As ESpecies
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class