Public Class Asignar_rol

    Dim dbhelper As DBHelper = DBHelper.getDBHelper

    Private Sub Asignar_rol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        cargar_combo(cmbRol, (dbhelper.ConsultaSQL("select * from rol")), "idRol", "descripcion")
    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox _
                              , ByRef tabla As DataTable _
                              , ByVal pk As String _
                              , ByVal descriptor As String)

        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
        combo.SelectedIndex = -1
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "select p.apellido, p.nombre, p.nroDocumento from persona p "
        sql &= " where p.fechaIngreso IS NOT NULL "

        tabla = dbhelper.ConsultaSQL(sql)

        Dim c As Integer = 0

        Me.dgvAsignarRol.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgvAsignarRol.Rows.Add()
            Me.dgvAsignarRol.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(0)
            Me.dgvAsignarRol.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(1)
            Me.dgvAsignarRol.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
        Next
    End Sub

    Private Sub dgvAsignarRol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsignarRol.CellContentClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM persona p WHERE p.nroDocumento = " & Me.dgvAsignarRol.CurrentRow.Cells("cNroDoc").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.txtNroDoc.Text = tabla.Rows(0)("nroDocumento")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sql As String = ""
        Dim sql1 As String
        Dim tabla1 As DataTable

        sql1 = "select rp.* from rolXPersona rp "
        sql1 &= " where rp.nroDocumento =  " & txtNroDoc.Text

        tabla1 = dbhelper.ConsultaSQL(sql1)

        If tabla1.Rows.Count < 1 Then
            sql &= " insert into rolXPersona (idRol, nroDocumento, fechaDesde, fechaHasta) "
            sql &= " values (" & cmbRol.SelectedValue & "," & txtNroDoc.Text & ",'" & dtpDesde.Text & "','" & dtpHasta.Text & "')"
            dbhelper.EjecutarSQL(sql)
            MsgBox("Se grabo correctamente")
            Exit Sub
        Else
            MsgBox("La persona que intenta cargar ya posee un rol")
            Exit Sub
        End If

        Me.cargar_grilla()
    End Sub
End Class