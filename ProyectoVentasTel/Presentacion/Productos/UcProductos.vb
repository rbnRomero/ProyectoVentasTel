Public Class UcProductos
    Private Sub UcProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.ConfigurarBarraAcciones(tlpRaiz, pnlEncabezado, lblTitulo, btnNuevoProducto, btnEditarProducto)
        UiTema.ConfigurarEtiqueta(lblBuscar, txtBuscarProducto, "Buscar")
        UiTema.ConfigurarEtiqueta(lblTipo, cboFiltroTipo, "Tipo")
        UiTema.ConfigurarEtiqueta(lblEstado, cboFiltroEstado, "Estado")
        picProducto.AccessibleName = "Imagen del producto seleccionado"
        picProducto.AccessibleDescription = "Vista previa; se anuncia sin imagen cuando no hay una disponible"
        UiTema.ConfigurarTabla(dgvProductos, "productos y existencias")
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub
End Class
