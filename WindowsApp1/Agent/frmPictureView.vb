Public Class frmPictureView
    Private Sub pboImage4_Click(sender As Object, e As EventArgs) Handles pboImage4.Click
        pboView.Image = pboImage4.Image
    End Sub

    Private Sub pboImage2_Click(sender As Object, e As EventArgs) Handles pboImage2.Click
        pboView.Image = pboImage2.Image
    End Sub

    Private Sub pboImage3_Click(sender As Object, e As EventArgs) Handles pboImage3.Click
        pboView.Image = pboImage3.Image
    End Sub

    Private Sub pboImage1_Click(sender As Object, e As EventArgs) Handles pboImage1.Click
        pboView.Image = pboImage1.Image
    End Sub

    Private Sub frmPictureView_Load(sender As Object, e As EventArgs) Handles Me.Load
        pboImage1.Size = New Size(102, 60)
        pboImage2.Size = New Size(102, 60)
        pboImage3.Size = New Size(102, 60)
        pboImage4.Size = New Size(102, 60)
    End Sub
End Class