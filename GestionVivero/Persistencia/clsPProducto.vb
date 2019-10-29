
Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPProducto
    Inherits clsPersistencia
    Private Function RecrearProducto(fila As MySqlDataReader) As clsProducto 'Se genera un tipo listado en VB.Net para luego pedir los datos desde MySQL
        Dim unProducto As New clsProducto
        unProducto.id_Producto = fila.GetInt32("id")
        unProducto.Nombre_Producto = fila.GetString("nombre")
        Return (unProducto)
    End Function
    Public Function darProductoid(idP As String) As clsProducto
        Dim consulta As String
        Dim datos As MySqlDataReader
        Dim unProducto As New clsProducto
        consulta = "SELECT * FROM producto where id =( '" & idP & "' );"
        datos = ejecutarYdevolver(consulta)
        While datos.Read
            unProducto = RecrearProducto(datos)
        End While
        Return unProducto
    End Function
    Public Function listarProducto() As List(Of clsProducto)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaProducto As New List(Of clsProducto)
        consulta = "SELECT * FROM producto"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaProducto.Add(RecrearProducto(lo_que_devuelve))
            End While
        End If
        Return (listaProducto)
    End Function


End Class
