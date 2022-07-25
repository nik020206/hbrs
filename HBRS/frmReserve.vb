'Imports MySql.Data.MySqlClient

Public Class frmReserve
    Dim trans_id As String
    Dim id, guest_id, room_num As Integer

    Private Sub dtCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtCheckOutDate.ValueChanged
        Dim T As TimeSpan = dtCheckOutDate.Value - dtCheckInDate.Value
        If T.Days < 1 Then
            dtCheckOutDate.Text = dtCheckInDate.Value.Date.AddDays(1D)
            txtDaysNumber.Text = "1"
        Else
            txtDaysNumber.Text = T.Days
        End If
        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        lblDateNow.Text = Now.Date
    End Sub

    Private Sub bttnSearchGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchGuest.Click
        frmSelectGuest.ShowDialog()
    End Sub

    Private Sub bttnSearchRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchRoom.Click
        frmSelectRoom.ShowDialog()
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmReserve_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel")
        If a = vbNo Then
            e.Cancel = True
        Else
            clear_text()
        End If
    End Sub

    Private Sub clear_text()
        txtGuestName.Clear()
        txtRoomNumber.Clear()
        txtRoomType.Clear()
        txtRoomRate.Clear()
        txtChildren.Text = "0"
        txtAdults.Text = "0"
        txtAdvance.Clear()
        txtSubTotal.Clear()
        txtTotal.Clear()
        lblDiscountID.Text = ""
        lblDiscountRate.Text = ""
        lblGuestID.Text = ""
        lblAdvancePayment.Text = ""
        lblNoOfOccupancy.Text = "0"

        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"
        dtCheckInDate.Text = time.ToString(format)
        dtCheckOutDate.Text = Now.AddDays(1D)
    End Sub

    Private Sub frmReserve_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clear_text()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"
        dtCheckInDate.Text = time.ToString(format)
        dtCheckOutDate.Text = dtCheckInDate.Value.Date.AddDays(1D)
        lblDateNow.Text = Now.Date
    End Sub

    Private Sub bttnReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReserve.Click
        Dim children As Integer = Val(txtChildren.Text)
        Dim adult As Integer = Val(txtAdults.Text)
        Dim advance As Integer = Val(txtAdvance.Text)
        Dim discount As Integer = Val(lblDiscountID.Text)
        Dim reserve As String = "0"
        Dim remarks As String = "Reserve"
        Dim stat As String = "Active"

        If lblGuestID.Text = "GuestID" Or lblGuestID.Text = Nothing Or txtRoomNumber.Text = Nothing Or Val(children + adult) = Nothing Or advance = Nothing Or discount = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            Dim a As String = MsgBox("Confirm Reservation Transaction?", vbQuestion + vbYesNo, "Reservation")
            If a = vbYes Then
                children = Val(txtChildren.Text)
                adult = Val(txtAdults.Text)
                advance = Val(txtAdvance.Text)
                discount = Val(lblDiscountID.Text)

                MsgBox("Guest Successfully Reserved!", vbInformation, "Reservation")
                clear_text()
            End If
        End If
    End Sub

    Private Sub dtCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtCheckInDate.ValueChanged
        Dim t As Date = dtCheckInDate.Value
        If t.Date < Now.Date Then
            dtCheckInDate.Value = Now.Date
        Else
            dtCheckOutDate.Value = dtCheckInDate.Value.Date.AddDays(1D)
        End If
    End Sub

    Private Sub bttnAddAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAddAdult.Click
        Dim tao As Integer
        tao = Val(txtAdults.Text) + Val(txtChildren.Text)
        If tao = Val(lblNoOfOccupancy.Text) Then

        Else
            txtAdults.Text = Val(txtAdults.Text) + 1
        End If
    End Sub

    Private Sub bttnAddChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAddChildren.Click
        Dim tao As Integer
        tao = Val(txtAdults.Text) + Val(txtChildren.Text)
        If tao = Val(lblNoOfOccupancy.Text) Then

        Else
            txtChildren.Text = Val(txtChildren.Text) + 1
        End If
    End Sub

    Private Sub bttnSubAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSubAdult.Click
        If Val(txtAdults.Text) = 0 Then
            txtAdults.Text = Val(txtAdults.Text)
        Else
            txtAdults.Text = Val(txtAdults.Text) - 1
        End If
    End Sub

    Private Sub bttnSubChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSubChildren.Click
        If Val(txtChildren.Text) = 0 Then
            txtChildren.Text = Val(txtChildren.Text)
        Else
            txtChildren.Text = Val(txtChildren.Text) - 1
        End If
    End Sub

    Private Sub txtAdvance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdvance.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub txtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvance.TextChanged
        txtTotal.Text = Val(lblTotal.Text) - Val(txtAdvance.Text)
    End Sub

    Private Sub txtRoomRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomRate.TextChanged
        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
    End Sub

    Private Sub bttnCheckin_Click(sender As Object, e As EventArgs) Handles bttnCheckin.Click
        Dim check_in As String = MsgBox("Checkin Guest?", vbQuestion + vbYesNo, "Checkin")
        If check_in = vbYes Then
            MsgBox("Guest Checkedin", vbInformation, "Checkin")
        End If
    End Sub



    Private Sub bttnCancelReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancelReserve.Click
        Dim check_in As String = MsgBox("Cancel Reservation?", vbQuestion + vbYesNo, "Cancel")
        If check_in = vbYes Then
            MsgBox("Reservation Cancelled!", vbInformation, "Cancel")
        End If
    End Sub

End Class