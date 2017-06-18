<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmTipoDocumento
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
        Me.lbl_Nombre_Tipo_Doc = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.dgv_Tipo_Doc = New System.Windows.Forms.DataGridView()
        Me.Id_Tipo_Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Tipo_Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.lbl_Id_Tipo_Doc = New System.Windows.Forms.Label()
        Me.txt_Id_Tipo_Doc = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_Tipo_Doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Nombre_Tipo_Doc
        '
        Me.lbl_Nombre_Tipo_Doc.AutoSize = True
        Me.lbl_Nombre_Tipo_Doc.Location = New System.Drawing.Point(9, 26)
        Me.lbl_Nombre_Tipo_Doc.Name = "lbl_Nombre_Tipo_Doc"
        Me.lbl_Nombre_Tipo_Doc.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre_Tipo_Doc.TabIndex = 1
        Me.lbl_Nombre_Tipo_Doc.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Enabled = False
        Me.txt_Nombre.Location = New System.Drawing.Point(68, 19)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 3
        '
        'dgv_Tipo_Doc
        '
        Me.dgv_Tipo_Doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Tipo_Doc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Tipo_Doc, Me.Nombre_Tipo_Doc})
        Me.dgv_Tipo_Doc.Location = New System.Drawing.Point(235, 12)
        Me.dgv_Tipo_Doc.Name = "dgv_Tipo_Doc"
        Me.dgv_Tipo_Doc.Size = New System.Drawing.Size(384, 132)
        Me.dgv_Tipo_Doc.TabIndex = 4
        '
        'Id_Tipo_Doc
        '
        Me.Id_Tipo_Doc.HeaderText = "ID"
        Me.Id_Tipo_Doc.Name = "Id_Tipo_Doc"
        '
        'Nombre_Tipo_Doc
        '
        Me.Nombre_Tipo_Doc.HeaderText = "Nombre"
        Me.Nombre_Tipo_Doc.Name = "Nombre_Tipo_Doc"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Location = New System.Drawing.Point(9, 162)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Nuevo.TabIndex = 5
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Location = New System.Drawing.Point(90, 162)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(171, 162)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 7
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(318, 162)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 8
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'lbl_Id_Tipo_Doc
        '
        Me.lbl_Id_Tipo_Doc.AutoSize = True
        Me.lbl_Id_Tipo_Doc.Location = New System.Drawing.Point(35, 52)
        Me.lbl_Id_Tipo_Doc.Name = "lbl_Id_Tipo_Doc"
        Me.lbl_Id_Tipo_Doc.Size = New System.Drawing.Size(18, 13)
        Me.lbl_Id_Tipo_Doc.TabIndex = 0
        Me.lbl_Id_Tipo_Doc.Text = "ID"
        '
        'txt_Id_Tipo_Doc
        '
        Me.txt_Id_Tipo_Doc.Enabled = False
        Me.txt_Id_Tipo_Doc.Location = New System.Drawing.Point(68, 45)
        Me.txt_Id_Tipo_Doc.Mask = "999"
        Me.txt_Id_Tipo_Doc.Name = "txt_Id_Tipo_Doc"
        Me.txt_Id_Tipo_Doc.Size = New System.Drawing.Size(100, 20)
        Me.txt_Id_Tipo_Doc.TabIndex = 2
        '
        'AbmTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 193)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.dgv_Tipo_Doc)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Id_Tipo_Doc)
        Me.Controls.Add(Me.lbl_Nombre_Tipo_Doc)
        Me.Controls.Add(Me.lbl_Id_Tipo_Doc)
        Me.Name = "AbmTipoDocumento"
        Me.Text = "AbmTipoDocumento"
        CType(Me.dgv_Tipo_Doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Nombre_Tipo_Doc As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents dgv_Tipo_Doc As DataGridView
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents Id_Tipo_Doc As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Tipo_Doc As DataGridViewTextBoxColumn
    Friend WithEvents lbl_Id_Tipo_Doc As Label
    Friend WithEvents txt_Id_Tipo_Doc As MaskedTextBox
End Class
