'Public Class AbmPersonaAutorizada
'    Dim cadenaConexion As String = "Provider=SQLNCLI11;Data Source=LAPTOP-6VOLNCDP\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
'    Dim estado_Grabacion As condicionGrabacion = condicionGrabacion.insertar
'    Enum estadoGrabacion
'        aprobado
'        rechazado
'    End Enum
'    Enum condicionGrabacion
'        insertar
'        modificar
'    End Enum
'    Private Sub AbmPersonaAutorizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        cargar_grilla()
'        cargar_combo(cmbTipoDocPA, Me.leo_tabla("tipoDocumento"), "idTipoDocumento", "descripcion")
'    End Sub
'    Private Sub cargar_grilla()
'        Dim conexion As New OleDb.OleDbConnection
'        Dim cmd As New OleDb.OleDbCommand
'        Dim tabla As New DataTable

'        conexion.ConnectionString = cadenaConexion
'        conexion.Open()
'        cmd.Connection = conexion
'        cmd.CommandType = CommandType.Text

'        Dim sql As String = ""

'        sql &= "Select        persona.nombre, persona.apellido, persona.nroDocumento, persona.idTipoDocumento, persona.fechaIngreso, persona.fechaEgreso, "
'        sql &= "                 persona.celular, persona.Mail, persona.Domicilio, tipoDocumento.descripcion, tipoDocumento.idTipoDocumento "
'        sql &= " From            persona INNER JOIN "
'        sql &= " tipoDocumento On persona.idTipoDocumento = tipoDocumento.idTipoDocumento "

'        cmd.CommandText = sql
'        tabla.Load(cmd.ExecuteReader())
'        conexion.Close()

'        Dim c As Integer = 0

'        Me.dgvPersAut.Rows.Clear()

'        For c = 0 To tabla.Rows.Count - 1
'            Me.dgvPersAut.Rows.Add()
'            Me.dgvPersAut.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(0)
'            Me.dgvPersAut.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(1)
'            Me.dgvPersAut.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
'            Me.dgvPersAut.Rows(c).Cells("cDependencia").Value = tabla.Rows(c)(3)
'        Next
'    End Sub
'    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
'        Dim sql As String = ""
'        If validarDatos() = estadoGrabacion.aprobado Then
'            If estado_Grabacion = condicionGrabacion.insertar Then
'                If validarPersona() = estadoGrabacion.aprobado Then
'                    insertar()
'                Else
'                    MsgBox("El numero de documento que intenta cargar ya existe")
'                End If
'            Else
'                modificar()
'            End If
'        Else
'        End If
'    End Sub
'    Private Sub insertar()
'        Dim sql As String = ""
'        sql = " INSERT INTO persona (nombre,apellido,nroDocumento,idTipoDocumento,fechaIngreso,fechaEgreso, celular,Mail,Domicilio) values ( '" & txtNombrePA.Text & "', '" & txtApellidoPA.Text & "' , " & mskNroDocPA.Text & " , " & cmbTipoDocPA.SelectedValue & " , '" & mskFechaIngreso.Text & "' ,   null   , " & txtCelular.Text & " , '" & txtEmail.Text & "' , '" & txtDomicilio.Text & "')"
'        ejecutosql(sql)
'        MsgBox("Se grabo correctamente")
'        Me.cargar_grilla()
'    End Sub
'    Private Sub modificar()
'        Dim sql As String = ""

'        sql &= " UPDATE persona SET nroDocumento = " & mskNroDocPA.Text
'        sql &= " , nombre = '" & txtNombrePA.Text & "'"
'        sql &= " , apellido = '" & txtApellidoPA.Text & "'"
'        sql &= " , idTipoDocumento = '" & cmbTipoDocPA.SelectedValue & "'"
'        sql &= " , fechaIngreso = '" & mskFechaIngreso.Text & "'"
'        sql &= " , fechaEgreso = null "
'        sql &= " , celular = " & txtCelular.Text
'        sql &= " , Mail = '" & txtEmail.Text & "'"
'        sql &= " , Domicilio = '" & txtDomicilio.Text & "'"
'        sql &= " WHERE nroDocumento = " & mskNroDocPA.Text

'        ejecutosql(sql)
'        Me.cargar_grilla()
'        MsgBox("Se Modifico correctamente")
'    End Sub
'    Private Function ejecutosql(ByVal consulta As String) As DataTable
'        Dim conexion As New OleDb.OleDbConnection
'        Dim cmd As New OleDb.OleDbCommand
'        Dim tabla As New DataTable

'        conexion.ConnectionString = cadenaConexion
'        conexion.Open()
'        cmd.Connection = conexion
'        cmd.CommandType = CommandType.Text

'        cmd.CommandText = consulta
'        tabla.Load(cmd.ExecuteReader())
'        conexion.Close()
'        Return tabla
'    End Function
'    Private Function validarDatos() As estadoGrabacion
'        For Each obj As Control In Me.Controls
'            If obj.GetType.Name = "TextBox" Then
'                If obj.Text = "" Then
'                    MsgBox("El " & obj.Name & " no está ingresado")
'                    obj.Focus()
'                    Return estadoGrabacion.rechazado
'                End If
'            End If
'        Next

'    End Function
'    Private Function validarPersona() As estadoGrabacion
'        Dim sql As String = ""
'        Dim tabla As New DataTable

'        sql &= " SELECT * FROM persona WHERE nroDocumento = " & Me.mskNroDocPA.Text

'        tabla = ejecutosql(sql)

'        If tabla.Rows.Count = 0 Then
'            Return estadoGrabacion.aprobado
'        Else
'            Return estadoGrabacion.rechazado
'        End If
'    End Function
'    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
'        txtApellidoPA.Enabled = False
'        txtNombrePA.Enabled = False
'        mskNroDocPA.Enabled = True
'        cmbTipoDocPA.Enabled = False
'        mskFechaIngreso.Enabled = False
'        mskFechaEgreso.Enabled = False
'        txtDomicilio.Enabled = False
'        txtEmail.Enabled = False
'        txtCelular.Enabled = False
'    End Sub
'    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
'        txtApellidoPA.Text = ""
'        txtApellidoPA.Enabled = True
'        txtNombrePA.Text = ""
'        txtNombrePA.Enabled = True
'        mskNroDocPA.Text = ""
'        mskNroDocPA.Enabled = True
'        cmbTipoDocPA.Enabled = True
'        mskFechaIngreso.Enabled = True
'        mskFechaEgreso.Enabled = False
'        txtDomicilio.Enabled = True
'        txtEmail.Enabled = True
'        txtCelular.Enabled = True
'        btn_guardar.Enabled = True
'    End Sub
'    Private Function btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
'        Dim sql As String = ""
'        Dim tabla As New DataTable

'        sql = "SELECT * FROM persona WHERE nroDocumento = " & mskNroDocPA.Text
'        tabla = ejecutosql(sql)
'        Me.dgvPersAut.Rows.Clear()

'        Dim c As Integer = 0

'        For c = 0 To tabla.Rows.Count - 1
'            Me.dgvPersAut.Rows.Add()
'            Me.dgvPersAut.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(0)
'            Me.dgvPersAut.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(1)
'            Me.dgvPersAut.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
'        Next
'    End Function

'    Private Sub dgvPersAut_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersAut.CellContentClick
'        Dim sql As String = ""
'        Dim tabla As New DataTable

'        sql = " SELECT * FROM persona WHERE nroDocumento = " & Me.dgvPersAut.CurrentRow.Cells("cNroDoc").Value

'        tabla = ejecutosql(sql)

'        Me.txtApellidoPA.Text = tabla.Rows(0)("apellido")
'        Me.txtNombrePA.Text = tabla.Rows(0)("nombre")
'        Me.mskNroDocPA.Text = tabla.Rows(0)("nroDocumento")

'        Me.txtApellidoPA.Enabled = True
'        Me.txtNombrePA.Enabled = True
'        btn_eliminar.Enabled = True
'        btn_guardar.Enabled = True
'        Me.mskNroDocPA.Enabled = False
'        estado_Grabacion = condicionGrabacion.modificar
'    End Sub

'    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
'        Dim sql As String = ""

'        If validarDatos() = estadoGrabacion.aprobado Then
'            If validarPersona() = estadoGrabacion.rechazado Then
'                sql = " DELETE FROM persona WHERE nroDocumento = " & mskNroDocPA.Text
'                MsgBox("Se elimino correctamente la persona")
'            Else
'                MsgBox("Cargue correctamente la persona a eliminar")
'            End If
'        End If

'        ejecutosql(sql)
'        Me.cargar_grilla()
'    End Sub
'    Private Sub cargar_combo(ByRef combo As ComboBox _
'                              , ByRef tabla As DataTable _
'                              , ByVal pk As String _
'                              , ByVal descriptor As String)

'        combo.DataSource = tabla
'        combo.DisplayMember = descriptor
'        combo.ValueMember = pk
'        combo.SelectedIndex = -1

'    End Sub
'    Private Function leo_tabla(ByVal nombre_tabla As String) As DataTable
'        Return Me.ejecutosql("SELECT * FROM " & nombre_tabla)
'    End Function
'End Class
'End Class