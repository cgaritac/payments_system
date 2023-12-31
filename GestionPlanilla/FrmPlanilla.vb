Public Class FrmPlanilla
    Dim Datosempleados As New DatosPlanilla
    Dim codigoID As Integer = 1

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        tbCedula.Text = ""
        tbNombre.Text = ""
        tbApellidos.Text = ""
        tbDepartamento.Text = ""
        tbTelefono.Text = ""
        dtpFechaPago.ResetText()
        tbSalario.Text = ""
        txtBanco.Text = ""
        txtCCSS.Text = ""
        txtSalarioaPagar.Text = ""
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim mensaje As String = ""
        Dim cedEmpleado As Integer = 0

        Try
            If Not String.IsNullOrEmpty(tbCedula.Text) And Not String.IsNullOrEmpty(tbNombre.Text) And Not String.IsNullOrEmpty(tbApellidos.Text) And Not String.IsNullOrEmpty(tbDepartamento.Text) And Not String.IsNullOrEmpty(tbSalario.Text) And Not String.IsNullOrEmpty(txtBanco.Text) And Not String.IsNullOrEmpty(txtCCSS.Text) Then
                cedEmpleado = CType(tbCedula.Text, Integer)
                Datosempleados.GUARDAR_SALARIO(codigoID, cedEmpleado, tbNombre.Text, tbApellidos.Text, tbDepartamento.Text, tbTelefono.Text, tbSalario.Text, txtCCSS.Text, txtBanco.Text, dtpFechaPago.Value, mensaje)
                MessageBox.Show("Datos ingresados correctamente")
                codigoID = codigoID + 1
            Else
                MessageBox.Show("Faltan campos de completar en el formulario")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("El número de cédula ya existe en la base de datos")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cedEmpleado As Integer = 0
        Dim mensaje As String = ""
        Try
            If Not String.IsNullOrEmpty(tbCedula.Text) Then
                cedEmpleado = CType(tbCedula.Text, Integer)
                Datosempleados.ELIMINAR(tbCedula.Text, mensaje)
                MessageBox.Show(mensaje)
            Else
                MessageBox.Show("No es posible eliminar un trabajador si no indica el número de cédula")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cedEmpleado As Integer = 0
        Dim registros
        Dim mensaje As String = ""
        Dim deducciones As Double = 0

        Try
            If Not String.IsNullOrEmpty(tbCedula.Text) Then
                tbCedula.Text = tbCedula.Text.Trim()
                cedEmpleado = CType(tbCedula.Text, Integer)

                registros = Datosempleados.BUSCAR(cedEmpleado, mensaje)
                For Each registro In registros
                    tbNombre.Text = registro.NOMBRE
                    tbApellidos.Text = registro.APELLIDOS
                    tbDepartamento.Text = registro.DEPARTAMENTO
                    tbTelefono.Text = registro.TELEFONO
                    tbSalario.Text = registro.SALARIOMENSUAL
                    txtBanco.Text = registro.BANCOPOPULAR
                    txtCCSS.Text = registro.CCSS
                    dtpFechaPago.Value = registro.FECHADEPAGO
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub tbSalario_TextChanged(sender As Object, e As EventArgs) Handles tbSalario.TextChanged
        Dim salario As Double = 0
        Dim deducciones As Double = 0
        If tbSalario.Text = "" Then

        Else
            salario = tbSalario.Text
            txtBanco.Text = salario * 0.01
            txtCCSS.Text = salario * 0.0934
            deducciones = tbSalario.Text - txtBanco.Text - txtCCSS.Text
            txtSalarioaPagar.Text = deducciones
        End If

    End Sub

    Private Sub tbSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSalario.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub
End Class
