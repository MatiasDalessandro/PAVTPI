<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosParaCombo
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
        Me.btn_agregarACombo = New System.Windows.Forms.Button()
        Me.dgv_datos_articulos = New System.Windows.Forms.DataGridView()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.id_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_datos_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_agregarACombo
        '
        Me.btn_agregarACombo.Location = New System.Drawing.Point(175, 415)
        Me.btn_agregarACombo.Name = "btn_agregarACombo"
        Me.btn_agregarACombo.Size = New System.Drawing.Size(102, 23)
        Me.btn_agregarACombo.TabIndex = 0
        Me.btn_agregarACombo.Text = "Agregar a Combo"
        Me.btn_agregarACombo.UseVisualStyleBackColor = True
        '
        'dgv_datos_articulos
        '
        Me.dgv_datos_articulos.AllowUserToAddRows = False
        Me.dgv_datos_articulos.AllowUserToDeleteRows = False
        Me.dgv_datos_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_articulo, Me.nombre_articulo, Me.precio_articulo})
        Me.dgv_datos_articulos.Location = New System.Drawing.Point(12, 12)
        Me.dgv_datos_articulos.Name = "dgv_datos_articulos"
        Me.dgv_datos_articulos.ReadOnly = True
        Me.dgv_datos_articulos.Size = New System.Drawing.Size(447, 380)
        Me.dgv_datos_articulos.TabIndex = 31
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(383, 415)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 32
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'id_articulo
        '
        Me.id_articulo.HeaderText = "ID Articulo"
        Me.id_articulo.Name = "id_articulo"
        Me.id_articulo.ReadOnly = True
        Me.id_articulo.Width = 80
        '
        'nombre_articulo
        '
        Me.nombre_articulo.HeaderText = "Nombre Articulo"
        Me.nombre_articulo.Name = "nombre_articulo"
        Me.nombre_articulo.ReadOnly = True
        Me.nombre_articulo.Width = 250
        '
        'precio_articulo
        '
        Me.precio_articulo.HeaderText = "Precio"
        Me.precio_articulo.Name = "precio_articulo"
        Me.precio_articulo.ReadOnly = True
        Me.precio_articulo.Width = 70
        '
        'ArticulosParaCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 450)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_datos_articulos)
        Me.Controls.Add(Me.btn_agregarACombo)
        Me.Name = "ArticulosParaCombo"
        Me.Text = "ArticulosParaCombo"
        CType(Me.dgv_datos_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_agregarACombo As Button
    Friend WithEvents dgv_datos_articulos As DataGridView
    Friend WithEvents btn_salir As Button
    Friend WithEvents id_articulo As DataGridViewTextBoxColumn
    Friend WithEvents nombre_articulo As DataGridViewTextBoxColumn
    Friend WithEvents precio_articulo As DataGridViewTextBoxColumn
End Class
