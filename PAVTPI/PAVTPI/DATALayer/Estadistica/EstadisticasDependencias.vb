Partial Class EstadisticasDependencias
    Partial Public Class ArticuloMasVendidoDataTable
        Private Sub ArticuloMasVendidoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Public Class PrecioArticulosDataTable
        Private Sub PrecioArticulosDataTable_PrecioArticulosRowChanging(sender As Object, e As PrecioArticulosRowChangeEvent) Handles Me.PrecioArticulosRowChanging

        End Sub

    End Class

    Partial Public Class DeudasDependenciasDataTable
        Private Sub DeudasDependenciasDataTable_DeudasDependenciasRowChanging(sender As Object, e As DeudasDependenciasRowChangeEvent) Handles Me.DeudasDependenciasRowChanging

        End Sub

    End Class
End Class
