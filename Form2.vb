Public Class Form2
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Auteur.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher_Livre(LB_ISBN, LB_Titre, LB_Auteur)
    End Sub
End Class