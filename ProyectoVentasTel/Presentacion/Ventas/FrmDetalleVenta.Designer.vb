<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetalleVenta
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
        Me.SuspendLayout()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24, 24, 24, 24)
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFolioValor = New System.Windows.Forms.Label()
        Me.lblFechaValor = New System.Windows.Forms.Label()
        Me.lblVendedorValor = New System.Windows.Forms.Label()
        Me.lblEstadoValor = New System.Windows.Forms.Label()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.dgvArticulos.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.colArticuloIdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlResumen = New System.Windows.Forms.Panel()
        Me.pnlResumen.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.lblTotalValor = New System.Windows.Forms.Label()
        Me.lblEfectivoValor = New System.Windows.Forms.Label()
        Me.lblCambioValor = New System.Windows.Forms.Label()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.pnlCapturaCancelacion = New System.Windows.Forms.Panel()
        Me.pnlCapturaCancelacion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlCapturaCancelacion.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblMotivoCancelacion = New System.Windows.Forms.Label()
        Me.txtMotivoCancelacion = New System.Windows.Forms.TextBox()
        Me.btnConfirmarCancelacion = New System.Windows.Forms.Button()
        Me.btnDescartarCancelacion = New System.Windows.Forms.Button()
        Me.pnlDatosCancelacion = New System.Windows.Forms.Panel()
        Me.pnlDatosCancelacion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlDatosCancelacion.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblFechaCancelacionValor = New System.Windows.Forms.Label()
        Me.lblUsuarioCancelaValor = New System.Windows.Forms.Label()
        Me.lblMotivoCancelacionValor = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.erpCancelacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Size = New System.Drawing.Size(900, 700)
        Me.Name = "FrmDetalleVenta"
        Me.Text = "Detalle de venta"
        Me.AutoScroll = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Size = New System.Drawing.Size(900, 834)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpRaiz.AutoSize = True
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.RowCount = 7
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Detalle de venta"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Size = New System.Drawing.Size(450, 32)
        Me.lblFolioValor.Name = "lblFolioValor"
        Me.lblFolioValor.Visible = True
        Me.lblFolioValor.Text = "—"
        Me.lblFolioValor.Location = New System.Drawing.Point(0, 42)
        Me.lblFolioValor.Size = New System.Drawing.Size(170, 28)
        Me.lblFechaValor.Name = "lblFechaValor"
        Me.lblFechaValor.Visible = True
        Me.lblFechaValor.Text = "—"
        Me.lblFechaValor.Location = New System.Drawing.Point(180, 42)
        Me.lblFechaValor.Size = New System.Drawing.Size(170, 28)
        Me.lblVendedorValor.Name = "lblVendedorValor"
        Me.lblVendedorValor.Visible = True
        Me.lblVendedorValor.Text = "—"
        Me.lblVendedorValor.Location = New System.Drawing.Point(360, 42)
        Me.lblVendedorValor.Size = New System.Drawing.Size(170, 28)
        Me.lblEstadoValor.Name = "lblEstadoValor"
        Me.lblEstadoValor.Visible = True
        Me.lblEstadoValor.Text = "—"
        Me.lblEstadoValor.Location = New System.Drawing.Point(620, 42)
        Me.lblEstadoValor.Size = New System.Drawing.Size(170, 28)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.Visible = True
        Me.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvArticulos.ColumnHeadersHeight = 40
        Me.dgvArticulos.RowTemplate.Height = 36
        Me.colArticuloIdDetalle.Name = "colArticuloIdDetalle"
        Me.colArticuloIdDetalle.HeaderText = "IdDetalle"
        Me.colArticuloIdDetalle.Visible = True
        Me.colArticuloIdDetalle.Width = 90
        Me.colArticuloCodigo.Name = "colArticuloCodigo"
        Me.colArticuloCodigo.HeaderText = "Código"
        Me.colArticuloCodigo.Visible = True
        Me.colArticuloCodigo.Width = 130
        Me.colArticuloNombre.Name = "colArticuloNombre"
        Me.colArticuloNombre.HeaderText = "Producto"
        Me.colArticuloNombre.Visible = True
        Me.colArticuloNombre.Width = 280
        Me.colArticuloCantidad.Name = "colArticuloCantidad"
        Me.colArticuloCantidad.HeaderText = "Cantidad"
        Me.colArticuloCantidad.Visible = True
        Me.colArticuloCantidad.Width = 110
        Me.colArticuloPrecio.Name = "colArticuloPrecio"
        Me.colArticuloPrecio.HeaderText = "Precio"
        Me.colArticuloPrecio.Visible = True
        Me.colArticuloPrecio.Width = 120
        Me.colArticuloSubtotal.Name = "colArticuloSubtotal"
        Me.colArticuloSubtotal.HeaderText = "Subtotal"
        Me.colArticuloSubtotal.Visible = True
        Me.colArticuloSubtotal.Width = 130
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colArticuloIdDetalle, Me.colArticuloCodigo, Me.colArticuloNombre, Me.colArticuloCantidad, Me.colArticuloPrecio, Me.colArticuloSubtotal})
        Me.pnlResumen.Name = "pnlResumen"
        Me.pnlResumen.Visible = True
        Me.pnlResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalValor.Name = "lblTotalValor"
        Me.lblTotalValor.Visible = True
        Me.lblTotalValor.Text = "—"
        Me.lblTotalValor.Location = New System.Drawing.Point(20, 20)
        Me.lblTotalValor.Size = New System.Drawing.Size(220, 32)
        Me.lblEfectivoValor.Name = "lblEfectivoValor"
        Me.lblEfectivoValor.Visible = True
        Me.lblEfectivoValor.Text = "—"
        Me.lblEfectivoValor.Location = New System.Drawing.Point(300, 20)
        Me.lblEfectivoValor.Size = New System.Drawing.Size(220, 32)
        Me.lblCambioValor.Name = "lblCambioValor"
        Me.lblCambioValor.Visible = True
        Me.lblCambioValor.Text = "—"
        Me.lblCambioValor.Location = New System.Drawing.Point(580, 20)
        Me.lblCambioValor.Size = New System.Drawing.Size(220, 32)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Visible = True
        Me.btnCancelarVenta.Text = "Cancelar venta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(144, 40)
        Me.pnlCapturaCancelacion.Name = "pnlCapturaCancelacion"
        Me.pnlCapturaCancelacion.Visible = True
        Me.pnlCapturaCancelacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMotivoCancelacion.Name = "lblMotivoCancelacion"
        Me.lblMotivoCancelacion.Visible = True
        Me.lblMotivoCancelacion.Text = "Motivo de cancelación"
        Me.lblMotivoCancelacion.Location = New System.Drawing.Point(20, 6)
        Me.lblMotivoCancelacion.Size = New System.Drawing.Size(400, 22)
        Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
        Me.txtMotivoCancelacion.Visible = True
        Me.txtMotivoCancelacion.Location = New System.Drawing.Point(20, 32)
        Me.txtMotivoCancelacion.Size = New System.Drawing.Size(790, 58)
        Me.txtMotivoCancelacion.Multiline = True
        Me.btnConfirmarCancelacion.Name = "btnConfirmarCancelacion"
        Me.btnConfirmarCancelacion.Visible = True
        Me.btnConfirmarCancelacion.Text = "Confirmar cancelación"
        Me.btnConfirmarCancelacion.Location = New System.Drawing.Point(20, 98)
        Me.btnConfirmarCancelacion.Size = New System.Drawing.Size(180, 40)
        Me.btnDescartarCancelacion.Name = "btnDescartarCancelacion"
        Me.btnDescartarCancelacion.Visible = True
        Me.btnDescartarCancelacion.Text = "Volver"
        Me.btnDescartarCancelacion.Location = New System.Drawing.Point(212, 98)
        Me.btnDescartarCancelacion.Size = New System.Drawing.Size(112, 40)
        Me.pnlDatosCancelacion.Name = "pnlDatosCancelacion"
        Me.pnlDatosCancelacion.Visible = True
        Me.pnlDatosCancelacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaCancelacionValor.Name = "lblFechaCancelacionValor"
        Me.lblFechaCancelacionValor.Visible = True
        Me.lblFechaCancelacionValor.Text = "—"
        Me.lblFechaCancelacionValor.Location = New System.Drawing.Point(20, 10)
        Me.lblFechaCancelacionValor.Size = New System.Drawing.Size(240, 26)
        Me.lblUsuarioCancelaValor.Name = "lblUsuarioCancelaValor"
        Me.lblUsuarioCancelaValor.Visible = True
        Me.lblUsuarioCancelaValor.Text = "—"
        Me.lblUsuarioCancelaValor.Location = New System.Drawing.Point(286, 10)
        Me.lblUsuarioCancelaValor.Size = New System.Drawing.Size(240, 26)
        Me.lblMotivoCancelacionValor.Name = "lblMotivoCancelacionValor"
        Me.lblMotivoCancelacionValor.Visible = True
        Me.lblMotivoCancelacionValor.Text = "—"
        Me.lblMotivoCancelacionValor.Location = New System.Drawing.Point(20, 48)
        Me.lblMotivoCancelacionValor.Size = New System.Drawing.Size(790, 50)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Visible = True
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(112, 40)
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.lblFolioValor)
        Me.pnlEncabezado.Controls.Add(Me.lblFechaValor)
        Me.pnlEncabezado.Controls.Add(Me.lblVendedorValor)
        Me.pnlEncabezado.Controls.Add(Me.lblEstadoValor)
        Me.tlpRaiz.Controls.Add(Me.dgvArticulos, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.pnlResumen, 0, 2)
        Me.pnlResumen.Controls.Add(Me.lblTotalValor)
        Me.pnlResumen.Controls.Add(Me.lblEfectivoValor)
        Me.pnlResumen.Controls.Add(Me.lblCambioValor)
        Me.tlpRaiz.Controls.Add(Me.btnCancelarVenta, 0, 3)
        Me.tlpRaiz.Controls.Add(Me.pnlCapturaCancelacion, 0, 4)
        Me.pnlCapturaCancelacion.Controls.Add(Me.lblMotivoCancelacion)
        Me.pnlCapturaCancelacion.Controls.Add(Me.txtMotivoCancelacion)
        Me.pnlCapturaCancelacion.Controls.Add(Me.btnConfirmarCancelacion)
        Me.pnlCapturaCancelacion.Controls.Add(Me.btnDescartarCancelacion)
        Me.tlpRaiz.Controls.Add(Me.pnlDatosCancelacion, 0, 5)
        Me.pnlDatosCancelacion.Controls.Add(Me.lblFechaCancelacionValor)
        Me.pnlDatosCancelacion.Controls.Add(Me.lblUsuarioCancelaValor)
        Me.pnlDatosCancelacion.Controls.Add(Me.lblMotivoCancelacionValor)
        Me.tlpRaiz.Controls.Add(Me.btnCerrar, 0, 6)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblFolioValor As System.Windows.Forms.Label
    Friend WithEvents lblFechaValor As System.Windows.Forms.Label
    Friend WithEvents lblVendedorValor As System.Windows.Forms.Label
    Friend WithEvents lblEstadoValor As System.Windows.Forms.Label
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents pnlResumen As System.Windows.Forms.Panel
    Friend WithEvents lblTotalValor As System.Windows.Forms.Label
    Friend WithEvents lblEfectivoValor As System.Windows.Forms.Label
    Friend WithEvents lblCambioValor As System.Windows.Forms.Label
    Friend WithEvents btnCancelarVenta As System.Windows.Forms.Button
    Friend WithEvents pnlCapturaCancelacion As System.Windows.Forms.Panel
    Friend WithEvents lblMotivoCancelacion As System.Windows.Forms.Label
    Friend WithEvents txtMotivoCancelacion As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmarCancelacion As System.Windows.Forms.Button
    Friend WithEvents btnDescartarCancelacion As System.Windows.Forms.Button
    Friend WithEvents pnlDatosCancelacion As System.Windows.Forms.Panel
    Friend WithEvents lblFechaCancelacionValor As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioCancelaValor As System.Windows.Forms.Label
    Friend WithEvents lblMotivoCancelacionValor As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents erpCancelacion As System.Windows.Forms.ErrorProvider
    Friend WithEvents colArticuloIdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArticuloCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArticuloNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArticuloCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArticuloPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArticuloSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
