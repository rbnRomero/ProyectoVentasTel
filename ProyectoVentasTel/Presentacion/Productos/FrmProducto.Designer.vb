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
        Me.SuspendLayout()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24, 24, 24, 24)
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tlpCampos = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCampos.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.lblTipoProducto.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.cboTipoProducto.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblCapacidadGB = New System.Windows.Forms.Label()
        Me.lblCapacidadGB.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.txtCapacidadGB = New System.Windows.Forms.TextBox()
        Me.txtCapacidadGB.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblColor.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtColor.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.lblPrecioVenta.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.nudPrecioVenta = New System.Windows.Forms.NumericUpDown()
        Me.nudPrecioVenta.Margin = New System.Windows.Forms.Padding(0, 0, 12, 12)
        Me.lblExistencias = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.pnlImagen = New System.Windows.Forms.Panel()
        Me.pnlImagen.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.picVistaPrevia = New System.Windows.Forms.PictureBox()
        Me.lblNombreImagen = New System.Windows.Forms.Label()
        Me.btnSeleccionarImagen = New System.Windows.Forms.Button()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.erpProducto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.Size = New System.Drawing.Size(760, 720)
        Me.Name = "FrmProducto"
        Me.Text = "Producto"
        Me.MinimumSize = New System.Drawing.Size(680, 620)
        Me.AutoScroll = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 3
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Nuevo producto"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 12)
        Me.lblTitulo.Size = New System.Drawing.Size(400, 36)
        Me.tlpCampos.Name = "tlpCampos"
        Me.tlpCampos.Visible = True
        Me.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCampos.ColumnCount = 2
        Me.tlpCampos.RowCount = 9
        Me.tlpCampos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCampos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Visible = True
        Me.lblCodigo.Text = "Código"
        Me.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Visible = True
        Me.txtCodigo.Size = New System.Drawing.Size(180, 38)
        Me.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Visible = True
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Visible = True
        Me.txtNombre.Size = New System.Drawing.Size(180, 38)
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Visible = True
        Me.lblTipoProducto.Text = "Tipo"
        Me.lblTipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Visible = True
        Me.cboTipoProducto.Size = New System.Drawing.Size(180, 38)
        Me.cboTipoProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Visible = True
        Me.lblMarca.Text = "Marca"
        Me.lblMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Visible = True
        Me.txtMarca.Size = New System.Drawing.Size(180, 38)
        Me.txtMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Visible = True
        Me.lblModelo.Text = "Modelo"
        Me.lblModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Visible = True
        Me.txtModelo.Size = New System.Drawing.Size(180, 38)
        Me.txtModelo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCapacidadGB.Name = "lblCapacidadGB"
        Me.lblCapacidadGB.Visible = True
        Me.lblCapacidadGB.Text = "Capacidad (GB)"
        Me.lblCapacidadGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCapacidadGB.Name = "txtCapacidadGB"
        Me.txtCapacidadGB.Visible = True
        Me.txtCapacidadGB.Size = New System.Drawing.Size(180, 38)
        Me.txtCapacidadGB.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Visible = True
        Me.lblColor.Text = "Color"
        Me.lblColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Visible = True
        Me.txtColor.Size = New System.Drawing.Size(180, 38)
        Me.txtColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Visible = True
        Me.lblPrecioVenta.Text = "Precio de venta"
        Me.lblPrecioVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudPrecioVenta.Name = "nudPrecioVenta"
        Me.nudPrecioVenta.Visible = True
        Me.nudPrecioVenta.Size = New System.Drawing.Size(180, 38)
        Me.nudPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboTipoProducto.Items.AddRange(New Object() {"Teléfono", "Accesorio"})
        Me.lblExistencias.Name = "lblExistencias"
        Me.lblExistencias.Visible = True
        Me.lblExistencias.Text = "Existencias: 0"
        Me.lblExistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Visible = True
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlImagen.Name = "pnlImagen"
        Me.pnlImagen.Visible = True
        Me.pnlImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picVistaPrevia.Name = "picVistaPrevia"
        Me.picVistaPrevia.Visible = True
        Me.picVistaPrevia.Location = New System.Drawing.Point(20, 20)
        Me.picVistaPrevia.Size = New System.Drawing.Size(200, 230)
        Me.lblNombreImagen.Name = "lblNombreImagen"
        Me.lblNombreImagen.Visible = True
        Me.lblNombreImagen.Text = "Sin imagen"
        Me.lblNombreImagen.Location = New System.Drawing.Point(55, 174)
        Me.lblNombreImagen.Size = New System.Drawing.Size(130, 22)
        Me.btnSeleccionarImagen.Name = "btnSeleccionarImagen"
        Me.btnSeleccionarImagen.Visible = True
        Me.btnSeleccionarImagen.Text = "Seleccionar imagen"
        Me.btnSeleccionarImagen.Location = New System.Drawing.Point(20, 270)
        Me.btnSeleccionarImagen.Size = New System.Drawing.Size(200, 40)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.Visible = True
        Me.btnQuitarImagen.Text = "Quitar imagen"
        Me.btnQuitarImagen.Location = New System.Drawing.Point(20, 322)
        Me.btnQuitarImagen.Size = New System.Drawing.Size(200, 40)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Visible = True
        Me.btnGuardar.Text = "Guardar producto"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 40)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Visible = True
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 40)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 3)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.tlpRaiz.Controls.Add(Me.tlpCampos, 0, 1)
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
        Me.tlpRaiz.Controls.Add(Me.pnlImagen, 2, 1)
        Me.pnlImagen.Controls.Add(Me.picVistaPrevia)
        Me.pnlImagen.Controls.Add(Me.lblNombreImagen)
        Me.pnlImagen.Controls.Add(Me.btnSeleccionarImagen)
        Me.pnlImagen.Controls.Add(Me.btnQuitarImagen)
        Me.tlpRaiz.Controls.Add(Me.btnGuardar, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.btnCancelar, 2, 2)
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
