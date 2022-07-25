Imports MySql.Data.MySqlClient


Public Class frmEmployee

    Dim employeeid As Integer = txtemployeeid.Text
    Dim fname As String = txtFName.Text
    Dim mname As String = txtMName.Text
    Dim lname As String = txtLName.Text
    Dim address As String = txtAddress.Text
    Dim contactnum As Double = txtNumber.Text
    Dim gender As String = cboGender.Text
    Dim emailaddress As String = txtEmail.Text

    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim comm As MySqlCommand
        conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=hbrs_db;port=3306;"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "insert into employee (Employee ID, First Name, Middle Name, Last Name, Address, Contact Number, Gender, Email Address) values ('" & employeeid & "', '" & fname & "','" & mname & "','" & lname & "','" & address & "','" & contactnum & "','" & gender & "','" & emailaddress & "') "
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            MessageBox.Show("Employee Added")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs) Handles bttnUpdate.Click
        Dim conn As New MySqlConnection
        Dim comm As MySqlCommand
        conn.ConnectionString = "server=localhost;userid=root;password=;database=hbrs_db;"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "update employee set Employee ID ='" & employeeid & "',First Name = '" & fname & "',Middle Name = '" & mname & "',Last Name = '" & lname & "',Address = '" & address & "',Contact Number = '" & contactnum & "',Gender = '" & gender & "',Email Address = '" & emailaddress & "' "
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            MessageBox.Show("Employee Updated")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub bttnDelete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        Dim conn As New MySqlConnection
        Dim comm As MySqlCommand
        conn.ConnectionString = "server=localhost;userid=root;password=;database=hbrs_db;"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "delete employee where Employee ID ='" & employeeid & "',First Name = '" & fname & "',Middle Name = '" & mname & "',Last Name = '" & lname & "',Address = '" & address & "',Contact Number = '" & contactnum & "',Gender = '" & gender & "',Email Address = '" & emailaddress & "' "
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            MessageBox.Show("Employee Deleted")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Dim out_app As String = MsgBox("Do you want to cancel?", vbQuestion + vbYesNo, "Employee")
        If out_app = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class