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
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnEntradas = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlAreaPrincipal = New System.Windows.Forms.Panel()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTituloSeccion = New System.Windows.Forms.Label()
        Me.lblRolActual = New System.Windows.Forms.Label()
        Me.ucProductos = New ProyectoVentasTel.UcProductos()
        Me.tlpRaiz.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.tlpMenu.SuspendLayout()
        Me.pnlAreaPrincipal.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlMenu, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.pnlAreaPrincipal, 1, 0)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.RowCount = 1
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(1262, 753)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.tlpMenu)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(3, 3)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(218, 747)
        Me.pnlMenu.TabIndex = 0
        '
        'tlpMenu
        '
        Me.tlpMenu.ColumnCount = 1
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.Controls.Add(Me.lblMarca, 0, 0)
        Me.tlpMenu.Controls.Add(Me.btnProductos, 0, 1)
        Me.tlpMenu.Controls.Add(Me.btnVenta, 0, 2)
        Me.tlpMenu.Controls.Add(Me.btnHistorial, 0, 3)
        Me.tlpMenu.Controls.Add(Me.btnEntradas, 0, 4)
        Me.tlpMenu.Controls.Add(Me.btnUsuarios, 0, 5)
        Me.tlpMenu.Controls.Add(Me.btnSalir, 0, 7)
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 8
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpMenu.Size = New System.Drawing.Size(218, 747)
        Me.tlpMenu.TabIndex = 0
        '
        'lblMarca
        '
        Me.lblMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(3, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(184, 32)
        Me.lblMarca.TabIndex = 0
        Me.lblMarca.Text = "VENTAS TEL"
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Location = New System.Drawing.Point(0, 74)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(218, 40)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnVenta
        '
        Me.btnVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVenta.FlatAppearance.BorderSize = 0
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.Location = New System.Drawing.Point(0, 118)
        Me.btnVenta.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(218, 40)
        Me.btnVenta.TabIndex = 2
        Me.btnVenta.Text = "Ventas"
        '
        'btnHistorial
        '
        Me.btnHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHistorial.FlatAppearance.BorderSize = 0
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.White
        Me.btnHistorial.Location = New System.Drawing.Point(0, 162)
        Me.btnHistorial.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(218, 40)
        Me.btnHistorial.TabIndex = 3
        Me.btnHistorial.Text = "Historial Ventas"
        '
        'btnEntradas
        '
        Me.btnEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEntradas.FlatAppearance.BorderSize = 0
        Me.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntradas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntradas.ForeColor = System.Drawing.Color.White
        Me.btnEntradas.Location = New System.Drawing.Point(0, 206)
        Me.btnEntradas.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnEntradas.Name = "btnEntradas"
        Me.btnEntradas.Size = New System.Drawing.Size(218, 40)
        Me.btnEntradas.TabIndex = 4
        Me.btnEntradas.Text = "Inventario"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 250)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(218, 40)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.Text = "Usuarios"
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(3, 710)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(212, 34)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'pnlAreaPrincipal
        '
        Me.pnlAreaPrincipal.Controls.Add(Me.pnlContenido)
        Me.pnlAreaPrincipal.Controls.Add(Me.pnlEncabezado)
        Me.pnlAreaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAreaPrincipal.Location = New System.Drawing.Point(227, 3)
        Me.pnlAreaPrincipal.Name = "pnlAreaPrincipal"
        Me.pnlAreaPrincipal.Size = New System.Drawing.Size(1032, 747)
        Me.pnlAreaPrincipal.TabIndex = 1
        '
        'pnlContenido
        '
        Me.pnlContenido.Controls.Add(Me.ucProductos)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(0, 72)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1032, 675)
        Me.pnlContenido.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.White
        Me.pnlEncabezado.Controls.Add(Me.lblTituloSeccion)
        Me.pnlEncabezado.Controls.Add(Me.lblRolActual)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(1032, 72)
        Me.pnlEncabezado.TabIndex = 1
        '
        'lblTituloSeccion
        '
        Me.lblTituloSeccion.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloSeccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTituloSeccion.Location = New System.Drawing.Point(24, 22)
        Me.lblTituloSeccion.Name = "lblTituloSeccion"
        Me.lblTituloSeccion.Size = New System.Drawing.Size(640, 47)
        Me.lblTituloSeccion.TabIndex = 0
        Me.lblTituloSeccion.Text = "Productos"
        '
        'lblRolActual
        '
        Me.lblRolActual.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRolActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblRolActual.Location = New System.Drawing.Point(560, 22)
        Me.lblRolActual.Name = "lblRolActual"
        Me.lblRolActual.Size = New System.Drawing.Size(200, 28)
        Me.lblRolActual.TabIndex = 1
        '
        'ucProductos
        '
        Me.ucProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ucProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucProductos.Location = New System.Drawing.Point(0, 0)
        Me.ucProductos.Name = "ucProductos"
        Me.ucProductos.Size = New System.Drawing.Size(1032, 675)
        Me.ucProductos.TabIndex = 0
        '
        'FrmPrincipal
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1262, 753)
        Me.Controls.Add(Me.tlpRaiz)
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventas Tel"
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.tlpMenu.ResumeLayout(False)
        Me.pnlAreaPrincipal.ResumeLayout(False)
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
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
