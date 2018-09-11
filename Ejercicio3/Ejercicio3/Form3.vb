Public Class Form3
    Private Sub btnlanzar_Click(sender As Object, e As EventArgs) Handles btnlanzar.Click
        MsgBox("Apagar la PC", MsgBoxStyle.Exclamation, "¡Està conforme!")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        Form4.Show()
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class