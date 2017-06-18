Public Class AbmCombo
    Private bandera As tipoOperacion
    Enum tipoOperacion
        nuevo
        editar
    End Enum
    Enum camposLlenos
        si
        no
    End Enum
    Private Sub AbmCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setLoad()
    End Sub

    Private listadoEleminar As List(Of String)

    Private Sub setNuevo()
        bandera = tipoOperacion.nuevo

        dgv_datos_articulos.DataSource = Nothing

        Dim strSQL As String = ""
        strSQL = "select MAX(idCombo)  from combo"
        Dim numID As Integer = (DBHelper.getDBHelper.ConsultaSQL(strSQL).Rows.Count + 1)

        txt_id_combo.Enabled = False
        txt_id_combo.Text = numID.ToString

        txt_nombre_combo.Enabled = True
        txt_nombre_combo.Text = Nothing

        txt_precio.Enabled = True
        txt_precio.Text = Nothing

        dgv_datos_articulos.DataSource = Nothing
        dgv_datos_articulos.Rows.Clear()

        btn_guardar.Enabled = True
        btn_guardar.Visible = True
        btn_buscar.Enabled = False
        btn_buscar.Visible = False
        btn_eliminar.Enabled = True
        btn_eliminar.Visible = True
        btn_salir.Enabled = True

        btn_agregar_articulo.Enabled = True
        btn_agregar_articulo.Visible = True
        btn_quitar_articulo.Enabled = True
        btn_quitar_articulo.Visible = True

        btn_editar_combo.Enabled = False
        btn_editar_combo.Visible = False



    End Sub

    Private Sub setBuscar()

        dgv_datos_articulos.DataSource = Nothing

        txt_id_combo.Enabled = True
        txt_id_combo.Text = Nothing

        txt_nombre_combo.Enabled = False
        txt_nombre_combo.Text = Nothing

        txt_precio.Enabled = False
        txt_precio.Text = Nothing

        dgv_datos_articulos.DataSource = Nothing
        dgv_datos_articulos.Rows.Clear()

        btn_guardar.Enabled = False
        btn_guardar.Visible = False
        btn_buscar.Enabled = True
        btn_buscar.Visible = True
        btn_eliminar.Enabled = True
        btn_eliminar.Visible = True
        btn_salir.Enabled = True

        btn_agregar_articulo.Enabled = False
        btn_agregar_articulo.Visible = False
        btn_quitar_articulo.Enabled = False
        btn_quitar_articulo.Visible = False

        btn_editar_combo.Enabled = False
        btn_editar_combo.Visible = True
    End Sub

    Private Sub setEdit()
        listadoEleminar = New List(Of String)

        bandera = tipoOperacion.editar

        txt_id_combo.Enabled = False
        txt_nombre_combo.Enabled = True
        txt_precio.Enabled = True

        btn_buscar.Enabled = False
        btn_buscar.Visible = False

        btn_guardar.Enabled = True
        btn_guardar.Visible = True
        btn_eliminar.Enabled = True
        btn_eliminar.Visible = True
        btn_salir.Enabled = True
        btn_agregar_articulo.Enabled = True
        btn_agregar_articulo.Visible = True
        btn_quitar_articulo.Enabled = True
        btn_quitar_articulo.Visible = True

        btn_editar_combo.Visible = False
        btn_editar_combo.Enabled = False

    End Sub

    Private Sub setLoad()

        dgv_datos_articulos.DataSource = Nothing
        dgv_datos_articulos.Rows.Clear()

        txt_id_combo.Enabled = False
        txt_id_combo.Text = Nothing

        txt_nombre_combo.Enabled = False
        txt_nombre_combo.Text = Nothing

        txt_precio.Enabled = False
        txt_precio.Text = Nothing

        dgv_datos_articulos.DataSource = Nothing

        btn_guardar.Enabled = False
        btn_guardar.Visible = False
        btn_buscar.Enabled = False
        btn_buscar.Visible = False
        btn_eliminar.Enabled = False
        btn_eliminar.Visible = False
        btn_salir.Enabled = True

        btn_agregar_articulo.Enabled = False
        btn_agregar_articulo.Visible = False
        btn_quitar_articulo.Enabled = False
        btn_quitar_articulo.Visible = False

        btn_editar_combo.Enabled = False
        btn_editar_combo.Visible = False
    End Sub

    Private Function verificarCampos()
        Dim ret As camposLlenos
        For Each Obj In Me.Controls
            If Obj.GetType.ToString = "System.Windows.Forms.TextBox" Then
                If Not (Obj.Equals(txt_id_combo)) Then
                    If Obj.Text = "" Then
                        ret = camposLlenos.no
                    Else
                        ret = camposLlenos.si
                        Exit For
                    End If
                End If
            End If
        Next
        If dgv_datos_articulos.Rows.Count = 0 Then
            ret = camposLlenos.no
        End If
        Return ret
    End Function

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If verificarCampos() = camposLlenos.no Then
            setNuevo()
        Else
            If MsgBox("Se perderan los cambios. ¿ Desea Continuar ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                setNuevo()
            End If
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        If verificarCampos() = camposLlenos.no Then
            setBuscar()
        Else
            If MsgBox("Se perderan los cambios. ¿ Desea Continuar ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                setBuscar()
            End If
        End If
    End Sub

    Private Sub btn_editar_combo_Click(sender As Object, e As EventArgs) Handles btn_editar_combo.Click
        setEdit()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim idCom As String = txt_id_combo.Text.ToString
        setBuscar()

        btn_editar_combo.Enabled = True
        btn_editar_combo.Visible = True

        llenarGrilla(idCom)

    End Sub

    Private Sub llenarGrilla(ByVal idCombo As String)
        Dim strSql As String = "SELECT A.idCombo, A.nombreCombo, B.idArticuloIntegrante, B.nombre, A.cantidad, A.precio " _
            & "FROM comboXArticulo A, articulo B " _
            & "WHERE A.idArticuloIntegrante = B.idArticuloIntegrante AND idCombo = " & idCombo

        Try
            Dim tabla As DataTable = DBHelper.getDBHelper().ConsultaSQL(strSql)
            If tabla.Rows.Count > 0 Then
                For Each row1 As DataRow In tabla.Rows
                    With row1
                        Me.dgv_datos_articulos.Rows.Add(New String() {
                                                        .Item("idArticuloIntegrante").ToString,
                                                        .Item("nombre").ToString,
                                                        .Item("cantidad").ToString
                                                        })
                        txt_id_combo.Text = .Item("idCombo").ToString
                        txt_nombre_combo.Text = .Item("nombreCombo").ToString
                        txt_precio.Text = .Item("precio")

                    End With
                Next
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MsgBox("No se puede cargar el listado de articulos")
        End Try
    End Sub

    Private Sub btn_agregar_articulo_Click(sender As Object, e As EventArgs) Handles btn_agregar_articulo.Click
        ArticulosParaCombo.ShowDialog()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If verificarCampos() = camposLlenos.si Then
            Dim strSQL As String = ""
            If bandera = tipoOperacion.nuevo Then

                For Each rowInsert As DataGridViewRow In dgv_datos_articulos.Rows
                    If strSQL = "" Then
                        strSQL &= "INSERT INTO comboXArticulo (idCombo, nombreCombo, idArticuloIntegrante, cantidad, precio) VALUES (" _
                      & txt_id_combo.Text & ",'" & txt_nombre_combo.Text & "'," & rowInsert.Cells(0).Value.ToString & "," & rowInsert.Cells(2).Value.ToString & "," & txt_precio.Text.ToString & ");"
                    Else
                        strSQL &= vbLf
                        strSQL &= "INSERT INTO comboXArticulo (idCombo,nombreCombo,idArticuloIntegrante,cantidad,precio) VALUES (" _
                      & txt_id_combo.Text & ",'" & txt_nombre_combo.Text & "'," & rowInsert.Cells(0).Value.ToString & "," & rowInsert.Cells(2).Value.ToString & "," & txt_precio.Text.ToString & ");"
                    End If
                Next

                DBHelper.getDBHelper.EjecutarSQL(strSQL)
                setNuevo()
            Else

                For Each idArticuloEliminar As String In listadoEleminar
                    If strSQL = "" Then
                        strSQL &= "DELETE FROM comboXArticulo WHERE idCombo = " & txt_id_combo.Text.ToString & " AND " _
                            & " idArticuloIntegrante = " & idArticuloEliminar.ToString
                    Else
                        strSQL &= vbLf
                        strSQL &= "DELETE FROM comboXArticulo WHERE idCombo = " & txt_id_combo.Text.ToString & " AND " _
                            & " idArticuloIntegrante = " & idArticuloEliminar.ToString
                    End If
                Next

                If strSQL = "" Then
                    strSQL &= "UPDATE comboXArticulo set nombreCombo = " & txt_nombre_combo.Text.ToString & ", precio = " & txt_precio.Text.ToString & "WHERE idCombo = 1;"
                Else
                    strSQL &= vbLf
                    strSQL &= "UPDATE comboXArticulo set nombreCombo = " & txt_nombre_combo.Text.ToString & ", precio = " & txt_precio.Text.ToString & "WHERE idCombo = 1;"
                End If

                For Each rowInsert As DataGridViewRow In dgv_datos_articulos.Rows
                    If strSQL = "" Then
                        strSQL &= "INSERT INTO comboXArticulo (idCombo,nombreCombo,idArticuloIntegrante,cantidad,precio) VALUES (" _
                      & txt_id_combo.Text & ",'" & txt_nombre_combo.Text & "'," & rowInsert.Cells(0).Value.ToString & "," & rowInsert.Cells(2).Value.ToString & "," & txt_precio.Text.ToString & ");"
                    Else
                        strSQL &= vbLf
                        strSQL &= "INSERT INTO comboXArticulo (idCombo,nombreCombo,idArticuloIntegrante,cantidad,precio) VALUES (" _
                      & txt_id_combo.Text & ",'" & txt_nombre_combo.Text & "'," & rowInsert.Cells(0).Value.ToString & "," & rowInsert.Cells(2).Value.ToString & "," & txt_precio.Text.ToString & ");"
                    End If
                Next

                DBHelper.getDBHelper.EjecutarSQL(strSQL)
                setBuscar()

            End If
        End If
    End Sub

    Private Sub btn_quitar_articulo_Click(sender As Object, e As EventArgs) Handles btn_quitar_articulo.Click
        listadoEleminar.Add(dgv_datos_articulos.CurrentRow.Cells("idArticuloIntegrante").Value.ToString)
        dgv_datos_articulos.Rows.Remove(dgv_datos_articulos.CurrentRow)
    End Sub

    Private Sub dgv_datos_articulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos_articulos.CellClick
        Me.dgv_datos_articulos.CurrentRow.Selected = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        setNuevo()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class