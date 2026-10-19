Public Class FrmDetalleVenta
    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.ConfigurarTabla(dgvArticulos, "artículos de la venta")
        btnCancelarVenta.AccessibleDescription = "Inicia la cancelación de esta venta"
        btnConfirmarCancelacion.AccessibleDescription = "Confirma la cancelación definitiva de la venta"
        btnDescartarCancelacion.AccessibleDescription = "Descarta la cancelación y conserva la venta"
        CancelButton = btnCerrar
    End Sub

    Private Sub dgvArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellContentClick

    End Sub
End Class
