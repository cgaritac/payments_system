<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlanilla
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
        Me.tbCedula = New System.Windows.Forms.TextBox()
        Me.tbSalario = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDepartamento = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSalarioaPagar = New System.Windows.Forms.TextBox()
        Me.txtCCSS = New System.Windows.Forms.TextBox()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.lblCalcCed = New System.Windows.Forms.Label()
        Me.lblCalcNomb = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCedula
        '
        Me.tbCedula.Location = New System.Drawing.Point(183, 30)
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(134, 28)
        Me.tbCedula.TabIndex = 0
        '
        'tbSalario
        '
        Me.tbSalario.Location = New System.Drawing.Point(183, 234)
        Me.tbSalario.Name = "tbSalario"
        Me.tbSalario.Size = New System.Drawing.Size(134, 28)
        Me.tbSalario.TabIndex = 1
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(183, 166)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(134, 28)
        Me.tbTelefono.TabIndex = 2
        '
        'tbDepartamento
        '
        Me.tbDepartamento.Location = New System.Drawing.Point(183, 132)
        Me.tbDepartamento.Name = "tbDepartamento"
        Me.tbDepartamento.Size = New System.Drawing.Size(134, 28)
        Me.tbDepartamento.TabIndex = 3
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(183, 98)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(134, 28)
        Me.tbApellidos.TabIndex = 4
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(183, 64)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(134, 28)
        Me.tbNombre.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSalarioaPagar)
        Me.GroupBox1.Controls.Add(Me.txtCCSS)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(347, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 164)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deducciones"
        '
        'txtSalarioaPagar
        '
        Me.txtSalarioaPagar.Enabled = False
        Me.txtSalarioaPagar.Location = New System.Drawing.Point(230, 105)
        Me.txtSalarioaPagar.Name = "txtSalarioaPagar"
        Me.txtSalarioaPagar.Size = New System.Drawing.Size(133, 28)
        Me.txtSalarioaPagar.TabIndex = 22
        '
        'txtCCSS
        '
        Me.txtCCSS.Enabled = False
        Me.txtCCSS.Location = New System.Drawing.Point(230, 68)
        Me.txtCCSS.Name = "txtCCSS"
        Me.txtCCSS.Size = New System.Drawing.Size(133, 28)
        Me.txtCCSS.TabIndex = 22
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(230, 31)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(133, 28)
        Me.txtBanco.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Banco Popular 1%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CCSS 9,34%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Salario a pagar: "
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Location = New System.Drawing.Point(183, 200)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(236, 28)
        Me.dtpFechaPago.TabIndex = 7
        '
        'lblCalcCed
        '
        Me.lblCalcCed.AutoSize = True
        Me.lblCalcCed.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcCed.Location = New System.Drawing.Point(22, 33)
        Me.lblCalcCed.Name = "lblCalcCed"
        Me.lblCalcCed.Size = New System.Drawing.Size(80, 20)
        Me.lblCalcCed.TabIndex = 8
        Me.lblCalcCed.Text = "Cédula:"
        '
        'lblCalcNomb
        '
        Me.lblCalcNomb.AutoSize = True
        Me.lblCalcNomb.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcNomb.Location = New System.Drawing.Point(22, 67)
        Me.lblCalcNomb.Name = "lblCalcNomb"
        Me.lblCalcNomb.Size = New System.Drawing.Size(91, 20)
        Me.lblCalcNomb.TabIndex = 11
        Me.lblCalcNomb.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Apellidos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Departamento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Teléfono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha de pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Salario"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(35, 298)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(108, 34)
        Me.btnRegistrar.TabIndex = 17
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(193, 298)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 34)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(341, 298)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(97, 34)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(485, 298)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(96, 34)
        Me.btnLimpiar.TabIndex = 20
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(630, 298)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 34)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 353)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCalcNomb)
        Me.Controls.Add(Me.lblCalcCed)
        Me.Controls.Add(Me.dtpFechaPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbApellidos)
        Me.Controls.Add(Me.tbDepartamento)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.tbSalario)
        Me.Controls.Add(Me.tbCedula)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo de Planilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCedula As TextBox
    Friend WithEvents tbSalario As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbDepartamento As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents lblCalcCed As Label
    Friend WithEvents lblCalcNomb As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtSalarioaPagar As TextBox
    Friend WithEvents txtCCSS As TextBox
    Friend WithEvents txtBanco As TextBox
End Class
