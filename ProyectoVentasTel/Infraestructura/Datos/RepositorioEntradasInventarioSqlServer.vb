Imports System.Data
Imports System.Data.SqlClient
Imports ProyectoVentasTel.Dominio.Inventario

Namespace Infraestructura.Datos
    Public NotInheritable Class RepositorioEntradasInventarioSqlServer
        Implements IRepositorioEntradasInventario

        Public Function ProductosActivos() As IReadOnlyList(Of ProductoEntrada) Implements IRepositorioEntradasInventario.ProductosActivos
            Dim resultado As New List(Of ProductoEntrada)()
            Using conexion = ConexionSqlServer.Crear(), comando = conexion.CreateCommand()
                comando.CommandText = "SELECT IdProducto,Codigo,Nombre,Existencias FROM dbo.Productos WHERE Activo=1 ORDER BY Nombre,Codigo;"
                conexion.Open()
                Using lector = comando.ExecuteReader()
                    While lector.Read()
                        resultado.Add(New ProductoEntrada With {.IdProducto = CInt(lector("IdProducto")), .Codigo = CStr(lector("Codigo")), .Nombre = CStr(lector("Nombre")), .Existencias = CInt(lector("Existencias"))})
                    End While
                End Using
            End Using
            Return resultado
        End Function

        Public Function Consultar() As IReadOnlyList(Of EntradaInventario) Implements IRepositorioEntradasInventario.Consultar
            Dim resultado As New List(Of EntradaInventario)()
            Using conexion = ConexionSqlServer.Crear(), comando = conexion.CreateCommand()
                comando.CommandText = "SELECT e.IdEntrada,e.FechaHora,p.Codigo,p.Nombre,e.Cantidad,u.NombreCompleto,e.Observaciones FROM dbo.EntradasInventario e INNER JOIN dbo.Productos p ON p.IdProducto=e.IdProducto INNER JOIN dbo.Usuarios u ON u.IdUsuario=e.IdUsuario ORDER BY e.FechaHora DESC,e.IdEntrada DESC;"
                conexion.Open()
                Using lector = comando.ExecuteReader()
                    While lector.Read()
                        resultado.Add(New EntradaInventario With {.IdEntrada = CInt(lector("IdEntrada")), .FechaHora = CDate(lector("FechaHora")), .CodigoProducto = CStr(lector("Codigo")), .NombreProducto = CStr(lector("Nombre")), .Cantidad = CInt(lector("Cantidad")), .Usuario = CStr(lector("NombreCompleto")), .Observaciones = If(IsDBNull(lector("Observaciones")), String.Empty, CStr(lector("Observaciones")))})
                    End While
                End Using
            End Using
            Return resultado
        End Function

        Public Function Registrar(idProducto As Integer, idUsuario As Integer, cantidad As Integer, observaciones As String) As Integer Implements IRepositorioEntradasInventario.Registrar
            Using conexion = ConexionSqlServer.Crear()
                conexion.Open()
                Using transaccion = conexion.BeginTransaction(IsolationLevel.Serializable)
                    Try
                        Using comando = New SqlCommand("UPDATE dbo.Productos WITH (UPDLOCK,HOLDLOCK) SET Existencias=Existencias+@cantidad WHERE IdProducto=@producto AND Activo=1 AND Existencias<=2147483647-@cantidad;", conexion, transaccion)
                            comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad
                            comando.Parameters.Add("@producto", SqlDbType.Int).Value = idProducto
                            If comando.ExecuteNonQuery() <> 1 Then Throw New InvalidOperationException("El producto no está disponible o la cantidad excede el límite de existencias.")
                        End Using
                        Dim idEntrada As Integer
                        Using comando = New SqlCommand("INSERT dbo.EntradasInventario(IdProducto,IdUsuario,Cantidad,Observaciones) VALUES(@producto,@usuario,@cantidad,@observaciones); SELECT CONVERT(INT,SCOPE_IDENTITY());", conexion, transaccion)
                            comando.Parameters.Add("@producto", SqlDbType.Int).Value = idProducto
                            comando.Parameters.Add("@usuario", SqlDbType.Int).Value = idUsuario
                            comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad
                            comando.Parameters.Add("@observaciones", SqlDbType.NVarChar, 250).Value = If(observaciones Is Nothing, CType(DBNull.Value, Object), observaciones)
                            idEntrada = CInt(comando.ExecuteScalar())
                        End Using
                        transaccion.Commit()
                        Return idEntrada
                    Catch
                        transaccion.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Function
    End Class
End Namespace
