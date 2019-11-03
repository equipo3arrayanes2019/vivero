
Imports Entities
Imports MySql
Imports MySql.Data.MySqlClient
Public Class PProduct
    Private Function CreateProduct(fila As MySqlDataReader) As EProduct 'Se genera un tipo listado en VB.Net para luego pedir los datos desde MySQL
        Dim unProducto As New EProduct
        unProducto.ProductId = fila.GetInt32("id")
        unProducto.ProductName = fila.GetString("nombre")
        Return (unProducto)
    End Function

    Public Function ById(idP As String) As EProduct
        Dim consulta As String
        Dim datos As MySqlDataReader
        Dim unProducto As New EProduct
        Dim conn As New SqlHandle()

        consulta = "SELECT * FROM producto where id =( '" & idP & "' );"
        datos = conn.SendQuery(consulta)
        While datos.Read
            unProducto = CreateProduct(datos)
        End While
        conn.Close()
        Return unProducto
    End Function
    Public Function List() As List(Of EProduct)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaProducto As New List(Of EProduct)
        Dim conn As New SqlHandle()

        consulta = "SELECT * FROM producto"
        lo_que_devuelve = conn.SendQuery(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaProducto.Add(CreateProduct(lo_que_devuelve))
            End While
        End If
        conn.Close()
        Return (listaProducto)
    End Function


End Class
