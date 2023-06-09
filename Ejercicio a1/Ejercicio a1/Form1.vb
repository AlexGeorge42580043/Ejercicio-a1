Public Class Form1
    Private Sub btEjecutar_Click(sender As Object, e As EventArgs) Handles btEjecutar.Click
        Dim a, b As Integer
        a = InputBox("Escribir a", "Ejercicio a1", 0)
        b = InputBox("Escribir b", "Ejercicio a1", 0)
        If a > b Then
            lblMostrarMayor.Text = "" & a
            lblMostrarMenor.Text = "" & b
        Else
            lblMostrarMenor.Text = "" & a
            lblMostrarMayor.Text = "" & b
        End If
    End Sub
End Class
