Public Class clsPersona
    Private mNombre As String
    Private mApellido As String
    Private mCedula As String
    Private mTelefono As String
    Private mDireccion As String
    Public Property nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
        End Set
    End Property
    Public Property apellido() As String

        Get
            Return mApellido
        End Get
        Set(ByVal value As String)
            mApellido = value
        End Set
    End Property
    Public Property cedula() As String
        Get
            Return mCedula

        End Get
        Set(ByVal value As String)
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

    Public Sub New()

    End Sub
    Public Sub New(nom As String, ape As String, ci As String, tel As String, dir As String)

        nombre = nom
        apellido = ape
        cedula = ci
        tele = tel
        direccion = dir

    End Sub


End Class
