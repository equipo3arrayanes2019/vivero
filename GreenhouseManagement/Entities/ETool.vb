Public Class ETool
    Inherits EProduct

    Private mType As String
    Private mName As EZone
    Private mUse As String

    Public Property Type As String
        Get
            Return mType
        End Get
        Set(value As String)
            mType = value
        End Set
    End Property
    Public Property ZoneName As EZone
        Get
            Return mName
        End Get
        Set(value As EZone)
            mName = value
        End Set
    End Property
    Public Property Use As String
        Get ''es to hace una wea
            Return mUse
        End Get
        Set(value As String)
            mUse = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Type As String, ProductId As Integer, ZoneName As EZone, Use As String)
        Me.Use = Use
        Me.Type = Type
        Me.ProductId = ProductId
        Me.ZoneName = ZoneName
    End Sub
End Class
