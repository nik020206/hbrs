Imports MySql.Data.MySqlClient
Public Class frmCheckout
    Dim conn As New MySqlConnection
    Dim comm As MySqlCommand

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        If Val(txtCash.Text) < Val(txtTotal.Text) Then
            txtChange.Text = "0.00"
        Else
            txtChange.Text = (Val(txtCash.Text) - Val(txtTotal.Text)).ToString("N")
        End If
    End Sub

    Private Sub bttnCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckout.Click
        conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=hbrs_db;port=3306;"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "insert into checkout (TransactionID, Guest Name, Room Number, Room Type, Room Rate, Checkin Date, Checkout Date, NoofDays, NoofChildrens, NoofAdults, Sub Total, Advance Payment,Total Balance) values('" & txtTransID.Text & "', '" & txtGuestName.Text & "','" & txtRoomNumber.Text & "','" & txtRoomType.Text & "','" & txtRoomRate.Text & "','" & dtCheckInDate.Text & "','" & dtCheckOutDate.Text & "','" & txtDays.Text & "','" & txtChildren.Text & "','" & txtAdult.Text & "', '" & txtSubTotal.Text & "', '" & txtAdvance.Text & "', '" & txtTotal.Text & "',) "
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            MessageBox.Show("Checkout Completed")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        If txtTransID.Text = Nothing Then
            MsgBox("Please select transaction to checkout!", vbExclamation, "Note")
        Else
            If Val(txtCash.Text) < Val(txtTotal.Text) Then
                MsgBox("Insufficient cash!", vbExclamation, "Note")
            Else
                Dim out As String = MsgBox("Confirm Checkout", vbQuestion + vbYesNo, "Checkout")
                If out = vbYes Then
                    MsgBox("Guest Checked out!", vbInformation, "Checkout")
                    clear_text()
                End If
            End If
        End If
    End Sub

    Public Sub clear_text()
        txtTransID.Clear()
        txtGuestName.Clear()
        txtRoomNumber.Clear()
        txtRoomRate.Clear()
        txtRoomType.Clear()
        dtCheckInDate.Dispose()
        dtCheckOutDate.Dispose()
        txtChildren.Clear()
        txtAdult.Clear()
        txtAdvance.Clear()
        txtTotal.Clear()
        txtSubTotal.Clear()
        txtDays.Clear()
        txtCash.Clear()
        txtChange.Clear()
    End Sub

    Private Sub frmCheckout_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_text()
    End Sub

    Private Sub frmCheckout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRoomNumber.Clear()
        dtIn.Value = Date.Now
        dtOut.Value = Date.Now
    End Sub

End Class