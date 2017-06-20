Public Class PagoXCuentaCorriente

    Dim dbhelper As DBHelper = DBHelper.getDBHelper()


    Private Sub PagoXCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT dependencia.nombre,dependencia.nroCuentaCorriente,dependencia.saldo,dependencia.estado FROM dependencia"

        tabla = dbhelper.ConsultaSQL(sql)
        Dim c As Integer = 0
        Me.dgv_dependencia.Rows.Clear()

        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_dependencia.Rows.Add()
            Me.dgv_dependencia.Rows(c).Cells("c_nombreDependencia").Value = tabla.Rows(c)(0)
            Me.dgv_dependencia.Rows(c).Cells("c_nroCuentaCorriente").Value = tabla.Rows(c)(1)
            Me.dgv_dependencia.Rows(c).Cells("c_saldo").Value = tabla.Rows(c)(2)
            If tabla.Rows(c)(3) = "False" Then
                Me.dgv_dependencia.Rows(c).Cells("c_estado").Value = "Deshabilitada"
            Else
                Me.dgv_dependencia.Rows(c).Cells("c_estado").Value = "Habilitada"
            End If

        Next
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim tabla As New DataTable
        Dim sql As String = ""

        If Me.mtb_nroCuentacorriente.Text = "" Then
            MsgBox("Numero de Cuenta Corriente no Ingresado.")

        Else
            sql &= "SELECT dependencia.nombre,dependencia.nroCuentaCorriente,dependencia.saldo,dependencia.estado FROM dependencia"
            sql &= " WHERE dependencia.nroCuentaCorriente = " & Me.mtb_nroCuentacorriente.Text

            tabla = dbhelper.ConsultaSQL(sql)
            Me.dgv_dependencia.Rows.Clear()

            For c = 0 To tabla.Rows.Count() - 1
                Me.dgv_dependencia.Rows.Add()
                Me.dgv_dependencia.Rows(c).Cells("c_nombreDependencia").Value = tabla.Rows(c)(0)
                Me.dgv_dependencia.Rows(c).Cells("c_nroCuentaCorriente").Value = tabla.Rows(c)(1)
                Me.dgv_dependencia.Rows(c).Cells("c_saldo").Value = tabla.Rows(c)(2)
                Me.dgv_dependencia.Rows(c).Cells("c_estado").Value = tabla.Rows(c)(3)
            Next

        End If


    End Sub

    Private Sub dgv_dependencia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dependencia.CellDoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tablaPagos As New DataTable

        sql = "SELECT * FROM dependencia WHERE dependencia.nroCuentaCorriente = " & Me.dgv_dependencia.CurrentRow.Cells("c_NroCuentaCorriente").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.txt_cuentaCorriente.Text = tabla.Rows(0)(0)
        Me.txt_nombre.Text = tabla.Rows(0)(1)
        Me.txt_saldo.Text = tabla.Rows(0)(3)

        If tabla.Rows(0)(4) = "False" Then
            Me.txt_estado.Text = "Deshabilitada"
        Else
            Me.txt_estado.Text = "Habilitada"
        End If


        If Me.txt_saldo.Text < 1 Then
            Me.btn_registrarPago.Enabled = False
        Else
            Me.btn_registrarPago.Enabled = True
        End If

        Me.cargar_grillaPagos()


    End Sub


    Private Sub dgv_registroDePagos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_registroDePagos.CellDoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT * FROM pagoXCuentaCorriente WHERE pagoXCuentaCorriente.nroCuentaCorriente = " & Me.dgv_registroDePagos.CurrentRow.Cells("c_nroCuentaCorrientePago").Value
        sql &= " AND pagoXCuentaCorriente.fechaHora = '" & Me.dgv_registroDePagos.CurrentRow.Cells("c_fechaHoraPago").Value & "'"

        tabla = dbhelper.ConsultaSQL(sql)

        Me.txt_fechaPago.Text = tabla.Rows(0)(1)
        Me.txt_montoPago.Text = tabla.Rows(0)(2)

    End Sub

    Private Sub cargar_grillaPagos()
        Dim sql As String = ""
        Dim tablaPagos As New DataTable

        sql = "SELECT * FROM pagoXCuentaCorriente WHERE pagoXCuentaCorriente.nroCuentaCorriente = " & Me.txt_cuentaCorriente.Text & " ORDER BY fechaHora DESC"
        tablaPagos = dbhelper.ConsultaSQL(sql)
        Me.dgv_registroDePagos.Rows.Clear()

        Me.txt_fechaPago.Text = ""
        Me.txt_montoPago.Text = ""

        Dim c As Integer = 0
        For c = 0 To tablaPagos.Rows.Count() - 1
            Me.dgv_registroDePagos.Rows.Add()
            Me.dgv_registroDePagos.Rows(c).Cells("c_nroCuentaCorrientePago").Value = tablaPagos.Rows(c)(0)
            Me.dgv_registroDePagos.Rows(c).Cells("c_fechaHoraPago").Value = tablaPagos.Rows(c)(1)
            Me.dgv_registroDePagos.Rows(c).Cells("c_montoPago").Value = tablaPagos.Rows(c)(2)
        Next

    End Sub

    Private Sub refrescar_saldo()
        Dim tabla As New DataTable

        tabla = dbhelper.ConsultaSQL("SELECT dependencia.saldo from dependencia WHERE dependencia.nroCuentaCorriente = " & Me.txt_cuentaCorriente.Text)

        Me.txt_saldo.Text = tabla.Rows(0)(0)

        If Me.txt_saldo.Text < 1 Then
            Me.btn_registrarPago.Enabled = False
        End If
    End Sub

    Private Sub btn_registrarPago_Click_1(sender As Object, e As EventArgs) Handles btn_registrarPago.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        Dim restaSaldo As Double = 0
        Dim saldo1 As Double = Me.txt_saldo.Text
        Dim saldo2 As Double = Me.txt_montoAcobrar.Text
        Dim fechaHora As DateTime = DateTime.Now.ToString

        If saldo2 < 1 Then
            MsgBox("El monto a cobrar no puede ser menor a 1")
        Else
            If saldo2 > saldo1 Then
                MsgBox("El monto no puede ser mayor al saldo actual")
            Else
                sql = "INSERT INTO pagoXCuentaCorriente (nroCuentaCorriente,fechaHora,monto) VALUES ( " & Me.txt_cuentaCorriente.Text & ",'" & DateTime.Now & "'," & Me.txt_montoAcobrar.Text & ")"
                If dbhelper.EjecutarSQL(sql) = 1 Then
                    MsgBox("Se realizo correctamente el Pago.")


                    restaSaldo = saldo1 - saldo2
                    dbhelper.EjecutarSQL("UPDATE dependencia SET dependencia.saldo = " & restaSaldo & "WHERE dependencia.nroCuentaCorriente = " & Me.txt_cuentaCorriente.Text)

                Else
                    MsgBox("El Pago no pudo realizarse")
                End If
            End If

        End If

        cargar_grillaPagos()
        refrescar_saldo()
        Me.cargar_grilla()
        Me.txt_montoAcobrar.Text = ""
    End Sub
End Class