<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnGameSimple = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.btnCtrl = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.lblCtrl = New System.Windows.Forms.Label()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.ForeColor = System.Drawing.Color.White
        Me.btnCredits.Location = New System.Drawing.Point(12, 190)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(270, 23)
        Me.btnCredits.TabIndex = 0
        Me.btnCredits.Text = "Crédits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnGameSimple
        '
        Me.btnGameSimple.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGameSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGameSimple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGameSimple.ForeColor = System.Drawing.Color.White
        Me.btnGameSimple.Location = New System.Drawing.Point(12, 45)
        Me.btnGameSimple.Name = "btnGameSimple"
        Me.btnGameSimple.Size = New System.Drawing.Size(270, 23)
        Me.btnGameSimple.TabIndex = 1
        Me.btnGameSimple.Text = "Jeu simple"
        Me.btnGameSimple.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(97, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 33)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "2048"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(12, 219)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(270, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Quitter"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(9, 45)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(20, 16)
        Me.lblCredits.TabIndex = 4
        Me.lblCredits.Text = "..."
        Me.lblCredits.Visible = False
        '
        'btnCtrl
        '
        Me.btnCtrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtrl.ForeColor = System.Drawing.Color.White
        Me.btnCtrl.Location = New System.Drawing.Point(12, 74)
        Me.btnCtrl.Name = "btnCtrl"
        Me.btnCtrl.Size = New System.Drawing.Size(270, 23)
        Me.btnCtrl.TabIndex = 5
        Me.btnCtrl.Text = "Contrôles"
        Me.btnCtrl.UseVisualStyleBackColor = False
        '
        'btnRules
        '
        Me.btnRules.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRules.ForeColor = System.Drawing.Color.White
        Me.btnRules.Location = New System.Drawing.Point(12, 103)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(270, 23)
        Me.btnRules.TabIndex = 6
        Me.btnRules.Text = "Règles"
        Me.btnRules.UseVisualStyleBackColor = False
        '
        'lblCtrl
        '
        Me.lblCtrl.Font = New System.Drawing.Font("Oswald", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtrl.Location = New System.Drawing.Point(12, 45)
        Me.lblCtrl.Name = "lblCtrl"
        Me.lblCtrl.Size = New System.Drawing.Size(279, 200)
        Me.lblCtrl.TabIndex = 7
        Me.lblCtrl.Tag = "1"
        Me.lblCtrl.Text = resources.GetString("lblCtrl.Text")
        Me.lblCtrl.Visible = False
        '
        'lblRules
        '
        Me.lblRules.Font = New System.Drawing.Font("Oswald", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.Location = New System.Drawing.Point(8, 42)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(283, 203)
        Me.lblRules.TabIndex = 8
        Me.lblRules.Text = resources.GetString("lblRules.Text")
        Me.lblRules.Visible = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(294, 254)
        Me.Controls.Add(Me.btnRules)
        Me.Controls.Add(Me.btnCtrl)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnGameSimple)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.lblCtrl)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.lblRules)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCredits As Button
    Friend WithEvents btnGameSimple As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCredits As Label
    Friend WithEvents btnCtrl As Button
    Friend WithEvents btnRules As Button
    Friend WithEvents lblCtrl As Label
    Friend WithEvents lblRules As Label
End Class
