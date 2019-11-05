Imports Domain
Imports Entities

Public Class frmListaDOUPLantPot

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
    End Sub

    Private Sub CheckPermissions()
        If Not Person.Charge = "Administrador" Then
            tsmiDelete.Visible = False
            tsmiModify.Visible = False
        End If
    End Sub

    Private mPerson As EPerson
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property

    Private mPlantPots As New List(Of EPlantPot)
    Private mLast As String
    Private con As New Controller

    Private mPlantPot As EPlantPot
    Public Property PlantPot() As EPlantPot
        Get
            Return mPlantPot
        End Get
        Set(ByVal value As EPlantPot)
            mPlantPot = value
        End Set
    End Property
    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If Not txtMaterial.Text = "" Then
            ByMaterial()
        End If
    End Sub

    Private Sub ByMaterial()
        Try
            mPlantPots = con.ListPlantPotByMaterial(txtMaterial.Text)
        Catch ex As Exception
            CommonError.ErrorGetting(ex)
        End Try
        mLast = "ByMaterial"
        LoadDGV()
    End Sub

    Private Sub LoadDGV()
        dgvPlantPotList.Rows.Clear()
        For Each pp As EPlantPot In mPlantPots
            dgvPlantPotList.Rows.Add(pp.ProductName, pp.Material, pp.Size)
        Next
        dgvPlantPotList.Refresh()
    End Sub
    Private Sub Repeat()
        Select Case mLast
            Case "ByMaterial"
                ByMaterial()
        End Select
    End Sub

    Private Sub TsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        Dim result As DialogResult = MessageBox.Show("¿Seguro que desea eliminar el tipo de maceta: " + PlantPot.ProductName + "?", "Eliminar Maceta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                con.RemovePlantPot(PlantPot)
            Catch ex As Exception
                CommonError.ErrorUpdating(ex)
            End Try
            Repeat()
        End If
    End Sub

    Private Sub DgvPlantPotList_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPlantPotList.CellMouseUp
        If e.Button = MouseButtons.Right Then
            cmsInteract.Show(dgvPlantPotList, e.Location)
        End If
    End Sub

    Private Sub DgvPlantPotList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPlantPotList.SelectionChanged
        Dim c As Integer = 0
        If dgvPlantPotList.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        While Not (dgvPlantPotList.SelectedRows(0).GetHashCode() = dgvPlantPotList.Rows(c).GetHashCode())
            c += 1
            If c > dgvPlantPotList.Rows.Count Then
                c = -1
                Exit While
            End If
        End While
        If c = -1 Then
            PlantPot = Nothing
        Else
            PlantPot = mPlantPots(c)
        End If
    End Sub

    Private Sub TsmiModify_Click(sender As Object, e As EventArgs) Handles tsmiModify.Click
        Dim f As New frmAddPlantPot(Person, PlantPot)
        f.ShowDialog()
        f.Dispose()
        Repeat()
    End Sub
End Class