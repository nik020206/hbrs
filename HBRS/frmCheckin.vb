Imports MySql.Data.MySqlClient

Public Class frmCheckin
    Public conn As New MySqlConnection
    Public comm As MySqlCommand

    Private Sub bttnCheckIn_Click(sender As Object, e As EventArgs) Handles bttnCheckIn.Click
        conn.ConnectionString = "server = 127.0.0.1;uid=root;pwd=;database=hbrs_db;port=3306;"
        Dim reader As MySqlDataReader

        Dim transactionid As Integer = txtTransID.Text
        Dim guestname As String = txtGuestName.Text
        Dim roomnum As String = txtRoomNumber.Text
        Dim roomtype As String = txtRoomType.Text
        Dim roomrate As Integer = txtRoomRate.Text
        Dim checkin As Date = dtCheckInDate.Text
        Dim checkout As Date = dtCheckOutDate.Text
        Dim noofdays As Integer = txtDaysNumber.Text
        Dim noofadults As Integer = txtAdults.Text
        Dim noofchildrens As Integer = txtChildren.Text
        Dim subtotal As Integer = txtSubTotal.Text
        Dim advancepay As Integer = txtAdvance.Text
        Dim totalbalance As Integer = txtTotal.Text

        Try
            conn.Open()
            Dim query As String
            query = "insert into checkin (TransactionID, Guest Name, Room Number, Room Type, Room Rate, Checkin Date, Checkout Date, NoofDays, NoofAdults, NoofChildrens, Sub Total, Advance Payment,Total Balance) values ('" & transactionid & "', '" & guestname & "','" & roomnum & "','" & roomtype & "','" & roomrate & "','" & checkin & "','" & checkout & "','" & noofdays & "','" & noofadults & "','" & noofchildrens & "', '" & subtotal & "', '" & advancepay & "', '" & totalbalance & "',) "
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            MessageBox.Show("Checkin Completed")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Dim out_app As String = MsgBox("Cancel Check-in?", vbQuestion + vbYesNo, "Check-In")
        If out_app = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtTransID_TextChanged(sender As Object, e As EventArgs) Handles txtTransID.TextChanged

    End Sub

    Private Sub frmCheckin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class