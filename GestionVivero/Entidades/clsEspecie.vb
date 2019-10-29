Public Class clsEspecie
    Private mnombre As String
    Private mtipo As String
    Private mfamilia As String
    Private mtipoZona As String
    Private mTiempoCultivo As Integer
    Private mTipoLuna As String
    Private mhumedad As Double
    Public Property nombre As String
        Get
            Return mnombre
        End Get
        Set(value As String)
            mnombre = value
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
    Public Property familia As String
        Get
            Return mfamilia
        End Get
        Set(value As String)
            mfamilia = value
        End Set
    End Property
    Public Property tipozona As String
        Get
            Return mtipoZona
        End Get
        Set(value As String)
            mtipoZona = value
        End Set
    End Property
    Public Property Tiempocultivo As Integer
        Get
            Return mTiempoCultivo
        End Get
        Set(value As Integer)
            mTiempoCultivo = value
        End Set
    End Property
    Public Property tipoLuna As String
        Get
            Return mTipoLuna
        End Get
        Set(value As String)
            mTipoLuna = value
        End Set
    End Property
    Public Property humeadad As Double
        Get
            Return mhumedad
        End Get
        Set(value As Double)
            mhumedad = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
