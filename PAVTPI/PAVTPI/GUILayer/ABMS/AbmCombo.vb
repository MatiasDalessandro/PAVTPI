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
        strSQL = "select MAX(idCombo) as idCombo from combo"
        Dim numID As Integer = (DBHelper.getDBHelper.ConsultaSQL(strSQL)).Rows(0)("idCombo") + 1

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
        Dim strSql As String = "SELECT ca.idArticuloIntegrante, a.nombre, ca.cantidad,c.nombreCombo,c.precio from comboXArticulo ca "
        strSql &= "inner Join articulo a on a.idArticuloIntegrante = ca.idArticuloIntegrante "
        strSql &= "inner Join combo c on c.idCombo=ca.idCombo "
        strSql &= "where ca.idCombo = " & idCombo


        Try
            Dim tabla As DataTable = DBHelper.getDBHelper().ConsultaSQL(strSql)
            If tabla.Rows.Count = 0 Then
                MsgBox("El combo buscado no existe.")
                Exit Sub
            End If
            txt_id_combo.Text = idCombo
            txt_nombre_combo.Text = tabla.Rows(0)("nombreCombo").ToString
            txt_precio.Text = tabla.Rows(0)("precio")
            If tabla.Rows.Count > 0 Then
                For Each row1 As DataRow In tabla.Rows
                    With row1
                        Me.dgv_datos_articulos.Rows.Add(New String() {
                                                        .Item("idArticuloIntegrante").ToString,
                                                        .Item("nombre").ToString,
                                                        .Item("cantidad").ToString
                                                        })
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
                Dim insert As String = "insert into combo (nombreCombo,precio) values ('" & txt_nombre_combo.Text & "', " & CType(txt_precio.Text, System.Double) & ")"
                DBHelper.getDBHelper.EjecutarSQL(insert)
                For Each rowInsert As DataGridViewRow In dgv_datos_articulos.Rows
                    If strSQL = "" Then
                        strSQL &= "INSERT INTO comboXArticulo (idCombo, idArticuloIntegrante, cantidad) VALUES (" _
                      & txt_id_combo.Text & "," & rowInsert.Cells(0).Value.ToString & "," & rowInsert.Cells(2).Value.ToString & ");"
                    Else
                        strSQL &= vbLf
                        strSQL &= "INSERT INTO comboXArticulo (idCombo,idArticuloIntegrante,cantidad) VALUES (" _
                      & txt_id_combo.Text & "," & rowInsert.Cells(0).Value.ToString & "," & rowInsert.Cells(2).Value.ToString & ");"
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
                    strSQL &= "UPDATE combo set nombreCombo = '" & txt_nombre_combo.Text.ToString & "', precio = " & txt_precio.Text.ToString & " WHERE idCombo =" & txt_id_combo.Text & ";"
                Else
                    strSQL &= vbLf
                    strSQL &= "UPDATE combo set nombreCombo = '" & txt_nombre_combo.Text.ToString & "', precio = " & txt_precio.Text.ToString & " WHERE idCombo =" & txt_id_combo.Text & " ;"
                End If

                For Each rowInsert As DataGridViewRow In dgv_datos_articulos.Rows

                    If strSQL = "" Then

                        strSQL &= "MERGE dbo.comboXArticulo WITH (SERIALIZABLE) AS T "
                        strSQL &= " Using (VALUES(" & txt_id_combo.Text & "," & rowInsert.Cells(0).Value.ToString & ", " & rowInsert.Cells(2).Value.ToString & ")) As U (idCombo,idArticuloIntegrante, cantidad) "
                        strSQL &= " On U.idCombo = T.idCombo And U.idArticuloIntegrante = T.idArticuloIntegrante "
                        strSQL &= " WHEN MATCHED THEN "
                        strSQL &= " Update SET T.cantidad = U.cantidad "
                        strSQL &= " WHEN Not MATCHED THEN "
                        strSQL &= " INSERT(idCombo, idArticuloIntegrante, cantidad) "
                        strSQL &= " VALUES(U.idCombo, U.idArticuloIntegrante, U.cantidad); "
                    Else
                        strSQL &= vbLf
                        strSQL &= "MERGE dbo.comboXArticulo WITH (SERIALIZABLE) AS T "
                        strSQL &= " Using (VALUES(" & txt_id_combo.Text & "," & rowInsert.Cells(0).Value.ToString & ", " & rowInsert.Cells(2).Value.ToString & ")) As U (idCombo,idArticuloIntegrante, cantidad) "
                        strSQL &= " On U.idCombo = T.idCombo And U.idArticuloIntegrante = T.idArticuloIntegrante "
                        strSQL &= " WHEN MATCHED THEN "
                        strSQL &= " Update SET T.cantidad = U.cantidad "
                        strSQL &= " WHEN Not MATCHED THEN "
                        strSQL &= " INSERT(idCombo, idArticuloIntegrante, cantidad) "
                        strSQL &= " VALUES(U.idCombo, U.idArticuloIntegrante, U.cantidad); "
                    End If
                Next
                DBHelper.getDBHelper.EjecutarSQL(strSQL)
                setBuscar()
            End If
        Else
            MsgBox("No es posible insertar el combo.")
        End If
    End Sub

    Private Sub btn_quitar_articulo_Click(sender As Object, e As EventArgs) Handles btn_quitar_articulo.Click
        listadoEleminar.Add(dgv_datos_articulos.CurrentRow.Cells("c_id_articulo").Value.ToString)
        dgv_datos_articulos.Rows.Remove(dgv_datos_articulos.CurrentRow)
    End Sub

    Private Sub dgv_datos_articulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos_articulos.CellClick
        Me.dgv_datos_articulos.CurrentRow.Selected = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = "delete from comboXArticulo where idcombo= " & txt_id_combo.Text
        sql &= vbLf
        sql &= "delete from combo where idCombo = " & txt_id_combo.Text
        DBHelper.getDBHelper.EjecutarSQL(sql)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

End Class