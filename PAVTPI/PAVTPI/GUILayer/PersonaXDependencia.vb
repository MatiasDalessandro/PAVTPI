Public Class PersonaXDependencia
    Dim dbHelper As DBHelper = DBHelper.getDBHelper
    Dim estado_Grabacion As condicionGrabacion = condicionGrabacion.insertar
    Enum estadoGrabacion
        aprobado
        rechazado
    End Enum
    Enum condicionGrabacion
        insertar
        modificar
    End Enum

    Private Sub PersonaXDependencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

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
            MsgBox("No se encontro ninguna persona con DNI: " & txt_documento.Text)
            Exit Sub
        End If
        txt_persona_dni.Text = tabla.Rows(0)("nroDocumento")
        txt_persona_apellido.Text = tabla.Rows(0)("apellido")
        txt_persona_nombre.Text = tabla.Rows(0)("nombre")

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String = "INSERT INTO dependenciaXPersona (nroCuentaCorriente,nroDocumento) VALUES ("
        If validarDatos() = estadoGrabacion.aprobado Then
            If estado_Grabacion = condicionGrabacion.insertar Then
                If validarPersona() = estadoGrabacion.aprobado Then
                    insertar()
                Else
                    MsgBox("El numero de documento que intenta cargar ya existe")
                End If
            End If
        Else
        End If
    End Sub

    Private Sub cargarGrilla()
        Dim sql As String = "Select persona.nombre, persona.apellido, persona.nroDocumento, dependenciaXPersona.nroCuentaCorriente 
        From persona INNER Join dependenciaXPersona On persona.nroDocumento = dependenciaXPersona.nroDocumento"
        Dim tabla As New DataTable
        tabla = dbHelper.ConsultaSQL(sql)
        dgv_personaDependencia.Rows.Clear()
        Dim c As Integer
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_personaDependencia.Rows.Add()
            Me.dgv_personaDependencia.Rows(c).Cells("nombre").Value = tabla.Rows(c)(0)
            Me.dgv_personaDependencia.Rows(c).Cells("apellido").Value = tabla.Rows(c)(1)
            Me.dgv_personaDependencia.Rows(c).Cells("documento").Value = tabla.Rows(c)(2)
            Me.dgv_personaDependencia.Rows(c).Cells("nroCuenta").Value = tabla.Rows(c)(3)
        Next
    End Sub

    Private Sub dgv_personaDependencia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_personaDependencia.CellContentClick

        Dim sql As String = "SELECT * from dependenciaXPersona where nroCuentaCorriente=" & dgv_personaDependencia.CurrentRow.Cells("nroCuenta").Value
        Dim tabla As New DataTable

        tabla = dbHelper.ConsultaSQL(sql)

        Me.txt_dependencia_nro.Text = tabla.Rows(0)("nroCuentaCorriente")
        Me.txt_persona_dni.Text = tabla.Rows(0)("nroDocumento")

        estado_Grabacion = condicionGrabacion.modificar
    End Sub
    'no puedo descifrar que es lo que anda mal aca cuando intento borrar un registro
    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_Borrar.Click
        If MessageBox.Show("Esta seguro de borrar: " + Chr(13) +
                           "Dependencia: " & Me.dgv_personaDependencia.CurrentRow.Cells(3).Value.ToString.Trim + Chr(10) +
                           "Nombre: " & Me.dgv_personaDependencia.CurrentRow.Cells(0).Value.ToString.Trim + Chr(10) +
                           "Apellido: " & Me.dgv_personaDependencia.CurrentRow.Cells(1).Value.ToString.Trim _
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

    Private Function validarDatos() As estadoGrabacion
        For Each obj As Control In Me.Controls
            If obj.GetType.Name = "TextBox" Then
                If obj.Text = "" Then
                    MsgBox("El " & obj.Name & " no está ingresado")
                    obj.Focus()
                    Return estadoGrabacion.rechazado
                End If
            End If
        Next
    End Function
    Private Function validarPersona() As estadoGrabacion
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM persona WHERE nroDocumento = " & Me.txt_documento.Text

        tabla = dbHelper.ConsultaSQL(sql)

        If tabla.Rows.Count = 0 Then
            Return estadoGrabacion.aprobado
        Else
            Return estadoGrabacion.rechazado
        End If
    End Function
    Private Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO dependenciaXPersona (nroCuentaCorriente,nroDocumento) VALUES ( " & txt_dependencia_nro.Text & "," & txt_documento.Text & ")"
        dbHelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente")
        Me.cargarGrilla()
    End Sub
End Class
