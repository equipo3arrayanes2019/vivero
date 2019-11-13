Imports Entities
Public Class PPlantPot

    Public Sub Add(p As EPlantPot)
        Dim query As String = "INSERT INTO Producto(nombre) VALUES('" + SqlHandle.Escape(p.ProductName) + "');"
        Dim conn As New SqlHandle()
        conn.SendCommand(query)
        query = "SELECT LAST_INSERT_ID();"
        Dim result = conn.SendQuery(query)
        Dim id As Integer
        If result.Read() Then
            id = result.GetInt32(0)
        End If
        result.Close()
        query = "INSERT INTO Maceta(material, tamaño, Producto_id) VALUES('" + SqlHandle.Escape(p.Material) + "', '" + SqlHandle.Escape(p.Size) + "', " + id.ToString() + ");"
        conn.SendCommand(query)
        conn.Close()
    End Sub

    Public Sub Remove(p As EPlantPot)
        Dim querys As String() = {"DELETE FROM Maceta WHERE id = " + p.Id.ToString() + ";", "DELETE FROM Producto WHERE id = " + p.ProductId.ToString() + ";"}
        SqlHandle.StaticSendCommand(querys)
    End Sub

    Public Sub Update(p As EPlantPot)
        Dim querys As String() = {"UPDATE Producto SET nombre='" + SqlHandle.Escape(p.ProductName) + "' WHERE id = " + p.ProductId.ToString() + ";", "UPDATE Maceta SET material = '" + SqlHandle.Escape(p.Material) + "', tamaño = '" + SqlHandle.Escape(p.Size) + "' WHERE id = " + p.Id.ToString() + ";"}
        SqlHandle.StaticSendCommand(querys)
    End Sub

    Public Function ByMaterial(m As String) As List(Of EPlantPot)
        Dim query As String = "SELECT * FROM Maceta JOIN Producto ON Producto.id = Maceta.Producto_id WHERE material LIKE '%" + SqlHandle.Escape(m) + "%';"
        Dim conn As New SqlHandle()
        Dim result = conn.SendQuery(query)
        Dim out As New List(Of EPlantPot)
        While result.Read()
            out.Add(New EPlantPot(result.GetInt32("id"), result.GetString("material"), result.GetString("tamaño"), result.GetInt32("Producto_id"), result.GetString("nombre")))
        End While
        conn.Close()
        Return out
    End Function

End Class
