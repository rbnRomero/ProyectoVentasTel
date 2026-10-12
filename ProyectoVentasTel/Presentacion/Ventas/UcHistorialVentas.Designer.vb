<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcHistorialVentas
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
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.pnlFiltros.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlFiltros.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.dgvVentas.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.colIdVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEfectivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinVentas = New System.Windows.Forms.Label()
        Me.btnVerDetalle = New System.Windows.Forms.Button()
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.Name = "UcHistorialVentas"
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.RowCount = 4
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Historial de ventas"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 8)
        Me.lblTitulo.Size = New System.Drawing.Size(500, 32)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Visible = True
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Visible = True
        Me.lblDesde.Text = "Desde"
        Me.lblDesde.Location = New System.Drawing.Point(20, 8)
        Me.lblDesde.Size = New System.Drawing.Size(220, 22)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Visible = True
        Me.lblHasta.Text = "Hasta"
        Me.lblHasta.Location = New System.Drawing.Point(252, 8)
        Me.lblHasta.Size = New System.Drawing.Size(220, 22)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Visible = True
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.Location = New System.Drawing.Point(484, 8)
        Me.lblEstado.Size = New System.Drawing.Size(220, 22)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Visible = True
        Me.dtpDesde.Location = New System.Drawing.Point(20, 34)
        Me.dtpDesde.Size = New System.Drawing.Size(220, 38)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Visible = True
        Me.dtpHasta.Location = New System.Drawing.Point(252, 34)
        Me.dtpHasta.Size = New System.Drawing.Size(220, 38)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Visible = True
        Me.cboEstado.Location = New System.Drawing.Point(484, 34)
        Me.cboEstado.Size = New System.Drawing.Size(220, 38)
        Me.cboEstado.Items.AddRange(New Object() {"Todas", "Confirmadas", "Canceladas"})
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Visible = True
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Visible = True
        Me.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVentas.ColumnHeadersHeight = 40
        Me.dgvVentas.RowTemplate.Height = 36
        Me.colIdVenta.Name = "colIdVenta"
        Me.colIdVenta.HeaderText = "IdVenta"
        Me.colIdVenta.Visible = True
        Me.colIdVenta.Width = 90
        Me.colFolio.Name = "colFolio"
        Me.colFolio.HeaderText = "Folio"
        Me.colFolio.Visible = True
        Me.colFolio.Width = 145
        Me.colFecha.Name = "colFecha"
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Visible = True
        Me.colFecha.Width = 155
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.HeaderText = "Vendedor"
        Me.colVendedor.Visible = True
        Me.colVendedor.Width = 165
        Me.colTotal.Name = "colTotal"
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Visible = True
        Me.colTotal.Width = 130
        Me.colEfectivo.Name = "colEfectivo"
        Me.colEfectivo.HeaderText = "Efectivo"
        Me.colEfectivo.Visible = True
        Me.colEfectivo.Width = 130
        Me.colEstado.Name = "colEstado"
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Visible = True
        Me.colEstado.Width = 120
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdVenta, Me.colFolio, Me.colFecha, Me.colVendedor, Me.colTotal, Me.colEfectivo, Me.colEstado})
        Me.lblSinVentas.Name = "lblSinVentas"
        Me.lblSinVentas.Visible = True
        Me.lblSinVentas.Text = "No hay ventas para mostrar"
        Me.lblSinVentas.Location = New System.Drawing.Point(320, 175)
        Me.lblSinVentas.Size = New System.Drawing.Size(320, 28)
        Me.btnVerDetalle.Name = "btnVerDetalle"
        Me.btnVerDetalle.Visible = True
        Me.btnVerDetalle.Text = "Ver detalle"
        Me.btnVerDetalle.Size = New System.Drawing.Size(128, 40)
        Me.btnVerDetalle.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVerDetalle.Margin = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.tlpRaiz.Controls.Add(Me.pnlFiltros, 0, 1)
        Me.pnlFiltros.Controls.Add(Me.lblDesde)
        Me.pnlFiltros.Controls.Add(Me.lblHasta)
        Me.pnlFiltros.Controls.Add(Me.lblEstado)
        Me.pnlFiltros.Controls.Add(Me.dtpDesde)
        Me.pnlFiltros.Controls.Add(Me.dtpHasta)
        Me.pnlFiltros.Controls.Add(Me.cboEstado)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 2)
        Me.pnlTabla.Controls.Add(Me.dgvVentas)
        Me.pnlTabla.Controls.Add(Me.lblSinVentas)
        Me.tlpRaiz.Controls.Add(Me.btnVerDetalle, 0, 3)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTabla As System.Windows.Forms.Panel
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
    Friend WithEvents lblSinVentas As System.Windows.Forms.Label
    Friend WithEvents btnVerDetalle As System.Windows.Forms.Button
    Friend WithEvents colIdVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEfectivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
