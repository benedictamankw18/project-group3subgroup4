Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports WindowsApp1.databaseClass
Imports WindowsApp1.Mode
Imports System.IO

Public Class frmsignIn
    Public query As String = ""

    Private isShowing As Boolean = False
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Length > 0 Then
            lblPassword.Visible = True
        Else
            lblPassword.Visible = False
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text.Length > 0 Then
            lblUsername.Visible = True
        Else
            lblUsername.Visible = False
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If isShowing Then
            txtPassword.UseSystemPasswordChar = True
            btnView.Image = Nothing
            btnView.Image = My.Resources.eye30px
            isShowing = False
        Else
            txtPassword.UseSystemPasswordChar = False
            btnView.Image = Nothing
            btnView.Image = My.Resources.hide30
            isShowing = True
        End If
    End Sub



    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        If File.Exists(splash_screen.log.ToString) Then
            Using writer As New StreamWriter(splash_screen.log.ToString, True)
                writer.WriteLine(Date.Now & vbTab & " tried logging  " & vbTab & "SIGN IN")
            End Using
        Else
            Using writer As New StreamWriter(splash_screen.log.ToString, True)
                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                writer.WriteLine(Date.Now & vbTab & " tried logging  " & vbTab & "SIGN IN")
            End Using
        End If

        Try
            Dim isCorrectEmail As Boolean = showMatch(txtUsername.Text, "\b([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,8})(\.[a-z]{2,8})?\b")
            If txtUsername.Text.Length = 0 And txtPassword.Text.Length = 0 Then
                MessageBox.Show("Enter your Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtUsername.Text.Length = 0 Then
                MessageBox.Show("Enter your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtPassword.Text.Length = 0 Then
                MessageBox.Show("Enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If isCorrectEmail Then
                    query = "SELECT login.User_Id, login.User_role, login.Username, user.First_email, login.Password FROM g3subvb.user INNER JOIN g3subvb.login ON g3subvb.user.User_Id = g3subvb.login.User_Id WHERE BINARY user.First_email = @Username AND BINARY login.Password = @Password"
                Else
                    query = "SELECT login.User_Id, login.User_role, login.Username, login.Password FROM g3subvb.login WHERE BINARY login.Username = @Username AND BINARY login.Password = @Password"
                End If

                Using connection As New MySqlConnection(My.Settings.conPathDb)
                    connection.Open()
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", txtUsername.Text)
                        command.Parameters.AddWithValue("@Password", txtPassword.Text)

                        Dim reader As Object = command.ExecuteReader()
                        If reader.Read() Then
                            user_role = Convert.ToString(reader("User_role"))
                            username = Convert.ToString(reader("Username"))
                            password = Convert.ToString(reader("Password"))
                            UserId = Convert.ToInt64(reader("User_Id"))
                        End If

                        reader.Close()

                        Using writer As New StreamWriter(splash_screen.log.ToString, True)
                            If splash_screen.lines < 1 Then
                                writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                            End If
                            writer.WriteLine(Date.Now & vbTab & " Logged in has " & "Username: " & username & "  Role: " & user_role & vbTab & "SIGN IN")
                        End Using

                        If Not String.IsNullOrEmpty(user_role) Then
                            MsgBox(user_role)

                            If user_role = "Admin" Then
                                Me.Hide()
                                frmDashboard.Show()
                            Else
                                Me.Hide()
                                frmAgentDashboard.Show()
                            End If
                        Else
                            MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    End Using
                End Using

                Dim Profilequery As String = "Select login.User_Id, user.Profile_pic from user LEFT JOIN login on user.User_Id = login.User_Id where login.Username = @Username and login.Password = @Password and login.User_role = @Role;"

                Using connection As New MySqlConnection(My.Settings.conPathDb)
                    connection.Open()
                    Using command As New MySqlCommand(Profilequery, connection)
                        command.Parameters.AddWithValue("@Password", password)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Role", user_role)

                        Dim reader As Object = command.ExecuteReader()
                        If reader.Read() Then
                            If Not (reader("Profile_pic") Is DBNull.Value) Then
                                Dim imageData() As Byte = DirectCast(reader("Profile_pic"), Byte())

                                Using ms As New MemoryStream(imageData)
                                    frmDashboard.btnUserIcon.Image = Image.FromStream(ms)
                                End Using
                            Else
                                frmDashboard.btnUserIcon.Image = Nothing
                            End If

                        End If

                        reader.Close()

                    End Using
                End Using
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub frmsignIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        user_role = ""
        username = ""
        UserId = 0
    End Sub

    Function showMatch(ByVal text As String, ByVal expr As String) As Boolean
        Dim mc As MatchCollection = Regex.Matches(text, expr)
        Dim m As Match

        For Each m In mc
            Return True
        Next

        Return False
    End Function


End Class