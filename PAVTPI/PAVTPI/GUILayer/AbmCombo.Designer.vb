<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbmCombo
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
        Me.dgv_datos_articulos = New System.Windows.Forms.DataGridView()
        Me.c_id_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_precio_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borrar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_nombre_articulo = New System.Windows.Forms.TextBox()
        Me.txt_id_combo = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_combo = New System.Windows.Forms.Label()
        Me.lbl_id_combo = New System.Windows.Forms.Label()
        Me.btn_agregar_articulo = New System.Windows.Forms.Button()
        Me.btn_quitar_articulo = New System.Windows.Forms.Button()
        Me.btn_editar_combo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_datos_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_datos_articulos
        '
        Me.dgv_datos_articulos.AllowUserToDeleteRows = False
        Me.dgv_datos_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_id_articulo, Me.c_nombre_articulo, Me.c_precio_articulo, Me.Borrar})
        Me.dgv_datos_articulos.Location = New System.Drawing.Point(27, 148)
        Me.dgv_datos_articulos.Name = "dgv_datos_articulos"
        Me.dgv_datos_articulos.ReadOnly = True
        Me.dgv_datos_articulos.Size = New System.Drawing.Size(463, 228)
        Me.dgv_datos_articulos.TabIndex = 30
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
        'Borrar
        '
        Me.Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Borrar.HeaderText = "      "
        Me.Borrar.Image = Global.PAVTPI.My.Resources.Resources.X_Para_borrar_100_100
        Me.Borrar.Name = "Borrar"
        Me.Borrar.ReadOnly = True
        Me.Borrar.Width = 21
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(292, 33)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 25
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(346, 451)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 26
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(98, 451)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 27
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(222, 451)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 28
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_nombre_articulo
        '
        Me.txt_nombre_articulo.Enabled = False
        Me.txt_nombre_articulo.Location = New System.Drawing.Point(125, 71)
        Me.txt_nombre_articulo.Name = "txt_nombre_articulo"
        Me.txt_nombre_articulo.Size = New System.Drawing.Size(156, 20)
        Me.txt_nombre_articulo.TabIndex = 23
        '
        'txt_id_combo
        '
        Me.txt_id_combo.Location = New System.Drawing.Point(125, 36)
        Me.txt_id_combo.Name = "txt_id_combo"
        Me.txt_id_combo.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_combo.TabIndex = 24
        '
        'lbl_nombre_combo
        '
        Me.lbl_nombre_combo.AutoSize = True
        Me.lbl_nombre_combo.Location = New System.Drawing.Point(24, 74)
        Me.lbl_nombre_combo.Name = "lbl_nombre_combo"
        Me.lbl_nombre_combo.Size = New System.Drawing.Size(80, 13)
        Me.lbl_nombre_combo.TabIndex = 20
        Me.lbl_nombre_combo.Text = "Nombre Combo"
        '
        'lbl_id_combo
        '
        Me.lbl_id_combo.AutoSize = True
        Me.lbl_id_combo.Location = New System.Drawing.Point(24, 39)
        Me.lbl_id_combo.Name = "lbl_id_combo"
        Me.lbl_id_combo.Size = New System.Drawing.Size(54, 13)
        Me.lbl_id_combo.TabIndex = 19
        Me.lbl_id_combo.Text = "ID Combo"
        '
        'btn_agregar_articulo
        '
        Me.btn_agregar_articulo.Location = New System.Drawing.Point(29, 393)
        Me.btn_agregar_articulo.Name = "btn_agregar_articulo"
        Me.btn_agregar_articulo.Size = New System.Drawing.Size(90, 23)
        Me.btn_agregar_articulo.TabIndex = 31
        Me.btn_agregar_articulo.Text = "Agregar Articulo"
        Me.btn_agregar_articulo.UseVisualStyleBackColor = True
        '
        'btn_quitar_articulo
        '
        Me.btn_quitar_articulo.Location = New System.Drawing.Point(138, 393)
        Me.btn_quitar_articulo.Name = "btn_quitar_articulo"
        Me.btn_quitar_articulo.Size = New System.Drawing.Size(78, 23)
        Me.btn_quitar_articulo.TabIndex = 32
        Me.btn_quitar_articulo.Text = "Quitar Artitulo"
        Me.btn_quitar_articulo.UseVisualStyleBackColor = True
        '
        'btn_editar_combo
        '
        Me.btn_editar_combo.Location = New System.Drawing.Point(409, 393)
        Me.btn_editar_combo.Name = "btn_editar_combo"
        Me.btn_editar_combo.Size = New System.Drawing.Size(81, 23)
        Me.btn_editar_combo.TabIndex = 33
        Me.btn_editar_combo.Text = "Editar Combo"
        Me.btn_editar_combo.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(517, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'AbmCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 490)
        Me.Controls.Add(Me.btn_editar_combo)
        Me.Controls.Add(Me.btn_quitar_articulo)
        Me.Controls.Add(Me.btn_agregar_articulo)
        Me.Controls.Add(Me.dgv_datos_articulos)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txt_nombre_articulo)
        Me.Controls.Add(Me.txt_id_combo)
        Me.Controls.Add(Me.lbl_nombre_combo)
        Me.Controls.Add(Me.lbl_id_combo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AbmCombo"
        Me.Text = "AbmCombo"
        CType(Me.dgv_datos_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_datos_articulos As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_nombre_articulo As TextBox
    Friend WithEvents txt_id_combo As TextBox
    Friend WithEvents lbl_nombre_combo As Label
    Friend WithEvents lbl_id_combo As Label
    Friend WithEvents c_id_articulo As DataGridViewTextBoxColumn
    Friend WithEvents c_nombre_articulo As DataGridViewTextBoxColumn
    Friend WithEvents c_precio_articulo As DataGridViewTextBoxColumn
    Friend WithEvents Borrar As DataGridViewImageColumn
    Friend WithEvents btn_agregar_articulo As Button
    Friend WithEvents btn_quitar_articulo As Button
    Friend WithEvents btn_editar_combo As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
End Class
