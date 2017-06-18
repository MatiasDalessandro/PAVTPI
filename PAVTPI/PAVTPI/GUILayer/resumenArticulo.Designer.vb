<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resumenArticulo
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.resumenArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenArticulos = New PAVTPI.ResumenArticulos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetResumenCtaCte = New PAVTPI.DataSetResumenCtaCte()
        Me.resumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenArticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPI = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.resumenArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenArticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'resumenArticulosBindingSource
        '
        Me.resumenArticulosBindingSource.DataMember = "resumenArticulos"
        Me.resumenArticulosBindingSource.DataSource = Me.ResumenArticulos
        '
        'ResumenArticulos
        '
        Me.ResumenArticulos.DataSetName = "ResumenArticulos"
        Me.ResumenArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.resumenArticulosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.ResumenArticulos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 34)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(785, 432)
        Me.ReportViewer1.TabIndex = 0
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
        'ResumenArticulosBindingSource1
        '
        Me.ResumenArticulosBindingSource1.DataMember = "resumenArticulos"
        Me.ResumenArticulosBindingSource1.DataSource = Me.ResumenArticulos
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Precio Inicial"
        '
        'txtPF
        '
        Me.txtPF.Location = New System.Drawing.Point(307, 6)
        Me.txtPF.Name = "txtPF"
        Me.txtPF.Size = New System.Drawing.Size(100, 20)
        Me.txtPF.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Final"
        '
        'txtPI
        '
        Me.txtPI.Location = New System.Drawing.Point(85, 6)
        Me.txtPI.Name = "txtPI"
        Me.txtPI.Size = New System.Drawing.Size(100, 20)
        Me.txtPI.TabIndex = 2
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(426, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'resumenArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 478)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtPI)
        Me.Controls.Add(Me.txtPF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "resumenArticulo"
        Me.Text = "resumenArticulo"
        CType(Me.resumenArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetResumenCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenArticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents resumenBindingSource As BindingSource
    Friend WithEvents DataSetResumenCtaCte As DataSetResumenCtaCte
    Friend WithEvents resumenArticulosBindingSource As BindingSource
    Friend WithEvents ResumenArticulos As ResumenArticulos
    Friend WithEvents ResumenArticulosBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPI As TextBox
    Friend WithEvents btnCalcular As Button
End Class
