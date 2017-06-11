<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_por_período
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
        Me.txt_fechaInicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fechaFin = New System.Windows.Forms.MaskedTextBox()
        Me.txt_buscar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'txt_fechaInicio
        '
        Me.txt_fechaInicio.Location = New System.Drawing.Point(13, 13)
        Me.txt_fechaInicio.Mask = "00/00/0000"
        Me.txt_fechaInicio.Name = "txt_fechaInicio"
        Me.txt_fechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechaInicio.TabIndex = 0
        Me.txt_fechaInicio.ValidatingType = GetType(Date)
        '
        'txt_fechaFin
        '
        Me.txt_fechaFin.Location = New System.Drawing.Point(120, 13)
        Me.txt_fechaFin.Mask = "00/00/0000"
        Me.txt_fechaFin.Name = "txt_fechaFin"
        Me.txt_fechaFin.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechaFin.TabIndex = 1
        Me.txt_fechaFin.ValidatingType = GetType(Date)
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(227, 13)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(75, 23)
        Me.txt_buscar.TabIndex = 2
        Me.txt_buscar.Text = "Buscar"
        Me.txt_buscar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 56)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(722, 401)
        Me.ReportViewer1.TabIndex = 3
        '
        'Ventas_por_período
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 469)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.txt_fechaFin)
        Me.Controls.Add(Me.txt_fechaInicio)
        Me.Name = "Ventas_por_período"
        Me.Text = "Ventas_por_período"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_fechaInicio As MaskedTextBox
    Friend WithEvents txt_fechaFin As MaskedTextBox
    Friend WithEvents txt_buscar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
