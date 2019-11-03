

Public Class CommonError

    Public Shared Sub ShowError(e As Exception)
        Dim f As New frmError(e)
        f.ShowDialog()
        f.Close()
        f.Dispose()
    End Sub

    Public Shared Sub ErrorSaving(e As Exception)
        Dim f As New frmError("Guardar informacion", e)
        f.ShowDialog()
        f.Close()
        f.Dispose()
    End Sub

    Public Shared Sub ErrorGetting(e As Exception)
        Dim f As New frmError("Obtener informacion", e)
        f.ShowDialog()
        f.Close()
        f.Dispose()
    End Sub

    Public Shared Sub ErrorUpdating(e As Exception)
        Dim f As New frmError("Actualizar informacion", e)
        f.ShowDialog()
        f.Close()
        f.Dispose()
    End Sub

End Class
