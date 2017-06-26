<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrecioArticulo
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
        Me.PrecioArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        Me.cmd_generarPrecioArticulos = New System.Windows.Forms.Button()
        Me.rv_pa = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.PrecioArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrecioArticulosBindingSource
        '
        Me.PrecioArticulosBindingSource.DataMember = "PrecioArticulos"
        Me.PrecioArticulosBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmd_generarPrecioArticulos
        '
        Me.cmd_generarPrecioArticulos.Location = New System.Drawing.Point(12, 10)
        Me.cmd_generarPrecioArticulos.Name = "cmd_generarPrecioArticulos"
        Me.cmd_generarPrecioArticulos.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generarPrecioArticulos.TabIndex = 3
        Me.cmd_generarPrecioArticulos.Text = "Generar"
        Me.cmd_generarPrecioArticulos.UseVisualStyleBackColor = True
        '
        'rv_pa
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PrecioArticulosBindingSource
        Me.rv_pa.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_pa.LocalReport.ReportEmbeddedResource = "PAVTPI.PrecioArticulos.rdlc"
        Me.rv_pa.Location = New System.Drawing.Point(12, 50)
        Me.rv_pa.Name = "rv_pa"
        Me.rv_pa.Size = New System.Drawing.Size(923, 602)
        Me.rv_pa.TabIndex = 2
        '
        'PrecioArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 659)
        Me.Controls.Add(Me.cmd_generarPrecioArticulos)
        Me.Controls.Add(Me.rv_pa)
        Me.Name = "PrecioArticulo"
        Me.Text = "PrecioArticulo"
        CType(Me.PrecioArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_generarPrecioArticulos As Button
    Friend WithEvents rv_pa As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrecioArticulosBindingSource As BindingSource
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
End Class
