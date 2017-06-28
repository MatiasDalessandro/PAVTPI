<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asignar_rol
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
        Me.dgvAsignarRol = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvAsignarRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsignarRol
        '
        Me.dgvAsignarRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsignarRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cApellido, Me.cNombre, Me.cNroDoc})
        Me.dgvAsignarRol.Location = New System.Drawing.Point(233, 12)
        Me.dgvAsignarRol.Name = "dgvAsignarRol"
        Me.dgvAsignarRol.Size = New System.Drawing.Size(477, 375)
        Me.dgvAsignarRol.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(12, 28)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(97, 20)
        Me.dtpDesde.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(12, 91)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(97, 20)
        Me.dtpHasta.TabIndex = 2
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(12, 200)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtNroDoc.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 226)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        'cmbRol
        '
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(12, 147)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(121, 21)
        Me.cmbRol.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rol"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nro. Documento"
        '
        'Asignar_rol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 399)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbRol)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAsignarRol)
        Me.Name = "Asignar_rol"
        Me.Text = "Asignar_rol"
        CType(Me.dgvAsignarRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAsignarRol As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cNroDoc As DataGridViewTextBoxColumn
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
