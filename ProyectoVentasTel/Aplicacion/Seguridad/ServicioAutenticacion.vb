Imports ProyectoVentasTel.Dominio.Seguridad
Imports ProyectoVentasTel.Infraestructura.Datos

Namespace Aplicacion.Seguridad
    Public NotInheritable Class ServicioAutenticacion
        Private ReadOnly repositorioUsuarios As IRepositorioUsuarios

        Public Sub New(Optional repositorio As IRepositorioUsuarios = Nothing)
            repositorioUsuarios = If(repositorio, New RepositorioUsuariosSqlServer())
        End Sub

        Public Function Autenticar(nombreUsuario As String, contrasena As String) As UsuarioAutenticado
            If String.IsNullOrWhiteSpace(nombreUsuario) OrElse String.IsNullOrEmpty(contrasena) Then
                Return Nothing
            End If

            Dim usuario As UsuarioAutenticado = repositorioUsuarios.ObtenerUsuarioActivoPorNombreUsuario(nombreUsuario.Trim())
            If usuario Is Nothing OrElse usuario.Rol = RolUsuario.Desconocido OrElse
               Not HashContrasena.Verificar(contrasena, usuario.ContrasenaHash) Then
                Return Nothing
            End If

            usuario.ContrasenaHash = Nothing
            Return usuario
        End Function
    End Class
End Namespace
