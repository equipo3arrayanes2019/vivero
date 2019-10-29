Public Class clsPlanta
    Private mnid As String
    Private mfecha As String
    Private mespecie As String
    Private mcantidad As Integer
    Public Property id() As String
        Get
            Return mnid
        End Get
        Set(ByVal value As String)
            mnid = value
        End Set
    End Property
    Public Property fecha() As String

        Get
            Return mfecha
        End Get
        Set(ByVal value As String)
            mfecha = value
        End Set
    End Property
    Public Property especie() As String
        Get
            Return mespecie

        End Get
        Set(ByVal value As String)
            mespecie = value
        End Set
    End Property

    Public Property cantidad As Integer
        Get
            Return mcantidad
        End Get
        Set(value As Integer)
            mcantidad = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(id As String, fecha As String, especie As String, cantidad As Integer)

        id = id
        especie = especie
        fecha = fecha
        cantidad = cantidad

    End Sub
End Class
