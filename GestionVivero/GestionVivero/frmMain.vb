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

    Private Sub tsmiCloseProgram_Click(sender As Object, e As EventArgs) Handles tsmiCloseProgram.Click
        Me.CloseProgram = True
        Me.Close()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        Me.CloseProgram = False
        Me.Close()
    End Sub

    Private Sub TsmiSpeciesBookAdd_Click(sender As Object, e As EventArgs) Handles tsmiSpeciesBookAdd.Click
        Dim addPlants As New frmAddPlants()
        addPlants.MdiParent = Me
        AddPlants.Show()
    End Sub

    Private Sub TsmiSpeciesBookBrowse_Click(sender As Object, e As EventArgs) Handles tsmiSpeciesBookBrowse.Click
        Dim browsePlants As New frmBrowsePlants()
        browsePlants.MdiParent = Me
        browsePlants.Show()
    End Sub

    Private Sub TsmiPlant_Click(sender As Object, e As EventArgs) Handles tsmiPlant.Click
        Dim plant = New frmPlant()
        plant.MdiParent = Me
        plant.Show()
    End Sub

    Private Sub tsmiRegister_Click(sender As Object, e As EventArgs) Handles tsmiRegister.Click
        Dim addPerson = New frmAddPerson()
        addPerson.MdiParent = Me
        addPerson.Show()
        frmAddPerson.mskCedula.ReadOnly = False
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        Dim listperson = New listPerson()
        listperson.MdiParent = Me
        listperson.Show()
    End Sub

    Private Sub tsmiStockMaterialsAdd_Click(sender As Object, e As EventArgs) Handles tsmiStockMaterialsAdd.Click
        FrmaddAditivo.Show()
    End Sub

    Private Sub tsmiStockMaterialsList_Click(sender As Object, e As EventArgs) Handles tsmiStockMaterialsList.Click
        Dim addAditivo = New FrmaddAditivo()
        addAditivo.MdiParent = Me
        addAditivo.Show()
    End Sub

    Private Sub tsmiZoneOutdoorsList_Click(sender As Object, e As EventArgs) Handles tsmiZoneOutdoorsList.Click
        Dim addZona = New frmListadoZona()
        addZona.MdiParent = Me
        addZona.Show()
    End Sub

    Private Sub ListarToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem4.Click
        Dim addMedicion = New frmsensor()
        addMedicion.MdiParent = Me
        addMedicion.Show()
    End Sub

    Private Sub ListarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem2.Click
        Dim addSensor = New frmListadorSensor()
        addSensor.MdiParent = Me
        addSensor.Show()
    End Sub

    Private Sub tsmiStockToolsAdd_Click(sender As Object, e As EventArgs) Handles tsmiStockToolsAdd.Click
        Dim addHerramienta = New frmAddHerramienta()
        addHerramienta.MdiParent = Me
        addHerramienta.Show()

    End Sub

    Private Sub tsmiStockToolsList_Click(sender As Object, e As EventArgs) Handles tsmiStockToolsList.Click
        Dim listHerramienta = New frmListadoherramienta()
        listHerramienta.MdiParent = Me
        listHerramienta.Show()
    End Sub

    Private Sub tsmiZoneOutdoorsAdd_Click(sender As Object, e As EventArgs) Handles tsmiZoneOutdoorsAdd.Click
        Dim addZona = New frmAddZona()
        addZona.MdiParent = Me
        addZona.Show()
    End Sub
End Class
