Public Class ESensor
    Private mSensorId As String
    Private mType As String
    Public Property SensorId As String
        Get
            Return mSensorId
        End Get
        Set(value As String)
            mSensorId = value
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

    Private mZone As EZone
    Public Property Zone() As EZone
        Get
            Return mZone
        End Get
        Set(ByVal value As EZone)
            mZone = value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(SensorId As String, Type As String, Zone As EZone)
        Me.SensorId = SensorId
        Me.Type = Type
        Me.Zone = Zone
    End Sub
End Class
