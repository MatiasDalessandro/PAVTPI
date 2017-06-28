<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGanancias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.txt_año = New System.Windows.Forms.MaskedTextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.historico = New System.Windows.Forms.RadioButton()
        Me.anual = New System.Windows.Forms.RadioButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GananciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadisticasDependencias = New PAVTPI.EstadisticasDependencias()
        Me.GananciasHistoricasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GananciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GananciasHistoricasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_calcular
        '
        Me.btn_calcular.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_calcular.Location = New System.Drawing.Point(268, 21)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 26)
        Me.btn_calcular.TabIndex = 0
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'txt_año
        '
        Me.txt_año.Location = New System.Drawing.Point(186, 42)
        Me.txt_año.Mask = "9999"
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(35, 20)
        Me.txt_año.TabIndex = 1
        Me.txt_año.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(151, 46)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(29, 13)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Año:"
        Me.lbl2.Visible = False
        '
        'historico
        '
        Me.historico.AutoSize = True
        Me.historico.Location = New System.Drawing.Point(12, 21)
        Me.historico.Name = "historico"
        Me.historico.Size = New System.Drawing.Size(125, 17)
        Me.historico.TabIndex = 7
        Me.historico.TabStop = True
        Me.historico.Text = "Ganancias Historicas"
        Me.historico.UseVisualStyleBackColor = True
        '
        'anual
        '
        Me.anual.AutoSize = True
        Me.anual.Location = New System.Drawing.Point(12, 44)
        Me.anual.Name = "anual"
        Me.anual.Size = New System.Drawing.Size(100, 17)
        Me.anual.TabIndex = 8
        Me.anual.TabStop = True
        Me.anual.Text = "Ganancia anual"
        Me.anual.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GananciasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAVTPI.gananciasPorAño.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 82)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(350, 432)
        Me.ReportViewer1.TabIndex = 9
        Me.ReportViewer1.Visible = False
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.GananciasHistoricasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "PAVTPI.gHistoricas.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(13, 82)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(350, 432)
        Me.ReportViewer2.TabIndex = 10
        Me.ReportViewer2.Visible = False
        '
        'GananciasBindingSource
        '
        Me.GananciasBindingSource.DataMember = "Ganancias"
        Me.GananciasBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'EstadisticasDependencias
        '
        Me.EstadisticasDependencias.DataSetName = "EstadisticasDependencias"
        Me.EstadisticasDependencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GananciasHistoricasBindingSource
        '
        Me.GananciasHistoricasBindingSource.DataMember = "GananciasHistoricas"
        Me.GananciasHistoricasBindingSource.DataSource = Me.EstadisticasDependencias
        '
        'formGanancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 75)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.anual)
        Me.Controls.Add(Me.historico)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txt_año)
        Me.Controls.Add(Me.btn_calcular)
        Me.Name = "formGanancias"
        Me.Text = "Ganancias"
        CType(Me.GananciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadisticasDependencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GananciasHistoricasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_calcular As Button
    Friend WithEvents txt_año As MaskedTextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents historico As RadioButton
    Friend WithEvents anual As RadioButton
    Friend WithEvents GananciasBindingSource As BindingSource
    Friend WithEvents EstadisticasDependencias As EstadisticasDependencias
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GananciasHistoricasBindingSource As BindingSource
End Class
