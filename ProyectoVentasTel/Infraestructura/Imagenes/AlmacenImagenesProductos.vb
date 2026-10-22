Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports ProyectoVentasTel.Dominio.Productos

Namespace Infraestructura.Imagenes
    Public NotInheritable Class AlmacenImagenesProductos
        Implements IAlmacenImagenesProductos

        Private Shared ReadOnly Property Carpeta As String
            Get
                Return ResolverCarpeta(AppDomain.CurrentDomain.BaseDirectory)
            End Get
        End Property

        Private Shared Function ResolverCarpeta(directorioBase As String) As String
            Dim directorio As New DirectoryInfo(directorioBase)
            While directorio IsNot Nothing
                If File.Exists(Path.Combine(directorio.FullName, "ProyectoVentasTel.vbproj")) Then
                    Return Path.Combine(directorio.FullName, "img", "productos")
                End If
                directorio = directorio.Parent
            End While
            Throw New AlmacenamientoImagenException("No se encontró la carpeta del proyecto. Ejecuta la aplicación dentro de ProyectoVentasTel para guardar imágenes en img/productos.")
        End Function

        Public Function Copiar(archivo As String) As String Implements IAlmacenImagenesProductos.Copiar
            ' Decodifica antes de persistir y vuelve a codificar para copiar solamente la imagen.
            Using imagen = Cargar(archivo)
                Return GuardarImagen(imagen, Carpeta)
            End Using
        End Function

        Private Shared Function GuardarImagen(imagen As Image, carpetaDestino As String) As String
            Dim destino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString("N") & ".png")
            If destino.Length > 500 Then Throw New AlmacenamientoImagenException("La ruta de almacenamiento de imágenes es demasiado larga.")
            Try
                Directory.CreateDirectory(carpetaDestino)
                imagen.Save(destino, ImageFormat.Png)
                Return destino
            Catch ex As Exception When TypeOf ex Is IOException OrElse TypeOf ex Is UnauthorizedAccessException OrElse
                                       TypeOf ex Is System.Security.SecurityException OrElse TypeOf ex Is System.Runtime.InteropServices.ExternalException
                Try
                    If File.Exists(destino) Then File.Delete(destino)
                Catch errorLimpieza As Exception
                    Diagnostics.Trace.TraceWarning("No se pudo eliminar una copia incompleta de imagen.")
                End Try
                Throw New AlmacenamientoImagenException("No se pudo guardar la imagen en img/productos del proyecto. Comprueba que la carpeta esté disponible y tengas permisos de escritura.")
            End Try
        End Function

        Public Sub EliminarCopia(ruta As String) Implements IAlmacenImagenesProductos.EliminarCopia
            If String.Equals(Path.GetDirectoryName(Path.GetFullPath(ruta)), Path.GetFullPath(Carpeta), StringComparison.OrdinalIgnoreCase) Then
                File.Delete(ruta)
            End If
        End Sub

        Public Shared Function Cargar(archivo As String) As Image
            Dim extension = Path.GetExtension(archivo)
            If Not {".jpg", ".jpeg", ".png"}.Contains(extension, StringComparer.OrdinalIgnoreCase) Then
                Throw New ArgumentException("Selecciona una imagen JPEG o PNG válida.", "ArchivoImagenNuevo")
            End If
            Try
                Using flujo As New FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.Read),
                      imagen = Image.FromStream(flujo, True, True)
                    If Not imagen.RawFormat.Equals(ImageFormat.Jpeg) AndAlso Not imagen.RawFormat.Equals(ImageFormat.Png) Then
                        Throw New ArgumentException("Selecciona una imagen JPEG o PNG válida.", "ArchivoImagenNuevo")
                    End If
                    Return New Bitmap(imagen)
                End Using
            Catch ex As ArgumentException
                Throw New ArgumentException("Selecciona una imagen JPEG o PNG válida.", "ArchivoImagenNuevo")
            End Try
        End Function

        Public Shared Function IntentarCargar(archivo As String) As Image
            If String.IsNullOrWhiteSpace(archivo) Then Return Nothing
            Try
                Return Cargar(archivo)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
    End Class
End Namespace
