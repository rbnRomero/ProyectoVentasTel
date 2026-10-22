Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Ventas

Public Class UcHistorialVentas
    Private ReadOnly servicio As New ServicioVentas()
    Private ReadOnly ventasPorId As New Dictionary(Of Integer, VentaListado)()

    Private Sub UcHistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.OcultarEncabezadoDeModulo(tlpRaiz, pnlEncabezado, lblTitulo)
        UiTema.ConfigurarEtiqueta(lblDesde, dtpDesde, "Desde")
        UiTema.ConfigurarEtiqueta(lblHasta, dtpHasta, "Hasta")
        UiTema.ConfigurarEtiqueta(lblEstado, cboEstado, "Estado")
        dtpDesde.Format = DateTimePickerFormat.Short
        dtpHasta.Format = DateTimePickerFormat.Short
        dtpDesde.Value = Date.Today.AddDays(-30)
        dtpHasta.Value = Date.Today
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cboEstado.SelectedIndex = 0
        UiTema.ConfigurarTabla(dgvVentas, "historial de ventas")
        dgvVentas.ReadOnly = True
        dgvVentas.AllowUserToAddRows = False
        dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        colIdVenta.Visible = False
        colTotal.DefaultCellStyle.Format = "C2"
        colEfectivo.DefaultCellStyle.Format = "C2"
        AddHandler dtpDesde.ValueChanged, AddressOf FiltroCambiado
        AddHandler dtpHasta.ValueChanged, AddressOf FiltroCambiado
        AddHandler cboEstado.SelectedIndexChanged, AddressOf FiltroCambiado
        AddHandler dgvVentas.CellDoubleClick, AddressOf VerDetalleSeleccionado
        CargarVentas()
    End Sub

    Private Sub FiltroCambiado(sender As Object, e As EventArgs)
        CargarVentas()
    End Sub

    Public Sub ActualizarDatos()
        CargarVentas()
    End Sub

    Private Sub CargarVentas()
        dgvVentas.Rows.Clear()
        ventasPorId.Clear()
        If dtpDesde.Value.Date > dtpHasta.Value.Date Then
            lblSinVentas.Text = "La fecha inicial debe ser anterior o igual a la fecha final."
            lblSinVentas.Visible = True
            Return
        End If
        Try
            Dim estado = If(cboEstado.SelectedIndex = 1, "Confirmada", If(cboEstado.SelectedIndex = 2, "Cancelada", "Todas"))
            For Each venta In servicio.Consultar(New FiltroVentas With {.Desde = dtpDesde.Value.Date, .Hasta = dtpHasta.Value.Date, .Estado = estado})
                ventasPorId(venta.IdVenta) = venta
                dgvVentas.Rows.Add(venta.IdVenta, venta.Folio, venta.FechaHora.ToString("g"), venta.Vendedor, venta.Total, venta.EfectivoRecibido, If(venta.Estado = "Confirmada", "Confirmada", "Cancelada"))
            Next
            lblSinVentas.Text = "No hay ventas para mostrar"
        Catch ex As Exception
            lblSinVentas.Text = "No se pudo cargar el historial. Comprueba la conexión e intenta nuevamente."
        Finally
            lblSinVentas.Visible = dgvVentas.Rows.Count = 0
            btnVerDetalle.Enabled = dgvVentas.Rows.Count > 0
        End Try
    End Sub

    Private Sub btnVerDetalle_Click(sender As Object, e As EventArgs) Handles btnVerDetalle.Click
        VerDetalleSeleccionado(sender, EventArgs.Empty)
    End Sub

    Private Sub VerDetalleSeleccionado(sender As Object, e As EventArgs)
        If dgvVentas.CurrentRow Is Nothing Then Return
        Dim id As Integer
        If Not Integer.TryParse(Convert.ToString(dgvVentas.CurrentRow.Cells(colIdVenta.Index).Value), id) Then Return
        Using formulario As New FrmDetalleVenta(id, servicio)
            formulario.ShowDialog(FindForm())
        End Using
        CargarVentas()
    End Sub
End Class
