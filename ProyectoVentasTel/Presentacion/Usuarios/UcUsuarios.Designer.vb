<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcUsuarios
    Inherits System.Windows.Forms.UserControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.btnEditarUsuario = New System.Windows.Forms.Button()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.cboFiltroRol = New System.Windows.Forms.ComboBox()
        Me.cboFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.colIdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinUsuarios = New System.Windows.Forms.Label()
        Me.tlpRaiz.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        Me.pnlTabla.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpRaiz
        '
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpRaiz.Controls.Add(Me.pnlFiltros, 0, 1)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 2)
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.Location = New System.Drawing.Point(0, 0)
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24)
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.White
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.btnNuevoUsuario)
        Me.pnlEncabezado.Controls.Add(Me.btnEditarUsuario)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEncabezado.Location = New System.Drawing.Point(24, 24)
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(960, 44)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(300, 40)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Usuarios"
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNuevoUsuario.FlatAppearance.BorderSize = 0
        Me.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoUsuario.ForeColor = System.Drawing.Color.White
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(430, 0)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(144, 40)
        Me.btnNuevoUsuario.TabIndex = 1
        Me.btnNuevoUsuario.Text = "Nuevo usuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = False
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEditarUsuario.FlatAppearance.BorderSize = 0
        Me.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnEditarUsuario.Location = New System.Drawing.Point(586, 0)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(144, 40)
        Me.btnEditarUsuario.TabIndex = 2
        Me.btnEditarUsuario.Text = "Editar usuario"
        Me.btnEditarUsuario.UseVisualStyleBackColor = False
        '
        'pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.White
        Me.pnlFiltros.Controls.Add(Me.lblBuscar)
        Me.pnlFiltros.Controls.Add(Me.lblRol)
        Me.pnlFiltros.Controls.Add(Me.lblEstado)
        Me.pnlFiltros.Controls.Add(Me.txtBuscarUsuario)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroRol)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroEstado)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFiltros.Location = New System.Drawing.Point(24, 84)
        Me.pnlFiltros.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFiltros.Size = New System.Drawing.Size(960, 76)
        Me.pnlFiltros.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(20, 8)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(280, 22)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar"
        '
        'lblRol
        '
        Me.lblRol.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblRol.Location = New System.Drawing.Point(312, 8)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(180, 22)
        Me.lblRol.TabIndex = 1
        Me.lblRol.Text = "Rol"
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(504, 8)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(180, 22)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Estado"
        '
        'txtBuscarUsuario
        '
        Me.txtBuscarUsuario.BackColor = System.Drawing.Color.White
        Me.txtBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtBuscarUsuario.Location = New System.Drawing.Point(20, 34)
        Me.txtBuscarUsuario.Name = "txtBuscarUsuario"
        Me.txtBuscarUsuario.Size = New System.Drawing.Size(280, 32)
        Me.txtBuscarUsuario.TabIndex = 3
        '
        'cboFiltroRol
        '
        Me.cboFiltroRol.BackColor = System.Drawing.Color.White
        Me.cboFiltroRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFiltroRol.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFiltroRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboFiltroRol.Items.AddRange(New Object() {"Todos", "Administrador", "Vendedor", "Inventarios"})
        Me.cboFiltroRol.Location = New System.Drawing.Point(312, 34)
        Me.cboFiltroRol.Name = "cboFiltroRol"
        Me.cboFiltroRol.Size = New System.Drawing.Size(180, 33)
        Me.cboFiltroRol.TabIndex = 4
        '
        'cboFiltroEstado
        '
        Me.cboFiltroEstado.BackColor = System.Drawing.Color.White
        Me.cboFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboFiltroEstado.Items.AddRange(New Object() {"Todos", "Activos", "Inactivos"})
        Me.cboFiltroEstado.Location = New System.Drawing.Point(504, 34)
        Me.cboFiltroEstado.Name = "cboFiltroEstado"
        Me.cboFiltroEstado.Size = New System.Drawing.Size(180, 33)
        Me.cboFiltroEstado.TabIndex = 5
        '
        'pnlTabla
        '
        Me.pnlTabla.BackColor = System.Drawing.Color.White
        Me.pnlTabla.Controls.Add(Me.dgvUsuarios)
        Me.pnlTabla.Controls.Add(Me.lblSinUsuarios)
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTabla.Location = New System.Drawing.Point(27, 179)
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Size = New System.Drawing.Size(954, 498)
        Me.pnlTabla.TabIndex = 2
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.ColumnHeadersHeight = 40
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdUsuario, Me.colNombreCompleto, Me.colNombreUsuario, Me.colRol, Me.colActivo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.RowTemplate.Height = 36
        Me.dgvUsuarios.Size = New System.Drawing.Size(954, 498)
        Me.dgvUsuarios.TabIndex = 0
        '
        'colIdUsuario
        '
        Me.colIdUsuario.HeaderText = "IdUsuario"
        Me.colIdUsuario.MinimumWidth = 6
        Me.colIdUsuario.Name = "colIdUsuario"
        '
        'colNombreCompleto
        '
        Me.colNombreCompleto.HeaderText = "Nombre"
        Me.colNombreCompleto.MinimumWidth = 6
        Me.colNombreCompleto.Name = "colNombreCompleto"
        Me.colNombreCompleto.Width = 240
        '
        'colNombreUsuario
        '
        Me.colNombreUsuario.HeaderText = "Usuario"
        Me.colNombreUsuario.MinimumWidth = 6
        Me.colNombreUsuario.Name = "colNombreUsuario"
        Me.colNombreUsuario.Width = 190
        '
        'colRol
        '
        Me.colRol.HeaderText = "Rol"
        Me.colRol.MinimumWidth = 6
        Me.colRol.Name = "colRol"
        Me.colRol.Width = 160
        '
        'colActivo
        '
        Me.colActivo.HeaderText = "Estado"
        Me.colActivo.MinimumWidth = 6
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Width = 110
        '
        'lblSinUsuarios
        '
        Me.lblSinUsuarios.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblSinUsuarios.Location = New System.Drawing.Point(320, 200)
        Me.lblSinUsuarios.Name = "lblSinUsuarios"
        Me.lblSinUsuarios.Size = New System.Drawing.Size(320, 28)
        Me.lblSinUsuarios.TabIndex = 1
        Me.lblSinUsuarios.Text = "No hay usuarios para mostrar"
        Me.lblSinUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcUsuarios
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.tlpRaiz)
        Me.Name = "UcUsuarios"
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.tlpRaiz.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.pnlTabla.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpRaiz As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnNuevoUsuario As System.Windows.Forms.Button
    Friend WithEvents btnEditarUsuario As System.Windows.Forms.Button
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents txtBuscarUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cboFiltroRol As System.Windows.Forms.ComboBox
    Friend WithEvents cboFiltroEstado As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTabla As System.Windows.Forms.Panel
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents lblSinUsuarios As System.Windows.Forms.Label
    Friend WithEvents colIdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colActivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
