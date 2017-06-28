Public Class ArticuloMvendido
    Dim dbhelper As DBHelper = DBHelper.getDBHelper
    Private Sub ArticuloMvendido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub generar_articuloMasVendido()
        Dim tabla As New DataTable
        Dim SQL As String = ""

        SQL &= " select A.nombre , DTA.cantidad"
        SQL &= "        from articulo A"
        SQL &= "        join detalleTicketArticulo DTA on DTA.idArticulo = A.idArticuloIntegrante "

        tabla = dbhelper.ConsultaSQL(SQL)

        ArticuloMVendidoBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub btn_amv_Click(sender As Object, e As EventArgs) Handles btn_amv.Click
        generar_articuloMasVendido()
    End Sub
End Class