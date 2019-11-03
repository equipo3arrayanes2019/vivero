Imports Domain
Imports Entities

Public Class frmAddSensor
    Private con As New Controller
    Private zones As New List(Of EZone)
    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cbxType.SelectedItem = 0
        LoadZones()
        Person = p
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
        Try
            con.AddSensor(New ESensor(txtId.Text, cbxType.Items.Item(cbxType.SelectedIndex).ToString(), zones(cbxZone.SelectedIndex)))
        Catch ex As Exception
            CommonError.ErrorSaving(ex)
            err = True
        End Try
        If Not err Then
            txtId.Text =""
        End If
    End Sub
End Class