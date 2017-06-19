<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentasPorHoraPico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ticketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConjuntoDatos = New PAVTPI.ConjuntoDatos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmd_generarReporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtb_horaInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtb_horaFin = New System.Windows.Forms.MaskedTextBox()
        CType(Me.ticketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConjuntoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ticketBindingSource
        '
        Me.ticketBindingSource.DataMember = "ticket"
        Me.ticketBindingSource.DataSource = Me.ConjuntoDatos
        '
        'ConjuntoDatos
        '
        Me.ConjuntoDatos.DataSetName = "ConjuntoDatos"
        Me.ConjuntoDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ticketBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.ReporteVentaPorHoraPico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(814, 460)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmd_generarReporte
        '
        Me.cmd_generarReporte.Location = New System.Drawing.Point(166, 11)
        Me.cmd_generarReporte.Name = "cmd_generarReporte"
        Me.cmd_generarReporte.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generarReporte.TabIndex = 1
        Me.cmd_generarReporte.Text = "Generar"
        Me.cmd_generarReporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hora Inicio"
        '
        'mtb_horaInicio
        '
        Me.mtb_horaInicio.Location = New System.Drawing.Point(69, 12)
        Me.mtb_horaInicio.Mask = "00"
        Me.mtb_horaInicio.Name = "mtb_horaInicio"
        Me.mtb_horaInicio.Size = New System.Drawing.Size(21, 20)
        Me.mtb_horaInicio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hora Fin"
        '
        'mtb_horaFin
        '
        Me.mtb_horaFin.Location = New System.Drawing.Point(139, 12)
        Me.mtb_horaFin.Mask = "00"
        Me.mtb_horaFin.Name = "mtb_horaFin"
        Me.mtb_horaFin.Size = New System.Drawing.Size(21, 20)
        Me.mtb_horaFin.TabIndex = 3
        '
        'ReporteVentasPorHoraPico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 510)
        Me.Controls.Add(Me.mtb_horaFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtb_horaInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_generarReporte)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteVentasPorHoraPico"
        Me.Text = "ReporteVentasPorHoraPico"
        CType(Me.ticketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConjuntoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmd_generarReporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents mtb_horaInicio As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtb_horaFin As MaskedTextBox
    Friend WithEvents ticketBindingSource As BindingSource
    Friend WithEvents ConjuntoDatos As ConjuntoDatos
End Class
