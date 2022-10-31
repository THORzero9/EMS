Public Class Admin


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim userid As String
        Dim password As String
        userid = usertxt.Text
        password = passtxt.Text
        If (usertxt.Text = "admin" And passtxt.Text = "root") Then
            Home.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Login Details")
        End If
    End Sub

    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class