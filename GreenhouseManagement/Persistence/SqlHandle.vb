Option Strict On

Imports MySql.Data.MySqlClient
Imports System.Configuration

'Namespace SqlHandleing
Friend NotInheritable Class SqlHandle

    'string connection to the server
    'Private connString As String = "server=172.16.0.1;user=programa;database=MeGusta;port=3306;password=123" ';SslMode=none"

    'the actual connection, only used when you instantiate the class
    Private conn As MySqlConnection

    'contructor
    Public Sub New()
        conn = New MySqlConnection(My.Settings.Item("connection_string").ToString()) 'My.Settings.Item("connection_string").ToString())
        conn.Open()
    End Sub

    Public Shared Function Escape(str As String) As String
            Return MySqlHelper.EscapeString(str)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="query">the query</param>
        ''' <returns>sends a query and returns the result as a MysqlDataReader</returns>
        Public Function SendQuery(query As String) As MySqlDataReader
            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteReader()
            Return result
        End Function

        ''' <summary>
        ''' closes the mysql connection
        ''' </summary>
        Public Sub Close()
            conn.Close()
            conn.Dispose()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="d">the date as the internal date format of vb.net</param>
        ''' <returns>receives a date and returns the mysql date format as string</returns>
        Public Shared Function GetMySqlDateFormat(d As DateTime) As String
            Return d.ToString("yyyy-MM-dd")
        End Function

        ''' <summary>
        ''' sends multiple querys and returns nothing, but it can be called without instantiating the class.
        ''' <para>It creates its own mysql connection and closes it after executing the query</para>
        ''' </summary>
        ''' <param name="query">the query</param>
        Public Shared Sub StaticSendCommand(query As String())
            Dim conn = New MySqlConnection(My.Settings.Item("connection_string").ToString())
            conn.Open()
            Dim cmd As MySqlCommand
            For Each item In query
                cmd = New MySqlCommand(item, conn)
                cmd.ExecuteNonQuery()
            Next
        End Sub

        ''' <summary>
        ''' Sends a query and returns nothing, but it can be called without instantiating the class.
        ''' <para>It creates its own mysql connection and closes it after executing the query</para>
        ''' </summary>
        ''' <param name="query">the query</param>
        Public Shared Sub StaticSendCommand(query As String)
            Dim conn = New MySqlConnection(My.Settings.Item("connection_string").ToString())
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        End Sub

        ''' <summary>
        ''' Sends multiple querys and returns nothing, but it can be called without instantiating the class.
        ''' <para>It creates its own mysql connection and closes it after executing the query</para>
        ''' </summary>
        ''' <param name="query">the query</param>
        Public Sub SendCommand(query As String())
            Dim cmd As MySqlCommand
            For Each item In query
                cmd = New MySqlCommand(item, conn)
                cmd.ExecuteNonQuery()
            Next
        End Sub

        ''' <summary>
        ''' sennds a query and returns nothing
        ''' </summary>
        ''' <param name="query">the query</param>
        Public Sub SendCommand(query As String)
            Dim cmd As New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
        End Sub

    End Class
'End Namespace