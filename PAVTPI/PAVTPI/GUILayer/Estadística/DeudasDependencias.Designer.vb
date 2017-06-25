<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeudasDependencias
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
        Me.rv_dd = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmd_generarDD = New System.Windows.Forms.Button()
        Me.DeudasDependenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        CType(Me.DeudasDependenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rv_dd
        '
        ReportDataSource1.Name = "DeudasDependenciasDataSet"
        ReportDataSource1.Value = Me.DeudasDependenciasBindingSource
        Me.rv_dd.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_dd.LocalReport.ReportEmbeddedResource = "PAVTPI.DeudasDependencias.rdlc"
        Me.rv_dd.Location = New System.Drawing.Point(12, 46)
        Me.rv_dd.Name = "rv_dd"
        Me.rv_dd.Size = New System.Drawing.Size(950, 650)
        Me.rv_dd.TabIndex = 0
        '
        'cmd_generarDD
        '
        Me.cmd_generarDD.Location = New System.Drawing.Point(12, 13)
        Me.cmd_generarDD.Name = "cmd_generarDD"
        Me.cmd_generarDD.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generarDD.TabIndex = 1
        Me.cmd_generarDD.Text = "Generar"
        Me.cmd_generarDD.UseVisualStyleBackColor = True
        '
        'DeudasDependenciasBindingSource
        '
        Me.DeudasDependenciasBindingSource.DataMember = "DeudasDependencias"
        Me.DeudasDependenciasBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeudasDependencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 709)
        Me.Controls.Add(Me.cmd_generarDD)
        Me.Controls.Add(Me.rv_dd)
        Me.Name = "DeudasDependencias"
        Me.Text = "DeudasDependencias"
        CType(Me.DeudasDependenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rv_dd As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmd_generarDD As Button
    Friend WithEvents DeudasDependenciasBindingSource As BindingSource
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
End Class
