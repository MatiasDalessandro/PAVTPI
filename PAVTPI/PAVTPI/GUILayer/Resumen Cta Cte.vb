Public Class Resumen_Cta_Cte
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub Resumen_Cta_Cte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "select * from dependencia where dependencia.nroCuentaCorriente = " & txtCtaCte.Text

        tabla = dbhelper.ConsultaSQL(sql)
        ResumenBindingSource.DataSource = tabla

        ReportViewer1.RefreshReport()
    End Sub
End Class