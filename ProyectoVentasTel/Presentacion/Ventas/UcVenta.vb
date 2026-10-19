Public Class UcVenta
    Private Sub UcVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.OcultarEncabezadoDeModulo(tlpRaiz, pnlEncabezado, lblTitulo)
        pnlEncabezado.Controls.Remove(lblFolioPendiente)
        pnlCatalogo.Controls.Add(lblFolioPendiente)
        lblFolioPendiente.Location = New Point(pnlCatalogo.ClientSize.Width - 280, 6)
        lblFolioPendiente.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFolioPendiente.AccessibleName = "Folio de la venta pendiente"
        UiTema.ConfigurarEtiqueta(lblBuscarProducto, txtBuscarProducto, "Buscar producto")
        UiTema.ConfigurarEtiqueta(lblCantidad, nudCantidad, "Cantidad")
        UiTema.ConfigurarEtiqueta(lblEfectivo, nudEfectivoRecibido, "Efectivo recibido")
        UiTema.ConfigurarMensaje(lblMensajeVenta, "Estado de la venta")
        txtBuscarProducto.Focus()
        UiTema.ConfigurarTabla(dgvProductosVenta, "catálogo de productos")
        UiTema.ConfigurarTabla(dgvDetalleVenta, "productos de la venta")
    End Sub
End Class
