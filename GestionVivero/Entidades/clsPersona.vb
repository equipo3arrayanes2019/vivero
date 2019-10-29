Public Class clsPersona
    Private mNombre As String
    Private mCedula As Integer
    Private mTelefono As String
    Private mDireccion As String
    Private mCargo As String
    Private mUser As String
    Private mContra As String
    Private mFecha As DateTime

    Public Property nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
        End Set
    End Property
    Public Property cedula() As Integer
        Get
            Return mCedula

        End Get
        Set(ByVal value As Integer)
            mCedula = value
        End Set
    End Property
    Public Property tele() As String
        Get
            Return mTelefono
        End Get
        Set(ByVal value As String)
            mTelefono = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return mDireccion
        End Get
        Set(ByVal value As String)
            mDireccion = value
        End Set
    End Property

    Public Property cargo As String
        Get
            Return mCargo
        End Get
        Set(value As String)
            mCargo = value
        End Set
    End Property

    Public Property user As String
        Get
            Return mUser
        End Get
        Set(value As String)
            mUser = value
        End Set
    End Property
    Public Property contra As String
        Get
            Return mContra
        End Get
        Set(value As String)
            mContra = value
        End Set
    End Property
    Public Property fecha As DateTime
        Get
            Return mFecha
        End Get
        Set(value As DateTime)
            mFecha = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(nom As String, ci As Integer, tel As String, dir As String, user As String, contra As String, cargo As String, fecha As DateTime)

        nombre = nom
        cedula = ci
        tele = tel
        direccion = dir
        contra = contra
        user = user
        cargo = cargo
        fecha = fecha
    End Sub


End Class
