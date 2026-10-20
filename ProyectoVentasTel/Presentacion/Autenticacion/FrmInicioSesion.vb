Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.Automation
Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Seguridad

Public Class FrmInicioSesion
    Private ReadOnly servicioAutenticacion As New ServicioAutenticacion()

    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        Text = "Inicio de Sesión"
        txtContrasena.UseSystemPasswordChar = True
        btnMostrarContrasena.Text = "Mostrar"
        btnMostrarContrasena.AccessibleName = "Mostrar contraseña"
        btnMostrarContrasena.AccessibleDescription = "Alterna la visibilidad de la contraseña"
        txtUsuario.AccessibleName = "Usuario"
        txtContrasena.AccessibleName = "Contraseña"
        lblUsuario.Text = "&Usuario"
        lblContrasena.Text = "&Contraseña"
        UiTema.ConfigurarMensaje(lblMensaje)
        lblMensaje.ForeColor = UiTema.Peligro
        AcceptButton = btnEntrar
        lblMensaje.Text = String.Empty
        txtUsuario.Focus()
    End Sub

    Private Sub btnMostrarContrasena_Click(sender As Object, e As EventArgs) Handles btnMostrarContrasena.Click
        txtContrasena.UseSystemPasswordChar = Not txtContrasena.UseSystemPasswordChar
        btnMostrarContrasena.Text = If(txtContrasena.UseSystemPasswordChar, "Mostrar", "Ocultar")
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
