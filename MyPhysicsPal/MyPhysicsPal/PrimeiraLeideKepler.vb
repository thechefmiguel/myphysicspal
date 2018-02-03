Public Class PrimeiraLeideKepler

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim caneta As Pen

        caneta = New Pen(Drawing.Color.Black, 5)

        Dim graficos As Graphics = Me.CreateGraphics

        Dim c As Double = TextBox2.Text
        Dim excentricidade As Double = TextBox1.Text

        Dim a As Double = c / excentricidade
        Dim b As Double = Math.Sqrt(a ^ 2 - c ^ 2)

        graficos.Clear(Drawing.Color.Gray)

        Dim x As Integer = 512 - b
        Dim y As Integer = 384 - a

        Dim altura As Integer = 2 * b
        Dim largura As Integer = 2 * a
        graficos.DrawEllipse(caneta, x, y, Int(largura), Int(altura))
    End Sub

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click
        LeisKepler.Show()
        Me.Hide()
    End Sub
End Class