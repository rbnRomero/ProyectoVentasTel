Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Productos
Imports ProyectoVentasTel.Infraestructura.Imagenes

Public Class UcProductos
    Private ReadOnly servicio As New ServicioProductos()
    Private ReadOnly productosPorId As New Dictionary(Of Integer, Producto)()
    Private filtrosListos As Boolean

    Private Sub UcProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.ConfigurarBarraAcciones(tlpRaiz, pnlEncabezado, lblTitulo, btnNuevoProducto, btnEditarProducto)
        UiTema.ConfigurarEtiqueta(lblBuscar, txtBuscarProducto, "Buscar")
        UiTema.ConfigurarEtiqueta(lblTipo, cboFiltroTipo, "Tipo")
        UiTema.ConfigurarEtiqueta(lblEstado, cboFiltroEstado, "Estado")
        picProducto.AccessibleName = "Imagen del producto seleccionado"
        UiTema.ConfigurarTabla(dgvProductos, "productos y existencias")
        dgvProductos.AutoGenerateColumns = False
        dgvProductos.ReadOnly = True
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.MultiSelect = False
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        colPrecio.DefaultCellStyle.Format = "N2"
        txtBuscarProducto.MaxLength = 100
        cboFiltroTipo.DropDownStyle = ComboBoxStyle.DropDownList
        cboFiltroEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cboFiltroTipo.SelectedIndex = 0
        cboFiltroEstado.SelectedIndex = 0
        picProducto.SizeMode = PictureBoxSizeMode.Zoom
        lblSinProductos.BackColor = dgvProductos.BackgroundColor
        AddHandler pnlTabla.SizeChanged, Sub() CentrarMensajeListado()
        CentrarMensajeListado()
        btnNuevoProducto.Visible = ServicioProductos.PuedeAdministrar()
        btnEditarProducto.Visible = ServicioProductos.PuedeAdministrar()
        AddHandler Disposed, Sub() LiberarImagen()
        filtrosListos = True
        CargarProductos()
    End Sub

    Private Sub FiltrosCambiados(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged, cboFiltroTipo.SelectedIndexChanged, cboFiltroEstado.SelectedIndexChanged
        If filtrosListos Then CargarProductos()
    End Sub

    Private Sub CargarProductos()
        dgvProductos.Rows.Clear()
        productosPorId.Clear()
        Try
            Dim filtro As New FiltroProductos With {
                .Texto = txtBuscarProducto.Text,
                .Tipo = If(cboFiltroTipo.SelectedIndex = 0, CType(Nothing, TipoProducto?), If(cboFiltroTipo.SelectedIndex = 1, TipoProducto.Telefono, TipoProducto.Accesorio)),
                .Activo = If(cboFiltroEstado.SelectedIndex = 0, CType(Nothing, Boolean?), cboFiltroEstado.SelectedIndex = 1)}
            For Each producto In servicio.ConsultarProductos(filtro)
                productosPorId(producto.IdProducto) = producto
                dgvProductos.Rows.Add(producto.IdProducto, producto.Codigo, producto.Nombre,
                    If(producto.Tipo = TipoProducto.Telefono, "Teléfono", "Accesorio"),
                    producto.Marca, producto.Modelo, producto.PrecioVenta, producto.Existencias,
                    If(producto.Activo, "Activo", "Inactivo"))
            Next
            lblSinProductos.Text = "No hay productos para mostrar"
        Catch ex As Exception
            dgvProductos.Rows.Clear()
            productosPorId.Clear()
            lblSinProductos.Text = "No se pudieron cargar los productos. Comprueba la conexión e intenta nuevamente."
        Finally
            lblSinProductos.Visible = dgvProductos.Rows.Count = 0
            If lblSinProductos.Visible Then lblSinProductos.BringToFront()
            ActualizarSeleccion()
        End Try
    End Sub

    Private Sub CentrarMensajeListado()
        lblSinProductos.SetBounds(20, Math.Max(60, (pnlTabla.ClientSize.Height - 80) \ 2), Math.Max(1, pnlTabla.ClientSize.Width - 40), 80)
    End Sub

    Private Function Seleccionado() As Producto
        Dim fila = dgvProductos.CurrentRow
        If fila Is Nothing OrElse fila.IsNewRow Then Return Nothing
        Dim producto As Producto = Nothing
        Dim id As Integer
        If Integer.TryParse(Convert.ToString(fila.Cells(colIdProducto.Index).Value), id) Then productosPorId.TryGetValue(id, producto)
        Return producto
    End Function

    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        ActualizarSeleccion()
    End Sub

    Private Sub ActualizarSeleccion()
        Dim producto = Seleccionado()
        btnEditarProducto.Enabled = ServicioProductos.PuedeAdministrar() AndAlso producto IsNot Nothing
        LiberarImagen()
        picProducto.Image = AlmacenImagenesProductos.IntentarCargar(producto?.RutaImagen)
        lblSinImagen.Visible = picProducto.Image Is Nothing
        If lblSinImagen.Visible Then lblSinImagen.BringToFront()
        picProducto.AccessibleDescription = If(picProducto.Image Is Nothing, "Sin imagen", "Imagen del producto seleccionado")
    End Sub

    Private Sub LiberarImagen()
        Dim anterior = picProducto.Image
        picProducto.Image = Nothing
        If anterior IsNot Nothing Then anterior.Dispose()
    End Sub

    Private Sub btnNuevoProducto_Click(sender As Object, e As EventArgs) Handles btnNuevoProducto.Click
        If Not ServicioProductos.PuedeAdministrar() Then Return
        Using formulario = FrmProducto.CrearNuevo(servicio)
            If formulario.ShowDialog(FindForm()) = DialogResult.OK Then CargarProductos()
        End Using
    End Sub

    Private Sub btnEditarProducto_Click(sender As Object, e As EventArgs) Handles btnEditarProducto.Click
        Dim producto = Seleccionado()
        If producto Is Nothing OrElse Not ServicioProductos.PuedeAdministrar() Then Return
        Try
            Using formulario = FrmProducto.CrearParaEdicion(servicio.ObtenerProducto(producto.IdProducto), servicio)
                If formulario.ShowDialog(FindForm()) = DialogResult.OK Then CargarProductos()
            End Using
        Catch ex As ProductoNoEncontradoException
            MessageBox.Show(Me, ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CargarProductos()
        Catch ex As Exception
            MessageBox.Show(Me, "No se pudo abrir el producto. Comprueba la conexión e intenta nuevamente.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
