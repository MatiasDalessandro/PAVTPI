<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonaXDependencia
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
        Me.btn_buscarDependencia = New System.Windows.Forms.Button()
        Me.btn_buscarPersona = New System.Windows.Forms.Button()
        Me.txt_nroDependencia = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_documento = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dependencia_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_dependencia_nro = New System.Windows.Forms.TextBox()
        Me.txt_dependencia_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_persona_dni = New System.Windows.Forms.TextBox()
        Me.txt_persona_apellido = New System.Windows.Forms.TextBox()
        Me.txt_persona_nombre = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_personaDependencia = New System.Windows.Forms.DataGridView()
        Me.nroCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.btn_dependencia = New System.Windows.Forms.Button()
        Me.btn_persona_empleado = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.dgv_personaDependencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscarDependencia
        '
        Me.btn_buscarDependencia.Location = New System.Drawing.Point(12, 73)
        Me.btn_buscarDependencia.Name = "btn_buscarDependencia"
        Me.btn_buscarDependencia.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarDependencia.TabIndex = 0
        Me.btn_buscarDependencia.Text = "Buscar"
        Me.btn_buscarDependencia.UseVisualStyleBackColor = True
        '
        'btn_buscarPersona
        '
        Me.btn_buscarPersona.Location = New System.Drawing.Point(222, 73)
        Me.btn_buscarPersona.Name = "btn_buscarPersona"
        Me.btn_buscarPersona.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarPersona.TabIndex = 1
        Me.btn_buscarPersona.Text = "Buscar"
        Me.btn_buscarPersona.UseVisualStyleBackColor = True
        '
        'txt_nroDependencia
        '
        Me.txt_nroDependencia.Location = New System.Drawing.Point(12, 40)
        Me.txt_nroDependencia.Mask = "99999999"
        Me.txt_nroDependencia.Name = "txt_nroDependencia"
        Me.txt_nroDependencia.Size = New System.Drawing.Size(144, 20)
        Me.txt_nroDependencia.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dependencia"
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(222, 37)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(144, 20)
        Me.txt_documento.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Documento"
        '
        'txt_dependencia_descripcion
        '
        Me.txt_dependencia_descripcion.Location = New System.Drawing.Point(12, 165)
        Me.txt_dependencia_descripcion.Name = "txt_dependencia_descripcion"
        Me.txt_dependencia_descripcion.Size = New System.Drawing.Size(144, 20)
        Me.txt_dependencia_descripcion.TabIndex = 6
        '
        'txt_dependencia_nro
        '
        Me.txt_dependencia_nro.Location = New System.Drawing.Point(12, 139)
        Me.txt_dependencia_nro.Name = "txt_dependencia_nro"
        Me.txt_dependencia_nro.Size = New System.Drawing.Size(144, 20)
        Me.txt_dependencia_nro.TabIndex = 7
        '
        'txt_dependencia_nombre
        '
        Me.txt_dependencia_nombre.Location = New System.Drawing.Point(12, 191)
        Me.txt_dependencia_nombre.Name = "txt_dependencia_nombre"
        Me.txt_dependencia_nombre.Size = New System.Drawing.Size(144, 20)
        Me.txt_dependencia_nombre.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Dependencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Persona"
        '
        'txt_persona_dni
        '
        Me.txt_persona_dni.Location = New System.Drawing.Point(222, 139)
        Me.txt_persona_dni.Name = "txt_persona_dni"
        Me.txt_persona_dni.Size = New System.Drawing.Size(144, 20)
        Me.txt_persona_dni.TabIndex = 11
        '
        'txt_persona_apellido
        '
        Me.txt_persona_apellido.Location = New System.Drawing.Point(222, 165)
        Me.txt_persona_apellido.Name = "txt_persona_apellido"
        Me.txt_persona_apellido.Size = New System.Drawing.Size(144, 20)
        Me.txt_persona_apellido.TabIndex = 12
        '
        'txt_persona_nombre
        '
        Me.txt_persona_nombre.Location = New System.Drawing.Point(222, 191)
        Me.txt_persona_nombre.Name = "txt_persona_nombre"
        Me.txt_persona_nombre.Size = New System.Drawing.Size(144, 20)
        Me.txt_persona_nombre.TabIndex = 13
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(12, 270)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 14
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dgv_personaDependencia
        '
        Me.dgv_personaDependencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_personaDependencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nroCuenta, Me.apellido, Me.nombre, Me.documento})
        Me.dgv_personaDependencia.Location = New System.Drawing.Point(416, 21)
        Me.dgv_personaDependencia.Name = "dgv_personaDependencia"
        Me.dgv_personaDependencia.Size = New System.Drawing.Size(442, 244)
        Me.dgv_personaDependencia.TabIndex = 15
        '
        'nroCuenta
        '
        Me.nroCuenta.HeaderText = "Numero de Cuenta"
        Me.nroCuenta.Name = "nroCuenta"
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombres"
        Me.nombre.Name = "nombre"
        '
        'documento
        '
        Me.documento.HeaderText = "Numero de Documento"
        Me.documento.Name = "documento"
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Location = New System.Drawing.Point(93, 270)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Borrar.TabIndex = 16
        Me.btn_Borrar.Text = "Borrar"
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_dependencia
        '
        Me.btn_dependencia.Location = New System.Drawing.Point(162, 40)
        Me.btn_dependencia.Name = "btn_dependencia"
        Me.btn_dependencia.Size = New System.Drawing.Size(17, 20)
        Me.btn_dependencia.TabIndex = 17
        Me.btn_dependencia.Text = "+"
        Me.btn_dependencia.UseVisualStyleBackColor = True
        '
        'btn_persona_empleado
        '
        Me.btn_persona_empleado.Location = New System.Drawing.Point(372, 37)
        Me.btn_persona_empleado.Name = "btn_persona_empleado"
        Me.btn_persona_empleado.Size = New System.Drawing.Size(17, 21)
        Me.btn_persona_empleado.TabIndex = 18
        Me.btn_persona_empleado.Text = "+"
        Me.btn_persona_empleado.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(783, 312)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 19
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'PersonaXDependencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 360)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_persona_empleado)
        Me.Controls.Add(Me.btn_dependencia)
        Me.Controls.Add(Me.btn_Borrar)
        Me.Controls.Add(Me.dgv_personaDependencia)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_persona_nombre)
        Me.Controls.Add(Me.txt_persona_apellido)
        Me.Controls.Add(Me.txt_persona_dni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_dependencia_nombre)
        Me.Controls.Add(Me.txt_dependencia_nro)
        Me.Controls.Add(Me.txt_dependencia_descripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nroDependencia)
        Me.Controls.Add(Me.btn_buscarPersona)
        Me.Controls.Add(Me.btn_buscarDependencia)
        Me.Name = "PersonaXDependencia"
        Me.Text = "PersonaXDependecia"
        CType(Me.dgv_personaDependencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscarDependencia As Button
    Friend WithEvents btn_buscarPersona As Button
    Friend WithEvents txt_nroDependencia As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_documento As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_dependencia_descripcion As TextBox
    Friend WithEvents txt_dependencia_nro As TextBox
    Friend WithEvents txt_dependencia_nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_persona_dni As TextBox
    Friend WithEvents txt_persona_apellido As TextBox
    Friend WithEvents txt_persona_nombre As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents dgv_personaDependencia As DataGridView
    Friend WithEvents btn_Borrar As Button
    Friend WithEvents btn_dependencia As Button
    Friend WithEvents btn_persona_empleado As Button
    Friend WithEvents nroCuenta As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents documento As DataGridViewTextBoxColumn
    Friend WithEvents btn_salir As Button
End Class
