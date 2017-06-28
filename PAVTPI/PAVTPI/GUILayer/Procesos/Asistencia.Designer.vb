<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Asistencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvAsist = New System.Windows.Forms.DataGridView()
        Me.cApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLlegada = New System.Windows.Forms.Label()
        Me.dtpDiaLlegada = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDiaSalida = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.chkAusente = New System.Windows.Forms.CheckBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvAsist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsist
        '
        Me.dgvAsist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cApellido, Me.cNombre, Me.cNroDoc})
        Me.dgvAsist.Location = New System.Drawing.Point(231, 12)
        Me.dgvAsist.Name = "dgvAsist"
        Me.dgvAsist.Size = New System.Drawing.Size(472, 285)
        Me.dgvAsist.TabIndex = 0
        '
        'cApellido
        '
        Me.cApellido.HeaderText = "Apellido"
        Me.cApellido.Name = "cApellido"
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        '
        'cNroDoc
        '
        Me.cNroDoc.HeaderText = "Nro. Documento"
        Me.cNroDoc.Name = "cNroDoc"
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
        Me.dtpDiaLlegada.CustomFormat = ""
        Me.dtpDiaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDiaLlegada.Location = New System.Drawing.Point(18, 35)
        Me.dtpDiaLlegada.Name = "dtpDiaLlegada"
        Me.dtpDiaLlegada.Size = New System.Drawing.Size(98, 20)
        Me.dtpDiaLlegada.TabIndex = 2
        Me.dtpDiaLlegada.Value = New Date(2017, 6, 6, 22, 46, 34, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Salida"
        '
        'dtpDiaSalida
        '
        Me.dtpDiaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDiaSalida.Location = New System.Drawing.Point(18, 86)
        Me.dtpDiaSalida.Name = "dtpDiaSalida"
        Me.dtpDiaSalida.Size = New System.Drawing.Size(98, 20)
        Me.dtpDiaSalida.TabIndex = 2
        Me.dtpDiaSalida.Value = New Date(2017, 6, 6, 22, 46, 34, 0)
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(124, 277)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(18, 278)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtNroDoc.TabIndex = 4
        '
        'chkAusente
        '
        Me.chkAusente.AutoSize = True
        Me.chkAusente.Location = New System.Drawing.Point(18, 158)
        Me.chkAusente.Name = "chkAusente"
        Me.chkAusente.Size = New System.Drawing.Size(65, 17)
        Me.chkAusente.TabIndex = 5
        Me.chkAusente.Text = "Ausente"
        Me.chkAusente.UseVisualStyleBackColor = True
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(18, 194)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(207, 20)
        Me.txtMotivo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Motivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nro. Documento"
        '
        'Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 309)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.chkAusente)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dtpDiaSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDiaLlegada)
        Me.Controls.Add(Me.lblLlegada)
        Me.Controls.Add(Me.dgvAsist)
        Me.Name = "Asistencia"
        Me.Text = "Asistencia"
        CType(Me.dgvAsist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAsist As DataGridView
    Friend WithEvents lblLlegada As Label
    Friend WithEvents dtpDiaLlegada As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDiaSalida As DateTimePicker
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cNroDoc As DataGridViewTextBoxColumn
    Friend WithEvents chkAusente As CheckBox
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
