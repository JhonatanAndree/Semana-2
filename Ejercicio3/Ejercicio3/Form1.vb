Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlanzar.Click
        MsgBox("Hola Mundo", MsgBoxStyle.AbortRetryIgnore, "Información")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        Form2.Show()
        Close()
    End Sub
End Class
