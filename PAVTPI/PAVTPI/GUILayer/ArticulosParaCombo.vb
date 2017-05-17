Public Class ArticulosParaCombo
    Private Sub ArticulosParaCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row1 As New DataGridViewRow
        AbmCombo.dgv_datos_articulos.Rows.Add(row1)
    End Sub
End Class