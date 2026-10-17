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
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTarjeta = New System.Windows.Forms.Panel()
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
        Me.tlpRaiz.SuspendLayout()
        Me.pnlTarjeta.SuspendLayout()
        CType(Me.erpInicioSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.ColumnCount = 3
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlTarjeta, 1, 1)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(462, 473)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlTarjeta
        '
        Me.pnlTarjeta.BackColor = System.Drawing.Color.White
        Me.pnlTarjeta.Controls.Add(Me.lblMarca)
        Me.pnlTarjeta.Controls.Add(Me.lblTitulo)
        Me.pnlTarjeta.Controls.Add(Me.lblUsuario)
        Me.pnlTarjeta.Controls.Add(Me.txtUsuario)
        Me.pnlTarjeta.Controls.Add(Me.lblContrasena)
        Me.pnlTarjeta.Controls.Add(Me.txtContrasena)
        Me.pnlTarjeta.Controls.Add(Me.btnMostrarContrasena)
        Me.pnlTarjeta.Controls.Add(Me.btnEntrar)
        Me.pnlTarjeta.Controls.Add(Me.lblMensaje)
        Me.pnlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTarjeta.Location = New System.Drawing.Point(34, 59)
        Me.pnlTarjeta.Name = "pnlTarjeta"
        Me.pnlTarjeta.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlTarjeta.Size = New System.Drawing.Size(394, 354)
        Me.pnlTarjeta.TabIndex = 0
        '
        'lblMarca
        '
        Me.lblMarca.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblMarca.Location = New System.Drawing.Point(12, 10)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(360, 48)
        Me.lblMarca.TabIndex = 0
        Me.lblMarca.Text = "Ventas Tel"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(15, 49)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(360, 43)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Iniciar sesión"
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(20, 108)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(340, 22)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(20, 134)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(360, 32)
        Me.txtUsuario.TabIndex = 3
        '
        'lblContrasena
        '
        Me.lblContrasena.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblContrasena.Location = New System.Drawing.Point(20, 184)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(340, 22)
        Me.lblContrasena.TabIndex = 4
        Me.lblContrasena.Text = "Contraseña"
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.White
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContrasena.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtContrasena.Location = New System.Drawing.Point(20, 210)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(240, 32)
        Me.txtContrasena.TabIndex = 5
        '
        'btnMostrarContrasena
        '
        Me.btnMostrarContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnMostrarContrasena.FlatAppearance.BorderSize = 0
        Me.btnMostrarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarContrasena.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnMostrarContrasena.Location = New System.Drawing.Point(272, 206)
        Me.btnMostrarContrasena.Name = "btnMostrarContrasena"
        Me.btnMostrarContrasena.Size = New System.Drawing.Size(108, 40)
        Me.btnMostrarContrasena.TabIndex = 6
        Me.btnMostrarContrasena.Text = "Mostrar"
        Me.btnMostrarContrasena.UseVisualStyleBackColor = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(20, 266)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(360, 40)
        Me.btnEntrar.TabIndex = 7
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(20, 318)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(360, 22)
        Me.lblMensaje.TabIndex = 8
        '
        'erpInicioSesion
        '
        Me.erpInicioSesion.ContainerControl = Me
        '
        'FrmInicioSesion
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 473)
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "FrmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlTarjeta.ResumeLayout(False)
        Me.pnlTarjeta.PerformLayout()
        CType(Me.erpInicioSesion, System.ComponentModel.ISupportInitialize).EndInit()
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
