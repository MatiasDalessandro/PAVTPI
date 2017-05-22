Public Class _3k6_2017_acceso_datosvb
    Enum tipo_conexion
        _simple
        _transaccion
    End Enum
    Enum resultado_transaccion
        _ok
        _error
    End Enum
    Dim configuracion_conexion As tipo_conexion = tipo_conexion._simple
    Dim control_transaccion As resultado_transaccion = resultado_transaccion._ok

    Dim conexion As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim transaccion As OleDb.OleDbTransaction

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
    Public Sub iniciar_conexion_con_transaccion()
        Me.configuracion_conexion = tipo_conexion._transaccion
        Me.control_transaccion = resultado_transaccion._ok
    End Sub
    Public Sub cerrar_conexion_con_transaccion()
        If Me.configuracion_conexion = tipo_conexion._transaccion Then
            If Me.control_transaccion = resultado_transaccion._ok Then
                Me.transaccion.Commit()
            Else
                Me.transaccion.Rollback()
            End If
            Me.configuracion_conexion = tipo_conexion._simple
            Me.cerrar_conexion()
        End If
    End Sub
    Private Sub conectar()
        If conexion.State.ToString <> "Open" Then
            Me.conexion.ConnectionString = Me.cadena_conexion
            Me.conexion.Open()
            Me.cmd.Connection = conexion
            Me.cmd.CommandType = CommandType.Text

            If Me.configuracion_conexion = tipo_conexion._transaccion Then
                Me.transaccion = Me.conexion.BeginTransaction()
                Me.cmd.Transaction = Me.transaccion
                Me.control_transaccion = resultado_transaccion._ok
            End If
        End If
    End Sub
    Private Sub cerrar_conexion()
        If configuracion_conexion = tipo_conexion._simple Then
            conexion.Close()
        End If
    End Sub
    Public Function _ejecutar_sql(ByVal sql As String) As DataTable
        Me.conectar()
        If sql.Trim.ToUpper.IndexOf("SELECT") = 0 Then
            cmd.CommandText = sql
            Dim tabla As New DataTable
            Try
                tabla.Load(cmd.ExecuteReader())
            Catch ex As Exception
                Me.control_transaccion = resultado_transaccion._error
                MessageBox.Show("Error SQL: " + ex.Message _
                                + Chr(13) _
                                + "En la consulta: " _
                                + Chr(13) _
                                + sql)
            End Try

            Me.cerrar_conexion()
            Return tabla
        Else
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Me.control_transaccion = resultado_transaccion._error
                MessageBox.Show("Error SQL: " + ex.Message _
                                + Chr(13) _
                                + "En la consulta: " _
                                + Chr(13) _
                                + sql)
            End Try

            Me.cerrar_conexion()
            Return New DataTable
        End If
    End Function
    '"apellido = damiano, nombre=luis, sexo=M"
    Public Sub _insertar(ByVal datos As String)

        Dim estructura As New DataTable
        estructura = Me.consulto_estructura()
        Dim pares() As String
        pares = datos.Split(";")
        Dim c As Integer = 0
        Dim est_col As String = ""
        Dim est_dat As String = ""
        For c = 0 To pares.Length - 1
            Dim columnas() As String
            columnas = pares(c).Split("=")
            Dim d As Integer = 0
            Dim encontre As Boolean = False
            Dim tipodato As String = ""
            For d = 0 To estructura.Columns.Count - 1
                If columnas(0).ToUpper.Trim = estructura.Columns(d).ColumnName.ToUpper.Trim Then
                    encontre = True
                    tipodato = estructura.Columns(d).DataType.Name
                End If
            Next
            If encontre = True Then
                est_col &= IIf(est_col = "", "", ", ") & columnas(0).Trim
                est_dat &= IIf(est_dat = "", "", ", ") & Me.formatear(columnas(1).Trim, tipodato)
            Else
                MsgBox("La columna " & columnas(0).ToUpper.Trim _
                       & " no es correcta ")
                Exit Sub
            End If
        Next

        Dim txt_insert As String = ""
        txt_insert = "INSERT INTO " & Me.nombre_tabla & "( " _
                     & est_col & ") VALUES (" & est_dat & ")"

        Me._ejecutar_sql(txt_insert)

    End Sub
    Private Function formatear(ByVal dato As String, ByVal tipoDato As String) As String
        Select Case tipoDato
            Case "String", "Date"
                Return "'" & dato & "'"
                'Case "Date"
                '    Return "'" & dato & "'"
            Case Else
                Return dato.Replace(",", ".")
        End Select
    End Function
    Private Function consulto_estructura() As DataTable
        Return Me._ejecutar_sql("SELECT TOP 1 * FROM " & Me.nombre_tabla)
    End Function

End Class
