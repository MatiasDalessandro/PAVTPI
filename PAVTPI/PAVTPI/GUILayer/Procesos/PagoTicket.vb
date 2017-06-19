Public Class Venta
    Dim dbHelper As DBHelper = DBHelper.getDBHelper
    Private Sub PagoTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grillas_simples(dgv_articulo, dbHelper.ConsultaSQL("SELECT * FROM articulo"))
        cargar_grillas_simples(dgv_combo, dbHelper.ConsultaSQL("SELECT DISTINCT idCombo,nombreCombo,precio FROM comboXArticulo"))
        cargar_combo(cmb_dependencia, (dbHelper.ConsultaSQL("select * from dependencia")), "nroCuentaCorriente", "descripcion")
        Dim sql As String = ""
        sql &= "select P.apellido, P.nombre,P.nroDocumento from persona P "
        sql &= "inner Join rolXPersona RP on RP.nroDocumento=P.nroDocumento "
        sql &= "where RP.idRol = 1"
        Dim tabla As DataTable = dbHelper.ConsultaSQL(sql)
        Dim tabla2 As New DataTable
        Dim column1 As New DataColumn("nroDocumento", GetType(System.Int32))
        Dim column2 As New DataColumn("nombre", GetType(System.String))
        tabla2.Columns.Add(column1)
        tabla2.Columns.Add(column2)
        tabla2.PrimaryKey = New DataColumn() {column1}
        Dim row As DataRow
        For i = 0 To tabla.Rows.Count - 1
            row = tabla2.NewRow()
            row("nroDocumento") = tabla.Rows(i)("nroDocumento")
            row("nombre") = tabla.Rows(i)("apellido") & ", " & tabla.Rows(i)("nombre")
            tabla2.Rows.Add(row)
        Next
        cargar_combo(cmb_empleado, tabla2, "nroDocumento", "nombre")
        cmb_empleado.SelectedIndex = -1
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
        Dim estado As Boolean = True
        If Not dgv_detalle.Rows.Count = 0 Then
            For i = 0 To dgv_detalle.Rows.Count - 1
                If (dgv_detalle.Rows(i).Cells(4).Value = dgv_articulo.CurrentRow.Cells(0).Value) Then
                    dgv_detalle.Rows(i).Cells(3).Value += 1
                    estado = False
                    Exit For
                End If
            Next
        End If
        If estado Then
            dgv_detalle.Rows.Add(New String() {
                            dgv_articulo(0, dgv_articulo.CurrentRow.Index).Value.ToString(),
                            dgv_articulo(1, dgv_articulo.CurrentRow.Index).Value.ToString(),
                            dgv_articulo(2, dgv_articulo.CurrentRow.Index).Value.ToString(),
                            1,
                            dgv_articulo(0, dgv_articulo.CurrentRow.Index).Value.ToString, 0
                      })
        End If
        calcular_total()
        btn_quitar.Enabled = True
        btn_qf.Enabled = True
    End Sub
    Private Sub calcular_total()
        Dim total As Double = 0
        For Each row As DataGridViewRow In dgv_detalle.Rows
            total += CType(row.Cells(2).Value, Double) * CType(row.Cells(3).Value, Double)
        Next
        txt_total.Text = total
    End Sub

    Private Sub btn_mostrarTodosArt_Click(sender As Object, e As EventArgs) Handles btn_mostrarTodosArt.Click
        cargar_grillas_simples(Me.dgv_articulo, dbHelper.ConsultaSQL("SELECT * FROM articulo"))
    End Sub

    Private Sub btn_agregarDependencia_Click(sender As Object, e As EventArgs) Handles btn_agregarDependencia.Click
        cmd_cancelar.Show()
    End Sub
    Private Sub btn_agregarCombo_Click(sender As Object, e As EventArgs) Handles btn_agregarCombo.Click
        Dim estado As Boolean = True
        If Not dgv_detalle.Rows.Count = 0 Then
            For i = 0 To dgv_detalle.Rows.Count - 1
                If (dgv_detalle.Rows(i).Cells(5).Value = dgv_combo.CurrentRow.Cells(0).Value) Then
                    dgv_detalle.Rows(i).Cells(3).Value += 1
                    estado = False
                    Exit For
                End If
            Next
        End If
        If estado Then
            dgv_detalle.Rows.Add(New String() {
                                    dgv_combo(0, dgv_combo.CurrentRow.Index).Value.ToString(),
                                    dgv_combo(1, dgv_combo.CurrentRow.Index).Value.ToString(),
                                    dgv_combo(2, dgv_combo.CurrentRow.Index).Value.ToString(),
                                    1, 0,
                                    dgv_combo(0, dgv_combo.CurrentRow.Index).Value.ToString
                               })
        End If
        calcular_total()
        btn_quitar.Enabled = True
        btn_qf.Enabled = True
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
            cmb_persona.Enabled = True

        End If
        If Not chk_dependencia.Checked Then
            cmb_dependencia.Enabled = False
            btn_agregarDependencia.Enabled = False
            cmb_persona.Enabled = False
        End If
    End Sub

    Private Sub chk_mozo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mozo.CheckedChanged
        If chk_mozo.Checked Then
            cmb_empleado.Enabled = True
        End If
    End Sub
    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dgv_detalle.CurrentRow.Cells(3).Value = 1 Then
            dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)
            calcular_total()
        Else
            dgv_detalle.CurrentRow.Cells(3).Value += -1
            calcular_total()
        End If
        If dgv_detalle.Rows.Count = 0 Then
            btn_quitar.Enabled = False
            btn_qf.Enabled = False
        End If
    End Sub
    Private Sub btn_qf_Click(sender As Object, e As EventArgs) Handles btn_qf.Click
        dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)
        calcular_total()
        If dgv_detalle.Rows.Count = 0 Then
            btn_quitar.Enabled = False
            btn_qf.Enabled = False
        End If
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim estado As Boolean = False
        If dgv_detalle.Rows.Count = 0 Then
            MsgBox("No se puede guardar venta sin articulos o combos.")
            Exit Sub
        Else
            Dim transaccion As String = ""
            Dim compraCtaCte As String = ""
            Dim ctaCteMozo As String = ""
            Dim compraComun As String = ""
            If chk_dependencia.Checked And cmb_dependencia.SelectedIndex <> -1 And chk_mozo.Checked <> True Then
                If cmb_persona.SelectedIndex = -1 Then
                    MsgBox("Debe seleccionar una persona autorizada.")
                    Exit Sub
                End If
                Dim tablaid As DataTable = cmb_dependencia.DataSource
                Dim id As Integer = tablaid(cmb_dependencia.SelectedIndex)(0)
                Dim table As DataTable = cmb_persona.DataSource
                Dim nroDoc As Integer = table(cmb_persona.SelectedIndex)(0)
                If tablaid(cmb_dependencia.SelectedIndex)(4) = 0 Then
                    MsgBox("La dependencia está deshabilitada")
                    Exit Sub
                End If
                compraCtaCte &= "INSERT INTO ticket (fechaHora, monto, nroDocumento, nroCuentaCorriente) VALUES ('" & System.DateTime.Now.ToString() & "'," & CType(txt_total.Text, System.Double) & "," & nroDoc & "," & id & ")"
                dbHelper.EjecutarSQL(compraCtaCte)
                estado = True
            End If
            If chk_mozo.Checked And cmb_empleado.SelectedIndex <> -1 And chk_dependencia.Checked And cmb_dependencia.SelectedIndex <> -1 Then
                Dim table As DataTable = cmb_persona.DataSource
                Dim nroDoc As Integer = table(cmb_persona.SelectedIndex)(0)
                Dim table2 As DataTable = cmb_empleado.DataSource
                Dim nroDocMozo As Integer = table2(cmb_empleado.SelectedIndex)(0)
                Dim tablaid As DataTable = cmb_dependencia.DataSource
                Dim id As Integer = tablaid(cmb_dependencia.SelectedIndex)(0)
                If tablaid(cmb_dependencia.SelectedIndex)(4) = 0 Then
                    MsgBox("La dependencia está deshabilitada.")
                    Exit Sub
                End If
                ctaCteMozo &= "INSERT INTO ticket (fechaHora, monto, nroDocumento, nroCuentaCorriente,nroDocMozo) VALUES ('" & System.DateTime.Now.ToString() & "'," & CType(txt_total.Text, System.Double) & "," & nroDoc & "," & id & ", " & nroDocMozo & ")"
                dbHelper.EjecutarSQL(ctaCteMozo)
                estado = True
            End If
            If chk_mozo.Checked = False And chk_dependencia.Checked = False Then
                compraComun &= "INSERT INTO ticket (fechaHora,monto) VALUES ('" & System.DateTime.Now.ToString() & "', " & CType(txt_total.Text, System.Double) & ")"
                dbHelper.EjecutarSQL(compraComun)
            End If
            Dim tabla As DataTable = dbHelper.ConsultaSQL("SELECT MAX(t.nroTicket) from ticket t")
            Dim idTicket As Integer = tabla(0)(0)

            Dim detalleArt As String = ""
            Dim detalleCom As String = ""
            For Each row As DataGridViewRow In dgv_detalle.Rows
                If row.Cells(4).Value <> 0 Then
                    If detalleArt = "" Then
                        detalleArt &= "insert into detalleTicketArticulo (nroTicket,idArticulo,cantidad) VALUES(" & idTicket & "," & row.Cells(0).Value.ToString
                        detalleArt &= ", " & row.Cells(3).Value.ToString & ")"
                    Else
                        detalleArt &= vbLf
                        detalleArt &= "insert into detalleTicketArticulo (nroTicket,idArticulo,cantidad) VALUES(" & idTicket & "," & row.Cells(0).Value.ToString
                        detalleArt &= ", " & row.Cells(3).Value.ToString & ")"
                    End If
                End If
                If row.Cells(5).Value <> 0 Then
                    Dim tabla2 As DataTable = dbHelper.ConsultaSQL("select idArticuloIntegrante from comboXArticulo where idCombo= " & row.Cells(5).Value)
                    For Each row2 In tabla2.Rows
                        If detalleCom = "" Then
                            detalleCom &= "insert into detalleTicketCombo (nroTicket,idCombo,idArticuloIntegrante,cantidad) VALUES(" & idTicket & "," & row.Cells(5).Value
                            detalleCom &= ", " & row2("idArticuloIntegrante") & ", " & row.Cells(3).Value & ")"
                        Else
                            detalleCom &= vbLf
                            detalleCom &= "insert into detalleTicketCombo (nroTicket,idCombo,idArticuloIntegrante,cantidad) VALUES(" & idTicket & "," & row.Cells(5).Value
                            detalleCom &= ", " & row2("idArticuloIntegrante") & ", " & row.Cells(3).Value & ")"
                        End If
                    Next

                End If
            Next

            transaccion &= detalleArt
            transaccion &= detalleCom

            If estado = True Then
                Dim tablaid As DataTable = cmb_dependencia.DataSource
                Dim id As Integer = tablaid(cmb_dependencia.SelectedIndex)(0)
                transaccion &= vbLf
                transaccion &= "insert into ticketXDependencia (nroCuentaCorriente,nroTicket) VALUES (" & id & ", " & idTicket & ")"
            End If
            dbHelper.EjecutarSQL(transaccion)
            MsgBox("Se guardo correctamente.")
            dgv_detalle.Rows.Clear()
            cmb_persona.SelectedIndex = -1
            cmb_dependencia.SelectedIndex = -1
            cmb_empleado.SelectedIndex = -1


        End If
    End Sub

    Private Sub cmb_dependencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dependencia.SelectedIndexChanged
        Dim sql As String = "SELECT p.apellido, p.nombre, p.nroDocumento FROM persona p"
        sql &= " inner join dependenciaXPersona dp on dp.nroDocumento = p.nroDocumento"
        sql &= " where nroCuentaCorriente = " & cmb_dependencia.SelectedIndex + 1
        Dim tabla As DataTable = dbHelper.ConsultaSQL(sql)

        Dim tabla2 As New DataTable
        Dim column1 As New DataColumn("nroDocumento", GetType(System.Int32))
        Dim column2 As New DataColumn("nombre", GetType(System.String))
        tabla2.Columns.Add(column1)
        tabla2.Columns.Add(column2)
        tabla2.PrimaryKey = New DataColumn() {column1}
        Dim row As DataRow
        For i = 0 To tabla.Rows.Count - 1
            row = tabla2.NewRow
            row("nroDocumento") = tabla.Rows(i)("nroDocumento")
            row("nombre") = tabla.Rows(i)("apellido") & ", " & tabla.Rows(i)("nombre")
            tabla2.Rows.Add(row)
        Next
        cargar_combo(cmb_persona, tabla2, "nroDocumento", "nombre")
    End Sub

End Class