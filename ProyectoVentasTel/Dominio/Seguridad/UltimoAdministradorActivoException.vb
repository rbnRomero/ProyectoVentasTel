Namespace Dominio.Seguridad
    Public NotInheritable Class UltimoAdministradorActivoException
        Inherits Exception

        Public Sub New(Optional mensaje As String = "Debe permanecer al menos un administrador activo.")
            MyBase.New(mensaje)
        End Sub
    End Class
End Namespace
