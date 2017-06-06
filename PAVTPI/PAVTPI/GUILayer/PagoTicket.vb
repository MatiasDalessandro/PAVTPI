Public Class Venta
    Dim dbHelper As DBHelper = DBHelper.getDBHelper
    Private Sub PagoTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grillas_simples(Me.dgv_articulo, dbHelper.ConsultaSQL("SELECT * FROM articulo"))
        cargar_grillas_simples(Me.dgv_combo, dbHelper.ConsultaSQL("SELECT DISTINCT idCombo,nombreCombo,precio FROM comboXArticulo"))
        cargar_combo(cmb_dependencia, (dbHelper.ConsultaSQL("select * from dependencia")), "nroCuentaCorriente", "nombre")

        Dim sql As String = "Select E.apellido, E.nombre from persona E where E.nroDocumento in (select rolXPersona.nroDocumento from rolXPersona where rolXPersona.idRol = 1)"

        'cargar_combo(cmb_empleado, (dbHelper.ConsultaSQL(sql)), "nroDocumento", sql.ToString)

        Me.txt_total.Enabled = False

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable, ByVal pk As String, ByVal descriptor As String)
        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
        combo.SelectedIndex = -1
    End Sub

    Private Sub btn_buscarArticulo_Click(sender As Object, e As EventArgs) Handles btn_buscarArticulo.Click
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM articulo WHERE idArticuloIntegrante= " & txt_articulo.Text
        tabla = dbHelper.ConsultaSQL(sql)
        cargar_grillas_simples(dgv_articulo, tabla)


    End Sub
    Private Sub cargar_grillas_simples(ByRef dgv As DataGridView, ByRef tabla As DataTable)
        dgv.DataSource = vbNull
        dgv.DataSource = tabla
        dgv.Columns(0).HeaderCell.Value = "Nro"
        dgv.Columns(1).HeaderCell.Value = "Nombre"
        dgv.Columns(2).HeaderCell.Value = "Precio"
    End Sub

    Private Sub bnt_agregarArticulo_Click(sender As Object, e As EventArgs) Handles bnt_agregarArticulo.Click
        dgv_detalle.Rows.Add(New String() {
                                    dgv_articulo(0, dgv_articulo.CurrentRow.Index).Value.ToString(),
                                    dgv_articulo(1, dgv_articulo.CurrentRow.Index).Value.ToString(),
                                    dgv_articulo(2, dgv_articulo.CurrentRow.Index).Value.ToString()
                               })
        calcular_total()
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dgv_detalle.Rows.Count > 1 Then
            Dim total As Double = txt_total.Text
            total += -dgv_detalle.CurrentRow.Cells(2).Value
            dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)
            txt_total.Text = total
        ElseIf dgv_detalle.Rows.Count = 1 Then
            Dim total As Double = txt_total.Text
            total += -dgv_detalle.CurrentRow.Cells(2).Value
            dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)
            txt_total.Text = total
            btn_quitar.Enabled = False
        End If
    End Sub
    Private Sub calcular_total()
        Dim total As Double = 0
        For Each row As DataGridViewRow In dgv_detalle.Rows
            total += CType(row.Cells(2).Value, Double)
        Next
        txt_total.Text = total
    End Sub

    Private Sub btn_mostrarTodosArt_Click(sender As Object, e As EventArgs) Handles btn_mostrarTodosArt.Click
        cargar_grillas_simples(Me.dgv_articulo, dbHelper.ConsultaSQL("SELECT * FROM articulo"))
    End Sub

    Private Sub btn_agregarDependencia_Click(sender As Object, e As EventArgs) Handles btn_agregarDependencia.Click
        AbmDependencia.Show()
    End Sub

    Private Sub btn_agregarEmpleado_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_agregarCombo_Click(sender As Object, e As EventArgs) Handles btn_agregarCombo.Click
        dgv_detalle.Rows.Add(New String() {
                                    dgv_combo(0, dgv_combo.CurrentRow.Index).Value.ToString(),
                                    dgv_combo(1, dgv_combo.CurrentRow.Index).Value.ToString(),
                                    dgv_combo(2, dgv_combo.CurrentRow.Index).Value.ToString()
                               })
        calcular_total()
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_mostrarTodosCom_Click(sender As Object, e As EventArgs) Handles btn_mostrarTodosCom.Click
        cargar_grillas_simples(Me.dgv_combo, dbHelper.ConsultaSQL("SELECT DISTINCT idCombo,nombreCombo,precio FROM comboXArticulo"))
    End Sub

    Private Sub btn_buscarCombo_Click(sender As Object, e As EventArgs) Handles btn_buscarCombo.Click
        Dim tabla As New DataTable
        Dim sql As String = "SELECT DISTINCT idCombo,nombreCombo,precio FROM comboXArticulo WHERE idCombo = " & txt_combo.Text
        tabla = dbHelper.ConsultaSQL(sql)
        cargar_grillas_simples(dgv_combo, tabla)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub chk_dependencia_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dependencia.CheckedChanged
        If chk_dependencia.Checked Then
            cmb_dependencia.Enabled = True
            btn_agregarDependencia.Enabled = True
        End If
        If Not chk_dependencia.Checked Then
            cmb_dependencia.Enabled = False
            btn_agregarDependencia.Enabled = False
        End If
    End Sub

    Private Sub chk_mozo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mozo.CheckedChanged
        If chk_mozo.Checked Then
            cmb_empleado.Enabled = True
        Else
            cmb_empleado.Enabled = False
        End If
    End Sub
End Class