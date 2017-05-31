Public Class Venta
    Dim dbHelper As DBHelper = DBHelper.getDBHelper
    Private Sub PagoTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grillas_simples(Me.dgv_articulo, dbHelper.ConsultaSQL("SELECT * FROM articulo"))
        cargar_grillas_simples(Me.dgv_combo, dbHelper.ConsultaSQL("select * from comboXArticulo"))
        cargar_combo(cmb_dependencia, (dbHelper.ConsultaSQL("select * from dependencia")), "nroCuentaCorriente", "descripcion")

        Dim sql As String = "select * from rolXPersona where idRol = (select idRol from rol where descripcion= 'Mozo')"
        Dim tabla As DataTable
        tabla = dbHelper.ConsultaSQL(sql)

        cargar_combo(cmb_empleado, (dbHelper.ConsultaSQL(sql)), "nroDocumento", "")

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
        cargar_grillas_simples(dgv_combo, tabla)

    End Sub
    Private Sub cargar_grillas_simples(ByRef dgv As DataGridView, ByRef tabla As DataTable)
        dgv.Rows.Clear()
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
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Dim total As Double = txt_total.Text
        total += -dgv_detalle.CurrentRow.Cells(2).Value
        dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)
        txt_total.Text = total
    End Sub
    Private Sub calcular_total()
        Dim total As Double = 0
        For Each row As DataGridViewRow In dgv_detalle.Rows
            total += row.Cells(2).Value
        Next
        txt_total.Text = total
    End Sub

    Private Sub btn_mostrarTodosArt_Click(sender As Object, e As EventArgs) Handles btn_mostrarTodosArt.Click
        cargar_grillas_simples(Me.dgv_articulo, dbHelper.ConsultaSQL("SELECT * FROM articulo"))
    End Sub
End Class