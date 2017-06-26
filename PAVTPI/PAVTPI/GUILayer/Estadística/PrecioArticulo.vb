Public Class PrecioArticulo
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub generar_precioArticulos()
        Dim tabla As New DataTable
        Dim SQL As String = ""

        SQL &= " select nombre, precio from articulo "

        tabla = dbhelper.ConsultaSQL(SQL)

        PrecioArticulosBindingSource.DataSource = tabla
        rv_pa.RefreshReport()

    End Sub



    Private Sub cmd_generarPrecioArticulos_Click(sender As Object, e As EventArgs) Handles cmd_generarPrecioArticulos.Click
        generar_precioArticulos()
    End Sub

    Private Sub PrecioArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class