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
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.colDetalleIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetallePrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalleSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFolioPendiente = New System.Windows.Forms.Label()
        Me.pnlCatalogo = New System.Windows.Forms.Panel()
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.dgvProductosVenta = New System.Windows.Forms.DataGridView()
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
        Me.pnlCobro = New System.Windows.Forms.Panel()
        Me.lblTotalTexto = New System.Windows.Forms.Label()
        Me.lblTotalValor = New System.Windows.Forms.Label()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.lblCambioTexto = New System.Windows.Forms.Label()
        Me.lblCambioValor = New System.Windows.Forms.Label()
        Me.lblMensajeVenta = New System.Windows.Forms.Label()
        Me.nudEfectivoRecibido = New System.Windows.Forms.NumericUpDown()
        Me.btnConfirmarVenta = New System.Windows.Forms.Button()
        Me.erpVenta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tlpRaiz.SuspendLayout()
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlCatalogo.SuspendLayout()
        CType(Me.dgvProductosVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAgregar.SuspendLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCobro.SuspendLayout()
        CType(Me.nudEfectivoRecibido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.AutoSize = True
        Me.tlpRaiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.pnlCatalogo, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.pnlAgregar, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.lblDetalle, 0, 3)
        Me.tlpRaiz.Controls.Add(Me.btnQuitarProducto, 1, 3)
        Me.tlpRaiz.Controls.Add(Me.dgvDetalleVenta, 0, 4)
        Me.tlpRaiz.Controls.Add(Me.pnlCobro, 0, 5)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 6
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(987, 812)
        Me.tlpRaiz.TabIndex = 0
        '
        'dgvDetalleVenta
        '
        Me.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalleVenta.ColumnHeadersHeight = 40
        Me.dgvDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDetalleIdProducto, Me.colDetalleCodigo, Me.colDetalleNombre, Me.colDetalleCantidad, Me.colDetallePrecioUnitario, Me.colDetalleSubtotal})
        Me.tlpRaiz.SetColumnSpan(Me.dgvDetalleVenta, 2)
        Me.dgvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleVenta.EnableHeadersVisualStyles = False
        Me.dgvDetalleVenta.GridColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvDetalleVenta.Location = New System.Drawing.Point(24, 446)
        Me.dgvDetalleVenta.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.dgvDetalleVenta.Name = "dgvDetalleVenta"
        Me.dgvDetalleVenta.RowHeadersWidth = 51
        Me.dgvDetalleVenta.RowTemplate.Height = 36
        Me.dgvDetalleVenta.Size = New System.Drawing.Size(939, 194)
        Me.dgvDetalleVenta.TabIndex = 5
        '
        'colDetalleIdProducto
        '
        Me.colDetalleIdProducto.HeaderText = "IdProducto"
        Me.colDetalleIdProducto.MinimumWidth = 6
        Me.colDetalleIdProducto.Name = "colDetalleIdProducto"
        '
        'colDetalleCodigo
        '
        Me.colDetalleCodigo.HeaderText = "Código"
        Me.colDetalleCodigo.MinimumWidth = 6
        Me.colDetalleCodigo.Name = "colDetalleCodigo"
        Me.colDetalleCodigo.Width = 130
        '
        'colDetalleNombre
        '
        Me.colDetalleNombre.HeaderText = "Producto"
        Me.colDetalleNombre.MinimumWidth = 6
        Me.colDetalleNombre.Name = "colDetalleNombre"
        Me.colDetalleNombre.Width = 290
        '
        'colDetalleCantidad
        '
        Me.colDetalleCantidad.HeaderText = "Cantidad"
        Me.colDetalleCantidad.MinimumWidth = 6
        Me.colDetalleCantidad.Name = "colDetalleCantidad"
        Me.colDetalleCantidad.Width = 110
        '
        'colDetallePrecioUnitario
        '
        Me.colDetallePrecioUnitario.HeaderText = "Precio unitario"
        Me.colDetallePrecioUnitario.MinimumWidth = 6
        Me.colDetallePrecioUnitario.Name = "colDetallePrecioUnitario"
        Me.colDetallePrecioUnitario.Width = 150
        '
        'colDetalleSubtotal
        '
        Me.colDetalleSubtotal.HeaderText = "Subtotal"
        Me.colDetalleSubtotal.MinimumWidth = 6
        Me.colDetalleSubtotal.Name = "colDetalleSubtotal"
        Me.colDetalleSubtotal.Width = 150
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 2)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.lblFolioPendiente)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Location = New System.Drawing.Point(24, 24)
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(939, 52)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(0, -10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(400, 40)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Nueva venta"
        '
        'lblFolioPendiente
        '
        Me.lblFolioPendiente.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolioPendiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblFolioPendiente.Location = New System.Drawing.Point(0, 28)
        Me.lblFolioPendiente.Name = "lblFolioPendiente"
        Me.lblFolioPendiente.Size = New System.Drawing.Size(500, 22)
        Me.lblFolioPendiente.TabIndex = 1
        Me.lblFolioPendiente.Text = "Folio: se asignará al confirmar"
        '
        'pnlCatalogo
        '
        Me.pnlCatalogo.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.SetColumnSpan(Me.pnlCatalogo, 2)
        Me.pnlCatalogo.Controls.Add(Me.lblBuscarProducto)
        Me.pnlCatalogo.Controls.Add(Me.txtBuscarProducto)
        Me.pnlCatalogo.Controls.Add(Me.dgvProductosVenta)
        Me.pnlCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCatalogo.Location = New System.Drawing.Point(24, 92)
        Me.pnlCatalogo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlCatalogo.Name = "pnlCatalogo"
        Me.pnlCatalogo.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlCatalogo.Size = New System.Drawing.Size(939, 234)
        Me.pnlCatalogo.TabIndex = 1
        '
        'lblBuscarProducto
        '
        Me.lblBuscarProducto.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarProducto.Location = New System.Drawing.Point(20, 6)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(250, 22)
        Me.lblBuscarProducto.TabIndex = 0
        Me.lblBuscarProducto.Text = "Buscar producto"
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.BackColor = System.Drawing.Color.White
        Me.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarProducto.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProducto.Location = New System.Drawing.Point(20, 32)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(700, 31)
        Me.txtBuscarProducto.TabIndex = 1
        '
        'dgvProductosVenta
        '
        Me.dgvProductosVenta.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductosVenta.ColumnHeadersHeight = 40
        Me.dgvProductosVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCatalogoIdProducto, Me.colCatalogoCodigo, Me.colCatalogoNombre, Me.colCatalogoPrecio, Me.colCatalogoExistencias})
        Me.dgvProductosVenta.EnableHeadersVisualStyles = False
        Me.dgvProductosVenta.GridColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvProductosVenta.Location = New System.Drawing.Point(20, 74)
        Me.dgvProductosVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProductosVenta.Name = "dgvProductosVenta"
        Me.dgvProductosVenta.RowHeadersWidth = 51
        Me.dgvProductosVenta.RowTemplate.Height = 36
        Me.dgvProductosVenta.Size = New System.Drawing.Size(700, 148)
        Me.dgvProductosVenta.TabIndex = 2
        '
        'colCatalogoIdProducto
        '
        Me.colCatalogoIdProducto.HeaderText = "IdProducto"
        Me.colCatalogoIdProducto.MinimumWidth = 6
        Me.colCatalogoIdProducto.Name = "colCatalogoIdProducto"
        '
        'colCatalogoCodigo
        '
        Me.colCatalogoCodigo.HeaderText = "Código"
        Me.colCatalogoCodigo.MinimumWidth = 6
        Me.colCatalogoCodigo.Name = "colCatalogoCodigo"
        Me.colCatalogoCodigo.Width = 140
        '
        'colCatalogoNombre
        '
        Me.colCatalogoNombre.HeaderText = "Producto"
        Me.colCatalogoNombre.MinimumWidth = 6
        Me.colCatalogoNombre.Name = "colCatalogoNombre"
        Me.colCatalogoNombre.Width = 300
        '
        'colCatalogoPrecio
        '
        Me.colCatalogoPrecio.HeaderText = "Precio"
        Me.colCatalogoPrecio.MinimumWidth = 6
        Me.colCatalogoPrecio.Name = "colCatalogoPrecio"
        Me.colCatalogoPrecio.Width = 140
        '
        'colCatalogoExistencias
        '
        Me.colCatalogoExistencias.HeaderText = "Existencias"
        Me.colCatalogoExistencias.MinimumWidth = 6
        Me.colCatalogoExistencias.Name = "colCatalogoExistencias"
        Me.colCatalogoExistencias.Width = 130
        '
        'pnlAgregar
        '
        Me.pnlAgregar.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.SetColumnSpan(Me.pnlAgregar, 2)
        Me.pnlAgregar.Controls.Add(Me.lblCantidad)
        Me.pnlAgregar.Controls.Add(Me.nudCantidad)
        Me.pnlAgregar.Controls.Add(Me.btnAgregarProducto)
        Me.pnlAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAgregar.Location = New System.Drawing.Point(27, 345)
        Me.pnlAgregar.Name = "pnlAgregar"
        Me.pnlAgregar.Size = New System.Drawing.Size(933, 50)
        Me.pnlAgregar.TabIndex = 2
        '
        'lblCantidad
        '
        Me.lblCantidad.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(0, 14)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(90, 24)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad"
        '
        'nudCantidad
        '
        Me.nudCantidad.BackColor = System.Drawing.Color.White
        Me.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCantidad.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantidad.Location = New System.Drawing.Point(100, 9)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(100, 31)
        Me.nudCantidad.TabIndex = 1
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.Blue
        Me.btnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAgregarProducto.Location = New System.Drawing.Point(216, 4)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(144, 40)
        Me.btnAgregarProducto.TabIndex = 2
        Me.btnAgregarProducto.Text = "Agregar a venta"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'lblDetalle
        '
        Me.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDetalle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblDetalle.Location = New System.Drawing.Point(27, 398)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(773, 48)
        Me.lblDetalle.TabIndex = 3
        Me.lblDetalle.Text = "Productos de la venta"
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnQuitarProducto.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuitarProducto.FlatAppearance.BorderSize = 0
        Me.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarProducto.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnQuitarProducto.Location = New System.Drawing.Point(819, 402)
        Me.btnQuitarProducto.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(144, 40)
        Me.btnQuitarProducto.TabIndex = 4
        Me.btnQuitarProducto.Text = "Quitar producto"
        Me.btnQuitarProducto.UseVisualStyleBackColor = False
        '
        'pnlCobro
        '
        Me.pnlCobro.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.SetColumnSpan(Me.pnlCobro, 2)
        Me.pnlCobro.Controls.Add(Me.lblTotalTexto)
        Me.pnlCobro.Controls.Add(Me.lblTotalValor)
        Me.pnlCobro.Controls.Add(Me.lblEfectivo)
        Me.pnlCobro.Controls.Add(Me.lblCambioTexto)
        Me.pnlCobro.Controls.Add(Me.lblCambioValor)
        Me.pnlCobro.Controls.Add(Me.lblMensajeVenta)
        Me.pnlCobro.Controls.Add(Me.nudEfectivoRecibido)
        Me.pnlCobro.Controls.Add(Me.btnConfirmarVenta)
        Me.pnlCobro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCobro.Location = New System.Drawing.Point(27, 659)
        Me.pnlCobro.Name = "pnlCobro"
        Me.pnlCobro.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlCobro.Size = New System.Drawing.Size(933, 126)
        Me.pnlCobro.TabIndex = 6
        '
        'lblTotalTexto
        '
        Me.lblTotalTexto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTexto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTotalTexto.Location = New System.Drawing.Point(20, 8)
        Me.lblTotalTexto.Name = "lblTotalTexto"
        Me.lblTotalTexto.Size = New System.Drawing.Size(170, 22)
        Me.lblTotalTexto.TabIndex = 0
        Me.lblTotalTexto.Text = "Total"
        '
        'lblTotalValor
        '
        Me.lblTotalValor.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTotalValor.Location = New System.Drawing.Point(20, 34)
        Me.lblTotalValor.Name = "lblTotalValor"
        Me.lblTotalValor.Size = New System.Drawing.Size(170, 22)
        Me.lblTotalValor.TabIndex = 1
        Me.lblTotalValor.Text = "$0.00"
        '
        'lblEfectivo
        '
        Me.lblEfectivo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfectivo.Location = New System.Drawing.Point(230, 8)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(190, 22)
        Me.lblEfectivo.TabIndex = 2
        Me.lblEfectivo.Text = "Efectivo recibido"
        '
        'lblCambioTexto
        '
        Me.lblCambioTexto.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambioTexto.Location = New System.Drawing.Point(430, 8)
        Me.lblCambioTexto.Name = "lblCambioTexto"
        Me.lblCambioTexto.Size = New System.Drawing.Size(120, 22)
        Me.lblCambioTexto.TabIndex = 3
        Me.lblCambioTexto.Text = "Cambio"
        '
        'lblCambioValor
        '
        Me.lblCambioValor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambioValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCambioValor.Location = New System.Drawing.Point(430, 34)
        Me.lblCambioValor.Name = "lblCambioValor"
        Me.lblCambioValor.Size = New System.Drawing.Size(120, 22)
        Me.lblCambioValor.TabIndex = 4
        Me.lblCambioValor.Text = "$0.00"
        '
        'lblMensajeVenta
        '
        Me.lblMensajeVenta.Location = New System.Drawing.Point(20, 84)
        Me.lblMensajeVenta.Name = "lblMensajeVenta"
        Me.lblMensajeVenta.Size = New System.Drawing.Size(650, 22)
        Me.lblMensajeVenta.TabIndex = 5
        '
        'nudEfectivoRecibido
        '
        Me.nudEfectivoRecibido.BackColor = System.Drawing.Color.White
        Me.nudEfectivoRecibido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudEfectivoRecibido.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEfectivoRecibido.Location = New System.Drawing.Point(230, 34)
        Me.nudEfectivoRecibido.Name = "nudEfectivoRecibido"
        Me.nudEfectivoRecibido.Size = New System.Drawing.Size(180, 31)
        Me.nudEfectivoRecibido.TabIndex = 6
        '
        'btnConfirmarVenta
        '
        Me.btnConfirmarVenta.BackColor = System.Drawing.Color.Blue
        Me.btnConfirmarVenta.FlatAppearance.BorderSize = 0
        Me.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarVenta.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarVenta.ForeColor = System.Drawing.Color.White
        Me.btnConfirmarVenta.Location = New System.Drawing.Point(560, 34)
        Me.btnConfirmarVenta.Name = "btnConfirmarVenta"
        Me.btnConfirmarVenta.Size = New System.Drawing.Size(170, 40)
        Me.btnConfirmarVenta.TabIndex = 7
        Me.btnConfirmarVenta.Text = "Confirmar venta"
        Me.btnConfirmarVenta.UseVisualStyleBackColor = False
        '
        'erpVenta
        '
        Me.erpVenta.ContainerControl = Me
        '
        'UcVenta
        '
        Me.AutoScroll = True
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "UcVenta"
        Me.Size = New System.Drawing.Size(987, 704)
        Me.tlpRaiz.ResumeLayout(False)
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlCatalogo.ResumeLayout(False)
        Me.pnlCatalogo.PerformLayout()
        CType(Me.dgvProductosVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAgregar.ResumeLayout(False)
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCobro.ResumeLayout(False)
        CType(Me.nudEfectivoRecibido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
