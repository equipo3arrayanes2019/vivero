Public Class clsSensor
    Private mSensor_id As String
    Private mtipo As String
    Public Property Sensor_id As String
        Get
            Return mSensor_id
        End Get
        Set(value As String)
            mSensor_id = value
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

    Public Sub New(Sensor_id As String, tipo As String, ZonaNombre As clsSensor())
        Sensor_id = Sensor_id
        tipo = tipo
        ZonaNombre = ZonaNombre
    End Sub
End Class
