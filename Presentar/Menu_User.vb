Public Class Menu_User
    Private Sub PresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionToolStripMenuItem.Click
        Dim a As New Presentacion
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub HorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorarioToolStripMenuItem.Click
        Dim a As New Horario
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Login
        a.Show()
    End Sub
End Class