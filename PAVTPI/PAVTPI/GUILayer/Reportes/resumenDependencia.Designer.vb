<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resumenDependencia
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
        Me.rv_resumenDep = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btn_buscardep = New System.Windows.Forms.Button()
        Me.DataSetResumenCtaCte = New PAVTPI.DataSetResumenCtaCte()
        Me.resumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rv_resumenDep
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.resumenBindingSource
        Me.rv_resumenDep.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_resumenDep.LocalReport.ReportEmbeddedResource = "PAVTPI.ReporteCtaCte.rdlc"
        Me.rv_resumenDep.Location = New System.Drawing.Point(12, 46)
        Me.rv_resumenDep.Name = "rv_resumenDep"
        Me.rv_resumenDep.Size = New System.Drawing.Size(858, 419)
        Me.rv_resumenDep.TabIndex = 0
        '
        'btn_buscardep
        '
        Me.btn_buscardep.Location = New System.Drawing.Point(12, 12)
        Me.btn_buscardep.Name = "btn_buscardep"
        Me.btn_buscardep.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscardep.TabIndex = 1
        Me.btn_buscardep.Text = "Buscar"
        Me.btn_buscardep.UseVisualStyleBackColor = True
        '
        'DataSetResumenCtaCte
        '
        Me.DataSetResumenCtaCte.DataSetName = "DataSetResumenCtaCte"
        Me.DataSetResumenCtaCte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'resumenBindingSource
        '
        Me.resumenBindingSource.DataMember = "resumen"
        Me.resumenBindingSource.DataSource = Me.DataSetResumenCtaCte
        '
        'resumenDependencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 477)
        Me.Controls.Add(Me.btn_buscardep)
        Me.Controls.Add(Me.rv_resumenDep)
        Me.Name = "resumenDependencia"
        Me.Text = "resumenDependencia"
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rv_resumenDep As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btn_buscardep As Button
    Friend WithEvents resumenBindingSource As BindingSource
    Friend WithEvents DataSetResumenCtaCte As DataSetResumenCtaCte
End Class
