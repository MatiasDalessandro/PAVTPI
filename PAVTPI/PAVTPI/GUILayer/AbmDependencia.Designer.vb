<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbmDependencia
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
        Me.dgv_datos_dependencia = New System.Windows.Forms.DataGridView()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_datos_dependencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_datos_dependencia
        '
        Me.dgv_datos_dependencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_dependencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.descripcion, Me.nro_cuenta, Me.saldo, Me.estado})
        Me.dgv_datos_dependencia.Location = New System.Drawing.Point(12, 22)
        Me.dgv_datos_dependencia.Name = "dgv_datos_dependencia"
        Me.dgv_datos_dependencia.Size = New System.Drawing.Size(545, 211)
        Me.dgv_datos_dependencia.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(16, 293)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(16, 319)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Descripción"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(16, 346)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "Estado"
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(182, 338)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(192, 21)
        Me.cmb_estado.TabIndex = 10
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(182, 286)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(192, 20)
        Me.txt_nombre.TabIndex = 8
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(182, 312)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(192, 20)
        Me.txt_descripcion.TabIndex = 9
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(19, 459)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(100, 459)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(182, 459)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 14
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(482, 459)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 15
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        '
        'nro_cuenta
        '
        Me.nro_cuenta.HeaderText = "Número de cuenta"
        Me.nro_cuenta.Name = "nro_cuenta"
        '
        'saldo
        '
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'AbmDependencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 518)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.dgv_datos_dependencia)
        Me.Name = "AbmDependencia"
        Me.Text = "AbmDependencia"
        CType(Me.dgv_datos_dependencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_datos_dependencia As DataGridView
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents lbl_estado As Label
    Friend WithEvents cmb_estado As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents nro_cuenta As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
