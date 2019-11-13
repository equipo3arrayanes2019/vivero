Imports Domain
Imports Entities

Public Class frmAddPlantPot


    Public Sub New(p As EPerson, pp As EPlantPot)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        p = Person
        mUpdate = True
        txtMaterial.Text = pp.Material
        txtName.Text = pp.ProductName
        txtSize.Text = pp.Size
        Me.Text = "Actualizar Maceta"
        mPlantPot = pp
    End Sub
    Public Sub New(p As EPerson)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        p = Person
        mUpdate = False
    End Sub

    Private mPlantPot As EPlantPot
    Private mPerson As EPerson
    Public Property Person() As EPerson
        Get
            Return mPerson
        End Get
        Private Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property
    Private con As New Controller

    Private mUpdate As Boolean

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim err As Boolean = False
        If mUpdate Then
            Try
                mPlantPot.Material = txtMaterial.Text
                mPlantPot.Size = txtSize.Text
                mPlantPot.ProductName = txtName.Text
                con.UpdatePlantPot(mPlantPot)
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
                err = True
            End Try
            If Not err Then
                Me.Close()
            End If
        Else
            Try
                con.AddPlantPot(New EPlantPot(0, txtMaterial.Text, txtSize.Text, 0, txtName.Text))
            Catch ex As Exception
                CommonError.ErrorSaving(ex)
                err = True
            End Try
            If Not err Then
                txtMaterial.Text = ""
                txtName.Text = ""
                txtSize.Text = ""
            End If
        End If
    End Sub
End Class