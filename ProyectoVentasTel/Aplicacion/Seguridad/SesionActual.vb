Imports ProyectoVentasTel.Dominio.Seguridad

Namespace Aplicacion.Seguridad
    Public NotInheritable Class SesionActual
        Private Shared usuarioActual As UsuarioAutenticado

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property Usuario As UsuarioAutenticado
            Get
                Return usuarioActual
            End Get
        End Property

        Public Shared Sub Iniciar(usuario As UsuarioAutenticado)
            If usuario Is Nothing Then
                Throw New ArgumentNullException(NameOf(usuario))
            End If

            usuarioActual = usuario
        End Sub

        Public Shared Sub Cerrar()
            usuarioActual = Nothing
        End Sub

        Public Shared Function PuedeAcceder(modulo As ModuloAplicacion) As Boolean
            If usuarioActual Is Nothing Then
                Return False
            End If

            Select Case usuarioActual.Rol
                Case RolUsuario.Administrador
                    Return True
                Case RolUsuario.Vendedor
                    Return modulo = ModuloAplicacion.Productos OrElse
                           modulo = ModuloAplicacion.Ventas OrElse
                           modulo = ModuloAplicacion.HistorialVentas
                Case RolUsuario.Inventarios
                    Return modulo = ModuloAplicacion.Productos OrElse
                           modulo = ModuloAplicacion.EntradasInventario
                Case Else
                    Return False
            End Select
        End Function
    End Class
End Namespace
