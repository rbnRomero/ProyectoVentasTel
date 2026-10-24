Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Inventario

Public Class UcEntradasInventario
    Private ReadOnly servicio As New ServicioEntradasInventario()

    Private Sub UcEntradasInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        tlpRaiz.RowStyles(1).Height = 208
        tlpCaptura.RowStyles(3).SizeType = SizeType.Absolute
        tlpCaptura.RowStyles(3).Height = 42
        btnRegistrarEntrada.Height = 36
        UiTema.OcultarEncabezadoDeModulo(tlpRaiz, pnlEncabezado, lblTitulo)
        UiTema.ConfigurarEtiqueta(lblProducto, cboProducto, "Producto")
        UiTema.ConfigurarEtiqueta(lblCantidad, nudCantidad, "Cantidad recibida")
        UiTema.ConfigurarEtiqueta(lblObservaciones, txtObservaciones, "Observaciones")
        UiTema.ConfigurarTabla(dgvEntradas, "historial de entradas de inventario")
        dgvEntradas.ReadOnly = True
        dgvEntradas.AllowUserToAddRows = False
        dgvEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        colIdEntrada.Visible = False
        cboProducto.DropDownStyle = ComboBoxStyle.DropDownList
        nudCantidad.Minimum = 1
        nudCantidad.Maximum = Integer.MaxValue
        nudCantidad.ThousandsSeparator = True
        txtObservaciones.MaxLength = 250
        AddHandler cboProducto.SelectedIndexChanged, AddressOf ActualizarExistenciasSeleccionadas
        CargarDatos()
    End Sub

    Private Sub CargarDatos(Optional idSeleccionado As Integer = 0)
        Try
            Dim lista = servicio.ProductosActivos().ToList()
            cboProducto.DataSource = Nothing
            cboProducto.DisplayMember = NameOf(ProductoEntrada.DisplayText)
            cboProducto.DataSource = lista
            If idSeleccionado > 0 Then
                For indice = 0 To lista.Count - 1
                    If lista(indice).IdProducto = idSeleccionado Then cboProducto.SelectedIndex = indice : Exit For
                Next
            End If
            dgvEntradas.Rows.Clear()
            For Each entrada In servicio.Consultar()
                dgvEntradas.Rows.Add(entrada.IdEntrada, entrada.FechaHora.ToString("g"), entrada.CodigoProducto, entrada.NombreProducto, entrada.Cantidad, entrada.Usuario, entrada.Observaciones)
            Next
            lblSinEntradas.Visible = dgvEntradas.Rows.Count = 0
            btnRegistrarEntrada.Enabled = lista.Count > 0
            lblSinEntradas.Text = If(lista.Count = 0, "No hay entradas registradas ni productos activos", "No hay entradas para mostrar")
            ActualizarExistenciasSeleccionadas(Nothing, EventArgs.Empty)
        Catch ex As Exception
            cboProducto.DataSource = Nothing
            dgvEntradas.Rows.Clear()
            lblSinEntradas.Text = "No se pudo cargar inventario. Comprueba la conexión e intenta nuevamente."
            lblSinEntradas.Visible = True
            btnRegistrarEntrada.Enabled = False
            lblExistenciasActuales.Text = "Existencias actuales: —"
        End Try
    End Sub

    Public Sub ActualizarDatos()
        CargarDatos()
    End Sub

    Private Sub ActualizarExistenciasSeleccionadas(sender As Object, e As EventArgs)
        Dim producto = TryCast(cboProducto.SelectedItem, ProductoEntrada)
        lblExistenciasActuales.Text = "Existencias actuales: " & If(producto Is Nothing, "—", producto.Existencias.ToString("N0"))
    End Sub

    Private Sub btnRegistrarEntrada_Click(sender As Object, e As EventArgs) Handles btnRegistrarEntrada.Click
        erpEntrada.Clear()
        Dim producto = TryCast(cboProducto.SelectedItem, ProductoEntrada)
        If producto Is Nothing Then
            erpEntrada.SetError(cboProducto, "Selecciona un producto activo.")
            Return
        End If
        If txtObservaciones.Text.Trim().Length > 250 Then
            erpEntrada.SetError(txtObservaciones, "Las observaciones no pueden exceder 250 caracteres.")
            Return
        End If
        Try
            servicio.Registrar(producto.IdProducto, CInt(nudCantidad.Value), txtObservaciones.Text)
            MessageBox.Show(FindForm(), "La entrada se registró y las existencias fueron actualizadas.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtObservaciones.Clear()
            nudCantidad.Value = 1
            CargarDatos(producto.IdProducto)
        Catch ex As ArgumentException
            erpEntrada.SetError(If(ex.ParamName = "observaciones", CType(txtObservaciones, Control), CType(nudCantidad, Control)), ex.Message)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show(FindForm(), ex.Message, "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(FindForm(), "No se pudo registrar la entrada. Comprueba la conexión, el estado del producto y la cantidad.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CargarDatos(producto.IdProducto)
        End Try
    End Sub
End Class
