Public Class clsPlanta
    Private midPlanta As String
    Private mtiPlanta As String
    Private mLocaPlanta As String
    Public Property idPlanta() As String
        Get
            Return midPlanta
        End Get
        Set(ByVal value As String)
            midPlanta = value
        End Set
    End Property
    Public Property tipoPlanta() As String

        Get
            Return mtiPlanta
        End Get
        Set(ByVal value As String)
            mtiPlanta = value
        End Set
    End Property
    Public Property LocaPlanta() As String
        Get
            Return mLocaPlanta

        End Get
        Set(ByVal value As String)
            mLocaPlanta = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(idPlant As String, tipoPlanta As String, LocaPlanta As String)

        idPlant = idPlant
        tipoPlanta = tipoPlanta
        LocaPlanta = LocaPlanta


    End Sub
End Class
