Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPPerson
    Inherits clsPersistencia
    Public Sub altaPersona(unP As clsPersona)
        Dim consulta1 As String
        consulta1 = "insert INTO registerpersona values ('" & unP.getcedula & "','" & unP.getnombre & "','" & unP.getapellido & "','" & unP.getdireccion & "','" & unP.gettelefono & "');"
        ejecutarSQL(consulta1)
    End Sub
    Private Function recrearPersona(fila As MySqlDataReader) As clsPersona
        Dim unEmp As New clsPersona
        unEmp.setcedula(fila.GetString("cedula"))
        unEmp.setnombre(fila.GetString("nombre"))
        unEmp.setapellido(fila.GetString("apellido"))
        unEmp.setdireccion(fila.GetString("direccion"))
        unEmp.settelefono(fila.GetString("telefono"))
        Return unEmp
    End Function
End Class

