Namespace Dominio.Seguridad
    Public NotInheritable Class UsuarioAutenticado
        Public Property IdUsuario As Integer
        Public Property NombreCompleto As String
        Public Property NombreUsuario As String
        Public Property Rol As RolUsuario
        Public Property ContrasenaHash As String
    End Class
End Namespace
