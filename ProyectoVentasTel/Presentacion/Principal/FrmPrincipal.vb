Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Seguridad

Public Class FrmPrincipal
    Private Shared ReadOnly ColorMenuNormal As Color = Color.FromArgb(15, 23, 42)
    Private Shared ReadOnly ColorMenuActivo As Color = Color.FromArgb(37, 99, 235)
    Private ReadOnly usuarioActual As UsuarioAutenticado
    Private ReadOnly ucVenta As New UcVenta()
    Private ReadOnly ucHistorialVentas As New UcHistorialVentas()
    Private ReadOnly ucEntradasInventario As New UcEntradasInventario()
    Private ReadOnly ucUsuarios As New UcUsuarios()

    Public Sub New(usuario As UsuarioAutenticado)
        If usuario Is Nothing Then Throw New ArgumentNullException(NameOf(usuario))

        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
        usuarioActual = usuario
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        ConfigurarMenuLateral()
        lblRolActual.Text = String.Format("{0} · {1}", usuarioActual.NombreCompleto, usuarioActual.Rol.ToString())
        lblRolActual.AccessibleName = "Usuario actual: " & lblRolActual.Text
        ConfigurarEncabezadoAdaptable()
        ConfigurarAccesos()
        AbrirModuloSiPermitido(ModuloAplicacion.Productos, ucProductos, "Productos")
    End Sub

    Private Sub FrmPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ConfigurarMenuLateral()
    End Sub

    Private Sub ConfigurarMenuLateral()
        tlpRaiz.BackColor = UiTema.Navegacion
        tlpRaiz.Padding = Padding.Empty
        pnlMenu.BackColor = UiTema.Navegacion
        pnlMenu.Margin = Padding.Empty
        pnlMenu.Padding = Padding.Empty
        tlpMenu.BackColor = UiTema.Navegacion
        tlpMenu.Margin = Padding.Empty
        tlpMenu.Padding = Padding.Empty
        pnlAreaPrincipal.BackColor = UiTema.Fondo
        pnlAreaPrincipal.Margin = Padding.Empty
    End Sub

    Private Sub ConfigurarEncabezadoAdaptable()
        Dim distribucion As New TableLayoutPanel With {
            .Name = "tlpEncabezadoAdaptable",
            .Dock = DockStyle.Fill,
            .BackColor = UiTema.Superficie,
            .Padding = New Padding(24, 0, 24, 0),
            .ColumnCount = 2,
            .RowCount = 1
        }
        distribucion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        distribucion.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        distribucion.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))

        pnlEncabezado.Controls.Remove(lblTituloSeccion)
        pnlEncabezado.Controls.Remove(lblRolActual)
        lblTituloSeccion.Dock = DockStyle.Fill
        lblTituloSeccion.TextAlign = ContentAlignment.MiddleLeft
        lblTituloSeccion.AutoEllipsis = True
        lblRolActual.Dock = DockStyle.Fill
        lblRolActual.TextAlign = ContentAlignment.MiddleRight
        lblRolActual.AutoEllipsis = True
        distribucion.Controls.Add(lblTituloSeccion, 0, 0)
        distribucion.Controls.Add(lblRolActual, 1, 0)
        pnlEncabezado.Controls.Add(distribucion)
    End Sub

    Private Sub ConfigurarAccesos()
        btnProductos.Visible = SesionActual.PuedeAcceder(ModuloAplicacion.Productos)
        btnVenta.Visible = SesionActual.PuedeAcceder(ModuloAplicacion.Ventas)
        btnHistorial.Visible = SesionActual.PuedeAcceder(ModuloAplicacion.HistorialVentas)
        btnEntradas.Visible = SesionActual.PuedeAcceder(ModuloAplicacion.EntradasInventario)
        btnUsuarios.Visible = SesionActual.PuedeAcceder(ModuloAplicacion.Usuarios)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirModuloSiPermitido(ModuloAplicacion.Productos, ucProductos, "Productos")
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        AbrirModuloSiPermitido(ModuloAplicacion.Ventas, ucVenta, "Nueva venta")
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        AbrirModuloSiPermitido(ModuloAplicacion.HistorialVentas, ucHistorialVentas, "Historial de ventas")
    End Sub

    Private Sub btnEntradas_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        AbrirModuloSiPermitido(ModuloAplicacion.EntradasInventario, ucEntradasInventario, "Entradas de inventario")
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        AbrirModuloSiPermitido(ModuloAplicacion.Usuarios, ucUsuarios, "Usuarios")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        SesionActual.Cerrar()
        Dim inicioSesion As New FrmInicioSesion()
        My.Application.EstablecerFormularioPrincipal(inicioSesion)
        inicioSesion.Show()
        Close()
    End Sub

    Private Sub FrmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SesionActual.Cerrar()
    End Sub

    Private Sub AbrirModuloSiPermitido(modulo As ModuloAplicacion, control As UserControl, titulo As String)
        If Not SesionActual.PuedeAcceder(modulo) Then
            MessageBox.Show("No tienes permiso para acceder a este módulo.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MostrarModulo(modulo, control, titulo)
    End Sub

    Private Sub MostrarModulo(modulo As ModuloAplicacion, control As UserControl, titulo As String)
        If control.Parent IsNot pnlContenido Then pnlContenido.Controls.Add(control)

        control.Dock = DockStyle.Fill
        control.BringToFront()
        lblTituloSeccion.Text = titulo
        ActualizarModuloActivo(modulo)
    End Sub

    Private Sub ActualizarModuloActivo(moduloActivo As ModuloAplicacion)
        Dim botones As Button() = {btnProductos, btnVenta, btnHistorial, btnEntradas, btnUsuarios}
        For Each boton As Button In botones
            boton.BackColor = ColorMenuNormal
        Next

        Dim botonActivo As Button = Nothing
        Select Case moduloActivo
            Case ModuloAplicacion.Productos
                botonActivo = btnProductos
            Case ModuloAplicacion.Ventas
                botonActivo = btnVenta
            Case ModuloAplicacion.HistorialVentas
                botonActivo = btnHistorial
            Case ModuloAplicacion.EntradasInventario
                botonActivo = btnEntradas
            Case ModuloAplicacion.Usuarios
                botonActivo = btnUsuarios
        End Select

        If botonActivo IsNot Nothing Then botonActivo.BackColor = ColorMenuActivo
        For Each boton As Button In botones
            Dim esActivo As Boolean = boton Is botonActivo
            boton.AccessibleDescription = If(esActivo, "Módulo actual", "Abrir módulo")
        Next
    End Sub
End Class
