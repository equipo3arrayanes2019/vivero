Public Class clsAditivo
    Private mid As Integer
    Private mtipo As String
    Private mdescripcion As String
    Private mproducto As Integer
    Public Property id As Integer
        Get
            Return mid
        End Get
        Set(value As Integer)
            mid = value
        End Set
    End Property
    Public Property tipo As String
        Get
            Return mtipo
        End Get
        Set(value As String)
            mtipo = value
        End Set
    End Property
    Public Property descripcion As String
        Get
            Return mdescripcion
        End Get
        Set(value As String)
            mdescripcion = value
        End Set
    End Property
    Public Property producto As Integer
        Get
            Return mproducto
        End Get
        Set(value As Integer)
            mproducto = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, tipo As String, descripcion As String, producto As Integer)
        id = id
        tipo = tipo
        descripcion = descripcion
        producto = producto

    End Sub
End Class
