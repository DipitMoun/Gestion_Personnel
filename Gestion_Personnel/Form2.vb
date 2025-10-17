Public Class Form2
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub

    'Private Sub Go2_Click(sender As Object, e As EventArgs) Handles Go2.Click
    '    Dim f3 As New Form3()
    '    f3.Show()
    '    Me.Hide()
    '    End SubPublic Class Form2

    Private Sub Go2_Click(sender As Object, e As EventArgs) Handles Go2.Click
        ' Lecture des champs
        Dim nom As String = Nom1.Text.Trim()
        Dim prenom As String = Pre1.Text.Trim()
        Dim telString As String = Tel1.Text.Trim()
        Dim email As String = mail2.Text.Trim()
        Dim mdp As String = psw2.Text.Trim()
        Dim mdpConfirme As String = psw3.Text.Trim()

        ' Vérification de base : champs vides
        If nom = "" OrElse prenom = "" OrElse telString = "" OrElse email = "" OrElse mdp = "" OrElse mdpConfirme = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Vérification que le téléphone est bien un nombre entier
        Dim telInt As Integer
        If Not Integer.TryParse(telString, telInt) Then
            MessageBox.Show("Le numéro de téléphone doit être composé uniquement de chiffres.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Vérification correspondance des mots de passe
        If mdp <> mdpConfirme Then
            MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur de confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Vérification que l’email n’existe pas déjà dans le arraylist
        For Each u As User In Users
            If u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Un compte existe déjà avec cet e-mail.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        ' Création du nouvel utilisateur
        Dim newUser As New User()
        newUser.Nom = nom
        newUser.Telephone = telInt
        newUser.Prenom = prenom
        newUser.Email = email
        newUser.Password = mdp

        ' Ajout dans la liste globale
        Users.Add(newUser)

        MessageBox.Show("Compte créé avec succès !.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Redirection vers le Form1 
        Form3.Show()
        Me.Close()
    End Sub
    Public ModeEdition As Boolean = False

    Public UserEnEdition As User = Nothing

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
