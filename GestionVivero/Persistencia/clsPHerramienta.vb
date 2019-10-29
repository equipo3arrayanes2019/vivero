Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class clsPHerramienta
    Inherits clsPersistencia
    Public Sub altaHerramienta(unPP As clsHerramienta)
        Dim consulta1, consulta2, consulta3 As String
        Dim ultimoId As Integer
        consulta1 = "insert INTO producto values ('" & unPP.id_Producto & "','" & unPP.Nombre_Producto & "' );" 'manda lo valores hacía la tabla producto
        ejecutarSQL(consulta1)
        consulta3 = "SELECT id from producto order by id DESC limit 1;" 'Toma el ultimo valor de la tabla 
        Dim dato = ejecutarYdevolver(consulta3)
        If dato.Read Then
            ultimoId = dato.GetInt32("id")
        End If

        consulta2 = "insert INTO herramienta values ('" & ultimoId & "','" & unPP.tipo_Herramienta & "', '" & unPP.uso & "' );"
        ejecutarSQL(consulta2)
    End Sub

    Public Sub bajaHerramienta(id As String)
        Dim consulta As String
        consulta = "DELETE FROM herramienta WHERE id='" & id & "';"
        ejecutarSQL(consulta)
    End Sub
    Private Function RecrearHerramienta(fila As MySqlDataReader) As clsHerramienta 'Se genera un tipo listado en VB.Net para luego pedir los datos desde MySQL
        Dim unHerramienta As New clsHerramienta
        Dim unPZona As New clsPZona
        Dim unPPro As New clsPProducto
        unHerramienta.uso = fila.GetString("uso")
        unHerramienta.tipo_Herramienta = fila.GetString("tipo")
        unHerramienta.Zona_nombre = unPZona.darZona(fila.GetString("Zona_nombre"))
        Return (unHerramienta)
    End Function

    Public Function listarHerramineta() As List(Of clsHerramienta)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaHerramienta As New List(Of clsHerramienta)
        consulta = "SELECT * FROM herramienta"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaHerramienta.Add(RecrearHerramienta(lo_que_devuelve))
            End While
        End If
        Return (listaHerramienta)
    End Function
End Class
