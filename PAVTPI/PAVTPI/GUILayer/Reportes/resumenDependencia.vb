Public Class resumenDependencia
    Dim dbhelper As DBHelper = DBHelper.getDBHelper


    Private Sub btn_buscardep_Click(sender As Object, e As EventArgs) Handles btn_buscardep.Click
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "select nroCuentaCorriente, nombre, saldo, estado from dependencia"

        tabla = dbhelper.ConsultaSQL(sql)

        resumenBindingSource.DataSource = tabla
        rv_resumenDep.RefreshReport()

    End Sub

    Private Sub resumenDependencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class