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
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.colIdVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEfectivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinVentas = New System.Windows.Forms.Label()
        Me.btnVerDetalle = New System.Windows.Forms.Button()
        Me.tlpRaiz.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        Me.pnlTabla.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.pnlFiltros, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.btnVerDetalle, 0, 3)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 4
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.White
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEncabezado.Location = New System.Drawing.Point(24, 24)
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(960, 44)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(500, 40)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Historial de ventas"
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.White
        Me.pnlFiltros.Controls.Add(Me.lblDesde)
        Me.pnlFiltros.Controls.Add(Me.lblHasta)
        Me.pnlFiltros.Controls.Add(Me.lblEstado)
        Me.pnlFiltros.Controls.Add(Me.dtpDesde)
        Me.pnlFiltros.Controls.Add(Me.dtpHasta)
        Me.pnlFiltros.Controls.Add(Me.cboEstado)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFiltros.Location = New System.Drawing.Point(24, 84)
        Me.pnlFiltros.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFiltros.Size = New System.Drawing.Size(960, 76)
        Me.pnlFiltros.TabIndex = 1
        '
        'lblDesde
        '
        Me.lblDesde.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(20, 8)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(220, 22)
        Me.lblDesde.TabIndex = 0
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(252, 8)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(220, 22)
        Me.lblHasta.TabIndex = 1
        Me.lblHasta.Text = "Hasta"
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(484, 8)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(220, 22)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Estado"
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Location = New System.Drawing.Point(20, 34)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(220, 31)
        Me.dtpDesde.TabIndex = 3
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Location = New System.Drawing.Point(252, 34)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(220, 31)
        Me.dtpHasta.TabIndex = 4
        '
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.Color.White
        Me.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEstado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.Color.Black
        Me.cboEstado.Items.AddRange(New Object() {"Todas", "Confirmadas", "Canceladas"})
        Me.cboEstado.Location = New System.Drawing.Point(484, 34)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(220, 33)
        Me.cboEstado.TabIndex = 5
        '
        'pnlTabla
        '
        Me.pnlTabla.BackColor = System.Drawing.Color.White
        Me.pnlTabla.Controls.Add(Me.dgvVentas)
        Me.pnlTabla.Controls.Add(Me.lblSinVentas)
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTabla.Location = New System.Drawing.Point(27, 179)
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Size = New System.Drawing.Size(954, 442)
        Me.pnlTabla.TabIndex = 2
        '
        'dgvVentas
        '
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvVentas.ColumnHeadersHeight = 40
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdVenta, Me.colFolio, Me.colFecha, Me.colVendedor, Me.colTotal, Me.colEfectivo, Me.colEstado})
        Me.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvVentas.Location = New System.Drawing.Point(0, 0)
        Me.dgvVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.Height = 36
        Me.dgvVentas.Size = New System.Drawing.Size(954, 442)
        Me.dgvVentas.TabIndex = 0
        '
        'colIdVenta
        '
        Me.colIdVenta.HeaderText = "IdVenta"
        Me.colIdVenta.MinimumWidth = 6
        Me.colIdVenta.Name = "colIdVenta"
        Me.colIdVenta.Width = 90
        '
        'colFolio
        '
        Me.colFolio.HeaderText = "Folio"
        Me.colFolio.MinimumWidth = 6
        Me.colFolio.Name = "colFolio"
        Me.colFolio.Width = 145
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.MinimumWidth = 6
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Width = 155
        '
        'colVendedor
        '
        Me.colVendedor.HeaderText = "Vendedor"
        Me.colVendedor.MinimumWidth = 6
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.Width = 165
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.MinimumWidth = 6
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Width = 130
        '
        'colEfectivo
        '
        Me.colEfectivo.HeaderText = "Efectivo"
        Me.colEfectivo.MinimumWidth = 6
        Me.colEfectivo.Name = "colEfectivo"
        Me.colEfectivo.Width = 130
        '
        'colEstado
        '
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.MinimumWidth = 6
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Width = 120
        '
        'lblSinVentas
        '
        Me.lblSinVentas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblSinVentas.Location = New System.Drawing.Point(320, 175)
        Me.lblSinVentas.Name = "lblSinVentas"
        Me.lblSinVentas.Size = New System.Drawing.Size(320, 28)
        Me.lblSinVentas.TabIndex = 1
        Me.lblSinVentas.Text = "No hay ventas para mostrar"
        Me.lblSinVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerDetalle
        '
        Me.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnVerDetalle.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVerDetalle.FlatAppearance.BorderSize = 0
        Me.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerDetalle.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnVerDetalle.Location = New System.Drawing.Point(856, 632)
        Me.btnVerDetalle.Margin = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.btnVerDetalle.Name = "btnVerDetalle"
        Me.btnVerDetalle.Size = New System.Drawing.Size(128, 40)
        Me.btnVerDetalle.TabIndex = 3
        Me.btnVerDetalle.Text = "Ver detalle"
        Me.btnVerDetalle.UseVisualStyleBackColor = False
        '
        'UcHistorialVentas
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "UcHistorialVentas"
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlTabla.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
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
