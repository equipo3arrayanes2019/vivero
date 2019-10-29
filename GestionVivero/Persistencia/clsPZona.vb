Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPZona
    Inherits clsPersistencia
    Public Sub altaZona(unP As clsZona) 'Se declara el alta persona la cual nos ineterviene entre VB.net y MySQL.
        Dim consulta1 As String
        consulta1 = "insert INTO zona values (" & unP.Zona_nombre & ",'" & unP.tamaño & "','" & unP.tipo & "');"
        ejecutarSQL(consulta1)
    End Sub
    Private Function RecrearZona(fila As MySqlDataReader) As clsZona
        Dim unZona As New clsZona
        unZona.Zona_nombre = fila.GetString("nombre")
        unZona.tamaño = fila.GetString("tamaño")
        unZona.tipo = fila.GetString("tipo")
        Return (unZona)
    End Function
    Public Function darZona(idZ As String) As clsZona
        Dim consulta As String
        Dim datos As MySqlDataReader
        Dim unZona As New clsZona
        consulta = "SELECT * FROM zona where nombre =( '" & idZ & "' );"
        datos = ejecutarYdevolver(consulta)
        While datos.Read
            unZona = RecrearZona(datos)
        End While
        Return unZona
    End Function
    Public Function listarZona() As List(Of clsZona)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaZona As New List(Of clsZona)
        consulta = "SELECT * FROM zona"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaZona.Add(RecrearZona(lo_que_devuelve))
            End While
        End If
        Return (listaZona)
    End Function

End Class
