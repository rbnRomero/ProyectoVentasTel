Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Productos
Imports ProyectoVentasTel.Infraestructura.Imagenes

Public Class FrmProducto
    Private ReadOnly servicio As ServicioProductos
    Private ReadOnly producto As Producto
    Private archivoImagenNuevo As String
    Private quitarImagen As Boolean

    Public Sub New()
        Me.New(Nothing, New ServicioProductos())
    End Sub

    Private Sub New(productoActual As Producto, servicioProductos As ServicioProductos)
        InitializeComponent()
        producto = productoActual
        servicio = servicioProductos
        StartPosition = FormStartPosition.CenterParent
        AddHandler Disposed, Sub() LiberarVistaPrevia()
    End Sub

    Public Shared Function CrearNuevo(servicio As ServicioProductos) As FrmProducto
        If servicio Is Nothing Then Throw New ArgumentNullException(NameOf(servicio))
        Return New FrmProducto(Nothing, servicio)
    End Function

    Public Shared Function CrearParaEdicion(producto As Producto, servicio As ServicioProductos) As FrmProducto
        If producto Is Nothing Then Throw New ArgumentNullException(NameOf(producto))
        If servicio Is Nothing Then Throw New ArgumentNullException(NameOf(servicio))
        Return New FrmProducto(producto, servicio)
    End Function

    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        txtCodigo.MaxLength = 30
        txtNombre.MaxLength = 100
        txtMarca.MaxLength = 50
        txtModelo.MaxLength = 80
        txtColor.MaxLength = 30
        txtCapacidadGB.MaxLength = 10
        cboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList
        nudPrecioVenta.DecimalPlaces = 2
        nudPrecioVenta.Maximum = 9999999999.99D
        nudPrecioVenta.Minimum = 0D
        picVistaPrevia.SizeMode = PictureBoxSizeMode.Zoom
        ofdImagen.Filter = "Imágenes JPEG y PNG|*.jpg;*.jpeg;*.png"
        ofdImagen.CheckFileExists = True
        ofdImagen.Multiselect = False
        AcceptButton = btnGuardar
        CancelButton = btnCancelar
        btnGuardar.DialogResult = DialogResult.None
        If producto Is Nothing Then
            cboTipoProducto.SelectedIndex = -1
            chkActivo.Checked = True
            MostrarImagen(Nothing)
        Else
            Text = "Editar producto"
            lblTitulo.Text = Text
            btnGuardar.Text = "Guardar cambios"
            txtCodigo.Text = producto.Codigo
            txtNombre.Text = producto.Nombre
            cboTipoProducto.SelectedIndex = If(producto.Tipo = TipoProducto.Telefono, 0, 1)
            txtMarca.Text = producto.Marca
            txtModelo.Text = producto.Modelo
            txtColor.Text = producto.Color
            txtCapacidadGB.Text = If(producto.CapacidadGB.HasValue, producto.CapacidadGB.Value.ToString(), String.Empty)
            nudPrecioVenta.Value = producto.PrecioVenta
            chkActivo.Checked = producto.Activo
            lblExistencias.Text = "Existencias: " & producto.Existencias.ToString()
            MostrarImagen(producto.RutaImagen)
        End If
        ActualizarTipo()
        btnGuardar.Enabled = ServicioProductos.PuedeAdministrar()
        txtCodigo.Focus()
    End Sub

    Private Sub cboTipoProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoProducto.SelectedIndexChanged
        ActualizarTipo()
    End Sub

    Private Sub ActualizarTipo()
        txtCapacidadGB.Enabled = cboTipoProducto.SelectedIndex = 0
        If Not txtCapacidadGB.Enabled Then
            txtCapacidadGB.Clear()
            erpProducto.SetError(txtCapacidadGB, String.Empty)
        End If
    End Sub

    Private Function CrearSolicitud() As SolicitudEdicionProducto
        If cboTipoProducto.SelectedIndex < 0 Then Throw New ArgumentException("Selecciona un tipo de producto.", "Tipo")
        Dim capacidad As Integer
        If cboTipoProducto.SelectedIndex = 0 AndAlso
            (Not Integer.TryParse(txtCapacidadGB.Text.Trim(), capacidad) OrElse capacidad <= 0) Then
            Throw New ArgumentException("Ingresa una capacidad entera positiva en GB.", "CapacidadGB")
        End If
        Dim solicitud As New SolicitudEdicionProducto With {
            .IdProducto = If(producto Is Nothing, 0, producto.IdProducto),
            .Codigo = txtCodigo.Text, .Nombre = txtNombre.Text,
            .Tipo = If(cboTipoProducto.SelectedIndex = 0, TipoProducto.Telefono, TipoProducto.Accesorio),
            .Marca = txtMarca.Text, .Modelo = txtModelo.Text, .Color = txtColor.Text,
            .CapacidadGB = If(cboTipoProducto.SelectedIndex = 0, CType(capacidad, Integer?), Nothing),
            .PrecioVenta = nudPrecioVenta.Value, .Activo = chkActivo.Checked,
            .ArchivoImagenNuevo = archivoImagenNuevo, .QuitarImagen = quitarImagen}
        ServicioProductos.ValidarDatos(solicitud)
        Return solicitud
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        erpProducto.Clear()
        btnGuardar.Enabled = False
        Try
            Dim solicitud = CrearSolicitud()
            If producto Is Nothing Then
                servicio.CrearProducto(solicitud)
            Else
                servicio.ActualizarProducto(solicitud)
            End If
            DialogResult = DialogResult.OK
            Close()
        Catch ex As ProductoDuplicadoException
            erpProducto.SetError(txtCodigo, ex.Message)
            MostrarMensaje(ex.Message, MessageBoxIcon.Warning)
        Catch ex As ProductoNoEncontradoException
            MostrarMensaje(ex.Message, MessageBoxIcon.Warning)
        Catch ex As AlmacenamientoImagenException
            erpProducto.SetError(btnSeleccionarImagen, ex.Message)
            MostrarMensaje(ex.Message, MessageBoxIcon.Warning)
        Catch ex As UnauthorizedAccessException
            MostrarMensaje("No tienes permiso para guardar el producto o acceder a la imagen seleccionada.", MessageBoxIcon.Warning)
        Catch ex As ArgumentException
            MarcarCampoInvalido(ex)
        Catch ex As Exception
            MostrarMensaje("No se pudo guardar el producto. Comprueba la conexión y el acceso a la imagen e intenta nuevamente.", MessageBoxIcon.Error)
        Finally
            btnGuardar.Enabled = ServicioProductos.PuedeAdministrar()
        End Try
    End Sub

    Private Sub MarcarCampoInvalido(ex As ArgumentException)
        Dim campos As New Dictionary(Of String, Control) From {
            {"Codigo", txtCodigo}, {"Nombre", txtNombre}, {"Tipo", cboTipoProducto},
            {"Marca", txtMarca}, {"Modelo", txtModelo}, {"Color", txtColor},
            {"CapacidadGB", txtCapacidadGB}, {"PrecioVenta", nudPrecioVenta}, {"ArchivoImagenNuevo", btnSeleccionarImagen}}
        Dim control As Control = Nothing
        Dim mensaje = ex.Message.Split(New String() {Environment.NewLine}, StringSplitOptions.None)(0)
        If ex.ParamName IsNot Nothing AndAlso campos.TryGetValue(ex.ParamName, control) Then
            erpProducto.SetError(control, mensaje)
            control.Focus()
        Else
            MostrarMensaje(mensaje, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSeleccionarImagen_Click(sender As Object, e As EventArgs) Handles btnSeleccionarImagen.Click
        If ofdImagen.ShowDialog(Me) <> DialogResult.OK Then Return
        Try
            Dim imagen = AlmacenImagenesProductos.Cargar(ofdImagen.FileName)
            LiberarVistaPrevia()
            picVistaPrevia.Image = imagen
            archivoImagenNuevo = ofdImagen.FileName
            quitarImagen = False
            lblNombreImagen.Visible = False
            btnQuitarImagen.Enabled = True
            erpProducto.SetError(btnSeleccionarImagen, String.Empty)
        Catch ex As Exception
            erpProducto.SetError(btnSeleccionarImagen, "No se pudo abrir la imagen. Selecciona un archivo JPEG o PNG válido y accesible.")
        End Try
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        archivoImagenNuevo = Nothing
        quitarImagen = True
        MostrarImagen(Nothing)
    End Sub

    Private Sub MostrarImagen(ruta As String)
        LiberarVistaPrevia()
        picVistaPrevia.Image = AlmacenImagenesProductos.IntentarCargar(ruta)
        lblNombreImagen.Text = "Sin imagen"
        lblNombreImagen.Visible = picVistaPrevia.Image Is Nothing
        If lblNombreImagen.Visible Then lblNombreImagen.BringToFront()
        btnQuitarImagen.Enabled = Not String.IsNullOrWhiteSpace(ruta)
    End Sub

    Private Sub LiberarVistaPrevia()
        Dim anterior = picVistaPrevia.Image
        picVistaPrevia.Image = Nothing
        If anterior IsNot Nothing Then anterior.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub MostrarMensaje(mensaje As String, icono As MessageBoxIcon)
        MessageBox.Show(Me, mensaje, "Productos", MessageBoxButtons.OK, icono)
    End Sub
End Class
