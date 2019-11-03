Public Class frmError


    Public Sub New(ex As Exception)
        Me.New("", ex)
    End Sub
    Public Sub New(task As String, ex As Exception)
        InitializeComponent()
        lblTask.Text = task
        If task = "" Then
            lblUserText1.Visible = False
        End If
        txtError.Text = ex.Message
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(txtError.Text)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class