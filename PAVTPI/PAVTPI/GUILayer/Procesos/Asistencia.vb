Public Class Asistencia

    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub Asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        txtMotivo.Enabled = False
        MsgBox(System.DateTime.Now.ToString)
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
        sql &= " INSERT INTO empleadoXAsistencia (fechaHoraInicio, fechaHoraFin, ausencia, motivo, nroDocumento) "
        If chkAusente.Checked Then
            sql &= " values ( " & dtpDiaLlegada.Text & System.DateTime.Now.ToString & "," & dtpDiaSalida.Text & "," & 1 & ",'" & txtMotivo.Text & "'," & txtNroDoc.Text & ")"
        Else
            sql &= " values ( " & dtpDiaLlegada.Text & "," & dtpDiaSalida.Text & "," & 0 & ",  null  ," & txtNroDoc.Text & ")"
        End If

        dbhelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub

    Private Sub chkAusente_CheckedChanged(sender As Object, e As EventArgs) Handles chkAusente.CheckedChanged
        If chkAusente.Checked Then
            txtMotivo.Enabled = True
        Else
            txtMotivo.Enabled = False
        End If
    End Sub
End Class