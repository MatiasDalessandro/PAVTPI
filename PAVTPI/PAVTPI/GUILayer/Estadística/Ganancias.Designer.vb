<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ganancias
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
        Me.chk_mes = New System.Windows.Forms.CheckBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chk_mes
        '
        Me.chk_mes.AutoSize = True
        Me.chk_mes.Location = New System.Drawing.Point(101, 8)
        Me.chk_mes.Name = "chk_mes"
        Me.chk_mes.Size = New System.Drawing.Size(66, 17)
        Me.chk_mes.TabIndex = 1
        Me.chk_mes.Text = "Mensual"
        Me.chk_mes.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(311, 6)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 2
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'cmb_mes
        '
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(209, 8)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(96, 21)
        Me.cmb_mes.TabIndex = 3
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(52, 9)
        Me.MaskedTextBox1.Mask = "9999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(34, 20)
        Me.MaskedTextBox1.TabIndex = 4
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Enabled = False
        Me.lbl.Location = New System.Drawing.Point(176, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(27, 13)
        Me.lbl.TabIndex = 5
        Me.lbl.Text = "Mes"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(21, 35)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(696, 402)
        Me.ReportViewer1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Año"
        '
        'ganancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 449)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.cmb_mes)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.chk_mes)
        Me.Name = "ganancias"
        Me.Text = "Ganancias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_mes As CheckBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents cmb_mes As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lbl As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
End Class
