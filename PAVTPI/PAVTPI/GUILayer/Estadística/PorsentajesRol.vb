Public Class PorsentajesRol
    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub generar_porcentajesRol()
        Dim tabla As New DataTable
        Dim SQL As String = ""

        SQL &= " select count(idRol) as valor, descripcion from rol"
        SQL &= " group by descripcion "

        tabla = dbhelper.ConsultaSQL(SQL)

        RolBindingSource.DataSource = tabla
        rv_pr.RefreshReport()

    End Sub

    Private Sub PorsentajesRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_pr_Click(sender As Object, e As EventArgs) Handles btn_pr.Click
        generar_porcentajesRol()
    End Sub
End Class