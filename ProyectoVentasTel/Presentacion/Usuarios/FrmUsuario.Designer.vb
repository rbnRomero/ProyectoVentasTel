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
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
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
        Me.tlpRaiz.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.tlpCampos.SuspendLayout()
        CType(Me.erpUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.ColumnCount = 2
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.tlpCampos, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.btnGuardar, 0, 2)
        Me.tlpRaiz.Controls.Add(Me.btnCancelar, 1, 2)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(542, 513)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.tlpRaiz.SetColumnSpan(Me.pnlEncabezado, 2)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEncabezado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlEncabezado.Location = New System.Drawing.Point(27, 27)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(488, 54)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(-2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(440, 54)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Nuevo usuario"
        '
        'tlpCampos
        '
        Me.tlpCampos.ColumnCount = 1
        Me.tlpRaiz.SetColumnSpan(Me.tlpCampos, 2)
        Me.tlpCampos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
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
        Me.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCampos.Location = New System.Drawing.Point(27, 87)
        Me.tlpCampos.Name = "tlpCampos"
        Me.tlpCampos.RowCount = 10
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
        Me.tlpCampos.Size = New System.Drawing.Size(488, 343)
        Me.tlpCampos.TabIndex = 1
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombreCompleto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblNombreCompleto.Location = New System.Drawing.Point(3, 0)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(482, 24)
        Me.lblNombreCompleto.TabIndex = 0
        Me.lblNombreCompleto.Text = "Nombre completo"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.BackColor = System.Drawing.Color.White
        Me.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(3, 27)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(482, 32)
        Me.txtNombreCompleto.TabIndex = 1
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(3, 66)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(482, 24)
        Me.lblNombreUsuario.TabIndex = 2
        Me.lblNombreUsuario.Text = "Nombre de usuario"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.White
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(3, 93)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(482, 32)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'lblRol
        '
        Me.lblRol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRol.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblRol.Location = New System.Drawing.Point(3, 132)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(482, 24)
        Me.lblRol.TabIndex = 4
        Me.lblRol.Text = "Rol"
        '
        'cboRol
        '
        Me.cboRol.BackColor = System.Drawing.Color.White
        Me.cboRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRol.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboRol.Items.AddRange(New Object() {"Administrador", "Vendedor", "Inventarios"})
        Me.cboRol.Location = New System.Drawing.Point(3, 159)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(482, 33)
        Me.cboRol.TabIndex = 5
        '
        'lblContrasena
        '
        Me.lblContrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContrasena.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblContrasena.Location = New System.Drawing.Point(3, 198)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(482, 24)
        Me.lblContrasena.TabIndex = 6
        Me.lblContrasena.Text = "Contraseña"
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.White
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContrasena.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtContrasena.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtContrasena.Location = New System.Drawing.Point(3, 225)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(482, 32)
        Me.txtContrasena.TabIndex = 7
        '
        'chkActivo
        '
        Me.chkActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkActivo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.chkActivo.Location = New System.Drawing.Point(3, 267)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(482, 26)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "Activo"
        '
        'lblAvisoContrasena
        '
        Me.lblAvisoContrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAvisoContrasena.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvisoContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.lblAvisoContrasena.Location = New System.Drawing.Point(3, 296)
        Me.lblAvisoContrasena.Name = "lblAvisoContrasena"
        Me.lblAvisoContrasena.Size = New System.Drawing.Size(482, 47)
        Me.lblAvisoContrasena.TabIndex = 9
        Me.lblAvisoContrasena.Text = "En edición, deje la contraseña vacía para conservarla."
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(27, 436)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar usuario"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(274, 436)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 40)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'erpUsuario
        '
        Me.erpUsuario.ContainerControl = Me
        '
        'FrmUsuario
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(542, 513)
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuario"
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        Me.tlpCampos.ResumeLayout(False)
        Me.tlpCampos.PerformLayout()
        CType(Me.erpUsuario, System.ComponentModel.ISupportInitialize).EndInit()
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
