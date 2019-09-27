Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPPerson
    Inherits clsPersistencia
    Public Sub altaPersona(unP As clsPersona)
        Dim consulta1 As String
        consulta1 = "insert INTO registerpersona values ('" & unP.cedula & "','" & unP.nombre & "','" & unP.apellido & "','" & unP.direccion & "','" & unP.tele & "');"
        ejecutarSQL(consulta1)
    End Sub

    Public Sub bajaPersona(cedula As String)
        Dim consulta As String
        consulta = "DELETE FROM registerpersona WHERE cedula='" & cedula & "'"
        ejecutarSQL(consulta)
    End Sub
    Private Function recrearPersona(fila As MySqlDataReader) As clsPersona
        Dim unEmp As New clsPersona
        unEmp.cedula = fila.GetString("cedula")
        unEmp.nombre = fila.GetString("nombre")
        unEmp.apellido = fila.GetString("apellido")
        unEmp.direccion = fila.GetString("direccion")
        unEmp.tele = fila.GetString("telefono")
        Return (unEmp)
    End Function

    Public Function listar() As List(Of clsPersona)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaPersona As New List(Of clsPersona)

        consulta = "SELECT * FROM registerpersona"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaPersona.Add(recrearPersona(lo_que_devuelve))
            End While
        End If
        Return (listaPersona)
    End Function

End Class

