<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Botones
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
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnPersAut = New System.Windows.Forms.Button()
        Me.btnTipoPersona = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmpleado
        '
        Me.btnEmpleado.Location = New System.Drawing.Point(12, 46)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpleado.TabIndex = 0
        Me.btnEmpleado.Text = "Empleado"
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnPersAut
        '
        Me.btnPersAut.Location = New System.Drawing.Point(112, 46)
        Me.btnPersAut.Name = "btnPersAut"
        Me.btnPersAut.Size = New System.Drawing.Size(131, 23)
        Me.btnPersAut.TabIndex = 0
        Me.btnPersAut.Text = "Persona autorizada"
        Me.btnPersAut.UseVisualStyleBackColor = True
        '
        'btnTipoPersona
        '
        Me.btnTipoPersona.AutoSize = True
        Me.btnTipoPersona.Location = New System.Drawing.Point(38, 18)
        Me.btnTipoPersona.Name = "btnTipoPersona"
        Me.btnTipoPersona.Size = New System.Drawing.Size(189, 13)
        Me.btnTipoPersona.TabIndex = 1
        Me.btnTipoPersona.Text = "Seleccione el tipo de persona a cargar"
        '
        'Botones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 86)
        Me.Controls.Add(Me.btnTipoPersona)
        Me.Controls.Add(Me.btnPersAut)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Name = "Botones"
        Me.Text = "Botones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmpleado As Button
    Friend WithEvents btnPersAut As Button
    Friend WithEvents btnTipoPersona As Label
End Class
