<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsistMensual
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AsistMensualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        CType(Me.AsistMensualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro de Mes"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(79, 6)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(185, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AsistMensualBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.AsistenciaMensual.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 527)
        Me.ReportViewer1.TabIndex = 3
        '
        'AsistMensualBindingSource
        '
        Me.AsistMensualBindingSource.DataMember = "AsistMensual"
        Me.AsistMensualBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsistMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 572)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AsistMensual"
        Me.Text = "AsistMensual"
        CType(Me.AsistMensualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMes As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
    Friend WithEvents AsistMensualBindingSource As BindingSource
End Class
