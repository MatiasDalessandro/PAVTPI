Public Class AsistMensual

    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub AsistMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim datatable As New DataTable
        Dim sql As String = " select distinct COUNT(*) as veces, p.apellido from empleadoXAsistencia ea, empleadoXAsistencia ea1 "
        sql &= " inner join persona p on p.nroDocumento = ea1.nroDocumento "
        sql &= " where (ea.nroDocumento = ea1.nroDocumento) and (MONTH(ea.fechaHoraInicio)= " & txtMes.Text & ") "
        sql &= " group by p.apellido"

        datatable = dbhelper.ConsultaSQL(sql)

        AsistMensualBindingSource.DataSource = datatable
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class