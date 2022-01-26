Module modInput
    Private OldX As Long, OldY As Long
    Private movementMouse As Byte, mouseClicked As Boolean = False
    Private marge As Long = 5

    Public Sub HandleMouseMove(ByVal Button As Long, ByVal x As Double, ByVal y As Double)

        ' seulement si on appuie sur la souris
        If Not mouseClicked Then Exit Sub

        If x > OldX + marge Then
            movementMouse = DirectionEnum.Right
        ElseIf x < OldX - marge Then
            movementMouse = DirectionEnum.Left
        End If

        If y > OldY + marge Then
            movementMouse = DirectionEnum.Down
        ElseIf y < OldY - marge Then
            movementMouse = DirectionEnum.Up
        End If

        OldX = x
        OldY = y
    End Sub

    Public Sub HandleMouseDown(ByVal Button As Long, ByVal x As Double, ByVal y As Double)

        ' si on sélectionne un carré alors
        If Moteur_UI.Moteur.isSquare(x, y) Then
            Selected = True
        End If

        mouseClicked = True

    End Sub

    Public Sub HandleMouseUp(ByVal Button As Long, ByVal x As Double, ByVal y As Double)
        Dim moved As Boolean = False

        If Selected And Not doitApparaitre Then

            If movementMouse = DirectionEnum.Right Then

                ' on fait bouger à partir de la droite
                For x = 3 To 0 Step -1
                    For y = 0 To 3
                        If NextPosition(movementMouse, x, y) Then moved = True
                    Next
                Next

            ElseIf movementMouse = DirectionEnum.Left Then

                ' on fait bouger à partir de la gauche
                For x = 0 To 3
                    For y = 0 To 3
                        If NextPosition(movementMouse, x, y) Then moved = True
                    Next
                Next

            ElseIf movementMouse = DirectionEnum.Down Then

                ' on fait bouger à partir du bas
                For x = 0 To 3
                    For y = 3 To 0 Step -1
                        If NextPosition(movementMouse, x, y) Then moved = True
                    Next
                Next

            ElseIf movementMouse = DirectionEnum.Up Then

                ' on fait bouger à partir du haut
                For x = 0 To 3
                    For y = 0 To 3
                        If NextPosition(movementMouse, x, y) Then moved = True
                    Next
                Next

            End If

        End If

        mouseClicked = False
        Selected = False

        ' si le jeu a bougé on fait apparaître une nouvelle case
        If moved Then
            doitApparaitre = True
        End If

        ' on vérifie si le joueur a perdu
        If Moteur_UI.Moteur.haveLost And InGame Then
            Call LoseGame()
        End If



    End Sub

    Public Sub HandleKeyUp(ByVal Keycode As Long)

        If Not doitApparaitre Then
            Dim moved As Boolean = False

            Select Case Keycode
                Case Keys.Up
                    ' on fait bouger à partir du haut
                    For x = 0 To 3
                        For y = 0 To 3
                            If NextPosition(DirectionEnum.Up, x, y) Then moved = True
                        Next
                    Next

                Case Keys.Down
                    ' on fait bouger à partir du bas
                    For x = 0 To 3
                        For y = 3 To 0 Step -1
                            If NextPosition(DirectionEnum.Down, x, y) Then moved = True
                        Next
                    Next

                Case Keys.Left
                    ' on fait bouger à partir de la gauche
                    For x = 0 To 3
                        For y = 0 To 3
                            If NextPosition(DirectionEnum.Left, x, y) Then moved = True
                        Next
                    Next

                Case Keys.Right
                    ' on fait bouger à partir de la droite
                    For x = 3 To 0 Step -1
                        For y = 0 To 3
                            If NextPosition(DirectionEnum.Right, x, y) Then moved = True
                        Next
                    Next
            End Select

            ' si le jeu a bougé on fait apparaître une nouvelle case
            If moved Then
                doitApparaitre = True
            End If

            ' on vérifie si le joueur a perdu
            If Moteur_UI.Moteur.haveLost And InGame Then
                Call LoseGame()
            End If

        End If

    End Sub

End Module
