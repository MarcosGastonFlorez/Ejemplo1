Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        End
    End Sub

    Private Sub btnCerrar2_Click(sender As Object, e As EventArgs) Handles btnCerrar2.Click
        Me.Close()
    End Sub
End Class
