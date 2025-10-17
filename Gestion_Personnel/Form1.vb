Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub Go1_Click(sender As Object, e As EventArgs) Handles Go1.Click
        ' Récupération des valeurs entrées par l’utilisateur
        Dim emailSaisi As String = mail1.Text.Trim()
        Dim mdpSaisi As String = psw1.Text.Trim()

        ' Vérification basique que les champs ne soient pas vides
        If emailSaisi = "" OrElse mdpSaisi = "" Then
            MessageBox.Show("Veuillez remplir tous les champs avant de continuer.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Vérification des informations dans l'arrayList globale
        Dim compteTrouve As Boolean = False

        For Each u As User In Users
            If u.Email = emailSaisi AndAlso u.Password = mdpSaisi Then
                compteTrouve = True
                Exit For
            End If
        Next

        ' Si tout est bon
        If compteTrouve Then
            MessageBox.Show("Connexion réussie.", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Ouvrir le Form3
            Form3.Show()
            Me.Close()
        Else
            MessageBox.Show("Ce compte n'existe pas. Créez-le en suivant le lien plus bas.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
