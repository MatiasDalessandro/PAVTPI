﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbl_Dependencia = New System.Windows.Forms.Label()
        Me.dgv_dependencia = New System.Windows.Forms.DataGridView()
        Me.c_nombreDependencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_NroCuentaCorriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
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
        Me.lbl_registroDePagos = New System.Windows.Forms.Label()
        Me.c_nroCuentaCorrientePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_fechaHoraPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_montoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgv_dependencia.Size = New System.Drawing.Size(465, 132)
        Me.dgv_dependencia.TabIndex = 1
        '
        'c_nombreDependencia
        '
        Me.c_nombreDependencia.FillWeight = 50.0!
        Me.c_nombreDependencia.HeaderText = "Nombre"
        Me.c_nombreDependencia.Name = "c_nombreDependencia"
        Me.c_nombreDependencia.ReadOnly = True
        Me.c_nombreDependencia.Width = 150
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
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(738, 409)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 18
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(9, 409)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 19
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
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
        'lbl_registroDePagos
        '
        Me.lbl_registroDePagos.AutoSize = True
        Me.lbl_registroDePagos.Location = New System.Drawing.Point(525, 40)
        Me.lbl_registroDePagos.Name = "lbl_registroDePagos"
        Me.lbl_registroDePagos.Size = New System.Drawing.Size(94, 13)
        Me.lbl_registroDePagos.TabIndex = 27
        Me.lbl_registroDePagos.Text = "Registro de Pagos"
        '
        'c_nroCuentaCorrientePago
        '
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
        'PagoXCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 442)
        Me.Controls.Add(Me.lbl_registroDePagos)
        Me.Controls.Add(Me.dgv_registroDePagos)
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
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dgv_dependencia)
        Me.Controls.Add(Me.lbl_Dependencia)
        Me.Name = "PagoXCuentaCorriente"
        Me.Text = "PagoXCuentaCorriente"
        CType(Me.dgv_dependencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_registroDePagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Dependencia As Label
    Friend WithEvents dgv_dependencia As DataGridView
    Friend WithEvents c_nombreDependencia As DataGridViewTextBoxColumn
    Friend WithEvents c_NroCuentaCorriente As DataGridViewTextBoxColumn
    Friend WithEvents c_Saldo As DataGridViewTextBoxColumn
    Friend WithEvents c_Estado As DataGridViewTextBoxColumn
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
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
End Class
