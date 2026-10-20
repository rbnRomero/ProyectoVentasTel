Namespace Dominio.Seguridad
    Public NotInheritable Class NombreUsuarioDuplicadoException
        Inherits Exception

        Public Sub New(Optional mensaje As String = "El nombre de usuario ya existe.")
            MyBase.New(mensaje)
        End Sub
    End Class
End Namespace
