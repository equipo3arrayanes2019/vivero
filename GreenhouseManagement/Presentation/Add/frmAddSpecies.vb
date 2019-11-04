Imports Domain
Imports Entities

Public Class frmAddSpecies


    Private mUpdate As Boolean = False
    Private mPerson As EPerson
    Private con As New Controller
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Private Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property
    Public Sub New(p As EPerson, s As ESpecies)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        mUpdate = True
        txtName.Text = s.Name
        txtFamily.Text = s.Family
        txtType.Text = s.Type
        nudGrowTime.Value = s.GrowTime
        nudHumidity.Value = Convert.ToDecimal(s.Humidity)
        Dim c As Integer = 0
        For Each item In cbxMoonType.Items
            If item.ToString() = s.MoonType Then
                Exit For
            End If
            c += 1
        Next
        cbxMoonType.SelectedIndex = c
        c = 0
        For Each item In cbxZoneType.Items
            If item.ToString() = s.ZoneType Then
                Exit For
            End If
            c += 1
        Next
        cbxZoneType.SelectedIndex = c
        Me.Text = "Editar Especie"
        btnSave.Text = "Guardar cambios"
    End Sub

    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Person = p
        mUpdate = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim err As Boolean = False
        If mUpdate Then
            Try
                con.UpdateSpecies(New ESpecies(txtName.Text, txtType.Text, txtFamily.Text, cbxZoneType.SelectedItem.ToString(), CInt(nudGrowTime.Value), cbxMoonType.SelectedItem.ToString(), Convert.ToDouble(nudHumidity.Value)))
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
                err = True
            End Try
            If Not err Then
                Me.Close()
            End If
        Else
            Try
                con.AddSpecies(New ESpecies(txtName.Text, txtType.Text, txtFamily.Text, cbxZoneType.SelectedItem.ToString(), CInt(nudGrowTime.Value), cbxMoonType.SelectedItem.ToString(), Convert.ToDouble(nudHumidity.Value)))
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
                err = True
            End Try
            If Not err Then
                txtFamily.Text = ""
                txtName.Text = ""
                txtType.Text = ""
                nudGrowTime.Value = 0
                nudHumidity.Value = 0
            End If
        End If
    End Sub
End Class