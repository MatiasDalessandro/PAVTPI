<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloMasVendido
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
        Me.rv_amv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmd_generarArticuloMasVendido = New System.Windows.Forms.Button()
        Me.ArticuloMasVendidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        CType(Me.ArticuloMasVendidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rv_amv
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ArticuloMasVendidoBindingSource
        Me.rv_amv.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_amv.LocalReport.ReportEmbeddedResource = "PAVTPI.ArticuloMasVendido.rdlc"
        Me.rv_amv.Location = New System.Drawing.Point(12, 64)
        Me.rv_amv.Name = "rv_amv"
        Me.rv_amv.Size = New System.Drawing.Size(1003, 409)
        Me.rv_amv.TabIndex = 0
        '
        'cmd_generarArticuloMasVendido
        '
        Me.cmd_generarArticuloMasVendido.Location = New System.Drawing.Point(41, 13)
        Me.cmd_generarArticuloMasVendido.Name = "cmd_generarArticuloMasVendido"
        Me.cmd_generarArticuloMasVendido.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generarArticuloMasVendido.TabIndex = 1
        Me.cmd_generarArticuloMasVendido.Text = "Generar"
        Me.cmd_generarArticuloMasVendido.UseVisualStyleBackColor = True
        '
        'ArticuloMasVendidoBindingSource
        '
        Me.ArticuloMasVendidoBindingSource.DataMember = "ArticuloMasVendido"
        Me.ArticuloMasVendidoBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticuloMasVendido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 485)
        Me.Controls.Add(Me.cmd_generarArticuloMasVendido)
        Me.Controls.Add(Me.rv_amv)
        Me.Name = "ArticuloMasVendido"
        Me.Text = "ArticuloMasVendido"
        CType(Me.ArticuloMasVendidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rv_amv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmd_generarArticuloMasVendido As Button
    Friend WithEvents ArticuloMasVendidoBindingSource As BindingSource
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
End Class
