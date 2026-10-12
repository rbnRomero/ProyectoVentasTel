<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcVenta
    Inherits System.Windows.Forms.UserControl
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SuspendLayout()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24, 24, 24, 24)
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFolioPendiente = New System.Windows.Forms.Label()
        Me.pnlCatalogo = New System.Windows.Forms.Panel()
        Me.pnlCatalogo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlCatalogo.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.dgvProductosVenta = New System.Windows.Forms.DataGridView()
        Me.dgvProductosVenta.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.colCatalogoIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatalogoCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatalogoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatalogoPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatalogoExistencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlAgregar = New System.Windows.Forms.Panel()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.dgvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.dgvDetalleVenta.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.colDetalleIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetallePrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlCobro = New System.Windows.Forms.Panel()
        Me.pnlCobro.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblTotalTexto = New System.Windows.Forms.Label()
        Me.lblTotalValor = New System.Windows.Forms.Label()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.lblCambioTexto = New System.Windows.Forms.Label()
        Me.lblCambioValor = New System.Windows.Forms.Label()
        Me.lblMensajeVenta = New System.Windows.Forms.Label()
        Me.nudEfectivoRecibido = New System.Windows.Forms.NumericUpDown()
        Me.btnConfirmarVenta = New System.Windows.Forms.Button()
        Me.erpVenta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.Name = "UcVenta"
        Me.AutoScroll = True
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Size = New System.Drawing.Size(1008, 850)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpRaiz.AutoSize = True
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.RowCount = 6
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Nueva venta"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Size = New System.Drawing.Size(400, 30)
        Me.lblFolioPendiente.Name = "lblFolioPendiente"
        Me.lblFolioPendiente.Visible = True
        Me.lblFolioPendiente.Text = "Folio: se asignará al confirmar"
        Me.lblFolioPendiente.Location = New System.Drawing.Point(0, 28)
        Me.lblFolioPendiente.Size = New System.Drawing.Size(500, 22)
        Me.pnlCatalogo.Name = "pnlCatalogo"
        Me.pnlCatalogo.Visible = True
        Me.pnlCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Visible = True
        Me.lblBuscarProducto.Text = "Buscar producto"
        Me.lblBuscarProducto.Location = New System.Drawing.Point(20, 6)
        Me.lblBuscarProducto.Size = New System.Drawing.Size(250, 22)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Visible = True
        Me.txtBuscarProducto.Location = New System.Drawing.Point(20, 32)
        Me.txtBuscarProducto.Size = New System.Drawing.Size(700, 38)
        Me.dgvProductosVenta.Name = "dgvProductosVenta"
        Me.dgvProductosVenta.Visible = True
        Me.dgvProductosVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductosVenta.ColumnHeadersHeight = 40
        Me.dgvProductosVenta.RowTemplate.Height = 36
        Me.colCatalogoIdProducto.Name = "colCatalogoIdProducto"
        Me.colCatalogoIdProducto.HeaderText = "IdProducto"
        Me.colCatalogoIdProducto.Visible = True
        Me.colCatalogoIdProducto.Width = 100
        Me.colCatalogoCodigo.Name = "colCatalogoCodigo"
        Me.colCatalogoCodigo.HeaderText = "Código"
        Me.colCatalogoCodigo.Visible = True
        Me.colCatalogoCodigo.Width = 140
        Me.colCatalogoNombre.Name = "colCatalogoNombre"
        Me.colCatalogoNombre.HeaderText = "Producto"
        Me.colCatalogoNombre.Visible = True
        Me.colCatalogoNombre.Width = 300
        Me.colCatalogoPrecio.Name = "colCatalogoPrecio"
        Me.colCatalogoPrecio.HeaderText = "Precio"
        Me.colCatalogoPrecio.Visible = True
        Me.colCatalogoPrecio.Width = 140
        Me.colCatalogoExistencias.Name = "colCatalogoExistencias"
        Me.colCatalogoExistencias.HeaderText = "Existencias"
        Me.colCatalogoExistencias.Visible = True
        Me.colCatalogoExistencias.Width = 130
        Me.dgvProductosVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCatalogoIdProducto, Me.colCatalogoCodigo, Me.colCatalogoNombre, Me.colCatalogoPrecio, Me.colCatalogoExistencias})
        Me.dgvProductosVenta.Dock = System.Windows.Forms.DockStyle.None
        Me.dgvProductosVenta.Location = New System.Drawing.Point(20, 74)
        Me.dgvProductosVenta.Size = New System.Drawing.Size(700, 148)
        Me.pnlAgregar.Name = "pnlAgregar"
        Me.pnlAgregar.Visible = True
        Me.pnlAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Visible = True
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.Location = New System.Drawing.Point(0, 14)
        Me.lblCantidad.Size = New System.Drawing.Size(90, 24)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Visible = True
        Me.nudCantidad.Location = New System.Drawing.Point(100, 9)
        Me.nudCantidad.Size = New System.Drawing.Size(100, 38)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Visible = True
        Me.btnAgregarProducto.Text = "Agregar a venta"
        Me.btnAgregarProducto.Location = New System.Drawing.Point(216, 4)
        Me.btnAgregarProducto.Size = New System.Drawing.Size(144, 40)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Visible = True
        Me.lblDetalle.Text = "Productos de la venta"
        Me.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Visible = True
        Me.btnQuitarProducto.Text = "Quitar producto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(144, 40)
        Me.btnQuitarProducto.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuitarProducto.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.dgvDetalleVenta.Name = "dgvDetalleVenta"
        Me.dgvDetalleVenta.Visible = True
        Me.dgvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleVenta.ColumnHeadersHeight = 40
        Me.dgvDetalleVenta.RowTemplate.Height = 36
        Me.colDetalleIdProducto.Name = "colDetalleIdProducto"
        Me.colDetalleIdProducto.HeaderText = "IdProducto"
        Me.colDetalleIdProducto.Visible = True
        Me.colDetalleIdProducto.Width = 100
        Me.colDetalleCodigo.Name = "colDetalleCodigo"
        Me.colDetalleCodigo.HeaderText = "Código"
        Me.colDetalleCodigo.Visible = True
        Me.colDetalleCodigo.Width = 130
        Me.colDetalleNombre.Name = "colDetalleNombre"
        Me.colDetalleNombre.HeaderText = "Producto"
        Me.colDetalleNombre.Visible = True
        Me.colDetalleNombre.Width = 290
        Me.colDetalleCantidad.Name = "colDetalleCantidad"
        Me.colDetalleCantidad.HeaderText = "Cantidad"
        Me.colDetalleCantidad.Visible = True
        Me.colDetalleCantidad.Width = 110
        Me.colDetallePrecioUnitario.Name = "colDetallePrecioUnitario"
        Me.colDetallePrecioUnitario.HeaderText = "Precio unitario"
        Me.colDetallePrecioUnitario.Visible = True
        Me.colDetallePrecioUnitario.Width = 150
        Me.colDetalleSubtotal.Name = "colDetalleSubtotal"
        Me.colDetalleSubtotal.HeaderText = "Subtotal"
        Me.colDetalleSubtotal.Visible = True
        Me.colDetalleSubtotal.Width = 150
        Me.dgvDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDetalleIdProducto, Me.colDetalleCodigo, Me.colDetalleNombre, Me.colDetalleCantidad, Me.colDetallePrecioUnitario, Me.colDetalleSubtotal})
        Me.tlpRaiz.SetColumnSpan(Me.dgvDetalleVenta, 2)
        Me.pnlCobro.Name = "pnlCobro"
        Me.pnlCobro.Visible = True
        Me.pnlCobro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalTexto.Name = "lblTotalTexto"
        Me.lblTotalTexto.Visible = True
        Me.lblTotalTexto.Text = "Total"
        Me.lblTotalTexto.Location = New System.Drawing.Point(20, 8)
        Me.lblTotalTexto.Size = New System.Drawing.Size(170, 22)
        Me.lblTotalValor.Name = "lblTotalValor"
        Me.lblTotalValor.Visible = True
        Me.lblTotalValor.Text = "$0.00"
        Me.lblTotalValor.Location = New System.Drawing.Point(20, 34)
        Me.lblTotalValor.Size = New System.Drawing.Size(170, 22)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Visible = True
        Me.lblEfectivo.Text = "Efectivo recibido"
        Me.lblEfectivo.Location = New System.Drawing.Point(230, 8)
        Me.lblEfectivo.Size = New System.Drawing.Size(190, 22)
        Me.lblCambioTexto.Name = "lblCambioTexto"
        Me.lblCambioTexto.Visible = True
        Me.lblCambioTexto.Text = "Cambio"
        Me.lblCambioTexto.Location = New System.Drawing.Point(430, 8)
        Me.lblCambioTexto.Size = New System.Drawing.Size(120, 22)
        Me.lblCambioValor.Name = "lblCambioValor"
        Me.lblCambioValor.Visible = True
        Me.lblCambioValor.Text = "$0.00"
        Me.lblCambioValor.Location = New System.Drawing.Point(430, 34)
        Me.lblCambioValor.Size = New System.Drawing.Size(120, 22)
        Me.lblMensajeVenta.Name = "lblMensajeVenta"
        Me.lblMensajeVenta.Visible = True
        Me.lblMensajeVenta.Text = ""
        Me.lblMensajeVenta.Location = New System.Drawing.Point(20, 84)
        Me.lblMensajeVenta.Size = New System.Drawing.Size(650, 22)
        Me.nudEfectivoRecibido.Name = "nudEfectivoRecibido"
        Me.nudEfectivoRecibido.Visible = True
        Me.nudEfectivoRecibido.Location = New System.Drawing.Point(230, 34)
        Me.nudEfectivoRecibido.Size = New System.Drawing.Size(180, 38)
        Me.btnConfirmarVenta.Name = "btnConfirmarVenta"
        Me.btnConfirmarVenta.Visible = True
        Me.btnConfirmarVenta.Text = "Confirmar venta"
        Me.btnConfirmarVenta.Location = New System.Drawing.Point(560, 34)
        Me.btnConfirmarVenta.Size = New System.Drawing.Size(170, 40)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 2)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.lblFolioPendiente)
        Me.tlpRaiz.Controls.Add(Me.pnlCatalogo, 0, 1)
        Me.tlpRaiz.SetColumnSpan(Me.pnlCatalogo, 2)
        Me.pnlCatalogo.Controls.Add(Me.lblBuscarProducto)
        Me.pnlCatalogo.Controls.Add(Me.txtBuscarProducto)
        Me.pnlCatalogo.Controls.Add(Me.dgvProductosVenta)
        Me.tlpRaiz.Controls.Add(Me.pnlAgregar, 0, 2)
        Me.tlpRaiz.SetColumnSpan(Me.pnlAgregar, 2)
        Me.pnlAgregar.Controls.Add(Me.lblCantidad)
        Me.pnlAgregar.Controls.Add(Me.nudCantidad)
        Me.pnlAgregar.Controls.Add(Me.btnAgregarProducto)
        Me.tlpRaiz.Controls.Add(Me.lblDetalle, 0, 3)
        Me.tlpRaiz.Controls.Add(Me.btnQuitarProducto, 1, 3)
        Me.tlpRaiz.Controls.Add(Me.dgvDetalleVenta, 0, 4)
        Me.tlpRaiz.Controls.Add(Me.pnlCobro, 0, 5)
        Me.tlpRaiz.SetColumnSpan(Me.pnlCobro, 2)
        Me.pnlCobro.Controls.Add(Me.lblTotalTexto)
        Me.pnlCobro.Controls.Add(Me.lblTotalValor)
        Me.pnlCobro.Controls.Add(Me.lblEfectivo)
        Me.pnlCobro.Controls.Add(Me.lblCambioTexto)
        Me.pnlCobro.Controls.Add(Me.lblCambioValor)
        Me.pnlCobro.Controls.Add(Me.lblMensajeVenta)
        Me.pnlCobro.Controls.Add(Me.nudEfectivoRecibido)
        Me.pnlCobro.Controls.Add(Me.btnConfirmarVenta)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblFolioPendiente As System.Windows.Forms.Label
    Friend WithEvents pnlCatalogo As System.Windows.Forms.Panel
    Friend WithEvents lblBuscarProducto As System.Windows.Forms.Label
    Friend WithEvents txtBuscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents dgvProductosVenta As System.Windows.Forms.DataGridView
    Friend WithEvents pnlAgregar As System.Windows.Forms.Panel
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents btnQuitarProducto As System.Windows.Forms.Button
    Friend WithEvents dgvDetalleVenta As System.Windows.Forms.DataGridView
    Friend WithEvents pnlCobro As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTexto As System.Windows.Forms.Label
    Friend WithEvents lblTotalValor As System.Windows.Forms.Label
    Friend WithEvents lblEfectivo As System.Windows.Forms.Label
    Friend WithEvents lblCambioTexto As System.Windows.Forms.Label
    Friend WithEvents lblCambioValor As System.Windows.Forms.Label
    Friend WithEvents lblMensajeVenta As System.Windows.Forms.Label
    Friend WithEvents nudEfectivoRecibido As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnConfirmarVenta As System.Windows.Forms.Button
    Friend WithEvents erpVenta As System.Windows.Forms.ErrorProvider
    Friend WithEvents colCatalogoIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatalogoCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatalogoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatalogoPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatalogoExistencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetalleIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetalleCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetalleNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetalleCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetallePrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetalleSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
