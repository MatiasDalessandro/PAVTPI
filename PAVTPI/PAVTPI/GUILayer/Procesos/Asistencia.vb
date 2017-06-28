Public Class Asistencia

    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub Asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        txtMotivo.Enabled = False
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "select p.apellido, p.nombre, p.nroDocumento from persona p "
        sql &= " where p.fechaIngreso IS NOT NULL "

        tabla = dbhelper.ConsultaSQL(sql)

        Dim c As Integer = 0

        Me.dgvAsist.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgvAsist.Rows.Add()
            Me.dgvAsist.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(0)
            Me.dgvAsist.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(1)
            Me.dgvAsist.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
        Next
    End Sub

    Private Sub dgvAsist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsist.CellContentClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM persona p WHERE p.nroDocumento = " & Me.dgvAsist.CurrentRow.Cells("cNroDoc").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.txtNroDoc.Text = tabla.Rows(0)("nroDocumento")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sql As String = ""
        Dim sql1 As String
        Dim tabla1 As DataTable

        sql1 = "select ea.* from empleadoXAsistencia ea "
        sql1 &= " where ea.nroDocumento = 85412369 "
        sql1 &= " And year(ea.fechaHoraInicio) = year(SYSDATETIME()) "
        sql1 &= " And month(ea.fechaHoraInicio) = MONTH(SYSDATETIME()) "
        sql1 &= " And DAY(ea.fechaHoraInicio) = day(sysdatetime())"

        tabla1 = dbhelper.ConsultaSQL(sql1)

        If tabla1.Rows.Count < 1 Then
            If chkAusente.Checked Then
                sql &= " INSERT INTO empleadoXAsistencia (fechaHoraInicio, fechaHoraFin, ausencia, motivo, nroDocumento) "
                sql &= " values ( '" & dtpDiaLlegada.Value.ToString & "',null," & 1 & ",'" & txtMotivo.Text & "'," & txtNroDoc.Text & ")"
                MsgBox("Se grabo correctamente")
                Exit Sub
            Else
                sql &= " INSERT INTO empleadoXAsistencia (fechaHoraInicio, fechaHoraFin, ausencia, motivo, nroDocumento) "
                sql &= " values ( '" & dtpDiaLlegada.Value.ToString & "',null," & 0 & ",null," & txtNroDoc.Text & ")"
                MsgBox("Se grabo correctamente")
            End If
        Else

        End If
        If (Not chkAusente.Checked) And tabla1.Rows.Count < 1 Then
            sql &= " values ( '" & dtpDiaLlegada.Value.ToString & "',null," & 1 & ",'" & txtMotivo.Text & "'," & txtNroDoc.Text & ")"
            sql &= "update empleadoXAsistencia set fechaHoraFin = '" & dtpDiaSalida.Value.ToString & "' where nroDocumento = " & txtNroDoc.Text & " and year(fechaHoraInicio) = year(SYSDATETIME()) "
            sql &= " and month(fechaHoraInicio) = MONTH(SYSDATETIME()) "
            sql &= " and DAY(fechaHoraInicio) = day(sysdatetime()) "
        End If

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
    End Sub

    Private Sub chkAusente_CheckedChanged(sender As Object, e As EventArgs) Handles chkAusente.CheckedChanged
        If chkAusente.Checked Then
            txtMotivo.Enabled = True
            dtpDiaSalida.Enabled = False
        Else
            txtMotivo.Enabled = False
            dtpDiaSalida.Enabled = True
        End If
    End Sub
End Class