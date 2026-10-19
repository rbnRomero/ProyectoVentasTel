Public Class FrmProducto
    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        AcceptButton = btnGuardar
        CancelButton = btnCancelar
        txtCodigo.Focus()
    End Sub
End Class
