Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Seguridad
Imports ProyectoVentasTel.Dominio.Ventas
Imports ProyectoVentasTel.Infraestructura.Datos

Namespace Aplicacion.Servicios
    Public NotInheritable Class ServicioVentas
        Private ReadOnly repositorio As IRepositorioVentas

        Public Sub New(Optional repositorioVentas As IRepositorioVentas = Nothing)
            repositorio = If(repositorioVentas, New RepositorioVentasSqlServer())
        End Sub

        Public Function BuscarProductos(texto As String) As IReadOnlyList(Of ProductoParaVenta)
            ExigirAcceso(ModuloAplicacion.Ventas)
            Return repositorio.BuscarProductos(If(texto, String.Empty).Trim())
        End Function

        Public Function Registrar(articulos As IReadOnlyList(Of ArticuloVenta), efectivo As Decimal) As String
            ExigirAcceso(ModuloAplicacion.Ventas)
            If articulos Is Nothing OrElse articulos.Count = 0 Then Throw New ArgumentException("Agrega al menos un producto a la venta.")
            Dim normalizados As New List(Of ArticuloVenta)()
            For Each articulo In articulos
                If articulo Is Nothing OrElse articulo.IdProducto <= 0 OrElse articulo.Cantidad <= 0 OrElse articulo.PrecioUnitario <= 0D Then Throw New ArgumentException("La venta contiene un artículo inválido.")
                Dim existente = normalizados.FirstOrDefault(Function(x) x.IdProducto = articulo.IdProducto)
                If existente Is Nothing Then
                    normalizados.Add(New ArticuloVenta With {.IdProducto = articulo.IdProducto, .Codigo = articulo.Codigo, .Nombre = articulo.Nombre, .Cantidad = articulo.Cantidad, .PrecioUnitario = Decimal.Round(articulo.PrecioUnitario, 2)})
                Else
                    If CInt(existente.Cantidad) > Integer.MaxValue - articulo.Cantidad Then Throw New ArgumentException("La cantidad solicitada excede el límite permitido.")
                    existente.Cantidad += articulo.Cantidad
                End If
            Next
            Dim total = normalizados.Sum(Function(x) x.Subtotal)
            If total <= 0D OrElse total > 9999999999.99D OrElse Decimal.Round(total, 2) <> total Then Throw New ArgumentException("El total de la venta no es válido.")
            If efectivo < total OrElse efectivo > 9999999999.99D OrElse Decimal.Round(efectivo, 2) <> efectivo Then Throw New ArgumentException("El efectivo recibido debe cubrir el total de la venta.")
            Return repositorio.Registrar(SesionActual.Usuario.IdUsuario, normalizados, efectivo)
        End Function

        Public Function Consultar(filtro As FiltroVentas) As IReadOnlyList(Of VentaListado)
            ExigirAcceso(ModuloAplicacion.HistorialVentas)
            If filtro Is Nothing Then Throw New ArgumentNullException(NameOf(filtro))
            If filtro.Desde.Date > filtro.Hasta.Date Then Throw New ArgumentException("La fecha inicial no puede ser posterior a la fecha final.")
            Return repositorio.Consultar(filtro)
        End Function

        Public Function Obtener(idVenta As Integer) As VentaDetalle
            ExigirAcceso(ModuloAplicacion.HistorialVentas)
            If idVenta <= 0 Then Throw New ArgumentException("La venta indicada no es válida.")
            Dim venta = repositorio.Obtener(idVenta)
            If venta Is Nothing Then Throw New VentaNoEncontradaException()
            Return venta
        End Function

        Public Sub Cancelar(idVenta As Integer, motivo As String)
            ExigirAcceso(ModuloAplicacion.HistorialVentas)
            Dim usuario = SesionActual.Usuario
            Dim limpio = If(motivo, String.Empty).Trim()
            If limpio.Length = 0 OrElse limpio.Length > 250 Then Throw New ArgumentException("Escribe un motivo de hasta 250 caracteres.", NameOf(motivo))
            repositorio.Cancelar(idVenta, usuario.IdUsuario, limpio, usuario.Rol = RolUsuario.Vendedor)
        End Sub

        Private Shared Sub ExigirAcceso(modulo As ModuloAplicacion)
            If Not SesionActual.PuedeAcceder(modulo) Then Throw New UnauthorizedAccessException("No tienes permiso para realizar esta operación.")
        End Sub
    End Class
End Namespace
