Public Class AbmProvincia

    Private Sub AbmProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarNuevo()
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_idProvincia.Text = Nothing
        txt_nomProvincia.Text = Nothing
    End Sub

    Private Sub iniciarNuevo()
        btn_editar.Enabled = False
        btn_guardar.Enabled = False
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Not ((txt_idProvincia.Text = "") Or (txt_nomProvincia.Text = "")) Then
            Dim str As String = 
        End If
    End Sub

    Private Function validarId(ByVal id As String) As Boolean
        Dim rtn As Boolean = False
        Dim str As String = "SELECT id_provincia FROM provincias where id_provincia = " + id
        Return rtn
    End Function
End Class