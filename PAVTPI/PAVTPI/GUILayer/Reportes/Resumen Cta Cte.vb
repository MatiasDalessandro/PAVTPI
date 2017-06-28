Public Class Resumen_Cta_Cte
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub Resumen_Cta_Cte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        If txtCtaCte.Text = "" Then
            MsgBox("Debe introducir un numero de Cuenta Corriente")
            Exit Sub
        End If

        sql &= "select * from dependencia where dependencia.nroCuentaCorriente = " & txtCtaCte.Text

        tabla = dbhelper.ConsultaSQL(sql)
        If tabla.Rows.Count < 1 Then
            MsgBox("No existe una dependencia con ese numero")
        End If
        ResumenBindingSource.DataSource = tabla

        ReportViewer1.RefreshReport()
    End Sub
End Class