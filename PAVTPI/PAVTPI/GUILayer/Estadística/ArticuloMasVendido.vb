Public Class ArticuloMasVendido
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub generar_articuloMasVendido()
        Dim tabla As New DataTable
        Dim SQL As String = ""

        SQL &= " select A.nombre , DTA.cantidad"
        SQL &= "        from articulo A"
        SQL &= "        join detalleTicketArticulo DTA on DTA.idArticulo = A.idArticuloIntegrante "

        tabla = dbhelper.ConsultaSQL(SQL)

        ArticuloMasVendidoBindingSource.DataSource = tabla
        rv_amv.RefreshReport()

    End Sub

    Private Sub cmd_generarArticuloMasVendido_Click(sender As Object, e As EventArgs) Handles cmd_generarArticuloMasVendido.Click
        generar_articuloMasVendido()
    End Sub
End Class