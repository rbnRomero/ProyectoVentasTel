Imports System.Configuration
Imports System.Data.SqlClient

Namespace Infraestructura.Datos
    ''' <summary>
    ''' Centraliza la creación de conexiones a la base de datos de VISOR.
    ''' </summary>
    Public NotInheritable Class ConexionSqlServer
        Private Const NombreCadenaConexion As String = "VentasTel_BD"

        Private Sub New()
        End Sub

        ''' <summary>
        ''' Crea una nueva conexión sin abrirla. El consumidor debe administrarla con Using.
        ''' </summary>
        Public Shared Function Crear() As SqlConnection
            Dim configuracion As ConnectionStringSettings = ConfigurationManager.ConnectionStrings(NombreCadenaConexion)

            If configuracion Is Nothing OrElse String.IsNullOrWhiteSpace(configuracion.ConnectionString) Then
                Throw New ConfigurationErrorsException(
                    String.Format("No se encontró la cadena de conexión '{0}' en App.config.", NombreCadenaConexion))
            End If

            Return New SqlConnection(configuracion.ConnectionString)
        End Function
    End Class
End Namespace
