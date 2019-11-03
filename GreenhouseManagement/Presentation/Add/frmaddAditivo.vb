Imports Entities
Imports Domain
Public Class frmaddAditivo

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
        Set(ByVal value As EPerson)
            mPerson = value
        End Set
    End Property
    Dim com As New DAdditive
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim unEE As New EAdditive
        unEE.Id = CInt(Int(txtID.Text))
        unEE.Type = txtProducto.Text
        unEE.Description = txtObsv.Text
        unEE.ProductId = CInt(Int(txtProducto.Text))
        com.Add(unEE)
    End Sub
End Class