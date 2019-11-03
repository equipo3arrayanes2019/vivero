
Public Class EMeasurement

    Private mId As Integer
    Private mDateTaken As DateTime
    Private mValue As String
    Private mSensorId As ESensor
    Private mZoneName As EZone

    Public Property Id As Integer
        Get
            Return mId
        End Get
        Set(value As Integer)
            [mId] = value
        End Set
    End Property
    Public Property DateTaken As DateTime
        Get
            Return mDateTaken
        End Get
        Set(value As DateTime)
            mDateTaken = value
        End Set
    End Property
    Public Property Value As String
        Get
            Return mValue
        End Get
        Set(value As String)
            mValue = value
        End Set
    End Property
    Public Property SensorId As ESensor
        Get
            Return mSensorId
        End Get
        Set(value As ESensor)
            mSensorId = value
        End Set
    End Property
    Public Property ZoneName As EZone
        Get
            Return mZoneName
        End Get
        Set(value As EZone)
            mZoneName = value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(Id As Integer, DateTaken As DateTime, Value As String, ZoneName As EZone, SensorId As ESensor)
        Me.Id = Id
        Me.DateTaken = DateTaken
        Me.Value = Value
        Me.ZoneName = ZoneName
        Me.SensorId = SensorId
    End Sub
End Class
