Public Class clsProducto
    Private mid_Producto As Integer
    Private mNombre_Producto As String
    Public Property id_Producto As Integer
        Get
            Return mid_Producto
        End Get
        Set(value As Integer)
            mid_Producto = value
        End Set
    End Property
    Public Property Nombre_Producto As String
        Get
            Return mNombre_Producto
        End Get
        Set(value As String)
            mNombre_Producto = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(id_Producto As Integer, Nombre_Producto As String)
        id_Producto = id_Producto
        Nombre_Producto = Nombre_Producto

    End Sub
End Class