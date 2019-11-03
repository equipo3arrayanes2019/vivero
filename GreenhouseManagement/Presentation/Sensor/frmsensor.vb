Imports Entities
Imports Domain
Public Class frmsensor

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
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
    Private Sub btnEstado_Click(sender As Object, e As EventArgs) Handles btnEstado.Click
        Dim com As New DMeasurment
        Dim listarMedicion As List(Of EMeasurement)
        'listarMedicion = com.listarMedicion()
        'dgvSensors.DataSource = listarMedicion
        dgvSensors.ClearSelection()
        listarMedicion = com.List()
        For Each unaM In listarMedicion
            dgvSensors.Rows.Add(unaM.Id, unaM.DateTaken, unaM.Value, unaM.ZoneName.ZoneName, unaM.SensorId.SensorId)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmtemp.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmGraphic.Show()
    End Sub
End Class