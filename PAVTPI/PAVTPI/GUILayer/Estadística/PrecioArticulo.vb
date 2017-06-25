Public Class PrecioArticulo
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub generar_precioArticulos()
        Dim tabla As New DataTable
        Dim SQL As String = ""

        SQL &= " select nombre, precio from articulo "

        tabla = dbhelper.ConsultaSQL(SQL)

        PrecioArticulosBindingSource.DataSource = tabla
        rv_ctd.RefreshReport()

    End Sub



    Private Sub cmd_generarPrecioArticulos_Click(sender As Object, e As EventArgs) Handles cmd_generarPrecioArticulos.Click
        generar_precioArticulos()
    End Sub
End Class