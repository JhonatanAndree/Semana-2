Public Class Form2
    Private Sub btnlanzar_Click(sender As Object, e As EventArgs) Handles btnlanzar.Click
        MsgBox("Error crítico en su pc", MsgBoxStyle.Critical, "Error Crítico")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        Form3.Show()
        Close()
    End Sub
End Class