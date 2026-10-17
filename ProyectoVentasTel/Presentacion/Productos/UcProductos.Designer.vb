<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnNuevoProducto = New System.Windows.Forms.Button()
        Me.btnEditarProducto = New System.Windows.Forms.Button()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.cboFiltroTipo = New System.Windows.Forms.ComboBox()
        Me.cboFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.colIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExistencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinProductos = New System.Windows.Forms.Label()
        Me.pnlVistaPrevia = New System.Windows.Forms.Panel()
        Me.lblVistaPrevia = New System.Windows.Forms.Label()
        Me.picProducto = New System.Windows.Forms.PictureBox()
        Me.lblSinImagen = New System.Windows.Forms.Label()
        Me.tlpRaiz.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        Me.pnlTabla.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVistaPrevia.SuspendLayout()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.pnlFiltros, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.pnlVistaPrevia, 1, 2)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 2)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.btnNuevoProducto)
        Me.pnlEncabezado.Controls.Add(Me.btnEditarProducto)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Location = New System.Drawing.Point(24, 24)
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(960, 44)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(430, 56)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Productos y existencias"
        '
        'btnNuevoProducto
        '
        Me.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNuevoProducto.FlatAppearance.BorderSize = 0
        Me.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoProducto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProducto.ForeColor = System.Drawing.Color.White
        Me.btnNuevoProducto.Location = New System.Drawing.Point(430, 0)
        Me.btnNuevoProducto.Name = "btnNuevoProducto"
        Me.btnNuevoProducto.Size = New System.Drawing.Size(144, 40)
        Me.btnNuevoProducto.TabIndex = 1
        Me.btnNuevoProducto.Text = "Nuevo producto"
        Me.btnNuevoProducto.UseVisualStyleBackColor = False
        '
        'btnEditarProducto
        '
        Me.btnEditarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEditarProducto.FlatAppearance.BorderSize = 0
        Me.btnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarProducto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnEditarProducto.Location = New System.Drawing.Point(586, 0)
        Me.btnEditarProducto.Name = "btnEditarProducto"
        Me.btnEditarProducto.Size = New System.Drawing.Size(144, 40)
        Me.btnEditarProducto.TabIndex = 2
        Me.btnEditarProducto.Text = "Editar producto"
        Me.btnEditarProducto.UseVisualStyleBackColor = False
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.White
        Me.tlpRaiz.SetColumnSpan(Me.pnlFiltros, 2)
        Me.pnlFiltros.Controls.Add(Me.lblBuscar)
        Me.pnlFiltros.Controls.Add(Me.lblTipo)
        Me.pnlFiltros.Controls.Add(Me.lblEstado)
        Me.pnlFiltros.Controls.Add(Me.txtBuscarProducto)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroTipo)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroEstado)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFiltros.Location = New System.Drawing.Point(24, 84)
        Me.pnlFiltros.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFiltros.Size = New System.Drawing.Size(960, 76)
        Me.pnlFiltros.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(20, 8)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(280, 22)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar"
        '
        'lblTipo
        '
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTipo.Location = New System.Drawing.Point(312, 8)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(180, 22)
        Me.lblTipo.TabIndex = 1
        Me.lblTipo.Text = "Tipo"
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(504, 8)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(180, 22)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Estado"
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.BackColor = System.Drawing.Color.White
        Me.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarProducto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtBuscarProducto.Location = New System.Drawing.Point(20, 34)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(280, 32)
        Me.txtBuscarProducto.TabIndex = 3
        '
        'cboFiltroTipo
        '
        Me.cboFiltroTipo.BackColor = System.Drawing.Color.White
        Me.cboFiltroTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFiltroTipo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFiltroTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboFiltroTipo.Items.AddRange(New Object() {"Todos", "Teléfono", "Accesorio"})
        Me.cboFiltroTipo.Location = New System.Drawing.Point(312, 34)
        Me.cboFiltroTipo.Name = "cboFiltroTipo"
        Me.cboFiltroTipo.Size = New System.Drawing.Size(180, 33)
        Me.cboFiltroTipo.TabIndex = 4
        '
        'cboFiltroEstado
        '
        Me.cboFiltroEstado.BackColor = System.Drawing.Color.White
        Me.cboFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboFiltroEstado.Items.AddRange(New Object() {"Todos", "Activos", "Inactivos"})
        Me.cboFiltroEstado.Location = New System.Drawing.Point(504, 34)
        Me.cboFiltroEstado.Name = "cboFiltroEstado"
        Me.cboFiltroEstado.Size = New System.Drawing.Size(180, 33)
        Me.cboFiltroEstado.TabIndex = 5
        '
        'pnlTabla
        '
        Me.pnlTabla.BackColor = System.Drawing.Color.White
        Me.pnlTabla.Controls.Add(Me.dgvProductos)
        Me.pnlTabla.Controls.Add(Me.lblSinProductos)
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTabla.Location = New System.Drawing.Point(24, 176)
        Me.pnlTabla.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Size = New System.Drawing.Size(704, 504)
        Me.pnlTabla.TabIndex = 2
        '
        'dgvProductos
        '
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.ColumnHeadersHeight = 40
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdProducto, Me.colCodigo, Me.colNombre, Me.colTipo, Me.colMarca, Me.colModelo, Me.colPrecio, Me.colExistencias, Me.colActivo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvProductos.Location = New System.Drawing.Point(0, 0)
        Me.dgvProductos.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.RowTemplate.Height = 36
        Me.dgvProductos.Size = New System.Drawing.Size(704, 504)
        Me.dgvProductos.TabIndex = 0
        '
        'colIdProducto
        '
        Me.colIdProducto.HeaderText = "IdProducto"
        Me.colIdProducto.MinimumWidth = 6
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Width = 90
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.MinimumWidth = 6
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Width = 125
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.MinimumWidth = 6
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Width = 170
        '
        'colTipo
        '
        Me.colTipo.HeaderText = "Tipo"
        Me.colTipo.MinimumWidth = 6
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Width = 90
        '
        'colMarca
        '
        Me.colMarca.HeaderText = "Marca"
        Me.colMarca.MinimumWidth = 6
        Me.colMarca.Name = "colMarca"
        Me.colMarca.Width = 125
        '
        'colModelo
        '
        Me.colModelo.HeaderText = "Modelo"
        Me.colModelo.MinimumWidth = 6
        Me.colModelo.Name = "colModelo"
        Me.colModelo.Width = 125
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.MinimumWidth = 6
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.Width = 90
        '
        'colExistencias
        '
        Me.colExistencias.HeaderText = "Existencias"
        Me.colExistencias.MinimumWidth = 6
        Me.colExistencias.Name = "colExistencias"
        Me.colExistencias.Width = 125
        '
        'colActivo
        '
        Me.colActivo.HeaderText = "Estado"
        Me.colActivo.MinimumWidth = 6
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Width = 90
        '
        'lblSinProductos
        '
        Me.lblSinProductos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblSinProductos.Location = New System.Drawing.Point(80, 190)
        Me.lblSinProductos.Name = "lblSinProductos"
        Me.lblSinProductos.Size = New System.Drawing.Size(330, 28)
        Me.lblSinProductos.TabIndex = 1
        Me.lblSinProductos.Text = "No hay productos para mostrar"
        Me.lblSinProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlVistaPrevia
        '
        Me.pnlVistaPrevia.BackColor = System.Drawing.Color.White
        Me.pnlVistaPrevia.Controls.Add(Me.lblVistaPrevia)
        Me.pnlVistaPrevia.Controls.Add(Me.picProducto)
        Me.pnlVistaPrevia.Controls.Add(Me.lblSinImagen)
        Me.pnlVistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVistaPrevia.Location = New System.Drawing.Point(747, 179)
        Me.pnlVistaPrevia.Name = "pnlVistaPrevia"
        Me.pnlVistaPrevia.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlVistaPrevia.Size = New System.Drawing.Size(234, 498)
        Me.pnlVistaPrevia.TabIndex = 3
        '
        'lblVistaPrevia
        '
        Me.lblVistaPrevia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblVistaPrevia.Location = New System.Drawing.Point(20, 12)
        Me.lblVistaPrevia.Name = "lblVistaPrevia"
        Me.lblVistaPrevia.Size = New System.Drawing.Size(200, 62)
        Me.lblVistaPrevia.TabIndex = 0
        Me.lblVistaPrevia.Text = "Imagen del producto"
        '
        'picProducto
        '
        Me.picProducto.BackColor = System.Drawing.Color.White
        Me.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProducto.Location = New System.Drawing.Point(20, 77)
        Me.picProducto.Name = "picProducto"
        Me.picProducto.Size = New System.Drawing.Size(200, 245)
        Me.picProducto.TabIndex = 1
        Me.picProducto.TabStop = False
        '
        'lblSinImagen
        '
        Me.lblSinImagen.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblSinImagen.Location = New System.Drawing.Point(40, 220)
        Me.lblSinImagen.Name = "lblSinImagen"
        Me.lblSinImagen.Size = New System.Drawing.Size(158, 22)
        Me.lblSinImagen.TabIndex = 2
        Me.lblSinImagen.Text = "Sin imagen"
        Me.lblSinImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcProductos
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "UcProductos"
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.pnlTabla.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVistaPrevia.ResumeLayout(False)
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnNuevoProducto As System.Windows.Forms.Button
    Friend WithEvents btnEditarProducto As System.Windows.Forms.Button
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents txtBuscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents cboFiltroTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cboFiltroEstado As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTabla As System.Windows.Forms.Panel
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents lblSinProductos As System.Windows.Forms.Label
    Friend WithEvents pnlVistaPrevia As System.Windows.Forms.Panel
    Friend WithEvents lblVistaPrevia As System.Windows.Forms.Label
    Friend WithEvents picProducto As System.Windows.Forms.PictureBox
    Friend WithEvents lblSinImagen As System.Windows.Forms.Label
    Friend WithEvents colIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colModelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colExistencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colActivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
