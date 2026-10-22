Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Seguridad
Imports ProyectoVentasTel.Dominio.Ventas

Public Class FrmDetalleVenta
    Private ReadOnly idVenta As Integer
    Private ReadOnly servicio As ServicioVentas

    Public Sub New()
        InitializeComponent()
        servicio = New ServicioVentas()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub New(id As Integer, servicioVentas As ServicioVentas)
        InitializeComponent()
        If id <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(id))
        idVenta = id
        servicio = If(servicioVentas, New ServicioVentas())
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        ReubicarAccionVolver()
        UiTema.ConfigurarTabla(dgvArticulos, "artículos de la venta")
        dgvArticulos.ReadOnly = True
        dgvArticulos.AllowUserToAddRows = False
        dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        colArticuloIdDetalle.Visible = False
        colArticuloPrecio.DefaultCellStyle.Format = "C2"
        colArticuloSubtotal.DefaultCellStyle.Format = "C2"
        btnCancelarVenta.AccessibleDescription = "Inicia la cancelación de esta venta"
        btnConfirmarCancelacion.AccessibleDescription = "Confirma la cancelación definitiva de la venta"
        btnDescartarCancelacion.AccessibleDescription = "Descarta la cancelación y conserva la venta"
        CancelButton = btnCerrar
        pnlCapturaCancelacion.Visible = False
        pnlDatosCancelacion.Visible = False
        txtMotivoCancelacion.MaxLength = 250
        CargarDetalle()
    End Sub

    Private Sub ReubicarAccionVolver()
        Dim dpi As Integer = If(btnConfirmarCancelacion.DeviceDpi > 0, btnConfirmarCancelacion.DeviceDpi, 96)
        Dim separacion As Integer = CInt(Math.Ceiling(12.0F * dpi / 96.0F))
        btnDescartarCancelacion.Location = New Point(btnConfirmarCancelacion.Right + separacion, btnConfirmarCancelacion.Top)
    End Sub

    Private Sub CargarDetalle()
        Try
            Dim venta = servicio.Obtener(idVenta)
            lblFolioValor.Text = venta.Folio
            lblFechaValor.Text = venta.FechaHora.ToString("g")
            lblVendedorValor.Text = venta.Vendedor
            lblEstadoValor.Text = If(venta.Estado = "Confirmada", "Confirmada", "Cancelada")
            lblTotalValor.Text = venta.Total.ToString("C2")
            lblEfectivoValor.Text = venta.EfectivoRecibido.ToString("C2")
            lblCambioValor.Text = (venta.EfectivoRecibido - venta.Total).ToString("C2")
            dgvArticulos.Rows.Clear()
            For Each articulo In venta.Articulos
                dgvArticulos.Rows.Add(articulo.IdProducto, articulo.Codigo, articulo.Nombre, articulo.Cantidad, articulo.PrecioUnitario, articulo.Subtotal)
            Next
            Dim usuario = SesionActual.Usuario
            Dim puedeCancelar = venta.Estado = "Confirmada" AndAlso usuario IsNot Nothing AndAlso
                (usuario.Rol = RolUsuario.Administrador OrElse (usuario.Rol = RolUsuario.Vendedor AndAlso venta.IdVendedor = usuario.IdUsuario))
            btnCancelarVenta.Visible = puedeCancelar
            pnlCapturaCancelacion.Visible = False
            pnlDatosCancelacion.Visible = venta.Estado = "Cancelada"
            If pnlDatosCancelacion.Visible Then
                lblFechaCancelacionValor.Text = If(venta.FechaCancelacion.HasValue, venta.FechaCancelacion.Value.ToString("g"), "—")
                lblUsuarioCancelaValor.Text = If(venta.UsuarioCancela, "—")
                lblMotivoCancelacionValor.Text = If(venta.MotivoCancelacion, "—")
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "No se pudo cargar el detalle de la venta. Comprueba la conexión e intenta nuevamente.", "Detalle de venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        pnlCapturaCancelacion.Visible = True
        btnCancelarVenta.Enabled = False
        txtMotivoCancelacion.Focus()
    End Sub

    Private Sub btnDescartarCancelacion_Click(sender As Object, e As EventArgs) Handles btnDescartarCancelacion.Click
        erpCancelacion.SetError(txtMotivoCancelacion, String.Empty)
        txtMotivoCancelacion.Clear()
        pnlCapturaCancelacion.Visible = False
        btnCancelarVenta.Enabled = True
    End Sub

    Private Sub btnConfirmarCancelacion_Click(sender As Object, e As EventArgs) Handles btnConfirmarCancelacion.Click
        Dim motivo = txtMotivoCancelacion.Text.Trim()
        If motivo.Length = 0 Then
            erpCancelacion.SetError(txtMotivoCancelacion, "Escribe el motivo de la cancelación.")
            Return
        End If
        erpCancelacion.SetError(txtMotivoCancelacion, String.Empty)
        If MessageBox.Show(Me, "La cancelación restaurará las existencias. ¿Deseas continuar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return
        Try
            servicio.Cancelar(idVenta, motivo)
            CargarDetalle()
        Catch ex As ArgumentException
            erpCancelacion.SetError(txtMotivoCancelacion, ex.Message)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show(Me, ex.Message, "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
        Catch ex As Exception
            MessageBox.Show(Me, "No se pudo cancelar la venta. Actualiza el historial e intenta nuevamente.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class
