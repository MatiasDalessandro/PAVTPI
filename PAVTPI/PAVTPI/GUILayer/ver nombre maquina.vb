Public Class ver_nombre_maquina
    Private Sub ver_nombre_maquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nomMaquina.Text = My.Computer.Name.ToString
    End Sub
End Class