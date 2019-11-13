Public Class ESpecies
    Private mName As String
    Private mType As String
    Private mFamily As String
    Private mZoneType As String
    Private mGrowTime As Integer
    Private mMoonType As String
    Private mHumidity As Double
    Public Property Name As String
        Get
            Return mName
        End Get
        Set(value As String)
            mName = value
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
    Public Property Family As String
        Get
            Return mFamily
        End Get
        Set(value As String)
            mFamily = value
        End Set
    End Property
    Public Property ZoneType As String
        Get
            Return mZoneType
        End Get
        Set(value As String)
            mZoneType = value
        End Set
    End Property
    Public Property GrowTime As Integer
        Get
            Return mGrowTime
        End Get
        Set(value As Integer)
            mGrowTime = value
        End Set
    End Property
    Public Property MoonPhase As String
        Get
            Return mMoonType
        End Get
        Set(value As String)
            mMoonType = value
        End Set
    End Property
    Public Property Humidity As Double
        Get
            Return mHumidity
        End Get
        Set(value As Double)
            mHumidity = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(Name As String, Type As String, Family As String, ZoneType As String, GrowTime As Integer, MoonType As String, Humidity As Double)
        Me.Name = Name
        Me.Type = Type
        Me.Family = Family
        Me.ZoneType = ZoneType
        Me.GrowTime = GrowTime
        Me.MoonPhase = MoonType
        Me.Humidity = Humidity
    End Sub
End Class
