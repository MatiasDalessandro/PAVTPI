Public Class Ventas_por_período
    Dim dbHelper As DBHelper = DBHelper.getDBHelper
    Private Sub txt_buscar_Click(sender As Object, e As EventArgs) Handles txt_buscar.Click
        Dim datatable As New DataTable
        Dim sql As String = ""
        sql &= "select distinct "
        sql &= " t.nroTicket, t.fechaHora, t.monto, t.nroCuentaCorriente, concat(p.apellido,', ' , p.nombre) as nombreapellido,"
        sql &= " dta.idArticulo, dta.cantidad, a.nombre As nombreA, pa.apellido, pa.nombre"
        sql &= " From detalleTicketArticulo dta, ticket t, ticketXDependencia td, persona p, persona pa, articulo a"
        sql &= " Where t.nroTicket = dta.nroTicket And pa.nroDocumento = t.nroDocMozo And p.nroDocumento = t.nroDocumento And dta.idArticulo = a.idArticuloIntegrante"
        If txt_fechaInicio.MaskFull And txt_fechaFin.MaskFull Then
            sql &= " And t.fechaHora between '" & txt_fechaInicio.Text & "' and  '" & txt_fechaFin.Text & "'"
        End If
        sql &= " Order By nroTicket"
        datatable = dbHelper.ConsultaSQL(sql)
        DataTable1BindingSource.DataSource = datatable
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub Ventas_por_período_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class