Imports Entities
Imports MySql.Data.MySqlClient
Public Class PPerson
    Public Sub AddPerson(p As EPerson) 'Se declara el alta persona la cual nos ineterviene entre VB.net y MySQL.
        Dim query As String
        query = "INSERT INTO Empleado(ci, usuario, contraseña, nombre, telefono, direccion, fechaNacimiento, cargo) VALUES (" + p.CI.ToString() + ", '" + SqlHandle.Escape(p.User) + "', '" + SqlHandle.Escape(p.Password) + "', '" + SqlHandle.Escape(p.Name) + "', '" + SqlHandle.Escape(p.Phone) + "', '" + SqlHandle.Escape(p.Address) + "', '" + SqlHandle.GetMySqlDateFormat(p.BirthDate) + "', '" + p.Charge + "');"
        SqlHandle.StaticSendCommand(query)
    End Sub
    '---------------------------------------------------------------------------------------------
    Public Sub AddUser(unU As EPerson)
        Dim query As String
        query = "insert into Empleado values ('" & unU.User & "', '" & unU.Password & "');"
        SqlHandle.StaticSendCommand(query)
    End Sub
    '---------------------------------------------------------------------------------------------
    Public Sub RemovePerson(CI As String)
        Dim query As String
        query = "DELETE FROM Empleado WHERE cedula='" & CI & "';"
        SqlHandle.StaticSendCommand(query)
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

        query = "SELECT * FROM Empleado"
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
        Dim consulta1 = "UPDATE Empleado set cedula='" & unE.CI & "', usuario='" & unE.User & "', contraseña='" & unE.Password & "', nombre='" & unE.Name & "', direccion='" & unE.Address & "', telefono='" & unE.Phone & "', fechanac='" & unE.BirthDate & "', cargo='" & unE.Charge & "' WHERE cedula='" & unE.CI & "';"
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

