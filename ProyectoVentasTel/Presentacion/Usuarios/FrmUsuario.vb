Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Seguridad

Public Class FrmUsuario
    Private ReadOnly servicioUsuarios As ServicioUsuarios
    Private ReadOnly usuarioParaEdicion As UsuarioListado
    Private ReadOnly idUsuarioActual As Integer

    Public Sub New()
        Me.New(Nothing, 0, New ServicioUsuarios())
    End Sub

    Private Sub New(usuario As UsuarioListado, idUsuarioEnSesion As Integer, servicio As ServicioUsuarios)
        If servicio Is Nothing Then Throw New ArgumentNullException(NameOf(servicio))
        If usuario IsNot Nothing AndAlso idUsuarioEnSesion <= 0 Then
            Throw New ArgumentOutOfRangeException(NameOf(idUsuarioEnSesion))
        End If

        InitializeComponent()
        servicioUsuarios = servicio
        usuarioParaEdicion = usuario
        idUsuarioActual = idUsuarioEnSesion
        StartPosition = FormStartPosition.CenterParent
    End Sub

    Public Shared Function CrearNuevo(Optional servicio As ServicioUsuarios = Nothing) As FrmUsuario
        Return New FrmUsuario(Nothing, 0, If(servicio, New ServicioUsuarios()))
    End Function

    Public Shared Function CrearParaEdicion(usuario As UsuarioListado,
                                             idUsuarioEnSesion As Integer,
                                             Optional servicio As ServicioUsuarios = Nothing) As FrmUsuario
        If usuario Is Nothing Then Throw New ArgumentNullException(NameOf(usuario))

        Return New FrmUsuario(usuario, idUsuarioEnSesion, If(servicio, New ServicioUsuarios()))
    End Function

    Private ReadOnly Property EsEdicion As Boolean
        Get
            Return usuarioParaEdicion IsNot Nothing
        End Get
    End Property

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        lblAvisoContrasena.ForeColor = UiTema.Advertencia
        lblAvisoContrasena.AccessibleName = "Aviso sobre contraseña"
        lblAvisoContrasena.AccessibleRole = AccessibleRole.StaticText

        cboRol.DropDownStyle = ComboBoxStyle.DropDownList
        txtNombreCompleto.MaxLength = 100
        txtNombreUsuario.MaxLength = 50
        txtContrasena.MaxLength = 128
        txtContrasena.UseSystemPasswordChar = True

        ConfigurarModo()
        AcceptButton = btnGuardar
        CancelButton = btnCancelar
        txtNombreCompleto.Focus()
    End Sub

    Private Sub ConfigurarModo()
        If EsEdicion Then
            Text = "Editar usuario"
            lblTitulo.Text = "Editar usuario"
            btnGuardar.Text = "Guardar cambios"
            lblContrasena.Text = "Contraseña (opcional)"
            lblAvisoContrasena.Visible = True

            txtNombreCompleto.Text = usuarioParaEdicion.NombreCompleto
            txtNombreUsuario.Text = usuarioParaEdicion.NombreUsuario
            cboRol.SelectedItem = usuarioParaEdicion.Rol.ToString()
            chkActivo.Checked = usuarioParaEdicion.Activo
            txtContrasena.Clear()
        Else
            Text = "Nuevo usuario"
            lblTitulo.Text = "Nuevo usuario"
            btnGuardar.Text = "Guardar usuario"
            lblContrasena.Text = "Contraseña"
            lblAvisoContrasena.Visible = False
            cboRol.SelectedIndex = -1
            chkActivo.Checked = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarFormulario() Then Return

        btnGuardar.Enabled = False
        Try
            If EsEdicion Then
                servicioUsuarios.ActualizarUsuario(CrearSolicitudEdicion(), idUsuarioActual)
            Else
                servicioUsuarios.CrearUsuario(CrearSolicitudNuevo())
            End If

            DialogResult = DialogResult.OK
            Close()
        Catch ex As NombreUsuarioDuplicadoException
            erpUsuario.SetError(txtNombreUsuario, "El nombre de usuario ya existe.")
            txtNombreUsuario.Focus()
            MostrarMensaje("El nombre de usuario ya existe.", MessageBoxIcon.Warning)
        Catch ex As OperacionUsuarioNoPermitidaException
            MostrarMensaje("No puedes desactivar tu propia cuenta ni quitarle el rol de Administrador.", MessageBoxIcon.Warning)
        Catch ex As UltimoAdministradorActivoException
            MostrarMensaje("Debe permanecer al menos un administrador activo.", MessageBoxIcon.Warning)
        Catch ex As UsuarioNoEncontradoException
            MostrarMensaje("El usuario seleccionado ya no existe. Actualiza la lista e intenta nuevamente.", MessageBoxIcon.Warning)
        Catch ex As ArgumentException
            MostrarMensaje(ex.Message, MessageBoxIcon.Warning)
        Catch ex As Exception
            MostrarMensaje("No se pudo guardar el usuario. Intenta nuevamente más tarde.", MessageBoxIcon.Error)
        Finally
            btnGuardar.Enabled = True
        End Try
    End Sub

    Private Function CrearSolicitudNuevo() As SolicitudNuevoUsuario
        Return New SolicitudNuevoUsuario With {
            .NombreCompleto = txtNombreCompleto.Text.Trim(),
            .NombreUsuario = txtNombreUsuario.Text.Trim(),
            .Rol = ObtenerRolSeleccionado(),
            .Activo = chkActivo.Checked,
            .Contrasena = txtContrasena.Text
        }
    End Function

    Private Function CrearSolicitudEdicion() As SolicitudEdicionUsuario
        Return New SolicitudEdicionUsuario With {
            .IdUsuario = usuarioParaEdicion.IdUsuario,
            .NombreCompleto = txtNombreCompleto.Text.Trim(),
            .NombreUsuario = txtNombreUsuario.Text.Trim(),
            .Rol = ObtenerRolSeleccionado(),
            .Activo = chkActivo.Checked,
            .NuevaContrasena = txtContrasena.Text
        }
    End Function

    Private Function ObtenerRolSeleccionado() As RolUsuario
        Select Case Convert.ToString(cboRol.SelectedItem)
            Case "Administrador"
                Return RolUsuario.Administrador
            Case "Vendedor"
                Return RolUsuario.Vendedor
            Case "Inventarios"
                Return RolUsuario.Inventarios
            Case Else
                Return RolUsuario.Desconocido
        End Select
    End Function

    Private Function ValidarFormulario() As Boolean
        erpUsuario.Clear()

        Dim esValido As Boolean = True
        Dim primerInvalido As Control = Nothing

        If String.IsNullOrWhiteSpace(txtNombreCompleto.Text) Then
            MarcarInvalido(txtNombreCompleto, "Ingresa el nombre completo.", esValido, primerInvalido)
        End If

        If String.IsNullOrWhiteSpace(txtNombreUsuario.Text) Then
            MarcarInvalido(txtNombreUsuario, "Ingresa el nombre de usuario.", esValido, primerInvalido)
        End If

        If ObtenerRolSeleccionado() = RolUsuario.Desconocido Then
            MarcarInvalido(cboRol, "Selecciona un rol.", esValido, primerInvalido)
        End If

        If Not EsEdicion AndAlso String.IsNullOrWhiteSpace(txtContrasena.Text) Then
            MarcarInvalido(txtContrasena, "Ingresa una contraseña.", esValido, primerInvalido)
        ElseIf txtContrasena.Text.Length > 0 AndAlso (txtContrasena.Text.Length < 8 OrElse txtContrasena.Text.Length > 128) Then
            MarcarInvalido(txtContrasena, "La contraseña debe tener entre 8 y 128 caracteres.", esValido, primerInvalido)
        End If

        If primerInvalido IsNot Nothing Then primerInvalido.Focus()
        Return esValido
    End Function

    Private Sub MarcarInvalido(control As Control,
                               mensaje As String,
                               ByRef esValido As Boolean,
                               ByRef primerInvalido As Control)
        erpUsuario.SetError(control, mensaje)
        esValido = False
        If primerInvalido Is Nothing Then primerInvalido = control
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub MostrarMensaje(mensaje As String, icono As MessageBoxIcon)
        MessageBox.Show(Me, mensaje, "Usuarios", MessageBoxButtons.OK, icono)
    End Sub
End Class
