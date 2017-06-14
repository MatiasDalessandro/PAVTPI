Public Class ReporteVentasPorHoraPico
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub cmd_generarReporte_Click(sender As Object, e As EventArgs) Handles cmd_generarReporte.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        If Me.mtb_horaInicio.Text = "" Or Me.mtb_horaFin.Text = "" Then
            MsgBox("Cargue correctamente el intervalo de horas")
        Else
            If Me.mtb_horaInicio.Text > 24 Or Me.mtb_horaFin.Text > 24 Or Convert.ToInt32(Me.mtb_horaInicio.Text) > Convert.ToInt32(Me.mtb_horaFin.Text) Or Convert.ToInt32(Me.mtb_horaInicio.Text) = Convert.ToInt32(Me.mtb_horaFin.Text) Then
                MsgBox("Cargue correctamente el intervalo de horas")
            Else
                sql &= "select * from ticket"
                sql &= " where DATEPART(HOUR,fechaHora) >" & Me.mtb_horaInicio.Text & " and datepart(hour,fechaHora) < " & Me.mtb_horaFin.Text

                tabla = dbhelper.ConsultaSQL(sql)

                ticketBindingSource.DataSource = tabla
                ReportViewer1.RefreshReport()
            End If
        End If

    End Sub

    Private Sub ReporteVentasPorHoraPico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class