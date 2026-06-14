Imports System.Runtime.InteropServices

Public Class Login

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub Btn_Check_Click_1(sender As Object, e As EventArgs) Handles Btn_Check.Click
        If Logica.Estudiante.Estudiante_Verify(TextBox2.Text, TextBox1.Text) = True Then
            MsgBox("Administrador")
            Dim Generator As New Menu()
            Generator.Show()
            Me.Hide()
        Else
            Dim Generator As New Menu_User()
            Generator.Show()
            Me.Hide()
            MsgBox("Estudiante")
        End If
    End Sub


End Class
