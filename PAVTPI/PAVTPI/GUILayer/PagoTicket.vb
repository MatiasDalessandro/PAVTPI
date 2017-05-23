Public Class PagoTicket
    Dim dbHelper As DBHelper = DBHelper.getDBHelper

    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable, ByVal pk As String, ByVal descriptor As String)


    End Sub

    Private Sub btn_buscarArticulo_Click(sender As Object, e As EventArgs) Handles btn_buscarArticulo.Click
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM articulo WHERE idArticuloCombo= " & txt_articulo.Text
        tabla = dbHelper.ConsultaSQL(sql)

    End Sub

    Private Sub cargar_listBox_articulo()
        Dim dt As New DataTable
        dt = dbHelper.ConsultaSQL("SELECT * FROM articulo")
        With lbox_articulo
            .DataSource = dt
            .DisplayMember = "nombre"
            .ValueMember = "idArticuloCombo"
        End With

    End Sub
    Private Sub cargar_listbox_combo()
        Dim dt As DataTable = dbHelper.ConsultaSQL("SELECT * FROM comboXArticulo")
        With lbox_combo
            .DataSource = dt
            .DisplayMember = "nombreCombo"
            .ValueMember = "idArticuloIntegrante"
        End With
    End Sub

    Private Sub PagoTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_listBox_articulo()
    End Sub
End Class