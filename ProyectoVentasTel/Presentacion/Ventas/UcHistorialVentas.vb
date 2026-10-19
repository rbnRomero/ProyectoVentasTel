Public Class UcHistorialVentas
    Private Sub UcHistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTema.Aplicar(Me)
        UiTema.OcultarEncabezadoDeModulo(tlpRaiz, pnlEncabezado, lblTitulo)
        UiTema.ConfigurarEtiqueta(lblDesde, dtpDesde, "Desde")
        UiTema.ConfigurarEtiqueta(lblHasta, dtpHasta, "Hasta")
        UiTema.ConfigurarEtiqueta(lblEstado, cboEstado, "Estado")
        dtpDesde.Format = DateTimePickerFormat.Short
        dtpHasta.Format = DateTimePickerFormat.Short
        UiTema.ConfigurarTabla(dgvVentas, "historial de ventas")
    End Sub

    Private Sub btnVerDetalle_Click(sender As Object, e As EventArgs) Handles btnVerDetalle.Click

    End Sub
End Class
