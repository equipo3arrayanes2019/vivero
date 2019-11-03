Public Class frmAskZoneType
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private mSelected As String
    Public Property Selected() As String
        Get
            Return mSelected
        End Get
        Private Set(ByVal value As String)
            mSelected = value
        End Set
    End Property

    Private Sub CbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged
        Selected = cbxType.Items.Item(cbxType.SelectedIndex).ToString()
    End Sub

    Private Sub FrmAskZoneType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxType.SelectedIndex = 0
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class