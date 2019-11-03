Imports Entities
Imports MySql.Data.MySqlClient
Public Class PPerson
    Public Sub AddPerson(unP As EPerson) 'Se declara el alta persona la cual nos ineterviene entre VB.net y MySQL.
        Dim consulta1 As String
        consulta1 = "insert INTO empleado values (" & unP.CI & ",'" & unP.User & "','" & unP.Password & "','" & unP.Name & "','" & unP.Address & "','" & unP.Phone & "','" & unP.BirthDate.ToString("yyyy-MM-dd") & "','" & unP.Charge & "');"
        SqlHandle.StaticSendCommand(consulta1)
    End Sub
    '---------------------------------------------------------------------------------------------
    Public Sub AddUser(unU As EPerson)
        Dim consulta1 As String
        consulta1 = "insert into empleado values ('" & unU.User & "', '" & unU.Password & "');"
        SqlHandle.StaticSendCommand(consulta1)
    End Sub
    '---------------------------------------------------------------------------------------------
    Public Sub RemovePerson(cedula As String)
        Dim consulta As String
        consulta = "DELETE FROM empleado WHERE cedula='" & cedula & "';"
        SqlHandle.StaticSendCommand(consulta)
    End Sub
    '---------------------------------------------------------------------------------------------
    Private Function CreatePerson(fila As MySqlDataReader) As EPerson
        Dim unEmp As New EPerson
        unEmp.CI = fila.GetInt32("ci")
        unEmp.User = fila.GetString("usuario")
        unEmp.Name = fila.GetString("nombre")
        unEmp.Address = fila.GetString("direccion")
        unEmp.Phone = fila.GetString("telefono")
        unEmp.Charge = fila.GetString("cargo")
        unEmp.BirthDate = fila.GetDateTime("fechaNacimiento")
        Return (unEmp)
    End Function
    '----------------------------------------------------------------------------------------------
    Public Function ListPerson() As List(Of EPerson)
        Dim query As String
        Dim returned As MySqlDataReader
        Dim lPerson As New List(Of EPerson)
        Dim conn As New SqlHandle

        query = "SELECT * FROM empleado"
        returned = conn.SendQuery(query)
        If returned.HasRows Then
            While (returned.Read)
                lPerson.Add(CreatePerson(returned))
            End While
        End If
        conn.Close()
        Return (lPerson)
    End Function
    Public Sub ModifyPerson(unE As EPerson)
        Dim consulta1 = "UPDATE empleado set cedula='" & unE.CI & "', usuario='" & unE.User & "', contraseña='" & unE.Password & "', nombre='" & unE.Name & "', direccion='" & unE.Address & "', telefono='" & unE.Phone & "', fechanac='" & unE.BirthDate & "', cargo='" & unE.Charge & "' WHERE cedula='" & unE.CI & "';"
        SqlHandle.StaticSendCommand(consulta1)
    End Sub

    Public Function Login(user As String, contra As String) As EPerson
        Dim sql As String
        Dim devolucion As MySqlDataReader
        Dim elUsuario As EPerson
        elUsuario = Nothing
        Dim conn As New SqlHandle()

        sql = "SELECT * FROM Empleado WHERE usuario='" & user & "' AND contraseña='" & contra & "';"
        devolucion = conn.SendQuery(sql)
        If devolucion.HasRows Then
            While devolucion.Read
                elUsuario = CreatePerson(devolucion)
            End While
        End If
        conn.Close()
        Return elUsuario
    End Function
    'Private Function CreateUser(fila As MySqlDataReader) As EPerson
    '    Dim unUsuario As New EPerson
    '    unUsuario.User = fila.GetString("usuario")
    '    'unUsuario.contra = fila.GetString("contraseña")
    '    Return unUsuario
    'End Function
End Class

