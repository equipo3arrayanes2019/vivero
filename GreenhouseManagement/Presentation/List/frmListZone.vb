Imports Entities
Imports Domain
Public Class frmListZone


    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        CheckPermissions()
    End Sub

    Private mSearchTerm As String
    Private mSearchType As String
    Private Sub CheckPermissions()
        If Not (Person.Charge = "Administrador") Then
            tsmiDeleteZones.Visible = False
            tsmiDeleteZones.Enabled = False
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
    Private con As New Controller()
    Private zones As New List(Of EZone)
    Private mZone As EZone
    Public Property Zone() As EZone
        Get
            Return mZone
        End Get
        Private Set(ByVal value As EZone)
            mZone = value
        End Set
    End Property


    Private Sub BtnByType_Click(sender As Object, e As EventArgs) Handles btnByType.Click
        Dim f As New frmAskZoneType()
        f.ShowDialog()
        Dim type = f.Selected
        f.Dispose()
        ListByType(type)
        mSearchTerm = type
        mSearchType = "TYPE"
    End Sub

    Private Sub ListByType(type As String)
        zones = con.ListZonesByType(type)
        LoadDGV()
    End Sub

    Private Sub Repeat()
        Select Case mSearchType
            Case "TYPE"
                ListByType(mSearchTerm)
        End Select
    End Sub

    Private Sub LoadDGV()
        dgvZones.Rows.Clear()
        dgvZones.Refresh()
        For Each z In zones
            dgvZones.Rows.Add(z.ZoneName, z.Size, z.Type)
        Next
    End Sub

    Private Sub TsmiDeleteZones_Click(sender As Object, e As EventArgs) Handles tsmiDeleteZones.Click
        Dim selected As String = ""
        For Each row As DataGridViewRow In dgvZones.SelectedRows
            selected += row.Cells.Item(0).Value.ToString() + ", "
        Next
        If selected IsNot "" Then
            selected = selected.Substring(0, selected.Length - 2)
            Dim result = MessageBox.Show("Esta seguro que desea eliminar las zonas: " + selected, "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For Each row As DataGridViewRow In dgvZones.SelectedRows
                    con.RemoveZone(row.Cells.Item(0).Value.ToString())
                Next
            End If
            Repeat()
        End If
    End Sub

    Private Sub DgvZones_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvZones.MouseUp
        If e.Button = MouseButtons.Right Then
            cmsInteract.Show(dgvZones, e.Location)
        End If
    End Sub

    Private Sub DgvZones_SelectionChanged(sender As Object, e As EventArgs) Handles dgvZones.SelectionChanged
        Dim c As Integer = 0
        If dgvZones.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        While Not (dgvZones.SelectedRows(0).GetHashCode() = dgvZones.Rows(c).GetHashCode())
            c += 1
            If c > dgvZones.Rows.Count Then
                Exit While
                c = -1
            End If
        End While
        If c = -1 Then
            Zone = Nothing
        Else
            Zone = zones(c)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class