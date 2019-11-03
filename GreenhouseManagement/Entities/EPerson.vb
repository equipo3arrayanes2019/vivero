Public Class EPerson
    Private mName As String
    Private mCI As Integer
    Private mPhone As String
    Private mAddress As String
    Private mCharge As String
    Private mUser As String
    Private mPassword As String
    Private mBirthDate As DateTime

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property
    Public Property CI() As Integer
        Get
            Return mCI

        End Get
        Set(ByVal value As Integer)
            mCI = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return mPhone
        End Get
        Set(ByVal value As String)
            mPhone = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return mAddress
        End Get
        Set(ByVal value As String)
            mAddress = value
        End Set
    End Property

    Public Property Charge As String
        Get
            Return mCharge
        End Get
        Set(value As String)
            mCharge = value
        End Set
    End Property

    Public Property User As String
        Get
            Return mUser
        End Get
        Set(value As String)
            mUser = value
        End Set
    End Property
    Public Property Password As String
        Get
            Return mPassword
        End Get
        Set(value As String)
            mPassword = value
        End Set
    End Property
    Public Property BirthDate As DateTime
        Get
            Return mBirthDate
        End Get
        Set(value As DateTime)
            mBirthDate = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(name As String, ci As Integer, phone As String, address As String, user As String, password As String, charge As String, brithdate As DateTime)

        Me.Name = name
        Me.CI = ci
        Me.Phone = phone
        Me.Address = address
        Me.Password = password
        Me.User = user
        Me.Charge = charge
        Me.BirthDate = brithdate
    End Sub


End Class
