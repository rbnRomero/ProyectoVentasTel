Imports ProyectoVentasTel.Aplicacion.Seguridad
Imports ProyectoVentasTel.Dominio.Productos
Imports ProyectoVentasTel.Dominio.Seguridad
Imports ProyectoVentasTel.Infraestructura.Datos
Imports ProyectoVentasTel.Infraestructura.Imagenes

Namespace Aplicacion.Servicios
    Public NotInheritable Class ServicioProductos
        Private ReadOnly repositorio As IRepositorioProductos
        Private ReadOnly imagenes As IAlmacenImagenesProductos

        Public Sub New(Optional repositorioProductos As IRepositorioProductos = Nothing,
                       Optional almacenImagenes As IAlmacenImagenesProductos = Nothing)
            repositorio = If(repositorioProductos, New RepositorioProductosSqlServer())
            imagenes = If(almacenImagenes, New AlmacenImagenesProductos())
        End Sub

        Public Shared Function PuedeAdministrar() As Boolean
            Dim usuario = SesionActual.Usuario
            Return usuario IsNot Nothing AndAlso
                (usuario.Rol = RolUsuario.Administrador OrElse usuario.Rol = RolUsuario.Inventarios)
        End Function

        Private Shared Sub ExigirConsulta()
            If Not SesionActual.PuedeAcceder(ModuloAplicacion.Productos) Then
                Throw New UnauthorizedAccessException("No tienes permiso para consultar productos.")
            End If
        End Sub

        Private Shared Sub ExigirEscritura()
            If Not PuedeAdministrar() Then
                Throw New UnauthorizedAccessException("No tienes permiso para agregar o editar productos.")
            End If
        End Sub

        Public Function ConsultarProductos(filtro As FiltroProductos) As IReadOnlyList(Of Producto)
            ExigirConsulta()
            Dim normalizado As New FiltroProductos With {
                .Texto = If(filtro?.Texto, String.Empty).Trim(),
                .Tipo = If(filtro Is Nothing, Nothing, filtro.Tipo),
                .Activo = If(filtro Is Nothing, Nothing, filtro.Activo)}
            If normalizado.Texto.Length > 100 Then normalizado.Texto = normalizado.Texto.Substring(0, 100)
            If normalizado.Tipo.HasValue AndAlso Not [Enum].IsDefined(GetType(TipoProducto), normalizado.Tipo.Value) Then
                Throw New ArgumentException("El tipo de producto no es válido.")
            End If
            Return repositorio.Consultar(normalizado)
        End Function

        Public Function ObtenerProducto(idProducto As Integer) As Producto
            ExigirConsulta()
            If idProducto <= 0 Then Throw New ArgumentException("El producto indicado no es válido.")
            Dim producto = repositorio.ObtenerPorId(idProducto)
            If producto Is Nothing Then Throw New ProductoNoEncontradoException()
            Return producto
        End Function

        Public Function CrearProducto(solicitud As SolicitudNuevoProducto) As Integer
            ExigirEscritura()
            Dim datos = ValidarDatos(solicitud)
            If repositorio.HayDuplicado(datos, 0) Then Throw New ProductoDuplicadoException()
            Dim copia As String = Nothing
            Try
                If Not String.IsNullOrWhiteSpace(solicitud.ArchivoImagenNuevo) Then copia = imagenes.Copiar(solicitud.ArchivoImagenNuevo)
                Return repositorio.Crear(datos, copia)
            Catch
                LimpiarCopia(copia)
                Throw
            End Try
        End Function

        Public Sub ActualizarProducto(solicitud As SolicitudEdicionProducto)
            ExigirEscritura()
            Dim datos = ValidarDatos(solicitud)
            Dim actual = ObtenerProducto(solicitud.IdProducto)
            If repositorio.HayDuplicado(datos, actual.IdProducto) Then Throw New ProductoDuplicadoException()
            Dim ruta = If(solicitud.QuitarImagen, Nothing, actual.RutaImagen)
            Dim copia As String = Nothing
            Try
                If Not String.IsNullOrWhiteSpace(solicitud.ArchivoImagenNuevo) Then
                    copia = imagenes.Copiar(solicitud.ArchivoImagenNuevo)
                    ruta = copia
                End If
                repositorio.Actualizar(actual.IdProducto, datos, ruta)
            Catch
                LimpiarCopia(copia)
                Throw
            End Try
        End Sub

        Private Sub LimpiarCopia(ruta As String)
            If ruta Is Nothing Then Return
            Try
                imagenes.EliminarCopia(ruta)
            Catch ex As Exception
                Diagnostics.Trace.TraceWarning("No se pudo eliminar una copia de imagen no guardada.")
            End Try
        End Sub

        Public Shared Function ValidarDatos(datos As DatosProducto) As DatosProducto
            If datos Is Nothing Then Throw New ArgumentNullException(NameOf(datos))
            If Not [Enum].IsDefined(GetType(TipoProducto), datos.Tipo) Then Throw New ArgumentException("Selecciona un tipo de producto válido.", "Tipo")
            If datos.PrecioVenta <= 0D OrElse datos.PrecioVenta > 9999999999.99D OrElse Decimal.Round(datos.PrecioVenta, 2) <> datos.PrecioVenta Then
                Throw New ArgumentException("El precio debe ser positivo, tener como máximo dos decimales y no exceder 9,999,999,999.99.", "PrecioVenta")
            End If
            Dim esTelefono = datos.Tipo = TipoProducto.Telefono
            If esTelefono AndAlso (Not datos.CapacidadGB.HasValue OrElse datos.CapacidadGB.Value <= 0) Then
                Throw New ArgumentException("Ingresa una capacidad entera positiva en GB.", "CapacidadGB")
            End If
            Return New DatosProducto With {
                .Codigo = Texto(datos.Codigo, 30, True, "Codigo"),
                .Nombre = Texto(datos.Nombre, 100, True, "Nombre"),
                .Tipo = datos.Tipo,
                .Marca = Texto(datos.Marca, 50, esTelefono, "Marca"),
                .Modelo = Texto(datos.Modelo, 80, esTelefono, "Modelo"),
                .Color = Texto(datos.Color, 30, esTelefono, "Color"),
                .CapacidadGB = If(esTelefono, datos.CapacidadGB, Nothing),
                .PrecioVenta = datos.PrecioVenta, .Activo = datos.Activo}
        End Function

        Private Shared Function Texto(valor As String, maximo As Integer, obligatorio As Boolean, campo As String) As String
            Dim limpio = If(valor, String.Empty).Trim()
            If obligatorio AndAlso limpio.Length = 0 Then Throw New ArgumentException("Este campo es obligatorio.", campo)
            If limpio.Length > maximo Then Throw New ArgumentException(String.Format("No puede exceder {0} caracteres.", maximo), campo)
            Return If(limpio.Length = 0, Nothing, limpio)
        End Function
    End Class
End Namespace
