Public Class formGanancias
    Dim dbheleper As DBHelper = DBHelper.getDBHelper
    Private Sub ganancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Sub historico_CheckedChanged(sender As Object, e As EventArgs) Handles historico.CheckedChanged, anual.CheckedChanged
        If anual.Checked Then
            lbl2.Visible = True
            txt_año.Visible = True
        End If
        If Not anual.Checked Then
            lbl2.Visible = False
            txt_año.Visible = False
        End If
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        If anual.Checked Then
            Dim sql As String = "select * from ticket where year(fechaHora)= " & txt_año.Text
            Dim tabla As DataTable = dbheleper.ConsultaSQL(sql)
            If Not tabla.Rows.Count = 0 Then
                Size = New System.Drawing.Size(400, 565)
                ReportViewer1.Visible = True
                Dim sql2 As String = ""
                sql2 &= "select sum(t.monto) as total,DATENAME(MM,t.fechaHora) as mes,year(t.fechaHora) as año from ticket t"
                If anual.Checked Then
                    sql2 &= " where Year(t.fechaHora) = " & txt_año.Text
                End If
                sql2 &= " group by DATENAME(MM,t.fechaHora),year(t.fechaHora)"
                sql2 &= " order by DATENAME(MM,t.fechaHora)"

                GananciasBindingSource.DataSource = dbheleper.ConsultaSQL(sql2)
                ReportViewer1.RefreshReport()
            Else
                anual.Checked = False
                txt_año.Text = ""
                MsgBox("No existen ventas registradas para ese año.")
                Exit Sub
            End If
        End If
        If historico.Checked Then
            Size = New System.Drawing.Size(400, 565)
            ReportViewer2.Visible = True
            Dim sql As String = ""
            sql &= "select sum(t.monto) as total,year(t.fechaHora) as año from ticket t group by year(t.fechaHora) order by year(t.fechaHora)"
            GananciasHistoricasBindingSource.DataSource = dbheleper.ConsultaSQL(sql)
            ReportViewer2.RefreshReport()
        End If
    End Sub
End Class