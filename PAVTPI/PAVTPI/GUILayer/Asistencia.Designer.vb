<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asistencia
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblLlegada = New System.Windows.Forms.Label()
        Me.dtpDiaLlegada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraLlegada = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDiaSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(147, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(360, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'lblLlegada
        '
        Me.lblLlegada.AutoSize = True
        Me.lblLlegada.Location = New System.Drawing.Point(15, 19)
        Me.lblLlegada.Name = "lblLlegada"
        Me.lblLlegada.Size = New System.Drawing.Size(45, 13)
        Me.lblLlegada.TabIndex = 1
        Me.lblLlegada.Text = "Llegada"
        '
        'dtpDiaLlegada
        '
        Me.dtpDiaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDiaLlegada.Location = New System.Drawing.Point(18, 35)
        Me.dtpDiaLlegada.Name = "dtpDiaLlegada"
        Me.dtpDiaLlegada.Size = New System.Drawing.Size(98, 20)
        Me.dtpDiaLlegada.TabIndex = 2
        Me.dtpDiaLlegada.Value = New Date(2017, 6, 6, 22, 46, 34, 0)
        '
        'dtpHoraLlegada
        '
        Me.dtpHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraLlegada.Location = New System.Drawing.Point(18, 61)
        Me.dtpHoraLlegada.Name = "dtpHoraLlegada"
        Me.dtpHoraLlegada.Size = New System.Drawing.Size(98, 20)
        Me.dtpHoraLlegada.TabIndex = 2
        Me.dtpHoraLlegada.Value = New Date(2017, 6, 6, 22, 46, 34, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Salida"
        '
        'dtpDiaSalida
        '
        Me.dtpDiaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDiaSalida.Location = New System.Drawing.Point(18, 110)
        Me.dtpDiaSalida.Name = "dtpDiaSalida"
        Me.dtpDiaSalida.Size = New System.Drawing.Size(98, 20)
        Me.dtpDiaSalida.TabIndex = 2
        Me.dtpDiaSalida.Value = New Date(2017, 6, 6, 22, 46, 34, 0)
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraSalida.Location = New System.Drawing.Point(18, 136)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(98, 20)
        Me.dtpHoraSalida.TabIndex = 2
        Me.dtpHoraSalida.Value = New Date(2017, 6, 6, 22, 46, 34, 0)
        '
        'Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 315)
        Me.Controls.Add(Me.dtpHoraSalida)
        Me.Controls.Add(Me.dtpHoraLlegada)
        Me.Controls.Add(Me.dtpDiaSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDiaLlegada)
        Me.Controls.Add(Me.lblLlegada)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Asistencia"
        Me.Text = "Asistencia"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblLlegada As Label
    Friend WithEvents dtpDiaLlegada As DateTimePicker
    Friend WithEvents dtpHoraLlegada As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDiaSalida As DateTimePicker
    Friend WithEvents dtpHoraSalida As DateTimePicker
End Class
