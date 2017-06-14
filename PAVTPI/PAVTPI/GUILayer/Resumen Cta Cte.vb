Public Class Resumen_Cta_Cte
    Dim cadena As String = "Provider=SQLNCLI11;Data Source=LAPTOP-6VOLNCDP\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    Dim conexion As New OleDb.OleDbConnection With {.ConnectionString = cadena}
    Dim cmd As New OleDb.OleDbCommand

    Private Sub Resumen_Cta_Cte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT * FROM pagoXCuentaCorriente WHERE pagoXCuentaCorriente.nroCuentaCorriente = " & txtCtaCte.Text




        ResumenBindingSource.DataSource = tabla

        ReportViewer1.RefreshReport()
    End Sub
End Class