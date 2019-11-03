Public Class EZone
    Private mZoneName As String
    Private mSize As String
    Private mType As String


    Public Property ZoneName As String
        Get
            Return mZoneName
        End Get
        Set(value As String)
            mZoneName = value
        End Set
    End Property
    Public Property Size As String
        Get
            Return mSize
        End Get
        Set(value As String)
            mSize = value
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

    Public Sub New()
    End Sub

    Public Sub New(ZoneName As String, Size As String, Type As String)
        Me.ZoneName = ZoneName
        Me.Size = Size
        Me.Type = Type
    End Sub
End Class
