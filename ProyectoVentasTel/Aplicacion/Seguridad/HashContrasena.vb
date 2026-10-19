Imports System.Security.Cryptography
Imports System.Text

Namespace Aplicacion.Seguridad
    Public NotInheritable Class HashContrasena
        Private Const Version As String = "PBKDF2-SHA256"
        Private Const Iteraciones As Integer = 100000
        Private Const LongitudSalt As Integer = 16
        Private Const LongitudClave As Integer = 32

        Private Sub New()
        End Sub

        Public Shared Function Crear(contrasena As String) As String
            If String.IsNullOrEmpty(contrasena) Then
                Throw New ArgumentException("La contraseña es obligatoria.", NameOf(contrasena))
            End If

            Dim salt(LongitudSalt - 1) As Byte
            Using generador As RandomNumberGenerator = RandomNumberGenerator.Create()
                generador.GetBytes(salt)
            End Using

            Dim clave As Byte() = DerivarClave(contrasena, salt, Iteraciones)
            Return String.Format("{0}${1}${2}${3}", Version, Iteraciones, Convert.ToBase64String(salt), Convert.ToBase64String(clave))
        End Function

        Public Shared Function Verificar(contrasena As String, hashAlmacenado As String) As Boolean
            If String.IsNullOrEmpty(contrasena) OrElse String.IsNullOrWhiteSpace(hashAlmacenado) Then
                Return False
            End If

            Try
                Dim partes As String() = hashAlmacenado.Split("$"c)
                If partes.Length <> 4 OrElse Not String.Equals(partes(0), Version, StringComparison.Ordinal) Then
                    Return False
                End If

                Dim iteracionesHash As Integer
                If Not Integer.TryParse(partes(1), iteracionesHash) OrElse iteracionesHash <= 0 Then
                    Return False
                End If

                Dim salt As Byte() = Convert.FromBase64String(partes(2))
                Dim claveEsperada As Byte() = Convert.FromBase64String(partes(3))
                If salt.Length <> LongitudSalt OrElse claveEsperada.Length <> LongitudClave Then
                    Return False
                End If

                Dim claveActual As Byte() = DerivarClave(contrasena, salt, iteracionesHash)
                Return SonIgualesTiempoConstante(claveEsperada, claveActual)
            Catch ex As FormatException
                Return False
            Catch ex As CryptographicException
                Return False
            End Try
        End Function

        Private Shared Function DerivarClave(contrasena As String, salt As Byte(), iteraciones As Integer) As Byte()
            Using derivador As New Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(contrasena), salt, iteraciones, HashAlgorithmName.SHA256)
                Return derivador.GetBytes(LongitudClave)
            End Using
        End Function

        Private Shared Function SonIgualesTiempoConstante(izquierda As Byte(), derecha As Byte()) As Boolean
            If izquierda Is Nothing OrElse derecha Is Nothing OrElse izquierda.Length <> derecha.Length Then
                Return False
            End If

            Dim diferencia As Integer = 0
            For indice As Integer = 0 To izquierda.Length - 1
                diferencia = diferencia Or (izquierda(indice) Xor derecha(indice))
            Next

            Return diferencia = 0
        End Function
    End Class
End Namespace
