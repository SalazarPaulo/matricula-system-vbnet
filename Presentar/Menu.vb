Imports System.Windows

Public Class Menu

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Dim a As New Estudiante
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub AsignaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaturaToolStripMenuItem.Click
        Dim a As New Asignatura
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub SedeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SedeToolStripMenuItem.Click
        Dim a As New Docente
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub PresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónToolStripMenuItem.Click
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
