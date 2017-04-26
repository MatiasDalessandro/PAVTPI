<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmEmpleado
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.mskNroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.mskFechaIngreso = New System.Windows.Forms.MaskedTextBox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.lblFechaEgreso = New System.Windows.Forms.Label()
        Me.mskFechaEgreso = New System.Windows.Forms.MaskedTextBox()
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
        Me.dgvEmpleado.Size = New System.Drawing.Size(448, 285)
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
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(135, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(156, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(135, 32)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(156, 20)
        Me.txtApellido.TabIndex = 0
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
        'mskNroDoc
        '
        Me.mskNroDoc.Location = New System.Drawing.Point(135, 92)
        Me.mskNroDoc.Mask = "99999999"
        Me.mskNroDoc.Name = "mskNroDoc"
        Me.mskNroDoc.Size = New System.Drawing.Size(100, 20)
        Me.mskNroDoc.TabIndex = 2
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
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(135, 122)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoDoc.TabIndex = 3
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
        'mskFechaIngreso
        '
        Me.mskFechaIngreso.Location = New System.Drawing.Point(135, 152)
        Me.mskFechaIngreso.Mask = "00/00/0000"
        Me.mskFechaIngreso.Name = "mskFechaIngreso"
        Me.mskFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.mskFechaIngreso.TabIndex = 4
        Me.mskFechaIngreso.ValidatingType = GetType(Date)
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
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(135, 239)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(156, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtCelular
        '
        Me.txtCelular.Enabled = False
        Me.txtCelular.Location = New System.Drawing.Point(135, 267)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(156, 20)
        Me.txtCelular.TabIndex = 7
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(135, 209)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(156, 20)
        Me.txtDomicilio.TabIndex = 5
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
        'mskFechaEgreso
        '
        Me.mskFechaEgreso.Location = New System.Drawing.Point(135, 178)
        Me.mskFechaEgreso.Mask = "00/00/0000"
        Me.mskFechaEgreso.Name = "mskFechaEgreso"
        Me.mskFechaEgreso.Size = New System.Drawing.Size(100, 20)
        Me.mskFechaEgreso.TabIndex = 4
        Me.mskFechaEgreso.ValidatingType = GetType(Date)
        '
        'AbmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 345)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.mskFechaEgreso)
        Me.Controls.Add(Me.mskFechaIngreso)
        Me.Controls.Add(Me.mskNroDoc)
        Me.Controls.Add(Me.dgvEmpleado)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.lblFechaEgreso)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Name = "AbmEmpleado"
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
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents mskNroDoc As MaskedTextBox
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents lblFechaIngreso As Label
    Friend WithEvents mskFechaIngreso As MaskedTextBox
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCelular As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cNroDoc As DataGridViewTextBoxColumn
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents lblFechaEgreso As Label
    Friend WithEvents mskFechaEgreso As MaskedTextBox
End Class
