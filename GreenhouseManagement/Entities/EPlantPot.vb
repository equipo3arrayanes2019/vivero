
Public Class EPlantPot
    Inherits EProduct

    Private mMaterial As String
    Public Property Material() As String
        Get
            Return mMaterial
        End Get
        Set(ByVal value As String)
            mMaterial = value
        End Set
    End Property

    Private mId As Integer
    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Private mSize As String
    Public Property Size() As String
        Get
            Return mSize
        End Get
        Set(ByVal value As String)
            mSize = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(Id As Integer, Material As String, Size As String, ProductId As Integer, ProductName As String)
        Me.ProductId = ProductId
        Me.ProductName = ProductName
        Me.Id = Id
        Me.Material = Material
        Me.Size = Size
    End Sub

End Class
