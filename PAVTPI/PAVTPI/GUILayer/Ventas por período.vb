Public Class Ventas_por_período
    Dim dbHelper As DBHelper = DBHelper.getDBHelper
    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click
        Dim fechaMinima As New DateTime(1900, 1, 1)
        Dim fechaMaxima As Date = Date.Now
        Dim datatable As New DataTable
        Dim sql As String = ""
        sql &= "select distinct "
        sql &= " t.nroTicket, t.fechaHora, t.monto, t.nroCuentaCorriente, concat(p.apellido,', ' , p.nombre) as nombreapellido,"
        sql &= " dta.idArticulo, dta.cantidad, a.nombre As nombreA, pa.apellido, pa.nombre"
        sql &= " From detalleTicketArticulo dta, ticket t, ticketXDependencia td, persona p, persona pa, articulo a"
        sql &= " Where t.nroTicket = dta.nroTicket And pa.nroDocumento = t.nroDocMozo And p.nroDocumento = t.nroDocumento And dta.idArticulo = a.idArticuloIntegrante"
        If txt_fechaInicio.MaskFull And txt_fechaFin.MaskFull Then
            Try
                If validar_fechas() = False Then
                    MsgBox("Las fechas ingresadas no son válidas-")
                    Exit Sub
                End If
                Dim fechaInicio As DateTime = CDate(txt_fechaInicio.Text)
                Dim fechaFin As DateTime = CDate(txt_fechaFin.Text)

                If (fechaInicio < fechaMinima Or fechaFin > fechaMaxima) Then
                    MsgBox("Las fechas ingresadas no corresponden a un intervalo válido" + vbLf +
                            "Solo es posible ingresar fechas entre: " + fechaMinima + " y " + fechaMaxima + ".")
                    Exit Sub
                End If

                If fechaInicio > fechaFin Then
                    MsgBox("La fecha de fin de intervalo es anterior a la de inicio.")
                    Exit Sub
                End If
            Catch ex As Exception
            End Try
            sql &= " And t.fechaHora between '" & txt_fechaInicio.Text & "' and  '" & txt_fechaFin.Text & "'"
        Else
            MsgBox("Se buscará sin rangos de fechas, ya que no se especificó una fecha de inicio o fin de intervalo, o ambas")
        End If
        sql &= " Order By nroTicket"
        datatable = dbHelper.ConsultaSQL(sql)
        DataTable1BindingSource.DataSource = datatable
        ReportViewer1.RefreshReport()

    End Sub
    Private Function validar_fechas()
        Dim fecha() As String = Split(txt_fechaInicio.Text, "/")
        Dim fecha2() As String = Split(txt_fechaFin.Text, "/")
        If (CType(fecha(1), System.Int32) > 12) Or (CType(fecha(0), System.Int32) > 31) Then
            Return False
        End If
        If (CType(fecha2(1), System.Int32) > 12) Or (CType(fecha2(0), System.Int32) > 31) Then
            Return False
        End If
        Return True
    End Function
End Class