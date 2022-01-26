Imports System.ComponentModel

Public Class frmGame
    Public Const GAME_NAME As String = "2048" ' variable qui contient le nom du jeu


    Private Sub frmGame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' on pose la question
        If MsgBox("Voulez-vous vraiment quitter le jeu ?", vbYesNo, GAME_NAME) = vbYes Then
            End
        Else
            e.Cancel = True ' on annule la fermeture
        End If

    End Sub


    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        Call UpdateGame
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click


        If MsgBox("Voulez-vous faire une nouvelle partie ?", vbYesNo, GAME_NAME) = vbYes Then
            Call initialiseGame() ' nouvelle partie
        End If

    End Sub



    Private Sub picGame_MouseDown(sender As Object, e As MouseEventArgs) Handles picGame.MouseDown
        Call HandleMouseDown(e.Button, e.X, e.Y)
    End Sub


    Private Sub picGame_MouseUp(sender As Object, e As MouseEventArgs) Handles picGame.MouseUp
        Call HandleMouseUp(e.Button, e.X, e.Y)
    End Sub

    Private Sub picGame_MouseMove(sender As Object, e As MouseEventArgs) Handles picGame.MouseMove
        Call HandleMouseMove(e.Button, e.X, e.Y)
    End Sub

    Private Sub picGame_Paint(sender As Object, e As PaintEventArgs) Handles picGame.Paint
        Call Moteur_UI.DrawGame(e)
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picGame.Invalidate()
    End Sub


    Private Sub frmGame_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Call HandleKeyUp(e.KeyCode)
    End Sub

    Private Sub picGame_KeyUp(sender As Object, e As KeyEventArgs) Handles picGame.KeyUp
        Call HandleKeyUp(e.KeyCode)
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview() = True
    End Sub
End Class