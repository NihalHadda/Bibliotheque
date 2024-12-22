<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_ISBN = New System.Windows.Forms.TextBox()
        Me.T_Auteur = New System.Windows.Forms.TextBox()
        Me.T_Titre = New System.Windows.Forms.TextBox()
        Me.bt_Afficher = New System.Windows.Forms.Button()
        Me.bt_Ajouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(116, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(116, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(116, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Auteur"
        '
        'T_ISBN
        '
        Me.T_ISBN.Location = New System.Drawing.Point(235, 85)
        Me.T_ISBN.Name = "T_ISBN"
        Me.T_ISBN.Size = New System.Drawing.Size(100, 22)
        Me.T_ISBN.TabIndex = 4
        '
        'T_Auteur
        '
        Me.T_Auteur.Location = New System.Drawing.Point(235, 272)
        Me.T_Auteur.Name = "T_Auteur"
        Me.T_Auteur.Size = New System.Drawing.Size(100, 22)
        Me.T_Auteur.TabIndex = 5
        '
        'T_Titre
        '
        Me.T_Titre.Location = New System.Drawing.Point(235, 172)
        Me.T_Titre.Name = "T_Titre"
        Me.T_Titre.Size = New System.Drawing.Size(100, 22)
        Me.T_Titre.TabIndex = 6
        '
        'bt_Afficher
        '
        Me.bt_Afficher.BackColor = System.Drawing.Color.Silver
        Me.bt_Afficher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Afficher.ForeColor = System.Drawing.Color.Navy
        Me.bt_Afficher.Location = New System.Drawing.Point(283, 355)
        Me.bt_Afficher.Name = "bt_Afficher"
        Me.bt_Afficher.Size = New System.Drawing.Size(97, 38)
        Me.bt_Afficher.TabIndex = 8
        Me.bt_Afficher.Text = "Afficher"
        Me.bt_Afficher.UseVisualStyleBackColor = False
        '
        'bt_Ajouter
        '
        Me.bt_Ajouter.BackColor = System.Drawing.Color.Silver
        Me.bt_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Ajouter.ForeColor = System.Drawing.Color.Navy
        Me.bt_Ajouter.Location = New System.Drawing.Point(121, 355)
        Me.bt_Ajouter.Name = "bt_Ajouter"
        Me.bt_Ajouter.Size = New System.Drawing.Size(97, 38)
        Me.bt_Ajouter.TabIndex = 10
        Me.bt_Ajouter.Text = "Ajouter"
        Me.bt_Ajouter.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bt_Ajouter)
        Me.Controls.Add(Me.bt_Afficher)
        Me.Controls.Add(Me.T_Titre)
        Me.Controls.Add(Me.T_Auteur)
        Me.Controls.Add(Me.T_ISBN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T_ISBN As TextBox
    Friend WithEvents T_Auteur As TextBox
    Friend WithEvents T_Titre As TextBox
    Friend WithEvents bt_Afficher As Button
    Friend WithEvents bt_Ajouter As Button
End Class
