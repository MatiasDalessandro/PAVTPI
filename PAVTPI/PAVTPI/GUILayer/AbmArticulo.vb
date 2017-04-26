Public Class AbmArticulo
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=MATI-PC\GDAPAV;Integrated Security=SSPI;Initial Catalog=PAV-TPI"

    Enum estado_grabacion
        aprobado
        rechazado
    End Enum
    Enum condicionGrabacion
        insertar
        modificar
    End Enum

    Dim estadoGrabacion As condicionGrabacion = condicionGrabacion.insertar
    Private Sub AbmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        sql = "SELECT * FROM Articulo"

        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        Dim c As Integer = 0

        Me.dgv_datos_articulos.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_articulos.Rows.Add()
            Me.dgv_datos_articulos.Rows(c).Cells("c_id_articulo").Value = tabla.Rows(c)(0)
            Me.dgv_datos_articulos.Rows(c).Cells("c_nombre_articulo").Value = tabla.Rows(c)(1)
            Me.dgv_datos_articulos.Rows(c).Cells("c_precio_articulo").Value = tabla.Rows(c)(2)
        Next
    End Sub

    Private Function validar_articulo() As estado_grabacion
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM Articulo WHERE idArticulo_Combo = " & Me.txt_id_articulo.Text

        tabla = ejecutosql(sql)

        If tabla.Rows.Count = 0 Then
            Return estado_grabacion.aprobado
        Else
            Return estado_grabacion.rechazado
        End If
    End Function

    Private Function validar_datos() As estado_grabacion
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

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String = ""




        If validar_datos() = estado_grabacion.aprobado Then
            If estadoGrabacion = condicionGrabacion.insertar Then
                If validar_articulo() = estado_grabacion.aprobado Then
                    insertar()
                Else
                    MsgBox("El ID del Articulo ya existe.")
                End If
            Else
                modificar()
            End If
        Else

        End If


    End Sub
    Private Sub insertar()
        Dim sql As String = ""
        sql = " INSERT INTO Articulo (IdArticulo_Combo,Nombre,Precio) values ( " & txt_id_articulo.Text & ", '" & txt_nombre_articulo.Text & "' , " & txt_precio.Text & ")"
        ejecutosql(sql)
        MsgBox("Se grabo correctamente.")
        Me.cargar_grilla()

    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE Articulo SET IdArticulo_Combo = " & txt_id_articulo.Text
        sql &= " , Nombre = '" & txt_nombre_articulo.Text & "'"
        sql &= " , Precio = " & txt_precio.Text
        sql &= " WHERE IdArticulo_Combo = " & txt_id_articulo.Text

        ejecutosql(sql)
        Me.cargar_grilla()
        MsgBox("Se Modifico correctamente.")

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_precio.Enabled = False
        txt_nombre_articulo.Enabled = False
        txt_nombre_articulo.Text = ""
        txt_precio.Text = ""
        txt_id_articulo.Text = ""
        Me.cargar_grilla()
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = False
        Me.txt_id_articulo.Enabled = True
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_nombre_articulo.Enabled = True
        txt_precio.Enabled = True
        txt_nombre_articulo.Text = ""
        txt_precio.Text = ""
        txt_id_articulo.Text = ""
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        estadoGrabacion = condicionGrabacion.insertar
        Me.txt_id_articulo.Enabled = True
    End Sub

    Private Function btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Articulo WHERE idArticulo_Combo = " & txt_id_articulo.Text
        tabla = ejecutosql(sql)
        Me.dgv_datos_articulos.Rows.Clear()

        Dim c As Integer = 0

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_articulos.Rows.Add()
            Me.dgv_datos_articulos.Rows(c).Cells("c_id_articulo").Value = tabla.Rows(c)(0)
            Me.dgv_datos_articulos.Rows(c).Cells("c_nombre_articulo").Value = tabla.Rows(c)(1)
            Me.dgv_datos_articulos.Rows(c).Cells("c_precio_articulo").Value = tabla.Rows(c)(2)
        Next

    End Function

    Private Sub dgv_datos_articulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos_articulos.CellDoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM Articulo WHERE idArticulo_Combo = " & Me.dgv_datos_articulos.CurrentRow.Cells("c_id_articulo").Value

        tabla = ejecutosql(sql)

        Me.txt_id_articulo.Text = tabla.Rows(0)("idArticulo_Combo")
        Me.txt_nombre_articulo.Text = tabla.Rows(0)("Nombre")
        Me.txt_precio.Text = tabla.Rows(0)("Precio")

        Me.txt_precio.Enabled = True
        Me.txt_nombre_articulo.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        Me.txt_id_articulo.Enabled = False
        estadoGrabacion = condicionGrabacion.modificar

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""

        If validar_datos() = estado_grabacion.aprobado Then
            If validar_articulo() = estado_grabacion.rechazado Then
                sql = " DELETE FROM Articulo WHERE idArticulo_Combo = " & txt_id_articulo.Text
                MsgBox("Se elimino correctamente el Articulo.")
            Else
                MsgBox("Cargue correctamente el Articulo a eliminar.")
            End If
        End If

        ejecutosql(sql)
        Me.cargar_grilla()
    End Sub
End Class