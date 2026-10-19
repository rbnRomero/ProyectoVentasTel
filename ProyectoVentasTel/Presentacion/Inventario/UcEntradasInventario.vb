Public Class UcEntradasInventario
    Private Sub UcEntradasInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.OcultarEncabezadoDeModulo(tlpRaiz, pnlEncabezado, lblTitulo)
        UiTema.ConfigurarEtiqueta(lblProducto, cboProducto, "Producto")
        UiTema.ConfigurarEtiqueta(lblCantidad, nudCantidad, "Cantidad recibida")
        UiTema.ConfigurarEtiqueta(lblObservaciones, txtObservaciones, "Observaciones")
        UiTema.ConfigurarTabla(dgvEntradas, "historial de entradas de inventario")
    End Sub
End Class
