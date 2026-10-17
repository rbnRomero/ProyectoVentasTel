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
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFolioValor = New System.Windows.Forms.Label()
        Me.lblFechaValor = New System.Windows.Forms.Label()
        Me.lblVendedorValor = New System.Windows.Forms.Label()
        Me.lblEstadoValor = New System.Windows.Forms.Label()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.colArticuloIdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colArticuloSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlResumen = New System.Windows.Forms.Panel()
        Me.lblTotalValor = New System.Windows.Forms.Label()
        Me.lblEfectivoValor = New System.Windows.Forms.Label()
        Me.lblCambioValor = New System.Windows.Forms.Label()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.pnlCapturaCancelacion = New System.Windows.Forms.Panel()
        Me.lblMotivoCancelacion = New System.Windows.Forms.Label()
        Me.txtMotivoCancelacion = New System.Windows.Forms.TextBox()
        Me.btnConfirmarCancelacion = New System.Windows.Forms.Button()
        Me.btnDescartarCancelacion = New System.Windows.Forms.Button()
        Me.pnlDatosCancelacion = New System.Windows.Forms.Panel()
        Me.lblFechaCancelacionValor = New System.Windows.Forms.Label()
        Me.lblUsuarioCancelaValor = New System.Windows.Forms.Label()
        Me.lblMotivoCancelacionValor = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.erpCancelacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tlpRaiz.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResumen.SuspendLayout()
        Me.pnlCapturaCancelacion.SuspendLayout()
        Me.pnlDatosCancelacion.SuspendLayout()
        CType(Me.erpCancelacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.AutoSize = True
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.dgvArticulos, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.pnlResumen, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.btnCancelarVenta, 0, 3)
        Me.tlpRaiz.Controls.Add(Me.pnlCapturaCancelacion, 0, 4)
        Me.tlpRaiz.Controls.Add(Me.pnlDatosCancelacion, 0, 5)
        Me.tlpRaiz.Controls.Add(Me.btnCerrar, 0, 6)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 7
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(861, 834)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.lblFolioValor)
        Me.pnlEncabezado.Controls.Add(Me.lblFechaValor)
        Me.pnlEncabezado.Controls.Add(Me.lblVendedorValor)
        Me.pnlEncabezado.Controls.Add(Me.lblEstadoValor)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Location = New System.Drawing.Point(24, 24)
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(813, 96)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(450, 47)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Detalle de venta"
        '
        'lblFolioValor
        '
        Me.lblFolioValor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolioValor.Location = New System.Drawing.Point(0, 42)
        Me.lblFolioValor.Name = "lblFolioValor"
        Me.lblFolioValor.Size = New System.Drawing.Size(170, 54)
        Me.lblFolioValor.TabIndex = 1
        Me.lblFolioValor.Text = "—"
        '
        'lblFechaValor
        '
        Me.lblFechaValor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaValor.Location = New System.Drawing.Point(180, 42)
        Me.lblFechaValor.Name = "lblFechaValor"
        Me.lblFechaValor.Size = New System.Drawing.Size(170, 28)
        Me.lblFechaValor.TabIndex = 2
        Me.lblFechaValor.Text = "—"
        '
        'lblVendedorValor
        '
        Me.lblVendedorValor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedorValor.Location = New System.Drawing.Point(360, 42)
        Me.lblVendedorValor.Name = "lblVendedorValor"
        Me.lblVendedorValor.Size = New System.Drawing.Size(170, 28)
        Me.lblVendedorValor.TabIndex = 3
        Me.lblVendedorValor.Text = "—"
        '
        'lblEstadoValor
        '
        Me.lblEstadoValor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoValor.Location = New System.Drawing.Point(620, 42)
        Me.lblEstadoValor.Name = "lblEstadoValor"
        Me.lblEstadoValor.Size = New System.Drawing.Size(170, 28)
        Me.lblEstadoValor.TabIndex = 4
        Me.lblEstadoValor.Text = "—"
        '
        'dgvArticulos
        '
        Me.dgvArticulos.BackgroundColor = System.Drawing.Color.White
        Me.dgvArticulos.ColumnHeadersHeight = 40
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colArticuloIdDetalle, Me.colArticuloCodigo, Me.colArticuloNombre, Me.colArticuloCantidad, Me.colArticuloPrecio, Me.colArticuloSubtotal})
        Me.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvArticulos.Location = New System.Drawing.Point(24, 136)
        Me.dgvArticulos.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.RowHeadersWidth = 51
        Me.dgvArticulos.RowTemplate.Height = 36
        Me.dgvArticulos.Size = New System.Drawing.Size(813, 206)
        Me.dgvArticulos.TabIndex = 1
        '
        'colArticuloIdDetalle
        '
        Me.colArticuloIdDetalle.HeaderText = "IdDetalle"
        Me.colArticuloIdDetalle.MinimumWidth = 6
        Me.colArticuloIdDetalle.Name = "colArticuloIdDetalle"
        Me.colArticuloIdDetalle.Width = 90
        '
        'colArticuloCodigo
        '
        Me.colArticuloCodigo.HeaderText = "Código"
        Me.colArticuloCodigo.MinimumWidth = 6
        Me.colArticuloCodigo.Name = "colArticuloCodigo"
        Me.colArticuloCodigo.Width = 130
        '
        'colArticuloNombre
        '
        Me.colArticuloNombre.HeaderText = "Producto"
        Me.colArticuloNombre.MinimumWidth = 6
        Me.colArticuloNombre.Name = "colArticuloNombre"
        Me.colArticuloNombre.Width = 280
        '
        'colArticuloCantidad
        '
        Me.colArticuloCantidad.HeaderText = "Cantidad"
        Me.colArticuloCantidad.MinimumWidth = 6
        Me.colArticuloCantidad.Name = "colArticuloCantidad"
        Me.colArticuloCantidad.Width = 110
        '
        'colArticuloPrecio
        '
        Me.colArticuloPrecio.HeaderText = "Precio"
        Me.colArticuloPrecio.MinimumWidth = 6
        Me.colArticuloPrecio.Name = "colArticuloPrecio"
        Me.colArticuloPrecio.Width = 120
        '
        'colArticuloSubtotal
        '
        Me.colArticuloSubtotal.HeaderText = "Subtotal"
        Me.colArticuloSubtotal.MinimumWidth = 6
        Me.colArticuloSubtotal.Name = "colArticuloSubtotal"
        Me.colArticuloSubtotal.Width = 130
        '
        'pnlResumen
        '
        Me.pnlResumen.Controls.Add(Me.lblTotalValor)
        Me.pnlResumen.Controls.Add(Me.lblEfectivoValor)
        Me.pnlResumen.Controls.Add(Me.lblCambioValor)
        Me.pnlResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResumen.Location = New System.Drawing.Point(24, 358)
        Me.pnlResumen.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlResumen.Name = "pnlResumen"
        Me.pnlResumen.Size = New System.Drawing.Size(813, 56)
        Me.pnlResumen.TabIndex = 2
        '
        'lblTotalValor
        '
        Me.lblTotalValor.Location = New System.Drawing.Point(20, 20)
        Me.lblTotalValor.Name = "lblTotalValor"
        Me.lblTotalValor.Size = New System.Drawing.Size(220, 32)
        Me.lblTotalValor.TabIndex = 0
        Me.lblTotalValor.Text = "—"
        '
        'lblEfectivoValor
        '
        Me.lblEfectivoValor.Location = New System.Drawing.Point(300, 20)
        Me.lblEfectivoValor.Name = "lblEfectivoValor"
        Me.lblEfectivoValor.Size = New System.Drawing.Size(220, 32)
        Me.lblEfectivoValor.TabIndex = 1
        Me.lblEfectivoValor.Text = "—"
        '
        'lblCambioValor
        '
        Me.lblCambioValor.Location = New System.Drawing.Point(580, 20)
        Me.lblCambioValor.Name = "lblCambioValor"
        Me.lblCambioValor.Size = New System.Drawing.Size(220, 32)
        Me.lblCambioValor.TabIndex = 2
        Me.lblCambioValor.Text = "—"
        '
        'btnCancelarVenta
        '
        Me.btnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnCancelarVenta.FlatAppearance.BorderSize = 0
        Me.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarVenta.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarVenta.ForeColor = System.Drawing.Color.White
        Me.btnCancelarVenta.Location = New System.Drawing.Point(27, 433)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(144, 40)
        Me.btnCancelarVenta.TabIndex = 3
        Me.btnCancelarVenta.Text = "Cancelar venta"
        Me.btnCancelarVenta.UseVisualStyleBackColor = False
        '
        'pnlCapturaCancelacion
        '
        Me.pnlCapturaCancelacion.Controls.Add(Me.lblMotivoCancelacion)
        Me.pnlCapturaCancelacion.Controls.Add(Me.txtMotivoCancelacion)
        Me.pnlCapturaCancelacion.Controls.Add(Me.btnConfirmarCancelacion)
        Me.pnlCapturaCancelacion.Controls.Add(Me.btnDescartarCancelacion)
        Me.pnlCapturaCancelacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCapturaCancelacion.Location = New System.Drawing.Point(24, 482)
        Me.pnlCapturaCancelacion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlCapturaCancelacion.Name = "pnlCapturaCancelacion"
        Me.pnlCapturaCancelacion.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlCapturaCancelacion.Size = New System.Drawing.Size(813, 142)
        Me.pnlCapturaCancelacion.TabIndex = 4
        '
        'lblMotivoCancelacion
        '
        Me.lblMotivoCancelacion.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoCancelacion.Location = New System.Drawing.Point(20, 6)
        Me.lblMotivoCancelacion.Name = "lblMotivoCancelacion"
        Me.lblMotivoCancelacion.Size = New System.Drawing.Size(400, 22)
        Me.lblMotivoCancelacion.TabIndex = 0
        Me.lblMotivoCancelacion.Text = "Motivo de cancelación"
        '
        'txtMotivoCancelacion
        '
        Me.txtMotivoCancelacion.BackColor = System.Drawing.Color.White
        Me.txtMotivoCancelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotivoCancelacion.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoCancelacion.Location = New System.Drawing.Point(20, 32)
        Me.txtMotivoCancelacion.Multiline = True
        Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
        Me.txtMotivoCancelacion.Size = New System.Drawing.Size(790, 58)
        Me.txtMotivoCancelacion.TabIndex = 1
        '
        'btnConfirmarCancelacion
        '
        Me.btnConfirmarCancelacion.Location = New System.Drawing.Point(20, 98)
        Me.btnConfirmarCancelacion.Name = "btnConfirmarCancelacion"
        Me.btnConfirmarCancelacion.Size = New System.Drawing.Size(180, 40)
        Me.btnConfirmarCancelacion.TabIndex = 2
        Me.btnConfirmarCancelacion.Text = "Confirmar cancelación"
        '
        'btnDescartarCancelacion
        '
        Me.btnDescartarCancelacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnDescartarCancelacion.FlatAppearance.BorderSize = 0
        Me.btnDescartarCancelacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescartarCancelacion.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescartarCancelacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnDescartarCancelacion.Location = New System.Drawing.Point(212, 98)
        Me.btnDescartarCancelacion.Name = "btnDescartarCancelacion"
        Me.btnDescartarCancelacion.Size = New System.Drawing.Size(112, 40)
        Me.btnDescartarCancelacion.TabIndex = 3
        Me.btnDescartarCancelacion.Text = "Volver"
        Me.btnDescartarCancelacion.UseVisualStyleBackColor = False
        '
        'pnlDatosCancelacion
        '
        Me.pnlDatosCancelacion.Controls.Add(Me.lblFechaCancelacionValor)
        Me.pnlDatosCancelacion.Controls.Add(Me.lblUsuarioCancelaValor)
        Me.pnlDatosCancelacion.Controls.Add(Me.lblMotivoCancelacionValor)
        Me.pnlDatosCancelacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDatosCancelacion.Location = New System.Drawing.Point(24, 640)
        Me.pnlDatosCancelacion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlDatosCancelacion.Name = "pnlDatosCancelacion"
        Me.pnlDatosCancelacion.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlDatosCancelacion.Size = New System.Drawing.Size(813, 98)
        Me.pnlDatosCancelacion.TabIndex = 5
        '
        'lblFechaCancelacionValor
        '
        Me.lblFechaCancelacionValor.Location = New System.Drawing.Point(20, 10)
        Me.lblFechaCancelacionValor.Name = "lblFechaCancelacionValor"
        Me.lblFechaCancelacionValor.Size = New System.Drawing.Size(240, 26)
        Me.lblFechaCancelacionValor.TabIndex = 0
        Me.lblFechaCancelacionValor.Text = "—"
        '
        'lblUsuarioCancelaValor
        '
        Me.lblUsuarioCancelaValor.Location = New System.Drawing.Point(286, 10)
        Me.lblUsuarioCancelaValor.Name = "lblUsuarioCancelaValor"
        Me.lblUsuarioCancelaValor.Size = New System.Drawing.Size(240, 26)
        Me.lblUsuarioCancelaValor.TabIndex = 1
        Me.lblUsuarioCancelaValor.Text = "—"
        '
        'lblMotivoCancelacionValor
        '
        Me.lblMotivoCancelacionValor.Location = New System.Drawing.Point(20, 48)
        Me.lblMotivoCancelacionValor.Name = "lblMotivoCancelacionValor"
        Me.lblMotivoCancelacionValor.Size = New System.Drawing.Size(790, 50)
        Me.lblMotivoCancelacionValor.TabIndex = 2
        Me.lblMotivoCancelacionValor.Text = "—"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(725, 762)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(112, 40)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'erpCancelacion
        '
        Me.erpCancelacion.ContainerControl = Me
        '
        'FrmDetalleVenta
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(882, 653)
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "FrmDetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de venta"
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResumen.ResumeLayout(False)
        Me.pnlCapturaCancelacion.ResumeLayout(False)
        Me.pnlCapturaCancelacion.PerformLayout()
        Me.pnlDatosCancelacion.ResumeLayout(False)
        CType(Me.erpCancelacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
