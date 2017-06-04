Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ABMEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMEmpleadoToolStripMenuItem.Click
        AbmPersona.Show()
    End Sub
    Private Sub ABMTipoDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTipoDocumentoToolStripMenuItem.Click
        AbmTipoDocumento.Show()
    End Sub

    Private Sub ABMBarrioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbmBarrio.Show()
    End Sub

    Private Sub ABMArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMArticuloToolStripMenuItem.Click
        AbmArticulo.Show()
    End Sub

    Private Sub ABMRolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMRolToolStripMenuItem.Click
        AbmRol.Show()
    End Sub

    Private Sub ABMDependenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMDependenciaToolStripMenuItem.Click
        AbmDependencia.Show()
    End Sub

    Private Sub ABMLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbmLocalidad.Show()
    End Sub

    Private Sub ABMProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbmProvincia.Show()
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
End Class
