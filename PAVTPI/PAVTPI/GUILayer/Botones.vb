Public Class Botones
    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        AbmEmpleado.Show()
        Me.Close()
    End Sub
    Private Sub btnPersAut_Click(sender As Object, e As EventArgs) Handles btnPersAut.Click
        AbmPersonaAutorizada.Show()
        Me.Close()
    End Sub
End Class