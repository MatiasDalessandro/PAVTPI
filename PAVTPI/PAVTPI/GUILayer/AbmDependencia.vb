Public Class AbmDependencia
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-VS0357J\SQLEXPRESS;Integrated Security=SSPI"
    Private Sub AbmDependencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub
    Private Function ejecuto_sql(ByVal consulta As String)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader)
        conexion.Close()
        Return tabla
    End Function
    Private Sub cargarGrilla()
        Dim sql As String = "SELECT * FROM Dependencia"
        Dim tabla As DataTable = ejecuto_sql(sql)
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_dependencia.Rows.Add()
            Me.dgv_datos_dependencia.Rows(c).Cells("c_id_articulo").Value = tabla.Rows(c)(0)
            Me.dgv_datos_dependencia.Rows(c).Cells("c_nombre_articulo").Value = tabla.Rows(c)(1)
            Me.dgv_datos_dependencia.Rows(c).Cells("c_precio_articulo").Value = tabla.Rows(c)(2)
        Next
    End Sub

End Class