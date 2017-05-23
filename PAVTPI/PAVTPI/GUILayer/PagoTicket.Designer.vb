<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoTicket
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
        Me.btn_buscarArticulo = New System.Windows.Forms.Button()
        Me.txt_articulo = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_detalleTicket = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_combo = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscarCombo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbox_articulo = New System.Windows.Forms.ListBox()
        Me.lbox_combo = New System.Windows.Forms.ListBox()
        Me.bnt_agregarArticulo = New System.Windows.Forms.Button()
        Me.btn_agregarCombo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_dependencia = New System.Windows.Forms.ComboBox()
        Me.btn_agregarDependencia = New System.Windows.Forms.Button()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.btn_agregarEmpleado = New System.Windows.Forms.Button()
        Me.chk_dependencia = New System.Windows.Forms.CheckBox()
        Me.chk_mozo = New System.Windows.Forms.CheckBox()
        Me.chk_abonado = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_detalleTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscarArticulo
        '
        Me.btn_buscarArticulo.Location = New System.Drawing.Point(87, 22)
        Me.btn_buscarArticulo.Name = "btn_buscarArticulo"
        Me.btn_buscarArticulo.Size = New System.Drawing.Size(69, 23)
        Me.btn_buscarArticulo.TabIndex = 0
        Me.btn_buscarArticulo.Text = "Buscar"
        Me.btn_buscarArticulo.UseVisualStyleBackColor = True
        '
        'txt_articulo
        '
        Me.txt_articulo.Location = New System.Drawing.Point(12, 25)
        Me.txt_articulo.Mask = "99999"
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Size = New System.Drawing.Size(69, 20)
        Me.txt_articulo.TabIndex = 1
        Me.txt_articulo.ValidatingType = GetType(Integer)
        '
        'dgv_detalleTicket
        '
        Me.dgv_detalleTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalleTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.cantidad, Me.precio})
        Me.dgv_detalleTicket.Location = New System.Drawing.Point(11, 205)
        Me.dgv_detalleTicket.Name = "dgv_detalleTicket"
        Me.dgv_detalleTicket.RowHeadersWidth = 40
        Me.dgv_detalleTicket.Size = New System.Drawing.Size(675, 150)
        Me.dgv_detalleTicket.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'Articulo
        '
        Me.Articulo.AutoSize = True
        Me.Articulo.Location = New System.Drawing.Point(13, 9)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Size = New System.Drawing.Size(42, 13)
        Me.Articulo.TabIndex = 3
        Me.Articulo.Text = "Articulo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Combo"
        '
        'txt_combo
        '
        Me.txt_combo.Location = New System.Drawing.Point(382, 25)
        Me.txt_combo.Mask = "99999"
        Me.txt_combo.Name = "txt_combo"
        Me.txt_combo.Size = New System.Drawing.Size(69, 20)
        Me.txt_combo.TabIndex = 7
        Me.txt_combo.ValidatingType = GetType(Integer)
        '
        'btn_buscarCombo
        '
        Me.btn_buscarCombo.Location = New System.Drawing.Point(457, 25)
        Me.btn_buscarCombo.Name = "btn_buscarCombo"
        Me.btn_buscarCombo.Size = New System.Drawing.Size(69, 23)
        Me.btn_buscarCombo.TabIndex = 8
        Me.btn_buscarCombo.Text = "Buscar"
        Me.btn_buscarCombo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Detalle del ticket"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(611, 482)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(526, 482)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 11
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(572, 362)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(535, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total"
        '
        'lbox_articulo
        '
        Me.lbox_articulo.FormattingEnabled = True
        Me.lbox_articulo.Location = New System.Drawing.Point(12, 51)
        Me.lbox_articulo.Name = "lbox_articulo"
        Me.lbox_articulo.Size = New System.Drawing.Size(305, 95)
        Me.lbox_articulo.Sorted = True
        Me.lbox_articulo.TabIndex = 14
        '
        'lbox_combo
        '
        Me.lbox_combo.FormattingEnabled = True
        Me.lbox_combo.Location = New System.Drawing.Point(382, 54)
        Me.lbox_combo.Name = "lbox_combo"
        Me.lbox_combo.Size = New System.Drawing.Size(305, 95)
        Me.lbox_combo.Sorted = True
        Me.lbox_combo.TabIndex = 15
        '
        'bnt_agregarArticulo
        '
        Me.bnt_agregarArticulo.Location = New System.Drawing.Point(12, 153)
        Me.bnt_agregarArticulo.Name = "bnt_agregarArticulo"
        Me.bnt_agregarArticulo.Size = New System.Drawing.Size(75, 23)
        Me.bnt_agregarArticulo.TabIndex = 16
        Me.bnt_agregarArticulo.Text = "Agregar"
        Me.bnt_agregarArticulo.UseVisualStyleBackColor = True
        '
        'btn_agregarCombo
        '
        Me.btn_agregarCombo.Location = New System.Drawing.Point(382, 155)
        Me.btn_agregarCombo.Name = "btn_agregarCombo"
        Me.btn_agregarCombo.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarCombo.TabIndex = 17
        Me.btn_agregarCombo.Text = "Agregar"
        Me.btn_agregarCombo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Quitar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_dependencia
        '
        Me.cmb_dependencia.FormattingEnabled = True
        Me.cmb_dependencia.Location = New System.Drawing.Point(11, 455)
        Me.cmb_dependencia.Name = "cmb_dependencia"
        Me.cmb_dependencia.Size = New System.Drawing.Size(121, 21)
        Me.cmb_dependencia.TabIndex = 19
        '
        'btn_agregarDependencia
        '
        Me.btn_agregarDependencia.Location = New System.Drawing.Point(139, 455)
        Me.btn_agregarDependencia.Name = "btn_agregarDependencia"
        Me.btn_agregarDependencia.Size = New System.Drawing.Size(28, 23)
        Me.btn_agregarDependencia.TabIndex = 21
        Me.btn_agregarDependencia.Text = "..."
        Me.btn_agregarDependencia.UseVisualStyleBackColor = True
        '
        'cmb_empleado
        '
        Me.cmb_empleado.FormattingEnabled = True
        Me.cmb_empleado.Location = New System.Drawing.Point(185, 457)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(121, 21)
        Me.cmb_empleado.TabIndex = 23
        '
        'btn_agregarEmpleado
        '
        Me.btn_agregarEmpleado.Location = New System.Drawing.Point(312, 453)
        Me.btn_agregarEmpleado.Name = "btn_agregarEmpleado"
        Me.btn_agregarEmpleado.Size = New System.Drawing.Size(28, 23)
        Me.btn_agregarEmpleado.TabIndex = 24
        Me.btn_agregarEmpleado.Text = "..."
        Me.btn_agregarEmpleado.UseVisualStyleBackColor = True
        '
        'chk_dependencia
        '
        Me.chk_dependencia.AutoSize = True
        Me.chk_dependencia.Location = New System.Drawing.Point(11, 432)
        Me.chk_dependencia.Name = "chk_dependencia"
        Me.chk_dependencia.Size = New System.Drawing.Size(90, 17)
        Me.chk_dependencia.TabIndex = 25
        Me.chk_dependencia.Text = "Dependencia"
        Me.chk_dependencia.UseVisualStyleBackColor = True
        '
        'chk_mozo
        '
        Me.chk_mozo.AutoSize = True
        Me.chk_mozo.Location = New System.Drawing.Point(185, 432)
        Me.chk_mozo.Name = "chk_mozo"
        Me.chk_mozo.Size = New System.Drawing.Size(52, 17)
        Me.chk_mozo.TabIndex = 26
        Me.chk_mozo.Text = "Mozo"
        Me.chk_mozo.UseVisualStyleBackColor = True
        '
        'chk_abonado
        '
        Me.chk_abonado.AutoSize = True
        Me.chk_abonado.Location = New System.Drawing.Point(11, 488)
        Me.chk_abonado.Name = "chk_abonado"
        Me.chk_abonado.Size = New System.Drawing.Size(69, 17)
        Me.chk_abonado.TabIndex = 27
        Me.chk_abonado.Text = "Abonado"
        Me.chk_abonado.UseVisualStyleBackColor = True
        '
        'PagoTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 513)
        Me.Controls.Add(Me.chk_abonado)
        Me.Controls.Add(Me.chk_mozo)
        Me.Controls.Add(Me.chk_dependencia)
        Me.Controls.Add(Me.btn_agregarEmpleado)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.btn_agregarDependencia)
        Me.Controls.Add(Me.cmb_dependencia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_agregarCombo)
        Me.Controls.Add(Me.bnt_agregarArticulo)
        Me.Controls.Add(Me.lbox_combo)
        Me.Controls.Add(Me.lbox_articulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_buscarCombo)
        Me.Controls.Add(Me.txt_combo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Articulo)
        Me.Controls.Add(Me.dgv_detalleTicket)
        Me.Controls.Add(Me.txt_articulo)
        Me.Controls.Add(Me.btn_buscarArticulo)
        Me.Name = "PagoTicket"
        Me.Text = "Registrar Venta"
        CType(Me.dgv_detalleTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscarArticulo As Button
    Friend WithEvents txt_articulo As MaskedTextBox
    Friend WithEvents dgv_detalleTicket As DataGridView
    Friend WithEvents Articulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_combo As MaskedTextBox
    Friend WithEvents btn_buscarCombo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbox_articulo As ListBox
    Friend WithEvents lbox_combo As ListBox
    Friend WithEvents bnt_agregarArticulo As Button
    Friend WithEvents btn_agregarCombo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cmb_dependencia As ComboBox
    Friend WithEvents btn_agregarDependencia As Button
    Friend WithEvents cmb_empleado As ComboBox
    Friend WithEvents btn_agregarEmpleado As Button
    Friend WithEvents chk_dependencia As CheckBox
    Friend WithEvents chk_mozo As CheckBox
    Friend WithEvents chk_abonado As CheckBox
End Class
