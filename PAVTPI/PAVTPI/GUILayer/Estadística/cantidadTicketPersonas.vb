Public Class cantidadTicketPersonas
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim sql As String = "select distinct count(*) as cantidad,CONCAT(p.apellido,', ',p.nombre) as nombre from ticket t inner join persona p on p.nroDocumento=t.nroDocumento group by p.apellido,p.nombre order by cantidad"
        ticketXPersonaBindingSource.DataSource = dbhelper.ConsultaSQL(sql)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cantidadTicketPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class