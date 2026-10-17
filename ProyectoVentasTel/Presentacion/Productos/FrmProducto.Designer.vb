<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducto
    Inherits System.Windows.Forms.Form
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
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tlpCampos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblCapacidadGB = New System.Windows.Forms.Label()
        Me.txtCapacidadGB = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.nudPrecioVenta = New System.Windows.Forms.NumericUpDown()
        Me.lblExistencias = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.pnlImagen = New System.Windows.Forms.Panel()
        Me.picVistaPrevia = New System.Windows.Forms.PictureBox()
        Me.lblNombreImagen = New System.Windows.Forms.Label()
        Me.btnSeleccionarImagen = New System.Windows.Forms.Button()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.erpProducto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.tlpRaiz.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.tlpCampos.SuspendLayout()
        CType(Me.nudPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlImagen.SuspendLayout()
        CType(Me.picVistaPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.ColumnCount = 3
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.tlpCampos, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.pnlImagen, 2, 1)
        Me.tlpRaiz.Controls.Add(Me.btnGuardar, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.btnCancelar, 2, 2)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(742, 673)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 3)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Location = New System.Drawing.Point(27, 27)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(688, 58)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(400, 46)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Nuevo producto"
        '
        'tlpCampos
        '
        Me.tlpCampos.ColumnCount = 2
        Me.tlpCampos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCampos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCampos.Controls.Add(Me.lblCodigo, 0, 0)
        Me.tlpCampos.Controls.Add(Me.txtCodigo, 0, 1)
        Me.tlpCampos.Controls.Add(Me.lblNombre, 1, 0)
        Me.tlpCampos.Controls.Add(Me.txtNombre, 1, 1)
        Me.tlpCampos.Controls.Add(Me.lblTipoProducto, 0, 2)
        Me.tlpCampos.Controls.Add(Me.cboTipoProducto, 0, 3)
        Me.tlpCampos.Controls.Add(Me.lblMarca, 1, 2)
        Me.tlpCampos.Controls.Add(Me.txtMarca, 1, 3)
        Me.tlpCampos.Controls.Add(Me.lblModelo, 0, 4)
        Me.tlpCampos.Controls.Add(Me.txtModelo, 0, 5)
        Me.tlpCampos.Controls.Add(Me.lblCapacidadGB, 1, 4)
        Me.tlpCampos.Controls.Add(Me.txtCapacidadGB, 1, 5)
        Me.tlpCampos.Controls.Add(Me.lblColor, 0, 6)
        Me.tlpCampos.Controls.Add(Me.txtColor, 0, 7)
        Me.tlpCampos.Controls.Add(Me.lblPrecioVenta, 1, 6)
        Me.tlpCampos.Controls.Add(Me.nudPrecioVenta, 1, 7)
        Me.tlpCampos.Controls.Add(Me.lblExistencias, 0, 8)
        Me.tlpCampos.Controls.Add(Me.chkActivo, 1, 8)
        Me.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCampos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpCampos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tlpCampos.Location = New System.Drawing.Point(24, 88)
        Me.tlpCampos.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.tlpCampos.Name = "tlpCampos"
        Me.tlpCampos.RowCount = 9
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCampos.Size = New System.Drawing.Size(438, 489)
        Me.tlpCampos.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodigo.Location = New System.Drawing.Point(0, 0)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(207, 24)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(0, 24)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(207, 32)
        Me.txtCodigo.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Location = New System.Drawing.Point(219, 0)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(207, 24)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(219, 24)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(207, 32)
        Me.txtNombre.TabIndex = 3
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoProducto.Location = New System.Drawing.Point(0, 72)
        Me.lblTipoProducto.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(207, 24)
        Me.lblTipoProducto.TabIndex = 4
        Me.lblTipoProducto.Text = "Tipo"
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.BackColor = System.Drawing.Color.White
        Me.cboTipoProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoProducto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboTipoProducto.Items.AddRange(New Object() {"Teléfono", "Accesorio"})
        Me.cboTipoProducto.Location = New System.Drawing.Point(0, 96)
        Me.cboTipoProducto.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(207, 33)
        Me.cboTipoProducto.TabIndex = 5
        '
        'lblMarca
        '
        Me.lblMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMarca.Location = New System.Drawing.Point(219, 72)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(207, 24)
        Me.lblMarca.TabIndex = 6
        Me.lblMarca.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.White
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtMarca.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtMarca.Location = New System.Drawing.Point(219, 96)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(207, 32)
        Me.txtMarca.TabIndex = 7
        '
        'lblModelo
        '
        Me.lblModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblModelo.Location = New System.Drawing.Point(0, 144)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(207, 24)
        Me.lblModelo.TabIndex = 8
        Me.lblModelo.Text = "Modelo"
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.White
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModelo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtModelo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtModelo.Location = New System.Drawing.Point(0, 168)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(207, 32)
        Me.txtModelo.TabIndex = 9
        '
        'lblCapacidadGB
        '
        Me.lblCapacidadGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCapacidadGB.Location = New System.Drawing.Point(219, 144)
        Me.lblCapacidadGB.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblCapacidadGB.Name = "lblCapacidadGB"
        Me.lblCapacidadGB.Size = New System.Drawing.Size(207, 24)
        Me.lblCapacidadGB.TabIndex = 10
        Me.lblCapacidadGB.Text = "Capacidad (GB)"
        '
        'txtCapacidadGB
        '
        Me.txtCapacidadGB.BackColor = System.Drawing.Color.White
        Me.txtCapacidadGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapacidadGB.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCapacidadGB.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidadGB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtCapacidadGB.Location = New System.Drawing.Point(219, 168)
        Me.txtCapacidadGB.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.txtCapacidadGB.Name = "txtCapacidadGB"
        Me.txtCapacidadGB.Size = New System.Drawing.Size(207, 32)
        Me.txtCapacidadGB.TabIndex = 11
        '
        'lblColor
        '
        Me.lblColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColor.Location = New System.Drawing.Point(0, 216)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(207, 24)
        Me.lblColor.TabIndex = 12
        Me.lblColor.Text = "Color"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtColor.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtColor.Location = New System.Drawing.Point(0, 240)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(207, 32)
        Me.txtColor.TabIndex = 13
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrecioVenta.Location = New System.Drawing.Point(219, 216)
        Me.lblPrecioVenta.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(207, 24)
        Me.lblPrecioVenta.TabIndex = 14
        Me.lblPrecioVenta.Text = "Precio de venta"
        '
        'nudPrecioVenta
        '
        Me.nudPrecioVenta.BackColor = System.Drawing.Color.White
        Me.nudPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudPrecioVenta.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.nudPrecioVenta.Location = New System.Drawing.Point(219, 240)
        Me.nudPrecioVenta.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.nudPrecioVenta.Name = "nudPrecioVenta"
        Me.nudPrecioVenta.Size = New System.Drawing.Size(207, 32)
        Me.nudPrecioVenta.TabIndex = 15
        '
        'lblExistencias
        '
        Me.lblExistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExistencias.Location = New System.Drawing.Point(3, 288)
        Me.lblExistencias.Name = "lblExistencias"
        Me.lblExistencias.Size = New System.Drawing.Size(213, 201)
        Me.lblExistencias.TabIndex = 16
        Me.lblExistencias.Text = "Existencias: 0"
        '
        'chkActivo
        '
        Me.chkActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkActivo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(222, 291)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(213, 195)
        Me.chkActivo.TabIndex = 17
        Me.chkActivo.Text = "Activo"
        '
        'pnlImagen
        '
        Me.pnlImagen.Controls.Add(Me.picVistaPrevia)
        Me.pnlImagen.Controls.Add(Me.lblNombreImagen)
        Me.pnlImagen.Controls.Add(Me.btnSeleccionarImagen)
        Me.pnlImagen.Controls.Add(Me.btnQuitarImagen)
        Me.pnlImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlImagen.Location = New System.Drawing.Point(481, 91)
        Me.pnlImagen.Name = "pnlImagen"
        Me.pnlImagen.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlImagen.Size = New System.Drawing.Size(234, 499)
        Me.pnlImagen.TabIndex = 2
        '
        'picVistaPrevia
        '
        Me.picVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVistaPrevia.Location = New System.Drawing.Point(20, 20)
        Me.picVistaPrevia.Name = "picVistaPrevia"
        Me.picVistaPrevia.Size = New System.Drawing.Size(200, 230)
        Me.picVistaPrevia.TabIndex = 0
        Me.picVistaPrevia.TabStop = False
        '
        'lblNombreImagen
        '
        Me.lblNombreImagen.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblNombreImagen.Location = New System.Drawing.Point(55, 174)
        Me.lblNombreImagen.Name = "lblNombreImagen"
        Me.lblNombreImagen.Size = New System.Drawing.Size(130, 22)
        Me.lblNombreImagen.TabIndex = 1
        Me.lblNombreImagen.Text = "Sin imagen"
        '
        'btnSeleccionarImagen
        '
        Me.btnSeleccionarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSeleccionarImagen.FlatAppearance.BorderSize = 0
        Me.btnSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarImagen.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarImagen.ForeColor = System.Drawing.Color.White
        Me.btnSeleccionarImagen.Location = New System.Drawing.Point(20, 270)
        Me.btnSeleccionarImagen.Name = "btnSeleccionarImagen"
        Me.btnSeleccionarImagen.Size = New System.Drawing.Size(200, 40)
        Me.btnSeleccionarImagen.TabIndex = 2
        Me.btnSeleccionarImagen.Text = "Seleccionar imagen"
        Me.btnSeleccionarImagen.UseVisualStyleBackColor = False
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnQuitarImagen.FlatAppearance.BorderSize = 0
        Me.btnQuitarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarImagen.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnQuitarImagen.Location = New System.Drawing.Point(20, 322)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.Size = New System.Drawing.Size(200, 40)
        Me.btnQuitarImagen.TabIndex = 3
        Me.btnQuitarImagen.Text = "Quitar imagen"
        Me.btnQuitarImagen.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(27, 596)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar producto"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(481, 596)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 40)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'erpProducto
        '
        Me.erpProducto.ContainerControl = Me
        '
        'FrmProducto
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(742, 673)
        Me.Controls.Add(Me.tlpRaiz)
        Me.MinimumSize = New System.Drawing.Size(680, 620)
        Me.Name = "FrmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Producto"
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        Me.tlpCampos.ResumeLayout(False)
        Me.tlpCampos.PerformLayout()
        CType(Me.nudPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlImagen.ResumeLayout(False)
        CType(Me.picVistaPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tlpCampos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoProducto As System.Windows.Forms.Label
    Friend WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblCapacidadGB As System.Windows.Forms.Label
    Friend WithEvents txtCapacidadGB As System.Windows.Forms.TextBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioVenta As System.Windows.Forms.Label
    Friend WithEvents nudPrecioVenta As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblExistencias As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents pnlImagen As System.Windows.Forms.Panel
    Friend WithEvents picVistaPrevia As System.Windows.Forms.PictureBox
    Friend WithEvents lblNombreImagen As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionarImagen As System.Windows.Forms.Button
    Friend WithEvents btnQuitarImagen As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents erpProducto As System.Windows.Forms.ErrorProvider
    Friend WithEvents ofdImagen As System.Windows.Forms.OpenFileDialog
End Class
