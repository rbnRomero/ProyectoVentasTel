Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Diagnostics
Imports System.IO

''' <summary>
''' Carga y colorea los iconos de la interfaz desde el directorio de contenido
''' de la aplicación. Mantiene las imágenes en caché para no dejar archivos
''' bloqueados ni recrear bitmaps en cada formulario.
''' </summary>
Friend NotInheritable Class UiIconos
    Private Shared ReadOnly imagenes As New Dictionary(Of String, Image)(StringComparer.OrdinalIgnoreCase)
    Private Shared ReadOnly sincronizacion As New Object()

    Private Sub New()
    End Sub

    Public Shared Function Obtener(nombre As String, color As Color, Optional tamano As Integer = 20) As Image
        If String.IsNullOrWhiteSpace(nombre) OrElse tamano <= 0 Then Return Nothing

        Dim clave As String = String.Format("{0}|{1}|{2}", nombre, color.ToArgb(), tamano)
        SyncLock sincronizacion
            Dim imagenEnCache As Image = Nothing
            If imagenes.TryGetValue(clave, imagenEnCache) Then Return imagenEnCache

            Dim ruta As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "icons", nombre & ".png")
            If Not File.Exists(ruta) Then
                Trace.TraceWarning("No se pudo cargar el icono en '{0}': el archivo no existe.", ruta)
                Return Nothing
            End If

            Dim icono As Image = CargarYColorear(ruta, color, tamano)
            If icono IsNot Nothing Then imagenes.Add(clave, icono)
            Return icono
        End SyncLock
    End Function

    Private Shared Function CargarYColorear(ruta As String, color As Color, tamano As Integer) As Image
        Try
            Dim bytes As Byte() = File.ReadAllBytes(ruta)
            Using flujo As New MemoryStream(bytes)
                Using original As Image = Image.FromStream(flujo)
                    Dim resultado As New Bitmap(tamano, tamano, PixelFormat.Format32bppArgb)
                    Using grafico As Graphics = Graphics.FromImage(resultado)
                        grafico.Clear(Color.Transparent)
                        grafico.CompositingQuality = CompositingQuality.HighQuality
                        grafico.InterpolationMode = InterpolationMode.HighQualityBicubic
                        grafico.PixelOffsetMode = PixelOffsetMode.HighQuality
                        grafico.SmoothingMode = SmoothingMode.HighQuality

                        Using atributos As New ImageAttributes()
                            atributos.SetColorMatrix(CrearMatrizDeColor(color))
                            grafico.DrawImage(original, New Rectangle(0, 0, tamano, tamano), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, atributos)
                        End Using
                    End Using
                    Return resultado
                End Using
            End Using
        Catch ex As Exception
            Trace.TraceWarning("No se pudo cargar el icono en '{0}': {1}", ruta, ex.Message)
            Return Nothing
        End Try
    End Function

    Private Shared Function CrearMatrizDeColor(color As Color) As ColorMatrix
        Return New ColorMatrix(New Single()() {
            New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F},
            New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F},
            New Single() {0.0F, 0.0F, 0.0F, 0.0F, 0.0F},
            New Single() {0.0F, 0.0F, 0.0F, 1.0F, 0.0F},
            New Single() {CSng(color.R) / 255.0F, CSng(color.G) / 255.0F, CSng(color.B) / 255.0F, 0.0F, 1.0F}
        })
    End Function
End Class
