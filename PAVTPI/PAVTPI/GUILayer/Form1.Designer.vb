﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMTipoDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMRolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMDependenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMComboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerNombreMaquinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarPersonaAutorizadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem, Me.ProcesosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(406, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMEmpleadoToolStripMenuItem, Me.ABMTipoDocumentoToolStripMenuItem, Me.ABMArticuloToolStripMenuItem, Me.ABMRolToolStripMenuItem, Me.ABMDependenciaToolStripMenuItem, Me.ABMComboToolStripMenuItem, Me.VerNombreMaquinaToolStripMenuItem})
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'ABMEmpleadoToolStripMenuItem
        '
        Me.ABMEmpleadoToolStripMenuItem.Name = "ABMEmpleadoToolStripMenuItem"
        Me.ABMEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMEmpleadoToolStripMenuItem.Text = "ABM Empleado"
        '
        'ABMTipoDocumentoToolStripMenuItem
        '
        Me.ABMTipoDocumentoToolStripMenuItem.Name = "ABMTipoDocumentoToolStripMenuItem"
        Me.ABMTipoDocumentoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMTipoDocumentoToolStripMenuItem.Text = "ABM Tipo Documento"
        '
        'ABMArticuloToolStripMenuItem
        '
        Me.ABMArticuloToolStripMenuItem.Name = "ABMArticuloToolStripMenuItem"
        Me.ABMArticuloToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMArticuloToolStripMenuItem.Text = "ABM Articulo"
        '
        'ABMRolToolStripMenuItem
        '
        Me.ABMRolToolStripMenuItem.Name = "ABMRolToolStripMenuItem"
        Me.ABMRolToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMRolToolStripMenuItem.Text = "ABM Rol"
        '
        'ABMDependenciaToolStripMenuItem
        '
        Me.ABMDependenciaToolStripMenuItem.Name = "ABMDependenciaToolStripMenuItem"
        Me.ABMDependenciaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMDependenciaToolStripMenuItem.Text = "ABM Dependencia"
        '
        'ABMComboToolStripMenuItem
        '
        Me.ABMComboToolStripMenuItem.Name = "ABMComboToolStripMenuItem"
        Me.ABMComboToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMComboToolStripMenuItem.Text = "ABM Combo"
        '
        'VerNombreMaquinaToolStripMenuItem
        '
        Me.VerNombreMaquinaToolStripMenuItem.Name = "VerNombreMaquinaToolStripMenuItem"
        Me.VerNombreMaquinaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.VerNombreMaquinaToolStripMenuItem.Text = "ver nombre maquina"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarPersonaAutorizadaToolStripMenuItem, Me.RegistrarVentaToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'CargarPersonaAutorizadaToolStripMenuItem
        '
        Me.CargarPersonaAutorizadaToolStripMenuItem.Name = "CargarPersonaAutorizadaToolStripMenuItem"
        Me.CargarPersonaAutorizadaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CargarPersonaAutorizadaToolStripMenuItem.Text = "Cargar Persona autorizada"
        '
        'RegistrarVentaToolStripMenuItem
        '
        Me.RegistrarVentaToolStripMenuItem.Name = "RegistrarVentaToolStripMenuItem"
        Me.RegistrarVentaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RegistrarVentaToolStripMenuItem.Text = "Registrar Venta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 320)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ABMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMTipoDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMArticuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMRolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMDependenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMComboToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerNombreMaquinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarPersonaAutorizadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVentaToolStripMenuItem As ToolStripMenuItem
End Class
