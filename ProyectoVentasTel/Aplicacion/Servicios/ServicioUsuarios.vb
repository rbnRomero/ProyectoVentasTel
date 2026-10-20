Imports ProyectoVentasTel.Dominio.Seguridad
Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Infraestructura.Datos

Namespace Aplicacion.Servicios
    Public NotInheritable Class ServicioUsuarios
        Private Const LongitudMaximaTexto As Integer = 100
        Private Const LongitudMaximaNombreUsuario As Integer = 50
        Private Const LongitudMinimaContrasena As Integer = 8
        Private Const LongitudMaximaContrasena As Integer = 128

        Private ReadOnly repositorioUsuarios As IRepositorioUsuarios

        Public Sub New(Optional repositorio As IRepositorioUsuarios = Nothing)
            repositorioUsuarios = If(repositorio, New RepositorioUsuariosSqlServer())
        End Sub

        Public Function ConsultarUsuarios(filtro As FiltroUsuarios) As IReadOnlyList(Of UsuarioListado)
            Dim filtroNormalizado As FiltroUsuarios = NormalizarFiltro(filtro)
            Return repositorioUsuarios.ConsultarUsuarios(filtroNormalizado)
        End Function

        Public Function CrearUsuario(solicitud As SolicitudNuevoUsuario) As Integer
            If solicitud Is Nothing Then
                Throw New ArgumentNullException(NameOf(solicitud))
            End If

            Dim perfil As PerfilUsuario = CrearPerfil(
                solicitud.NombreCompleto,
                solicitud.NombreUsuario,
                solicitud.Rol,
                solicitud.Activo)
            Dim contrasena As String = ValidarContrasenaObligatoria(solicitud.Contrasena)

            Return repositorioUsuarios.CrearUsuario(perfil, HashContrasena.Crear(contrasena))
        End Function

        Public Sub ActualizarUsuario(solicitud As SolicitudEdicionUsuario, idUsuarioActual As Integer)
            If solicitud Is Nothing Then
                Throw New ArgumentNullException(NameOf(solicitud))
            End If

            If solicitud.IdUsuario <= 0 Then
                Throw New ArgumentOutOfRangeException(NameOf(solicitud.IdUsuario), "El usuario indicado no es válido.")
            End If

            Dim perfil As PerfilUsuario = CrearPerfil(
                solicitud.NombreCompleto,
                solicitud.NombreUsuario,
                solicitud.Rol,
                solicitud.Activo)

            If solicitud.IdUsuario = idUsuarioActual AndAlso
               (perfil.Rol <> RolUsuario.Administrador OrElse Not perfil.Activo) Then
                Throw New OperacionUsuarioNoPermitidaException()
            End If

            Dim nuevaContrasena As String = ValidarContrasenaOpcional(solicitud.NuevaContrasena)
            Dim nuevoHash As String = If(nuevaContrasena Is Nothing, Nothing, HashContrasena.Crear(nuevaContrasena))
            Dim resultado As ResultadoActualizacionUsuario =
                repositorioUsuarios.ActualizarUsuario(solicitud.IdUsuario, perfil, nuevoHash)

            Select Case resultado
                Case ResultadoActualizacionUsuario.Actualizado
                    Return
                Case ResultadoActualizacionUsuario.NoEncontrado
                    Throw New UsuarioNoEncontradoException()
                Case ResultadoActualizacionUsuario.UltimoAdministradorActivo
                    Throw New UltimoAdministradorActivoException()
                Case Else
                    Throw New InvalidOperationException("El resultado de actualización del usuario no es válido.")
            End Select
        End Sub

        Private Shared Function NormalizarFiltro(filtro As FiltroUsuarios) As FiltroUsuarios
            Dim textoBusqueda As String = If(filtro?.Texto, String.Empty).Trim()

            If textoBusqueda.Length > LongitudMaximaTexto Then
                textoBusqueda = textoBusqueda.Substring(0, LongitudMaximaTexto)
            End If

            Dim rol As Nullable(Of RolUsuario) = If(filtro Is Nothing, Nothing, filtro.Rol)
            If rol.HasValue AndAlso Not EsRolValido(rol.Value) Then
                Throw New ArgumentException("El rol seleccionado no es válido.", NameOf(filtro))
            End If

            Return New FiltroUsuarios With {
                .Texto = textoBusqueda,
                .Rol = rol,
                .Activo = If(filtro Is Nothing, Nothing, filtro.Activo)
            }
        End Function

        Private Shared Function CrearPerfil(nombreCompleto As String,
                                            nombreUsuario As String,
                                            rol As RolUsuario,
                                            activo As Boolean) As PerfilUsuario
            Dim nombreCompletoNormalizado As String = NormalizarTexto(nombreCompleto, LongitudMaximaTexto, "El nombre completo")
            Dim nombreUsuarioNormalizado As String = NormalizarTexto(nombreUsuario, LongitudMaximaNombreUsuario, "El nombre de usuario")

            If Not EsRolValido(rol) Then
                Throw New ArgumentException("El rol seleccionado no es válido.", NameOf(rol))
            End If

            Return New PerfilUsuario With {
                .NombreCompleto = nombreCompletoNormalizado,
                .NombreUsuario = nombreUsuarioNormalizado,
                .Rol = rol,
                .Activo = activo
            }
        End Function

        Private Shared Function NormalizarTexto(valor As String, longitudMaxima As Integer, nombreCampo As String) As String
            Dim valorNormalizado As String = If(valor, String.Empty).Trim()

            If valorNormalizado.Length = 0 Then
                Throw New ArgumentException(String.Format("{0} es obligatorio.", nombreCampo))
            End If

            If valorNormalizado.Length > longitudMaxima Then
                Throw New ArgumentException(String.Format("{0} no puede exceder {1} caracteres.", nombreCampo, longitudMaxima))
            End If

            Return valorNormalizado
        End Function

        Private Shared Function ValidarContrasenaObligatoria(contrasena As String) As String
            If String.IsNullOrEmpty(contrasena) Then
                Throw New ArgumentException("La contraseña es obligatoria.", NameOf(contrasena))
            End If

            Return ValidarLongitudContrasena(contrasena)
        End Function

        Private Shared Function ValidarContrasenaOpcional(contrasena As String) As String
            If String.IsNullOrEmpty(contrasena) Then
                Return Nothing
            End If

            Return ValidarLongitudContrasena(contrasena)
        End Function

        Private Shared Function ValidarLongitudContrasena(contrasena As String) As String
            If contrasena.Length < LongitudMinimaContrasena OrElse contrasena.Length > LongitudMaximaContrasena Then
                Throw New ArgumentException(
                    String.Format("La contraseña debe tener entre {0} y {1} caracteres.", LongitudMinimaContrasena, LongitudMaximaContrasena),
                    NameOf(contrasena))
            End If

            Return contrasena
        End Function

        Private Shared Function EsRolValido(rol As RolUsuario) As Boolean
            Select Case rol
                Case RolUsuario.Administrador, RolUsuario.Vendedor, RolUsuario.Inventarios
                    Return True
                Case Else
                    Return False
            End Select
        End Function
    End Class
End Namespace
