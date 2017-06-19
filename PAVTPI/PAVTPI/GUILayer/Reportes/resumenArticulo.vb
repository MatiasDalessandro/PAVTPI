Public Class resumenArticulo
    Dim dbhelper As DBHelper = DBHelper.getDBHelper
    Private Sub resumenArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim tabla As DataTable
        Dim sql As String = ""


        If Me.txtPI.Text = "" Or Me.txtPF.Text = "" Then
            sql = "select * from articulo"

            tabla = dbhelper.ConsultaSQL(sql)

            resumenArticulosBindingSource.DataSource = tabla
            ReportViewer1.RefreshReport()
        Else
            If Convert.ToInt32(Me.txtPI.Text) > Convert.ToInt32(Me.txtPF.Text) Then
                MsgBox("Ingrese correctamente los precios")
            Else
                sql = "select * from articulo where articulo.precio between " & txtPI.Text & " and " & txtPF.Text

                tabla = dbhelper.ConsultaSQL(sql)

                resumenArticulosBindingSource.DataSource = tabla
                ReportViewer1.RefreshReport()
            End If


        End If

    End Sub
End Class