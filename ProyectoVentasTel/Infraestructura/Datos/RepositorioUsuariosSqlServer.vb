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
