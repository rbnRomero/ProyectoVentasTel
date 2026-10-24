Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' Paleta y convenciones visuales compartidas de la capa de presentación.
''' Se aplica en tiempo de ejecución para no modificar archivos generados por el diseñador.
''' </summary>
Public NotInheritable Class UiTema
    Private Shared ReadOnly IconoSistema As Icon = CargarIconoSistema()
    Public Shared ReadOnly Fondo As Color = Color.FromArgb(234, 240, 246)
    Public Shared ReadOnly Superficie As Color = Color.FromArgb(232, 239, 246)
    Private Shared ReadOnly TextoClaro As Color = Color.White
    Public Shared ReadOnly Campo As Color = Color.White
    Public Shared ReadOnly Primario As Color = Color.FromArgb(37, 99, 235)
    Public Shared ReadOnly Navegacion As Color = Color.FromArgb(15, 23, 42)
    Public Shared ReadOnly Secundario As Color = Color.FromArgb(248, 250, 252)
    Public Shared ReadOnly SecundarioDeshabilitado As Color = Color.FromArgb(226, 232, 240)
    Public Shared ReadOnly TextoPrincipal As Color = Color.FromArgb(15, 23, 42)
    Public Shared ReadOnly TextoSecundario As Color = Color.FromArgb(71, 85, 105)
    Public Shared ReadOnly Borde As Color = Color.FromArgb(216, 225, 236)
    Public Shared ReadOnly BordeSecundario As Color = Color.FromArgb(148, 163, 184)
    Public Shared ReadOnly Peligro As Color = Color.FromArgb(185, 28, 28)
    Public Shared ReadOnly Advertencia As Color = Color.FromArgb(146, 64, 14)

    Private Sub New()
    End Sub

    Public Shared Sub Aplicar(controlRaiz As Control)
        If controlRaiz Is Nothing Then Return

        Dim formulario As Form = TryCast(controlRaiz, Form)
        If formulario IsNot Nothing AndAlso IconoSistema IsNot Nothing Then formulario.Icon = IconoSistema

        controlRaiz.BackColor = Fondo
        controlRaiz.ForeColor = TextoPrincipal
        If String.IsNullOrWhiteSpace(controlRaiz.AccessibleName) Then
            controlRaiz.AccessibleName = If(String.IsNullOrWhiteSpace(controlRaiz.Text), NombreLegible(controlRaiz.Name), controlRaiz.Text)
        End If
        AplicarRecursivamente(controlRaiz)
    End Sub

    Private Shared Function CargarIconoSistema() As Icon
        Dim ruta As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "system", "visor-v-blanca.ico")
        If Not File.Exists(ruta) Then Return Nothing
        Return New Icon(ruta)
    End Function

    Public Shared Sub OcultarEncabezadoDeModulo(raiz As TableLayoutPanel, encabezado As Panel, titulo As Label, Optional conservarMetadato As Boolean = False)
        If raiz Is Nothing OrElse encabezado Is Nothing Then Return

        titulo.Visible = False
        encabezado.BackColor = Fondo
        encabezado.Margin = New Padding(0)
        If conservarMetadato Then
            encabezado.Height = 28
            raiz.RowStyles(0).SizeType = SizeType.Absolute
            raiz.RowStyles(0).Height = 28
        Else
            encabezado.Visible = False
            raiz.RowStyles(0).SizeType = SizeType.Absolute
            raiz.RowStyles(0).Height = 0
        End If
    End Sub

    ''' <summary>
    ''' Conserva las acciones de un módulo sin volver a mostrar un segundo título.
    ''' La barra ocupa la primera fila del layout y sus acciones quedan agrupadas
    ''' a la derecha, antes de los filtros.
    ''' </summary>
    Public Shared Sub ConfigurarBarraAcciones(raiz As TableLayoutPanel, barra As Panel, titulo As Label, accionPrimaria As Button, accionSecundaria As Button)
        If raiz Is Nothing OrElse barra Is Nothing Then Return

        If titulo IsNot Nothing Then titulo.Visible = False

        barra.Visible = True
        barra.BackColor = Superficie
        barra.Padding = New Padding(8)
        barra.Margin = New Padding(0, 0, 0, 16)

        If raiz.RowStyles.Count > 0 Then
            raiz.RowStyles(0).SizeType = SizeType.Absolute
            ' La fila incluye los 16 px de margen inferior de la barra: quedan
            ' 56 px visibles y 40 px útiles tras su relleno vertical.
            raiz.RowStyles(0).Height = 72
        End If

        For Each accion As Button In New Button() {accionPrimaria, accionSecundaria}
            If accion Is Nothing Then Continue For
            accion.Visible = True
            accion.Height = 40
            accion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Next

        AlinearAcciones(barra, accionPrimaria, accionSecundaria)
        AddHandler barra.SizeChanged, Sub(sender, e) AlinearAcciones(barra, accionPrimaria, accionSecundaria)
    End Sub

    Private Shared Sub AlinearAcciones(barra As Panel, accionPrimaria As Button, accionSecundaria As Button)
        If barra Is Nothing Then Return

        Dim bordeDerecho As Integer = barra.ClientSize.Width - barra.Padding.Right
        Dim altoDisponible As Integer = Math.Max(barra.Padding.Top, (barra.ClientSize.Height - 40) \ 2)

        If accionPrimaria IsNot Nothing Then
            accionPrimaria.Location = New Point(Math.Max(barra.Padding.Left, bordeDerecho - accionPrimaria.Width), altoDisponible)
            bordeDerecho = accionPrimaria.Left - 8
        End If

        If accionSecundaria IsNot Nothing Then
            accionSecundaria.Location = New Point(Math.Max(barra.Padding.Left, bordeDerecho - accionSecundaria.Width), altoDisponible)
        End If
    End Sub

    Public Shared Sub ConfigurarTabla(tabla As DataGridView, nombreAccesible As String)
        If tabla Is Nothing Then Return

        tabla.AccessibleName = nombreAccesible
        tabla.AccessibleDescription = "Tabla de " & nombreAccesible & ". Usa las flechas para recorrer sus filas."
        tabla.BackgroundColor = Campo
        tabla.GridColor = Borde
        tabla.EnableHeadersVisualStyles = False
        tabla.ColumnHeadersDefaultCellStyle.BackColor = Navegacion
        tabla.ColumnHeadersDefaultCellStyle.ForeColor = TextoClaro
        tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Navegacion
        tabla.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextoClaro
        tabla.DefaultCellStyle.BackColor = Campo
        tabla.DefaultCellStyle.ForeColor = TextoPrincipal
        tabla.DefaultCellStyle.SelectionBackColor = Primario
        tabla.DefaultCellStyle.SelectionForeColor = TextoClaro
        tabla.AlternatingRowsDefaultCellStyle.BackColor = Fondo
        tabla.AlternatingRowsDefaultCellStyle.ForeColor = TextoPrincipal
        tabla.AlternatingRowsDefaultCellStyle.SelectionBackColor = Primario
        tabla.AlternatingRowsDefaultCellStyle.SelectionForeColor = TextoClaro
        tabla.RowHeadersVisible = False
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        For Each columna As DataGridViewColumn In tabla.Columns
            If columna.Name.IndexOf("Id", StringComparison.OrdinalIgnoreCase) >= 0 AndAlso columna.HeaderText.IndexOf("Id", StringComparison.OrdinalIgnoreCase) >= 0 Then
                columna.Visible = False
            End If
        Next
    End Sub

    Public Shared Sub ConfigurarMensaje(mensaje As Label, Optional nombreAccesible As String = "Mensaje de inicio de sesión")
        mensaje.AccessibleName = nombreAccesible
        mensaje.AccessibleRole = AccessibleRole.Alert
        mensaje.AutoEllipsis = False
        mensaje.AutoSize = False
        mensaje.MaximumSize = New Size(Math.Max(1, mensaje.Width), 0)
        mensaje.Height = Math.Max(mensaje.Height, 44)
        mensaje.TextAlign = ContentAlignment.TopLeft
    End Sub

    Public Shared Sub AplicarFocoVisible(boton As Button)
        RemoveHandler boton.Enter, AddressOf ResaltarFoco
        RemoveHandler boton.Leave, AddressOf QuitarResaltadoFoco
        AddHandler boton.Enter, AddressOf ResaltarFoco
        AddHandler boton.Leave, AddressOf QuitarResaltadoFoco
    End Sub

    Private Shared Sub AplicarRecursivamente(control As Control)
        For Each hijo As Control In control.Controls
            If TypeOf hijo Is Panel Then
                If hijo.Name = "pnlMenu" Then
                    hijo.BackColor = Navegacion
                ElseIf hijo.Name = "pnlContenido" OrElse hijo.Name = "pnlAreaPrincipal" Then
                    hijo.BackColor = Fondo
                ElseIf EsTarjeta(hijo.Name) Then
                    hijo.BackColor = Superficie
                    hijo.Padding = New Padding(Math.Max(hijo.Padding.Left, 16), Math.Max(hijo.Padding.Top, 16), Math.Max(hijo.Padding.Right, 16), Math.Max(hijo.Padding.Bottom, 16))
                Else
                    hijo.BackColor = Fondo
                End If
            ElseIf hijo.Name = "tlpMenu" Then
                hijo.BackColor = Navegacion
            ElseIf TypeOf hijo Is TableLayoutPanel OrElse TypeOf hijo Is UserControl Then
                hijo.BackColor = Fondo
            ElseIf TypeOf hijo Is Label Then
                hijo.TabStop = False
            ElseIf TypeOf hijo Is TextBox OrElse TypeOf hijo Is ComboBox OrElse TypeOf hijo Is NumericUpDown OrElse TypeOf hijo Is DateTimePicker Then
                hijo.AccessibleName = If(String.IsNullOrWhiteSpace(hijo.AccessibleName), NombreLegible(hijo.Name), hijo.AccessibleName)
                hijo.BackColor = Campo
                hijo.ForeColor = TextoPrincipal
                If TypeOf hijo Is ComboBox Then DirectCast(hijo, ComboBox).FlatStyle = FlatStyle.Standard
            ElseIf TypeOf hijo Is DataGridView Then
                ConfigurarTabla(DirectCast(hijo, DataGridView), If(String.IsNullOrWhiteSpace(hijo.AccessibleName), NombreLegible(hijo.Name), hijo.AccessibleName))
            ElseIf TypeOf hijo Is PictureBox Then
                hijo.AccessibleName = If(String.IsNullOrWhiteSpace(hijo.AccessibleName), "Vista previa de imagen", hijo.AccessibleName)
                hijo.AccessibleDescription = "Imagen asociada al elemento seleccionado"
            ElseIf TypeOf hijo Is Button Then
                ConfigurarBoton(DirectCast(hijo, Button))
            End If

            AplicarRecursivamente(hijo)
        Next
    End Sub

    Private Shared Sub ConfigurarBoton(boton As Button)
        boton.AccessibleName = If(String.IsNullOrWhiteSpace(boton.AccessibleName), boton.Text, boton.AccessibleName)
        boton.FlatStyle = FlatStyle.Flat
        ' Mantener el grosor constante evita que el icono y el texto cambien de
        ' posición cuando el botón recibe o pierde el foco.
        boton.FlatAppearance.BorderSize = 1
        boton.UseVisualStyleBackColor = False

        If boton.BackColor.ToArgb() = Peligro.ToArgb() Then
            boton.BackColor = Peligro
            boton.ForeColor = TextoClaro
        ElseIf boton.BackColor.ToArgb() = SecundarioDeshabilitado.ToArgb() OrElse EsBotonSecundario(boton) Then
            boton.BackColor = If(boton.Enabled, Secundario, SecundarioDeshabilitado)
            boton.ForeColor = If(boton.Enabled, Color.FromArgb(51, 65, 85), TextoSecundario)
            boton.FlatAppearance.BorderColor = BordeSecundario
            boton.FlatAppearance.BorderSize = 1
        ElseIf boton.Name.IndexOf("Salir", StringComparison.OrdinalIgnoreCase) >= 0 AndAlso boton.Parent IsNot Nothing AndAlso boton.Parent.Name = "tlpMenu" Then
            boton.BackColor = Navegacion
            boton.ForeColor = TextoClaro
        Else
            boton.BackColor = Primario
            boton.ForeColor = TextoClaro
        End If

        Dim nombreIcono As String = ObtenerNombreIcono(boton)
        If Not String.IsNullOrWhiteSpace(nombreIcono) Then AplicarIcono(boton, nombreIcono)
        If EsControlDeMenu(boton) Then
            boton.FlatAppearance.BorderSize = 0
            boton.FlatAppearance.BorderColor = boton.BackColor
        Else
            boton.FlatAppearance.BorderSize = 1
            boton.FlatAppearance.BorderColor = If(EsBotonSecundario(boton), BordeSecundario, boton.BackColor)
        End If
        AplicarFocoVisible(boton)
    End Sub

    ''' <summary>
    ''' Asocia un pictograma con una acción sin sustituir el texto del botón.
    ''' Se usa también cuando una acción cambia de estado, como mostrar u
    ''' ocultar la contraseña durante el inicio de sesión.
    ''' </summary>
    Public Shared Sub AplicarIcono(boton As Button, nombreIcono As String)
        If boton Is Nothing OrElse String.IsNullOrWhiteSpace(nombreIcono) Then Return

        boton.AutoSize = False
        Dim dpi As Integer = If(boton.DeviceDpi > 0, boton.DeviceDpi, 96)
        Dim tamanoBase As Integer = If(boton.Name = "btnMostrarContrasena", 18, 20)
        Dim tamano As Integer = EscalarParaDpi(tamanoBase, dpi)
        Dim icono As Image = UiIconos.Obtener(nombreIcono, boton.ForeColor, tamano)
        If icono Is Nothing Then
            boton.Image = Nothing
            Return
        End If

        boton.Image = icono
        If boton.Name = "btnMostrarContrasena" Then
            boton.ImageAlign = ContentAlignment.MiddleCenter
            boton.TextImageRelation = TextImageRelation.Overlay
            boton.TextAlign = ContentAlignment.MiddleCenter
            boton.Padding = Padding.Empty
            Return
        End If

        boton.ImageAlign = ContentAlignment.MiddleLeft
        boton.TextImageRelation = TextImageRelation.ImageBeforeText
        boton.TextAlign = ContentAlignment.MiddleCenter
        Dim rellenoHorizontal As Integer = EscalarParaDpi(10, dpi)
        boton.Padding = New Padding(rellenoHorizontal, 0, rellenoHorizontal, 0)

        Dim tamanoPreferido As Size = boton.GetPreferredSize(Size.Empty)
        If tamanoPreferido.Width > boton.Width OrElse tamanoPreferido.Height > boton.Height Then
            Dim minimo As New Size(Math.Max(boton.MinimumSize.Width, tamanoPreferido.Width),
                                   Math.Max(boton.MinimumSize.Height, tamanoPreferido.Height))
            boton.MinimumSize = minimo
            boton.Size = New Size(Math.Max(boton.Width, minimo.Width), Math.Max(boton.Height, minimo.Height))
        End If
    End Sub

    Private Shared Function EscalarParaDpi(valor As Integer, dpi As Integer) As Integer
        Return CInt(Math.Ceiling(valor * dpi / 96.0F))
    End Function

    Private Shared Sub ResaltarFoco(sender As Object, e As EventArgs)
        Dim boton As Button = DirectCast(sender, Button)
        If EsControlDeMenu(boton) Then Return
        boton.FlatAppearance.BorderColor = TextoPrincipal
    End Sub

    Private Shared Sub QuitarResaltadoFoco(sender As Object, e As EventArgs)
        Dim boton As Button = DirectCast(sender, Button)
        If EsControlDeMenu(boton) Then Return
        boton.FlatAppearance.BorderColor = If(EsBotonSecundario(boton) AndAlso boton.Enabled, BordeSecundario, boton.BackColor)
    End Sub

    Private Shared Function EsBotonSecundario(boton As Button) As Boolean
        Return boton.Name.IndexOf("Cancelar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Quitar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Cerrar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Descartar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Editar", StringComparison.OrdinalIgnoreCase) >= 0
    End Function

    Private Shared Function ObtenerNombreIcono(boton As Button) As String
        Select Case boton.Name
            Case "btnProductos"
                Return "products"
            Case "btnVenta"
                Return "sales"
            Case "btnHistorial"
                Return "history"
            Case "btnEntradas"
                Return "inventory"
            Case "btnUsuarios"
                Return "users"
            Case "btnSalir"
                Return "sign-out"
            Case "btnEntrar"
                Return "sign-in"
            Case "btnMostrarContrasena"
                Return "eye"
            Case "btnNuevoProducto", "btnNuevoUsuario"
                Return "add"
            Case "btnEditarProducto", "btnEditarUsuario"
                Return "edit"
            Case "btnSeleccionarImagen"
                Return "image-upload"
            Case "btnQuitarImagen"
                Return "image-remove"
            Case "btnGuardar"
                Return "save"
            Case "btnRegistrarEntrada"
                Return "stock-in"
            Case "btnAgregarProducto"
                Return "cart-add"
            Case "btnQuitarProducto"
                Return "cart-remove"
            Case "btnConfirmarVenta"
                Return "sale-confirm"
            Case "btnVerDetalle"
                Return "details"
            Case "btnCancelarVenta", "btnConfirmarCancelacion"
                Return "sale-cancel"
            Case Else
                Return Nothing
        End Select
    End Function

    Private Shared Function EsControlDeMenu(control As Control) As Boolean
        Dim actual As Control = control.Parent
        While actual IsNot Nothing
            If actual.Name = "tlpMenu" OrElse actual.Name = "pnlMenu" Then Return True
            actual = actual.Parent
        End While
        Return False
    End Function

    Private Shared Function EsTarjeta(nombre As String) As Boolean
        Return nombre = "pnlTarjeta" OrElse nombre = "pnlFiltros" OrElse nombre = "pnlTabla" OrElse nombre = "pnlVistaPrevia" OrElse nombre = "pnlCaptura" OrElse nombre = "pnlCatalogo" OrElse nombre = "pnlAgregar" OrElse nombre = "pnlCobro" OrElse nombre = "pnlResumen" OrElse nombre = "pnlCapturaCancelacion" OrElse nombre = "pnlDatosCancelacion" OrElse nombre = "pnlEncabezado"
    End Function

    Public Shared Sub ConfigurarEtiqueta(etiqueta As Label, control As Control, texto As String)
        etiqueta.Text = If(texto.StartsWith("&", StringComparison.Ordinal), texto, "&" & texto)
        etiqueta.UseMnemonic = True
        etiqueta.AccessibleName = texto.Replace("&", String.Empty)
        control.AccessibleName = texto.Replace("&", String.Empty)
    End Sub

    Private Shared Function NombreLegible(nombre As String) As String
        If String.IsNullOrWhiteSpace(nombre) Then Return "Control"

        Dim resultado As String = nombre
        For Each prefijo As String In New String() {"txt", "cbo", "nud", "dtp", "dgv", "btn", "chk", "pic"}
            If resultado.StartsWith(prefijo, StringComparison.OrdinalIgnoreCase) Then
                resultado = resultado.Substring(prefijo.Length)
                Exit For
            End If
        Next

        For indice As Integer = resultado.Length - 1 To 1 Step -1
            If Char.IsUpper(resultado(indice)) Then resultado = resultado.Insert(indice, " ")
        Next
        Return resultado.Trim()
    End Function
End Class
