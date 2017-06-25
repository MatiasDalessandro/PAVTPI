<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CanTicketDependencias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CanTicketDependenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        Me.rv_ctd = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmd_generarCantTicketDependencias = New System.Windows.Forms.Button()
        CType(Me.CanTicketDependenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CanTicketDependenciasBindingSource
        '
        Me.CanTicketDependenciasBindingSource.DataMember = "CanTicketDependencias"
        Me.CanTicketDependenciasBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv_ctd
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CanTicketDependenciasBindingSource
        Me.rv_ctd.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_ctd.LocalReport.ReportEmbeddedResource = "PAVTPI.CanTicketDependencias.rdlc"
        Me.rv_ctd.Location = New System.Drawing.Point(13, 53)
        Me.rv_ctd.Name = "rv_ctd"
        Me.rv_ctd.Size = New System.Drawing.Size(923, 602)
        Me.rv_ctd.TabIndex = 0
        '
        'cmd_generarCantTicketDependencias
        '
        Me.cmd_generarCantTicketDependencias.Location = New System.Drawing.Point(13, 13)
        Me.cmd_generarCantTicketDependencias.Name = "cmd_generarCantTicketDependencias"
        Me.cmd_generarCantTicketDependencias.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generarCantTicketDependencias.TabIndex = 1
        Me.cmd_generarCantTicketDependencias.Text = "Generar"
        Me.cmd_generarCantTicketDependencias.UseVisualStyleBackColor = True
        '
        'CanTicketDependencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 665)
        Me.Controls.Add(Me.cmd_generarCantTicketDependencias)
        Me.Controls.Add(Me.rv_ctd)
        Me.Name = "CanTicketDependencias"
        Me.Text = "CanTicketDependencias"
        CType(Me.CanTicketDependenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rv_ctd As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmd_generarCantTicketDependencias As Button
    Friend WithEvents CanTicketDependenciasBindingSource As BindingSource
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
End Class
