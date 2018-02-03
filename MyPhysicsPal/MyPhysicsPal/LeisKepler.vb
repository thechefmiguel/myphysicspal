Public Class LeisKepler

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrimeiraLeiKepler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimeiraLeiKepler.Click
        PrimeiraLeideKepler.Show()
        Me.Hide()
    End Sub
End Class
