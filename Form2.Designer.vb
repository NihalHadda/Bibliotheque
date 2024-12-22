<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_ISBN = New System.Windows.Forms.ListBox()
        Me.LB_Titre = New System.Windows.Forms.ListBox()
        Me.LB_Auteur = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(116, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(339, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(559, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Auteur"
        '
        'LB_ISBN
        '
        Me.LB_ISBN.FormattingEnabled = True
        Me.LB_ISBN.ItemHeight = 16
        Me.LB_ISBN.Location = New System.Drawing.Point(112, 166)
        Me.LB_ISBN.Name = "LB_ISBN"
        Me.LB_ISBN.Size = New System.Drawing.Size(120, 244)
        Me.LB_ISBN.TabIndex = 4
        '
        'LB_Titre
        '
        Me.LB_Titre.FormattingEnabled = True
        Me.LB_Titre.ItemHeight = 16
        Me.LB_Titre.Location = New System.Drawing.Point(344, 166)
        Me.LB_Titre.Name = "LB_Titre"
        Me.LB_Titre.Size = New System.Drawing.Size(120, 244)
        Me.LB_Titre.TabIndex = 5
        '
        'LB_Auteur
        '
        Me.LB_Auteur.FormattingEnabled = True
        Me.LB_Auteur.ItemHeight = 16
        Me.LB_Auteur.Location = New System.Drawing.Point(564, 166)
        Me.LB_Auteur.Name = "LB_Auteur"
        Me.LB_Auteur.Size = New System.Drawing.Size(120, 244)
        Me.LB_Auteur.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LB_Auteur)
        Me.Controls.Add(Me.LB_Titre)
        Me.Controls.Add(Me.LB_ISBN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LB_ISBN As ListBox
    Friend WithEvents LB_Titre As ListBox
    Friend WithEvents LB_Auteur As ListBox
End Class
