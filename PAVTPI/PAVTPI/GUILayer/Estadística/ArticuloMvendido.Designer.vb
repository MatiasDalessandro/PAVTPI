<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloMvendido
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        Me.ArticuloMVendidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloMVendidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ArticuloMVendidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.ArticuloMasVendido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1043, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticuloMvendido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 585)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ArticuloMvendido"
        Me.Text = "ArticuloMvendido"
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloMVendidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
    Friend WithEvents ArticuloMVendidoBindingSource As BindingSource
End Class
