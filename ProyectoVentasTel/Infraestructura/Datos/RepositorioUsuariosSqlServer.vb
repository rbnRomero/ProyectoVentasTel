Imports System.Data
Imports System.Data.SqlClient
Imports ProyectoVentasTel.Dominio.Seguridad

Namespace Infraestructura.Datos
    Public NotInheritable Class RepositorioUsuariosSqlServer
        Implements IRepositorioUsuarios

        Public Function ObtenerUsuarioActivoPorNombreUsuario(nombreUsuario As String) As UsuarioAutenticado Implements IRepositorioUsuarios.ObtenerUsuarioActivoPorNombreUsuario
            Const consulta As String = "SELECT u.IdUsuario, u.NombreCompleto, u.NombreUsuario, u.ContrasenaHash, r.Nombre AS NombreRol " &
                                       "FROM dbo.Usuarios AS u " &
                                       "INNER JOIN dbo.Roles AS r ON r.IdRol = u.IdRol " &
                                       "WHERE u.NombreUsuario = @NombreUsuario AND u.Activo = 1;"

            Using conexion As SqlConnection = ConexionSqlServer.Crear()
                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario
                    conexion.Open()

                    Using lector As SqlDataReader = comando.ExecuteReader(CommandBehavior.SingleRow)
                        If Not lector.Read() Then
                            Return Nothing
                        End If

                        Return New UsuarioAutenticado With {
                            .IdUsuario = lector.GetInt32(lector.GetOrdinal("IdUsuario")),
                            .NombreCompleto = lector.GetString(lector.GetOrdinal("NombreCompleto")),
                            .NombreUsuario = lector.GetString(lector.GetOrdinal("NombreUsuario")),
                            .ContrasenaHash = lector.GetString(lector.GetOrdinal("ContrasenaHash")),
                            .Rol = ConvertirRol(lector.GetString(lector.GetOrdinal("NombreRol")))
                        }
                    End Using
                End Using
            End Using
        End Function

        Public Function ConsultarUsuarios(filtro As FiltroUsuarios) As IReadOnlyList(Of UsuarioListado) Implements IRepositorioUsuarios.ConsultarUsuarios
            Const consulta As String = "SELECT u.IdUsuario, u.NombreCompleto, u.NombreUsuario, r.Nombre AS NombreRol, u.Activo " &
                                       "FROM dbo.Usuarios AS u " &
                                       "INNER JOIN dbo.Roles AS r ON r.IdRol = u.IdRol " &
                                       "WHERE (@TextoBusqueda IS NULL " &
                                       "       OR CHARINDEX(@TextoBusqueda, u.NombreCompleto) > 0 " &
                                       "       OR CHARINDEX(@TextoBusqueda, u.NombreUsuario) > 0) " &
                                       "  AND (@Rol IS NULL OR r.Nombre = @Rol) " &
                                       "  AND (@Activo IS NULL OR u.Activo = @Activo) " &
                                       "ORDER BY u.NombreCompleto, u.NombreUsuario, u.IdUsuario;"

            Dim usuarios As New List(Of UsuarioListado)()
            Dim textoBusqueda As String = If(filtro?.Texto, String.Empty).Trim()

            Using conexion As SqlConnection = ConexionSqlServer.Crear()
                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.Add("@TextoBusqueda", SqlDbType.NVarChar, 100).Value =
                        If(textoBusqueda.Length = 0, CType(DBNull.Value, Object), textoBusqueda)

                    Dim rol As Object = DBNull.Value
                    If filtro IsNot Nothing AndAlso filtro.Rol.HasValue Then
                        rol = ConvertirNombreRol(filtro.Rol.Value)
                    End If
                    comando.Parameters.Add("@Rol", SqlDbType.NVarChar, 30).Value = rol

                    Dim activo As Object = DBNull.Value
                    If filtro IsNot Nothing AndAlso filtro.Activo.HasValue Then
                        activo = filtro.Activo.Value
                    End If
                    comando.Parameters.Add("@Activo", SqlDbType.Bit).Value = activo

                    conexion.Open()
                    Using lector As SqlDataReader = comando.ExecuteReader()
                        While lector.Read()
                            usuarios.Add(New UsuarioListado With {
                                .IdUsuario = lector.GetInt32(lector.GetOrdinal("IdUsuario")),
                                .NombreCompleto = lector.GetString(lector.GetOrdinal("NombreCompleto")),
                                .NombreUsuario = lector.GetString(lector.GetOrdinal("NombreUsuario")),
                                .Rol = ConvertirRol(lector.GetString(lector.GetOrdinal("NombreRol"))),
                                .Activo = lector.GetBoolean(lector.GetOrdinal("Activo"))
                            })
                        End While
                    End Using
                End Using
            End Using

            Return usuarios
        End Function

        Public Function CrearUsuario(perfil As PerfilUsuario, contrasenaHash As String) As Integer Implements IRepositorioUsuarios.CrearUsuario
            If perfil Is Nothing Then Throw New ArgumentNullException(NameOf(perfil))
            If String.IsNullOrWhiteSpace(contrasenaHash) Then Throw New ArgumentException("La contraseña cifrada es obligatoria.", NameOf(contrasenaHash))

            Const consulta As String = "INSERT INTO dbo.Usuarios (IdRol, NombreCompleto, NombreUsuario, ContrasenaHash, Activo) " &
                                       "OUTPUT INSERTED.IdUsuario " &
                                       "SELECT r.IdRol, @NombreCompleto, @NombreUsuario, @ContrasenaHash, @Activo " &
                                       "FROM dbo.Roles AS r " &
                                       "WHERE r.Nombre = @Rol;"

            Try
                Using conexion As SqlConnection = ConexionSqlServer.Crear()
                    Using comando As New SqlCommand(consulta, conexion)
                        comando.Parameters.Add("@NombreCompleto", SqlDbType.NVarChar, 100).Value = perfil.NombreCompleto
                        comando.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = perfil.NombreUsuario
                        comando.Parameters.Add("@ContrasenaHash", SqlDbType.NVarChar, 255).Value = contrasenaHash
                        comando.Parameters.Add("@Activo", SqlDbType.Bit).Value = perfil.Activo
                        comando.Parameters.Add("@Rol", SqlDbType.NVarChar, 30).Value = ConvertirNombreRol(perfil.Rol)

                        conexion.Open()
                        Dim idUsuarioCreado As Object = comando.ExecuteScalar()
                        If idUsuarioCreado Is Nothing OrElse idUsuarioCreado Is DBNull.Value Then
                            Throw New InvalidOperationException("No se encontró el rol seleccionado.")
                        End If

                        Return Convert.ToInt32(idUsuarioCreado)
                    End Using
                End Using
            Catch ex As SqlException When ex.Number = 2601 OrElse ex.Number = 2627
                Throw New NombreUsuarioDuplicadoException()
            End Try
        End Function

        Public Function ActualizarUsuario(idUsuario As Integer, perfil As PerfilUsuario, nuevaContrasenaHash As String) As ResultadoActualizacionUsuario Implements IRepositorioUsuarios.ActualizarUsuario
            If idUsuario <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(idUsuario))
            If perfil Is Nothing Then Throw New ArgumentNullException(NameOf(perfil))

            Const consultaBloquearAdministradores As String = "SELECT COUNT_BIG(*) " &
                                                               "FROM dbo.Usuarios AS u WITH (UPDLOCK, HOLDLOCK) " &
                                                               "INNER JOIN dbo.Roles AS r WITH (UPDLOCK, HOLDLOCK) ON r.IdRol = u.IdRol " &
                                                               "WHERE r.Nombre = N'Administrador' AND u.Activo = 1;"
            Const consultaUsuarioActual As String = "SELECT CASE WHEN r.Nombre = N'Administrador' AND u.Activo = 1 " &
                                                     "THEN CAST(1 AS bit) ELSE CAST(0 AS bit) END " &
                                                     "FROM dbo.Usuarios AS u WITH (UPDLOCK, HOLDLOCK) " &
                                                     "INNER JOIN dbo.Roles AS r WITH (UPDLOCK, HOLDLOCK) ON r.IdRol = u.IdRol " &
                                                     "WHERE u.IdUsuario = @IdUsuario;"
            Const consultaRol As String = "SELECT r.IdRol " &
                                           "FROM dbo.Roles AS r WITH (UPDLOCK, HOLDLOCK) " &
                                           "WHERE r.Nombre = @Rol;"
            Const consultaActualizar As String = "UPDATE dbo.Usuarios " &
                                                  "SET IdRol = @IdRol, " &
                                                  "    NombreCompleto = @NombreCompleto, " &
                                                  "    NombreUsuario = @NombreUsuario, " &
                                                  "    ContrasenaHash = CASE WHEN @NuevaContrasenaHash IS NULL THEN ContrasenaHash ELSE @NuevaContrasenaHash END, " &
                                                  "    Activo = @Activo " &
                                                  "WHERE IdUsuario = @IdUsuario;"

            Try
                Using conexion As SqlConnection = ConexionSqlServer.Crear()
                    conexion.Open()

                    Using transaccion As SqlTransaction = conexion.BeginTransaction(IsolationLevel.Serializable)
                        Dim administradoresActivos As Long
                        Using comandoBloqueo As New SqlCommand(consultaBloquearAdministradores, conexion, transaccion)
                            administradoresActivos = Convert.ToInt64(comandoBloqueo.ExecuteScalar())
                        End Using

                        Dim eraAdministradorActivo As Boolean
                        Using comandoUsuarioActual As New SqlCommand(consultaUsuarioActual, conexion, transaccion)
                            comandoUsuarioActual.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario
                            Dim valorUsuarioActual As Object = comandoUsuarioActual.ExecuteScalar()
                            If valorUsuarioActual Is Nothing OrElse valorUsuarioActual Is DBNull.Value Then
                                transaccion.Rollback()
                                Return ResultadoActualizacionUsuario.NoEncontrado
                            End If

                            eraAdministradorActivo = Convert.ToBoolean(valorUsuarioActual)
                        End Using

                        If eraAdministradorActivo AndAlso
                           (perfil.Rol <> RolUsuario.Administrador OrElse Not perfil.Activo) AndAlso
                           administradoresActivos <= 1 Then
                            transaccion.Rollback()
                            Return ResultadoActualizacionUsuario.UltimoAdministradorActivo
                        End If

                        Dim idRol As Integer
                        Using comandoRol As New SqlCommand(consultaRol, conexion, transaccion)
                            comandoRol.Parameters.Add("@Rol", SqlDbType.NVarChar, 30).Value = ConvertirNombreRol(perfil.Rol)
                            Dim valorRol As Object = comandoRol.ExecuteScalar()
                            If valorRol Is Nothing OrElse valorRol Is DBNull.Value Then
                                Throw New InvalidOperationException("No se encontró el rol seleccionado.")
                            End If

                            idRol = Convert.ToInt32(valorRol)
                        End Using

                        Dim filasActualizadas As Integer
                        Using comandoActualizar As New SqlCommand(consultaActualizar, conexion, transaccion)
                            comandoActualizar.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario
                            comandoActualizar.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol
                            comandoActualizar.Parameters.Add("@NombreCompleto", SqlDbType.NVarChar, 100).Value = perfil.NombreCompleto
                            comandoActualizar.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = perfil.NombreUsuario
                            comandoActualizar.Parameters.Add("@NuevaContrasenaHash", SqlDbType.NVarChar, 255).Value =
                                If(nuevaContrasenaHash Is Nothing, CType(DBNull.Value, Object), nuevaContrasenaHash)
                            comandoActualizar.Parameters.Add("@Activo", SqlDbType.Bit).Value = perfil.Activo
                            filasActualizadas = comandoActualizar.ExecuteNonQuery()
                        End Using

                        If filasActualizadas = 0 Then
                            transaccion.Rollback()
                            Return ResultadoActualizacionUsuario.NoEncontrado
                        End If

                        transaccion.Commit()
                        Return ResultadoActualizacionUsuario.Actualizado
                    End Using
                End Using
            Catch ex As SqlException When ex.Number = 2601 OrElse ex.Number = 2627
                Throw New NombreUsuarioDuplicadoException()
            End Try
        End Function

        Private Shared Function ConvertirNombreRol(rol As RolUsuario) As String
            Select Case rol
                Case RolUsuario.Administrador
                    Return "Administrador"
                Case RolUsuario.Vendedor
                    Return "Vendedor"
                Case RolUsuario.Inventarios
                    Return "Inventarios"
                Case Else
                    Throw New ArgumentOutOfRangeException(NameOf(rol), "El rol seleccionado no es válido.")
            End Select
        End Function

        Private Shared Function ConvertirRol(nombreRol As String) As RolUsuario
            Select Case nombreRol.Trim().ToUpperInvariant()
                Case "ADMINISTRADOR"
                    Return RolUsuario.Administrador
                Case "VENDEDOR"
                    Return RolUsuario.Vendedor
                Case "INVENTARIOS"
                    Return RolUsuario.Inventarios
                Case Else
                    Return RolUsuario.Desconocido
            End Select
        End Function
    End Class
End Namespace
