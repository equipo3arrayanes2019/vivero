Imports Entities
Imports Domain
Public Class frmListadoherramienta
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
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim com As New DTool
        Dim listarHerramienta As List(Of ETool)
        dgvTools.ClearSelection()
        listarHerramienta = com.listarHerramienta()
        For Each unaM In listarHerramienta
            dgvTools.Rows.Add(unaM.Use, unaM.Type, unaM.ZoneName.ZoneName, unaM.ProductId)
        Next
    End Sub
End Class