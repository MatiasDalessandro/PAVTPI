Public Class AbmRol

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=EMA-PC;Integrated Security=SSPI;Initial Catalog=PAV-TPI"

    Enum estado_grabacion
        aprobado
        rechazado
    End Enum
    Enum condicionGrabacion
        insertar
        modificar
    End Enum
    Dim estadoGrabacion = condicionGrabacion.insertar


    Private Sub AbmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = ""

        sql = "SELECT * FROM Rol"

        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        Dim c As Integer = 0

        Me.dgv_datos_rol.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_rol.Rows.Add()
            Me.dgv_datos_rol.Rows(c).Cells("c_id_rol").Value = tabla.Rows(c)(0)
            Me.dgv_datos_rol.Rows(c).Cells("c_nombre_rol").Value = tabla.Rows(c)(1)
        Next
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_nombre_rol.Enabled = False
        txt_nombre_rol.Text = ""
        Me.cargar_grilla()
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = False
        Me.txt_id_rol.Text = ""
        Me.txt_id_rol.Enabled = True

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_id_rol.Text = ""
        txt_nombre_rol.Text = ""
        txt_nombre_rol.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        estadoGrabacion = condicionGrabacion.insertar
        Me.txt_id_rol.Enabled = True
    End Sub

    Private Function ejecutosql(ByVal consulta As String) As DataTable
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

    Private Sub dgv_datos_rol_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos_rol.CellDoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM Rol WHERE IdRol = " & Me.dgv_datos_rol.CurrentRow.Cells("c_id_rol").Value

        tabla = ejecutosql(sql)

        Me.txt_id_rol.Text = tabla.Rows(0)("idRol")
        Me.txt_nombre_rol.Text = tabla.Rows(0)("Descripcion")

        Me.txt_id_rol.Enabled = True
        Me.txt_nombre_rol.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        estadoGrabacion = condicionGrabacion.modificar
        Me.txt_id_rol.Enabled = False

    End Sub

    Private Function validarRol() As estado_grabacion
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM Rol WHERE idRol = " & txt_id_rol.Text

        tabla = Me.ejecutosql(sql)

        If tabla.Rows.Count = 0 Then
            Return estado_grabacion.aprobado
        Else
            Return estado_grabacion.rechazado
        End If
    End Function

    Private Function validarDatos() As estado_grabacion
        For Each obj As Control In Me.Controls
            If obj.GetType.Name = "TextBox" Then
                If obj.Text = "" Then
                    MsgBox("El " & obj.Name & " no está ingresado")
                    obj.Focus()
                    Return estado_grabacion.rechazado
                End If
            End If
        Next

    End Function

    Private Sub insertar()
        Dim sql As String = ""

        sql = " INSERT INTO Rol (IdRol,Descripcion) VALUES ( " & txt_id_rol.Text & ", '" & txt_nombre_rol.Text & "')"
        ejecutosql(sql)
        MsgBox("Se grabo correctamente.")
        Me.cargar_grilla()
    End Sub

    Public Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE Rol SET IdRol = " & txt_id_rol.Text & ", Descripcion = '" & txt_nombre_rol.Text & "' WHERE IdRol = " & txt_id_rol.Text
        ejecutosql(sql)
        MsgBox("Se modifico correctamente.")
        Me.cargar_grilla()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String = ""




        If validarDatos() = estado_grabacion.aprobado Then
            If estadoGrabacion = condicionGrabacion.insertar Then
                If validarRol() = estado_grabacion.aprobado Then
                    insertar()
                Else
                    MsgBox("El ID del Rol ya existe.")
                End If
            Else
                modificar()
            End If
        Else

        End If

        Me.txt_id_rol.Text = ""
        Me.txt_nombre_rol.Text = ""

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""

        If validarDatos() = estado_grabacion.aprobado Then
            If validarRol() = estado_grabacion.rechazado Then
                sql = " DELETE FROM Rol WHERE IdRol = " & txt_id_rol.Text
                MsgBox("Se elimino correctamente el Rol.")
            Else
                MsgBox("Cargue correctamente el Rol a eliminar.")
            End If
        End If

        ejecutosql(sql)
        Me.cargar_grilla()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Rol WHERE IdRol = " & txt_id_rol.Text

        tabla = Me.ejecutosql(sql)
        Dim c As Integer = 0
        Me.dgv_datos_rol.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_rol.Rows.Add()
            Me.dgv_datos_rol.Rows(c).Cells("c_id_rol").Value = tabla.Rows(c)(0)
            Me.dgv_datos_rol.Rows(c).Cells("c_nombre_rol").Value = tabla.Rows(c)(1)
        Next

    End Sub
End Class