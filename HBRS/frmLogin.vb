Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim conn As New MySqlConnection
    Dim comm As New MySqlCommand


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=hbrs_db;port=3306;"
        Dim reader As MySqlDataReader

        Dim username As String
        Dim password As String

        username = UsernameTextBox.Text
        password = PasswordTextBox.Text


        Try
            conn.Open()
            Dim query As String
            query = "select * from users where Username='" & username & "' and Password='" & password & "' "
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count += 1
            End While

            If count = 1 Then
                MessageBox.Show("Login Successful")
                Me.Hide()
                frmMain.ShowDialog()
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                ' ElseIf count > 1 Then
            Else
                MessageBox.Show("Login Failed")
            End If

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
