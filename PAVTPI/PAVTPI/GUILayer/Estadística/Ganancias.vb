Public Class ganancias
    Private Sub Ganancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If chk_mes.Checked Then
            cmb_mes.Enabled = False
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub cargar_combo()
        cmb_mes.Items.Add("Enero")
        cmb_mes.Items.Add("Febrero")
        cmb_mes.Items.Add("Marzo")
        cmb_mes.Items.Add("Abril")
        cmb_mes.Items.Add("Mayo")
        cmb_mes.Items.Add("Junio")
        cmb_mes.Items.Add("Julio")
        cmb_mes.Items.Add("Agosto")
        cmb_mes.Items.Add("Septiembre")
        cmb_mes.Items.Add("Octubre")
        cmb_mes.Items.Add("Noviembre")
        cmb_mes.Items.Add("Diciembre")
    End Sub

    Private Sub chk_mes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mes.CheckedChanged
        If chk_mes.Checked Then
            lbl.Visible = True
            cmb_mes.Visible = True
            btn_calcular.Location = New Point(311, 6)
        End If
        If Not chk_mes.Checked Then
            lbl.Visible = False
            cmb_mes.Visible = False
            btn_calcular.Location = New Point(173, 6)
        End If
    End Sub
End Class