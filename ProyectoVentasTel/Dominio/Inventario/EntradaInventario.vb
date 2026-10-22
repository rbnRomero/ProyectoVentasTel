Namespace Dominio.Inventario
    Public NotInheritable Class ProductoEntrada
        Public Property IdProducto As Integer
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Existencias As Integer
        Public ReadOnly Property DisplayText As String
            Get
                Return Codigo & " · " & Nombre
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return Codigo & " · " & Nombre
        End Function
    End Class

    Public NotInheritable Class EntradaInventario
        Public Property IdEntrada As Integer
        Public Property FechaHora As DateTime
        Public Property CodigoProducto As String
        Public Property NombreProducto As String
        Public Property Cantidad As Integer
        Public Property Usuario As String
        Public Property Observaciones As String
    End Class

    Public Interface IRepositorioEntradasInventario
        Function ProductosActivos() As IReadOnlyList(Of ProductoEntrada)
        Function Consultar() As IReadOnlyList(Of EntradaInventario)
        Function Registrar(idProducto As Integer, idUsuario As Integer, cantidad As Integer, observaciones As String) As Integer
    End Interface
End Namespace
