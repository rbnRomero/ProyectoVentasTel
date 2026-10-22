Imports ProyectoVentasTel.Dominio.Seguridad

Namespace Dominio.Ventas
    Public NotInheritable Class ProductoParaVenta
        Public Property IdProducto As Integer
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Precio As Decimal
        Public Property Existencias As Integer
    End Class

    Public NotInheritable Class ArticuloVenta
        Public Property IdProducto As Integer
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Cantidad As Integer
        Public Property PrecioUnitario As Decimal
        Public ReadOnly Property Subtotal As Decimal
            Get
                Return Decimal.Round(Cantidad * PrecioUnitario, 2)
            End Get
        End Property
    End Class

    Public NotInheritable Class FiltroVentas
        Public Property Desde As Date
        Public Property Hasta As Date
        Public Property Estado As String
    End Class

    Public Class VentaListado
        Public Property IdVenta As Integer
        Public Property Folio As String
        Public Property FechaHora As DateTime
        Public Property Vendedor As String
        Public Property Total As Decimal
        Public Property EfectivoRecibido As Decimal
        Public Property Estado As String
    End Class

    Public NotInheritable Class VentaDetalle
        Inherits VentaListado
        Public Property Articulos As IReadOnlyList(Of ArticuloVenta)
        Public Property IdVendedor As Integer
        Public Property IdUsuarioCancela As Integer?
        Public Property FechaCancelacion As DateTime?
        Public Property MotivoCancelacion As String
        Public Property UsuarioCancela As String
    End Class

    Public Interface IRepositorioVentas
        Function BuscarProductos(texto As String) As IReadOnlyList(Of ProductoParaVenta)
        Function Registrar(idVendedor As Integer, articulos As IReadOnlyList(Of ArticuloVenta), efectivo As Decimal) As String
        Function Consultar(filtro As FiltroVentas) As IReadOnlyList(Of VentaListado)
        Function Obtener(idVenta As Integer) As VentaDetalle
        Sub Cancelar(idVenta As Integer, idUsuarioCancela As Integer, motivo As String, soloPropias As Boolean)
    End Interface

    Public NotInheritable Class ExistenciasInsuficientesException
        Inherits Exception
        Public Sub New()
            MyBase.New("No hay existencias suficientes para completar la venta. Actualiza el catálogo e intenta nuevamente.")
        End Sub
    End Class

    Public NotInheritable Class VentaNoEncontradaException
        Inherits Exception
        Public Sub New()
            MyBase.New("La venta seleccionada ya no existe. Actualiza el historial e intenta nuevamente.")
        End Sub
    End Class
End Namespace
