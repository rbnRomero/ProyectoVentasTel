Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Seguridad
Imports System.IO

Public Class FrmPrincipal
    Private Shared ReadOnly ColorMenuNormal As Color = Color.FromArgb(15, 23, 42)
    Private Shared ReadOnly ColorMenuActivo As Color = Color.FromArgb(37, 99, 235)
    Private ReadOnly usuarioActual As UsuarioAutenticado
    Private ReadOnly ucVenta As New UcVenta()
    Private ReadOnly ucHistorialVentas As New UcHistorialVentas()
    Private ReadOnly ucEntradasInventario As New UcEntradasInventario()
    Private ReadOnly ucUsuarios As New UcUsuarios()
    Private webLogotipoMenu As WebBrowser

    Public Sub New(usuario As UsuarioAutenticado)
        If usuario Is Nothing Then Throw New ArgumentNullException(NameOf(usuario))

        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        usuarioActual = usuario
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        ConfigurarMenuLateral()
        ConfigurarLogotipoMenu()
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

    Private Sub ConfigurarLogotipoMenu()
        Dim ruta As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "system", "visor-logotipo-blanco.svg")
        If Not File.Exists(ruta) Then Return

        webLogotipoMenu = New WebBrowser With {
            .Name = "webLogotipoMenu",
            .AccessibleName = "VISOR",
            .AccessibleDescription = "Logotipo blanco de VISOR",
            .Dock = DockStyle.Fill,
            .Margin = New Padding(14, 8, 14, 8),
            .ScrollBarsEnabled = False,
            .IsWebBrowserContextMenuEnabled = False,
            .WebBrowserShortcutsEnabled = False,
            .ScriptErrorsSuppressed = True,
            .AllowWebBrowserDrop = False,
            .TabStop = False
        }
        webLogotipoMenu.DocumentText = String.Format(
            "<!DOCTYPE html><html><head><meta http-equiv='X-UA-Compatible' content='IE=edge'></head><body style='width:100%;height:100%;margin:0;overflow:hidden;background:#0F172A'><img src='{0}' alt='VISOR' style='display:block;width:100%;height:100%'></body></html>",
            New Uri(ruta).AbsoluteUri)

        tlpMenu.Controls.Remove(lblMarca)
        tlpMenu.Controls.Add(webLogotipoMenu, 0, 0)
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        If webLogotipoMenu IsNot Nothing Then webLogotipoMenu.Dispose()
        MyBase.OnFormClosed(e)
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
        distribucion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.0F))
        distribucion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 62.0F))
        distribucion.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))

        Dim pnlEncabezadoIzquierdo As New Panel With {
            .Name = "pnlEncabezadoIzquierdo",
            .Dock = DockStyle.Fill,
            .BackColor = UiTema.Superficie,
            .Margin = Padding.Empty
        }
        Dim pnlEncabezadoDerecho As New Panel With {
            .Name = "pnlEncabezadoDerecho",
            .Dock = DockStyle.Fill,
            .BackColor = UiTema.Superficie,
            .Margin = Padding.Empty
        }

        pnlEncabezado.Controls.Remove(lblTituloSeccion)
        pnlEncabezado.Controls.Remove(lblRolActual)
        pnlEncabezado.Height = 104
        lblTituloSeccion.Dock = DockStyle.Fill
        lblTituloSeccion.TextAlign = ContentAlignment.MiddleLeft
        lblTituloSeccion.AutoEllipsis = False
        lblTituloSeccion.Margin = Padding.Empty
        lblRolActual.Dock = DockStyle.Fill
        lblRolActual.TextAlign = ContentAlignment.MiddleRight
        lblRolActual.AutoEllipsis = False
        lblRolActual.Margin = Padding.Empty
        pnlEncabezadoIzquierdo.Controls.Add(lblTituloSeccion)
        pnlEncabezadoDerecho.Controls.Add(lblRolActual)
        distribucion.Controls.Add(pnlEncabezadoIzquierdo, 0, 0)
        distribucion.Controls.Add(pnlEncabezadoDerecho, 1, 0)
        pnlEncabezado.Controls.Add(distribucion)
    End Sub

    Private Sub ConfigurarAccesos()
        Dim botones As Button() = {btnProductos, btnVenta, btnHistorial, btnEntradas, btnUsuarios}
        Dim permisos As Boolean() = {
            SesionActual.PuedeAcceder(ModuloAplicacion.Productos),
            SesionActual.PuedeAcceder(ModuloAplicacion.Ventas),
            SesionActual.PuedeAcceder(ModuloAplicacion.HistorialVentas),
            SesionActual.PuedeAcceder(ModuloAplicacion.EntradasInventario),
            SesionActual.PuedeAcceder(ModuloAplicacion.Usuarios)
        }
        Dim fila As Integer = 1
        For indice As Integer = 0 To botones.Length - 1
            botones(indice).Visible = permisos(indice)
            If Not permisos(indice) Then Continue For
            tlpMenu.SetRow(botones(indice), fila)
            fila += 1
        Next

        Dim filaSalir As Integer = fila + 1
        tlpMenu.RowCount = filaSalir + 1
        tlpMenu.RowStyles.Clear()
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 72.0F))
        For Each permiso As Boolean In permisos
            If permiso Then tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 44.0F))
        Next
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
        tlpMenu.SetRow(btnSalir, filaSalir)
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
        Dim yaInicializado = control.Parent Is pnlContenido
        If Not yaInicializado Then pnlContenido.Controls.Add(control)

        control.Dock = DockStyle.Fill
        control.BringToFront()
        lblTituloSeccion.Text = titulo
        ActualizarModuloActivo(modulo)
        If yaInicializado Then
            Select Case modulo
                Case ModuloAplicacion.Ventas
                    ucVenta.ActualizarDatos()
                Case ModuloAplicacion.HistorialVentas
                    ucHistorialVentas.ActualizarDatos()
                Case ModuloAplicacion.EntradasInventario
                    ucEntradasInventario.ActualizarDatos()
            End Select
        End If
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
