Public Class Form1
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtcantidad.Clear()
        txtpunit.Clear()
        txtprecio.Clear()
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txtprecio.Text = (Val(txtcantidad.Text) * Val(txtpunit.Text)) * 1.18
    End Sub
End Class
