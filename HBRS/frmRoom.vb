Imports MySql.Data.MySqlClient

Public Class frmRoom
    Dim conn As New MySqlConnection
    Dim comm As MySqlCommand
    Dim id As Integer

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        RoomNum.Clear()
        txtRoomType.Clear()
        txtRoomRate.Clear()
        txtNoOfOccupancy.Clear()
        bttnSave.Text = "&Save"
        Dim out_app As String = MsgBox("Do you want to exit?", vbQuestion + vbYesNo, "Room")
        If out_app = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=hbrs_db;port=3306;"
        Dim reader As MySqlDataReader

        Dim Rid As String = TxtRoomID.Text
        Dim Rn As Integer = RoomNum.Text
        Dim Rt As String = txtRoomType.Text
        Dim Rr As Integer = txtRoomRate.Text
        Dim Rc As Integer = txtNoOfOccupancy.Text


        Try
            conn.Open()
            Dim query As String
            query = "insert into room (Room ID,Room Number, Room Type, Room Rate, Room Capacity) values ('" & Rid & "', '" & Rn & "','" & Rt & "','" & Rr & "','" & Rc & "') "
            comm = New MySqlCommand(query, conn)
            reader = comm.ExecuteReader
            MessageBox.Show("Room Added Successfully")
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Dim num As String = Trim(RoomNum.Text)
        Dim type As String = Trim(txtRoomType.Text)
        Dim rate As String = Trim(txtRoomRate.Text)
        Dim occupancy As String = Trim(txtNoOfOccupancy.Text)
        Dim stat As String = "Available"
        If type = Nothing Or rate = Nothing Or occupancy = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            If bttnSave.Text = "&Save" Then
                num = Trim(RoomNum.Text)
                type = Trim(txtRoomType.Text)
                rate = Trim(txtRoomRate.Text)
                occupancy = Trim(txtNoOfOccupancy.Text)
                stat = "Available"
            Else
                MsgBox("Room Already Existed", vbExclamation, "Note")
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class