Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Authenticate(txtUserName.Text, txtPassword.Text) Then
            FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, True)
        End If


    End Sub

    Private Function Authenticate(ByVal userName As String, ByVal password As String) As Boolean
        If userName.Equals("admin") AndAlso password.Equals("password") Then
            Return True
        End If
        Return False
    End Function
End Class