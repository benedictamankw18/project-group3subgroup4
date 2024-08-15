Public Class Mode
    Public Shared checkMood As Boolean = False
    Public Shared user_role As String = ""
    Public Shared username As String = ""
    Public Shared password As String = ""
    Public Shared UserId As Integer = 0
    Public Sub Mood()
        If Not checkMood Then

            checkMood = True
        Else
            checkMood = False
        End If
    End Sub


End Class
