Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label6.Click, Label5.Click, Label4.Click

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txtsuma.Text = Val(txtn1.Text) + Val(txtn2.Text)
        txtresta.Text = Val(txtn1.Text) - Val(txtn2.Text)
        txtmultiplicacion.Text = Val(txtn1.Text) * Val(txtn2.Text)
        txtdivision.Text = Val(txtn1.Text) / Val(txtn2.Text)
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtn1.Clear()
        txtn2.Clear()
        txtsuma.Clear()
        txtresta.Clear()
        txtmultiplicacion.Clear()
        txtdivision.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub
End Class
