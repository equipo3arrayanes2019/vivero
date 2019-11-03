Imports Entities
Imports Domain

Public Class frmListSensor

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
    End Sub
    Private con As New Controller
    Private mPerson As EPerson
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Private Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property

    Private Sub TsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        For Each row As DataGridViewRow In dgvSensorList.SelectedRows
            con.RemoveSensor(row.Cells.Item(0).Value.ToString())
        Next
    End Sub

    Private Sub DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSensorList.CellMouseUp
        If e.Button = MouseButtons.Right Then
            cmsInteract.Show(dgvSensorList, e.Location)
        End If
    End Sub
End Class