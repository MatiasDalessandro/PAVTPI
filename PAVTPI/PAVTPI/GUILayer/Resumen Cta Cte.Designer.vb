<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resumen_Cta_Cte
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCtaCte = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetResumenCtaCte = New PAVTPI.DataSetResumenCtaCte()
        CType(Me.ResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ResumenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.ReporteCtaCte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 34)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(673, 478)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese numero de Cuenta Corriente"
        '
        'txtCtaCte
        '
        Me.txtCtaCte.Location = New System.Drawing.Point(193, 6)
        Me.txtCtaCte.Name = "txtCtaCte"
        Me.txtCtaCte.Size = New System.Drawing.Size(78, 20)
        Me.txtCtaCte.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(277, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ResumenBindingSource
        '
        Me.ResumenBindingSource.DataMember = "resumen"
        Me.ResumenBindingSource.DataSource = Me.DataSetResumenCtaCte
        '
        'DataSetResumenCtaCte
        '
        Me.DataSetResumenCtaCte.DataSetName = "DataSetResumenCtaCte"
        Me.DataSetResumenCtaCte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Resumen_Cta_Cte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 524)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCtaCte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Resumen_Cta_Cte"
        Me.Text = "Resumen_Cta_Cte"
        CType(Me.ResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCtaCte As TextBox
    Friend WithEvents ResumenBindingSource As BindingSource
    Friend WithEvents DataSetResumenCtaCte As DataSetResumenCtaCte
    Friend WithEvents btnBuscar As Button
End Class
