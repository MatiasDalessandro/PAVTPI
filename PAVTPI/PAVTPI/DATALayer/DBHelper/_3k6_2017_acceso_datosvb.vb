Public Class _3k6_2017_acceso_datosvb

    Dim conexion As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    Dim cadena_conexion As String = ""
    Dim nombre_tabla As String = ""

    Public Property _cadena_conexion As String
        Get
            Return Me.cadena_conexion
        End Get
        Set(ByVal value As String)
            Me.cadena_conexion = value
        End Set
    End Property

    Public Property _nombre_tabla As String
        Get
            Return Me.nombre_tabla
        End Get
        Set(ByVal value As String)
            Me.nombre_tabla = value
        End Set
    End Property
    Private Sub conectar()
        Me.conexion.ConnectionString = Me.cadena_conexion
        Me.conexion.Open()
        Me.cmd.Connection = conexion
        Me.cmd.CommandType = CommandType.Text
    End Sub
    Private Sub cerrar_conexion()
        conexion.Close()
    End Sub
    Enum valoresReturn
        tabla As DataTable
        filas As Integer
    End Enum
    Public Function _ejecutar_sql(ByVal sql As String) As DataTable
        Me.conectar()
        If sql.Trim.ToUpper.IndexOf("SELECT") = 0 Then
            cmd.CommandText = sql
            Dim tabla As New DataTable
            tabla.Load(cmd.ExecuteReader())
            Me.cerrar_conexion()
            Return tabla
        Else
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            Me.cerrar_conexion()
            Return New DataTable
        End If
    End Function
End Class
