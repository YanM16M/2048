Public Class MoteurUI

    ' ##########################################################################################################################################
    ' ##### VARIABLES ##########################################################################################################################
    ' ##########################################################################################################################################

    Public Moteur As New Moteur

    ' ##########################################################################################################################################
    ' ##### DRAWING ############################################################################################################################
    ' ##########################################################################################################################################

    Public Sub DrawRectangle(e As PaintEventArgs, ByVal x As Long, ByVal y As Long, ByVal width As Long, height As Long, ByVal Brushes1 As Brush)
        Dim myGraphics As Graphics = e.Graphics

        ' on dessine le rectangle
        myGraphics.FillRectangle(Brushes1, x, y, width, height)

    End Sub

    Public Sub DrawText(e As PaintEventArgs, ByVal text As String, ByVal x As Single, ByVal y As Single, ByVal Brushes1 As Brush)
        Dim myGraphics As Graphics = e.Graphics

        ' on dessine le text
        myGraphics.DrawString(text, New Font("Tahoma", 26), Brushes1, New Point(x, y))
    End Sub

    Public Sub DrawGame(e As PaintEventArgs)
        Dim value As Long, xOffset As Long, yOffset As Long
        Dim posX As Long, posY As Long

        ' on dessine le fond en premier
        For x = 0 To 3
            For y = 0 To 3
                ' On calcule la position des carrés
                posX = x * (SQUARE_SIZE + 10) + 5
                posY = y * (SQUARE_SIZE + 5) + 15

                ' on dessine le fond des carrées 
                Call DrawRectangle(e, posX, posY, SQUARE_SIZE, SQUARE_SIZE, Brushes.Brown)
            Next
        Next

        ' on dessine les carrés
        For x = 0 To 3
            For y = 0 To 3

                ' on récupère la valeur du carré
                value = Moteur.GetSquareValue(x, y)

                ' on récupère les offsets ( pour le mouvement ) 
                xOffset = Moteur.GetXoffset(x, y)
                yOffset = Moteur.GetYoffset(x, y)

                ' On calcule la position des carrés
                posX = x * (SQUARE_SIZE + 10) + 5
                posY = y * (SQUARE_SIZE + 5) + 15

                ' Si le carré est en jeu alors
                If Moteur.GetAlive(x, y) Then
                    Dim pourcentVisible As Double

                    ' apparition en grossisant
                    pourcentVisible = Moteur.GetPourcentVisible(x, y) / 100

                    ' on dessine les carrés du jeu
                    posX = posX + xOffset + ((SQUARE_SIZE / 2) * (1 - pourcentVisible)) + 2
                    posY = posY + yOffset + ((SQUARE_SIZE / 2) * (1 - pourcentVisible)) + 2

                    ' le carré 
                    Call DrawRectangle(e, posX, posY, (SQUARE_SIZE - 4) * pourcentVisible, (SQUARE_SIZE - 4) * pourcentVisible, getBrushColor(value))

                    ' le texte
                    If value > 999 Then
                        Call DrawText(e, value, (x * (SQUARE_SIZE + 10) + 5) + (SQUARE_SIZE / 2) - 45 + xOffset, (y * (SQUARE_SIZE + 5) + 15) + (SQUARE_SIZE / 2) - 22 + yOffset, getTextColor(value))
                    Else
                        Call DrawText(e, value, (x * (SQUARE_SIZE + 10) + 5) + (SQUARE_SIZE / 2) - 22 + xOffset, (y * (SQUARE_SIZE + 5) + 15) + (SQUARE_SIZE / 2) - 22 + yOffset, getTextColor(value))
                    End If
                End If
            Next
        Next

    End Sub

    Public Function getBrushColor(ByVal value As Long) As Brush

        Select Case value
            Case 0, 2, 4
                getBrushColor = Brushes.Beige
            Case 8, 16
                getBrushColor = Brushes.Orange
            Case 32, 64
                getBrushColor = Brushes.Red
            Case Else
                getBrushColor = Brushes.DarkOrange
        End Select

    End Function

    Public Function getTextColor(ByVal value As Long) As Brush

        Select Case value
            Case 0, 2, 4
                getTextColor = Brushes.Brown
            Case Else
                getTextColor = Brushes.White
        End Select

    End Function

End Class
