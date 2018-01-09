<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
        Me.pctB_Logo = New System.Windows.Forms.PictureBox()
        Me.btn_jouer = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtBoxNom = New System.Windows.Forms.TextBox()
        CType(Me.pctB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctB_Logo
        '
        Me.pctB_Logo.BackColor = System.Drawing.Color.Transparent
        Me.pctB_Logo.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.SpaceInvadersBally1979
        Me.pctB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctB_Logo.Location = New System.Drawing.Point(8, 8)
        Me.pctB_Logo.Margin = New System.Windows.Forms.Padding(2)
        Me.pctB_Logo.Name = "pctB_Logo"
        Me.pctB_Logo.Size = New System.Drawing.Size(581, 157)
        Me.pctB_Logo.TabIndex = 0
        Me.pctB_Logo.TabStop = False
        '
        'btn_jouer
        '
        Me.btn_jouer.BackColor = System.Drawing.Color.Black
        Me.btn_jouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jouer.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jouer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_jouer.Location = New System.Drawing.Point(210, 272)
        Me.btn_jouer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_jouer.Name = "btn_jouer"
        Me.btn_jouer.Size = New System.Drawing.Size(175, 60)
        Me.btn_jouer.TabIndex = 1
        Me.btn_jouer.Text = "Jouer"
        Me.btn_jouer.UseVisualStyleBackColor = False
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblNom.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNom.Location = New System.Drawing.Point(111, 215)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(96, 13)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Entrez votre nom : "
        '
        'txtBoxNom
        '
        Me.txtBoxNom.Location = New System.Drawing.Point(213, 212)
        Me.txtBoxNom.Name = "txtBoxNom"
        Me.txtBoxNom.Size = New System.Drawing.Size(172, 20)
        Me.txtBoxNom.TabIndex = 3
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.img1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(597, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBoxNom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btn_jouer)
        Me.Controls.Add(Me.pctB_Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pctB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctB_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_jouer As System.Windows.Forms.Button
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtBoxNom As System.Windows.Forms.TextBox

End Class
