Public Class FrmUsuario
    Public Sub New()
        InitializeComponent()
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        lblAvisoContrasena.ForeColor = UiTema.Advertencia
        lblAvisoContrasena.AccessibleName = "Aviso sobre contraseña"
        lblAvisoContrasena.AccessibleRole = AccessibleRole.StaticText
        AcceptButton = btnGuardar
        CancelButton = btnCancelar
        txtNombreCompleto.Focus()
    End Sub
End Class
