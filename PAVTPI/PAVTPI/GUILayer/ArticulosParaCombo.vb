Public Class ArticulosParaCombo
    Private Sub ArticulosParaCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrilla()
    End Sub

    Private Sub btn_agregarACombo_Click(sender As Object, e As EventArgs) Handles btn_agregarACombo.Click
        If (dgv_datos_articulos.SelectedRows.Count > 0) Then
            AbmCombo.dgv_datos_articulos.Rows.Add(Me.dgv_datos_articulos.CurrentRow)
        End If
    End Sub

    Private Sub llenarGrilla()
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
End Class