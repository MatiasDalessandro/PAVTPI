Public Class AbmTipoDocumento
    Enum estadoGrabacion
        aprobado
        rechazado
    End Enum
    Enum condicionGrabacion
        insertar
        modificar
    End Enum
    Dim estado_Grabacion As condicionGrabacion = condicionGrabacion.insertar
    Dim cadenaConexion As String = "Provider=SQLNCLI11;Data Source=MATI-PC\GDAPAV;Integrated Security=SSPI;Initial Catalog=PAV-TPI"

    Private Sub AbmTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        sql &= "SELECT        idTipoDocumento, descripcion "
        sql &= " From            tipoDocumento"

        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        Dim c As Integer = 0

        Me.dgv_Tipo_Doc.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_Tipo_Doc.Rows.Add()
            Me.dgv_Tipo_Doc.Rows(c).Cells("Id_Tipo_Doc").Value = tabla.Rows(c)(0)
            Me.dgv_Tipo_Doc.Rows(c).Cells("Nombre_Tipo_Doc").Value = tabla.Rows(c)(1)
        Next
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Dim sql As String = ""
        If validarDatos() = estadoGrabacion.aprobado Then
            If estado_Grabacion = condicionGrabacion.insertar Then
                If validarTipoDocuemnto() = estadoGrabacion.aprobado Then
                    insertar()
                Else
                    MsgBox("El ID que intenta cargar ya existe")
                End If
            Else
                modificar()
            End If
        Else
        End If
    End Sub
    Private Sub insertar()
        Dim sql As String = ""
        sql = " INSERT INTO tipoDocumento (idTipoDocumento,descripcion) VALUES ( '" & txt_Id_Tipo_Doc.Text & "', '" & txt_Nombre.Text & "')"
        ejecutosql(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= "UPDATE tipoDocumento "
        sql &= "SET descripcion = '" & Me.txt_Nombre.Text & "'"
        sql &= " WHERE idTipoDocumento = " & Me.txt_Id_Tipo_Doc.Text

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
            If obj.GetType.Name = "TextBox" Or obj.GetType.Name = "MaskedTextBox" Then
                If obj.Text = "" Then
                    MsgBox("El " & obj.Name & " esta vacio")
                    obj.Focus()
                    Return estadoGrabacion.rechazado
                End If
            End If
        Next
        Return estadoGrabacion.aprobado
    End Function
    Private Function validarTipoDocuemnto() As estadoGrabacion
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM tipoDocumento WHERE idTipoDocumento = " & Me.txt_Id_Tipo_Doc.Text

        tabla = ejecutosql(sql)

        If tabla.Rows.Count = 0 Then
            Return estadoGrabacion.aprobado
        Else
            Return estadoGrabacion.rechazado
        End If
    End Function

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        For Each obj As Control In Me.Controls
            If obj.GetType.Name = "TextBox" Or obj.GetType.Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
            If obj.GetType.Name = "ComboBox" Then
                Dim O As ComboBox = obj
                O.SelectedIndex = -1
            End If
        Next

        Me.txt_Id_Tipo_Doc.Enabled = True
        Me.txt_Nombre.Enabled = True
        Me.btn_Guardar.Enabled = True
        Me.btn_Eliminar.Enabled = True
        Me.estado_Grabacion = condicionGrabacion.insertar
        Me.txt_Id_Tipo_Doc.Focus()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM tipoDocuemnto WHERE idTipoDocuemnto = " & txt_Id_Tipo_Doc.Text
        tabla = ejecutosql(sql)
        Me.dgv_Tipo_Doc.Rows.Clear()

        Dim c As Integer = 0

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_Tipo_Doc.Rows.Add()
            Me.dgv_Tipo_Doc.Rows(c).Cells("Id_Tipo_Doc").Value = tabla.Rows(c)(0)
            Me.dgv_Tipo_Doc.Rows(c).Cells("Nombre_Tipo_Doc").Value = tabla.Rows(c)(1)

        Next
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim sql As String = ""

        If validarDatos() = estadoGrabacion.aprobado Then
            If validarTipoDocuemnto() = estadoGrabacion.rechazado Then
                sql = " DELETE FROM tipoDocumento WHERE idTipoDocumento = " & txt_Id_Tipo_Doc.Text
                MsgBox("Se elimino correctamente el tipo de documento")
            Else
                MsgBox("Cargue correctamente el tipo documento a eliminar")
            End If
        End If

        ejecutosql(sql)
        Me.cargar_grilla()
    End Sub
    Private Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return Me.ejecutosql("SELECT * FROM " & nombre_tabla)
    End Function

    Private Sub dgv_Tipo_Doc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tipo_Doc.CellContentClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM tipoDocuemnto WHERE idTipoDocuemnto = " & Me.dgv_Tipo_Doc.CurrentRow.Cells("Id_Tipo_Doc").Value

        tabla = ejecutosql(sql)

        Me.txt_Id_Tipo_Doc.Text = tabla.Rows(0)("ID")
        Me.txt_Nombre.Text = tabla.Rows(0)("Nombre")



        Me.txt_Nombre.Enabled = True
        btn_Eliminar.Enabled = True
        btn_Guardar.Enabled = True
        Me.txt_Id_Tipo_Doc.Enabled = False
        estado_Grabacion = condicionGrabacion.modificar
    End Sub
End Class