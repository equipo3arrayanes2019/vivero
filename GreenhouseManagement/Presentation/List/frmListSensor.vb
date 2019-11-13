Imports Entities
Imports Domain

Public Class frmListSensor

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Person = p
        CheckPermissions()
    End Sub


    Private Sub CheckPermissions()
        If Not (Person.Charge = "Administrador") Then
            tsmiDelete.Visible = False
            tsmiDelete.Enabled = False
            tsmiModify.Visible = False
            tsmiModify.Enabled = False
        End If
    End Sub

    Private con As New Controller
    Private mPerson As EPerson
    Private mZone As EZone
    Private mSensors As New List(Of ESensor)
    Private mLast As String
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Private Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property

    Private mSensor As ESensor
    Public Property Sensor() As ESensor
        Get
            Return mSensor
        End Get
        Private Set(ByVal value As ESensor)
            mSensor = value
        End Set
    End Property

    Private Sub TsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        For Each row As DataGridViewRow In dgvSensorList.SelectedRows
            con.RemoveSensor(row.Cells.Item(0).Value.ToString())
        Next
        Repeat()
    End Sub

    Private Sub DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSensorList.CellMouseUp
        If e.Button = MouseButtons.Right Then
            cmsInteract.Show(dgvSensorList, e.Location)
        End If
    End Sub

    Private Sub BtnSelectZone_Click(sender As Object, e As EventArgs) Handles btnSelectZone.Click
        Dim f As New frmListZone(Person)
        f.ShowDialog()
        mZone = f.Zone
        f.Dispose()
        If IsNothing(mZone) Then
            lblZone.Text = "Nada seleccionado"
            mSensors = New List(Of ESensor)
        Else
            lblZone.Text = mZone.ZoneName
            ListByZone()
        End If
        mLast = "BYZONE"
    End Sub

    Private Sub ListByZone()
        If Not IsNothing(mZone) Then
            mSensors = con.ListSensorByZone(mZone)
        End If
        LoadDGV()
    End Sub

    Private Sub Repeat()
        Select Case mLast
            Case "BYZONE"
                ListByZone()
        End Select
    End Sub

    Private Sub LoadDGV()
        dgvSensorList.Rows.Clear()
        dgvSensorList.Refresh()
        For Each sensor As ESensor In mSensors
            dgvSensorList.Rows.Add(sensor.SensorId, sensor.Type, sensor.Zone.ZoneName)
        Next
    End Sub

    Private Sub DgvSensorList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSensorList.SelectionChanged
        Dim c As Integer = 0
        If dgvSensorList.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        While Not (dgvSensorList.SelectedRows(0).GetHashCode() = dgvSensorList.Rows(c).GetHashCode())
            c += 1
            If c > dgvSensorList.Rows.Count Then
                c = -1
                Exit While
            End If
        End While
        If c = -1 Then
            Sensor = Nothing
        Else
            Sensor = mSensors(c)
        End If
    End Sub

    Private Sub TsmiModify_Click(sender As Object, e As EventArgs) Handles tsmiModify.Click
        If Not IsNothing(Sensor) Then
            Dim f As New frmAddSensor(Person, Sensor)
            f.ShowDialog()
            f.Dispose()
        End If
        Repeat()
    End Sub
End Class