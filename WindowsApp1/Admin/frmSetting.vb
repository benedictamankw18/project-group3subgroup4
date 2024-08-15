Imports WindowsApp1.Mode
Imports WindowsApp1.databaseClass
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmSetting
    Dim databaseConnection As databaseClass
    Dim Profile_pic As Byte()
    Private isShowing As Boolean = False
    Private isConShowing As Boolean = False

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Try

            openDialog1.Title = "PROFILE PICTURE"
        openDialog1.Filter = "Image Files (.jpg, .jpeg, .png)|*.jpg;*.jpeg;*.png"
            If openDialog1.ShowDialog() = DialogResult.OK Then
                pboProfile.Image = Image.FromFile(openDialog1.FileName)
                Profile_pic = File.ReadAllBytes(openDialog1.FileName)


                Dim user_id As Int64
                Dim query As String = "Select login.User_Id from login  where login.Username = @Username and login.Password = @Password and login.User_role = @Role;"

                Using writer As New StreamWriter(splash_screen.log.ToString, True)
                    If splash_screen.lines < 1 Then
                        writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                    End If
                    writer.WriteLine(Date.Now & vbTab & "Changing your Profile Picture from the Database" & vbTab & Me.Text)
                End Using


                Using connection As New MySqlConnection(My.Settings.conPathDb)
                    connection.Open()
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Password", password)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Role", user_role)

                        Dim reader As Object = command.ExecuteReader()
                        If reader.Read() Then
                            user_id = Convert.ToInt64(reader("User_Id"))

                        End If
                        reader.Close()
                        Dim updateImageQuery As String = "UPDATE g3subvb.user SET user.Profile_pic = @Image where user.User_Id = @User_Id;"

                        Using updateImagesCommand As New MySqlCommand(updateImageQuery, connection)
                            updateImagesCommand.Parameters.AddWithValue("@User_Id", user_id)
                            updateImagesCommand.Parameters.AddWithValue("@Image", Profile_pic)
                            updateImagesCommand.ExecuteNonQuery()
                        End Using

                    End Using
                End Using


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserRole.Text = user_role
        txtUsername.Text = username
        'txtPass.Text = password

        Dim query As String = "Select login.User_Id, user.Profile_pic from user LEFT JOIN login on user.User_Id = login.User_Id where login.Username = @Username and login.Password = @Password and login.User_role = @Role;"

        Using connection As New MySqlConnection(My.Settings.conPathDb)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Role", user_role)

                Dim reader As Object = command.ExecuteReader()
                If reader.Read() Then
                    If Not (reader("Profile_pic") Is DBNull.Value) Then
                        Dim imageData() As Byte = DirectCast(reader("Profile_pic"), Byte())

                        Using ms As New MemoryStream(imageData)
                            pboProfile.Image = Image.FromStream(ms)
                        End Using
                    Else
                        pboProfile.Image = Nothing
                    End If

                End If

                reader.Close()

            End Using
        End Using
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Try
            If txtPass.Text.Length = 0 Then
                MessageBox.Show("Enter your old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtCPass.Text.Length < 8 Then
                MessageBox.Show("Enter eight characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not txtPass.Text.Equals(password) Then
                MessageBox.Show("Wrong Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtPass.Text.Equals(txtCPass.Text) Then
                MessageBox.Show("The Password are the Same", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If



            Dim Message As DialogResult = MessageBox.Show("Are you sure you want to Change your Password?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If Message = DialogResult.Yes Then

                Dim query As String = "Update g3subvb.login SET login.Password = @ChangedPassword where login.Password = @Password And login.User_role = @Role And login.Username = @Username;"

                Using writer As New StreamWriter(splash_screen.log.ToString, True)
                    If splash_screen.lines < 1 Then
                        writer.WriteLine("DATE TIME" & vbTab & vbTab & " ACTION" & vbTab & vbTab & vbTab & vbTab & " LOCATION")
                    End If
                    writer.WriteLine(Date.Now & vbTab & "Changing your password from the Database" & vbTab & Me.Text)
                End Using

                Using connection As New MySqlConnection(My.Settings.conPathDb)

                    connection.Open()

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Password", password)
                        command.Parameters.AddWithValue("@ChangedPassword", txtCPass.Text)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Role", user_role)

                        Dim reader As Object = command.ExecuteReader()

                        reader.Close()
                        txtPass.Clear()
                        txtCPass.Clear()

                        MessageBox.Show("The Password has been Change Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnPassView_Click(sender As Object, e As EventArgs) Handles btnPassView.Click
        If isShowing Then
            txtPass.UseSystemPasswordChar = True
            btnPassView.Image = Nothing
            btnPassView.Image = My.Resources.eye30px
            isShowing = False
        Else
            txtPass.UseSystemPasswordChar = False
            txtPass.PasswordChar = ""
            btnPassView.Image = Nothing
            btnPassView.Image = My.Resources.hide30
            isShowing = True
        End If
    End Sub

    Private Sub btnComPassView_Click(sender As Object, e As EventArgs) Handles btnComPassView.Click
        If isConShowing Then
            txtCPass.UseSystemPasswordChar = True
            btnComPassView.Image = Nothing
            btnComPassView.Image = My.Resources.eye30px
            isConShowing = False
        Else
            txtCPass.UseSystemPasswordChar = False
            txtCPass.PasswordChar = ""
            btnComPassView.Image = Nothing
            btnComPassView.Image = My.Resources.hide30
            isConShowing = True
        End If
    End Sub

    Private Sub lilblHistroy_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblHistroy.LinkClicked
        frmLog.ShowDialog()
    End Sub

    Private Sub lilblClient_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblClient.LinkClicked
        frmReport.lblshow.Text = lilblClient.Text
        frmReport.ShowDialog()

    End Sub

    Private Sub lilblRent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblRent.LinkClicked
        frmReport.lblshow.Text = lilblRent.Text
        frmReport.ShowDialog()
    End Sub

    Private Sub lilblHousing_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblHousing.LinkClicked
        frmReport.lblshow.Text = lilblHousing.Text
        frmReport.ShowDialog()
    End Sub

    Private Sub lilblTransaction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblTransaction.LinkClicked
        frmReport.lblshow.Text = lilblTransaction.Text
        frmReport.ShowDialog()
    End Sub

    Private Sub lilblAgent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblAgent.LinkClicked
        frmReport.lblshow.Text = lilblAgent.Text
        frmReport.ShowDialog()
    End Sub

    Private Sub lilblSale_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblSale.LinkClicked
        frmReport.lblshow.Text = lilblSale.Text
        frmReport.ShowDialog()
    End Sub

    Private Sub lilblOwner_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lilblOwner.LinkClicked
        frmReport.lblshow.Text = lilblOwner.Text
        frmReport.ShowDialog()
    End Sub
End Class