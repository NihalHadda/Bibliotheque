Module gestion_Livre
    Public Structure Livre
        Dim ISBN As Integer
        Dim Titre As String
        Dim Auteur As String
    End Structure

    Public bibliotheque As New List(Of Livre)()

    Function AjouterLivre(l As Livre) As Boolean

        For Each livre In bibliotheque
            If livre.ISBN = l.ISBN Then
                Return False
            End If
        Next

        bibliotheque.Add(l)
        Return True
    End Function


    Sub Afficher_Livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        l1.Items.Clear()
        l2.Items.Clear()
        l3.Items.Clear()

        For Each livre In bibliotheque
            l1.Items.Add(livre.ISBN)
            l2.Items.Add(livre.Titre)
            l3.Items.Add(livre.Auteur)
        Next
    End Sub


    Sub Afficher3_livre(dgv_livre As DataGridView)

        dgv_livre.Rows.Clear()

        For Each livre In bibliotheque
            dgv_livre.Rows.Add(livre.ISBN, livre.Titre, livre.Auteur)
        Next
    End Sub
End Module
