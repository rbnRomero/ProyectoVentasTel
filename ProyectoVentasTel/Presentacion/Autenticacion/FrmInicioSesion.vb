Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.Automation
Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Seguridad

Public Class FrmInicioSesion
    Private ReadOnly servicioAutenticacion As New ServicioAutenticacion()
    Private webImagotipo As WebBrowser
    Private imagenContenidoEntrar As Bitmap

    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        ConfigurarImagotipo()
        Text = "Inicio de Sesión"
        txtContrasena.UseSystemPasswordChar = True
        btnMostrarContrasena.Text = String.Empty
        btnMostrarContrasena.Width = 40
        btnMostrarContrasena.AccessibleName = "Mostrar contraseña"
        btnMostrarContrasena.AccessibleDescription = "Alterna la visibilidad de la contraseña"
        UiTema.AplicarIcono(btnMostrarContrasena, "eye")
        txtUsuario.AccessibleName = "Usuario"
        txtContrasena.AccessibleName = "Contraseña"
        lblUsuario.Text = "&Usuario"
        lblContrasena.Text = "&Contraseña"
        UiTema.ConfigurarMensaje(lblMensaje)
        lblMensaje.TextAlign = ContentAlignment.MiddleCenter
        lblMensaje.Height = 58
        lblMensaje.ForeColor = UiTema.Peligro
        btnEntrar.TextAlign = ContentAlignment.MiddleCenter
        CentrarContenidoBotonEntrar()
        AcceptButton = btnEntrar
        lblMensaje.Text = String.Empty
        txtUsuario.Focus()
    End Sub

    Private Sub CentrarContenidoBotonEntrar()
        Dim icono As Image = btnEntrar.Image
        If icono Is Nothing Then Return

        Dim texto As String = btnEntrar.Text
        Dim tamanoTexto As Size = TextRenderer.MeasureText(texto, btnEntrar.Font, Size.Empty, TextFormatFlags.NoPadding)
        Dim espacio As Integer = 8
        Dim anchoContenido As Integer = icono.Width + espacio + tamanoTexto.Width
        imagenContenidoEntrar = New Bitmap(anchoContenido, btnEntrar.Height, PixelFormat.Format32bppArgb)

        Using grafico As Graphics = Graphics.FromImage(imagenContenidoEntrar)
            grafico.Clear(Color.Transparent)
            grafico.DrawImage(icono, 0, (btnEntrar.Height - icono.Height) \ 2, icono.Width, icono.Height)
            TextRenderer.DrawText(grafico,
                                  texto,
                                  btnEntrar.Font,
                                  New Rectangle(icono.Width + espacio, 0, tamanoTexto.Width, btnEntrar.Height),
                                  btnEntrar.ForeColor,
                                  TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPadding)
        End Using

        btnEntrar.Image = imagenContenidoEntrar
        btnEntrar.ImageAlign = ContentAlignment.MiddleCenter
        btnEntrar.TextImageRelation = TextImageRelation.Overlay
        btnEntrar.TextAlign = ContentAlignment.MiddleCenter
        btnEntrar.Padding = Padding.Empty
        btnEntrar.Text = String.Empty
        btnEntrar.AccessibleName = "Entrar"
        btnEntrar.AccessibleDescription = "Inicia sesión en VISOR"
    End Sub

    Private Sub ConfigurarImagotipo()
        Dim ruta As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "system", "visor-imagotipo.svg")
        If Not File.Exists(ruta) Then Return

        webImagotipo = New WebBrowser With {
            .Name = "webImagotipo",
            .AccessibleName = "Imagotipo de VISOR",
            .AccessibleDescription = "Logotipo de Ventas e Inventario de Seguimiento de Operaciones y Resultados",
            .Location = New Point(137, 8),
            .Size = New Size(120, 120),
            .ScrollBarsEnabled = False,
            .IsWebBrowserContextMenuEnabled = False,
            .WebBrowserShortcutsEnabled = False,
            .ScriptErrorsSuppressed = True,
            .AllowWebBrowserDrop = False,
            .TabStop = False
        }

        Dim origenSvg As String = New Uri(ruta).AbsoluteUri
        Dim fondo As Color = UiTema.Superficie
        Dim fondoCss As String = String.Format("#{0:X2}{1:X2}{2:X2}", fondo.R, fondo.G, fondo.B)
        webImagotipo.DocumentText = String.Format(
            "<!DOCTYPE html><html><head><meta http-equiv='X-UA-Compatible' content='IE=edge'></head><body style='width:100%;height:100%;margin:0;overflow:hidden;background:{1}'><img src='{0}' alt='Imagotipo de VISOR' style='display:block;width:100%;height:100%'></body></html>",
            origenSvg,
            fondoCss)

        lblMarca.Visible = False
        lblTitulo.Location = New Point(lblTitulo.Left, 139)
        lblUsuario.Location = New Point(lblUsuario.Left, 195)
        txtUsuario.Location = New Point(txtUsuario.Left, 221)
        lblContrasena.Location = New Point(lblContrasena.Left, 271)
        txtContrasena.Location = New Point(txtContrasena.Left, 297)
        txtContrasena.Width = 308
        btnMostrarContrasena.Location = New Point(340, 293)
        btnEntrar.Location = New Point(btnEntrar.Left, 353)
        lblMensaje.Location = New Point(lblMensaje.Left, 405)
        pnlTarjeta.Controls.Add(webImagotipo)
        webImagotipo.BringToFront()
        tlpRaiz.RowStyles(1).Height = 466
        ClientSize = New Size(ClientSize.Width, 579)
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        If webImagotipo IsNot Nothing Then webImagotipo.Dispose()
        If imagenContenidoEntrar IsNot Nothing Then
            imagenContenidoEntrar.Dispose()
            imagenContenidoEntrar = Nothing
            btnEntrar.Image = Nothing
        End If
        MyBase.OnFormClosed(e)
    End Sub

    Private Sub btnMostrarContrasena_Click(sender As Object, e As EventArgs) Handles btnMostrarContrasena.Click
        txtContrasena.UseSystemPasswordChar = Not txtContrasena.UseSystemPasswordChar
        btnMostrarContrasena.Text = String.Empty
        btnMostrarContrasena.AccessibleName = If(txtContrasena.UseSystemPasswordChar, "Mostrar contraseña", "Ocultar contraseña")
        UiTema.AplicarIcono(btnMostrarContrasena, If(txtContrasena.UseSystemPasswordChar, "eye", "eye-off"))
        NotificarCambioDeVisibilidadContrasena()
    End Sub

    Private Sub NotificarCambioDeVisibilidadContrasena()
        Dim objetoAccesible As Control.ControlAccessibleObject = TryCast(btnMostrarContrasena.AccessibilityObject, Control.ControlAccessibleObject)
        If objetoAccesible IsNot Nothing Then objetoAccesible.NotifyClients(AccessibleEvents.NameChange)

        Dim estado As String = If(txtContrasena.UseSystemPasswordChar, "Contraseña oculta", "Contraseña visible")
        Dim notificacionEmitida As Boolean = btnMostrarContrasena.AccessibilityObject.RaiseAutomationNotification(
            AutomationNotificationKind.ActionCompleted,
            AutomationNotificationProcessing.MostRecent,
            estado)
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If Not ValidarCampos() Then Return

        btnEntrar.Enabled = False
        lblMensaje.Text = String.Empty
        Try
            Dim usuario As UsuarioAutenticado = servicioAutenticacion.Autenticar(txtUsuario.Text, txtContrasena.Text)
            If usuario Is Nothing Then
                lblMensaje.Text = "Usuario o contraseña incorrectos."
                txtContrasena.SelectAll()
                txtContrasena.Focus()
                Return
            End If

            SesionActual.Iniciar(usuario)
            txtContrasena.Clear()
            AbrirPrincipal(usuario)
        Catch ex As SqlException
            lblMensaje.Text = "No fue posible iniciar sesión. Intenta nuevamente más tarde."
        Catch ex As ConfigurationErrorsException
            lblMensaje.Text = "No fue posible iniciar sesión. Intenta nuevamente más tarde."
        Catch ex As Exception
            lblMensaje.Text = "No fue posible iniciar sesión. Intenta nuevamente más tarde."
        Finally
            btnEntrar.Enabled = True
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        erpInicioSesion.Clear()
        Dim esValido As Boolean = True
        Dim primerInvalido As Control = Nothing
        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            erpInicioSesion.SetError(txtUsuario, "Ingresa tu usuario.")
            esValido = False
            primerInvalido = txtUsuario
        End If
        If String.IsNullOrEmpty(txtContrasena.Text) Then
            erpInicioSesion.SetError(txtContrasena, "Ingresa tu contraseña.")
            esValido = False
            If primerInvalido Is Nothing Then primerInvalido = txtContrasena
        End If
        If primerInvalido IsNot Nothing Then primerInvalido.Focus()
        Return esValido
    End Function

    Private Sub AbrirPrincipal(usuario As UsuarioAutenticado)
        Dim principal As New FrmPrincipal(usuario)
        My.Application.EstablecerFormularioPrincipal(principal)
        principal.Show()
        Close()
    End Sub
End Class
