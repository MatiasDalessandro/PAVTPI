Public Class ArticulosParaCombo
    Private Sub ArticulosParaCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrilla()
    End Sub

    Private Sub btn_agregarACombo_Click(sender As Object, e As EventArgs) Handles btn_agregarACombo.Click
        AbmCombo.dgv_datos_articulos.Rows.Add(Me.dgv_datos_articulos.CurrentRow)
    End Sub

    Private Sub llenarGrilla()
        Dim strSQL As String = "SELECT * FROM articulo"
        For Each row As DataRow In DBHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            Me.dgv_datos_articulos.Rows.Add(row)
            'fafsa
        Next
    End Sub

End Class