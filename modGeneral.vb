Module modGeneral
    Public Moteur_UI As New MoteurUI

    ' Constante
    Public Const SQUARE_SIZE = 96 ' taille d'un carré
    Public Const GAME_NAME = "2048"

    '  Game
    Public BestScore As Long = 0
    Public InGame As Boolean = False
    Public doitApparaitre As Boolean = False
    Public alreadyWin As Boolean = False

    ' carré sélectionné
    Public Selected As Boolean

    ' Liste des directions
    Public Enum DirectionEnum
        Right = 0
        Left = 1
        Down
        Up
    End Enum

    Public Sub initialiseGame()

        ' on fait disparaître la fenêtre de départ
        frmMenu.Visible = False

        ' on fait apparaître la fenêtre du jeu
        frmGame.Show()

        ' on lance le timer pour dessiner le jeu
        frmGame.tmrDraw.Enabled = True

        ' on lance le timer pour gérer le jeu
        frmGame.tmrGame.Enabled = True

        ' on nettoie le jeu
        Call Moteur_UI.Moteur.ClearSquares()

        ' on fait apparaître 2 cases
        Call Moteur_UI.Moteur.SpawnSquare()
        Call Moteur_UI.Moteur.SpawnSquare()

        InGame = True
    End Sub

    Public Sub LoseGame()

        ' on arrête les timers
        InGame = False

        ' on alerte le joueur
        Call MsgBox("Vous avez perdu !", vbYes, GAME_NAME)
    End Sub

    Public Sub UpdateGame()
        Dim animationTermine As Boolean = False

        For x = 0 To 3
            For y = 0 To 3

                If Moteur_UI.Moteur.GetAlive(x, y) Then ' si la case est en jeu

                    ' Effet de grossissement à l'appararition de la tuile : en %
                    If Moteur_UI.Moteur.GetPourcentVisible(x, y) < 100 Then
                        Call Moteur_UI.Moteur.SetPourcentVisible(x, y, Moteur_UI.Moteur.GetPourcentVisible(x, y) + 10)
                    ElseIf Moteur_UI.Moteur.GetPourcentVisible(x, y) > 100 Then
                        Call Moteur_UI.Moteur.SetPourcentVisible(x, y, Moteur_UI.Moteur.GetPourcentVisible(x, y) - 5)
                    End If

                    ' Effet de glissement des tuiles horizontalement
                    If Moteur_UI.Moteur.GetXoffset(x, y) < 0 Then ' droite

                        Moteur_UI.Moteur.SetOffsetX(x, y, Moteur_UI.Moteur.GetXoffset(x, y) + 25)

                        If Moteur_UI.Moteur.GetXoffset(x, y) >= 0 Then
                            Moteur_UI.Moteur.SetOffsetX(x, y, 0)
                        End If

                    ElseIf Moteur_UI.Moteur.GetXoffset(x, y) > 0 Then ' gauche

                        Moteur_UI.Moteur.SetOffsetX(x, y, Moteur_UI.Moteur.GetXoffset(x, y) - 25)

                        If Moteur_UI.Moteur.GetXoffset(x, y) <= 0 Then
                            Moteur_UI.Moteur.SetOffsetX(x, y, 0)
                        End If

                    End If

                    ' Effet de glissement des tuiles verticalements
                    If Moteur_UI.Moteur.GetYoffset(x, y) < 0 Then ' bas

                        Moteur_UI.Moteur.SetOffsetY(x, y, Moteur_UI.Moteur.GetYoffset(x, y) + 25)

                        If Moteur_UI.Moteur.GetYoffset(x, y) >= 0 Then
                            Moteur_UI.Moteur.SetOffsetY(x, y, 0)
                        End If

                    ElseIf Moteur_UI.Moteur.GetYoffset(x, y) > 0 Then ' haut

                        Moteur_UI.Moteur.SetOffsetY(x, y, Moteur_UI.Moteur.GetYoffset(x, y) - 25)

                        If Moteur_UI.Moteur.GetYoffset(x, y) <= 0 Then
                            Moteur_UI.Moteur.SetOffsetY(x, y, 0)
                        End If

                    End If

                End If
            Next
        Next

        ' Après avoir bouger les tuiles, il faut en faire apparaître une nouvelle
        If doitApparaitre Then
            Moteur_UI.Moteur.SpawnSquare()
            doitApparaitre = False
        End If

    End Sub

    Public Function NextPosition(ByVal direction As Byte, ByVal x As Long, ByVal y As Long) As Boolean
        Dim continueLoop As Boolean = True, moved = False
        Do While continueLoop

            continueLoop = False ' cette variable sert à savoir si on continue de faire glisser les nombres
            moved = False

            If direction = DirectionEnum.Right Then

                ' on bouge à droite

                If x < 3 Then

                    If Not Moteur_UI.Moteur.GetAlive(x + 1, y) Then

                        Moteur_UI.Moteur.moveSquare(direction, x, y, x + 1, y)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If x + 2 <= 3 Then
                            x = x + 1
                            continueLoop = True
                        End If

                        moved = True
                    ElseIf Moteur_UI.Moteur.GetSquareValue(x, y) = Moteur_UI.Moteur.GetSquareValue(x + 1, y) Then

                        Call Moteur_UI.Moteur.addSquare(direction, x, y, x + 1, y)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If x + 2 <= 3 Then
                            x = x + 1
                            continueLoop = True
                        End If

                        moved = True
                    End If

                End If

            ElseIf direction = DirectionEnum.Left Then

                ' on bouge à gauche

                If x > 0 Then
                    If Not Moteur_UI.Moteur.GetAlive(x - 1, y) Then
                        Moteur_UI.Moteur.moveSquare(direction, x, y, x - 1, y)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If x - 2 >= 0 Then
                            x = x - 1
                            continueLoop = True
                        End If

                        moved = True
                    ElseIf Moteur_UI.Moteur.GetSquareValue(x, y) = Moteur_UI.Moteur.GetSquareValue(x - 1, y) Then

                        Call Moteur_UI.Moteur.addSquare(direction, x, y, x - 1, y)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If x - 2 >= 0 Then
                            x = x - 1
                            continueLoop = True
                        End If

                        moved = True
                    End If
                End If

            ElseIf direction = DirectionEnum.Down Then

                ' on bouge en bas

                If y < 3 Then
                    If Not Moteur_UI.Moteur.GetAlive(x, y + 1) Then
                        Moteur_UI.Moteur.moveSquare(direction, x, y, x, y + 1)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If y + 2 <= 3 Then
                            y = y + 1
                            continueLoop = True
                        End If

                        moved = True
                    ElseIf Moteur_UI.Moteur.GetSquareValue(x, y) = Moteur_UI.Moteur.GetSquareValue(x, y + 1) Then

                        Call Moteur_UI.Moteur.addSquare(direction, x, y, x, y + 1)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If y + 2 <= 3 Then
                            y = y + 1
                            continueLoop = True
                        End If

                        moved = True
                    End If
                End If

            ElseIf direction = DirectionEnum.Up Then

                ' on bouge en haut

                If y > 0 Then
                    If Not Moteur_UI.Moteur.GetAlive(x, y - 1) Then

                        Moteur_UI.Moteur.moveSquare(direction, x, y, x, y - 1)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If y - 2 >= 0 Then
                            y = y - 1
                            continueLoop = True
                        End If

                        moved = True
                    ElseIf Moteur_UI.Moteur.GetSquareValue(x, y) = Moteur_UI.Moteur.GetSquareValue(x, y - 1) Then

                        Call Moteur_UI.Moteur.addSquare(direction, x, y, x, y - 1)

                        ' si c'est toujours dans les limites du tableau on peut continuer à faire glisser
                        If y - 2 >= 0 Then
                            y = y - 1
                            continueLoop = True
                        End If

                        moved = True
                    End If
                End If
            End If

        Loop

        NextPosition = moved

    End Function

    Public Function random(ByVal min As Long, ByVal max As Long) As Long
        Randomize()
        random = Int(Rnd() * (max + 1) + min)
    End Function

End Module
