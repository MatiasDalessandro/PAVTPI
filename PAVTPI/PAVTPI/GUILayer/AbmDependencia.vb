Public Class AbmDependencia
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-VS0357J\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    Private Sub AbmDependencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
        cargar_combo()

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
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function
    Private Sub cargarGrilla()
        Dim sql As String = "SELECT Nombre,Descripcion,NroCuentaCorriente,Saldo,Estado from Dependencia"
        Dim tabla As DataTable = ejecuto_sql(sql)
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_dependencia.Rows.Add()
            Me.dgv_datos_dependencia.Rows(c).Cells(0).Value = tabla.Rows(c)("nombre")
            Me.dgv_datos_dependencia.Rows(c).Cells(1).Value = tabla.Rows(c)(1)
            Me.dgv_datos_dependencia.Rows(c).Cells(2).Value = tabla.Rows(c)(2)
            Me.dgv_datos_dependencia.Rows(c).Cells(3).Value = tabla.Rows(c)(3)
            Me.dgv_datos_dependencia.Rows(c).Cells(4).Value = validar_estado(tabla.Rows(c)(4))
        Next
    End Sub
    Private Function validar_estado(ByVal estado As Integer)
        If estado = True Then
            Return "Habilitado"
            Exit Function
        End If
        Return "Deshabilitado"
    End Function
    Private Sub cargar_combo()
        Dim combo As ComboBox = Me.cmb_estado
        combo.Items.Add("Habilitado")
        combo.Items.Add("Deshabilitado")
    End Sub
    Private Function leo_tabla(ByVal sql As String) As DataTable
        Dim tabla As DataTable
        tabla = ejecuto_sql("SELECT * FROM" & sql)
        Return tabla
    End Function

End Class