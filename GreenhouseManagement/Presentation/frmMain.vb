Imports Entities

Public Class frmMain

    Private pCloseProgram As Boolean
    Public Property CloseProgram() As Boolean
        Get
            Return pCloseProgram
        End Get
        Private Set(ByVal value As Boolean)
            pCloseProgram = value
        End Set
    End Property

    Private mPerson As EPerson
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property
    Public Sub New(Person As EPerson)
        Me.Person = Person
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.Text = "Vivero Me Gusta " + Person.User + " (" + Person.Name + ")" + " : " + Person.Charge
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        PermissionCheck()
    End Sub

    Private Sub PermissionCheck()
        If Not Person.Charge = "Administrador" Then
            tsmiZoneAdd.Visible = False
            tsmiZoneAdd.Enabled = False
            tsmiSensorsAddnew.Visible = False
            tsmiSensorsAddnew.Enabled = False
            tsmiSpeciesBookAdd.Enabled = False
            tsmiSpeciesBookAdd.Visible = False
            tsmiPlantPotAdd.Visible = False
            tsmiPlantPotAdd.Enabled = False
        End If
    End Sub

    Private Sub tsmiCloseProgram_Click(sender As Object, e As EventArgs) Handles tsmiCloseProgram.Click
        Me.CloseProgram = True
        Me.Close()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        Me.CloseProgram = False
        Me.Close()
    End Sub

    Private Sub TsmiSpeciesBookAdd_Click(sender As Object, e As EventArgs) Handles tsmiSpeciesBookAdd.Click
        Dim addPlants As New frmAddSpecies(Person)
        addPlants.MdiParent = Me
        addPlants.Show()
    End Sub

    Private Sub TsmiSpeciesBookBrowse_Click(sender As Object, e As EventArgs) Handles tsmiSpeciesBookBrowse.Click
        Dim browsePlants As New frmListSpecies(Person)
        browsePlants.MdiParent = Me
        browsePlants.Show()
    End Sub

    Private Sub TsmiPlant_Click(sender As Object, e As EventArgs) Handles tsmiPlant.Click
        Dim plant = New frmAddPlant(Person)
        plant.MdiParent = Me
        plant.Show()
    End Sub

    Private Sub tsmiRegister_Click(sender As Object, e As EventArgs) Handles tsmiRegister.Click
        Dim addPerson = New frmAddPerson(Person)
        addPerson.MdiParent = Me
        addPerson.Show()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        Dim listperson = New listPerson(Person)
        listperson.MdiParent = Me
        listperson.Show()
    End Sub

    Private Sub tsmiStockMaterialsAdd_Click(sender As Object, e As EventArgs) Handles tsmiStockMaterialsAdd.Click
        Dim addAditivo = New frmaddAditivo(Person)
        addAditivo.MdiParent = Me
        addAditivo.Show()
    End Sub

    Private Sub tsmiStockMaterialsList_Click(sender As Object, e As EventArgs) Handles tsmiStockMaterialsList.Click
        Dim addAditivo = New frmaddAditivo(Person)
        addAditivo.MdiParent = Me
        addAditivo.Show()
    End Sub

    Private Sub tsmiZoneOutdoorsList_Click(sender As Object, e As EventArgs)
        Dim addZona = New frmListZone(Person)
        addZona.MdiParent = Me
        addZona.Show()
    End Sub

    Private Sub ListarToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        Dim addMedicion = New frmsensor(Person)
        addMedicion.MdiParent = Me
        addMedicion.Show()
    End Sub

    Private Sub ListarToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim addSensor = New frmListadorSensor(Person)
        addSensor.MdiParent = Me
        addSensor.Show()
    End Sub

    Private Sub tsmiStockToolsAdd_Click(sender As Object, e As EventArgs) Handles tsmiStockToolsAdd.Click
        Dim addHerramienta = New frmAddHerramienta(Person)
        addHerramienta.MdiParent = Me
        addHerramienta.Show()

    End Sub

    Private Sub tsmiStockToolsList_Click(sender As Object, e As EventArgs) Handles tsmiStockToolsList.Click
        Dim listHerramienta = New frmListadoherramienta(Person)
        listHerramienta.MdiParent = Me
        listHerramienta.Show()
    End Sub

    Private Sub TsmiZoneAdd_Click(sender As Object, e As EventArgs) Handles tsmiZoneAdd.Click
        Dim addZona = New frmAddZone(Person)
        addZona.MdiParent = Me
        addZona.Show()
    End Sub

    Private Sub TsmiZoneViewZone_Click(sender As Object, e As EventArgs) Handles tsmiZoneViewZone.Click
        Dim addZona = New frmListZone(Person)
        addZona.MdiParent = Me
        addZona.Show()
    End Sub

    Private Sub TsmiSensorsAddnew_Click(sender As Object, e As EventArgs) Handles tsmiSensorsAddnew.Click
        Dim addZona = New frmAddSensor(Person)
        addZona.MdiParent = Me
        addZona.Show()
    End Sub

    Private Sub TsmiViewSensor_Click(sender As Object, e As EventArgs) Handles tsmiViewSensor.Click
        Dim f As New frmListSensor(Person)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactoToolStripMenuItem.Click
        Dim f As New frmContact()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub TsmiPlantPotAdd_Click(sender As Object, e As EventArgs) Handles tsmiPlantPotAdd.Click
        Dim f As New frmAddPlantPot(Person)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub TsmiPlantPotList_Click(sender As Object, e As EventArgs) Handles tsmiPlantPotList.Click
        Dim f As New frmListaDOUPLantPot(Person)
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
