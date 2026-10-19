Imports System.Configuration
Imports System.Data.SqlClient
Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Seguridad

Public Class FrmInicioSesion
    Private ReadOnly servicioAutenticacion As New ServicioAutenticacion()

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Inicio de Sesión"
        txtContrasena.UseSystemPasswordChar = True
        btnMostrarContrasena.Text = "Mostrar"
        AcceptButton = btnEntrar
        lblMensaje.Text = String.Empty
        txtUsuario.Focus()
    End Sub

    Private Sub btnMostrarContrasena_Click(sender As Object, e As EventArgs) Handles btnMostrarContrasena.Click
        txtContrasena.UseSystemPasswordChar = Not txtContrasena.UseSystemPasswordChar
        btnMostrarContrasena.Text = If(txtContrasena.UseSystemPasswordChar, "Mostrar", "Ocultar")
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
        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            erpInicioSesion.SetError(txtUsuario, "Ingresa tu usuario.")
            esValido = False
        End If
        If String.IsNullOrEmpty(txtContrasena.Text) Then
            erpInicioSesion.SetError(txtContrasena, "Ingresa tu contraseña.")
            esValido = False
        End If
        Return esValido
    End Function

    Private Sub AbrirPrincipal(usuario As UsuarioAutenticado)
        Dim principal As New FrmPrincipal(usuario)
        My.Application.EstablecerFormularioPrincipal(principal)
        principal.Show()
        Close()
    End Sub
End Class
