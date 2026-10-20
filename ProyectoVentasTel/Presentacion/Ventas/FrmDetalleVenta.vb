Public Class FrmDetalleVenta
    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        ReubicarAccionVolver()
        UiTema.ConfigurarTabla(dgvArticulos, "artículos de la venta")
        btnCancelarVenta.AccessibleDescription = "Inicia la cancelación de esta venta"
        btnConfirmarCancelacion.AccessibleDescription = "Confirma la cancelación definitiva de la venta"
        btnDescartarCancelacion.AccessibleDescription = "Descarta la cancelación y conserva la venta"
        CancelButton = btnCerrar
    End Sub

    Private Sub ReubicarAccionVolver()
        Dim dpi As Integer = If(btnConfirmarCancelacion.DeviceDpi > 0, btnConfirmarCancelacion.DeviceDpi, 96)
        Dim separacion As Integer = CInt(Math.Ceiling(12.0F * dpi / 96.0F))
        btnDescartarCancelacion.Location = New Point(btnConfirmarCancelacion.Right + separacion, btnConfirmarCancelacion.Top)
    End Sub

    Private Sub dgvArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellContentClick

    End Sub
End Class
