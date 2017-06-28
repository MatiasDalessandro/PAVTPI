Public Class EmpleadoMayorTurno

    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim fechaMinima As New DateTime(1900, 1, 1)
        Dim fechaMaxima As Date = Date.Now
        Dim datatable As New DataTable
        Dim sql As String = ""
        sql &= " select distinct COUNT(*) as veces, p.apellido, p.nombre  from empleadoXAsistencia ea "
        sql &= "      inner join persona p on p.nroDocumento = ea.nroDocumento "
        sql &= "     where (p.nroDocumento = ea.nroDocumento) and (MONTH(ea.fechaHoraInicio)=6) and (month(ea.fechaHoraInicio)=6) "
        sql &= " group by ea.nroDocumento, p.apellido, p.nombre "
        sql &= " order by veces desc "

        Dim fechaInicio As DateTime = CDate(dtpDesde.Text)
        Dim fechaFin As DateTime = CDate(dtpHasta.Text)

                If (fechaInicio < fechaMinima Or fechaFin > fechaMaxima) Then
                    MsgBox("Las fechas ingresadas no corresponden a un intervalo válido" + vbLf +
                            "Solo es posible ingresar fechas entre: " + fechaMinima + " y " + fechaMaxima + ".")
                    Exit Sub
                End If

                If fechaInicio > fechaFin Then
                    MsgBox("La fecha de fin de intervalo es anterior a la de inicio.")
                    Exit Sub
                End If

        datatable = dbhelper.ConsultaSQL(sql)

        EmpMayTurnoBindingSource.DataSource = datatable
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub EmpleadoMayorTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class