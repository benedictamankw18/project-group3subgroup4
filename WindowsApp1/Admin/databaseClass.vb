Imports MySql.Data.MySqlClient

Public Class databaseClass

    Dim connection As New MySqlConnection
    Public command As New MySqlCommand
    Dim reader As MySqlDataReader

    Public Sub open()
        connection.ConnectionString = My.Settings.conPathDb
        connection.Open()
    End Sub

    Public Sub close()
        connection.Close()
    End Sub

    Public Sub dispose()
        connection.Dispose()

    End Sub

    Public Sub getCommand(ByVal query As String)
        command.CommandText = query
        command.Connection = connection
    End Sub

    Public Function read() As Boolean
        reader = command.ExecuteReader
        While reader.Read
            Return True
        End While
        Return False
    End Function

    'Public Function read() As Boolean
    '    Using reader As MySqlDataReader = command.ExecuteReader()
    '        While reader.Read()
    '            Return True
    '        End While
    '    End Using
    '    Return False
    'End Function

End Class
