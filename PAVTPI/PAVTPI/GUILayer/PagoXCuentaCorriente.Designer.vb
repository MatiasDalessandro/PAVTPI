<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoXCuentaCorriente
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_Dependencia = New System.Windows.Forms.Label()
        Me.dgv_dependencia = New System.Windows.Forms.DataGridView()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_registrarPago = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.mtb_nroCuentacorriente = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_CuentaCorriente = New System.Windows.Forms.Label()
        Me.lbl_saldo = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.lbl_montoAcobrar = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_saldo = New System.Windows.Forms.TextBox()
        Me.txt_cuentaCorriente = New System.Windows.Forms.TextBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.txt_montoAcobrar = New System.Windows.Forms.TextBox()
        Me.dgv_registroDePagos = New System.Windows.Forms.DataGridView()
        Me.c_nroCuentaCorrientePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_fechaHoraPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_montoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_registroDePagos = New System.Windows.Forms.Label()
        Me.lbl_fechaPago = New System.Windows.Forms.Label()
        Me.txt_fechaPago = New System.Windows.Forms.TextBox()
        Me.lbl_montoPago = New System.Windows.Forms.Label()
        Me.txt_montoPago = New System.Windows.Forms.TextBox()
        Me.gb_dependenciaSeleccionada = New System.Windows.Forms.GroupBox()
        Me.gb_pagoSeleccionado = New System.Windows.Forms.GroupBox()
        Me.c_nombreDependencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_NroCuentaCorriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_dependencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_registroDePagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Dependencia
        '
        Me.lbl_Dependencia.AutoSize = True
        Me.lbl_Dependencia.Location = New System.Drawing.Point(6, 9)
        Me.lbl_Dependencia.Name = "lbl_Dependencia"
        Me.lbl_Dependencia.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Dependencia.TabIndex = 0
        Me.lbl_Dependencia.Text = "Dependencias"
        '
        'dgv_dependencia
        '
        Me.dgv_dependencia.AllowUserToAddRows = False
        Me.dgv_dependencia.AllowUserToDeleteRows = False
        Me.dgv_dependencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dependencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_nombreDependencia, Me.c_NroCuentaCorriente, Me.c_Saldo, Me.c_Estado})
        Me.dgv_dependencia.Location = New System.Drawing.Point(9, 60)
        Me.dgv_dependencia.Name = "dgv_dependencia"
        Me.dgv_dependencia.ReadOnly = True
        Me.dgv_dependencia.Size = New System.Drawing.Size(485, 132)
        Me.dgv_dependencia.TabIndex = 1
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(738, 417)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 18
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_registrarPago
        '
        Me.btn_registrarPago.Enabled = False
        Me.btn_registrarPago.Location = New System.Drawing.Point(360, 310)
        Me.btn_registrarPago.Name = "btn_registrarPago"
        Me.btn_registrarPago.Size = New System.Drawing.Size(114, 23)
        Me.btn_registrarPago.TabIndex = 19
        Me.btn_registrarPago.Text = "Registrar Pago"
        Me.btn_registrarPago.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(115, 31)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 22
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'mtb_nroCuentacorriente
        '
        Me.mtb_nroCuentacorriente.Location = New System.Drawing.Point(9, 33)
        Me.mtb_nroCuentacorriente.Mask = "0000"
        Me.mtb_nroCuentacorriente.Name = "mtb_nroCuentacorriente"
        Me.mtb_nroCuentacorriente.Size = New System.Drawing.Size(100, 20)
        Me.mtb_nroCuentacorriente.TabIndex = 23
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(54, 225)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 24
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_CuentaCorriente
        '
        Me.lbl_CuentaCorriente.AutoSize = True
        Me.lbl_CuentaCorriente.Location = New System.Drawing.Point(12, 255)
        Me.lbl_CuentaCorriente.Name = "lbl_CuentaCorriente"
        Me.lbl_CuentaCorriente.Size = New System.Drawing.Size(86, 13)
        Me.lbl_CuentaCorriente.TabIndex = 24
        Me.lbl_CuentaCorriente.Text = "Cuenta Corriente"
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.Location = New System.Drawing.Point(64, 283)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(34, 13)
        Me.lbl_saldo.TabIndex = 24
        Me.lbl_saldo.Text = "Saldo"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(58, 310)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_estado.TabIndex = 24
        Me.lbl_estado.Text = "Estado"
        '
        'lbl_montoAcobrar
        '
        Me.lbl_montoAcobrar.AutoSize = True
        Me.lbl_montoAcobrar.Location = New System.Drawing.Point(284, 281)
        Me.lbl_montoAcobrar.Name = "lbl_montoAcobrar"
        Me.lbl_montoAcobrar.Size = New System.Drawing.Size(80, 13)
        Me.lbl_montoAcobrar.TabIndex = 24
        Me.lbl_montoAcobrar.Text = "Monto a Cobrar"
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(104, 218)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(174, 20)
        Me.txt_nombre.TabIndex = 25
        '
        'txt_saldo
        '
        Me.txt_saldo.Enabled = False
        Me.txt_saldo.Location = New System.Drawing.Point(104, 278)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(174, 20)
        Me.txt_saldo.TabIndex = 25
        '
        'txt_cuentaCorriente
        '
        Me.txt_cuentaCorriente.Enabled = False
        Me.txt_cuentaCorriente.Location = New System.Drawing.Point(104, 249)
        Me.txt_cuentaCorriente.Name = "txt_cuentaCorriente"
        Me.txt_cuentaCorriente.Size = New System.Drawing.Size(174, 20)
        Me.txt_cuentaCorriente.TabIndex = 25
        '
        'txt_estado
        '
        Me.txt_estado.Enabled = False
        Me.txt_estado.Location = New System.Drawing.Point(104, 304)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(174, 20)
        Me.txt_estado.TabIndex = 25
        '
        'txt_montoAcobrar
        '
        Me.txt_montoAcobrar.Location = New System.Drawing.Point(370, 276)
        Me.txt_montoAcobrar.Name = "txt_montoAcobrar"
        Me.txt_montoAcobrar.Size = New System.Drawing.Size(92, 20)
        Me.txt_montoAcobrar.TabIndex = 25
        '
        'dgv_registroDePagos
        '
        Me.dgv_registroDePagos.AllowUserToAddRows = False
        Me.dgv_registroDePagos.AllowUserToDeleteRows = False
        Me.dgv_registroDePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_registroDePagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_nroCuentaCorrientePago, Me.c_fechaHoraPago, Me.c_montoPago})
        Me.dgv_registroDePagos.Location = New System.Drawing.Point(528, 60)
        Me.dgv_registroDePagos.Name = "dgv_registroDePagos"
        Me.dgv_registroDePagos.ReadOnly = True
        Me.dgv_registroDePagos.Size = New System.Drawing.Size(285, 336)
        Me.dgv_registroDePagos.TabIndex = 26
        '
        'c_nroCuentaCorrientePago
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.c_nroCuentaCorrientePago.DefaultCellStyle = DataGridViewCellStyle2
        Me.c_nroCuentaCorrientePago.FillWeight = 50.0!
        Me.c_nroCuentaCorrientePago.HeaderText = "Cuenta Corriente"
        Me.c_nroCuentaCorrientePago.Name = "c_nroCuentaCorrientePago"
        Me.c_nroCuentaCorrientePago.ReadOnly = True
        Me.c_nroCuentaCorrientePago.Width = 110
        '
        'c_fechaHoraPago
        '
        Me.c_fechaHoraPago.FillWeight = 50.0!
        Me.c_fechaHoraPago.HeaderText = "Fecha"
        Me.c_fechaHoraPago.Name = "c_fechaHoraPago"
        Me.c_fechaHoraPago.ReadOnly = True
        Me.c_fechaHoraPago.Width = 80
        '
        'c_montoPago
        '
        Me.c_montoPago.FillWeight = 50.0!
        Me.c_montoPago.HeaderText = "Monto"
        Me.c_montoPago.Name = "c_montoPago"
        Me.c_montoPago.ReadOnly = True
        Me.c_montoPago.Width = 50
        '
        'lbl_registroDePagos
        '
        Me.lbl_registroDePagos.AutoSize = True
        Me.lbl_registroDePagos.Location = New System.Drawing.Point(525, 40)
        Me.lbl_registroDePagos.Name = "lbl_registroDePagos"
        Me.lbl_registroDePagos.Size = New System.Drawing.Size(94, 13)
        Me.lbl_registroDePagos.TabIndex = 27
        Me.lbl_registroDePagos.Text = "Registro de Pagos"
        '
        'lbl_fechaPago
        '
        Me.lbl_fechaPago.AutoSize = True
        Me.lbl_fechaPago.Location = New System.Drawing.Point(16, 383)
        Me.lbl_fechaPago.Name = "lbl_fechaPago"
        Me.lbl_fechaPago.Size = New System.Drawing.Size(82, 13)
        Me.lbl_fechaPago.TabIndex = 28
        Me.lbl_fechaPago.Text = "Fecha De Pago"
        '
        'txt_fechaPago
        '
        Me.txt_fechaPago.Enabled = False
        Me.txt_fechaPago.Location = New System.Drawing.Point(104, 379)
        Me.txt_fechaPago.Name = "txt_fechaPago"
        Me.txt_fechaPago.Size = New System.Drawing.Size(174, 20)
        Me.txt_fechaPago.TabIndex = 25
        '
        'lbl_montoPago
        '
        Me.lbl_montoPago.AutoSize = True
        Me.lbl_montoPago.Location = New System.Drawing.Point(61, 413)
        Me.lbl_montoPago.Name = "lbl_montoPago"
        Me.lbl_montoPago.Size = New System.Drawing.Size(37, 13)
        Me.lbl_montoPago.TabIndex = 28
        Me.lbl_montoPago.Text = "Monto"
        '
        'txt_montoPago
        '
        Me.txt_montoPago.Enabled = False
        Me.txt_montoPago.Location = New System.Drawing.Point(104, 408)
        Me.txt_montoPago.Name = "txt_montoPago"
        Me.txt_montoPago.Size = New System.Drawing.Size(70, 20)
        Me.txt_montoPago.TabIndex = 25
        '
        'gb_dependenciaSeleccionada
        '
        Me.gb_dependenciaSeleccionada.Location = New System.Drawing.Point(9, 199)
        Me.gb_dependenciaSeleccionada.Name = "gb_dependenciaSeleccionada"
        Me.gb_dependenciaSeleccionada.Size = New System.Drawing.Size(485, 155)
        Me.gb_dependenciaSeleccionada.TabIndex = 29
        Me.gb_dependenciaSeleccionada.TabStop = False
        Me.gb_dependenciaSeleccionada.Text = "Dependencia Seleccionada"
        '
        'gb_pagoSeleccionado
        '
        Me.gb_pagoSeleccionado.Location = New System.Drawing.Point(9, 360)
        Me.gb_pagoSeleccionado.Name = "gb_pagoSeleccionado"
        Me.gb_pagoSeleccionado.Size = New System.Drawing.Size(485, 80)
        Me.gb_pagoSeleccionado.TabIndex = 29
        Me.gb_pagoSeleccionado.TabStop = False
        Me.gb_pagoSeleccionado.Text = "Pago Seleccionado"
        '
        'c_nombreDependencia
        '
        Me.c_nombreDependencia.FillWeight = 50.0!
        Me.c_nombreDependencia.HeaderText = "Nombre"
        Me.c_nombreDependencia.Name = "c_nombreDependencia"
        Me.c_nombreDependencia.ReadOnly = True
        Me.c_nombreDependencia.Width = 180
        '
        'c_NroCuentaCorriente
        '
        Me.c_NroCuentaCorriente.FillWeight = 50.0!
        Me.c_NroCuentaCorriente.HeaderText = "Cuenta Corriente"
        Me.c_NroCuentaCorriente.Name = "c_NroCuentaCorriente"
        Me.c_NroCuentaCorriente.ReadOnly = True
        Me.c_NroCuentaCorriente.Width = 110
        '
        'c_Saldo
        '
        Me.c_Saldo.FillWeight = 50.0!
        Me.c_Saldo.HeaderText = "Saldo"
        Me.c_Saldo.Name = "c_Saldo"
        Me.c_Saldo.ReadOnly = True
        Me.c_Saldo.Width = 75
        '
        'c_Estado
        '
        Me.c_Estado.FillWeight = 50.0!
        Me.c_Estado.HeaderText = "Estado"
        Me.c_Estado.Name = "c_Estado"
        Me.c_Estado.ReadOnly = True
        Me.c_Estado.Width = 75
        '
        'PagoXCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 446)
        Me.Controls.Add(Me.lbl_montoPago)
        Me.Controls.Add(Me.lbl_fechaPago)
        Me.Controls.Add(Me.lbl_registroDePagos)
        Me.Controls.Add(Me.dgv_registroDePagos)
        Me.Controls.Add(Me.txt_montoPago)
        Me.Controls.Add(Me.txt_fechaPago)
        Me.Controls.Add(Me.txt_montoAcobrar)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.txt_cuentaCorriente)
        Me.Controls.Add(Me.txt_saldo)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.lbl_montoAcobrar)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.lbl_CuentaCorriente)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.mtb_nroCuentacorriente)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_registrarPago)
        Me.Controls.Add(Me.dgv_dependencia)
        Me.Controls.Add(Me.lbl_Dependencia)
        Me.Controls.Add(Me.gb_pagoSeleccionado)
        Me.Controls.Add(Me.gb_dependenciaSeleccionada)
        Me.Name = "PagoXCuentaCorriente"
        Me.Text = "PagoXCuentaCorriente"
        CType(Me.dgv_dependencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_registroDePagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Dependencia As Label
    Friend WithEvents dgv_dependencia As DataGridView
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_registrarPago As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents mtb_nroCuentacorriente As MaskedTextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_CuentaCorriente As Label
    Friend WithEvents lbl_saldo As Label
    Friend WithEvents lbl_estado As Label
    Friend WithEvents lbl_montoAcobrar As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_saldo As TextBox
    Friend WithEvents txt_cuentaCorriente As TextBox
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents txt_montoAcobrar As TextBox
    Friend WithEvents dgv_registroDePagos As DataGridView
    Friend WithEvents lbl_registroDePagos As Label
    Friend WithEvents c_nroCuentaCorrientePago As DataGridViewTextBoxColumn
    Friend WithEvents c_fechaHoraPago As DataGridViewTextBoxColumn
    Friend WithEvents c_montoPago As DataGridViewTextBoxColumn
    Friend WithEvents lbl_fechaPago As Label
    Friend WithEvents txt_fechaPago As TextBox
    Friend WithEvents lbl_montoPago As Label
    Friend WithEvents txt_montoPago As TextBox
    Friend WithEvents gb_dependenciaSeleccionada As GroupBox
    Friend WithEvents gb_pagoSeleccionado As GroupBox
    Friend WithEvents c_nombreDependencia As DataGridViewTextBoxColumn
    Friend WithEvents c_NroCuentaCorriente As DataGridViewTextBoxColumn
    Friend WithEvents c_Saldo As DataGridViewTextBoxColumn
    Friend WithEvents c_Estado As DataGridViewTextBoxColumn
End Class
