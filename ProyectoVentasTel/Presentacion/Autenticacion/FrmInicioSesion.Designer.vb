<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicioSesion
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
        Me.pnlTarjeta = New System.Windows.Forms.Panel()
        Me.pnlTarjeta.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnMostrarContrasena = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.erpInicioSesion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Size = New System.Drawing.Size(480, 520)
        Me.Name = "FrmInicioSesion"
        Me.Text = "Iniciar sesión"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 3
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlTarjeta.Name = "pnlTarjeta"
        Me.pnlTarjeta.Visible = True
        Me.pnlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Visible = True
        Me.lblMarca.Text = "Ventas Tel"
        Me.lblMarca.Location = New System.Drawing.Point(20, 20)
        Me.lblMarca.Size = New System.Drawing.Size(360, 32)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Iniciar sesión"
        Me.lblTitulo.Location = New System.Drawing.Point(20, 58)
        Me.lblTitulo.Size = New System.Drawing.Size(360, 36)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Visible = True
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.Location = New System.Drawing.Point(20, 108)
        Me.lblUsuario.Size = New System.Drawing.Size(340, 22)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Visible = True
        Me.txtUsuario.Location = New System.Drawing.Point(20, 134)
        Me.txtUsuario.Size = New System.Drawing.Size(360, 38)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Visible = True
        Me.lblContrasena.Text = "Contraseña"
        Me.lblContrasena.Location = New System.Drawing.Point(20, 184)
        Me.lblContrasena.Size = New System.Drawing.Size(340, 22)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Visible = True
        Me.txtContrasena.Location = New System.Drawing.Point(20, 210)
        Me.txtContrasena.Size = New System.Drawing.Size(240, 38)
        Me.btnMostrarContrasena.Name = "btnMostrarContrasena"
        Me.btnMostrarContrasena.Visible = True
        Me.btnMostrarContrasena.Text = "Mostrar"
        Me.btnMostrarContrasena.Location = New System.Drawing.Point(272, 206)
        Me.btnMostrarContrasena.Size = New System.Drawing.Size(108, 40)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Visible = True
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.Location = New System.Drawing.Point(20, 266)
        Me.btnEntrar.Size = New System.Drawing.Size(360, 40)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Visible = True
        Me.lblMensaje.Text = ""
        Me.lblMensaje.Location = New System.Drawing.Point(20, 318)
        Me.lblMensaje.Size = New System.Drawing.Size(360, 22)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlTarjeta, 1, 1)
        Me.pnlTarjeta.Controls.Add(Me.lblMarca)
        Me.pnlTarjeta.Controls.Add(Me.lblTitulo)
        Me.pnlTarjeta.Controls.Add(Me.lblUsuario)
        Me.pnlTarjeta.Controls.Add(Me.txtUsuario)
        Me.pnlTarjeta.Controls.Add(Me.lblContrasena)
        Me.pnlTarjeta.Controls.Add(Me.txtContrasena)
        Me.pnlTarjeta.Controls.Add(Me.btnMostrarContrasena)
        Me.pnlTarjeta.Controls.Add(Me.btnEntrar)
        Me.pnlTarjeta.Controls.Add(Me.lblMensaje)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlTarjeta As System.Windows.Forms.Panel
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasena As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents btnMostrarContrasena As System.Windows.Forms.Button
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents erpInicioSesion As System.Windows.Forms.ErrorProvider
End Class
