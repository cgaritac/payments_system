Imports System.Windows.Forms

Public Class FrmMenuPrincipal
    Private Sub subItemSalir_Click(sender As Object, e As EventArgs) Handles subItemSalir.Click
        End
    End Sub

    Private Sub subItemPlanilla_Mensual_Click(sender As Object, e As EventArgs) Handles subItemPlanilla_Mensual.Click
        FrmPlanilla.Show()
    End Sub

    Private Sub itemAcerca_Click(sender As Object, e As EventArgs) Handles itemAcerca.Click
        FrmAcerca.Show()
    End Sub
End Class
