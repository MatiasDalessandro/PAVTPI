Public Class AbmDependencia
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-VS0357J\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim condicion_grabacion As estado_grabacion = estado_grabacion.insertar

    Private Sub AbmDependencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
        cargar_combo()
        txt_descripcion.Enabled = False
        txt_nombre.Enabled = False
        cmb_estado.Enabled = False
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
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function
    Private Sub cargarGrilla()

        Dim sql As String = "SELECT IdDependencia,Nombre,Descripcion,NroCuentaCorriente,Saldo,Estado from Dependencia"
        Dim tabla As DataTable = ejecuto_sql(sql)
        dgv_datos_dependencia.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_dependencia.Rows.Add()
            Me.dgv_datos_dependencia.Rows(c).Cells(0).Value = tabla.Rows(c)("nombre")
            Me.dgv_datos_dependencia.Rows(c).Cells(1).Value = tabla.Rows(c)(2)
            Me.dgv_datos_dependencia.Rows(c).Cells(2).Value = tabla.Rows(c)(3)
            Me.dgv_datos_dependencia.Rows(c).Cells(3).Value = tabla.Rows(c)(4)
            Me.dgv_datos_dependencia.Rows(c).Cells(4).Value = validar_estado(tabla.Rows(c)(5))
            Me.dgv_datos_dependencia.Rows(c).Cells(5).Value = tabla.Rows(c)(0)
        Next
    End Sub
    Private Function validar_estado(ByVal estado As Integer)
        If estado = True Then
            Return "Habilitado"
            Exit Function
        End If
        Return "Deshabilitado"
    End Function
    Private Function validar_estado_r(ByVal estado As String)
        If estado = "Habilitado" Then
            Return 1
            Exit Function

        End If
        Return 0
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

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        For Each obj As Control In Me.Controls
            If obj.GetType.Name = "TextBox" Or obj.GetType.Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
            If obj.GetType.Name = "ComboBox" Then
                Dim o As ComboBox = obj
                o.SelectedValue = -1
            End If
        Next
        Me.txt_nombre.Enabled = True
        Me.txt_descripcion.Enabled = True
        Me.cmb_estado.Enabled = True
        Me.txt_nro.Text = generar_nro_cta()
        Me.txt_nro.ReadOnly = True
        Me.condicion_grabacion = estado_grabacion.insertar
        Me.txt_nombre.Focus()
    End Sub
    Private Function generar_nro_cta()
        Dim sql = "Select NroCuentaCorriente FROM Dependencia"
        Dim nro As Integer = 0
        Dim tabla As DataTable = ejecuto_sql(sql)
        nro = tabla.Rows(tabla.Rows.Count - 1)(0)
        Return nro + 1
    End Function
    Private Sub grabar_borrar(sql As String)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Private Sub insertar()
        Dim nro As Integer = Me.txt_nro.Text
        Dim estado As Integer = validar_estado_r(Me.cmb_estado.SelectedValue)
        Dim sql As String = ""
        sql &= "insert into [PAV-TPI].dbo.Dependencia (Nombre,Descripcion,NroCuentaCorriente,Estado) VALUES ('"
        sql &= Me.txt_nombre.Text & "', '" & Me.txt_descripcion.Text & "'," & nro & "," & estado & ")"
        grabar_borrar(sql)

    End Sub
    Private Sub modificar()
        Dim id As Integer = dgv_datos_dependencia.CurrentRow.Cells(5).Value
        Dim sql As String = "UPDATE [PAV-TPI].dbo.Dependencia set nombre='" & Me.txt_nombre.Text & "',descripcion = '" & txt_descripcion.Text & "' where IdDependencia = "
        sql &= id
        grabar_borrar(sql)


    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If condicion_grabacion = estado_grabacion.insertar Then
            insertar()
        Else
            modificar()
        End If
        cargarGrilla()
        MsgBox("Se cargo correctamente.")
    End Sub

    Private Sub dgv_datos_dependencia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos_dependencia.CellContentClick
        Dim sql As String = ""
        sql &= "SELECT * FROM [PAV-TPI].dbo.Dependencia WHERE IdDependencia = " & dgv_datos_dependencia.CurrentRow.Cells(5).Value
        Dim tabla As DataTable = ejecuto_sql(sql)
        If tabla.Rows.Count = 0 Then
            MsgBox("No hay personas para recuperar")
        End If
        Me.txt_nombre.Text = tabla.Rows(0)("Nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("Descripcion")
        Me.txt_nro.Text = tabla.Rows(0)("NroCuentaCorriente")
        Me.cmb_estado.Text = validar_estado(tabla.Rows(0)("Estado"))
        condicion_grabacion = estado_grabacion.modificar


    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If MessageBox.Show("Esta seguro de borrar: " + Chr(13) +
                           "Dependencia: " & Me.dgv_datos_dependencia.CurrentRow.Cells(0).Value.ToString.Trim + Chr(10) +
                           "Descripcion: " & Me.dgv_datos_dependencia.CurrentRow.Cells(1).Value.ToString.Trim _
                           , "Importante" _
                           , MessageBoxButtons.YesNo _
                           , MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim sql As String = "DELETE FROM [PAV-TPI].dbo.Dependencia where IdDependencia = "
        sql &= dgv_datos_dependencia.CurrentRow.Cells(5).Value
        grabar_borrar(sql)
        cargarGrilla()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class