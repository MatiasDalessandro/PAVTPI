Public Class AbmPersonaAutorizada
    Dim dbhelper As DBHelper = DBHelper.getDBHelper
    Dim estado_Grabacion As condicionGrabacion = condicionGrabacion.insertar

    Enum estadoGrabacion
        aprobado
        rechazado
    End Enum
    Enum condicionGrabacion
        insertar
        modificar
    End Enum
    Private Sub AbmPersonaAutorizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        cargar_combo(cmbTipoDocPA, dbhelper.ConsultaSQL("select * from tipoDocumento"), "idTipoDocumento", "descripcion")
    End Sub
    Private Sub cargar_grilla()
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        Dim sql As String = ""

        sql &= "Select        persona.nombre, persona.apellido, persona.nroDocumento, persona.idTipoDocumento, persona.fechaIngreso, persona.fechaEgreso, "
        sql &= "                 persona.celular, persona.Mail, persona.Domicilio, tipoDocumento.descripcion, tipoDocumento.idTipoDocumento "
        sql &= " From            persona INNER JOIN "
        sql &= " tipoDocumento On persona.idTipoDocumento = tipoDocumento.idTipoDocumento "

        tabla = dbhelper.ConsultaSQL(sql)

        Dim c As Integer = 0

        Me.dgvPersAut.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgvPersAut.Rows.Add()
            Me.dgvPersAut.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(0)
            Me.dgvPersAut.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(1)
            Me.dgvPersAut.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
            Me.dgvPersAut.Rows(c).Cells("cDependencia").Value = tabla.Rows(c)(3)
        Next
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String = ""
        If validarDatos() = estadoGrabacion.aprobado Then
            If estado_Grabacion = condicionGrabacion.insertar Then
                If validarPersona() = estadoGrabacion.aprobado Then
                    insertar()
                Else
                    MsgBox("El numero de documento que intenta cargar ya existe")
                End If
            Else
                modificar()
            End If
        Else
        End If
    End Sub
    Private Sub insertar()
        Dim sql As String = ""
        sql = " INSERT INTO persona (nombre,apellido,nroDocumento,) values ( '" & txtNombrePA.Text & "', '" & txtApellidoPA.Text & "' , " & mskNroDocPA.Text & " , " & cmbTipoDocPA.SelectedValue & " , " & cmbDependencia.SelectedValue & ")"
        dbhelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE persona SET nroDocumento = " & mskNroDocPA.Text
        sql &= " , nombre = '" & txtNombrePA.Text & "'"
        sql &= " , apellido = '" & txtApellidoPA.Text & "'"
        sql &= " , idTipoDocumento = '" & cmbTipoDocPA.SelectedValue & "'"
        sql &= " , Domicilio = " & cmbDependencia.SelectedValue
        sql &= " WHERE nroDocumento = " & mskNroDocPA.Text

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
        MsgBox("Se Modifico correctamente")
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

        sql &= " SELECT * FROM persona WHERE nroDocumento = " & Me.mskNroDocPA.Text

        tabla = dbhelper.ConsultaSQL(sql)

        If tabla.Rows.Count = 0 Then
            Return estadoGrabacion.aprobado
        Else
            Return estadoGrabacion.rechazado
        End If
    End Function
    'Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
    '    txtApellidoPA.Enabled = False
    '    txtNombrePA.Enabled = False
    '    mskNroDocPA.Enabled = True
    '    cmbTipoDocPA.Enabled = False
    '    mskFechaIngreso.Enabled = False
    '    mskFechaEgreso.Enabled = False
    '    txtDomicilio.Enabled = False
    '    txtEmail.Enabled = False
    '    txtCelular.Enabled = False
    'End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txtApellidoPA.Text = ""
        txtApellidoPA.Enabled = True
        txtNombrePA.Text = ""
        txtNombrePA.Enabled = True
        mskNroDocPA.Text = ""
        mskNroDocPA.Enabled = True
        cmbTipoDocPA.Enabled = True
        cmbDependencia.Enabled = True
        btn_guardar.Enabled = True
    End Sub
    Private Function btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM persona WHERE nroDocumento = " & mskNroDocPA.Text
        tabla = dbhelper.ConsultaSQL(sql)
        Me.dgvPersAut.Rows.Clear()

        Dim c As Integer = 0

        For c = 0 To tabla.Rows.Count - 1
            Me.dgvPersAut.Rows.Add()
            Me.dgvPersAut.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(0)
            Me.dgvPersAut.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(1)
            Me.dgvPersAut.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
            Me.dgvPersAut.Rows(c).Cells("cDependencia").Value = tabla.Rows(c)(3)
        Next
    End Function

    Private Sub dgvPersAut_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersAut.CellContentClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM persona WHERE nroDocumento = " & Me.dgvPersAut.CurrentRow.Cells("cNroDoc").Value

        tabla = dbhelper.ConsultaSQL(sql)
        Me.txtApellidoPA.Text = tabla.Rows(0)("apellido")
        Me.txtNombrePA.Text = tabla.Rows(0)("nombre")
        Me.mskNroDocPA.Text = tabla.Rows(0)("nroDocumento")
        Me.cmbDependencia.SelectedValue = tabla.Rows(0)("")

        Me.txtApellidoPA.Enabled = True
        Me.txtNombrePA.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        Me.mskNroDocPA.Enabled = False
        estado_Grabacion = condicionGrabacion.modificar
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""

        If validarDatos() = estadoGrabacion.aprobado Then
            If validarPersona() = estadoGrabacion.rechazado Then
                sql = " DELETE FROM persona WHERE nroDocumento = " & mskNroDocPA.Text
                MsgBox("Se elimino correctamente la persona")
            Else
                MsgBox("Cargue correctamente la persona a eliminar")
            End If
        End If

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
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
End Class