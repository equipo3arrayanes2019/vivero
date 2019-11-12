Imports Entities
Imports Domain

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
        lblPlantpot.Text = pl.PlantPot.ProductName
        lblSpecies.Text = pl.Species.Name
        lblZone.Text = pl.Zone.ZoneName
        dtpDate.Value = pl.DatePlanted
        mPlant = pl
    End Sub

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        mUpdate = False
        mPlant = New EPlant()
        mPlant.Id = 0
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

    Private mPlantPot As EPlantPot
    Private mSpecies As ESpecies
    Private mUpdate As Boolean
    Private mZone As EZone
    Private mPlant As EPlant
    Private con As New Controller

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsNothing(mSpecies) Then
            MessageBox.Show("Seleccione una especie", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If IsNothing(mPlantPot) Then
            MessageBox.Show("Seleccione un tipo de maceta", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If IsNothing(mZone) Then
            MessageBox.Show("Seleccione la zona en la que esta ubicada", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Try
            mPlant.Price = Convert.ToDouble(txtPrice.Text)
        Catch ex As Exception
            MessageBox.Show("Campo vacío, letras ingresadas o número muy grande", "Precio incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        mPlant.DatePlanted = dtpDate.Value
        mPlant.Species = mSpecies
        mPlant.Zone = mZone
        mPlant.PlantPot = mPlantPot
        If mUpdate Then
            Try
                con.ModifyPlant(mPlant)
            Catch ex As Exception
                CommonError.ErrorUpdating(ex)
            End Try
        Else
            Try
                con.AddPlant(mPlant)
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
            End Try
        End If
    End Sub

    Private Sub BtnPickSpecies_Click(sender As Object, e As EventArgs) Handles btnPickSpecies.Click
        Dim f As New frmListSpecies(Person)
        f.ShowDialog()
        mSpecies = f.Species
        f.Dispose()
        If IsNothing(mSpecies) Then
            lblSpecies.Text = "Nada seleccionado"
        Else
            lblSpecies.Text = mSpecies.Name
        End If
    End Sub

    Private Sub BtnPickPlantPot_Click(sender As Object, e As EventArgs) Handles btnPickPlantPot.Click
        Dim f As New frmListPlantPot(Person)
        f.ShowDialog()
        mPlantPot = f.PlantPot
        f.Dispose()
        If IsNothing(mPlantPot) Then
            lblPlantpot.Text = "Nada seleccionado"
        Else
            lblPlantpot.Text = mPlantPot.ProductName
        End If
    End Sub

    Private Sub BtnPickZone_Click(sender As Object, e As EventArgs) Handles btnPickZone.Click
        Dim f As New frmListZone(Person)
        f.ShowDialog()
        mZone = f.Zone
        f.Dispose()
        If IsNothing(mZone) Then
            lblZone.Text = "Nada seleccionado"
        Else
            lblZone.Text = mZone.ZoneName
        End If
    End Sub
End Class