Public NotInheritable Class SplashScreen1

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").

    ''' <summary>
    ''' Permet d'accéder au Jeu quand on appuie sur le bouton Jouer et ferme cette page d'accueil
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jouer.Click

        ' Si un nom est rempli alors on ouvre le jeu
        If (Not txtBoxNom.Text.Equals("")) Then
            frmSpaceInvaders.recupererNom(txtBoxNom.Text)
            Me.Close()
        Else 'Sinon, on affiche un message de rappel
            MessageBox.Show("Vous devez indiquer votre nom pour pouvoir jouer !", "Erreur", MessageBoxButtons.OK)
        End If

    End Sub

End Class