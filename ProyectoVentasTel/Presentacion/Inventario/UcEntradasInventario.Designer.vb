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
        Me.SuspendLayout()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24, 24, 24, 24)
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlCaptura = New System.Windows.Forms.Panel()
        Me.pnlCaptura.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlCaptura.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.tlpCaptura = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.nudCantidad.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblExistenciasActuales = New System.Windows.Forms.Label()
        Me.btnRegistrarEntrada = New System.Windows.Forms.Button()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.dgvEntradas = New System.Windows.Forms.DataGridView()
        Me.dgvEntradas.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.colIdEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinEntradas = New System.Windows.Forms.Label()
        Me.erpEntrada = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.Name = "UcEntradasInventario"
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.RowCount = 4
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Entradas de inventario"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 8)
        Me.lblTitulo.Size = New System.Drawing.Size(500, 32)
        Me.pnlCaptura.Name = "pnlCaptura"
        Me.pnlCaptura.Visible = True
        Me.pnlCaptura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCaptura.Name = "tlpCaptura"
        Me.tlpCaptura.Visible = True
        Me.tlpCaptura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCaptura.ColumnCount = 3
        Me.tlpCaptura.RowCount = 4
        Me.tlpCaptura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpCaptura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpCaptura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpCaptura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Visible = True
        Me.lblProducto.Text = "Producto"
        Me.lblProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Visible = True
        Me.lblCantidad.Text = "Cantidad recibida"
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Visible = True
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Visible = True
        Me.cboProducto.Size = New System.Drawing.Size(300, 38)
        Me.cboProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Visible = True
        Me.nudCantidad.Size = New System.Drawing.Size(140, 38)
        Me.nudCantidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Visible = True
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Multiline = True
        Me.lblExistenciasActuales.Name = "lblExistenciasActuales"
        Me.lblExistenciasActuales.Visible = True
        Me.lblExistenciasActuales.Text = "Existencias actuales: —"
        Me.lblExistenciasActuales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRegistrarEntrada.Name = "btnRegistrarEntrada"
        Me.btnRegistrarEntrada.Visible = True
        Me.btnRegistrarEntrada.Text = "Registrar entrada"
        Me.btnRegistrarEntrada.Size = New System.Drawing.Size(160, 40)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Visible = True
        Me.lblHistorial.Text = "Entradas registradas"
        Me.lblHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Visible = True
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntradas.Name = "dgvEntradas"
        Me.dgvEntradas.Visible = True
        Me.dgvEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntradas.ColumnHeadersHeight = 40
        Me.dgvEntradas.RowTemplate.Height = 36
        Me.colIdEntrada.Name = "colIdEntrada"
        Me.colIdEntrada.HeaderText = "IdEntrada"
        Me.colIdEntrada.Visible = True
        Me.colIdEntrada.Width = 90
        Me.colFechaEntrada.Name = "colFechaEntrada"
        Me.colFechaEntrada.HeaderText = "Fecha"
        Me.colFechaEntrada.Visible = True
        Me.colFechaEntrada.Width = 135
        Me.colCodigoProducto.Name = "colCodigoProducto"
        Me.colCodigoProducto.HeaderText = "Código"
        Me.colCodigoProducto.Visible = True
        Me.colCodigoProducto.Width = 100
        Me.colNombreProducto.Name = "colNombreProducto"
        Me.colNombreProducto.HeaderText = "Producto"
        Me.colNombreProducto.Visible = True
        Me.colNombreProducto.Width = 180
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.Width = 90
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.HeaderText = "Registró"
        Me.colUsuario.Visible = True
        Me.colUsuario.Width = 130
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.HeaderText = "Observaciones"
        Me.colObservaciones.Visible = True
        Me.colObservaciones.Width = 180
        Me.dgvEntradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdEntrada, Me.colFechaEntrada, Me.colCodigoProducto, Me.colNombreProducto, Me.colCantidad, Me.colUsuario, Me.colObservaciones})
        Me.lblSinEntradas.Name = "lblSinEntradas"
        Me.lblSinEntradas.Visible = True
        Me.lblSinEntradas.Text = "No hay entradas para mostrar"
        Me.lblSinEntradas.Location = New System.Drawing.Point(310, 150)
        Me.lblSinEntradas.Size = New System.Drawing.Size(350, 28)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.tlpRaiz.Controls.Add(Me.pnlCaptura, 0, 1)
        Me.pnlCaptura.Controls.Add(Me.tlpCaptura)
        Me.tlpCaptura.Controls.Add(Me.lblProducto, 0, 0)
        Me.tlpCaptura.Controls.Add(Me.lblCantidad, 1, 0)
        Me.tlpCaptura.Controls.Add(Me.lblObservaciones, 2, 0)
        Me.tlpCaptura.Controls.Add(Me.cboProducto, 0, 1)
        Me.tlpCaptura.Controls.Add(Me.nudCantidad, 1, 1)
        Me.tlpCaptura.Controls.Add(Me.txtObservaciones, 2, 1)
        Me.tlpCaptura.SetRowSpan(Me.txtObservaciones, 2)
        Me.tlpCaptura.Controls.Add(Me.lblExistenciasActuales, 0, 2)
        Me.tlpCaptura.Controls.Add(Me.btnRegistrarEntrada, 2, 3)
        Me.tlpRaiz.Controls.Add(Me.lblHistorial, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 3)
        Me.pnlTabla.Controls.Add(Me.dgvEntradas)
        Me.pnlTabla.Controls.Add(Me.lblSinEntradas)
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
