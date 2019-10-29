Public Class clsZona
    Private mZona_nombre As String
    Private mtamaño As String
    Private mtipo As String


    Public Property Zona_nombre As String
        Get
            Return mZona_nombre
        End Get
        Set(value As String)
            mZona_nombre = value
        End Set
    End Property
    Public Property tamaño As String
        Get
            Return mtamaño
        End Get
        Set(value As String)
            mtamaño = value
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

    Public Sub New()
    End Sub

    Public Sub New(Zona_nombre As String, tamaño As String, tipo As String)
        Zona_nombre = Zona_nombre
        tamaño = tamaño
        tipo = tipo
    End Sub
End Class
