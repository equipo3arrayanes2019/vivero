
Public Class clsMedicion

    Private mid As Integer
    Private mfecha As DateTime
    Private mvalor As String
    Private mSensor_id As clsSensor
    Private mZona_nombre As clsZona

    Public Property id As Integer
        Get
            Return mid
        End Get
        Set(value As Integer)
            mid = value
        End Set
    End Property
    Public Property fecha As DateTime
        Get
            Return mfecha
        End Get
        Set(value As DateTime)
            mfecha = value
        End Set
    End Property
    Public Property valor As String
        Get
            Return mvalor
        End Get
        Set(value As String)
            mvalor = value
        End Set
    End Property
    Public Property Sensor_id As clsSensor
        Get
            Return mSensor_id
        End Get
        Set(value As clsSensor)
            mSensor_id = value
        End Set
    End Property
    Public Property Zona_nombre As clsZona
        Get
            Return mZona_nombre
        End Get
        Set(value As clsZona)
            mZona_nombre = value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(id As Integer, fecha As DateTime, valor As String, Zona_nombre As clsZona, Sensor_id As clsSensor)
        id = id
        fecha = fecha
        valor = valor
        Zona_nombre = Zona_nombre
        Sensor_id = Sensor_id
    End Sub
End Class
