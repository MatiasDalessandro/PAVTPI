Public Class AbmRol
    Enum estado_grabacion
        aprobado
        rechazado
    End Enum
    Enum condicionGrabacion
        insertar
        modificar
    End Enum
    Dim dbhelper As DBHelper = DBHelper.getDBHelper
    Dim estadoGrabacion = condicionGrabacion.insertar


    Private Sub AbmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM rol"

        tabla = dbhelper.ConsultaSQL(sql)

        Dim c As Integer = 0

        Me.dgv_datos_rol.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_rol.Rows.Add()
            Me.dgv_datos_rol.Rows(c).Cells("c_id_rol").Value = tabla.Rows(c)(0)
            Me.dgv_datos_rol.Rows(c).Cells("c_nombre_rol").Value = tabla.Rows(c)(1)
        Next
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Nombre.Enabled = False
        Nombre.Text = ""
        Me.cargar_grilla()
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = False
        Me.msk_idRol.Text = ""
        Me.msk_idRol.Enabled = True

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.msk_idRol.Text = ""
        Me.Nombre.Text = ""
        Me.Nombre.Enabled = True
        Me.btn_eliminar.Enabled = False
        Me.btn_guardar.Enabled = True
        Me.estadoGrabacion = condicionGrabacion.insertar
        Me.msk_idRol.Enabled = False
    End Sub

    Private Sub dgv_datos_rol_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos_rol.CellDoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM rol WHERE idRol = " & Me.dgv_datos_rol.CurrentRow.Cells("c_id_rol").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.msk_idRol.Text = tabla.Rows(0)("idRol")
        Me.Nombre.Text = tabla.Rows(0)("Descripcion")

        Me.msk_idRol.Enabled = True
        Me.Nombre.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = True
        estadoGrabacion = condicionGrabacion.modificar
        Me.msk_idRol.Enabled = False

    End Sub

    Private Function validarRol() As estado_grabacion
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM rol WHERE idRol = " & Me.msk_idRol.Text

        tabla = dbhelper.ConsultaSQL(sql)

        If tabla.Rows.Count = 0 Then
            Return estado_grabacion.aprobado
        Else
            Return estado_grabacion.rechazado
        End If
    End Function

    Private Function validarDatos() As estado_grabacion
        For Each obj As Control In Me.Controls
            If obj.GetType.Name = "TextBox" Then
                If obj.Text = "" Then
                    MsgBox("El " & obj.Name & " no está ingresado")
                    obj.Focus()
                    Return estado_grabacion.rechazado
                End If
            End If
        Next

    End Function

    Private Sub insertar()
        Dim sql As String = ""

        sql = " INSERT INTO Rol (Descripcion) VALUES ('" & Nombre.Text & "')"
        dbhelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente.")
        Me.cargar_grilla()
    End Sub

    Public Sub modificar()
        Dim sql As String = ""

        sql &= " UPDATE rol SET Descripcion = '" & Nombre.Text & "' WHERE IdRol = " & Me.msk_idRol.Text
        dbhelper.EjecutarSQL(sql)
        MsgBox("Se modifico correctamente.")
        Me.cargar_grilla()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sql As String = ""

        If validarDatos() = estado_grabacion.aprobado Then
            If estadoGrabacion = condicionGrabacion.insertar Then
                If validarRol() = estado_grabacion.aprobado Then
                    insertar()
                Else
                    MsgBox("El ID del Rol ya existe.")
                End If
                insertar()
            Else
                modificar()
            End If
        Else
        End If

        Me.msk_idRol.Text = ""
        Me.Nombre.Text = ""

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""

        If validarDatos() = estado_grabacion.aprobado Then
            If validarRol() = estado_grabacion.rechazado Then
                sql = " DELETE FROM rol WHERE idRol = " & Me.msk_idRol.Text
                MsgBox("Se elimino correctamente el Rol.")
            Else
                MsgBox("Cargue correctamente el Rol a eliminar.")
            End If
        End If

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable

        If msk_idRol.Enabled = False Then
            Exit Sub
        End If

        sql = "SELECT * FROM rol WHERE idRol = " & Me.msk_idRol.Text

        tabla = dbhelper.ConsultaSQL(sql)
        Dim c As Integer = 0
        Me.dgv_datos_rol.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_datos_rol.Rows.Add()
            Me.dgv_datos_rol.Rows(c).Cells("c_id_rol").Value = tabla.Rows(c)(0)
            Me.dgv_datos_rol.Rows(c).Cells("c_nombre_rol").Value = tabla.Rows(c)(1)
        Next
    End Sub
End Class