Public Class EPlant
    Private mId As String
    Private mDatePlanted As String
    Private mSpecies As String
    Private mCount As Integer
    Public Property Id() As String
        Get
            Return mId
        End Get
        Set(ByVal value As String)
            [mId] = value
        End Set
    End Property
    Public Property DatePlanted() As String

        Get
            Return mDatePlanted
        End Get
        Set(ByVal value As String)
            mDatePlanted = value
        End Set
    End Property
    Public Property Species() As String
        Get
            Return mSpecies

        End Get
        Set(ByVal value As String)
            mSpecies = value
        End Set
    End Property

    Public Property Count As Integer
        Get
            Return mCount
        End Get
        Set(value As Integer)
            mCount = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Id As String, DatePlanted As String, Species As String, Count As Integer)

        Me.Id = Id
        Me.Species = Species
        Me.DatePlanted = DatePlanted
        Me.Count = Count

    End Sub
End Class
