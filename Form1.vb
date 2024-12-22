Public Class Form1
    ' Bouton pour ajouter un livre
    Private Sub bt_Ajouter_Click(sender As Object, e As EventArgs) Handles bt_Ajouter.Click
        Dim l As Livre
        l.ISBN = Integer.Parse(T_ISBN.Text)
        l.Titre = T_Titre.Text
        l.Auteur = T_Auteur.Text

        If AjouterLivre(l) Then
            MessageBox.Show("Ajout du livre avec succès")
        Else
            MessageBox.Show("Le tableau est saturé")
        End If
    End Sub

    'Bouton pour afficher tous les livres
    Private Sub bt_Afficher_Click(sender As Object, e As EventArgs) Handles bt_Afficher.Click
        Form2.Show()
        Afficher_Livre(Form2.LB_ISBN, Form2.LB_Titre, Form2.LB_Auteur)
    End Sub

End Class
