Namespace Dominio.Seguridad
    Public Interface IRepositorioUsuarios
        Function ObtenerUsuarioActivoPorNombreUsuario(nombreUsuario As String) As UsuarioAutenticado
        Function ConsultarUsuarios(filtro As FiltroUsuarios) As IReadOnlyList(Of UsuarioListado)
        Function CrearUsuario(perfil As PerfilUsuario, contrasenaHash As String) As Integer
        Function ActualizarUsuario(idUsuario As Integer, perfil As PerfilUsuario, nuevaContrasenaHash As String) As ResultadoActualizacionUsuario
    End Interface
End Namespace
