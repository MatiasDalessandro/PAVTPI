Public Class ArticulosParaCombo
    Private Sub ArticulosParaCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrilla()
        If dgv_datos_articulos.Rows.Count > 0 Then
            Me.dgv_datos_articulos.CurrentRow.Selected = True
        End If
    End Sub

    Private Sub btn_agregarACombo_Click(sender As Object, e As EventArgs) Handles btn_agregarACombo.Click
        If (dgv_datos_articulos.SelectedRows.Count > 0) Then
            Dim row1 As DataGridViewRow = Me.dgv_datos_articulos.CurrentRow
            Dim defaultvalue As String = "0"
            Dim cantidada As String = InputBox("cantidad", "", defaultvalue)

            If cantidada = "" Then
                cantidada = defaultvalue
            End If

            With row1
                AbmCombo.dgv_datos_articulos.Rows.Add(New String() {
                                                        .Cells("id_articulo").Value.ToString,
                                                        .Cells("nombre_articulo").Value.ToString,
                                                        .Cells("precio_articulo").Value.ToString,
                                                        cantidada.ToString
                                                        })
            End With
        End If
    End Sub

    Private Sub llenarGrilla()
        dgv_datos_articulos.DataSource = Nothing
        Dim strSQL As String = "SELECT * FROM articulo"
        Try
            Dim tabla As DataTable = DBHelper.getDBHelper().ConsultaSQL(strSQL)
            If tabla.Rows.Count > 0 Then
                For Each row1 As DataRow In tabla.Rows
                    With row1
                        Me.dgv_datos_articulos.Rows.Add(New String() {
                                                        .Item("idArticuloIntegrante").ToString,
                                                        .Item("nombre").ToString,
                                                        .Item("precio").ToString
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

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub dgv_datos_articulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos_articulos.CellClick
        Me.dgv_datos_articulos.CurrentRow.Selected = True
    End Sub
End Class