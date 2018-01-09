<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaceInvaders
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitreScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lstHistorique = New System.Windows.Forms.ListBox()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.pnlAliens = New System.Windows.Forms.Panel()
        Me.pnlVaisseau = New System.Windows.Forms.Panel()
        Me.tmrJeu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMissile = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitreNiveau = New System.Windows.Forms.Label()
        Me.lblNiveau = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblTextMissileTire = New System.Windows.Forms.Label()
        Me.lblMissileTire = New System.Windows.Forms.Label()
        Me.lbl_temps = New System.Windows.Forms.Label()
        Me.lbl_compteur = New System.Windows.Forms.Label()
        Me.tmrCompteur = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblIndicationJeu = New System.Windows.Forms.Label()
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitreScore
        '
        Me.lblTitreScore.AutoSize = True
        Me.lblTitreScore.BackColor = System.Drawing.Color.Transparent
        Me.lblTitreScore.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreScore.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTitreScore.Location = New System.Drawing.Point(803, 52)
        Me.lblTitreScore.Name = "lblTitreScore"
        Me.lblTitreScore.Size = New System.Drawing.Size(48, 18)
        Me.lblTitreScore.TabIndex = 1
        Me.lblTitreScore.Text = "Score : "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore.Location = New System.Drawing.Point(876, 42)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(27, 29)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        '
        'lstHistorique
        '
        Me.lstHistorique.FormattingEnabled = True
        Me.lstHistorique.Location = New System.Drawing.Point(621, 170)
        Me.lstHistorique.Name = "lstHistorique"
        Me.lstHistorique.Size = New System.Drawing.Size(324, 342)
        Me.lstHistorique.TabIndex = 3
        '
        'btnJouer
        '
        Me.btnJouer.Location = New System.Drawing.Point(641, 551)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(120, 40)
        Me.btnJouer.TabIndex = 4
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'pnlAliens
        '
        Me.pnlAliens.BackColor = System.Drawing.Color.Black
        Me.pnlAliens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAliens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlAliens.Location = New System.Drawing.Point(22, 144)
        Me.pnlAliens.Name = "pnlAliens"
        Me.pnlAliens.Size = New System.Drawing.Size(589, 393)
        Me.pnlAliens.TabIndex = 5
        '
        'pnlVaisseau
        '
        Me.pnlVaisseau.BackColor = System.Drawing.Color.Black
        Me.pnlVaisseau.Location = New System.Drawing.Point(22, 543)
        Me.pnlVaisseau.Name = "pnlVaisseau"
        Me.pnlVaisseau.Size = New System.Drawing.Size(589, 61)
        Me.pnlVaisseau.TabIndex = 6
        '
        'tmrJeu
        '
        '
        'tmrMissile
        '
        '
        'lblTitreNiveau
        '
        Me.lblTitreNiveau.AutoSize = True
        Me.lblTitreNiveau.BackColor = System.Drawing.Color.Transparent
        Me.lblTitreNiveau.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreNiveau.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitreNiveau.Location = New System.Drawing.Point(614, 9)
        Me.lblTitreNiveau.Name = "lblTitreNiveau"
        Me.lblTitreNiveau.Size = New System.Drawing.Size(55, 18)
        Me.lblTitreNiveau.TabIndex = 7
        Me.lblTitreNiveau.Text = "Niveau : "
        '
        'lblNiveau
        '
        Me.lblNiveau.AutoSize = True
        Me.lblNiveau.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNiveau.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNiveau.Location = New System.Drawing.Point(679, 6)
        Me.lblNiveau.Name = "lblNiveau"
        Me.lblNiveau.Size = New System.Drawing.Size(26, 29)
        Me.lblNiveau.TabIndex = 8
        Me.lblNiveau.Text = "0"
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(806, 551)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(120, 40)
        Me.btnQuitter.TabIndex = 9
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTextMissileTire
        '
        Me.lblTextMissileTire.AutoSize = True
        Me.lblTextMissileTire.BackColor = System.Drawing.Color.Transparent
        Me.lblTextMissileTire.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextMissileTire.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTextMissileTire.Location = New System.Drawing.Point(614, 52)
        Me.lblTextMissileTire.Name = "lblTextMissileTire"
        Me.lblTextMissileTire.Size = New System.Drawing.Size(112, 18)
        Me.lblTextMissileTire.TabIndex = 10
        Me.lblTextMissileTire.Text = "Missile(s) Tiré(s) : "
        '
        'lblMissileTire
        '
        Me.lblMissileTire.AutoSize = True
        Me.lblMissileTire.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissileTire.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMissileTire.Location = New System.Drawing.Point(735, 42)
        Me.lblMissileTire.Name = "lblMissileTire"
        Me.lblMissileTire.Size = New System.Drawing.Size(26, 29)
        Me.lblMissileTire.TabIndex = 11
        Me.lblMissileTire.Text = "0"
        '
        'lbl_temps
        '
        Me.lbl_temps.AutoSize = True
        Me.lbl_temps.BackColor = System.Drawing.Color.Transparent
        Me.lbl_temps.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_temps.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_temps.Location = New System.Drawing.Point(618, 93)
        Me.lbl_temps.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_temps.Name = "lbl_temps"
        Me.lbl_temps.Size = New System.Drawing.Size(58, 20)
        Me.lbl_temps.TabIndex = 12
        Me.lbl_temps.Text = "Temps :"
        '
        'lbl_compteur
        '
        Me.lbl_compteur.AutoSize = True
        Me.lbl_compteur.BackColor = System.Drawing.Color.Transparent
        Me.lbl_compteur.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_compteur.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_compteur.Location = New System.Drawing.Point(709, 83)
        Me.lbl_compteur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_compteur.Name = "lbl_compteur"
        Me.lbl_compteur.Size = New System.Drawing.Size(86, 34)
        Me.lbl_compteur.TabIndex = 13
        Me.lbl_compteur.Text = "00 : 00"
        '
        'tmrCompteur
        '
        Me.tmrCompteur.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.SpaceInvadersBally1979
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(22, -21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(590, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblIndicationJeu
        '
        Me.lblIndicationJeu.AutoSize = True
        Me.lblIndicationJeu.BackColor = System.Drawing.Color.Transparent
        Me.lblIndicationJeu.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicationJeu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblIndicationJeu.Location = New System.Drawing.Point(680, 144)
        Me.lblIndicationJeu.Name = "lblIndicationJeu"
        Me.lblIndicationJeu.Size = New System.Drawing.Size(60, 20)
        Me.lblIndicationJeu.TabIndex = 15
        Me.lblIndicationJeu.Text = "Bon jeu "
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.BackColor = System.Drawing.Color.Transparent
        Me.lblNomJoueur.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomJoueur.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNomJoueur.Location = New System.Drawing.Point(746, 144)
        Me.lblNomJoueur.Name = "lblNomJoueur"
        Me.lblNomJoueur.Size = New System.Drawing.Size(0, 20)
        Me.lblNomJoueur.TabIndex = 16
        '
        'frmSpaceInvaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(954, 630)
        Me.Controls.Add(Me.lblNomJoueur)
        Me.Controls.Add(Me.lblIndicationJeu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_compteur)
        Me.Controls.Add(Me.lbl_temps)
        Me.Controls.Add(Me.lblMissileTire)
        Me.Controls.Add(Me.lblTextMissileTire)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblNiveau)
        Me.Controls.Add(Me.lblTitreNiveau)
        Me.Controls.Add(Me.lstHistorique)
        Me.Controls.Add(Me.pnlVaisseau)
        Me.Controls.Add(Me.pnlAliens)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTitreScore)
        Me.KeyPreview = True
        Me.Name = "frmSpaceInvaders"
        Me.Text = "SpaceInvaders"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitreScore As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lstHistorique As System.Windows.Forms.ListBox
    Friend WithEvents pnlAliens As System.Windows.Forms.Panel
    Friend WithEvents pnlVaisseau As System.Windows.Forms.Panel
    Friend WithEvents lblTitreNiveau As System.Windows.Forms.Label
    Friend WithEvents lblNiveau As System.Windows.Forms.Label
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents lblTextMissileTire As System.Windows.Forms.Label
    Friend WithEvents lblMissileTire As System.Windows.Forms.Label
    Friend WithEvents lbl_temps As System.Windows.Forms.Label
    Friend WithEvents lbl_compteur As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents tmrJeu As System.Windows.Forms.Timer
    Public WithEvents tmrMissile As System.Windows.Forms.Timer
    Public WithEvents tmrCompteur As System.Windows.Forms.Timer
    Public WithEvents btnJouer As System.Windows.Forms.Button
    Friend WithEvents lblIndicationJeu As System.Windows.Forms.Label
    Friend WithEvents lblNomJoueur As System.Windows.Forms.Label

End Class
