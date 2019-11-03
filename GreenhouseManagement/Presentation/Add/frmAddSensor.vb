Imports Domain
Imports Entities

Public Class frmAddSensor
    Private con As New Controller
    Private zones As New List(Of EZone)
    Private mModify As Boolean

    Public Sub New(p As EPerson, sensor As ESensor)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "Modificar Sensor"
        Person = p
        mModify = True
        cbxType.SelectedItem = 0
        LoadZones()
        Person = p
        Dim c As Integer = 0
        For Each zone As EZone In zones
            If zone.ZoneName = sensor.Zone.ZoneName Then
                Exit For
            End If
            c += 1
        Next
        cbxZone.SelectedIndex = c
        c = 0
        For Each item In cbxType.Items
            If item.ToString = sensor.Type Then
                Exit For
            End If
            c += 1
        Next
        cbxType.SelectedIndex = c
        txtId.Text = sensor.SensorId
    End Sub

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mModify = False
        Person = p
        cbxType.SelectedItem = 0
        LoadZones()
        cbxZone.SelectedIndex = 0
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

    Private Sub LoadZones()
        Try
            zones = con.ListZone()
        Catch ex As Exception
            CommonError.ErrorGetting(ex)
        End Try
        For Each zone As EZone In zones
            cbxZone.Items.Add(zone.ZoneName)
        Next
        cbxZone.SelectedIndex = 0
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim err As Boolean = False
        If mModify Then
            Try
                con.UpdateSensor(New ESensor(txtId.Text, cbxType.Items.Item(cbxType.SelectedIndex).ToString(), zones(cbxZone.SelectedIndex)))
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
                err = True
            End Try
            If Not err Then
                Me.Close()
            End If
        Else
            Try
                con.AddSensor(New ESensor(txtId.Text, cbxType.Items.Item(cbxType.SelectedIndex).ToString(), zones(cbxZone.SelectedIndex)))
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
                err = True
            End Try
            If Not err Then
                txtId.Text = ""
            End If
        End If
    End Sub
End Class