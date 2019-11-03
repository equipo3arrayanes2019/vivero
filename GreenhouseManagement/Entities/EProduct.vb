Public Class EProduct
    Private mProductId As Integer
    Private mProductName As String
    Public Property ProductId As Integer
        Get
            Return mProductId
        End Get
        Set(value As Integer)
            mProductId = value
        End Set
    End Property
    Public Property ProductName As String
        Get
            Return mProductName
        End Get
        Set(value As String)
            mProductName = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ProductId As Integer, ProductName As String)
        Me.mProductId = ProductId
        Me.ProductName = ProductName

    End Sub
End Class