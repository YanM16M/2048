Public Class Moteur

    ' ##########################################################################################################################################
    ' ##### VARIABLES ##########################################################################################################################
    ' ##########################################################################################################################################
    Private NumberOfFullCase As Byte = 0

    Private Structure SquareStructure
        Public value As Long
        Public xOffset As Long
        Public yOffset As Long
        Public alive As Boolean
        ' Animation
        Public PourcentVisible As Long
    End Structure

    Private Square(0 To 3, 0 To 3) As SquareStructure

    ' ##########################################################################################################################################
    ' ##### CONSTRUCTEURS ######################################################################################################################
    ' ##########################################################################################################################################

    Sub New()

        ' on nettoie
        Call ClearSquares()


    End Sub

    ' ##########################################################################################################################################
    ' ##### GETTERS AND SETTERS ################################################################################################################
    ' ##########################################################################################################################################

    Public Function GetSquareValue(ByVal x As Long, ByVal y As Long) As Long
        GetSquareValue = Square(x, y).value
    End Function

    Public Sub SetSquareValue(ByVal x As Long, ByVal y As Long, ByVal value As Long)
        Square(x, y).value = value
    End Sub

    Public Function GetXoffset(ByVal x As Long, ByVal y As Long) As Long
        GetXoffset = Square(x, y).xOffset
    End Function

    Public Sub SetOffsetX(ByVal x As Long, ByVal y As Long, ByVal value As Long)
        Square(x, y).xOffset = value
    End Sub

    Public Function GetYoffset(ByVal x As Long, ByVal y As Long) As Long
        GetYoffset = Square(x, y).yOffset
    End Function

    Public Sub SetOffsetY(ByVal x As Long, ByVal y As Long, ByVal value As Long)
        Square(x, y).yOffset = value
    End Sub

    Public Function GetPourcentVisible(ByVal x As Long, ByVal y As Long) As Long
        GetPourcentVisible = Square(x, y).PourcentVisible
    End Function

    Public Sub SetPourcentVisible(ByVal x As Long, ByVal y As Long, ByVal value As Long)
        Square(x, y).PourcentVisible = value
    End Sub

    Public Function GetAlive(ByVal x As Long, ByVal y As Long) As Boolean
        GetAlive = Square(x, y).alive
    End Function

    Public Sub SetAlive(ByVal x As Long, ByVal y As Long, ByVal etat As Boolean)
        Square(x, y).alive = etat
    End Sub

    ' ##########################################################################################################################################
    ' ##### GAMES ##############################################################################################################################
    ' ##########################################################################################################################################

    Public Sub ClearSquares()

        For x = 0 To 3
            For y = 0 To 3
                Call ClearSquare(x, y)
            Next
        Next

        NumberOfFullCase = 0

    End Sub

    Public Sub ClearSquare(ByVal x As Long, ByVal y As Long)

        ' on clear toutes les cases
        With Square(x, y)
            .value = 0
            .alive = False
            .xOffset = 0
            .yOffset = 0
            .PourcentVisible = 0
        End With

    End Sub

    Public Sub addSquare(ByVal direction As Byte, ByVal x1 As Long, ByVal y1 As Long, ByVal x2 As Long, ByVal y2 As Long)

        ' on additionne les 2 valeurs identiques
        Square(x1, y1).value = Square(x1, y1).value + Square(x2, y2).value

        ' Meilleur score
        If Square(x1, y1).value > BestScore Then
            BestScore = Square(x1, y1).value
            frmGame.lblScore.Text = "Meilleure score : " & BestScore
        End If

        ' Win ?
        If Not alreadyWin Then
            If Square(x1, y1).value = 2048 Then
                Call MsgBox("Bravo ! Vous avez atteint le nombre 2048 ! Vous pouvez continuer de jouer pour augmenter votre score !", vbYes, GAME_NAME)
                alreadyWin = True
            End If
        End If

        ' et on le fait bouger
        Call moveSquare(direction, x1, y1, x2, y2)

        Square(x2, y2).PourcentVisible = 150

        ' on enlève 1 carré
        NumberOfFullCase = NumberOfFullCase - 1

    End Sub

    Public Sub moveSquare(ByVal direction As Byte, ByVal x1 As Long, ByVal y1 As Long, ByVal x2 As Long, ByVal y2 As Long)

        ' on change de position le carré
        Square(x2, y2) = Square(x1, y1)

        ' on lui un offset pour l'animation
        Select Case direction
            Case DirectionEnum.Right
                Square(x2, y2).xOffset = Square(x2, y2).xOffset - SQUARE_SIZE
            Case DirectionEnum.Left
                Square(x2, y2).xOffset = Square(x2, y2).xOffset + SQUARE_SIZE
            Case DirectionEnum.Down
                Square(x2, y2).yOffset = Square(x2, y2).yOffset - SQUARE_SIZE
            Case DirectionEnum.Up
                Square(x2, y2).yOffset = Square(x2, y2).yOffset + SQUARE_SIZE
        End Select

        Call ClearSquare(x1, y1)

    End Sub

    Public Sub SpawnSquare()
        Dim Founded As Boolean = False
        Dim x As Long, y As Long

        Do While Not Founded And NumberOfFullCase < 16
            x = random(0, 3)
            y = random(0, 3)

            If Not Square(x, y).alive Then

                With Square(x, y)
                    .alive = True

                    ' on donne une valeur
                    If random(1, 2) = 1 Then
                        .value = 2
                    Else
                        .value = 4
                    End If

                    .xOffset = 0
                    .yOffset = 0
                    .PourcentVisible = 0

                End With

                Founded = True
                NumberOfFullCase = NumberOfFullCase + 1
            End If

        Loop

    End Sub

    Public Function isSquare(ByVal xSouris As Double, ByVal ySouris As Double) As Boolean
        Dim posX As Long, posY As Long

        ' rien trouvé
        isSquare = False

        For x2 = 0 To 3
            For y2 = 0 To 3

                ' on calcule la position des carrés
                posX = x2 * (SQUARE_SIZE + 10) + 5
                posY = y2 * (SQUARE_SIZE + 5) + 15

                If (xSouris >= posX And xSouris <= posX + SQUARE_SIZE) And (ySouris >= posY And ySouris <= posY + SQUARE_SIZE) Then
                    isSquare = True ' trouvé
                    Exit Function
                End If

            Next
        Next

    End Function

    Public Function haveLost() As Boolean
        Dim x As Long = 0, y As Long = 0
        haveLost = False

        If NumberOfFullCase >= 16 Then

            ' 1 ère ligne
            For x = 0 To 3

                ' 1ère ligne
                If x < 3 Then
                    If Square(x, y).value = Square(x + 1, y).value Then
                        Exit Function
                    End If
                End If

                If Square(x, y).value = Square(x, y + 1).value Then
                    Exit Function
                End If

                ' 2 ème ligne
                If x < 3 Then
                    If Square(x, y + 1).value = Square(x + 1, y + 1).value Then
                        Exit Function
                    End If
                End If

                If Square(x, y + 1).value = Square(x, y + 2).value Then
                    Exit Function
                End If

                '3ème ligne
                If x < 3 Then
                    If Square(x, y + 2).value = Square(x + 1, y + 2).value Then
                        Exit Function
                    End If
                End If

                If Square(x, y + 2).value = Square(x, y + 3).value Then
                    Exit Function
                End If

            Next

            haveLost = True
        End If

    End Function

End Class
