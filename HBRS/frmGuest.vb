Imports MySql.Data.MySqlClient

Public Class frmGuest

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        Dim conn As New MySqlConnection
        Dim comm As MySqlCommand

        conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=hbrs_db;port=3306;"
        Dim reader As MySqlDataReader

        Dim guestid As Integer
        Dim firstname As String
        Dim middlename As String
        Dim lastname As String
        Dim address As String
        Dim contact As Double
        Dim gender As Boolean
        Dim emailaddress As String

        guestid = txtGuestID.Text
        firstname = txtFName.Text
        middlename = txtMName.Text
        lastname = txtLName.Text
        address = txtAddress.Text
        contact = txtNumber.Text
        gender = cboGender.Text
        emailaddress = txtEmail.Text


        Try
            conn.Open()
            Dim query As String
            query = "insert into guests(Guest ID, First Name, Middle Name, Last Name, Address, Contact Number, Gender, Email Address, Status, Remarks) values ('" & guestid & "', '" & firstname & "', '" & middlename & "', '" & lastname & "', '" & address & "', '" & contact & "', '" & gender & "', '" & emailaddress & "')"
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            MessageBox.Show("Guest Added Successfully")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Dim fname As String = Trim(txtFName.Text)
        Dim mname As String = Trim(txtMName.Text)
        Dim lname As String = Trim(txtLName.Text)
        Dim add As String = Trim(txtAddress.Text)
        Dim num As String = Trim(txtNumber.Text)
        Dim email As String = Trim(txtEmail.Text)
        Dim stat As String = "Active"
        Dim remark As String = "Available"

        If fname = Nothing Or mname = Nothing Or lname = Nothing Or add = Nothing Or num = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            MsgBox("Guest Added!", vbInformation, "Note")
            txtFName.Clear()
            txtMName.Clear()
            txtLName.Clear()
            txtAddress.Clear()
            txtNumber.Clear()
            txtEmail.Clear()
        End If
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        txtFName.Clear()
        txtMName.Clear()
        txtLName.Clear()
        txtAddress.Clear()
        txtNumber.Clear()
        txtEmail.Clear()
        Dim out_app As String = MsgBox("Do you want to exit?", vbQuestion + vbYesNo, "Guest")
        If out_app = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub DgGuestlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgGuestlist.CellContentClick

    End Sub


    'Private Sub frmGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim conn As New MySqlConnection
    'Dim comm As MySqlCommand

    '   conn.ConnectionString = "server=localhost;userid=root;password=;database=hbrs_db;"
    'Dim da As MySqlDataAdapter
    'Dim dbdataset As New DataTable
    'Dim bsource As New BindingSource


    'Try
    '       conn.Open()
    'Dim query As String
    '       query = "select from hbrs_db.guests where GuestId,First Name,Middle Name, Last Name, Address, Contact Number, Gender, Email Address ='" & txtGuestID.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & txtAddress.Text & "','" & txtNumber.Text & "','" & cboGender.Text & "','" & txtEmail.Text & "',) "
    '      comm = New MySqlCommand(query, conn)
    '     da.SelectCommand = comm
    '    da.Fill(dbdataset)
    '   bsource.DataSource = dbdataset
    '  DgGuestlist.DataSource = bsource
    ' da.Update(dbdataset)

    'conn.Close()

    'Catch ex As Exception
    '       MessageBox.Show(ex.Message)
    'Finally
    '       conn.Dispose()
    'End Try
    ' End Sub

    '  Private Sub DgGuestlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgGuestlist.CellContentClick
    ' If e.RowIndex >= 0 Then
    'Dim row As DataGridViewRow
    '       row = Me.DgGuestlist.Rows(e.RowIndex)
    '
    ' txtGuestID.Text = row.Cells("Guest ID").Value.ToString
    'txtFName.Text = row.Cells("First Name").Value.ToString
    'txtMName.Text = row.Cells("Middle Name").Value.ToString
    'txtLName.Text = row.Cells("Last Name").Value.ToString
    ' txtAddress.Text = row.Cells("Address").Value.ToString
    ' txtNumber.Text = row.Cells("Contact Number").Value.ToString
    ' cboGender.Text = row.Cells("Gender").Value.ToString
    ' txtEmail.Text = row.Cells("Email Address").Value.ToString

    '    End If
    '   End Sub
End Class