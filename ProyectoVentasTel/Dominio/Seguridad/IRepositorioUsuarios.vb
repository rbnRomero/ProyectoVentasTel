Namespace Dominio.Seguridad
    Public Interface IRepositorioUsuarios
        Function ObtenerUsuarioActivoPorNombreUsuario(nombreUsuario As String) As UsuarioAutenticado
    End Interface
End Namespace
