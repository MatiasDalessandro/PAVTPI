Public Class AsistMensual

    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub AsistMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim datatable As New DataTable
        Dim sql As String = ""


        If txtMes.Text = "" Then
            MsgBox("Debe ingresar un mes")
        Else
            sql &= " select distinct COUNT(*) as veces, p.apellido from empleadoXAsistencia ea "
            sql &= " inner join persona p on p.nroDocumento = ea.nroDocumento  "
            sql &= " where (ea.nroDocumento = p.nroDocumento) and (MONTH(ea.fechaHoraInicio)= " & txtMes.Text & ") "
            sql &= " group by p.apellido "
            datatable = dbhelper.ConsultaSQL(sql)

            If datatable.Rows.Count < 1 Then
                MsgBox("No existen asistencias")
            End If

            AsistMensualBindingSource.DataSource = datatable
            Me.ReportViewer1.RefreshReport()
        End If



    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class