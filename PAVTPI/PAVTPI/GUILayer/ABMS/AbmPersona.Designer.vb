<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmPersona
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
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.cApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Apellido = New System.Windows.Forms.TextBox()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.NumeroDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.TipoDocumento = New System.Windows.Forms.ComboBox()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Celular = New System.Windows.Forms.TextBox()
        Me.Domicilio = New System.Windows.Forms.TextBox()
        Me.lblFechaEgreso = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEgreso = New System.Windows.Forms.DateTimePicker()
        Me.chkPersAut = New System.Windows.Forms.CheckBox()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.AllowUserToAddRows = False
        Me.dgvEmpleado.AllowUserToDeleteRows = False
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cApellido, Me.cNombre, Me.cNroDoc})
        Me.dgvEmpleado.Location = New System.Drawing.Point(343, 12)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.ReadOnly = True
        Me.dgvEmpleado.Size = New System.Drawing.Size(448, 275)
        Me.dgvEmpleado.TabIndex = 30
        '
        'cApellido
        '
        Me.cApellido.HeaderText = "Apellido"
        Me.cApellido.Name = "cApellido"
        Me.cApellido.ReadOnly = True
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        '
        'cNroDoc
        '
        Me.cNroDoc.HeaderText = "Nro. Documento"
        Me.cNroDoc.Name = "cNroDoc"
        Me.cNroDoc.ReadOnly = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(336, 313)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 12
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(255, 313)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(93, 313)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 9
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(174, 313)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 10
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 313)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 8
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(135, 62)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(156, 20)
        Me.Nombre.TabIndex = 1
        '
        'Apellido
        '
        Me.Apellido.Location = New System.Drawing.Point(135, 32)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(156, 20)
        Me.Apellido.TabIndex = 0
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(12, 95)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(117, 13)
        Me.lblNroDoc.TabIndex = 21
        Me.lblNroDoc.Text = "Numero de Documento"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(85, 65)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(85, 35)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 19
        Me.lblApellido.Text = "Apellido"
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.Location = New System.Drawing.Point(135, 92)
        Me.NumeroDocumento.Mask = "99999999"
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.Size = New System.Drawing.Size(100, 20)
        Me.NumeroDocumento.TabIndex = 2
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(28, 127)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(101, 13)
        Me.lblTipoDoc.TabIndex = 21
        Me.lblTipoDoc.Text = "Tipo de Documento"
        '
        'TipoDocumento
        '
        Me.TipoDocumento.FormattingEnabled = True
        Me.TipoDocumento.Location = New System.Drawing.Point(135, 122)
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.TipoDocumento.TabIndex = 3
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(39, 155)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(90, 13)
        Me.lblFechaIngreso.TabIndex = 21
        Me.lblFechaIngreso.Text = "Fecha de Ingreso"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(80, 212)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.lblDomicilio.TabIndex = 21
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(97, 242)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "Email"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(90, 270)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 21
        Me.lblCelular.Text = "Celular"
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Location = New System.Drawing.Point(135, 239)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(156, 20)
        Me.Email.TabIndex = 6
        '
        'Celular
        '
        Me.Celular.Enabled = False
        Me.Celular.Location = New System.Drawing.Point(135, 267)
        Me.Celular.Name = "Celular"
        Me.Celular.Size = New System.Drawing.Size(156, 20)
        Me.Celular.TabIndex = 7
        '
        'Domicilio
        '
        Me.Domicilio.Enabled = False
        Me.Domicilio.Location = New System.Drawing.Point(135, 209)
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Size = New System.Drawing.Size(156, 20)
        Me.Domicilio.TabIndex = 5
        '
        'lblFechaEgreso
        '
        Me.lblFechaEgreso.AutoSize = True
        Me.lblFechaEgreso.Location = New System.Drawing.Point(39, 181)
        Me.lblFechaEgreso.Name = "lblFechaEgreso"
        Me.lblFechaEgreso.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaEgreso.TabIndex = 21
        Me.lblFechaEgreso.Text = "Fecha de Egreso"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(135, 149)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaIngreso.TabIndex = 31
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(135, 175)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaEgreso.TabIndex = 31
        '
        'chkPersAut
        '
        Me.chkPersAut.AutoSize = True
        Me.chkPersAut.Location = New System.Drawing.Point(135, 9)
        Me.chkPersAut.Name = "chkPersAut"
        Me.chkPersAut.Size = New System.Drawing.Size(118, 17)
        Me.chkPersAut.TabIndex = 32
        Me.chkPersAut.Text = "Persona Autorizada"
        Me.chkPersAut.UseVisualStyleBackColor = True
        '
        'AbmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 345)
        Me.Controls.Add(Me.chkPersAut)
        Me.Controls.Add(Me.dtpFechaEgreso)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.TipoDocumento)
        Me.Controls.Add(Me.NumeroDocumento)
        Me.Controls.Add(Me.dgvEmpleado)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Celular)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Domicilio)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.lblFechaEgreso)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Name = "AbmPersona"
        Me.Text = "AbmEmpleado"
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmpleado As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Apellido As TextBox
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents NumeroDocumento As MaskedTextBox
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents TipoDocumento As ComboBox
    Friend WithEvents lblFechaIngreso As Label
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCelular As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Celular As TextBox
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cNroDoc As DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As TextBox
    Friend WithEvents lblFechaEgreso As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents dtpFechaEgreso As DateTimePicker
    Friend WithEvents chkPersAut As CheckBox
End Class
