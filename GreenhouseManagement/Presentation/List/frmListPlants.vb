Imports Entities
Imports Domain
Public Class frmListPlants

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        CheckPermissions()
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
    Dim con As New Controller

    Private mPlant As EPlant
    Public Property Plant() As EPlant
        Get
            Return mPlant
        End Get
        Set(ByVal value As EPlant)
            mPlant = value
        End Set
    End Property

    Private mPlants As List(Of EPlant)
    Private mLast As String

    Private Sub CheckPermissions()
        If Not (Person.Charge = "Administrador") Then
            tsmiModify.Visible = False
            tsmiDelete.Visible = False
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If Not (txtSpecies.Text = "") Then
            BySpecies()
        End If
    End Sub

    Private Sub BySpecies()
        Try
            mPlants = con.ListPlantsBySpecies(txtSpecies.Text)
        Catch ex As Exception
            CommonError.ErrorGetting(ex)
        End Try

        mLast = "BySpecies"
        LoadDGV()
    End Sub

    Private Sub Repeat()
        Select Case mLast
            Case "BySpecies"
                BySpecies()
        End Select
    End Sub

    Private Sub LoadDGV()
        dgvPlantList.Rows.Clear()
        For Each plant As EPlant In mPlants
            dgvPlantList.Rows.Add(plant.Species.Name, plant.Id, plant.Zone.ZoneName, plant.DatePlanted.ToString("yyyy/M/d"), plant.Price, plant.PlantPot.ProductName)
        Next
        dgvPlantList.Refresh()
    End Sub

    Private Sub DgvPlanta_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPlantList.SelectionChanged
        Dim c As Integer = 0
        If dgvPlantList.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        While Not (dgvPlantList.SelectedRows(0).GetHashCode() = dgvPlantList.Rows(c).GetHashCode())
            c += 1
            If c > dgvPlantList.Rows.Count Then
                c = -1
                Exit While
            End If
        End While
        If c = -1 Then
            Plant = Nothing
        Else
            Plant = mPlants(c)
        End If
    End Sub

    Private Sub TsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        Dim s As New List(Of EPlant)
        Dim plants As String = ""
        Dim n As Integer = 0
        For Each dgrow As DataGridViewRow In dgvPlantList.SelectedRows
            n = 0
            For Each grow As DataGridViewRow In dgvPlantList.Rows
                If grow.GetHashCode() = dgrow.GetHashCode() Then
                    s.Add(mPlants(n))
                    plants += mPlants(n).Species.Name + " (" + mPlants(n).Id.ToString() + "),"
                    Exit For
                End If
                n += 1
            Next
        Next
        plants = plants.Remove(plants.LastIndexOf(","), 1)
        If DialogResult.Yes = MessageBox.Show("Esta seguro que desea eliminar las plantas: " + plants + "?", "Eliminar plantas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            For Each plant As EPlant In s
                Try
                    con.RemovePlant(plant.Id)
                Catch ex As Exception
                    CommonError.ErrorSaving(ex)
                End Try
            Next
        End If
        Repeat()
    End Sub

    Private Sub DgvPlantList_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPlantList.CellMouseUp
        If e.Button = MouseButtons.Right Then
            cmsInteract.Show(dgvPlantList, e.Location)
        End If
    End Sub

    Private Sub TsmiModify_Click(sender As Object, e As EventArgs) Handles tsmiModify.Click
        Dim f As New frmAddPlant(Person, Plant)
        f.ShowDialog()
        f.Dispose()
        Repeat()
    End Sub
End Class