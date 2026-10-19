Public Class UcUsuarios
    Private Sub UcUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.ConfigurarBarraAcciones(tlpRaiz, pnlEncabezado, lblTitulo, btnNuevoUsuario, btnEditarUsuario)
        UiTema.ConfigurarEtiqueta(lblBuscar, txtBuscarUsuario, "Buscar")
        UiTema.ConfigurarEtiqueta(lblRol, cboFiltroRol, "Rol")
        UiTema.ConfigurarEtiqueta(lblEstado, cboFiltroEstado, "Estado")
        UiTema.ConfigurarTabla(dgvUsuarios, "usuarios")
    End Sub
End Class
