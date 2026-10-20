Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Aplicacion.Servicios
Imports ProyectoVentasTel.Dominio.Seguridad

Public Class UcUsuarios
    Private ReadOnly servicioUsuarios As New ServicioUsuarios()
    Private ReadOnly usuariosPorId As New Dictionary(Of Integer, UsuarioListado)()
    Private inicializandoFiltros As Boolean

    Private Sub UcUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.ConfigurarBarraAcciones(tlpRaiz, pnlEncabezado, lblTitulo, btnNuevoUsuario, btnEditarUsuario)
        UiTema.ConfigurarEtiqueta(lblBuscar, txtBuscarUsuario, "Buscar")
        UiTema.ConfigurarEtiqueta(lblRol, cboFiltroRol, "Rol")
        UiTema.ConfigurarEtiqueta(lblEstado, cboFiltroEstado, "Estado")
        UiTema.ConfigurarTabla(dgvUsuarios, "usuarios")

        ConfigurarTablaUsuarios()
        InicializarFiltros()
        CargarUsuarios()
    End Sub

    Private Sub ConfigurarTablaUsuarios()
        dgvUsuarios.AutoGenerateColumns = False
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.AllowUserToDeleteRows = False
        dgvUsuarios.AllowUserToOrderColumns = False
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically
        btnEditarUsuario.Enabled = False
    End Sub

    Private Sub InicializarFiltros()
        inicializandoFiltros = True
        Try
            txtBuscarUsuario.MaxLength = 100
            cboFiltroRol.DropDownStyle = ComboBoxStyle.DropDownList
            cboFiltroEstado.DropDownStyle = ComboBoxStyle.DropDownList
            cboFiltroRol.SelectedIndex = 0
            cboFiltroEstado.SelectedIndex = 0
        Finally
            inicializandoFiltros = False
        End Try
    End Sub

    Private Sub txtBuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarUsuario.TextChanged
        RecargarUsuariosSiLosFiltrosEstanListos()
    End Sub

    Private Sub cboFiltroRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroRol.SelectedIndexChanged
        RecargarUsuariosSiLosFiltrosEstanListos()
    End Sub

    Private Sub cboFiltroEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroEstado.SelectedIndexChanged
        RecargarUsuariosSiLosFiltrosEstanListos()
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsuarios.SelectionChanged
        ActualizarEstadoBotonEditar()
    End Sub

    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click
        Using formulario As FrmUsuario = FrmUsuario.CrearNuevo(servicioUsuarios)
            If MostrarDialogo(formulario) = DialogResult.OK Then
                CargarUsuarios()
            End If
        End Using
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        Dim usuarioSeleccionado As UsuarioListado = ObtenerUsuarioSeleccionado()
        If usuarioSeleccionado Is Nothing Then
            ActualizarEstadoBotonEditar()
            Return
        End If

        Dim usuarioActual As UsuarioAutenticado = SesionActual.Usuario
        If usuarioActual Is Nothing Then
            MessageBox.Show(Me, "La sesión actual no es válida.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using formulario As FrmUsuario = FrmUsuario.CrearParaEdicion(usuarioSeleccionado, usuarioActual.IdUsuario, servicioUsuarios)
            If MostrarDialogo(formulario) = DialogResult.OK Then
                CargarUsuarios()
            End If
        End Using
    End Sub

    Private Function MostrarDialogo(formulario As Form) As DialogResult
        Dim formularioPrincipal As Form = FindForm()
        If formularioPrincipal Is Nothing Then
            Return formulario.ShowDialog()
        End If

        Return formulario.ShowDialog(formularioPrincipal)
    End Function

    Private Sub RecargarUsuariosSiLosFiltrosEstanListos()
        If Not inicializandoFiltros AndAlso IsHandleCreated Then
            CargarUsuarios()
        End If
    End Sub

    Private Sub CargarUsuarios()
        dgvUsuarios.Rows.Clear()
        usuariosPorId.Clear()
        lblSinUsuarios.Text = "No hay usuarios para mostrar"

        Try
            Dim filtro As New FiltroUsuarios With {
                .Texto = txtBuscarUsuario.Text,
                .Rol = ObtenerRolSeleccionado(),
                .Activo = ObtenerEstadoSeleccionado()
            }
            Dim usuarios As IReadOnlyList(Of UsuarioListado) = servicioUsuarios.ConsultarUsuarios(filtro)

            If usuarios IsNot Nothing Then
                For Each usuario As UsuarioListado In usuarios
                    usuariosPorId(usuario.IdUsuario) = usuario
                    dgvUsuarios.Rows.Add(
                        usuario.IdUsuario,
                        usuario.NombreCompleto,
                        usuario.NombreUsuario,
                        usuario.Rol.ToString(),
                        If(usuario.Activo, "Activo", "Inactivo"))
                Next
            End If

            lblSinUsuarios.Visible = dgvUsuarios.Rows.Count = 0
        Catch ex As Exception
            dgvUsuarios.Rows.Clear()
            usuariosPorId.Clear()
            lblSinUsuarios.Text = "No se pudieron cargar los usuarios."
            lblSinUsuarios.Visible = True
        Finally
            ActualizarEstadoBotonEditar()
        End Try
    End Sub

    Private Function ObtenerUsuarioSeleccionado() As UsuarioListado
        Dim fila As DataGridViewRow = dgvUsuarios.CurrentRow
        If fila Is Nothing OrElse fila.IsNewRow Then Return Nothing

        Dim idUsuario As Integer
        If Not Integer.TryParse(Convert.ToString(fila.Cells(colIdUsuario.Index).Value), idUsuario) Then Return Nothing

        Dim usuario As UsuarioListado = Nothing
        If usuariosPorId.TryGetValue(idUsuario, usuario) Then Return usuario

        Return Nothing
    End Function

    Private Sub ActualizarEstadoBotonEditar()
        btnEditarUsuario.Enabled = ObtenerUsuarioSeleccionado() IsNot Nothing
    End Sub

    Private Function ObtenerRolSeleccionado() As Nullable(Of RolUsuario)
        Select Case Convert.ToString(cboFiltroRol.SelectedItem)
            Case "Administrador"
                Return RolUsuario.Administrador
            Case "Vendedor"
                Return RolUsuario.Vendedor
            Case "Inventarios"
                Return RolUsuario.Inventarios
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function ObtenerEstadoSeleccionado() As Nullable(Of Boolean)
        Select Case Convert.ToString(cboFiltroEstado.SelectedItem)
            Case "Activos"
                Return True
            Case "Inactivos"
                Return False
            Case Else
                Return Nothing
        End Select
    End Function
End Class
