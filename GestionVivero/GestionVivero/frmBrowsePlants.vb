Public Class frmBrowsePlants
    Private Sub ChkSpecies_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecies.CheckedChanged
        cbxSpecies.Enabled = chkSpecies.Checked
    End Sub
End Class