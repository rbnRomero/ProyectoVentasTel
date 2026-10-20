Namespace Dominio.Seguridad
    Public NotInheritable Class UsuarioNoEncontradoException
        Inherits Exception

        Public Sub New(Optional mensaje As String = "El usuario indicado no existe.")
            MyBase.New(mensaje)
        End Sub
    End Class
End Namespace
