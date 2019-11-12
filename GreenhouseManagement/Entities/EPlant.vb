Public Class EPlant
    Private mPrice As Double
    Private mId As Integer
    Private mDatePlanted As DateTime
    Private mSpecies As ESpecies
    Private mPlantPot As EPlantPot
    Private mZone As EZone
    Private mCount As Integer
    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            [mId] = value
        End Set
    End Property
    Public Property DatePlanted() As DateTime

        Get
            Return mDatePlanted
        End Get
        Set(ByVal value As DateTime)
            mDatePlanted = value
        End Set
    End Property
    Public Property Species() As ESpecies
        Get
            Return mSpecies

        End Get
        Set(ByVal value As ESpecies)
            mSpecies = value
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return mPrice
        End Get
        Set(ByVal value As Double)
            mPrice = value
        End Set
    End Property

    Public Property PlantPot() As EPlantPot
        Get
            Return mPlantPot

        End Get
        Set(value As EPlantPot)
            mPlantPot = value
        End Set
    End Property


    Public Property Zone() As EZone
        Get
            Return mZone
        End Get
        Set(value As EZone)
            mZone = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(Id As Integer, DatePlanted As DateTime, Species As ESpecies, PlantPot As EPlantPot, Zone As EZone, Price As Double)

        Me.Id = Id
        Me.Species = Species
        Me.DatePlanted = DatePlanted
        Me.Price = Price
        Me.PlantPot = PlantPot
        Me.Zone = Zone
    End Sub
End Class
