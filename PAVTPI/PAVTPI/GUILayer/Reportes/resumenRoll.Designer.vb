<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resumenRoll
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
        Me.btn_rr = New System.Windows.Forms.Button()
        Me.rv_rr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetResumenCtaCte = New PAVTPI.DataSetResumenCtaCte()
        Me.resumenRolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resumenRolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_rr
        '
        Me.btn_rr.Location = New System.Drawing.Point(28, 27)
        Me.btn_rr.Name = "btn_rr"
        Me.btn_rr.Size = New System.Drawing.Size(75, 23)
        Me.btn_rr.TabIndex = 0
        Me.btn_rr.Text = "Buscar"
        Me.btn_rr.UseVisualStyleBackColor = True
        '
        'rv_rr
        '
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.resumenRolBindingSource
        Me.rv_rr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_rr.LocalReport.ReportEmbeddedResource = "PAVTPI.ResumenRol.rdlc"
        Me.rv_rr.Location = New System.Drawing.Point(12, 67)
        Me.rv_rr.Name = "rv_rr"
        Me.rv_rr.Size = New System.Drawing.Size(1089, 444)
        Me.rv_rr.TabIndex = 1
        '
        'DataSetResumenCtaCte
        '
        Me.DataSetResumenCtaCte.DataSetName = "DataSetResumenCtaCte"
        Me.DataSetResumenCtaCte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'resumenRolBindingSource
        '
        Me.resumenRolBindingSource.DataMember = "resumenRol"
        Me.resumenRolBindingSource.DataSource = Me.DataSetResumenCtaCte
        '
        'resumenRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 523)
        Me.Controls.Add(Me.rv_rr)
        Me.Controls.Add(Me.btn_rr)
        Me.Name = "resumenRoll"
        Me.Text = "resumenRoll"
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resumenRolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_rr As Button
    Friend WithEvents rv_rr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents resumenRolBindingSource As BindingSource
    Friend WithEvents DataSetResumenCtaCte As DataSetResumenCtaCte
End Class
