Public Class frmGraphic
    Private Sub frmGraphic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    '    Dim com As New clsPRegistro
    '    Dim colregistro As List(Of clsRegistro)
    '    colregistro = com.listar()

    '    For Each unr In colregistro
    '        Chart1.Series("valor").Points.AddXY(unr.idRegistro, unr.valor)
    '    Next
    'End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Timer1.Enabled = True
    End Sub
End Class