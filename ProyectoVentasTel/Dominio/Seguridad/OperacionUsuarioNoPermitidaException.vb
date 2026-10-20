Namespace Dominio.Seguridad
    Public NotInheritable Class OperacionUsuarioNoPermitidaException
        Inherits Exception

        Public Sub New(Optional mensaje As String = "No se puede desactivar ni cambiar el rol del usuario actual.")
            MyBase.New(mensaje)
        End Sub
    End Class
End Namespace
