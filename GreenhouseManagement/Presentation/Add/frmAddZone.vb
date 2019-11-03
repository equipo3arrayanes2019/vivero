Imports Entities
Imports Domain
Public Class frmAddZone
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
    Dim unDZ As New DZone
    Dim unEZ As New EZone
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim err As Boolean = False
        unEZ.ZoneName = txtID.Text
        unEZ.Size = txtSize.Text
        unEZ.Type = cbxType.Items.Item(cbxType.SelectedIndex).ToString()
        Try
            unDZ.Add(unEZ)
        Catch ex As Exception
            CommonError.ErrorSaving(ex)
            err = True
        End Try
        If Not err Then
            txtID.Text = ""
            txtSize.Text = ""
        End If
    End Sub

    Private Sub FrmAddZone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxType.SelectedIndex = 0
    End Sub
End Class