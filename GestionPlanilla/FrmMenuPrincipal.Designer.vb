<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.itemEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemPlanilla_Mensual = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.itemAcerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemEmpleados, Me.itemAyuda})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(11, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(682, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'itemEmpleados
        '
        Me.itemEmpleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subItemPlanilla_Mensual, Me.subItemSalir})
        Me.itemEmpleados.Name = "itemEmpleados"
        Me.itemEmpleados.Size = New System.Drawing.Size(115, 24)
        Me.itemEmpleados.Text = "Empleados"
        '
        'subItemPlanilla_Mensual
        '
        Me.subItemPlanilla_Mensual.Image = Global.GestionPlanilla.My.Resources.Resources._5_Outsourcing_de_Planillas
        Me.subItemPlanilla_Mensual.Name = "subItemPlanilla_Mensual"
        Me.subItemPlanilla_Mensual.Size = New System.Drawing.Size(221, 26)
        Me.subItemPlanilla_Mensual.Text = "Planilla Mensual"
        '
        'subItemSalir
        '
        Me.subItemSalir.Image = Global.GestionPlanilla.My.Resources.Resources.Salir
        Me.subItemSalir.Name = "subItemSalir"
        Me.subItemSalir.Size = New System.Drawing.Size(221, 26)
        Me.subItemSalir.Text = "Salir"
        '
        'itemAyuda
        '
        Me.itemAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.itemAcerca})
        Me.itemAyuda.Name = "itemAyuda"
        Me.itemAyuda.Size = New System.Drawing.Size(75, 24)
        Me.itemAyuda.Text = "Ay&uda"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(183, 6)
        '
        'itemAcerca
        '
        Me.itemAcerca.Image = Global.GestionPlanilla.My.Resources.Resources._2000px_Gtk_dialog_info_svg
        Me.itemAcerca.Name = "itemAcerca"
        Me.itemAcerca.Size = New System.Drawing.Size(216, 26)
        Me.itemAcerca.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 26, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(682, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 553)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents itemAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents itemAcerca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents itemEmpleados As ToolStripMenuItem
    Friend WithEvents subItemPlanilla_Mensual As ToolStripMenuItem
    Friend WithEvents subItemSalir As ToolStripMenuItem
End Class
