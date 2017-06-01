Public Class PersonaXDependencia
    Dim dbHelper As DBHelper = DBHelper.getDBHelper
    Private Sub btn_persona_empleado_Click(sender As Object, e As EventArgs) Handles btn_persona_empleado.Click
        AbmPersonaAutorizada.Show()
    End Sub

    Private Sub btn_dependencia_Click(sender As Object, e As EventArgs) Handles btn_dependencia.Click
        AbmDependencia.Show()
    End Sub
    Private Sub btn_buscarDependencia_Click(sender As Object, e As EventArgs) Handles btn_buscarDependencia.Click
        Dim sql As String = "SELECT nombre,descripcion,nroCuentaCorriente FROM dependencia WHERE nroCuentaCorriente = " & txt_nroDependencia.Text
        Dim tabla As New DataTable
        tabla = dbHelper.ConsultaSQL(sql)
        If tabla.Rows.Count = -1 Then
            MsgBox("No se encontro Cuenta con número " & txt_nroDependencia.Text)
            Exit Sub
        End If
        txt_dependencia_nro.Text = tabla.Rows(0)("nroCuentaCorriente")
        txt_dependencia_nombre.Text = tabla.Rows(0)("nombre")
        txt_dependencia_descripcion.Text = tabla.Rows(0)("descripcion")
    End Sub

    Private Sub btn_buscarPersona_Click(sender As Object, e As EventArgs) Handles btn_buscarPersona.Click
        Dim sql As String = "SELECT nroDocumento,nombre,apellido FROM persona where nroDocumento = " & txt_documento.Text
        Dim tabla As New DataTable
        tabla = dbHelper.ConsultaSQL(sql)
        If tabla.Rows.Count = -1 Then
            MsgBox("No se encontor ninguna persona con DNI: " & txt_documento.Text)
            Exit Sub
        End If
        txt_persona_dni = tabla.Rows(0)("nroDocumento")
        txt_persona_apellido = tabla.Rows(0)("apellido")
        txt_persona_nombre = tabla.Rows(0)("nombre")

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String = "INSERT INTO dependenciaXPersona (nroCuentaCorriente,nroDocumento) VALUES ("
        sql &= txt_dependencia_nro.Text & "," & txt_persona_dni.Text & ")"
        dbHelper.EjecutarSQL(sql)
    End Sub
    Private Sub cargarGrilla()
        Dim sql As String = "Select persona.nombre, persona.apellido, persona.nroDocumento, dependenciaXPersona.nroCuentaCorriente 
        From persona INNER Join dependenciaXPersona On persona.nroDocumento = dependenciaXPersona.nroDocumento"
        Dim tabla As New DataTable
        tabla = dbHelper.ConsultaSQL(sql)
        dgv_personaDependencia.Rows.Clear()
        Dim c As Integer
        For c = 0 To tabla.Rows.Count - 1
            dgv_personaDependencia.Rows.Add()
            dgv_personaDependencia.Rows(c).Cells(0) = tabla.Rows(c)("nroCuentaCorriente")
            dgv_personaDependencia.Rows(c).Cells(1) = tabla.Rows(c)("apellido")
            dgv_personaDependencia.Rows(c).Cells(2) = tabla.Rows(c)("nombre")
            dgv_personaDependencia.Rows(c).Cells(3) = tabla.Rows(c)("nroDocumento")
        Next
    End Sub

    Private Sub PersonaXDependencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub dgv_personaDependencia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_personaDependencia.CellContentClick
        Dim sql As String = "SELECT nombre,descripcion from dependencia where nroCuentaCorriente=" & dgv_personaDependencia.CurrentRow.Cells(0).Value
        Dim tabla As New DataTable
        tabla = dbHelper.ConsultaSQL(sql)
        txt_dependencia_nro.Text = dgv_personaDependencia.CurrentRow.Cells(0).Value
        txt_dependencia_nombre.Text = tabla.Rows(0)("nombre")
        txt_dependencia_descripcion.Text = tabla.Rows(0)("descripcion")
        txt_nroDependencia.Text = txt_dependencia_nro.Text
        txt_persona_apellido.Text = dgv_personaDependencia.CurrentRow.Cells(1).Value
        txt_persona_nombre.Text = dgv_personaDependencia.CurrentRow.Cells(2).Value
        txt_persona_dni = dgv_personaDependencia.CurrentRow.Cells(3).Value
        txt_documento.Text = txt_persona_dni.Text
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_Borrar.Click
        If MessageBox.Show("Esta seguro de borrar: " + Chr(13) +
                           "Dependencia: " & Me.dgv_personaDependencia.CurrentRow.Cells(0).Value.ToString.Trim + Chr(10) +
                           "Nombre: " & Me.dgv_personaDependencia.CurrentRow.Cells(1).Value.ToString.Trim + Chr(10) +
                           "Apellido: " & Me.dgv_personaDependencia.CurrentRow.Cells(2).Value.ToString.Trim _
                           , "Importante" _
                           , MessageBoxButtons.YesNo _
                           , MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim sql As String = "DELETE FROM dependenciaXPersona where nroCuentaCorriente = " & txt_dependencia_nro.Text
        sql &= " AND nroDocumento = " & txt_documento.Text
        dbHelper.EjecutarSQL(sql)
        cargarGrilla()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class