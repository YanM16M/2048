<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.picGame = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(2, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 55)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "2048"
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewGame.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnNewGame.ForeColor = System.Drawing.Color.White
        Me.btnNewGame.Location = New System.Drawing.Point(341, 12)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(94, 73)
        Me.btnNewGame.TabIndex = 4
        Me.btnNewGame.Text = "Nouvelle partie"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'tmrDraw
        '
        Me.tmrDraw.Interval = 1
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 1
        '
        'picGame
        '
        Me.picGame.Location = New System.Drawing.Point(12, 91)
        Me.picGame.Name = "picGame"
        Me.picGame.Size = New System.Drawing.Size(423, 416)
        Me.picGame.TabIndex = 5
        Me.picGame.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(9, 75)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(93, 13)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Meilleure score : 2"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(447, 519)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picGame)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2048"
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents btnNewGame As Button
    Friend WithEvents tmrDraw As Timer
    Friend WithEvents tmrGame As Timer
    Friend WithEvents picGame As PictureBox
    Friend WithEvents lblScore As Label
End Class
