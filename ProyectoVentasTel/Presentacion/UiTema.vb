Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Paleta y convenciones visuales compartidas de la capa de presentación.
''' Se aplica en tiempo de ejecución para no modificar archivos generados por el diseñador.
''' </summary>
Public NotInheritable Class UiTema
    Public Shared ReadOnly Fondo As Color = Color.FromArgb(234, 240, 246)
    Public Shared ReadOnly Superficie As Color = Color.FromArgb(248, 250, 252)
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

        controlRaiz.BackColor = Fondo
        controlRaiz.ForeColor = TextoPrincipal
        If String.IsNullOrWhiteSpace(controlRaiz.AccessibleName) Then
            controlRaiz.AccessibleName = If(String.IsNullOrWhiteSpace(controlRaiz.Text), NombreLegible(controlRaiz.Name), controlRaiz.Text)
        End If
        AplicarRecursivamente(controlRaiz)
    End Sub

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
        tabla.ColumnHeadersDefaultCellStyle.ForeColor = Superficie
        tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Navegacion
        tabla.ColumnHeadersDefaultCellStyle.SelectionForeColor = Superficie
        tabla.DefaultCellStyle.BackColor = Campo
        tabla.DefaultCellStyle.ForeColor = TextoPrincipal
        tabla.DefaultCellStyle.SelectionBackColor = Primario
        tabla.DefaultCellStyle.SelectionForeColor = Superficie
        tabla.AlternatingRowsDefaultCellStyle.BackColor = Fondo
        tabla.AlternatingRowsDefaultCellStyle.ForeColor = TextoPrincipal
        tabla.AlternatingRowsDefaultCellStyle.SelectionBackColor = Primario
        tabla.AlternatingRowsDefaultCellStyle.SelectionForeColor = Superficie
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
        boton.FlatAppearance.BorderSize = 0
        boton.UseVisualStyleBackColor = False

        If boton.BackColor.ToArgb() = Peligro.ToArgb() Then
            boton.BackColor = Peligro
            boton.ForeColor = Superficie
        ElseIf boton.BackColor.ToArgb() = SecundarioDeshabilitado.ToArgb() OrElse EsBotonSecundario(boton) Then
            boton.BackColor = If(boton.Enabled, Secundario, SecundarioDeshabilitado)
            boton.ForeColor = If(boton.Enabled, Color.FromArgb(51, 65, 85), TextoSecundario)
            boton.FlatAppearance.BorderColor = BordeSecundario
            boton.FlatAppearance.BorderSize = 1
        ElseIf boton.Name.IndexOf("Salir", StringComparison.OrdinalIgnoreCase) >= 0 AndAlso boton.Parent IsNot Nothing AndAlso boton.Parent.Name = "tlpMenu" Then
            boton.BackColor = Navegacion
            boton.ForeColor = Superficie
        Else
            boton.BackColor = Primario
            boton.ForeColor = Superficie
        End If

        AplicarFocoVisible(boton)
    End Sub

    Private Shared Sub ResaltarFoco(sender As Object, e As EventArgs)
        Dim boton As Button = DirectCast(sender, Button)
        boton.FlatAppearance.BorderColor = If(EsControlDeMenu(boton), Superficie, TextoPrincipal)
        boton.FlatAppearance.BorderSize = 2
    End Sub

    Private Shared Sub QuitarResaltadoFoco(sender As Object, e As EventArgs)
        Dim boton As Button = DirectCast(sender, Button)
        boton.FlatAppearance.BorderSize = If(EsBotonSecundario(boton) AndAlso boton.Enabled, 1, 0)
    End Sub

    Private Shared Function EsBotonSecundario(boton As Button) As Boolean
        Return boton.Name.IndexOf("Cancelar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Quitar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Cerrar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Descartar", StringComparison.OrdinalIgnoreCase) >= 0 OrElse
               boton.Name.IndexOf("Editar", StringComparison.OrdinalIgnoreCase) >= 0
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
