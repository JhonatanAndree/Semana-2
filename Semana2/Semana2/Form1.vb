Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnmsg1_Click(sender As Object, e As EventArgs) Handles btnmsg1.Click
        txt1.Text = "BIENVENIDOS"
    End Sub

    Private Sub btnmsg23_Click(sender As Object, e As EventArgs) Handles btnmsg23.Click
        txt2.Text = "TALLER DE PROGRAMACION"
        txt3.Text = "DISTRIBUIDA"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub
End Class
