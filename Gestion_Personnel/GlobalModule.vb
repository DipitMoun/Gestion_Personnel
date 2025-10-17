' Classe représentant un utilisateur
Public Class User
    Public Property Nom As String
    Public Property Prenom As String
    Public Property Telephone As Integer
    Public Property Email As String
    Public Property Password As String
End Class
Module GlobalModule

    ' Liste globale des utilisateurs
    Public Users As New ArrayList()

End Module
