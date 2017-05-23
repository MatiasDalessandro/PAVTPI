Public Class AbmArticulo

    Dim dbhelper As DBHelper = DBHelper.getDBHelper


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
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM articulo"

        tabla = dbhelper.ConsultaSQL(sql)
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

        sql &= " SELECT * FROM articulo WHERE idArticuloIntegrante = " & Me.msk_IdArticulo.Text

        tabla = dbhelper.ConsultaSQL(sql)

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

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String = ""

        If validar_datos() = estado_grabacion.aprobado Then
            If estadoGrabacion = condicionGrabacion.insertar Then
                insertar()
            Else
                modificar()
            End If
        Else

        End If


    End Sub
    Private Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO articulo (nombre,precio) values ('" & txt_nombre_articulo.Text & "' , " & txt_precio.Text & ")"
        dbhelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente.")
        Me.cargar_grilla()
    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE articulo SET "
        sql &= " nombre = '" & txt_nombre_articulo.Text & "'"
        sql &= " , precio = " & txt_precio.Text
        sql &= " WHERE idArticuloIntegrante = " & Me.msk_IdArticulo.Text

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
        MsgBox("Se Modifico correctamente.")

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_precio.Enabled = False
        txt_nombre_articulo.Enabled = False
        txt_nombre_articulo.Text = ""
        txt_precio.Text = ""
        Me.msk_IdArticulo.Text = ""
        Me.cargar_grilla()
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = False
        Me.msk_IdArticulo.Enabled = True
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_nombre_articulo.Enabled = True
        txt_precio.Enabled = True
        txt_nombre_articulo.Text = ""
        txt_precio.Text = ""
        Me.msk_IdArticulo.Text = ""
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = True
        estadoGrabacion = condicionGrabacion.insertar
        Me.msk_IdArticulo.Enabled = False
    End Sub

    Private Function btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM articulo WHERE idArticuloIntegrante = " & Me.msk_IdArticulo.Text
        tabla = dbhelper.ConsultaSQL(sql)
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

        sql = " SELECT * FROM articulo WHERE idArticuloIntegrante = " & Me.dgv_datos_articulos.CurrentRow.Cells("c_id_articulo").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.msk_IdArticulo.Text = tabla.Rows(0)("idArticuloCombo")
        Me.txt_nombre_articulo.Text = tabla.Rows(0)("nombre")
        Me.txt_precio.Text = tabla.Rows(0)("precio")

        Me.txt_precio.Enabled = True
        Me.txt_nombre_articulo.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        Me.msk_IdArticulo.Enabled = False
        estadoGrabacion = condicionGrabacion.modificar

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""

        If validar_datos() = estado_grabacion.aprobado Then
            If validar_articulo() = estado_grabacion.rechazado Then
                sql = " DELETE FROM articulo WHERE idArticuloIntegrante = " & Me.msk_IdArticulo.Text
                MsgBox("Se elimino correctamente el Articulo.")
                'Me.msk_IdArticulo.Text = ""
                'Me.txt_nombre_articulo.Text = ""
                'Me.txt_precio.Text = ""
            Else
                MsgBox("Cargue correctamente el Articulo a eliminar.")
            End If
        End If

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
    End Sub
End Class