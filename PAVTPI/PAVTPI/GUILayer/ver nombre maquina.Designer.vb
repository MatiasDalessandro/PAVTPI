﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ver_nombre_maquina
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
        Me.txt_nomMaquina = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_nomMaquina
        '
        Me.txt_nomMaquina.Location = New System.Drawing.Point(39, 75)
        Me.txt_nomMaquina.Name = "txt_nomMaquina"
        Me.txt_nomMaquina.Size = New System.Drawing.Size(196, 20)
        Me.txt_nomMaquina.TabIndex = 0
        '
        'ver_nombre_maquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.txt_nomMaquina)
        Me.Name = "ver_nombre_maquina"
        Me.Text = "ver_nombre_maquina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nomMaquina As TextBox
End Class
