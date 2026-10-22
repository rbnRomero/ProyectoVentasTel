Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Ventas

Public Class UcVenta
    Private ReadOnly servicio As New ServicioVentas()
    Private ReadOnly productos As New Dictionary(Of Integer, ProductoParaVenta)()
    Private ReadOnly carrito As New List(Of ArticuloVenta)()

    Private Sub UcVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        AjustarColumnaAccionQuitarProducto()
        UiTema.OcultarEncabezadoDeModulo(tlpRaiz, pnlEncabezado, lblTitulo)
        pnlEncabezado.Controls.Remove(lblFolioPendiente)
        pnlCatalogo.Controls.Add(lblFolioPendiente)
        lblFolioPendiente.Location = New Point(pnlCatalogo.ClientSize.Width - 280, 6)
        lblFolioPendiente.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        UiTema.ConfigurarEtiqueta(lblBuscarProducto, txtBuscarProducto, "Buscar producto")
        UiTema.ConfigurarEtiqueta(lblCantidad, nudCantidad, "Cantidad")
        UiTema.ConfigurarEtiqueta(lblEfectivo, nudEfectivoRecibido, "Efectivo recibido")
        UiTema.ConfigurarMensaje(lblMensajeVenta, "Estado de la venta")
        UiTema.ConfigurarTabla(dgvProductosVenta, "catálogo de productos")
        UiTema.ConfigurarTabla(dgvDetalleVenta, "productos de la venta")
        dgvProductosVenta.AutoGenerateColumns = False
        dgvProductosVenta.ReadOnly = True
        dgvProductosVenta.AllowUserToAddRows = False
        dgvProductosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetalleVenta.AutoGenerateColumns = False
        dgvDetalleVenta.ReadOnly = True
        dgvDetalleVenta.AllowUserToAddRows = False
        dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        colCatalogoIdProducto.Visible = False
        colDetalleIdProducto.Visible = False
        colCatalogoPrecio.DefaultCellStyle.Format = "C2"
        colDetallePrecioUnitario.DefaultCellStyle.Format = "C2"
        colDetalleSubtotal.DefaultCellStyle.Format = "C2"
        nudCantidad.Minimum = 1
        nudCantidad.Maximum = 999999
        nudEfectivoRecibido.Minimum = 0
        nudEfectivoRecibido.Maximum = 9999999999.99D
        nudEfectivoRecibido.DecimalPlaces = 2
        nudEfectivoRecibido.ThousandsSeparator = True
        CargarCatalogo()
        ActualizarCarrito()
    End Sub

    Private Sub AjustarColumnaAccionQuitarProducto()
        If tlpRaiz.ColumnStyles.Count < 2 Then Return
        Dim columnaAccion As ColumnStyle = tlpRaiz.ColumnStyles(1)
        Dim anchoRequerido As Integer = Math.Max(btnQuitarProducto.Width, btnQuitarProducto.MinimumSize.Width) + btnQuitarProducto.Margin.Horizontal
        columnaAccion.SizeType = SizeType.Absolute
        columnaAccion.Width = Math.Max(columnaAccion.Width, anchoRequerido)
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        CargarCatalogo()
    End Sub

    Private Sub CargarCatalogo()
        productos.Clear()
        dgvProductosVenta.Rows.Clear()
        Try
            For Each producto In servicio.BuscarProductos(txtBuscarProducto.Text)
                productos(producto.IdProducto) = producto
                dgvProductosVenta.Rows.Add(producto.IdProducto, producto.Codigo, producto.Nombre, producto.Precio, producto.Existencias)
            Next
        Catch ex As Exception
            lblMensajeVenta.Text = "No se pudo cargar el catálogo. Comprueba la conexión e intenta nuevamente."
        End Try
    End Sub

    Public Sub ActualizarDatos()
        CargarCatalogo()
        ActualizarCarrito()
    End Sub

    Private Function ProductoSeleccionado() As ProductoParaVenta
        If dgvProductosVenta.CurrentRow Is Nothing Then Return Nothing
        Dim id As Integer
        If Not Integer.TryParse(Convert.ToString(dgvProductosVenta.CurrentRow.Cells(colCatalogoIdProducto.Index).Value), id) Then Return Nothing
        Dim producto As ProductoParaVenta = Nothing
        productos.TryGetValue(id, producto)
        Return producto
    End Function

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim producto = ProductoSeleccionado()
        If producto Is Nothing Then
            lblMensajeVenta.Text = "Selecciona un producto disponible."
            Return
        End If
        Dim cantidad = CInt(nudCantidad.Value)
        Dim articulo = carrito.FirstOrDefault(Function(x) x.IdProducto = producto.IdProducto)
        If (If(articulo Is Nothing, 0, articulo.Cantidad) + cantidad) > producto.Existencias Then
            lblMensajeVenta.Text = "La cantidad solicitada supera las existencias disponibles."
            Return
        End If
        If articulo Is Nothing Then
            carrito.Add(New ArticuloVenta With {.IdProducto = producto.IdProducto, .Codigo = producto.Codigo, .Nombre = producto.Nombre, .Cantidad = cantidad, .PrecioUnitario = producto.Precio})
        Else
            articulo.Cantidad += cantidad
        End If
        lblMensajeVenta.Text = String.Empty
        ActualizarCarrito()
    End Sub

    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        If dgvDetalleVenta.CurrentRow Is Nothing Then Return
        Dim id As Integer
        If Integer.TryParse(Convert.ToString(dgvDetalleVenta.CurrentRow.Cells(colDetalleIdProducto.Index).Value), id) Then carrito.RemoveAll(Function(x) x.IdProducto = id)
        ActualizarCarrito()
    End Sub

    Private Sub ActualizarCarrito()
        dgvDetalleVenta.Rows.Clear()
        For Each articulo In carrito
            dgvDetalleVenta.Rows.Add(articulo.IdProducto, articulo.Codigo, articulo.Nombre, articulo.Cantidad, articulo.PrecioUnitario, articulo.Subtotal)
        Next
        Dim total = carrito.Sum(Function(x) x.Subtotal)
        lblTotalValor.Text = total.ToString("C2")
        lblCambioValor.Text = Math.Max(0D, nudEfectivoRecibido.Value - total).ToString("C2")
        btnConfirmarVenta.Enabled = carrito.Count > 0
        btnQuitarProducto.Enabled = dgvDetalleVenta.Rows.Count > 0
    End Sub

    Private Sub nudEfectivoRecibido_ValueChanged(sender As Object, e As EventArgs) Handles nudEfectivoRecibido.ValueChanged
        ActualizarCarrito()
    End Sub

    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        If carrito.Count = 0 Then
            lblMensajeVenta.Text = "Agrega al menos un producto a la venta."
            Return
        End If
        Dim total = carrito.Sum(Function(x) x.Subtotal)
        If nudEfectivoRecibido.Value < total Then
            erpVenta.SetError(nudEfectivoRecibido, "El efectivo debe cubrir el total.")
            lblMensajeVenta.Text = "El efectivo recibido es insuficiente."
            Return
        End If
        erpVenta.SetError(nudEfectivoRecibido, String.Empty)
        Try
            Dim folio = servicio.Registrar(carrito.ToArray(), nudEfectivoRecibido.Value)
            lblFolioPendiente.Text = "Folio: " & folio
            lblMensajeVenta.Text = "Venta confirmada. Cambio: " & (nudEfectivoRecibido.Value - total).ToString("C2")
            carrito.Clear()
            nudEfectivoRecibido.Value = 0D
            ActualizarCarrito()
            CargarCatalogo()
        Catch ex As ExistenciasInsuficientesException
            lblMensajeVenta.Text = ex.Message
            CargarCatalogo()
        Catch ex As ArgumentException
            lblMensajeVenta.Text = ex.Message
        Catch ex As InvalidOperationException
            lblMensajeVenta.Text = ex.Message
            CargarCatalogo()
        Catch ex As Exception
            lblMensajeVenta.Text = "No se pudo registrar la venta. Comprueba la conexión e intenta nuevamente."
            CargarCatalogo()
        End Try
    End Sub
End Class
