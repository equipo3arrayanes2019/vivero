Imports Domain
Imports Entities

Public Class frmListSpecies

    Public Sub New(p As EPerson)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        CheckPersmissions()
    End Sub

    Private Sub CheckPersmissions()
        If Not (Person.Charge = "Administrador") Then
            tsmiDelete.Enabled = False
            tsmiDelete.Visible = False
            tsmiModify.Enabled = False
            tsmiModify.Visible = False
        End If
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

    Private mSpecies As New List(Of ESpecies)
    Private con As New Controller()
    Private mLast As String

    Private m_Species As ESpecies
    Public Property Species() As ESpecies
        Get
            Return m_Species
        End Get
        Private Set(ByVal value As ESpecies)
            m_Species = value
        End Set
    End Property
    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If Not (txtName.Text = "") Then
            ByName()
        ElseIf Not (txtType.Text = "") Then
            ByType()
        End If
    End Sub
    Private Sub repeat()
        Select Case mLast
            Case "BYTYPE"
                ByType()
            Case "BYNAME"
                ByName()
        End Select
    End Sub

    Private Sub ByName()
        Try
            mSpecies = con.SpeciesByName(txtName.Text)
        Catch ex As Exception
            CommonError.ErrorGetting(ex)
        End Try
        mLast = "BYNAME"
        LoadDGV()
    End Sub
    Private Sub ByType()
        Try
            mSpecies = con.SpeciesByType(txtType.Text)
        Catch ex As Exception
            CommonError.ErrorGetting(ex)
        End Try
        mLast = "BYTYPE"
        LoadDGV()
    End Sub

    Private Sub LoadDGV()
        dgvSpeciesList.Rows.Clear()
        For Each s As ESpecies In mSpecies
            dgvSpeciesList.Rows.Add(s.Name, s.Type, s.Family, s.ZoneType, s.GrowTime.ToString() + " Días", s.MoonPhase, s.Humidity.ToString())
        Next
        dgvSpeciesList.Refresh()
    End Sub

    Private Sub TsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que desea eliminar la especie: " + Species.Name, "Eliminar especie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                con.RemoveSpecies(Species.Name)
            Catch ex As Exception
                CommonError.ErrorUpdating(ex)
            End Try
        End If
        repeat()
    End Sub

    Private Sub TsmiModify_Click(sender As Object, e As EventArgs) Handles tsmiModify.Click
        If Not IsNothing(Species) Then
            Dim f As New frmAddSpecies(Person, Species)
            f.ShowDialog()
        End If
        repeat()
    End Sub
    Private Sub DgvSpeciesList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSpeciesList.SelectionChanged
        Dim c As Integer = 0
        If dgvSpeciesList.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        While Not (dgvSpeciesList.SelectedRows(0).GetHashCode() = dgvSpeciesList.Rows(c).GetHashCode())
            c += 1
            If c > dgvSpeciesList.Rows.Count Then
                Exit While
                c = -1
            End If
        End While
        If c = -1 Then
            Species = Nothing
        Else
            Species = mSpecies(c)
        End If
    End Sub

    Private Sub DgvSpeciesList_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSpeciesList.CellMouseUp
        If e.Button = MouseButtons.Right Then
            cmsInteract.Show(dgvSpeciesList, e.Location)
        End If
    End Sub
End Class