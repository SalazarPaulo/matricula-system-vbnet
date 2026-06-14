<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PresentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SedeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentaciónToolStripMenuItem, Me.AsignaturaToolStripMenuItem, Me.SedeToolStripMenuItem, Me.EstudianteToolStripMenuItem, Me.HorarioToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PresentaciónToolStripMenuItem
        '
        Me.PresentaciónToolStripMenuItem.Name = "PresentaciónToolStripMenuItem"
        Me.PresentaciónToolStripMenuItem.Size = New System.Drawing.Size(99, 23)
        Me.PresentaciónToolStripMenuItem.Text = "Presentación"
        '
        'AsignaturaToolStripMenuItem
        '
        Me.AsignaturaToolStripMenuItem.Name = "AsignaturaToolStripMenuItem"
        Me.AsignaturaToolStripMenuItem.Size = New System.Drawing.Size(87, 23)
        Me.AsignaturaToolStripMenuItem.Text = "Asignatura"
        '
        'SedeToolStripMenuItem
        '
        Me.SedeToolStripMenuItem.Name = "SedeToolStripMenuItem"
        Me.SedeToolStripMenuItem.Size = New System.Drawing.Size(72, 23)
        Me.SedeToolStripMenuItem.Text = "Docente"
        '
        'EstudianteToolStripMenuItem
        '
        Me.EstudianteToolStripMenuItem.Name = "EstudianteToolStripMenuItem"
        Me.EstudianteToolStripMenuItem.Size = New System.Drawing.Size(85, 23)
        Me.EstudianteToolStripMenuItem.Text = "Estudiante"
        '
        'HorarioToolStripMenuItem
        '
        Me.HorarioToolStripMenuItem.Name = "HorarioToolStripMenuItem"
        Me.HorarioToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.HorarioToolStripMenuItem.Text = "Horario"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(600, 321)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PresentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignaturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SedeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
End Class
