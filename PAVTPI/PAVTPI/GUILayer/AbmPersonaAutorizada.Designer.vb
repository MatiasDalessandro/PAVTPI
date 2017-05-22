<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbmPersonaAutorizada
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
        Me.cmbTipoDocPA = New System.Windows.Forms.ComboBox()
        Me.mskNroDocPA = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombrePA = New System.Windows.Forms.TextBox()
        Me.txtApellidoPA = New System.Windows.Forms.TextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDependencia = New System.Windows.Forms.Label()
        Me.cmbDependencia = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.dgvPersAut = New System.Windows.Forms.DataGridView()
        Me.cApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDependencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPersAut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoDocPA
        '
        Me.cmbTipoDocPA.FormattingEnabled = True
        Me.cmbTipoDocPA.Location = New System.Drawing.Point(129, 118)
        Me.cmbTipoDocPA.Name = "cmbTipoDocPA"
        Me.cmbTipoDocPA.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoDocPA.TabIndex = 25
        '
        'mskNroDocPA
        '
        Me.mskNroDocPA.Location = New System.Drawing.Point(129, 88)
        Me.mskNroDocPA.Mask = "99999999"
        Me.mskNroDocPA.Name = "mskNroDocPA"
        Me.mskNroDocPA.Size = New System.Drawing.Size(100, 20)
        Me.mskNroDocPA.TabIndex = 24
        '
        'txtNombrePA
        '
        Me.txtNombrePA.Enabled = False
        Me.txtNombrePA.Location = New System.Drawing.Point(129, 58)
        Me.txtNombrePA.Name = "txtNombrePA"
        Me.txtNombrePA.Size = New System.Drawing.Size(156, 20)
        Me.txtNombrePA.TabIndex = 23
        '
        'txtApellidoPA
        '
        Me.txtApellidoPA.Location = New System.Drawing.Point(129, 28)
        Me.txtApellidoPA.Name = "txtApellidoPA"
        Me.txtApellidoPA.Size = New System.Drawing.Size(156, 20)
        Me.txtApellidoPA.TabIndex = 22
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(22, 123)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(101, 13)
        Me.lblTipoDoc.TabIndex = 28
        Me.lblTipoDoc.Text = "Tipo de Documento"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(6, 91)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(117, 13)
        Me.lblNroDoc.TabIndex = 29
        Me.lblNroDoc.Text = "Numero de Documento"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(79, 61)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 27
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(79, 31)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 26
        Me.lblApellido.Text = "Apellido"
        '
        'lblDependencia
        '
        Me.lblDependencia.AutoSize = True
        Me.lblDependencia.Location = New System.Drawing.Point(52, 152)
        Me.lblDependencia.Name = "lblDependencia"
        Me.lblDependencia.Size = New System.Drawing.Size(71, 13)
        Me.lblDependencia.TabIndex = 28
        Me.lblDependencia.Text = "Dependencia"
        '
        'cmbDependencia
        '
        Me.cmbDependencia.FormattingEnabled = True
        Me.cmbDependencia.Location = New System.Drawing.Point(129, 149)
        Me.cmbDependencia.Name = "cmbDependencia"
        Me.cmbDependencia.Size = New System.Drawing.Size(121, 21)
        Me.cmbDependencia.TabIndex = 25
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(254, 274)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 33
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(92, 274)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 31
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(173, 274)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 32
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(11, 274)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 30
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'dgvPersAut
        '
        Me.dgvPersAut.AllowUserToAddRows = False
        Me.dgvPersAut.AllowUserToDeleteRows = False
        Me.dgvPersAut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersAut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cApellido, Me.cNombre, Me.cNroDoc, Me.cDependencia})
        Me.dgvPersAut.Location = New System.Drawing.Point(369, 12)
        Me.dgvPersAut.Name = "dgvPersAut"
        Me.dgvPersAut.ReadOnly = True
        Me.dgvPersAut.Size = New System.Drawing.Size(455, 285)
        Me.dgvPersAut.TabIndex = 34
        '
        'cApellido
        '
        Me.cApellido.HeaderText = "Apellido"
        Me.cApellido.Name = "cApellido"
        Me.cApellido.ReadOnly = True
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        '
        'cNroDoc
        '
        Me.cNroDoc.HeaderText = "Nro. Documento"
        Me.cNroDoc.Name = "cNroDoc"
        Me.cNroDoc.ReadOnly = True
        '
        'cDependencia
        '
        Me.cDependencia.HeaderText = "Dependencia"
        Me.cDependencia.Name = "cDependencia"
        Me.cDependencia.ReadOnly = True
        '
        'AbmPersonaAutorizada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 312)
        Me.Controls.Add(Me.dgvPersAut)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.cmbDependencia)
        Me.Controls.Add(Me.cmbTipoDocPA)
        Me.Controls.Add(Me.mskNroDocPA)
        Me.Controls.Add(Me.txtNombrePA)
        Me.Controls.Add(Me.txtApellidoPA)
        Me.Controls.Add(Me.lblDependencia)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Name = "AbmPersonaAutorizada"
        Me.Text = "AbmPersonaAutorizada"
        CType(Me.dgvPersAut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTipoDocPA As ComboBox
    Friend WithEvents mskNroDocPA As MaskedTextBox
    Friend WithEvents txtNombrePA As TextBox
    Friend WithEvents txtApellidoPA As TextBox
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblDependencia As Label
    Friend WithEvents cmbDependencia As ComboBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents dgvPersAut As DataGridView
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cNroDoc As DataGridViewTextBoxColumn
    Friend WithEvents cDependencia As DataGridViewTextBoxColumn
End Class
