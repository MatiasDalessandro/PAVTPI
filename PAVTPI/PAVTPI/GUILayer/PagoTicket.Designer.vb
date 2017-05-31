<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
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
        Me.btn_buscarArticulo = New System.Windows.Forms.Button()
        Me.txt_articulo = New System.Windows.Forms.MaskedTextBox()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_combo = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscarCombo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnt_agregarArticulo = New System.Windows.Forms.Button()
        Me.btn_agregarCombo = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.cmb_dependencia = New System.Windows.Forms.ComboBox()
        Me.btn_agregarDependencia = New System.Windows.Forms.Button()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.btn_agregarEmpleado = New System.Windows.Forms.Button()
        Me.chk_dependencia = New System.Windows.Forms.CheckBox()
        Me.chk_mozo = New System.Windows.Forms.CheckBox()
        Me.chk_abonado = New System.Windows.Forms.CheckBox()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_articulo = New System.Windows.Forms.DataGridView()
        Me.dgv_combo = New System.Windows.Forms.DataGridView()
        Me.btn_mostrarTodosArt = New System.Windows.Forms.Button()
        Me.btn_mostrarTodosCom = New System.Windows.Forms.Button()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_combo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscarArticulo
        '
        Me.btn_buscarArticulo.Location = New System.Drawing.Point(87, 25)
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
        Me.Label1.Location = New System.Drawing.Point(552, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Combo"
        '
        'txt_combo
        '
        Me.txt_combo.Location = New System.Drawing.Point(555, 25)
        Me.txt_combo.Mask = "99999"
        Me.txt_combo.Name = "txt_combo"
        Me.txt_combo.Size = New System.Drawing.Size(69, 20)
        Me.txt_combo.TabIndex = 7
        Me.txt_combo.ValidatingType = GetType(Integer)
        '
        'btn_buscarCombo
        '
        Me.btn_buscarCombo.Location = New System.Drawing.Point(630, 25)
        Me.btn_buscarCombo.Name = "btn_buscarCombo"
        Me.btn_buscarCombo.Size = New System.Drawing.Size(69, 23)
        Me.btn_buscarCombo.TabIndex = 8
        Me.btn_buscarCombo.Text = "Buscar"
        Me.btn_buscarCombo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Detalle del ticket"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(930, 594)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(849, 594)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 11
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(891, 477)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_total.Size = New System.Drawing.Size(114, 20)
        Me.txt_total.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(854, 480)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total"
        '
        'bnt_agregarArticulo
        '
        Me.bnt_agregarArticulo.Location = New System.Drawing.Point(11, 258)
        Me.bnt_agregarArticulo.Name = "bnt_agregarArticulo"
        Me.bnt_agregarArticulo.Size = New System.Drawing.Size(75, 23)
        Me.bnt_agregarArticulo.TabIndex = 16
        Me.bnt_agregarArticulo.Text = "Agregar"
        Me.bnt_agregarArticulo.UseVisualStyleBackColor = True
        '
        'btn_agregarCombo
        '
        Me.btn_agregarCombo.Location = New System.Drawing.Point(555, 258)
        Me.btn_agregarCombo.Name = "btn_agregarCombo"
        Me.btn_agregarCombo.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarCombo.TabIndex = 17
        Me.btn_agregarCombo.Text = "Agregar"
        Me.btn_agregarCombo.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(11, 480)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar.TabIndex = 18
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'cmb_dependencia
        '
        Me.cmb_dependencia.FormattingEnabled = True
        Me.cmb_dependencia.Location = New System.Drawing.Point(11, 570)
        Me.cmb_dependencia.Name = "cmb_dependencia"
        Me.cmb_dependencia.Size = New System.Drawing.Size(121, 21)
        Me.cmb_dependencia.TabIndex = 19
        '
        'btn_agregarDependencia
        '
        Me.btn_agregarDependencia.Location = New System.Drawing.Point(139, 570)
        Me.btn_agregarDependencia.Name = "btn_agregarDependencia"
        Me.btn_agregarDependencia.Size = New System.Drawing.Size(28, 23)
        Me.btn_agregarDependencia.TabIndex = 21
        Me.btn_agregarDependencia.Text = "..."
        Me.btn_agregarDependencia.UseVisualStyleBackColor = True
        '
        'cmb_empleado
        '
        Me.cmb_empleado.FormattingEnabled = True
        Me.cmb_empleado.Location = New System.Drawing.Point(185, 572)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(121, 21)
        Me.cmb_empleado.TabIndex = 23
        '
        'btn_agregarEmpleado
        '
        Me.btn_agregarEmpleado.Location = New System.Drawing.Point(312, 568)
        Me.btn_agregarEmpleado.Name = "btn_agregarEmpleado"
        Me.btn_agregarEmpleado.Size = New System.Drawing.Size(28, 23)
        Me.btn_agregarEmpleado.TabIndex = 24
        Me.btn_agregarEmpleado.Text = "..."
        Me.btn_agregarEmpleado.UseVisualStyleBackColor = True
        '
        'chk_dependencia
        '
        Me.chk_dependencia.AutoSize = True
        Me.chk_dependencia.Location = New System.Drawing.Point(11, 547)
        Me.chk_dependencia.Name = "chk_dependencia"
        Me.chk_dependencia.Size = New System.Drawing.Size(90, 17)
        Me.chk_dependencia.TabIndex = 25
        Me.chk_dependencia.Text = "Dependencia"
        Me.chk_dependencia.UseVisualStyleBackColor = True
        '
        'chk_mozo
        '
        Me.chk_mozo.AutoSize = True
        Me.chk_mozo.Location = New System.Drawing.Point(185, 547)
        Me.chk_mozo.Name = "chk_mozo"
        Me.chk_mozo.Size = New System.Drawing.Size(52, 17)
        Me.chk_mozo.TabIndex = 26
        Me.chk_mozo.Text = "Mozo"
        Me.chk_mozo.UseVisualStyleBackColor = True
        '
        'chk_abonado
        '
        Me.chk_abonado.AutoSize = True
        Me.chk_abonado.Location = New System.Drawing.Point(11, 603)
        Me.chk_abonado.Name = "chk_abonado"
        Me.chk_abonado.Size = New System.Drawing.Size(69, 17)
        Me.chk_abonado.TabIndex = 27
        Me.chk_abonado.Text = "Abonado"
        Me.chk_abonado.UseVisualStyleBackColor = True
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre_2, Me.monto})
        Me.dgv_detalle.Location = New System.Drawing.Point(11, 318)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(994, 150)
        Me.dgv_detalle.TabIndex = 28
        '
        'id
        '
        Me.id.HeaderText = "Nro"
        Me.id.Name = "id"
        '
        'nombre_2
        '
        Me.nombre_2.HeaderText = "Nombre"
        Me.nombre_2.Name = "nombre_2"
        '
        'monto
        '
        Me.monto.HeaderText = "Precio"
        Me.monto.Name = "monto"
        '
        'dgv_articulo
        '
        Me.dgv_articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulo.Location = New System.Drawing.Point(11, 51)
        Me.dgv_articulo.Name = "dgv_articulo"
        Me.dgv_articulo.Size = New System.Drawing.Size(450, 201)
        Me.dgv_articulo.TabIndex = 29
        '
        'dgv_combo
        '
        Me.dgv_combo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_combo.Location = New System.Drawing.Point(555, 51)
        Me.dgv_combo.Name = "dgv_combo"
        Me.dgv_combo.Size = New System.Drawing.Size(450, 201)
        Me.dgv_combo.TabIndex = 30
        '
        'btn_mostrarTodosArt
        '
        Me.btn_mostrarTodosArt.Location = New System.Drawing.Point(340, 258)
        Me.btn_mostrarTodosArt.Name = "btn_mostrarTodosArt"
        Me.btn_mostrarTodosArt.Size = New System.Drawing.Size(121, 23)
        Me.btn_mostrarTodosArt.TabIndex = 31
        Me.btn_mostrarTodosArt.Text = "Mostrar Todos"
        Me.btn_mostrarTodosArt.UseVisualStyleBackColor = True
        '
        'btn_mostrarTodosCom
        '
        Me.btn_mostrarTodosCom.Location = New System.Drawing.Point(884, 258)
        Me.btn_mostrarTodosCom.Name = "btn_mostrarTodosCom"
        Me.btn_mostrarTodosCom.Size = New System.Drawing.Size(121, 23)
        Me.btn_mostrarTodosCom.TabIndex = 32
        Me.btn_mostrarTodosCom.Text = "Mostrar Todos"
        Me.btn_mostrarTodosCom.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 629)
        Me.Controls.Add(Me.btn_mostrarTodosCom)
        Me.Controls.Add(Me.btn_mostrarTodosArt)
        Me.Controls.Add(Me.dgv_combo)
        Me.Controls.Add(Me.dgv_articulo)
        Me.Controls.Add(Me.dgv_detalle)
        Me.Controls.Add(Me.chk_abonado)
        Me.Controls.Add(Me.chk_mozo)
        Me.Controls.Add(Me.chk_dependencia)
        Me.Controls.Add(Me.btn_agregarEmpleado)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.btn_agregarDependencia)
        Me.Controls.Add(Me.cmb_dependencia)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_agregarCombo)
        Me.Controls.Add(Me.bnt_agregarArticulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_buscarCombo)
        Me.Controls.Add(Me.txt_combo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Articulo)
        Me.Controls.Add(Me.txt_articulo)
        Me.Controls.Add(Me.btn_buscarArticulo)
        Me.Name = "Venta"
        Me.Text = "Registrar Venta"
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_combo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscarArticulo As Button
    Friend WithEvents txt_articulo As MaskedTextBox
    Friend WithEvents Articulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_combo As MaskedTextBox
    Friend WithEvents btn_buscarCombo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bnt_agregarArticulo As Button
    Friend WithEvents btn_agregarCombo As Button
    Friend WithEvents btn_quitar As Button
    Friend WithEvents cmb_dependencia As ComboBox
    Friend WithEvents btn_agregarDependencia As Button
    Friend WithEvents cmb_empleado As ComboBox
    Friend WithEvents btn_agregarEmpleado As Button
    Friend WithEvents chk_dependencia As CheckBox
    Friend WithEvents chk_mozo As CheckBox
    Friend WithEvents chk_abonado As CheckBox
    Friend WithEvents dgv_detalle As DataGridView
    Friend WithEvents dgv_articulo As DataGridView
    Friend WithEvents dgv_combo As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre_2 As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents btn_mostrarTodosArt As Button
    Friend WithEvents btn_mostrarTodosCom As Button
End Class
