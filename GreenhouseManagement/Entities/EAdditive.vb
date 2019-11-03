Public Class EAdditive
    Inherits EProduct
    Private mId As Integer
    Private mType As String
    Private mDescription As String
    Public Property Id As Integer
        Get
            Return mId
        End Get
        Set(value As Integer)
            [mId] = value
        End Set
    End Property
    Public Property Type As String
        Get
            Return mType
        End Get
        Set(value As String)
            mType = value
        End Set
    End Property
    Public Property Description As String
        Get
            Return mDescription
        End Get
        Set(value As String)
            mDescription = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Id As Integer, Type As String, Descriptrion As String, ProductId As Integer, ProductName As String)
        Me.Id = Id
        Me.Type = Type
        Me.Description = Descriptrion
        Me.ProductId = ProductId
        Me.ProductName = ProductName
    End Sub
End Class
