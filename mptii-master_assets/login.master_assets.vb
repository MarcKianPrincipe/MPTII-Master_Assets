Imports System.Data.SqlClient

Public Class loginForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Integrated Security=True"
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Create a SQL connection and command objects
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT COUNT(*) FROM [DBmptii_master-asset].[dbo].[TBmptii-users] WHERE [Username] = @Username AND [Password] = @Password"
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                ' Open the connection
                connection.Open()

                ' Execute the command and retrieve the result
                Dim count As Integer = CInt(command.ExecuteScalar())

                ' Check if the username and password match the user credentials
                If count > 0 Then
                    ' Check if the user is an admin
                    If isAdmin(username, password, connection) Then
                        MessageBox.Show("Login successful as Admin")
                        Dim adminForm As New adminForm()
                        adminForm.Show()
                    Else
                        MessageBox.Show("Login successful as User")
                        Dim userForm As New userForm()
                        userForm.Show()
                    End If

                    ' Hide the login form
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        ' Change the button's hover color to #0f1d41
        btnLogin.BackColor = ColorTranslator.FromHtml("#0f1d41")
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        ' Change the button's color to #1f9bde
        btnLogin.BackColor = ColorTranslator.FromHtml("#1f9bde")
    End Sub



    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simulate a click event on the login button
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simulate a click event on the login button
            btnLogin.PerformClick()
        End If
    End Sub

    Private Function isAdmin(username As String, password As String, connection As SqlConnection) As Boolean
        ' Implement your logic to determine if the user is an admin
        ' You can query the database to check if the user has an admin role assigned
        ' For example, you can execute a separate SELECT query or use a stored procedure to retrieve the user's role from the table
        ' Here, let's assume the admin role is represented by "Admin"
        Using command As New SqlCommand()
            command.Connection = connection
            command.CommandText = "SELECT COUNT(*) FROM [DBmptii_master-asset].[dbo].[TBmptii-users] WHERE [Username] = @Username AND [Password] = @Password AND [Role] = 'Admin'"
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            Dim count As Integer = CInt(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function
End Class
