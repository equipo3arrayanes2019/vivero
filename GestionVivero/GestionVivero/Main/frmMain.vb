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
        Dim browsePlants As New frmListPlants()
        browsePlants.MdiParent = Me
        browsePlants.Show()
    End Sub

    Private Sub TsmiPlant_Click(sender As Object, e As EventArgs) Handles tsmiPlant.Click
        Dim plant = New frmPlant()
        plant.MdiParent = Me
        plant.Show()
    End Sub


End Class
