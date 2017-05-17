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

        txt_precio.Enabled = True
        txt_precio.Text = Nothing

        txt_precio_sugerido.Enabled = False
        txt_precio_sugerido.Text = Nothing


        btn_agregar_articulo.Enabled = True
        btn_quitar_articulo.Enabled = True

        btn_nuevo.Enabled = True
        btn_guardar.Enabled = True
        btn_buscar.Enabled = True
        btn_eliminar.Enabled = True
        btn_salir.Enabled = True

        btn_editar_combo.Enabled = False
        btn_editar_combo.Visible = False
    End Sub

    Private Sub setBuscar()

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
End Class