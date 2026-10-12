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
        Me.components = New System.ComponentModel.Container()
        Me.SuspendLayout()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24, 24, 24, 24)
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnNuevoProducto = New System.Windows.Forms.Button()
        Me.btnEditarProducto = New System.Windows.Forms.Button()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.pnlFiltros.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlFiltros.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.cboFiltroTipo = New System.Windows.Forms.ComboBox()
        Me.cboFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.pnlTabla.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvProductos.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
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
        Me.pnlVistaPrevia.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblVistaPrevia = New System.Windows.Forms.Label()
        Me.picProducto = New System.Windows.Forms.PictureBox()
        Me.lblSinImagen = New System.Windows.Forms.Label()
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.Name = "UcProductos"
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Productos y existencias"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 8)
        Me.lblTitulo.Size = New System.Drawing.Size(430, 32)
        Me.btnNuevoProducto.Name = "btnNuevoProducto"
        Me.btnNuevoProducto.Visible = True
        Me.btnNuevoProducto.Text = "Nuevo producto"
        Me.btnNuevoProducto.Location = New System.Drawing.Point(430, 0)
        Me.btnNuevoProducto.Size = New System.Drawing.Size(144, 40)
        Me.btnEditarProducto.Name = "btnEditarProducto"
        Me.btnEditarProducto.Visible = True
        Me.btnEditarProducto.Text = "Editar producto"
        Me.btnEditarProducto.Location = New System.Drawing.Point(586, 0)
        Me.btnEditarProducto.Size = New System.Drawing.Size(144, 40)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Visible = True
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Visible = True
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Location = New System.Drawing.Point(20, 8)
        Me.lblBuscar.Size = New System.Drawing.Size(280, 22)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Visible = True
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.Location = New System.Drawing.Point(312, 8)
        Me.lblTipo.Size = New System.Drawing.Size(180, 22)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Visible = True
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.Location = New System.Drawing.Point(504, 8)
        Me.lblEstado.Size = New System.Drawing.Size(180, 22)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Visible = True
        Me.txtBuscarProducto.Location = New System.Drawing.Point(20, 34)
        Me.txtBuscarProducto.Size = New System.Drawing.Size(280, 38)
        Me.cboFiltroTipo.Name = "cboFiltroTipo"
        Me.cboFiltroTipo.Visible = True
        Me.cboFiltroTipo.Location = New System.Drawing.Point(312, 34)
        Me.cboFiltroTipo.Size = New System.Drawing.Size(180, 38)
        Me.cboFiltroEstado.Name = "cboFiltroEstado"
        Me.cboFiltroEstado.Visible = True
        Me.cboFiltroEstado.Location = New System.Drawing.Point(504, 34)
        Me.cboFiltroEstado.Size = New System.Drawing.Size(180, 38)
        Me.cboFiltroTipo.Items.AddRange(New Object() {"Todos", "Teléfono", "Accesorio"})
        Me.cboFiltroEstado.Items.AddRange(New Object() {"Todos", "Activos", "Inactivos"})
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Visible = True
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Visible = True
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.ColumnHeadersHeight = 40
        Me.dgvProductos.RowTemplate.Height = 36
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.HeaderText = "IdProducto"
        Me.colIdProducto.Visible = True
        Me.colIdProducto.Width = 90
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 100
        Me.colNombre.Name = "colNombre"
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Visible = True
        Me.colNombre.Width = 170
        Me.colTipo.Name = "colTipo"
        Me.colTipo.HeaderText = "Tipo"
        Me.colTipo.Visible = True
        Me.colTipo.Width = 90
        Me.colMarca.Name = "colMarca"
        Me.colMarca.HeaderText = "Marca"
        Me.colMarca.Visible = True
        Me.colMarca.Width = 100
        Me.colModelo.Name = "colModelo"
        Me.colModelo.HeaderText = "Modelo"
        Me.colModelo.Visible = True
        Me.colModelo.Width = 100
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Visible = True
        Me.colPrecio.Width = 90
        Me.colExistencias.Name = "colExistencias"
        Me.colExistencias.HeaderText = "Existencias"
        Me.colExistencias.Visible = True
        Me.colExistencias.Width = 100
        Me.colActivo.Name = "colActivo"
        Me.colActivo.HeaderText = "Estado"
        Me.colActivo.Visible = True
        Me.colActivo.Width = 90
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdProducto, Me.colCodigo, Me.colNombre, Me.colTipo, Me.colMarca, Me.colModelo, Me.colPrecio, Me.colExistencias, Me.colActivo})
        Me.lblSinProductos.Name = "lblSinProductos"
        Me.lblSinProductos.Visible = True
        Me.lblSinProductos.Text = "No hay productos para mostrar"
        Me.lblSinProductos.Location = New System.Drawing.Point(80, 190)
        Me.lblSinProductos.Size = New System.Drawing.Size(330, 28)
        Me.pnlVistaPrevia.Name = "pnlVistaPrevia"
        Me.pnlVistaPrevia.Visible = True
        Me.pnlVistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVistaPrevia.Name = "lblVistaPrevia"
        Me.lblVistaPrevia.Visible = True
        Me.lblVistaPrevia.Text = "Imagen del producto"
        Me.lblVistaPrevia.Location = New System.Drawing.Point(20, 12)
        Me.lblVistaPrevia.Size = New System.Drawing.Size(200, 26)
        Me.picProducto.Name = "picProducto"
        Me.picProducto.Visible = True
        Me.picProducto.Location = New System.Drawing.Point(20, 48)
        Me.picProducto.Size = New System.Drawing.Size(200, 245)
        Me.lblSinImagen.Name = "lblSinImagen"
        Me.lblSinImagen.Visible = True
        Me.lblSinImagen.Text = "Sin imagen"
        Me.lblSinImagen.Location = New System.Drawing.Point(70, 220)
        Me.lblSinImagen.Size = New System.Drawing.Size(120, 22)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 2)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.btnNuevoProducto)
        Me.pnlEncabezado.Controls.Add(Me.btnEditarProducto)
        Me.tlpRaiz.Controls.Add(Me.pnlFiltros, 0, 1)
        Me.tlpRaiz.SetColumnSpan(Me.pnlFiltros, 2)
        Me.pnlFiltros.Controls.Add(Me.lblBuscar)
        Me.pnlFiltros.Controls.Add(Me.lblTipo)
        Me.pnlFiltros.Controls.Add(Me.lblEstado)
        Me.pnlFiltros.Controls.Add(Me.txtBuscarProducto)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroTipo)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroEstado)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 2)
        Me.pnlTabla.Controls.Add(Me.dgvProductos)
        Me.pnlTabla.Controls.Add(Me.lblSinProductos)
        Me.tlpRaiz.Controls.Add(Me.pnlVistaPrevia, 1, 2)
        Me.pnlVistaPrevia.Controls.Add(Me.lblVistaPrevia)
        Me.pnlVistaPrevia.Controls.Add(Me.picProducto)
        Me.pnlVistaPrevia.Controls.Add(Me.lblSinImagen)
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
