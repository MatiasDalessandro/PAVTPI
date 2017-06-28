<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PorsentajesRol
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btn_pr = New System.Windows.Forms.Button()
        Me.rv_pr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_pr
        '
        Me.btn_pr.Location = New System.Drawing.Point(46, 12)
        Me.btn_pr.Name = "btn_pr"
        Me.btn_pr.Size = New System.Drawing.Size(75, 23)
        Me.btn_pr.TabIndex = 0
        Me.btn_pr.Text = "Generar"
        Me.btn_pr.UseVisualStyleBackColor = True
        '
        'rv_pr
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.RolBindingSource
        Me.rv_pr.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rv_pr.LocalReport.ReportEmbeddedResource = "PAVTPI.PorcentajeRol.rdlc"
        Me.rv_pr.Location = New System.Drawing.Point(12, 57)
        Me.rv_pr.Name = "rv_pr"
        Me.rv_pr.Size = New System.Drawing.Size(961, 437)
        Me.rv_pr.TabIndex = 1
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "Rol"
        Me.RolBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'PorsentajesRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 506)
        Me.Controls.Add(Me.rv_pr)
        Me.Controls.Add(Me.btn_pr)
        Me.Name = "PorsentajesRol"
        Me.Text = "PorsentajesRol"
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_pr As Button
    Friend WithEvents rv_pr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
End Class
