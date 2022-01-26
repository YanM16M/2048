Public Class frmMenu

    Private Sub btnGameSimple_Click(sender As Object, e As EventArgs) Handles btnGameSimple.Click
        Call initialiseGame() ' on lance le jeu
    End Sub

    Private Sub hideAllControls()

        btnExit.Visible = False
        btnRules.Visible = False
        btnCredits.Visible = False
        btnCtrl.Visible = False
        btnGameSimple.Visible = False
        lblRules.Visible = False
        lblCtrl.Visible = False
        lblCredits.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If btnExit.Text = "Retour" Then
            btnExit.Text = "Quitter"
            Call hideAllControls()
            btnGameSimple.Visible = True
            btnCredits.Visible = True
            btnRules.Visible = True
            btnCtrl.Visible = True
            btnExit.Visible = True
            lblCredits.Visible = False
        Else
            End ' on met fin au logiciel
        End If

    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click

        Call hideAllControls()
        btnExit.Text = "Retour"
        lblCredits.Text = "Merci à :

        Kevin Mouttajagane
        Julien Labee
        Julian
        Yanis Martinon"

        lblCredits.Visible = True
        btnExit.Visible = True

    End Sub

    Private Sub btnCtrl_Click(sender As Object, e As EventArgs) Handles btnCtrl.Click
        Call hideAllControls()
        lblCtrl.Visible = True
        btnExit.Text = "Retour"
        btnExit.Visible = True
    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        Call hideAllControls()
        lblRules.Visible = True
        btnExit.Text = "Retour"
        btnExit.Visible = True
    End Sub
End Class
