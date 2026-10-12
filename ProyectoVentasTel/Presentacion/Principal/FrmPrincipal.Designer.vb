<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SuspendLayout()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnVenta.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnHistorial.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnEntradas = New System.Windows.Forms.Button()
        Me.btnEntradas.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlAreaPrincipal = New System.Windows.Forms.Panel()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTituloSeccion = New System.Windows.Forms.Label()
        Me.lblRolActual = New System.Windows.Forms.Label()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.ucProductos = New Global.ProyectoVentasTel.UcProductos()
        Me.Size = New System.Drawing.Size(1280, 800)
        Me.Name = "FrmPrincipal"
        Me.Text = "Ventas Tel"
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.RowCount = 1
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Visible = True
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.Visible = True
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMenu.ColumnCount = 1
        Me.tlpMenu.RowCount = 8
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Visible = True
        Me.lblMarca.Text = "VENTAS TEL"
        Me.lblMarca.Location = New System.Drawing.Point(20, 20)
        Me.lblMarca.Size = New System.Drawing.Size(184, 32)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Visible = True
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Visible = True
        Me.btnVenta.Text = "Nueva venta"
        Me.btnVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Visible = True
        Me.btnHistorial.Text = "Historial de ventas"
        Me.btnHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEntradas.Name = "btnEntradas"
        Me.btnEntradas.Visible = True
        Me.btnEntradas.Text = "Entradas de inventario"
        Me.btnEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Visible = True
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Visible = True
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAreaPrincipal.Name = "pnlAreaPrincipal"
        Me.pnlAreaPrincipal.Visible = True
        Me.pnlAreaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Size = New System.Drawing.Size(1056, 72)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTituloSeccion.Name = "lblTituloSeccion"
        Me.lblTituloSeccion.Visible = True
        Me.lblTituloSeccion.Text = "Productos"
        Me.lblTituloSeccion.Location = New System.Drawing.Point(24, 22)
        Me.lblTituloSeccion.Size = New System.Drawing.Size(640, 32)
        Me.lblRolActual.Name = "lblRolActual"
        Me.lblRolActual.Visible = True
        Me.lblRolActual.Text = ""
        Me.lblRolActual.Location = New System.Drawing.Point(560, 22)
        Me.lblRolActual.Size = New System.Drawing.Size(200, 28)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Visible = True
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucProductos.Name = "ucProductos"
        Me.ucProductos.Visible = True
        Me.ucProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlMenu, 0, 0)
        Me.pnlMenu.Controls.Add(Me.tlpMenu)
        Me.tlpMenu.Controls.Add(Me.lblMarca, 0, 0)
        Me.tlpMenu.Controls.Add(Me.btnProductos, 0, 1)
        Me.tlpMenu.Controls.Add(Me.btnVenta, 0, 2)
        Me.tlpMenu.Controls.Add(Me.btnHistorial, 0, 3)
        Me.tlpMenu.Controls.Add(Me.btnEntradas, 0, 4)
        Me.tlpMenu.Controls.Add(Me.btnUsuarios, 0, 5)
        Me.tlpMenu.Controls.Add(Me.btnSalir, 0, 7)
        Me.tlpRaiz.Controls.Add(Me.pnlAreaPrincipal, 1, 0)
        Me.pnlAreaPrincipal.Controls.Add(Me.pnlContenido)
        Me.pnlAreaPrincipal.Controls.Add(Me.pnlEncabezado)
        Me.pnlEncabezado.Controls.Add(Me.lblTituloSeccion)
        Me.pnlEncabezado.Controls.Add(Me.lblRolActual)
        Me.pnlContenido.Controls.Add(Me.ucProductos)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents tlpMenu As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents btnHistorial As System.Windows.Forms.Button
    Friend WithEvents btnEntradas As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pnlAreaPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTituloSeccion As System.Windows.Forms.Label
    Friend WithEvents lblRolActual As System.Windows.Forms.Label
    Friend WithEvents pnlContenido As System.Windows.Forms.Panel
    Friend WithEvents ucProductos As Global.ProyectoVentasTel.UcProductos
End Class
