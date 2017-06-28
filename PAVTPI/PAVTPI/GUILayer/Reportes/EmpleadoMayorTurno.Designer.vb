<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadoMayorTurno
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        Me.EmpMayTurnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpMayTurnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EmpMayTurnoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.EmpMayTurCump.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 36)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1047, 531)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(299, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpMayTurnoBindingSource
        '
        Me.EmpMayTurnoBindingSource.DataMember = "EmpMayTurno"
        Me.EmpMayTurnoBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(56, 10)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(99, 20)
        Me.dtpDesde.TabIndex = 4
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(194, 10)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(99, 20)
        Me.dtpHasta.TabIndex = 4
        '
        'EmpleadoMayorTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 579)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "EmpleadoMayorTurno"
        Me.Text = "EmpleadoMayorTurno"
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpMayTurnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents EmpMayTurnoBindingSource As BindingSource
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dtpHasta As DateTimePicker
End Class
