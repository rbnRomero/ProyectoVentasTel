Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Seguridad

Public Class FrmPrincipal
    Private ReadOnly usuarioActual As UsuarioAutenticado
    Private ReadOnly ucVenta As New UcVenta()
    Private ReadOnly ucHistorialVentas As New UcHistorialVentas()
    Private ReadOnly ucEntradasInventario As New UcEntradasInventario()
    Private ReadOnly ucUsuarios As New UcUsuarios()

    Public Sub New(usuario As UsuarioAutenticado)
        If usuario Is Nothing Then Throw New ArgumentNullException(NameOf(usuario))

        InitializeComponent()
        usuarioActual = usuario
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRolActual.Text = String.Format("{0} · {1}", usuarioActual.NombreCompleto, usuarioActual.Rol.ToString())
        ConfigurarAccesos()
        AbrirModuloSiPermitido(ModuloAplicacion.Productos, ucProductos, "Productos")
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

        MostrarModulo(control, titulo)
    End Sub

    Private Sub MostrarModulo(control As UserControl, titulo As String)
        If control.Parent IsNot pnlContenido Then pnlContenido.Controls.Add(control)

        control.Dock = DockStyle.Fill
        control.BringToFront()
        lblTituloSeccion.Text = titulo
    End Sub
End Class
