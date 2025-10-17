Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerUtilisateurs()
    End Sub

    Public Sub ChargerUtilisateurs()
        ' On efface les lignes
        DataGridView1.Rows.Clear()

        ' On recharge tous les utilisateurs de la arrayList
        For Each u As User In Users
            Dim rowIndex As Integer = DataGridView1.Rows.Add(u.Nom, u.Prenom, u.Telephone.ToString(), u.Email)
            ' Stockage de la référence de l'utilisateur dans la ligne
            DataGridView1.Rows(rowIndex).Tag = u
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Vérifie que c’est bien une ligne valide
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim u As User = TryCast(row.Tag, User)
        If u Is Nothing Then Return

        ' le nom interne de la colonne cliquée
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        Select Case colName
            Case "AEdit"
                ' Ouverture du Form2 en mode édition
                Dim f2 As New Form2()
                f2.ModeEdition = True
                f2.UserEnEdition = u
                f2.ShowDialog()
                ' Recharge du tableau après modification
                ChargerUtilisateurs()

            Case "ADelete"
                ' Confirmation de suppression
                Dim result = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Users.Remove(u)
                    ChargerUtilisateurs()
                End If
        End Select
    End Sub

    Private Sub Go3_Click(sender As Object, e As EventArgs) Handles Go3.Click
        Dim f2 As New Form2()
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class