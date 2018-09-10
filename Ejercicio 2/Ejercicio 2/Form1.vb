Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txtpromedio.Text = (Val(txtn1.Text) + Val(txtn2.Text)) / 2
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtn1.Clear()
        txtn2.Clear()
        txtpromedio.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub
End Class
