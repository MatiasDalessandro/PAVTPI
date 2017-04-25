Public Class AbmEmpleado

    Dim cadenaConexion As String = "Provider=SQLNCLI11;Data Source=MATI-PC\GDAPAV;Integrated Security=SSPI;Initial Catalog=PAV-TPI"

    Private Sub AbmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
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

        sql = "SELECT * FROM Persona"

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
        'Dim sql As String = ""
        'If validar_datos() = estado_grabacion.aprobado Then
        '    If estadoGrabacion = condicionGrabacion.insertar Then
        '        If validar_articulo() = estado_grabacion.aprobado Then
        '            insertar()
        '        Else
        '            MsgBox("El numero de documento que intenta cargar ya existe")
        '        End If
        '    Else
        '        modificar()
        '    End If
        'Else
        'End If
    End Sub
    Private Sub insertar()
        Dim sql As String = ""
        sql = " INSERT INTO Persona (Nombre,Apellido,NroDocumento,IdTipoDocumento,FechaIngreso,,Celular,Email,Domicilio) values ( " & txtNombre.Text & ", '" & txtApellido.Text & "' , " & mskNroDoc.Text & "' , " & cmbTipoDoc.Text & "' , " & mskFechaIngreso.Text & "' , " &  & "' , " & txtCelular.Text & "' , " & txtEmail.Text & "' , " & txtDomi.Text & ")"
        ejecutosql(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE Persona SET NroDocumento = " & mskNroDoc.Text
        sql &= " , Nombre = '" & txtNombre.Text & "'"
        sql &= " , Apellido = " & txtApellido.Text & "'"
        sql &= " , IdTipoDocumento = " & cmbTipoDoc.Text & "'"
        sql &= " , FechaIngreso = " & mskFechaIngreso.Text & "'"
        sql &= " , "
        sql &= " , Celular = " & txtCelular.Text & "'"
        sql &= " , Email = " & txtEmail.Text & "'"
        sql &= " , Domicilio = " & txtDomicilio.Text & "'"
        sql &= " WHERE IdArticulo_Combo = " & mskNroDoc.Text

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

End Class