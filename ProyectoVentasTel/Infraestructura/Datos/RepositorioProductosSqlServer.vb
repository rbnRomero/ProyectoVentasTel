Imports System.Data.SqlClient
Imports ProyectoVentasTel.Dominio.Productos

Namespace Infraestructura.Datos
    Public NotInheritable Class RepositorioProductosSqlServer
        Implements IRepositorioProductos

        Private Const Columnas As String = "IdProducto, Codigo, Nombre, TipoProducto, Marca, Modelo, CapacidadGB, Color, PrecioVenta, Existencias, RutaImagen, Activo"

        Public Function Consultar(filtro As FiltroProductos) As IReadOnlyList(Of Producto) Implements IRepositorioProductos.Consultar
            Dim resultado As New List(Of Producto)()
            Const condicion As String = " WHERE (@Texto = N'' OR Codigo LIKE @Patron ESCAPE '~' OR Nombre LIKE @Patron ESCAPE '~' OR Marca LIKE @Patron ESCAPE '~' OR Modelo LIKE @Patron ESCAPE '~') AND (@Tipo IS NULL OR TipoProducto = @Tipo) AND (@Activo IS NULL OR Activo = @Activo) ORDER BY Nombre, Codigo, IdProducto;"
            Using conexion = ConexionSqlServer.Crear(), comando As New SqlCommand("SELECT " & Columnas & " FROM dbo.Productos" & condicion, conexion)
                comando.Parameters.Add("@Texto", SqlDbType.NVarChar, 100).Value = filtro.Texto
                Dim patron = filtro.Texto.Replace("~", "~~").Replace("%", "~%").Replace("_", "~_").Replace("[", "~[")
                comando.Parameters.Add("@Patron", SqlDbType.NVarChar, 202).Value = "%" & patron & "%"
                comando.Parameters.Add("@Tipo", SqlDbType.VarChar, 10).Value = If(filtro.Tipo.HasValue, CType(filtro.Tipo.GetValueOrDefault().ToString(), Object), DBNull.Value)
                comando.Parameters.Add("@Activo", SqlDbType.Bit).Value = If(filtro.Activo.HasValue, CType(filtro.Activo.GetValueOrDefault(), Object), DBNull.Value)
                conexion.Open()
                Using lector = comando.ExecuteReader()
                    While lector.Read()
                        resultado.Add(Leer(lector))
                    End While
                End Using
            End Using
            Return resultado
        End Function

        Public Function ObtenerPorId(idProducto As Integer) As Producto Implements IRepositorioProductos.ObtenerPorId
            Using conexion = ConexionSqlServer.Crear(), comando As New SqlCommand("SELECT " & Columnas & " FROM dbo.Productos WHERE IdProducto = @Id;", conexion)
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = idProducto
                conexion.Open()
                Using lector = comando.ExecuteReader()
                    If lector.Read() Then Return Leer(lector)
                End Using
            End Using
            Return Nothing
        End Function

        Public Function HayDuplicado(datos As DatosProducto, idExcluido As Integer) As Boolean Implements IRepositorioProductos.HayDuplicado
            Const sql As String = "SELECT CASE WHEN EXISTS (SELECT 1 FROM dbo.Productos WHERE IdProducto <> @Id AND (Codigo = @Codigo OR (@Tipo = 'Telefono' AND TipoProducto = 'Telefono' AND Marca = @Marca AND Modelo = @Modelo AND CapacidadGB = @Capacidad AND Color = @Color))) THEN 1 ELSE 0 END;"
            Using conexion = ConexionSqlServer.Crear(), comando As New SqlCommand(sql, conexion)
                AgregarParametros(comando, datos, Nothing)
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = idExcluido
                conexion.Open()
                Return CInt(comando.ExecuteScalar()) = 1
            End Using
        End Function

        Public Function Crear(datos As DatosProducto, rutaImagen As String) As Integer Implements IRepositorioProductos.Crear
            Const sql As String = "INSERT INTO dbo.Productos (Codigo, Nombre, TipoProducto, Marca, Modelo, CapacidadGB, Color, PrecioVenta, RutaImagen, Activo) VALUES (@Codigo, @Nombre, @Tipo, @Marca, @Modelo, @Capacidad, @Color, @Precio, @Ruta, @Activo); SELECT CAST(SCOPE_IDENTITY() AS INT);"
            Try
                Using conexion = ConexionSqlServer.Crear(), comando As New SqlCommand(sql, conexion)
                    AgregarParametros(comando, datos, rutaImagen)
                    conexion.Open()
                    Return CInt(comando.ExecuteScalar())
                End Using
            Catch ex As SqlException When ex.Number = 2601 OrElse ex.Number = 2627
                Throw New ProductoDuplicadoException()
            End Try
        End Function

        Public Sub Actualizar(idProducto As Integer, datos As DatosProducto, rutaImagen As String) Implements IRepositorioProductos.Actualizar
            ' Existencias pertenece a los movimientos de inventario y ventas; nunca se escribe aquí.
            Const sql As String = "UPDATE dbo.Productos SET Codigo=@Codigo, Nombre=@Nombre, TipoProducto=@Tipo, Marca=@Marca, Modelo=@Modelo, CapacidadGB=@Capacidad, Color=@Color, PrecioVenta=@Precio, RutaImagen=@Ruta, Activo=@Activo WHERE IdProducto=@Id;"
            Try
                Using conexion = ConexionSqlServer.Crear(), comando As New SqlCommand(sql, conexion)
                    AgregarParametros(comando, datos, rutaImagen)
                    comando.Parameters.Add("@Id", SqlDbType.Int).Value = idProducto
                    conexion.Open()
                    If comando.ExecuteNonQuery() = 0 Then Throw New ProductoNoEncontradoException()
                End Using
            Catch ex As SqlException When ex.Number = 2601 OrElse ex.Number = 2627
                Throw New ProductoDuplicadoException()
            End Try
        End Sub

        Private Shared Sub AgregarParametros(comando As SqlCommand, datos As DatosProducto, rutaImagen As String)
            comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = datos.Codigo
            comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = datos.Nombre
            comando.Parameters.Add("@Tipo", SqlDbType.VarChar, 10).Value = datos.Tipo.ToString()
            comando.Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = If(CType(datos.Marca, Object), DBNull.Value)
            comando.Parameters.Add("@Modelo", SqlDbType.NVarChar, 80).Value = If(CType(datos.Modelo, Object), DBNull.Value)
            comando.Parameters.Add("@Color", SqlDbType.NVarChar, 30).Value = If(CType(datos.Color, Object), DBNull.Value)
            comando.Parameters.Add("@Capacidad", SqlDbType.Int).Value = If(datos.CapacidadGB.HasValue, CType(datos.CapacidadGB.GetValueOrDefault(), Object), DBNull.Value)
            Dim precio = comando.Parameters.Add("@Precio", SqlDbType.Decimal)
            precio.Precision = 12
            precio.Scale = 2
            precio.Value = datos.PrecioVenta
            comando.Parameters.Add("@Ruta", SqlDbType.NVarChar, 500).Value = If(CType(rutaImagen, Object), DBNull.Value)
            comando.Parameters.Add("@Activo", SqlDbType.Bit).Value = datos.Activo
        End Sub

        Private Shared Function Leer(lector As SqlDataReader) As Producto
            Return New Producto With {
                .IdProducto = lector.GetInt32(0), .Codigo = lector.GetString(1), .Nombre = lector.GetString(2),
                .Tipo = If(lector.GetString(3) = "Telefono", TipoProducto.Telefono, TipoProducto.Accesorio),
                .Marca = If(lector.IsDBNull(4), Nothing, lector.GetString(4)),
                .Modelo = If(lector.IsDBNull(5), Nothing, lector.GetString(5)),
                .CapacidadGB = If(lector.IsDBNull(6), CType(Nothing, Integer?), lector.GetInt32(6)),
                .Color = If(lector.IsDBNull(7), Nothing, lector.GetString(7)),
                .PrecioVenta = lector.GetDecimal(8), .Existencias = lector.GetInt32(9),
                .RutaImagen = If(lector.IsDBNull(10), Nothing, lector.GetString(10)), .Activo = lector.GetBoolean(11)}
        End Function
    End Class
End Namespace
