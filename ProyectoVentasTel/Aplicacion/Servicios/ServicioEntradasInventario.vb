Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Inventario
Imports ProyectoVentasTel.Dominio.Seguridad
Imports ProyectoVentasTel.Infraestructura.Datos

Namespace Aplicacion.Servicios
    Public NotInheritable Class ServicioEntradasInventario
        Private ReadOnly repositorio As IRepositorioEntradasInventario

        Public Sub New(Optional repositorioEntradas As IRepositorioEntradasInventario = Nothing)
            repositorio = If(repositorioEntradas, New RepositorioEntradasInventarioSqlServer())
        End Sub

        Public Function ProductosActivos() As IReadOnlyList(Of ProductoEntrada)
            ExigirPermiso()
            Return repositorio.ProductosActivos()
        End Function

        Public Function Consultar() As IReadOnlyList(Of EntradaInventario)
            ExigirPermiso()
            Return repositorio.Consultar()
        End Function

        Public Function Registrar(idProducto As Integer, cantidad As Integer, observaciones As String) As Integer
            ExigirPermiso()
            If idProducto <= 0 Then Throw New ArgumentException("Selecciona un producto válido.", NameOf(idProducto))
            If cantidad <= 0 Then Throw New ArgumentException("La cantidad debe ser un entero positivo.", NameOf(cantidad))
            Dim texto = If(observaciones, String.Empty).Trim()
            If texto.Length > 250 Then Throw New ArgumentException("Las observaciones no pueden exceder 250 caracteres.", NameOf(observaciones))
            Return repositorio.Registrar(idProducto, SesionActual.Usuario.IdUsuario, cantidad, If(texto.Length = 0, Nothing, texto))
        End Function

        Private Shared Sub ExigirPermiso()
            Dim usuario = SesionActual.Usuario
            If usuario Is Nothing OrElse (usuario.Rol <> RolUsuario.Administrador AndAlso usuario.Rol <> RolUsuario.Inventarios) OrElse Not SesionActual.PuedeAcceder(ModuloAplicacion.EntradasInventario) Then
                Throw New UnauthorizedAccessException("No tienes permiso para consultar o registrar entradas de inventario.")
            End If
        End Sub
    End Class
End Namespace
