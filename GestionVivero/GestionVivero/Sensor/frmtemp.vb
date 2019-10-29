Public Class frmtemp
    Private Sub frmtemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim com As New clsPRegistro
        'Dim registro As clsRegistro
        'registro = com.darultimo()
        ''dgvSensors.DataSource = colregistro

        'labeltxt.Text = (registro.valor)
    End Sub

    Private Sub btnRefress_Click(sender As Object, e As EventArgs) Handles btnRefress.Click

        Timer1.Enabled = True

    End Sub
End Class