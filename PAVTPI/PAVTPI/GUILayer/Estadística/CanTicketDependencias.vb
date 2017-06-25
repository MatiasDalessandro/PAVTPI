Public Class CanTicketDependencias
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub generar_canTicketsDependencias()
        Dim tabla As New DataTable
        Dim SQL As String = ""

        SQL &= " select D.descripcion, COUNT(*) valor from ticket T "
        SQL &= " JOIN dependencia D On T.nroCuentaCorriente = D.nroCuentaCorriente "
        SQL &= " group by D.descripcion "

        tabla = dbhelper.ConsultaSQL(SQL)

        CanTicketDependenciasBindingSource.DataSource = tabla
        rv_ctd.RefreshReport()

    End Sub

    Private Sub cmd_generarCantTicketDependencias_Click(sender As Object, e As EventArgs) Handles cmd_generarCantTicketDependencias.Click
        generar_canTicketsDependencias()
    End Sub

    Private Sub CanTicketDependencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class