
Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Public Class listPerson



    'Public Sub Probarconexion()
    '    Try
    '        MysqlConexion.Open()
    '        MsgBox("La conexión fue exitosa")
    '        MysqlConexion.Close()
    '    Catch ex As Exception
    '        MsgBox("La conexión no fue exitosa")
    '    End Try
    'End Sub

    Private Sub dgvPerson_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerson.CellContentClick

    End Sub

    Private Sub listPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MysqlCommand As New MySqlCommand
        Dim MysqlConnString As String = "server=localhost; uid=root ; password= ; database=viverobd;"
        Dim MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)
        Dim Grid1 As New DataGridView
    Dim lista As MySqlDataReader
    Dim datos As New DataTable
        ' Dim com As New MySqlCommand
        Dim xsql As String = "select * from registerpersona"
        'Dim conector As New MySqlConnection("server=localhost;Uid=root;password=Tierra616;database=tierra2;port=3306")
        Try
            MysqlConexion.Open()
            MysqlCommand.Connection = MysqlConexion
            MysqlCommand.CommandType = CommandType.Text
            MysqlCommand.CommandText = xsql
            lista = MysqlCommand.ExecuteReader
            datos.Load(lista)
            MsgBox("Felicidades Datos Encontrados")
            Grid1.DataSource = datos
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("Falla en la conexion")

    End Try
End Sub
End Class