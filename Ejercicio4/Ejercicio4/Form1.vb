Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txtsuma.Text = Val(txtn1.Text) + Val(txtn2.Text) + Val(txtn3.Text)
        txtpromedio.Text = (Val(txtn1.Text) + Val(txtn2.Text) + Val(txtn3.Text)) / 3
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtn1.Clear()
        txtn2.Clear()
        txtn3.Clear()
        txtpromedio.Clear()
        txtsuma.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub
End Class
