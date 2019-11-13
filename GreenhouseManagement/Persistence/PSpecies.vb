Imports Entities

Public Class PSpecies

    Public Function ByName(name As String) As List(Of ESpecies)
        Dim query As String = "SELECT * FROM Especie WHERE nombre LIKE '%" + SqlHandle.Escape(name) + "%'"
        Dim conn As New SqlHandle()
        Dim result = conn.SendQuery(query)
        Dim out = New List(Of ESpecies)
        While result.Read
            out.Add(New ESpecies(result.GetString("nombre"), result.GetString("tipo"), result.GetString("familia"), result.GetString("tipoZona"), result.GetInt32("tiempoCultivo"), result.GetString("faseLunar"), result.GetDouble("humedad")))
        End While
        conn.Close()
        Return out
    End Function

    Public Function ByType(type As String) As List(Of ESpecies)
        Dim query As String = "SELECT * FROM Especie WHERE tipo LIKE '%" + SqlHandle.Escape(type) + "%'"
        Dim conn As New SqlHandle()
        Dim result = conn.SendQuery(query)
        Dim out = New List(Of ESpecies)
        While result.Read
            out.Add(New ESpecies(result.GetString("nombre"), result.GetString("tipo"), result.GetString("familia"), result.GetString("tipoZona"), result.GetInt32("tiempoCultivo"), result.GetString("faseLunar"), result.GetDouble("humedad")))
        End While
        conn.Close()
        Return out
    End Function

    Public Sub Add(s As ESpecies)
        Dim query As String = "INSERT INTO Especie(nombre, tipo, familia, tipoZona, tiempoCultivo, faseLunar, humedad) VALUES('" + SqlHandle.Escape(s.Name) + "', '" + SqlHandle.Escape(s.Type) + "', '" + SqlHandle.Escape(s.Family) + "', '" + s.ZoneType + "', " + s.GrowTime.ToString() + ", '" + s.MoonPhase + "', " + s.Humidity.ToString().Replace(",", ".") + ");"
        SqlHandle.StaticSendCommand(query)
    End Sub

    Public Sub Remove(name As String)
        Dim query As String = "DELETE FROM Especie WHERE nombre = '" + SqlHandle.Escape(name) + "';"
        SqlHandle.StaticSendCommand(query)
    End Sub

    Public Sub Update(s As ESpecies)
        Dim query As String = "UPDATE Especie SET nombre = '" + SqlHandle.Escape(s.Name) + "', tipo = '" + SqlHandle.Escape(s.Type) + "', familia = '" + SqlHandle.Escape(s.Family) + "',  tipoZona = '" + s.ZoneType + "', tiempoCultivo = " + s.GrowTime.ToString() + ", faseLunar = '" + s.MoonPhase + "', humedad = " + s.Humidity.ToString().Replace(",", ".") + " WHERE nombre = '" + SqlHandle.Escape(s.Name) + "';"
        SqlHandle.StaticSendCommand(query)
    End Sub


End Class
