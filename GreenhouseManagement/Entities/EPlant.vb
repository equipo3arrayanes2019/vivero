Public Class EPlant
    Private mId As String
    Private mDatePlanted As DateTime
    Private mSpecies As ESpecies
    Private mCount As Integer
    Public Property Id() As String
        Get
            Return mId
        End Get
        Set(ByVal value As String)
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

    Private mPrice As Double
    Public Property Price() As Double
        Get
            Return mPrice
        End Get
        Set(ByVal value As Double)
            mPrice = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Id As String, DatePlanted As DateTime, Species As ESpecies, Price As Double)

        Me.Id = Id
        Me.Species = Species
        Me.DatePlanted = DatePlanted
        Me.Price = Price

    End Sub
End Class
