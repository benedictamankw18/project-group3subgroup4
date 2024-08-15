Imports System.IO

Public Class splash_screen
    Public Shared log As String = Application.StartupPath & "\ Log.txt"
    Public Shared lines As Integer = 0
    Dim count As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count = 6 Then
            Me.Hide()
            frmsignIn.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            If File.Exists(log.ToString) Then
                Using reader As New StreamReader(log.ToString)
                    lines = reader.ReadToEnd.Length
                End Using
            End If
            Using writer As New StreamWriter(log.ToString, True)
                If lines < 1 Then
                    writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                    lines = 4
                End If
                writer.WriteLine(Date.Now & vbTab & " LUNCHING THE APPLICATION " & vbTab & "LUNCHER")
            End Using

        Catch ex As Exception
        End Try
    End Sub
End Class