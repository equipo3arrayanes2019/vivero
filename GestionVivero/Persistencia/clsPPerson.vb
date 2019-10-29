Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPPerson
    Inherits clsPersistencia
    Public Sub altaPersona(unP As clsPersona) 'Se declara el alta persona la cual nos ineterviene entre VB.net y MySQL.
        Dim consulta1 As String
        consulta1 = "insert INTO empleado values (" & unP.cedula & ",'" & unP.user & "','" & unP.contra & "','" & unP.nombre & "','" & unP.direccion & "','" & unP.tele & "','" & unP.fecha.ToString("yyyy-MM-dd") & "','" & unP.cargo & "');"
        ejecutarSQL(consulta1)
    End Sub
    '---------------------------------------------------------------------------------------------
    Public Sub altausuario(unU As clsPersona)
        Dim consulta1 As String
        consulta1 = "insert into empleado values ('" & unU.user & "', '" & unU.contra & "');"
        ejecutarSQL(consulta1)
    End Sub
    '---------------------------------------------------------------------------------------------
    Public Sub bajaPersona(cedula As String)
        Dim consulta As String
        consulta = "DELETE FROM empleado WHERE cedula='" & cedula & "';"
        ejecutarSQL(consulta)
    End Sub
    '---------------------------------------------------------------------------------------------
    Private Function recrearPersona(fila As MySqlDataReader) As clsPersona
        Dim unEmp As New clsPersona
        unEmp.cedula = fila.GetInt32("cedula")
        unEmp.user = fila.GetString("usuario")
        unEmp.nombre = fila.GetString("nombre")
        unEmp.direccion = fila.GetString("direccion")
        unEmp.tele = fila.GetString("telefono")
        unEmp.cargo = fila.GetString("cargo")
        unEmp.fecha = fila.GetDateTime("fechanac")
        Return (unEmp)
    End Function
    '----------------------------------------------------------------------------------------------
    Public Function listarPer() As List(Of clsPersona)
        Dim consulta As String
        Dim lo_que_devuelve As MySqlDataReader
        Dim listaPersona As New List(Of clsPersona)

        consulta = "SELECT * FROM empleado"
        lo_que_devuelve = ejecutarYdevolver(consulta)
        If lo_que_devuelve.HasRows Then
            While (lo_que_devuelve.Read)
                listaPersona.Add(recrearPersona(lo_que_devuelve))
            End While
        End If
        Return (listaPersona)
    End Function
    Public Sub modificarPersona(unE As clsPersona)
        Dim consulta1 = "UPDATE empleado set cedula='" & unE.cedula & "', usuario='" & unE.user & "', contraseña='" & unE.contra & "', nombre='" & unE.nombre & "', direccion='" & unE.direccion & "', telefono='" & unE.tele & "', fechanac='" & unE.fecha & "', cargo='" & unE.cargo & "' WHERE cedula='" & unE.cedula & "';"
        ejecutarSQL(consulta1)
    End Sub
End Class

