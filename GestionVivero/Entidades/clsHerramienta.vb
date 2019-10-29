Public Class clsHerramienta
    Inherits clsProducto
        Private mtipo_Herramienta As String
    Private mZona_nombre As clsZona
    Private mUso As String

    Public Property tipo_Herramienta As String
        Get
            Return mtipo_Herramienta
        End Get
        Set(value As String)
            mtipo_Herramienta = value
        End Set
    End Property
    Public Property Zona_nombre As clsZona
        Get
            Return mZona_nombre
        End Get
        Set(value As clsZona)
            mZona_nombre = value
        End Set
    End Property
    Public Property uso As String
        Get ''es to hace una wea
            Return mUso
        End Get
        Set(value As String)
            mUso = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(tipo_Herramienta As String, id_Producto As clsProducto, Zona_nombre As clsZona, uso As String)
        uso = uso
        tipo_Herramienta = tipo_Herramienta
        id_Producto = id_Producto
        Zona_nombre = Zona_nombre
    End Sub
End Class
