<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenPause
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_reprendre = New System.Windows.Forms.Button()
        Me.lbl_InfoTouches = New System.Windows.Forms.Label()
        Me.lbl_TitrePause = New System.Windows.Forms.Label()
        Me.lbl_InfoJeu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_reprendre
        '
        Me.btn_reprendre.BackColor = System.Drawing.Color.Transparent
        Me.btn_reprendre.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.img1
        Me.btn_reprendre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_reprendre.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reprendre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_reprendre.Location = New System.Drawing.Point(202, 302)
        Me.btn_reprendre.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_reprendre.Name = "btn_reprendre"
        Me.btn_reprendre.Size = New System.Drawing.Size(175, 60)
        Me.btn_reprendre.TabIndex = 1
        Me.btn_reprendre.Text = "Reprendre"
        Me.btn_reprendre.UseVisualStyleBackColor = False
        '
        'lbl_InfoTouches
        '
        Me.lbl_InfoTouches.AutoSize = True
        Me.lbl_InfoTouches.BackColor = System.Drawing.Color.Transparent
        Me.lbl_InfoTouches.Font = New System.Drawing.Font("Impact", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InfoTouches.ForeColor = System.Drawing.Color.Lime
        Me.lbl_InfoTouches.Location = New System.Drawing.Point(84, 156)
        Me.lbl_InfoTouches.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_InfoTouches.Name = "lbl_InfoTouches"
        Me.lbl_InfoTouches.Size = New System.Drawing.Size(428, 108)
        Me.lbl_InfoTouches.TabIndex = 2
        Me.lbl_InfoTouches.Text = "<- : Se déplacer à gauche" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-> : Se déplacer à droite" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESPACE : Pour tirer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mainte" & _
    "nir ESPACE : Tire plusieurs fois à la suite"
        '
        'lbl_TitrePause
        '
        Me.lbl_TitrePause.AutoSize = True
        Me.lbl_TitrePause.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TitrePause.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitrePause.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_TitrePause.Location = New System.Drawing.Point(201, 23)
        Me.lbl_TitrePause.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_TitrePause.Name = "lbl_TitrePause"
        Me.lbl_TitrePause.Size = New System.Drawing.Size(193, 80)
        Me.lbl_TitrePause.TabIndex = 3
        Me.lbl_TitrePause.Text = "PAUSE"
        '
        'lbl_InfoJeu
        '
        Me.lbl_InfoJeu.AutoSize = True
        Me.lbl_InfoJeu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_InfoJeu.Font = New System.Drawing.Font("Impact", 10.0!)
        Me.lbl_InfoJeu.ForeColor = System.Drawing.Color.Lime
        Me.lbl_InfoJeu.Location = New System.Drawing.Point(8, 386)
        Me.lbl_InfoJeu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_InfoJeu.Name = "lbl_InfoJeu"
        Me.lbl_InfoJeu.Size = New System.Drawing.Size(298, 18)
        Me.lbl_InfoJeu.TabIndex = 4
        Me.lbl_InfoJeu.Text = "*Après avoir cliqué sur reprendre, cliquer sur JOUER"
        '
        'SplashScreenPause
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.img1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(597, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_InfoJeu)
        Me.Controls.Add(Me.lbl_TitrePause)
        Me.Controls.Add(Me.lbl_InfoTouches)
        Me.Controls.Add(Me.btn_reprendre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreenPause"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_reprendre As System.Windows.Forms.Button
    Friend WithEvents lbl_InfoTouches As System.Windows.Forms.Label
    Friend WithEvents lbl_TitrePause As System.Windows.Forms.Label
    Friend WithEvents lbl_InfoJeu As System.Windows.Forms.Label

End Class
