<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmArticulo
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
        Me.dgv_datos_articulos = New System.Windows.Forms.DataGridView()
        Me.c_id_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_precio_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_nombre_articulo = New System.Windows.Forms.TextBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_nombre_articulo = New System.Windows.Forms.Label()
        Me.lbl_id_articulo = New System.Windows.Forms.Label()
        Me.msk_IdArticulo = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_datos_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_datos_articulos
        '
        Me.dgv_datos_articulos.AllowUserToAddRows = False
        Me.dgv_datos_articulos.AllowUserToDeleteRows = False
        Me.dgv_datos_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_id_articulo, Me.c_nombre_articulo, Me.c_precio_articulo})
        Me.dgv_datos_articulos.Location = New System.Drawing.Point(309, 12)
        Me.dgv_datos_articulos.Name = "dgv_datos_articulos"
        Me.dgv_datos_articulos.ReadOnly = True
        Me.dgv_datos_articulos.Size = New System.Drawing.Size(446, 272)
        Me.dgv_datos_articulos.TabIndex = 18
        '
        'c_id_articulo
        '
        Me.c_id_articulo.HeaderText = "ID Articulo"
        Me.c_id_articulo.Name = "c_id_articulo"
        Me.c_id_articulo.ReadOnly = True
        Me.c_id_articulo.Width = 80
        '
        'c_nombre_articulo
        '
        Me.c_nombre_articulo.HeaderText = "Nombre Articulo"
        Me.c_nombre_articulo.Name = "c_nombre_articulo"
        Me.c_nombre_articulo.ReadOnly = True
        Me.c_nombre_articulo.Width = 250
        '
        'c_precio_articulo
        '
        Me.c_precio_articulo.HeaderText = "Precio"
        Me.c_precio_articulo.Name = "c_precio_articulo"
        Me.c_precio_articulo.ReadOnly = True
        Me.c_precio_articulo.Width = 70
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(215, 31)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 13
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(262, 298)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(100, 298)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 15
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(181, 298)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 16
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(19, 298)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 17
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txt_precio
        '
        Me.txt_precio.Enabled = False
        Me.txt_precio.Location = New System.Drawing.Point(100, 96)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 10
        '
        'txt_nombre_articulo
        '
        Me.txt_nombre_articulo.Enabled = False
        Me.txt_nombre_articulo.Location = New System.Drawing.Point(100, 66)
        Me.txt_nombre_articulo.Name = "txt_nombre_articulo"
        Me.txt_nombre_articulo.Size = New System.Drawing.Size(156, 20)
        Me.txt_nombre_articulo.TabIndex = 11
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(57, 99)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_precio.TabIndex = 9
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_nombre_articulo
        '
        Me.lbl_nombre_articulo.AutoSize = True
        Me.lbl_nombre_articulo.Location = New System.Drawing.Point(12, 69)
        Me.lbl_nombre_articulo.Name = "lbl_nombre_articulo"
        Me.lbl_nombre_articulo.Size = New System.Drawing.Size(82, 13)
        Me.lbl_nombre_articulo.TabIndex = 8
        Me.lbl_nombre_articulo.Text = "Nombre Articulo"
        '
        'lbl_id_articulo
        '
        Me.lbl_id_articulo.AutoSize = True
        Me.lbl_id_articulo.Location = New System.Drawing.Point(38, 36)
        Me.lbl_id_articulo.Name = "lbl_id_articulo"
        Me.lbl_id_articulo.Size = New System.Drawing.Size(56, 13)
        Me.lbl_id_articulo.TabIndex = 7
        Me.lbl_id_articulo.Text = "ID Articulo"
        '
        'msk_IdArticulo
        '
        Me.msk_IdArticulo.Location = New System.Drawing.Point(100, 33)
        Me.msk_IdArticulo.Mask = "99999"
        Me.msk_IdArticulo.Name = "msk_IdArticulo"
        Me.msk_IdArticulo.Size = New System.Drawing.Size(100, 20)
        Me.msk_IdArticulo.TabIndex = 19
        Me.msk_IdArticulo.ValidatingType = GetType(Integer)
        '
        'AbmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 327)
        Me.Controls.Add(Me.msk_IdArticulo)
        Me.Controls.Add(Me.dgv_datos_articulos)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_nombre_articulo)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_nombre_articulo)
        Me.Controls.Add(Me.lbl_id_articulo)
        Me.Name = "AbmArticulo"
        Me.Text = "AbmArticulo"
        CType(Me.dgv_datos_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_datos_articulos As DataGridView
    Friend WithEvents c_id_articulo As DataGridViewTextBoxColumn
    Friend WithEvents c_nombre_articulo As DataGridViewTextBoxColumn
    Friend WithEvents c_precio_articulo As DataGridViewTextBoxColumn
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_nombre_articulo As TextBox
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_nombre_articulo As Label
    Friend WithEvents lbl_id_articulo As Label
    Friend WithEvents msk_IdArticulo As MaskedTextBox
End Class
