Imports Entidades
Imports MySql
Imports MySql.Data.MySqlClient
Public Class clsPEmploye
    Inherits clsPersistencia
    Public Sub altaEmpleado(unP As clsemploye)
        Dim consulta1 As String
        consulta1 = "insert INTO registerpersona values ('" & unP.getcedula & "','" & unP.getnombre & "','" & unP.getapellido & "','" & unP.getdireccion & "','" & unP.gettelefono & "');"
        ejecutarSQL(consulta1)
    End Sub
    Private Function recrearEmpleados(fila As MySqlDataReader) As clsemploye
        Dim unEmp As New clsemploye
        unEmp.setcedula(fila.GetString("cedula"))
        unEmp.setnombre(fila.GetString("nombre"))
        unEmp.setapellido(fila.GetString("apellido"))
        unEmp.setdireccion(fila.GetString("direccion"))
        unEmp.settelefono(fila.GetString("telefono"))
        Return unEmp
    End Function
End Class
