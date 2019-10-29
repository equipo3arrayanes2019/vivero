Imports Entidades
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class clsPPlant
    Inherits clsPersistencia
    Public Sub altaPlanta(unPP As clsPlanta)
        Dim consulta1 As String
        consulta1 = "insert INTO planta values ('" & unPP.id & "','" & unPP.fecha & "','" & unPP.cantidad & "','" & unPP.especie & "');"
        ejecutarSQL(consulta1)
    End Sub

    Public Sub bajaPlanta(id As String)
        Dim consulta As String
        consulta = "DELETE FROM planta WHERE id='" & id & "';"
        ejecutarSQL(consulta)
    End Sub
    Private Function recrearPersona(fila As MySqlDataReader) As clsPlanta
        Dim unPla As New clsPlanta
        unPla.id = fila.GetString("id")
        unPla.fecha = fila.GetString("fecha")
        unPla.cantidad = fila.GetInt32("cantidad")
        unPla.especie = fila.GetString("especie")
        Return (unPla)
    End Function

    Public Function listar() As List(Of clsPlanta)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaPlanta As New List(Of clsPlanta)

        consulta = "SELECT * FROM planta"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaPlanta.Add(recrearPersona(lo_que_devuelve))
            End While
        End If
        Return (listaPlanta)
    End Function
End Class
