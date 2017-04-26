Public Class AbmEmpleado

    Dim cadenaConexion As String = "Provider=SQLNCLI11;Data Source=MATI-PC\GDAPAV;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
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
        cargar_combo(cmbTipoDoc, Me.leo_tabla("TipoDocumento"), "IdTipoDocumento", "Nombre")
    End Sub

    Private Sub cargar_grilla()
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = ""

        sql &= "SELECT        Persona.Nombre, Persona.Apellido, Persona.NroDocumento, Persona.IdTipoDocumento, Persona.FechaIngreso, Persona.FechaEgreso, "
        sql &= "                 Persona.Celular, Persona.Email, Persona.Domicilio, TipoDocumento.Nombre, TipoDocumento.IdTipoDocumento "
        sql &= " From            Persona INNER JOIN "
        sql &= " TipoDocumento ON Persona.IdTipoDocumento = TipoDocumento.IdTipoDocumento "

        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

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
        sql = " INSERT INTO Persona (Nombre,Apellido,NroDocumento,IdTipoDocumento,FechaIngreso,FechaEgreso,Celular,Email,Domicilio) values ( '" & txtNombre.Text & "', '" & txtApellido.Text & "' , " & mskNroDoc.Text & " , '" & cmbTipoDoc.SelectedValue & "' , '" & mskFechaIngreso.Text & "' ,   null   , " & txtCelular.Text & " , '" & txtEmail.Text & "' , '" & txtDomicilio.Text & "')"
        ejecutosql(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE Persona SET NroDocumento = " & mskNroDoc.Text
        sql &= " , Nombre = '" & txtNombre.Text & "'"
        sql &= " , Apellido = '" & txtApellido.Text & "'"
        sql &= " , IdTipoDocumento = '" & cmbTipoDoc.SelectedValue & "'"
        sql &= " , FechaIngreso = '" & mskFechaIngreso.Text & "'"
        sql &= " , FechaEgreso = null "
        sql &= " , Celular = " & txtCelular.Text
        sql &= " , Email = '" & txtEmail.Text & "'"
        sql &= " , Domicilio = '" & txtDomicilio.Text & "'"
        sql &= " WHERE NroDocumento = " & mskNroDoc.Text

        ejecutosql(sql)
        Me.cargar_grilla()
        MsgBox("Se Modifico correctamente")
    End Sub
    Private Function ejecutosql(ByVal consulta As String) As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function
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

        sql &= " SELECT * FROM Persona WHERE NroDocumento = " & Me.mskNroDoc.Text

        tabla = ejecutosql(sql)

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
        mskFechaIngreso.Enabled = False
        mskFechaEgreso.Enabled = False
        txtDomicilio.Enabled = False
        txtEmail.Enabled = False
        txtCelular.Enabled = False
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txtApellido.Text = ""
        txtApellido.Enabled = True
        txtNombre.Text = ""
        txtNombre.Enabled = True
        mskNroDoc.Text = ""
        mskNroDoc.Enabled = True
        cmbTipoDoc.Enabled = True
        mskFechaIngreso.Enabled = True
        mskFechaEgreso.Enabled = False
        txtDomicilio.Enabled = True
        txtEmail.Enabled = True
        txtCelular.Enabled = True
        btn_guardar.Enabled = True
    End Sub
    Private Function btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Persona WHERE NroDocumento = " & mskNroDoc.Text
        tabla = ejecutosql(sql)
        Me.dgvEmpleado.Rows.Clear()

        Dim c As Integer = 0

        For c = 0 To tabla.Rows.Count - 1
            Me.dgvEmpleado.Rows.Add()
            Me.dgvEmpleado.Rows(c).Cells("cNombre").Value = tabla.Rows(c)(0)
            Me.dgvEmpleado.Rows(c).Cells("cApellido").Value = tabla.Rows(c)(1)
            Me.dgvEmpleado.Rows(c).Cells("cNroDoc").Value = tabla.Rows(c)(2)
        Next
    End Function

    Private Sub dgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM Persona WHERE NroDocumento = " & Me.dgvEmpleado.CurrentRow.Cells("cNroDoc").Value

        tabla = ejecutosql(sql)

        Me.txtApellido.Text = tabla.Rows(0)("Apellido")
        Me.txtNombre.Text = tabla.Rows(0)("Nombre")
        Me.mskNroDoc.Text = tabla.Rows(0)("NroDocumento")

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
                sql = " DELETE FROM Persona WHERE NroDocumento = " & mskNroDoc.Text
                MsgBox("Se elimino correctamente la persona")
            Else
                MsgBox("Cargue correctamente la persona a eliminar")
            End If
        End If

        ejecutosql(sql)
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
    Private Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return Me.ejecutosql("SELECT * FROM " & nombre_tabla)
    End Function
End Class