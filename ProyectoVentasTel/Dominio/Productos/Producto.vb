Namespace Dominio.Productos
    Public Enum TipoProducto
        Telefono
        Accesorio
    End Enum

    Public Class DatosProducto
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Tipo As TipoProducto
        Public Property Marca As String
        Public Property Modelo As String
        Public Property CapacidadGB As Integer?
        Public Property Color As String
        Public Property PrecioVenta As Decimal
        Public Property Activo As Boolean
    End Class

    Public NotInheritable Class Producto
        Inherits DatosProducto
        Public Property IdProducto As Integer
        Public Property Existencias As Integer
        Public Property RutaImagen As String
    End Class

    Public Class SolicitudNuevoProducto
        Inherits DatosProducto
        Public Property ArchivoImagenNuevo As String
        Public Property QuitarImagen As Boolean
    End Class

    Public NotInheritable Class SolicitudEdicionProducto
        Inherits SolicitudNuevoProducto
        Public Property IdProducto As Integer
    End Class

    Public NotInheritable Class FiltroProductos
        Public Property Texto As String
        Public Property Tipo As TipoProducto?
        Public Property Activo As Boolean?
    End Class

    Public Interface IRepositorioProductos
        Function Consultar(filtro As FiltroProductos) As IReadOnlyList(Of Producto)
        Function ObtenerPorId(idProducto As Integer) As Producto
        Function HayDuplicado(datos As DatosProducto, idExcluido As Integer) As Boolean
        Function Crear(datos As DatosProducto, rutaImagen As String) As Integer
        Sub Actualizar(idProducto As Integer, datos As DatosProducto, rutaImagen As String)
    End Interface

    Public Interface IAlmacenImagenesProductos
        Function Copiar(archivo As String) As String
        Sub EliminarCopia(ruta As String)
    End Interface

    Public NotInheritable Class AlmacenamientoImagenException
        Inherits Exception
        Public Sub New(mensaje As String)
            MyBase.New(mensaje)
        End Sub
    End Class

    Public NotInheritable Class ProductoDuplicadoException
        Inherits Exception
        Public Sub New()
            MyBase.New("Ya existe un producto con ese código o una variante de teléfono con la misma marca, modelo, capacidad y color.")
        End Sub
    End Class

    Public NotInheritable Class ProductoNoEncontradoException
        Inherits Exception
        Public Sub New()
            MyBase.New("El producto seleccionado ya no existe. Actualiza la lista e intenta nuevamente.")
        End Sub
    End Class
End Namespace
