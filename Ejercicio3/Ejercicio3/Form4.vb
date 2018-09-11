Public Class Form4
    Private Sub btnlanzar_Click(sender As Object, e As EventArgs) Handles btnlanzar.Click
        MsgBox("¿Puede decirme su nombre?", MsgBoxStyle.Question, "¿Como se llama?")
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        Close()
    End Sub
End Class