<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmRol
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
        Me.dgv_datos_rol = New System.Windows.Forms.DataGridView()
        Me.c_id_rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre_rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_nombre_rol = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_articulo = New System.Windows.Forms.Label()
        Me.lbl_id_articulo = New System.Windows.Forms.Label()
        Me.msk_idRol = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_datos_rol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_datos_rol
        '
        Me.dgv_datos_rol.AllowUserToAddRows = False
        Me.dgv_datos_rol.AllowUserToDeleteRows = False
        Me.dgv_datos_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_rol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_id_rol, Me.c_nombre_rol})
        Me.dgv_datos_rol.Location = New System.Drawing.Point(12, 12)
        Me.dgv_datos_rol.Name = "dgv_datos_rol"
        Me.dgv_datos_rol.ReadOnly = True
        Me.dgv_datos_rol.Size = New System.Drawing.Size(448, 285)
        Me.dgv_datos_rol.TabIndex = 27
        '
        'c_id_rol
        '
        Me.c_id_rol.HeaderText = "ID Rol"
        Me.c_id_rol.Name = "c_id_rol"
        Me.c_id_rol.ReadOnly = True
        '
        'c_nombre_rol
        '
        Me.c_nombre_rol.HeaderText = "Nombre Rol"
        Me.c_nombre_rol.Name = "c_nombre_rol"
        Me.c_nombre_rol.ReadOnly = True
        Me.c_nombre_rol.Width = 300
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(352, 415)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 22
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(271, 415)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 23
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(109, 415)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 24
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(190, 415)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 25
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(28, 415)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 26
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_nombre_rol
        '
        Me.txt_nombre_rol.Enabled = False
        Me.txt_nombre_rol.Location = New System.Drawing.Point(190, 348)
        Me.txt_nombre_rol.Name = "txt_nombre_rol"
        Me.txt_nombre_rol.Size = New System.Drawing.Size(156, 20)
        Me.txt_nombre_rol.TabIndex = 20
        '
        'lbl_nombre_articulo
        '
        Me.lbl_nombre_articulo.AutoSize = True
        Me.lbl_nombre_articulo.Location = New System.Drawing.Point(102, 351)
        Me.lbl_nombre_articulo.Name = "lbl_nombre_articulo"
        Me.lbl_nombre_articulo.Size = New System.Drawing.Size(63, 13)
        Me.lbl_nombre_articulo.TabIndex = 19
        Me.lbl_nombre_articulo.Text = "Nombre Rol"
        '
        'lbl_id_articulo
        '
        Me.lbl_id_articulo.AutoSize = True
        Me.lbl_id_articulo.Location = New System.Drawing.Point(128, 318)
        Me.lbl_id_articulo.Name = "lbl_id_articulo"
        Me.lbl_id_articulo.Size = New System.Drawing.Size(37, 13)
        Me.lbl_id_articulo.TabIndex = 18
        Me.lbl_id_articulo.Text = "ID Rol"
        '
        'msk_idRol
        '
        Me.msk_idRol.Location = New System.Drawing.Point(190, 310)
        Me.msk_idRol.Mask = "99"
        Me.msk_idRol.Name = "msk_idRol"
        Me.msk_idRol.Size = New System.Drawing.Size(100, 20)
        Me.msk_idRol.TabIndex = 28
        '
        'AbmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 446)
        Me.Controls.Add(Me.msk_idRol)
        Me.Controls.Add(Me.dgv_datos_rol)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_nombre_rol)
        Me.Controls.Add(Me.lbl_nombre_articulo)
        Me.Controls.Add(Me.lbl_id_articulo)
        Me.Name = "AbmRol"
        Me.Text = "AbmRol"
        CType(Me.dgv_datos_rol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_datos_rol As DataGridView
    Friend WithEvents c_id_rol As DataGridViewTextBoxColumn
    Friend WithEvents c_nombre_rol As DataGridViewTextBoxColumn
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents txt_nombre_rol As TextBox
    Friend WithEvents lbl_nombre_articulo As Label
    Friend WithEvents lbl_id_articulo As Label
    Friend WithEvents msk_idRol As MaskedTextBox
End Class
