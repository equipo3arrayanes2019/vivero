Public Class clsemploye
    Private cedula As String
    Private nombre As String
    Private apellido As String
    Private direccion As String
    Private telefono As String
    Sub New()
        Me.cedula = ""
        Me.nombre = ""
        Me.apellido = ""
        Me.direccion = ""
        Me.telefono = ""
    End Sub
    Sub New(cedula As String, nombre As String, apellido As String, direccion As String, telefono As String)
        Me.cedula = cedula
        Me.nombre = nombre
        Me.apellido = apellido
        Me.direccion = direccion
        Me.telefono = telefono
    End Sub

    Function getcedula() As String
        Return Me.cedula
    End Function
    Function getnombre() As String
        Return Me.nombre
    End Function
    Function getapellido() As String
        Return Me.apellido
    End Function
    Function getdireccion() As String
        Return Me.direccion
    End Function
    Function gettelefono() As String
        Return Me.telefono
    End Function

    Sub setcedula(cedula As String)
        Me.cedula = cedula
    End Sub
    Sub setnombre(nombre As String)
        Me.nombre = nombre
    End Sub
    Sub setapellido(apellido As String)
        Me.apellido = apellido
    End Sub
    Sub setdireccion(direccion As String)
        Me.direccion = direccion
    End Sub
    Sub settelefono(telefono As String)
        Me.telefono = telefono
    End Sub
End Class
