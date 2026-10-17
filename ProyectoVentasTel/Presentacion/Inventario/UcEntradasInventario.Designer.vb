<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcEntradasInventario
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
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlCaptura = New System.Windows.Forms.Panel()
        Me.tlpCaptura = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblExistenciasActuales = New System.Windows.Forms.Label()
        Me.btnRegistrarEntrada = New System.Windows.Forms.Button()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.dgvEntradas = New System.Windows.Forms.DataGridView()
        Me.colIdEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinEntradas = New System.Windows.Forms.Label()
        Me.erpEntrada = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tlpRaiz.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlCaptura.SuspendLayout()
        Me.tlpCaptura.SuspendLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTabla.SuspendLayout()
        CType(Me.dgvEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.pnlCaptura, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.lblHistorial, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 3)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 4
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Location = New System.Drawing.Point(24, 24)
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(960, 44)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(500, 36)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Entradas de inventario"
        '
        'pnlCaptura
        '
        Me.pnlCaptura.BackColor = System.Drawing.Color.White
        Me.pnlCaptura.Controls.Add(Me.tlpCaptura)
        Me.pnlCaptura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCaptura.Location = New System.Drawing.Point(24, 84)
        Me.pnlCaptura.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlCaptura.Name = "pnlCaptura"
        Me.pnlCaptura.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlCaptura.Size = New System.Drawing.Size(960, 184)
        Me.pnlCaptura.TabIndex = 1
        '
        'tlpCaptura
        '
        Me.tlpCaptura.ColumnCount = 3
        Me.tlpCaptura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpCaptura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpCaptura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpCaptura.Controls.Add(Me.lblProducto, 0, 0)
        Me.tlpCaptura.Controls.Add(Me.lblCantidad, 1, 0)
        Me.tlpCaptura.Controls.Add(Me.lblObservaciones, 2, 0)
        Me.tlpCaptura.Controls.Add(Me.cboProducto, 0, 1)
        Me.tlpCaptura.Controls.Add(Me.nudCantidad, 1, 1)
        Me.tlpCaptura.Controls.Add(Me.txtObservaciones, 2, 1)
        Me.tlpCaptura.Controls.Add(Me.lblExistenciasActuales, 0, 2)
        Me.tlpCaptura.Controls.Add(Me.btnRegistrarEntrada, 2, 3)
        Me.tlpCaptura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCaptura.Location = New System.Drawing.Point(20, 20)
        Me.tlpCaptura.Name = "tlpCaptura"
        Me.tlpCaptura.RowCount = 4
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCaptura.Size = New System.Drawing.Size(920, 144)
        Me.tlpCaptura.TabIndex = 0
        '
        'lblProducto
        '
        Me.lblProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducto.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblProducto.Location = New System.Drawing.Point(3, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(362, 26)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto"
        '
        'lblCantidad
        '
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCantidad.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(371, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(178, 26)
        Me.lblCantidad.TabIndex = 1
        Me.lblCantidad.Text = "Cantidad recibida"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblObservaciones.Location = New System.Drawing.Point(555, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(362, 26)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        '
        'cboProducto
        '
        Me.cboProducto.BackColor = System.Drawing.Color.White
        Me.cboProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboProducto.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboProducto.Location = New System.Drawing.Point(0, 26)
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(356, 33)
        Me.cboProducto.TabIndex = 3
        '
        'nudCantidad
        '
        Me.nudCantidad.BackColor = System.Drawing.Color.White
        Me.nudCantidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudCantidad.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.nudCantidad.Location = New System.Drawing.Point(368, 26)
        Me.nudCantidad.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(172, 31)
        Me.nudCantidad.TabIndex = 4
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(555, 29)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.tlpCaptura.SetRowSpan(Me.txtObservaciones, 2)
        Me.txtObservaciones.Size = New System.Drawing.Size(362, 78)
        Me.txtObservaciones.TabIndex = 5
        '
        'lblExistenciasActuales
        '
        Me.lblExistenciasActuales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExistenciasActuales.Location = New System.Drawing.Point(3, 74)
        Me.lblExistenciasActuales.Name = "lblExistenciasActuales"
        Me.lblExistenciasActuales.Size = New System.Drawing.Size(362, 36)
        Me.lblExistenciasActuales.TabIndex = 6
        Me.lblExistenciasActuales.Text = "Existencias actuales: —"
        '
        'btnRegistrarEntrada
        '
        Me.btnRegistrarEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRegistrarEntrada.FlatAppearance.BorderSize = 0
        Me.btnRegistrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarEntrada.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEntrada.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarEntrada.Location = New System.Drawing.Point(555, 113)
        Me.btnRegistrarEntrada.Name = "btnRegistrarEntrada"
        Me.btnRegistrarEntrada.Size = New System.Drawing.Size(160, 28)
        Me.btnRegistrarEntrada.TabIndex = 7
        Me.btnRegistrarEntrada.Text = "Registrar entrada"
        Me.btnRegistrarEntrada.UseVisualStyleBackColor = False
        '
        'lblHistorial
        '
        Me.lblHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHistorial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblHistorial.Location = New System.Drawing.Point(27, 284)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(954, 42)
        Me.lblHistorial.TabIndex = 2
        Me.lblHistorial.Text = "Entradas registradas"
        '
        'pnlTabla
        '
        Me.pnlTabla.Controls.Add(Me.dgvEntradas)
        Me.pnlTabla.Controls.Add(Me.lblSinEntradas)
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTabla.Location = New System.Drawing.Point(27, 329)
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Size = New System.Drawing.Size(954, 348)
        Me.pnlTabla.TabIndex = 3
        '
        'dgvEntradas
        '
        Me.dgvEntradas.BackgroundColor = System.Drawing.Color.White
        Me.dgvEntradas.ColumnHeadersHeight = 40
        Me.dgvEntradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdEntrada, Me.colFechaEntrada, Me.colCodigoProducto, Me.colNombreProducto, Me.colCantidad, Me.colUsuario, Me.colObservaciones})
        Me.dgvEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntradas.GridColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvEntradas.Location = New System.Drawing.Point(0, 0)
        Me.dgvEntradas.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvEntradas.Name = "dgvEntradas"
        Me.dgvEntradas.RowHeadersWidth = 51
        Me.dgvEntradas.RowTemplate.Height = 36
        Me.dgvEntradas.Size = New System.Drawing.Size(954, 348)
        Me.dgvEntradas.TabIndex = 0
        '
        'colIdEntrada
        '
        Me.colIdEntrada.HeaderText = "IdEntrada"
        Me.colIdEntrada.MinimumWidth = 6
        Me.colIdEntrada.Name = "colIdEntrada"
        Me.colIdEntrada.Width = 90
        '
        'colFechaEntrada
        '
        Me.colFechaEntrada.HeaderText = "Fecha"
        Me.colFechaEntrada.MinimumWidth = 6
        Me.colFechaEntrada.Name = "colFechaEntrada"
        Me.colFechaEntrada.Width = 135
        '
        'colCodigoProducto
        '
        Me.colCodigoProducto.HeaderText = "Código"
        Me.colCodigoProducto.MinimumWidth = 6
        Me.colCodigoProducto.Name = "colCodigoProducto"
        '
        'colNombreProducto
        '
        Me.colNombreProducto.HeaderText = "Producto"
        Me.colNombreProducto.MinimumWidth = 6
        Me.colNombreProducto.Name = "colNombreProducto"
        Me.colNombreProducto.Width = 180
        '
        'colCantidad
        '
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.MinimumWidth = 6
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Width = 90
        '
        'colUsuario
        '
        Me.colUsuario.HeaderText = "Registró"
        Me.colUsuario.MinimumWidth = 6
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Width = 130
        '
        'colObservaciones
        '
        Me.colObservaciones.HeaderText = "Observaciones"
        Me.colObservaciones.MinimumWidth = 6
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Width = 180
        '
        'lblSinEntradas
        '
        Me.lblSinEntradas.Location = New System.Drawing.Point(310, 150)
        Me.lblSinEntradas.Name = "lblSinEntradas"
        Me.lblSinEntradas.Size = New System.Drawing.Size(350, 28)
        Me.lblSinEntradas.TabIndex = 1
        Me.lblSinEntradas.Text = "No hay entradas para mostrar"
        '
        'erpEntrada
        '
        Me.erpEntrada.ContainerControl = Me
        '
        'UcEntradasInventario
        '
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "UcEntradasInventario"
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlCaptura.ResumeLayout(False)
        Me.tlpCaptura.ResumeLayout(False)
        Me.tlpCaptura.PerformLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTabla.ResumeLayout(False)
        CType(Me.dgvEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlCaptura As System.Windows.Forms.Panel
    Friend WithEvents tlpCaptura As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents cboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblExistenciasActuales As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarEntrada As System.Windows.Forms.Button
    Friend WithEvents lblHistorial As System.Windows.Forms.Label
    Friend WithEvents pnlTabla As System.Windows.Forms.Panel
    Friend WithEvents dgvEntradas As System.Windows.Forms.DataGridView
    Friend WithEvents lblSinEntradas As System.Windows.Forms.Label
    Friend WithEvents erpEntrada As System.Windows.Forms.ErrorProvider
    Friend WithEvents colIdEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
