Public Class resumenRoll
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub btn_rr_Click(sender As Object, e As EventArgs) Handles btn_rr.Click
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "select * from rol"

        tabla = dbhelper.ConsultaSQL(sql)
        resumenRolBindingSource.DataSource = tabla
        rv_rr.RefreshReport()
    End Sub

    Private Sub resumenRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class