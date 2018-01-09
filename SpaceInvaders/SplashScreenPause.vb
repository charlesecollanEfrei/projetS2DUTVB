''' <summary>
''' Cette fenetre a pour but d'informer le joueur des touches mais aussi de faire une pause
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class SplashScreenPause

    ''' <summary>
    ''' Permet de revenir au jeu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reprendre.Click

        If btn_reprendre.Text = "Reprendre" Then
            Me.Close()
        End If

    End Sub

End Class