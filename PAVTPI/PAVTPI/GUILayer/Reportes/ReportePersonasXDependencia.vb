Public Class ReportePersonasXDependencia

    Dim dbhelper As DBHelper = DBHelper.getDBHelper


    Private Sub ReportePersonasXDependencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_combo(Me.cmb_dependencia, (dbhelper.ConsultaSQL("select * from dependencia")), "nroCuentaCorriente", "nombre")
    End Sub

    Private Function leo_tabla(ByVal tabla As String) As DataTable
        Return (dbhelper.ConsultaSQL("select * from " & tabla))

    End Function
    Private Sub cargar_combo(ByRef combo As ComboBox _
                              , ByRef tabla As DataTable _
                              , ByVal pk As String _
                              , ByVal descriptor As String)

        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
        combo.SelectedIndex = 0

    End Sub

    Private Sub generar_reportePersonasXDependencia()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "select * from dependenciaXPersona DP where DP.nroCuentaCorriente = " & Me.cmb_dependencia.SelectedValue

        tabla = dbhelper.ConsultaSQL(sql)
        personaXdependenciaBindingSource.DataSource = tabla

        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_generar_Click(sender As Object, e As EventArgs) Handles cmd_generar.Click
        generar_reportePersonasXDependencia()
    End Sub
End Class