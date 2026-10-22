Imports System.Data
Imports System.Data.SqlClient
Imports ProyectoVentasTel.Dominio.Ventas

Namespace Infraestructura.Datos
    Public NotInheritable Class RepositorioVentasSqlServer
        Implements IRepositorioVentas

        Public Function BuscarProductos(texto As String) As IReadOnlyList(Of ProductoParaVenta) Implements IRepositorioVentas.BuscarProductos
            Dim resultado As New List(Of ProductoParaVenta)()
            Using conexion = ConexionSqlServer.Crear(), comando = conexion.CreateCommand()
                comando.CommandText = "SELECT IdProducto,Codigo,Nombre,PrecioVenta,Existencias FROM dbo.Productos WHERE Activo=1 AND Existencias>0 AND (@texto=N'' OR Codigo LIKE N'%' + @texto + N'%' OR Nombre LIKE N'%' + @texto + N'%' OR Marca LIKE N'%' + @texto + N'%' OR Modelo LIKE N'%' + @texto + N'%') ORDER BY Nombre,Codigo;"
                comando.Parameters.Add("@texto", SqlDbType.NVarChar, 100).Value = If(texto, String.Empty)
                conexion.Open()
                Using lector = comando.ExecuteReader()
                    While lector.Read()
                        resultado.Add(New ProductoParaVenta With {.IdProducto = CInt(lector("IdProducto")), .Codigo = CStr(lector("Codigo")), .Nombre = CStr(lector("Nombre")), .Precio = CDec(lector("PrecioVenta")), .Existencias = CInt(lector("Existencias"))})
                    End While
                End Using
            End Using
            Return resultado
        End Function

        Public Function Registrar(idVendedor As Integer, articulos As IReadOnlyList(Of ArticuloVenta), efectivo As Decimal) As String Implements IRepositorioVentas.Registrar
            Using conexion = ConexionSqlServer.Crear()
                conexion.Open()
                Using transaccion = conexion.BeginTransaction(IsolationLevel.Serializable)
                    Try
                        Dim total As Decimal = 0D
                        For Each articulo In articulos
                            Dim precio As Decimal
                            Using comando = New SqlCommand("SELECT PrecioVenta FROM dbo.Productos WITH (UPDLOCK,HOLDLOCK) WHERE IdProducto=@id AND Activo=1;", conexion, transaccion)
                                comando.Parameters.Add("@id", SqlDbType.Int).Value = articulo.IdProducto
                                Dim valor = comando.ExecuteScalar()
                                If valor Is Nothing Then Throw New InvalidOperationException("Uno de los productos ya no está disponible.")
                                precio = CDec(valor)
                            End Using
                            Using comando = New SqlCommand("UPDATE dbo.Productos SET Existencias=Existencias-@cantidad WHERE IdProducto=@id AND Activo=1 AND Existencias>=@cantidad;", conexion, transaccion)
                                comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = articulo.Cantidad
                                comando.Parameters.Add("@id", SqlDbType.Int).Value = articulo.IdProducto
                                If comando.ExecuteNonQuery() <> 1 Then Throw New ExistenciasInsuficientesException()
                            End Using
                            total += precio * articulo.Cantidad
                            articulos.First(Function(x) x.IdProducto = articulo.IdProducto).PrecioUnitario = precio
                        Next
                        If total <= 0D OrElse total > 9999999999.99D OrElse efectivo < total Then Throw New ArgumentException("El efectivo recibido debe cubrir el total actualizado de la venta.")
                        Dim idVenta As Integer
                        Using comando = New SqlCommand("INSERT dbo.Ventas(Folio,IdVendedor,Total,EfectivoRecibido) VALUES(@folio,@vendedor,@total,@efectivo); SELECT CONVERT(INT,SCOPE_IDENTITY());", conexion, transaccion)
                            comando.Parameters.Add("@folio", SqlDbType.NVarChar, 20).Value = "PEND-" & Guid.NewGuid().ToString("N")
                            comando.Parameters.Add("@vendedor", SqlDbType.Int).Value = idVendedor
                            comando.Parameters.Add("@total", SqlDbType.Decimal).Value = total
                            comando.Parameters("@total").Precision = 12 : comando.Parameters("@total").Scale = 2
                            comando.Parameters.Add("@efectivo", SqlDbType.Decimal).Value = efectivo
                            comando.Parameters("@efectivo").Precision = 12 : comando.Parameters("@efectivo").Scale = 2
                            idVenta = CInt(comando.ExecuteScalar())
                        End Using
                        Using comando = New SqlCommand("UPDATE dbo.Ventas SET Folio=@folio WHERE IdVenta=@id;", conexion, transaccion)
                            comando.Parameters.Add("@folio", SqlDbType.NVarChar, 20).Value = "V-" & idVenta.ToString("D10")
                            comando.Parameters.Add("@id", SqlDbType.Int).Value = idVenta
                            comando.ExecuteNonQuery()
                        End Using
                        For Each articulo In articulos
                            Using comando = New SqlCommand("INSERT dbo.DetalleVenta(IdVenta,IdProducto,Cantidad,PrecioUnitario) VALUES(@venta,@producto,@cantidad,@precio);", conexion, transaccion)
                                comando.Parameters.Add("@venta", SqlDbType.Int).Value = idVenta
                                comando.Parameters.Add("@producto", SqlDbType.Int).Value = articulo.IdProducto
                                comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = articulo.Cantidad
                                comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = articulo.PrecioUnitario
                                comando.Parameters("@precio").Precision = 12 : comando.Parameters("@precio").Scale = 2
                                comando.ExecuteNonQuery()
                            End Using
                        Next
                        transaccion.Commit()
                        Return "V-" & idVenta.ToString("D10")
                    Catch
                        transaccion.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Function

        Public Function Consultar(filtro As FiltroVentas) As IReadOnlyList(Of VentaListado) Implements IRepositorioVentas.Consultar
            Dim resultado As New List(Of VentaListado)()
            Using conexion = ConexionSqlServer.Crear(), comando = conexion.CreateCommand()
                comando.CommandText = "SELECT v.IdVenta,v.Folio,v.FechaHora,u.NombreCompleto,v.Total,v.EfectivoRecibido,v.Estado FROM dbo.Ventas v INNER JOIN dbo.Usuarios u ON u.IdUsuario=v.IdVendedor WHERE v.FechaHora>=@desde AND v.FechaHora<DATEADD(DAY,1,@hasta) AND (@estado=N'Todas' OR v.Estado=@estado) ORDER BY v.FechaHora DESC,v.IdVenta DESC;"
                comando.Parameters.Add("@desde", SqlDbType.Date).Value = filtro.Desde.Date
                comando.Parameters.Add("@hasta", SqlDbType.Date).Value = filtro.Hasta.Date
                comando.Parameters.Add("@estado", SqlDbType.NVarChar, 10).Value = If(String.IsNullOrWhiteSpace(filtro.Estado), "Todas", filtro.Estado)
                conexion.Open()
                Using lector = comando.ExecuteReader()
                    While lector.Read()
                        resultado.Add(New VentaListado With {.IdVenta = CInt(lector("IdVenta")), .Folio = CStr(lector("Folio")), .FechaHora = CDate(lector("FechaHora")), .Vendedor = CStr(lector("NombreCompleto")), .Total = CDec(lector("Total")), .EfectivoRecibido = CDec(lector("EfectivoRecibido")), .Estado = CStr(lector("Estado"))})
                    End While
                End Using
            End Using
            Return resultado
        End Function

        Public Function Obtener(idVenta As Integer) As VentaDetalle Implements IRepositorioVentas.Obtener
            Dim venta As VentaDetalle = Nothing
            Using conexion = ConexionSqlServer.Crear(), comando = conexion.CreateCommand()
                comando.CommandText = "SELECT v.IdVenta,v.Folio,v.FechaHora,u.NombreCompleto,v.Total,v.EfectivoRecibido,v.Estado,v.IdVendedor,v.IdUsuarioCancela,v.FechaCancelacion,v.MotivoCancelacion,uc.NombreCompleto AS UsuarioCancela FROM dbo.Ventas v INNER JOIN dbo.Usuarios u ON u.IdUsuario=v.IdVendedor LEFT JOIN dbo.Usuarios uc ON uc.IdUsuario=v.IdUsuarioCancela WHERE v.IdVenta=@id;"
                comando.Parameters.Add("@id", SqlDbType.Int).Value = idVenta
                conexion.Open()
                Using lector = comando.ExecuteReader()
                    If lector.Read() Then
                        venta = New VentaDetalle With {.IdVenta = CInt(lector("IdVenta")), .Folio = CStr(lector("Folio")), .FechaHora = CDate(lector("FechaHora")), .Vendedor = CStr(lector("NombreCompleto")), .Total = CDec(lector("Total")), .EfectivoRecibido = CDec(lector("EfectivoRecibido")), .Estado = CStr(lector("Estado")), .IdVendedor = CInt(lector("IdVendedor")), .IdUsuarioCancela = If(IsDBNull(lector("IdUsuarioCancela")), CType(Nothing, Integer?), CInt(lector("IdUsuarioCancela"))), .FechaCancelacion = If(IsDBNull(lector("FechaCancelacion")), CType(Nothing, DateTime?), CDate(lector("FechaCancelacion"))), .MotivoCancelacion = If(IsDBNull(lector("MotivoCancelacion")), Nothing, CStr(lector("MotivoCancelacion"))), .UsuarioCancela = If(IsDBNull(lector("UsuarioCancela")), Nothing, CStr(lector("UsuarioCancela")))}
                    End If
                End Using
                If venta Is Nothing Then Return Nothing
                venta.Articulos = LeerArticulos(conexion, idVenta)
            End Using
            Return venta
        End Function

        Private Shared Function LeerArticulos(conexion As SqlConnection, idVenta As Integer) As IReadOnlyList(Of ArticuloVenta)
            Dim resultado As New List(Of ArticuloVenta)()
            Using comando = New SqlCommand("SELECT d.IdProducto,p.Codigo,p.Nombre,d.Cantidad,d.PrecioUnitario FROM dbo.DetalleVenta d INNER JOIN dbo.Productos p ON p.IdProducto=d.IdProducto WHERE d.IdVenta=@id ORDER BY d.IdDetalle;", conexion)
                comando.Parameters.Add("@id", SqlDbType.Int).Value = idVenta
                Using lector = comando.ExecuteReader()
                    While lector.Read()
                        resultado.Add(New ArticuloVenta With {.IdProducto = CInt(lector("IdProducto")), .Codigo = CStr(lector("Codigo")), .Nombre = CStr(lector("Nombre")), .Cantidad = CInt(lector("Cantidad")), .PrecioUnitario = CDec(lector("PrecioUnitario"))})
                    End While
                End Using
            End Using
            Return resultado
        End Function

        Public Sub Cancelar(idVenta As Integer, idUsuarioCancela As Integer, motivo As String, soloPropias As Boolean) Implements IRepositorioVentas.Cancelar
            Using conexion = ConexionSqlServer.Crear()
                conexion.Open()
                Using transaccion = conexion.BeginTransaction(IsolationLevel.Serializable)
                    Try
                        Dim idVendedor As Integer
                        Using comando = New SqlCommand("SELECT IdVendedor FROM dbo.Ventas WITH (UPDLOCK,HOLDLOCK) WHERE IdVenta=@id AND Estado='Confirmada';", conexion, transaccion)
                            comando.Parameters.Add("@id", SqlDbType.Int).Value = idVenta
                            Dim valor = comando.ExecuteScalar()
                            If valor Is Nothing Then Throw New VentaNoEncontradaException()
                            idVendedor = CInt(valor)
                        End Using
                        If soloPropias AndAlso idVendedor <> idUsuarioCancela Then Throw New UnauthorizedAccessException("Solo puedes cancelar tus propias ventas.")
                        Using comando = New SqlCommand("SELECT IdProducto,Cantidad FROM dbo.DetalleVenta WHERE IdVenta=@id;", conexion, transaccion)
                            comando.Parameters.Add("@id", SqlDbType.Int).Value = idVenta
                            Using lector = comando.ExecuteReader()
                                Dim items As New List(Of KeyValuePair(Of Integer, Integer))()
                                While lector.Read() : items.Add(New KeyValuePair(Of Integer, Integer)(CInt(lector("IdProducto")), CInt(lector("Cantidad")))) : End While
                                lector.Close()
                                For Each item In items
                                    Using actualizar = New SqlCommand("UPDATE dbo.Productos SET Existencias=Existencias+@cantidad WHERE IdProducto=@id;", conexion, transaccion)
                                        actualizar.Parameters.Add("@cantidad", SqlDbType.Int).Value = item.Value
                                        actualizar.Parameters.Add("@id", SqlDbType.Int).Value = item.Key
                                        actualizar.ExecuteNonQuery()
                                    End Using
                                Next
                            End Using
                        End Using
                        Using comando = New SqlCommand("UPDATE dbo.Ventas SET Estado='Cancelada',IdUsuarioCancela=@usuario,FechaCancelacion=SYSDATETIME(),MotivoCancelacion=@motivo WHERE IdVenta=@id AND Estado='Confirmada';", conexion, transaccion)
                            comando.Parameters.Add("@usuario", SqlDbType.Int).Value = idUsuarioCancela
                            comando.Parameters.Add("@motivo", SqlDbType.NVarChar, 250).Value = motivo
                            comando.Parameters.Add("@id", SqlDbType.Int).Value = idVenta
                            If comando.ExecuteNonQuery() <> 1 Then Throw New VentaNoEncontradaException()
                        End Using
                        transaccion.Commit()
                    Catch
                        transaccion.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Sub
    End Class
End Namespace
