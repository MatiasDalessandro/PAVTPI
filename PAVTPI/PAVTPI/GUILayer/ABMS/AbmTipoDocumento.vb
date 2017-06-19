'ABM Tipo Documento Alvaro
Public Class AbmTipoDocumento
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

    Private Sub AbmTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub
    Private Sub cargar_grilla()

        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT        idTipoDocumento, descripcion "
        sql &= " From            tipoDocumento"

        tabla = dbhelper.ConsultaSQL(sql)

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
                insertar()
            Else
                modificar()
            End If
        Else
        End If
        Me.cargar_grilla()
        Nombre.Text = ""
        txt_Id_Tipo_Doc.Text = ""
        Me.btn_Nuevo.Enabled = True
        Me.btn_Guardar.Enabled = False
        Me.btn_Eliminar.Enabled = False
        Me.Nombre.Enabled = False
    End Sub
    Private Sub insertar()
        Dim sql As String = ""
        sql = " INSERT INTO tipoDocumento (descripcion) VALUES ('" & Nombre.Text & "')"
        'Dim num As Integer
        'num = ejecSql(sql)
        'If num > 0 Then
        '    MsgBox("Se grabo correctamente")
        'Else
        '    MsgBox("no se pudo insetar")
        'End If
        dbhelper.EjecutarSQL(sql)
        MsgBox("Se grabo correctamente")
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= "UPDATE tipoDocumento "
        sql &= "SET descripcion = '" & Me.Nombre.Text & "'"
        sql &= " WHERE idTipoDocumento = " & Me.txt_Id_Tipo_Doc.Text

        'Dim num As Integer
        'num = ejecSql(sql)
        'If num > 0 Then
        '    MsgBox("Se grabo correctamente")
        'Else
        '    MsgBox("no se pudo insetar")
        'End If
        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
        MsgBox("Se Modifico correctamente")
    End Sub
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
        If Nombre.Text = "" Then
            Return estadoGrabacion.rechazado
        Else
            Return estadoGrabacion.aprobado
        End If
    End Function
    Private Function validarTipoDocuemnto() As estadoGrabacion
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM tipoDocumento WHERE idTipoDocumento = " & Me.txt_Id_Tipo_Doc.Text

        tabla = dbhelper.ConsultaSQL(sql)

        If tabla.Rows.Count = 0 Then
            Return estadoGrabacion.aprobado
        Else
            Return estadoGrabacion.rechazado
        End If

    End Function

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Nombre.Text = ""
        Me.txt_Id_Tipo_Doc.Text = ""
        Me.Nombre.Enabled = False
        Me.txt_Id_Tipo_Doc.Enabled = False
        Me.btn_Guardar.Enabled = False
        Me.btn_Eliminar.Enabled = False
        Me.btn_Nuevo.Enabled = True
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


        Me.Nombre.Enabled = True
        Me.btn_Guardar.Enabled = True
        'Me.btn_Buscar.Enabled = False
        Me.btn_Eliminar.Enabled = False

        Me.estado_Grabacion = condicionGrabacion.insertar
        Me.Nombre.Focus()
        Me.btn_Nuevo.Enabled = False
    End Sub

    'Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
    '    Dim sql As String = ""
    '    Dim tabla As New DataTable

    '    sql = "SELECT * FROM tipoDocumento WHERE descripcion = " & txt_Nombre.Text
    '    tabla = ejecutosql(sql)
    '    Me.dgv_Tipo_Doc.Rows.Clear()

    '    Dim c As Integer = 0

    '    For c = 0 To tabla.Rows.Count - 1
    '        Me.dgv_Tipo_Doc.Rows.Add()
    '        Me.dgv_Tipo_Doc.Rows(c).Cells("Id_Tipo_Doc").Value = tabla.Rows(c)(0)
    '        Me.dgv_Tipo_Doc.Rows(c).Cells("Nombre_Tipo_Doc").Value = tabla.Rows(c)(1)

    '    Next
    '    Me.btn_Eliminar.Enabled = True
    'End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim sql As String = ""

        If validarDatos() = estadoGrabacion.aprobado Then
            If validarTipoDocuemnto() = estadoGrabacion.rechazado Then
                sql = " DELETE FROM tipoDocumento WHERE idTipoDocumento = " & txt_Id_Tipo_Doc.Text
                MsgBox("Se elimino correctamente el Tipo de Documento ")
            Else
                MsgBox("Cargue correctamente el Tipo de Documento a eliminar")
            End If
        End If

        dbhelper.EjecutarSQL(sql)
        Me.cargar_grilla()
        Nombre.Text = ""
        txt_Id_Tipo_Doc.Text = ""
        btn_Nuevo.Enabled = True
        btn_Eliminar.Enabled = False
        btn_Guardar.Enabled = False
        Nombre.Enabled = False
    End Sub


    Private Sub dgv_Tipo_Doc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tipo_Doc.CellContentClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = " SELECT * FROM tipoDocumento WHERE idTipoDocumento = " & Me.dgv_Tipo_Doc.CurrentRow.Cells("Id_Tipo_Doc").Value

        tabla = dbhelper.ConsultaSQL(sql)

        Me.txt_Id_Tipo_Doc.Text = tabla.Rows(0)("idTipoDocumento")
        Me.Nombre.Text = tabla.Rows(0)("descripcion")



        Me.Nombre.Enabled = True
        btn_Eliminar.Enabled = True
        btn_Guardar.Enabled = True
        btn_Nuevo.Enabled = False
        Me.txt_Id_Tipo_Doc.Enabled = False
        estado_Grabacion = condicionGrabacion.modificar
    End Sub
End Class