Public Class AbmCombo
    Enum camposLlenos
        si
        no
    End Enum
    Private Sub AbmCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setNuevo()
    End Sub

    Private Sub setNuevo()
        txt_id_combo.Enabled = False
        txt_id_combo.Text = Nothing

        txt_nombre_articulo.Enabled = True
        txt_nombre_articulo.Text = Nothing

        btn_guardar.Enabled = True
        btn_buscar.Enabled = False
        btn_buscar.Visible = False
        btn_eliminar.Enabled = True
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

        btn_guardar.Enabled = False
        btn_buscar.Enabled = True
        btn_buscar.Visible = True
        btn_eliminar.Enabled = True
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
        btn_eliminar.Enabled = True
        btn_salir.Enabled = True
        btn_agregar_articulo.Enabled = True
        btn_agregar_articulo.Visible = True
        btn_quitar_articulo.Enabled = True
        btn_quitar_articulo.Visible = True

        btn_editar_combo.Visible = False
        btn_editar_combo.Enabled = False

    End Sub

    Private Function verificarCampos()
        Dim ret As camposLlenos
        For Each Obj In Me.Controls
            If Trim(Obj.Text) = "" Then
                ret = camposLlenos.no
            Else
                ret = camposLlenos.si
                Exit For
            End If
        Next
        Return ret
    End Function

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        setNuevo()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        setBuscar()
    End Sub
End Class