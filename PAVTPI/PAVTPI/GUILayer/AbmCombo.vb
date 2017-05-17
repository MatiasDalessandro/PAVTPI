﻿Public Class AbmCombo
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

    Private Sub setNuevo()
        txt_id_combo.Enabled = False
        txt_id_combo.Text = Nothing

        txt_nombre_articulo.Enabled = True
        txt_nombre_articulo.Text = Nothing

        dgv_datos_articulos.DataSource = Nothing

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
        txt_id_combo.Enabled = True
        txt_id_combo.Text = Nothing

        txt_nombre_articulo.Enabled = False
        txt_nombre_articulo.Text = Nothing

        dgv_datos_articulos.DataSource = Nothing

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
        txt_id_combo.Enabled = False
        txt_nombre_articulo.Enabled = True

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
        txt_id_combo.Enabled = False
        txt_id_combo.Text = Nothing

        txt_nombre_articulo.Enabled = False
        txt_nombre_articulo.Text = Nothing

        dgv_datos_articulos.DataSource = Nothing

        btn_guardar.Enabled = False
        btn_guardar.Visible = False
        btn_buscar.Enabled = False
        btn_buscar.Visible = False
        btn_eliminar.Enabled = False
        btn_eliminar.Visible = False
        btn_salir.Enabled = True

        btn_agregar_articulo.Enabled = True
        btn_agregar_articulo.Visible = True
        btn_quitar_articulo.Enabled = True
        btn_quitar_articulo.Visible = True

        btn_editar_combo.Enabled = False
        btn_editar_combo.Visible = False
    End Sub

    Private Function verificarCampos()
        Dim ret As camposLlenos
        For Each Obj In Me.Controls
            If Obj.GetType.ToString = "System.Windows.Forms.TextBox" Then
                If Obj.Text = "" Then
                    ret = camposLlenos.no
                Else
                    ret = camposLlenos.si
                    Exit For
                End If
            End If
        Next
        Return ret
    End Function

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If verificarCampos() = camposLlenos.no Then
            setNuevo()
            bandera = tipoOperacion.nuevo
        Else
            If MsgBox("Se perderan los cambios. ¿ Desea Continuar ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                setNuevo()
                bandera = tipoOperacion.nuevo
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
        btn_editar_combo.Enabled = True
        btn_editar_combo.Visible = True
        bandera = tipoOperacion.editar
        Dim sql As String = "SELECT A.IdArticulo_Combo, A.NombreCombo, B.IdArticulo_Combo, B.Nombre, B.Precio " _
            & "FROM ComboXArticulo A, Articulo B " _
            & "WHERE A.IdArticuloIntegrante = B.IdArticulo_Combo"
        'dass

    End Sub

    Private Sub btn_agregar_articulo_Click(sender As Object, e As EventArgs) Handles btn_agregar_articulo.Click
        ArticulosParaCombo.ShowDialog()
    End Sub
End Class