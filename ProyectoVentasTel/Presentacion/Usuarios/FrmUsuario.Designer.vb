<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24, 24, 24, 24)
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tlpCampos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblAvisoContrasena = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.erpUsuario = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Size = New System.Drawing.Size(560, 560)
        Me.Name = "FrmUsuario"
        Me.Text = "Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Nuevo usuario"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 10)
        Me.lblTitulo.Size = New System.Drawing.Size(440, 36)
        Me.tlpCampos.Name = "tlpCampos"
        Me.tlpCampos.Visible = True
        Me.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCampos.ColumnCount = 1
        Me.tlpCampos.RowCount = 10
        Me.tlpCampos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpCampos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Visible = True
        Me.lblNombreCompleto.Text = "Nombre completo"
        Me.lblNombreCompleto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Visible = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(470, 38)
        Me.txtNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Visible = True
        Me.lblNombreUsuario.Text = "Nombre de usuario"
        Me.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Visible = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(470, 38)
        Me.txtNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Visible = True
        Me.lblRol.Text = "Rol"
        Me.lblRol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Visible = True
        Me.cboRol.Size = New System.Drawing.Size(470, 38)
        Me.cboRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Visible = True
        Me.lblContrasena.Text = "Contraseña"
        Me.lblContrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Visible = True
        Me.txtContrasena.Size = New System.Drawing.Size(470, 38)
        Me.txtContrasena.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboRol.Items.AddRange(New Object() {"Administrador", "Vendedor", "Inventarios"})
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Visible = True
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAvisoContrasena.Name = "lblAvisoContrasena"
        Me.lblAvisoContrasena.Visible = True
        Me.lblAvisoContrasena.Text = "En edición, deje la contraseña vacía para conservarla."
        Me.lblAvisoContrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Visible = True
        Me.btnGuardar.Text = "Guardar usuario"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 40)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Visible = True
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 40)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 2)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.tlpRaiz.Controls.Add(Me.tlpCampos, 0, 1)
        Me.tlpRaiz.SetColumnSpan(Me.tlpCampos, 2)
        Me.tlpCampos.Controls.Add(Me.lblNombreCompleto, 0, 0)
        Me.tlpCampos.Controls.Add(Me.txtNombreCompleto, 0, 1)
        Me.tlpCampos.Controls.Add(Me.lblNombreUsuario, 0, 2)
        Me.tlpCampos.Controls.Add(Me.txtNombreUsuario, 0, 3)
        Me.tlpCampos.Controls.Add(Me.lblRol, 0, 4)
        Me.tlpCampos.Controls.Add(Me.cboRol, 0, 5)
        Me.tlpCampos.Controls.Add(Me.lblContrasena, 0, 6)
        Me.tlpCampos.Controls.Add(Me.txtContrasena, 0, 7)
        Me.tlpCampos.Controls.Add(Me.chkActivo, 0, 8)
        Me.tlpCampos.Controls.Add(Me.lblAvisoContrasena, 0, 9)
        Me.tlpRaiz.Controls.Add(Me.btnGuardar, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.btnCancelar, 1, 2)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tlpCampos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblNombreCompleto As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents cboRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblContrasena As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblAvisoContrasena As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents erpUsuario As System.Windows.Forms.ErrorProvider
End Class
