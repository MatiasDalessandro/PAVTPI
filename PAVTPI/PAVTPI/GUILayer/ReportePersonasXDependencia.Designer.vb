<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePersonasXDependencia
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
        Me.cmb_dependencia = New System.Windows.Forms.ComboBox()
        Me.lbl_dependencia = New System.Windows.Forms.Label()
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.personaXdependenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConjDatosPersXDep = New PAVTPI.ConjDatosPersXDep()
        CType(Me.personaXdependenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConjDatosPersXDep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.personaXdependenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.ReportePersonaXDep.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1092, 679)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmb_dependencia
        '
        Me.cmb_dependencia.FormattingEnabled = True
        Me.cmb_dependencia.Location = New System.Drawing.Point(90, 21)
        Me.cmb_dependencia.Name = "cmb_dependencia"
        Me.cmb_dependencia.Size = New System.Drawing.Size(170, 21)
        Me.cmb_dependencia.TabIndex = 1
        '
        'lbl_dependencia
        '
        Me.lbl_dependencia.AutoSize = True
        Me.lbl_dependencia.Location = New System.Drawing.Point(13, 25)
        Me.lbl_dependencia.Name = "lbl_dependencia"
        Me.lbl_dependencia.Size = New System.Drawing.Size(71, 13)
        Me.lbl_dependencia.TabIndex = 2
        Me.lbl_dependencia.Text = "Dependencia"
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(976, 22)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(129, 23)
        Me.cmd_generar.TabIndex = 3
        Me.cmd_generar.Text = "Generar"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'personaXdependenciaBindingSource
        '
        Me.personaXdependenciaBindingSource.DataMember = "personaXdependencia"
        Me.personaXdependenciaBindingSource.DataSource = Me.ConjDatosPersXDep
        '
        'ConjDatosPersXDep
        '
        Me.ConjDatosPersXDep.DataSetName = "ConjDatosPersXDep"
        Me.ConjDatosPersXDep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportePersonasXDependencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 744)
        Me.Controls.Add(Me.cmd_generar)
        Me.Controls.Add(Me.lbl_dependencia)
        Me.Controls.Add(Me.cmb_dependencia)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportePersonasXDependencia"
        Me.Text = "ReportePersonasXDependencia"
        CType(Me.personaXdependenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConjDatosPersXDep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmb_dependencia As ComboBox
    Friend WithEvents lbl_dependencia As Label
    Friend WithEvents cmd_generar As Button
    Friend WithEvents personaXdependenciaBindingSource As BindingSource
    Friend WithEvents ConjDatosPersXDep As ConjDatosPersXDep
End Class
