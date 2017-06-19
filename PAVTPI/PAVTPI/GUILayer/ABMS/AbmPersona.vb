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
        cargar_combo(TipoDocumento, (dbhelper.ConsultaSQL("select * from tipoDocumento")), "idTipoDocumento", "descripcion")
        dtpFechaEgreso.Enabled = False
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
        'SI FALTA NRO DOC ESTALLA
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
        sql = " INSERT INTO persona (nombre,apellido,nroDocumento,idTipoDocumento,fechaIngreso,fechaEgreso, celular,Mail,Domicilio) values ( '" & Nombre.Text & "', '" & Apellido.Text & "' , " & NumeroDocumento.Text & " , " & TipoDocumento.SelectedValue & " , '" & dtpFechaIngreso.Value & "' ,   null   , " & Celular.Text & " , '" & Email.Text & "' , '" & Domicilio.Text & "')"
        dbhelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE persona SET nroDocumento = " & NumeroDocumento.Text
        sql &= " , apellido = '" & Apellido.Text & "'"
        sql &= " , nombre = '" & Nombre.Text & "'"
        sql &= " , idTipoDocumento = '" & TipoDocumento.SelectedValue & "'"
        sql &= " , fechaIngreso = '" & dtpFechaEgreso.Value & "'"
        sql &= " , fechaEgreso = '" & dtpFechaEgreso.Value & "'"
        sql &= " , celular = " & Celular.Text
        sql &= " , Mail = '" & Email.Text & "'"
        sql &= " , Domicilio = '" & Domicilio.Text & "'"
        sql &= " WHERE nroDocumento = " & NumeroDocumento.Text

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
        MsgBox("Se Modifico correctamente")
    End Sub
    Private Function validarDatos() As estadoGrabacion
        For Each obj As Control In Me.Controls
            If obj.GetType.Name = "TextBox" Or obj.GetType.Name = "MaskedTextBox" Or obj.GetType.Name = "ComboBox" Then
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

        sql &= " SELECT * FROM persona WHERE nroDocumento = " & Me.NumeroDocumento.Text

        tabla = dbhelper.ConsultaSQL(sql)

        If tabla.Rows.Count = 0 Then
            Return estadoGrabacion.aprobado
        Else
            Return estadoGrabacion.rechazado
        End If
    End Function
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        chkPersAut.Enabled = False
        Apellido.Enabled = False
        Nombre.Enabled = False
        NumeroDocumento.Enabled = True
        TipoDocumento.Enabled = False
        dtpFechaIngreso.Enabled = False
        dtpFechaEgreso.Enabled = False
        Domicilio.Enabled = False
        Email.Enabled = False
        Celular.Enabled = False
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = False
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

        If chkPersAut.Checked Then
            dtpFechaEgreso.Enabled = False
            dtpFechaIngreso.Enabled = False
            Domicilio.Enabled = False
            Celular.Enabled = False
            Email.Enabled = False
        End If

        chkPersAut.Enabled = True
        Apellido.Text = ""
        Apellido.Enabled = True
        Nombre.Text = ""
        Nombre.Enabled = True
        NumeroDocumento.Text = ""
        NumeroDocumento.Enabled = True
        TipoDocumento.SelectedIndex = -1
        TipoDocumento.Enabled = True
        dtpFechaIngreso.Text = ""
        dtpFechaIngreso.Enabled = True
        dtpFechaEgreso.Text = ""
        dtpFechaEgreso.Enabled = False
        Domicilio.Text = ""
        Domicilio.Enabled = True
        Email.Text = ""
        Email.Enabled = True
        Celular.Text = ""
        Celular.Enabled = True
        btn_guardar.Enabled = True
        estado_Grabacion = condicionGrabacion.insertar
    End Sub
    Private Function btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        If NumeroDocumento.Text = "" Then
            MsgBox("Debe ingresar un numero de documento")
        Else
            sql = "SELECT * FROM persona WHERE nroDocumento = " & NumeroDocumento.Text
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

    Private Sub dgvEmpleado_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.DoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM persona WHERE nroDocumento = " & Me.dgvEmpleado.CurrentRow.Cells("cNroDoc").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.Apellido.Text = tabla.Rows(0)("apellido")
        Me.Nombre.Text = tabla.Rows(0)("nombre")
        Me.NumeroDocumento.Text = tabla.Rows(0)("nroDocumento")
        Me.TipoDocumento.SelectedValue = tabla.Rows(0)("idTipoDocumento")

        chkPersAut.Enabled = True
        Apellido.Enabled = True
        Nombre.Enabled = True
        NumeroDocumento.Enabled = True
        TipoDocumento.Enabled = True
        dtpFechaIngreso.Enabled = True
        dtpFechaEgreso.Enabled = False
        Domicilio.Enabled = True
        Email.Enabled = True
        Celular.Enabled = True
        btn_guardar.Enabled = True

        If IsDBNull(tabla.Rows(0)("fechaIngreso")) = True Then
            Me.dtpFechaIngreso.Text = ""
            Me.dtpFechaIngreso.Enabled = False
            Me.chkPersAut.Enabled = False
            Me.chkPersAut.Checked = True
        Else
            Me.dtpFechaIngreso.Value = tabla.Rows(0)("fechaIngreso")
            Me.chkPersAut.Enabled = True
            Me.chkPersAut.Checked = False
        End If

        If IsDBNull(tabla.Rows(0)("fechaEgreso")) = True Then
            Me.dtpFechaEgreso.Text = ""
            Me.dtpFechaEgreso.Enabled = False
        Else
            Me.dtpFechaEgreso.Value = tabla.Rows(0)("fechaEgreso")
        End If

        If IsDBNull(tabla.Rows(0)("celular")) = True Then
            Me.Celular.Text = ""
            Me.Celular.Enabled = False
        Else
            Me.Celular.Text = tabla.Rows(0)("celular")
        End If

        If IsDBNull(tabla.Rows(0)("Mail")) = True Then
            Me.Email.Text = ""
            Me.Email.Enabled = False
        Else
            Me.Email.Text = tabla.Rows(0)("Mail")
        End If

        If IsDBNull(tabla.Rows(0)("Domicilio")) = True Then
            Me.Domicilio.Text = ""
            Me.Domicilio.Enabled = False
        Else
            Me.Domicilio.Text = tabla.Rows(0)("Domicilio")
        End If

        Me.Apellido.Enabled = True
        Me.Nombre.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        Me.NumeroDocumento.Enabled = False
        estado_Grabacion = condicionGrabacion.modificar
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""

        If validarDatos() = estadoGrabacion.aprobado Then
            If validarPersona() = estadoGrabacion.rechazado Then
                sql = " DELETE FROM persona WHERE nroDocumento = " & NumeroDocumento.Text
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

    Private Sub chkPersAut_CheckStateChanged(sender As Object, e As EventArgs) Handles chkPersAut.CheckStateChanged
        If chkPersAut.Checked Then
            dtpFechaIngreso.Enabled = False
            dtpFechaEgreso.Enabled = False
            Domicilio.Enabled = False
            Email.Enabled = False
            Celular.Enabled = False
        Else
            dtpFechaIngreso.Enabled = True
            dtpFechaEgreso.Enabled = False
            Domicilio.Enabled = True
            Email.Enabled = True
            Celular.Enabled = True
        End If
    End Sub
End Class