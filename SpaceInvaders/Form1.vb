''' Mini-Projet : SpaceInvaders
''' Charles Ecollan
''' Jean-Luc NGUYEN
''' TP 2-C
''' Crée le 26/05/2015

Public Class frmSpaceInvaders

#Region "Declaration des variables et constantes"
    'Constantes
    'Constantes pour les aliens
    Private Const INCRVITESSEALIEN As Integer = 5
    Private Const MAXVITESSEALIEN As Integer = 50

    'Constantes pour le vaisseau
    Private Const VITESSEVAISSEAU As Integer = 40

    'Constantes pour les missiles
    Private Const VITESSEMISSILE As Integer = 40

    'Variables
    'Variables pour les aliens
    Private nbLigne As Integer
    Private nbColonne As Integer
    Private pnlAlien(nbLigne, nbColonne) As PictureBox
    Private positionAlien As New Point
    Private margeDescenteAlien As Integer
    Private vitesseAlien As Integer
    Dim deplacerAliens As Boolean = True

    'Variables pour le vaisseau
    Private vaisseau As PictureBox
    Private positionVaisseau As New Point

    'Variables pour les missiles
    Private lancerMissile As Boolean = True
    Private missile As PictureBox
    Private positionMissile As New Point
    Private nbMissileTire As Integer

    'Varibles Score et niveau
    Private scoreJoueur As Integer
    Private niveauActuel As Integer
    Private niveauReussis As Integer
    Private nbParties As Integer
    Private nomJoueur As String

    Private time As Integer 'Créaction d'une variable pour le TEMPS

#End Region

#Region "Procédures d'initialisation"

    ''' <summary>
    ''' Chargement de l'application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub FrmSpaceInvaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.SplashScreen1.ShowDialog()
        
        Initialiserpartie() 'On initialise le jeu

        'On initialise les intervalles des timers
        tmrJeu.Interval = 200
        tmrMissile.Interval = 20

        lblNomJoueur.Text = nomJoueur 'On affiche le nom du joueur

        nbParties = 1 'On initialise le nombre de partie
        Me.CenterToScreen() 'On met la fenêtre au centre
       
    End Sub

    ''' <summary>
    ''' Procédure permettant de récupérer le nom du joueur
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="theme"></param>
    ''' <remarks></remarks>
    Public Sub recupererNom(nom As String)
        nomJoueur = nom
    End Sub

    ''' <summary>
    ''' On initialise le panel des aliens avec des images en pictureBox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initialiserPanelAlien()
        ReDim pnlAlien(nbLigne, nbColonne)
        Dim i, j As Integer
        Dim distanceGauche, distancehaut As Integer

        'On initialise la position de l'alien
        positionAlien = New Point(10, 50)
        distanceGauche = 10
        distancehaut = 50

        'On affiche les pictureBox des aliens dans le panel pnlAliens, par un boucle
        For i = 0 To nbLigne - 1
            For j = 0 To nbColonne - 1
                pnlAlien(i, j) = New PictureBox() 'On crée une pictureBox

                'on alterne le type d'alienne avec une IF/ELSE
                If (i Mod 2 <> 0) Then
                    pnlAlien(i, j).Image = Image.FromFile("./images/alien.jpg")
                Else
                    pnlAlien(i, j).Image = Image.FromFile("./images/alien1.jpg")
                End If

                'On position la nouvelle pictureBox crée
                pnlAlien(i, j).Width = 60
                pnlAlien(i, j).Height = 60
                pnlAlien(i, j).Visible = True
                pnlAlien(i, j).Location = New Point(distanceGauche, distancehaut)
                pnlAliens.Controls.Add(pnlAlien(i, j))

                distanceGauche = distanceGauche + 60
            Next

            'On positionne les différentes pictureBox
            distanceGauche = 10
            distancehaut = distancehaut + 55
        Next
    End Sub

    ''' <summary>
    ''' On initialise la partie
    ''' </summary>
    ''' <remarks> On insére les aliens, on crée le vaisseau</remarks>
    Private Sub Initialiserpartie()
        'On initialise tout
        lblScore.Text = "0"
        lblMissileTire.Text = "0"
        lblNiveau.Text = "0"
        niveauReussis = 0
        nbLigne = 2
        nbColonne = 5
        lancerMissile = True
        scoreJoueur = 0
        niveauActuel = 1
        margeDescenteAlien = 2
        vitesseAlien = 30
        nbMissileTire = 0
        lblNiveau.Text = niveauActuel

        initialiserPanelAlien() 'On initialise le panel Alien

        'On fait apparaître le vaisseau
        vaisseau = New PictureBox()
        vaisseau.Image = Image.FromFile("./images/vaisseau.png")
        vaisseau.Width = 60
        vaisseau.Height = 60
        vaisseau.Visible = True
        vaisseau.Location = New Point((pnlVaisseau.Width / 2 - 30), 0)
        pnlVaisseau.Controls.Add(vaisseau)
        positionVaisseau = New Point((pnlVaisseau.Width / 2 - 30), 0)
    End Sub

#End Region

#Region "Gestion des déplacements"

    ''' <summary>
    ''' Timer pour les missiles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tmrMissile_Tick(sender As Object, e As EventArgs) Handles tmrMissile.Tick
        tmrMissile.Stop() 'On arrête le timer du missile

        If (Not lancerMissile) Then
            deplacerMissile() 'On deplace le missile
            testCollisionmissile() 'On teste les collisions
        End If

        tmrMissile.Start() 'On démarre le timer du missile
    End Sub

    ''' <summary>
    ''' Timer du temps de jeu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tmrCompteurr(sender As Object, e As EventArgs) Handles tmrCompteur.Tick
        time = time + 1
        Dim minutes As Integer = (time Mod 3600) \ 60
        Dim secondes As Integer = (time Mod 3600) Mod 60

        lbl_compteur.Text = minutes.ToString("00") & ":" & secondes.ToString("00") 'On affiche le compteur

    End Sub

    ''' <summary>
    ''' Timer pour les aliens
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tmrJeu_Tick(sender As Object, e As EventArgs) Handles tmrJeu.Tick
        tmrJeu.Stop() 'On stoppe le timer du jeu
        deplacerAlien()  'On déplace les aliens
        arriveeEnBas() 'On teste si les aliens sont arrivés en bas
        pnlAliens.Refresh() 'On met a jour l'affichage des panels

        'On vérifie si on a fini le niveau
        If (Not verifFinVague()) Then
            niveauReussis = niveauReussis + 1
            niveauActuel = niveauActuel + 1
            lblNiveau.Text = niveauActuel
            augmenterDifficulte()
            genererVagueAlien(nbLigne, nbColonne)
        End If

        tmrJeu.Start() 'On demarre le timer du jeu
    End Sub

    ''' <summary>
    ''' On gère le déplacement des aliens
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub deplacerAlien()
        Dim foundC As Boolean = False
        Dim i, j As Integer

        'Si on peut déplacer les aliens, on les déplace
        If (deplacerAliens) Then
            i = nbLigne - 1
            j = nbColonne - 1

            While (Not foundC And j >= 0)
                While (Not foundC And i >= 0)
                    foundC = pnlAlien(i, j).Visible
                    i = i - 1
                End While

                If (Not foundC) Then
                    i = nbLigne - 1
                    j = j - 1
                End If
            End While

            'On déplace les aliens par rapport à la descente
            If ((positionAlien.X + ((j + 1) * 60) + vitesseAlien) < pnlAliens.Width) Then
                positionAlien.X = positionAlien.X + vitesseAlien
                positionAlien.Y = positionAlien.Y + margeDescenteAlien
            Else
                positionAlien.X = pnlAliens.Width - ((j + 1) * 60)
                positionAlien.Y = positionAlien.Y + margeDescenteAlien
                deplacerAliens = False
            End If
        Else

            i = 0
            j = 0

            While (Not foundC And j < nbColonne)
                While (Not foundC And i < nbLigne)
                    foundC = pnlAlien(i, j).Visible
                    i = i + 1
                End While

                If (Not foundC) Then
                    i = 0
                    j = j + 1
                End If
            End While

            If (((positionAlien.X + (j * 60)) - vitesseAlien) > 0) Then
                positionAlien.X = positionAlien.X - vitesseAlien
                positionAlien.Y = positionAlien.Y + margeDescenteAlien
            Else
                positionAlien.X = -(j * 60)
                positionAlien.Y = positionAlien.Y + margeDescenteAlien
                deplacerAliens = True
            End If
        End If

        Dim distanceGauche, distanceHaut As Integer
        distanceGauche = positionAlien.X
        distanceHaut = positionAlien.Y

        For i = 0 To nbLigne - 1
            For j = 0 To nbColonne - 1
                pnlAlien(i, j).Location = New Point(distanceGauche, distanceHaut)
                distanceGauche = distanceGauche + 60
            Next
            distanceHaut = distanceHaut + 55
            distanceGauche = positionAlien.X
        Next
    End Sub

    ''' <summary>
    ''' On gère le déplacement du vaisseau
    ''' </summary>
    ''' <param name="move"></param>
    ''' <remarks></remarks>
    Private Sub deplacervaisseau(move As Integer)
        If (positionVaisseau.X + move < 0) Then
            positionVaisseau.X = 0

        ElseIf (positionVaisseau.X + vaisseau.Width + move > pnlVaisseau.Width) Then
            positionVaisseau.X = pnlVaisseau.Width - vaisseau.Width

        Else
            positionVaisseau.X = positionVaisseau.X + move
        End If

        vaisseau.Location = New Point(positionVaisseau.X, positionVaisseau.Y)
    End Sub

#End Region

#Region "Gestion des collisions"

    ''' <summary>
    ''' Test de Colision entre un alien et un missile
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub testCollisionmissile()
        Dim find As Integer = False
        Dim i, j As Integer
        i = 0
        j = 0

        'Tant que l'on n'a pas eu de collision et que le nombre de ligne du panel Aliens n'est pas atteinds
        'On vérifie que il n'y a pas de collision
        While i < nbLigne And Not find
            While j < nbColonne And Not find
                find = ((positionMissile.Y >= positionAlien.Y + (i * 60) And positionMissile.Y <= positionAlien.Y + ((i + 1) * 60)) And ((positionMissile.X >= positionAlien.X + (j * 60) And positionMissile.X <= positionAlien.X + (((j + 1) * 60)))) And pnlAlien(i, j).Visible)
                j = j + 1
            End While

            i = i + 1

            If (Not find) Then
                j = 0
            End If
        End While

        'S'il y a une collision, on efface le missile et on rend invisible l'alien touché
        If find Then
            missile.Dispose()
            positionMissile = New Point(0, 0)
            lancerMissile = True
            pnlAlien(i - 1, j - 1).Image = Nothing
            pnlAlien(i - 1, j - 1).Visible = False
            scoreJoueur = scoreJoueur + 1
            lblScore.Text = scoreJoueur
        End If
    End Sub

    ''' <summary>
    ''' Test de collision entre un alien et le bas de l'écran
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub arriveeEnBas()
        Dim i, j As Integer
        Dim found As Integer = False
        i = nbLigne
        j = nbColonne

        'Tant que on n'a pas touché le bas de l'écran, on continue à rendre visible les Aliens
        While (i > 0 And Not found)
            While (j > 0 And Not found)
                found = pnlAlien(i - 1, j - 1).Visible
                j = j - 1
            End While

            i = i - 1

            If (Not found) Then
                j = nbColonne
            End If
        End While

        'Si on touche le bas de l'écran, alors on arrête le timer et on appelle la Perdu()
        If (found And (positionAlien.Y + ((i + 1) * 55) >= pnlAliens.Height)) Then
            tmrCompteur.Stop()
            Perdu()
        End If
    End Sub

#End Region

#Region "Niveaux de difficulté"

    ''' <summary>
    ''' On vérifie si tous les aliens du niveau ont été tués
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function verifFinVague()
        Dim vagueFinie As Boolean = False
        Dim i, j As Integer

        'Tant qu'il y a un Alien visible, on n'a pas fini
        While (Not vagueFinie And i < nbLigne)
            While (Not vagueFinie And j < nbColonne)
                vagueFinie = pnlAlien(i, j).Visible
                j = j + 1
            End While

            i = i + 1
            j = 0
        End While

        Return vagueFinie
    End Function

    ''' <summary>
    ''' Augmentation de la difficulté à chaque level
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub augmenterDifficulte()
        'On augmente une difficulté si le niveau est inférieur à 5
        If (niveauReussis < 5) Then
            If (niveauReussis Mod 2 = 0) Then
                nbLigne = nbLigne + 1
            Else
                nbColonne = nbColonne + 1
            End If

            'On augmente une difficulté si le niveau est inférieur à 10
        ElseIf (niveauReussis < 10) Then
            If (vitesseAlien + INCRVITESSEALIEN < MAXVITESSEALIEN) Then
                vitesseAlien = vitesseAlien + INCRVITESSEALIEN
            End If

            'On augmente une difficulté si le niveau est inférieur à 15
        ElseIf (niveauReussis < 15) Then
            If (tmrJeu.Interval > 100) Then
                tmrJeu.Interval = tmrJeu.Interval - 12
            End If
            'On augmente une difficulté si le niveau est inférieur à 20
        ElseIf (niveauReussis < 20) Then
            margeDescenteAlien = margeDescenteAlien + 1
        End If
    End Sub

    ''' <summary>
    ''' Générer une nouvelle vague d'aliens à un nouveau niveau
    ''' </summary>
    ''' <param name="nbRangee"></param>
    ''' <param name="nbAlienRangee"></param>
    ''' <remarks></remarks>
    Private Sub genererVagueAlien(nbRangee As Integer, nbAlienRangee As Integer)
        initialiserPanelAlien() 'On remet le panel Aliens au début
    End Sub

#End Region

#Region "Génération et déplacement des missiles"

    ''' <summary>
    ''' Gérer le lancement des missiles du vaisseau
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lancementMissile()
        'On crée le missile dans une pictureBox
        missile = New PictureBox()
        missile.Image = Image.FromFile("./images/missile.png")
        missile.Width = 10
        missile.Height = 30
        missile.Visible = True
        missile.Location = New Point((positionVaisseau.X) + 30, pnlAliens.Height - 1)
        pnlAliens.Controls.Add(missile)
        positionMissile = New Point((positionVaisseau.X) + 30, pnlAliens.Height - 1)

        nbMissileTire = nbMissileTire + 1 'On incremente le nombre de missile tiré
        lblMissileTire.Text = nbMissileTire 'On met dans le label le nombre de missile tiré

        lancerMissile = False
    End Sub

    ''' <summary>
    ''' Gérer le déplacement des missiles du vaisseau
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub deplacerMissile()
        Dim i As Integer

        'On tire le missile
        For i = 0 To VITESSEMISSILE
            If (positionMissile.Y - VITESSEMISSILE > 0) Then
                missile.Location = New Point(positionMissile.X, positionMissile.Y - 1)
                testCollisionmissile()
                positionMissile.Y = positionMissile.Y - 1
            Else
                missile.Height = 0
                lancerMissile = True
            End If
        Next
    End Sub

#End Region

#Region "Evenements clavier et Score"

    ''' <summary>
    ''' Gérer les touches appuyées du clavier
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmInterface_Clavier(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Si on appuie sur la fleche gauche, on déplace le vaisseau à gauche
        If e.KeyCode = Keys.Left Then
            deplacervaisseau(-VITESSEVAISSEAU)
        End If
        'Si on appuie sur la fleche droite, on déplace le vaisseau à droite
        If e.KeyCode = Keys.Right Then
            deplacervaisseau(VITESSEVAISSEAU)
        End If
        'Si on appuie sur la touche espace, on tire un missile
        If e.KeyCode = Keys.Space Then
            'Si on peut tirer un missile, on tire
            If (lancerMissile) Then
                lancementMissile()
            End If
        End If
    End Sub

#End Region

#Region "Evenement Boutons"

    ''' <summary>
    ''' On lance les timers pour jouer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        'Si on clique sur le bouton Jouer
        If btnJouer.Text = "Jouer" Then
            tmrCompteur.Start() 'On démarre le timer de temps de jeu
            tmrJeu.Start() 'On démarre le timer du jeu
            tmrMissile.Start() 'On démarre le timer du missile
            btnJouer.Text = "Pause" 'On modifie le texte en Pause
        Else
            tmrCompteur.Stop() 'On stoppe le timer de temps de jeu
            tmrJeu.Stop() 'On stoppe le timer du jeu
            tmrMissile.Stop() 'On stoppe le timer du missile
            btnJouer.Text = "Jouer" 'On modofie le texte en Jouer
            My.Forms.SplashScreenPause.ShowDialog() 'On affiche la boite de dialogue d'information du jeu
        End If
    End Sub

    ''' <summary>
    ''' On quitte l'application avec une vérification avant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        tmrJeu.Stop() 'On stoppe le timerJeu le temps de savoir si on quitte ou non le jeu

        ' On demande si l'utilisateur veut vraiment quitter
        If MsgBox("Voulez - vous quitter ?", MsgBoxStyle.YesNo, "Quitter") = MsgBoxResult.Yes Then
            Me.Dispose() ' Si oui, on quitte
        End If

        tmrJeu.Start() 'Si on ne quitte pas, on redémarre le timerJeu
    End Sub
#End Region

#Region "Fonctions et procedures supplementaires"

    ''' <summary>
    ''' Detecte si le joueur à perdu la perdue, c'est à dire s'il y a eu une collision entre alien et bas de la fenêtre
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Perdu()
        'On affiche un message récapitulatif de la partie
        If niveauReussis < 2 Then
            MessageBox.Show("Vous avez réussis " & niveauReussis & " niveau(x). " & vbNewLine & "Vous avez une précision de tir de " & CalculPoucentage() & " %." & vbNewLine & "Votre temps de jeu est de " & lbl_compteur.Text, "Récapitulatif", MessageBoxButtons.OK)
        End If

        'On ajoute la partie à l'historique
        lstHistorique.Items.Add("Partie " & nbParties & " : Niveau " & niveauReussis & " réussis, ")
        lstHistorique.Items.Add(" avec une précision de " & CalculPoucentage() & " %.")
        lstHistorique.Items.Add("Votre temps de jeu est de " & lbl_compteur.Text)

        nbParties = nbParties + 1 'On incremente le nombre de partie

        If (MsgBox("Souhaitez-vous recommencer une partie ?", MsgBoxStyle.YesNo, "Recommencer") <> 7) Then
            'On efface les aliens non tué avant de relancer la partie
            For i = 0 To nbLigne - 1
                For j = 0 To nbColonne - 1
                    pnlAlien(i, j).Dispose()
                Next
            Next

            lbl_compteur.Text = "00:00"
            vaisseau.Dispose() 'On efface le vaiseau avant de relancer la partie
            Initialiserpartie() 'On relance la partie en appelant l'initialisation
        Else
            Me.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Calcul du pourcentage de tir
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CalculPoucentage()
        Dim resultat As Integer

        'On calcul le pourcentage de tir par rapport au nombre d'aliens tué et de missile tiré
        resultat = (scoreJoueur / nbMissileTire) * 100

        Return resultat
    End Function

#End Region

End Class