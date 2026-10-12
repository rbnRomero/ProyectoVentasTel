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
        Me.components = New System.ComponentModel.Container()
        Me.SuspendLayout()
        Me.tlpRaiz = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpRaiz.Padding = New System.Windows.Forms.Padding(24, 24, 24, 24)
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.pnlEncabezado.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.btnEditarUsuario = New System.Windows.Forms.Button()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.pnlFiltros.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.pnlFiltros.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.cboFiltroRol = New System.Windows.Forms.ComboBox()
        Me.cboFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.pnlTabla = New System.Windows.Forms.Panel()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.colIdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSinUsuarios = New System.Windows.Forms.Label()
        Me.Size = New System.Drawing.Size(1008, 704)
        Me.Name = "UcUsuarios"
        Me.tlpRaiz.Name = "tlpRaiz"
        Me.tlpRaiz.Visible = True
        Me.tlpRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaiz.ColumnCount = 1
        Me.tlpRaiz.RowCount = 3
        Me.tlpRaiz.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpRaiz.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Visible = True
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Visible = True
        Me.lblTitulo.Text = "Usuarios"
        Me.lblTitulo.Location = New System.Drawing.Point(0, 8)
        Me.lblTitulo.Size = New System.Drawing.Size(300, 32)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Visible = True
        Me.btnNuevoUsuario.Text = "Nuevo usuario"
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(430, 0)
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(144, 40)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Visible = True
        Me.btnEditarUsuario.Text = "Editar usuario"
        Me.btnEditarUsuario.Location = New System.Drawing.Point(586, 0)
        Me.btnEditarUsuario.Size = New System.Drawing.Size(144, 40)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Visible = True
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Visible = True
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Location = New System.Drawing.Point(20, 8)
        Me.lblBuscar.Size = New System.Drawing.Size(280, 22)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Visible = True
        Me.lblRol.Text = "Rol"
        Me.lblRol.Location = New System.Drawing.Point(312, 8)
        Me.lblRol.Size = New System.Drawing.Size(180, 22)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Visible = True
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.Location = New System.Drawing.Point(504, 8)
        Me.lblEstado.Size = New System.Drawing.Size(180, 22)
        Me.txtBuscarUsuario.Name = "txtBuscarUsuario"
        Me.txtBuscarUsuario.Visible = True
        Me.txtBuscarUsuario.Location = New System.Drawing.Point(20, 34)
        Me.txtBuscarUsuario.Size = New System.Drawing.Size(280, 38)
        Me.cboFiltroRol.Name = "cboFiltroRol"
        Me.cboFiltroRol.Visible = True
        Me.cboFiltroRol.Location = New System.Drawing.Point(312, 34)
        Me.cboFiltroRol.Size = New System.Drawing.Size(180, 38)
        Me.cboFiltroEstado.Name = "cboFiltroEstado"
        Me.cboFiltroEstado.Visible = True
        Me.cboFiltroEstado.Location = New System.Drawing.Point(504, 34)
        Me.cboFiltroEstado.Size = New System.Drawing.Size(180, 38)
        Me.cboFiltroRol.Items.AddRange(New Object() {"Todos", "Administrador", "Vendedor", "Inventarios"})
        Me.cboFiltroEstado.Items.AddRange(New Object() {"Todos", "Activos", "Inactivos"})
        Me.pnlTabla.Name = "pnlTabla"
        Me.pnlTabla.Visible = True
        Me.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Visible = True
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.ColumnHeadersHeight = 40
        Me.dgvUsuarios.RowTemplate.Height = 36
        Me.colIdUsuario.Name = "colIdUsuario"
        Me.colIdUsuario.HeaderText = "IdUsuario"
        Me.colIdUsuario.Visible = True
        Me.colIdUsuario.Width = 100
        Me.colNombreCompleto.Name = "colNombreCompleto"
        Me.colNombreCompleto.HeaderText = "Nombre"
        Me.colNombreCompleto.Visible = True
        Me.colNombreCompleto.Width = 240
        Me.colNombreUsuario.Name = "colNombreUsuario"
        Me.colNombreUsuario.HeaderText = "Usuario"
        Me.colNombreUsuario.Visible = True
        Me.colNombreUsuario.Width = 190
        Me.colRol.Name = "colRol"
        Me.colRol.HeaderText = "Rol"
        Me.colRol.Visible = True
        Me.colRol.Width = 160
        Me.colActivo.Name = "colActivo"
        Me.colActivo.HeaderText = "Estado"
        Me.colActivo.Visible = True
        Me.colActivo.Width = 110
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdUsuario, Me.colNombreCompleto, Me.colNombreUsuario, Me.colRol, Me.colActivo})
        Me.lblSinUsuarios.Name = "lblSinUsuarios"
        Me.lblSinUsuarios.Visible = True
        Me.lblSinUsuarios.Text = "No hay usuarios para mostrar"
        Me.lblSinUsuarios.Location = New System.Drawing.Point(320, 200)
        Me.lblSinUsuarios.Size = New System.Drawing.Size(320, 28)
        Me.Controls.Add(Me.tlpRaiz)
        Me.tlpRaiz.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.btnNuevoUsuario)
        Me.pnlEncabezado.Controls.Add(Me.btnEditarUsuario)
        Me.tlpRaiz.Controls.Add(Me.pnlFiltros, 0, 1)
        Me.pnlFiltros.Controls.Add(Me.lblBuscar)
        Me.pnlFiltros.Controls.Add(Me.lblRol)
        Me.pnlFiltros.Controls.Add(Me.lblEstado)
        Me.pnlFiltros.Controls.Add(Me.txtBuscarUsuario)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroRol)
        Me.pnlFiltros.Controls.Add(Me.cboFiltroEstado)
        Me.tlpRaiz.Controls.Add(Me.pnlTabla, 0, 2)
        Me.pnlTabla.Controls.Add(Me.dgvUsuarios)
        Me.pnlTabla.Controls.Add(Me.lblSinUsuarios)
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
