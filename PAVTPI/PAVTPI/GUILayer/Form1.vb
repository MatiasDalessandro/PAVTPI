Public Class Form1


    Private Sub ABMEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMEmpleadoToolStripMenuItem.Click
        AbmPersona.Show()
    End Sub
    Private Sub ABMTipoDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTipoDocumentoToolStripMenuItem.Click
        AbmTipoDocumento.Show()
    End Sub
    Private Sub ABMArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMArticuloToolStripMenuItem.Click
        AbmArticulo.Show()
    End Sub

    Private Sub ABMRolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMRolToolStripMenuItem.Click
        AbmRol.Show()
    End Sub

    Private Sub ABMDependenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMDependenciaToolStripMenuItem.Click
        cmd_cancelar.Show()
    End Sub
    Private Sub ABMComboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMComboToolStripMenuItem.Click
        AbmCombo.Show()
    End Sub

    'Private Sub ABMToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    '    AbmPersonaAutorizada.Show()
    'End Sub

    'Private Sub VerNombreMaquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerNombreMaquinaToolStripMenuItem.Click
    '    ver_nombre_maquina.Show()
    'End Sub

    Private Sub CargarPersonaAutorizadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarPersonaAutorizadaToolStripMenuItem.Click
        PersonaXDependencia.Show()
    End Sub

    Private Sub RegistrarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVentaToolStripMenuItem.Click
        Venta.Show()
    End Sub

    Private Sub CancelarSaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarSaldoToolStripMenuItem.Click
        PagoXCuentaCorriente.Show()
    End Sub

    Private Sub VentasPorPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorPeríodoToolStripMenuItem.Click
        Ventas_por_período.Show()
    End Sub

    Private Sub ResumenPorCuentaCorrienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenPorCuentaCorrienteToolStripMenuItem.Click
        Resumen_Cta_Cte.Show()
    End Sub

    Private Sub ReporteVentasPorHoraPicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasPorHoraPicoToolStripMenuItem.Click
        ReporteVentasPorHoraPico.Show()
    End Sub

    Private Sub ResumenDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeArticulosToolStripMenuItem.Click
        resumenArticulo.Show()
    End Sub

    Private Sub ReportePersonasPorDependenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePersonasPorDependenciaToolStripMenuItem.Click
        ReportePersonasXDependencia.Show()
    End Sub

    Private Sub DeudasDependenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudasDependenciasToolStripMenuItem.Click
        DeudasDependencias.Show()
    End Sub

    Private Sub CantTicketsPorDependenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantTicketsPorDependenciasToolStripMenuItem.Click
        CanTicketDependencias.Show()
    End Sub

    Private Sub PrecioArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrecioArtículosToolStripMenuItem.Click
        PrecioArticulo.Show()
    End Sub

    Private Sub ArtículosMasVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosMasVendidosToolStripMenuItem.Click
        ArticuloMvendido.Show()
    End Sub

    Private Sub ReporteEmpleadosPorTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteEmpleadosPorTurnosToolStripMenuItem.Click
        EmpleadoMayorTurno.Show()
    End Sub

    Private Sub PorcentajeDeAsistenciaMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcentajeDeAsistenciaMensualToolStripMenuItem.Click
        AsistMensual.Show()
    End Sub

    Private Sub CargarAsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarAsistenciaToolStripMenuItem.Click
        Asistencia.Show()
    End Sub
End Class
