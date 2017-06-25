Public Class DeudasDependencias

    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub generar_deudasDependencias()
        Dim tabla As New DataTable
        Dim SQL As String

        SQL = "select D.descripcion as nombre , D.saldo from dependencia D"

        tabla = dbhelper.ConsultaSQL(SQL)

        DeudasDependenciasBindingSource.DataSource = tabla
        rv_dd.RefreshReport()

    End Sub

    Private Sub cmd_generarDD_Click(sender As Object, e As EventArgs) Handles cmd_generarDD.Click
        Me.generar_deudasDependencias()
    End Sub
End Class