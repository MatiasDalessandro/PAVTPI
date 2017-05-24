Public Class AbmPersona

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

    Private Sub AbmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        cargar_combo(cmbTipoDoc, (dbhelper.ConsultaSQL("select * from tipoDocumento")), "idTipoDocumento", "descripcion")
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "Select        persona.nombre, persona.apellido, persona.nroDocumento, persona.idTipoDocumento, persona.fechaIngreso, persona.fechaEgreso, "
        sql &= "                 persona.celular, persona.Mail, persona.Domicilio, tipoDocumento.descripcion, tipoDocumento.idTipoDocumento "
        sql &= " From            persona INNER JOIN "
        sql &= " tipoDocumento On persona.idTipoDocumento = tipoDocumento.idTipoDocumento "

        tabla = dbhelper.ConsultaSQL(sql)

        Dim c As Integer = 0

        Me.dgvEmpleado.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgvEmpleado.Rows.Add()
            Me.dgvEmpleado.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(0)
            Me.dgvEmpleado.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(1)
            Me.dgvEmpleado.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
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
        sql = " INSERT INTO persona (nombre,apellido,nroDocumento,idTipoDocumento,fechaIngreso,fechaEgreso, celular,Mail,Domicilio) values ( '" & txtNombre.Text & "', '" & txtApellido.Text & "' , " & mskNroDoc.Text & " , " & cmbTipoDoc.SelectedValue & " , '" & dtpFechaIngreso.Value & "' ,   null   , " & txtCelular.Text & " , '" & txtEmail.Text & "' , '" & txtDomicilio.Text & "')"
        dbhelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE persona SET nroDocumento = " & mskNroDoc.Text
        sql &= " , apellido = '" & txtApellido.Text & "'"
        sql &= " , nombre = '" & txtNombre.Text & "'"
        sql &= " , idTipoDocumento = '" & cmbTipoDoc.SelectedValue & "'"
        sql &= " , fechaIngreso = '" & dtpFechaIngreso.Value & "'"
        sql &= " , fechaEgreso = '" & dtpFechaEgreso.Value & "'"
        sql &= " , celular = " & txtCelular.Text
        sql &= " , Mail = '" & txtEmail.Text & "'"
        sql &= " , Domicilio = '" & txtDomicilio.Text & "'"
        sql &= " WHERE nroDocumento = " & mskNroDoc.Text

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

        sql &= " SELECT * FROM persona WHERE nroDocumento = " & Me.mskNroDoc.Text

        tabla = dbhelper.ConsultaSQL(sql)

        If tabla.Rows.Count = 0 Then
            Return estadoGrabacion.aprobado
        Else
            Return estadoGrabacion.rechazado
        End If
    End Function
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txtApellido.Enabled = False
        txtNombre.Enabled = False
        mskNroDoc.Enabled = True
        cmbTipoDoc.Enabled = False
        dtpFechaIngreso.Enabled = False
        dtpFechaEgreso.Enabled = False
        txtDomicilio.Enabled = False
        txtEmail.Enabled = False
        txtCelular.Enabled = False
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = False
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txtApellido.Text = ""
        txtApellido.Enabled = True
        txtNombre.Text = ""
        txtNombre.Enabled = True
        mskNroDoc.Text = ""
        mskNroDoc.Enabled = True
        cmbTipoDoc.SelectedIndex = -1
        cmbTipoDoc.Enabled = True
        dtpFechaIngreso.Text = ""
        dtpFechaIngreso.Enabled = True
        dtpFechaEgreso.Text = ""
        dtpFechaEgreso.Enabled = False
        txtDomicilio.Text = ""
        txtDomicilio.Enabled = True
        txtEmail.Text = ""
        txtEmail.Enabled = True
        txtCelular.Text = ""
        txtCelular.Enabled = True
        btn_guardar.Enabled = True
        estado_Grabacion = condicionGrabacion.insertar
    End Sub
    Private Function btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        If mskNroDoc.Text = "" Then
            MsgBox("Debe ingresar un numero de documento")
        Else
            sql = "SELECT * FROM persona WHERE nroDocumento = " & mskNroDoc.Text
            tabla = dbhelper.ConsultaSQL(sql)
            Me.dgvEmpleado.Rows.Clear()

            Dim c As Integer = 0

            For c = 0 To tabla.Rows.Count - 1
                Me.dgvEmpleado.Rows.Add()
                Me.dgvEmpleado.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(0)
                Me.dgvEmpleado.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(1)
                Me.dgvEmpleado.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
            Next
        End If
    End Function

    Private Sub dgvEmpleado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentDoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM persona WHERE nroDocumento = " & Me.dgvEmpleado.CurrentRow.Cells("cNroDoc").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.txtApellido.Text = tabla.Rows(0)("apellido")
        Me.txtNombre.Text = tabla.Rows(0)("nombre")
        Me.mskNroDoc.Text = tabla.Rows(0)("nroDocumento")
        Me.cmbTipoDoc.SelectedValue = tabla.Rows(0)("idTipoDocumento")

        If IsDBNull(tabla.Rows(0)("fechaIngreso")) = True Then
            Me.dtpFechaIngreso.Text = ""
            Me.dtpFechaIngreso.Enabled = True
        Else
            Me.dtpFechaIngreso.Value = tabla.Rows(0)("fechaIngreso")
        End If

        If IsDBNull(tabla.Rows(0)("fechaEgreso")) = True Then
            Me.dtpFechaEgreso.Text = ""
            Me.dtpFechaEgreso.Enabled = True
        Else
            Me.dtpFechaEgreso.Value = tabla.Rows(0)("fechaEgreso")
        End If

        If IsDBNull(tabla.Rows(0)("celular")) = True Then
            Me.txtCelular.Text = ""
            Me.txtCelular.Enabled = True
        Else
            Me.txtCelular.Text = tabla.Rows(0)("celular")
        End If

        If IsDBNull(tabla.Rows(0)("Mail")) = True Then
            Me.txtEmail.Text = ""
            Me.txtEmail.Enabled = True
        Else
            Me.txtEmail.Text = tabla.Rows(0)("Mail")
        End If

        If IsDBNull(tabla.Rows(0)("Domicilio")) = True Then
            Me.txtDomicilio.Text = ""
            Me.txtDomicilio.Enabled = True
        Else
            Me.txtDomicilio.Text = tabla.Rows(0)("Domicilio")
        End If

        Me.txtApellido.Enabled = True
        Me.txtNombre.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        Me.mskNroDoc.Enabled = False
        estado_Grabacion = condicionGrabacion.modificar
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""

        If validarDatos() = estadoGrabacion.aprobado Then
            If validarPersona() = estadoGrabacion.rechazado Then
                sql = " DELETE FROM persona WHERE nroDocumento = " & mskNroDoc.Text
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