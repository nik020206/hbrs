﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserve
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReserve))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtCheckInDate = New System.Windows.Forms.DateTimePicker()
        Me.lblAdvancePayment = New System.Windows.Forms.Label()
        Me.bttnAddChildren = New System.Windows.Forms.Button()
        Me.bttnAddAdult = New System.Windows.Forms.Button()
        Me.bttnSubChildren = New System.Windows.Forms.Button()
        Me.bttnSubAdult = New System.Windows.Forms.Button()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.bttnSearchRoom = New System.Windows.Forms.Button()
        Me.bttnSearchGuest = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnReserve = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDaysNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtCheckOutDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bttnCheckin = New System.Windows.Forms.Button()
        Me.bttnCancelReserve = New System.Windows.Forms.Button()
        Me.dtOut = New System.Windows.Forms.DateTimePicker()
        Me.dtIn = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscountRate = New System.Windows.Forms.Label()
        Me.lblDiscountID = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.lblNoOfOccupancy = New System.Windows.Forms.Label()
        Me.lblDateNow = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(995, 490)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage1.Controls.Add(Me.dtCheckInDate)
        Me.TabPage1.Controls.Add(Me.lblAdvancePayment)
        Me.TabPage1.Controls.Add(Me.bttnAddChildren)
        Me.TabPage1.Controls.Add(Me.bttnAddAdult)
        Me.TabPage1.Controls.Add(Me.bttnSubChildren)
        Me.TabPage1.Controls.Add(Me.bttnSubAdult)
        Me.TabPage1.Controls.Add(Me.txtAdults)
        Me.TabPage1.Controls.Add(Me.txtChildren)
        Me.TabPage1.Controls.Add(Me.bttnSearchRoom)
        Me.TabPage1.Controls.Add(Me.bttnSearchGuest)
        Me.TabPage1.Controls.Add(Me.bttnCancel)
        Me.TabPage1.Controls.Add(Me.bttnReserve)
        Me.TabPage1.Controls.Add(Me.txtTotal)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtAdvance)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtSubTotal)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtDaysNumber)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.dtCheckOutDate)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtRoomRate)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtRoomType)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtRoomNumber)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtGuestName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTransID)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ShapeContainer1)
        Me.TabPage1.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(987, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reservation Form"
        '
        'dtCheckInDate
        '
        Me.dtCheckInDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckInDate.Location = New System.Drawing.Point(212, 267)
        Me.dtCheckInDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtCheckInDate.Name = "dtCheckInDate"
        Me.dtCheckInDate.Size = New System.Drawing.Size(152, 26)
        Me.dtCheckInDate.TabIndex = 75
        '
        'lblAdvancePayment
        '
        Me.lblAdvancePayment.AutoSize = True
        Me.lblAdvancePayment.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvancePayment.ForeColor = System.Drawing.Color.Red
        Me.lblAdvancePayment.Location = New System.Drawing.Point(649, 271)
        Me.lblAdvancePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdvancePayment.Name = "lblAdvancePayment"
        Me.lblAdvancePayment.Size = New System.Drawing.Size(0, 28)
        Me.lblAdvancePayment.TabIndex = 74
        Me.lblAdvancePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bttnAddChildren
        '
        Me.bttnAddChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddChildren.Location = New System.Drawing.Point(888, 150)
        Me.bttnAddChildren.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnAddChildren.Name = "bttnAddChildren"
        Me.bttnAddChildren.Size = New System.Drawing.Size(31, 31)
        Me.bttnAddChildren.TabIndex = 73
        Me.bttnAddChildren.Text = ">"
        Me.bttnAddChildren.UseVisualStyleBackColor = True
        '
        'bttnAddAdult
        '
        Me.bttnAddAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddAdult.Location = New System.Drawing.Point(888, 113)
        Me.bttnAddAdult.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnAddAdult.Name = "bttnAddAdult"
        Me.bttnAddAdult.Size = New System.Drawing.Size(31, 31)
        Me.bttnAddAdult.TabIndex = 72
        Me.bttnAddAdult.Text = ">"
        Me.bttnAddAdult.UseVisualStyleBackColor = True
        '
        'bttnSubChildren
        '
        Me.bttnSubChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubChildren.Location = New System.Drawing.Point(858, 149)
        Me.bttnSubChildren.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnSubChildren.Name = "bttnSubChildren"
        Me.bttnSubChildren.Size = New System.Drawing.Size(31, 31)
        Me.bttnSubChildren.TabIndex = 71
        Me.bttnSubChildren.Text = "<"
        Me.bttnSubChildren.UseVisualStyleBackColor = True
        '
        'bttnSubAdult
        '
        Me.bttnSubAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubAdult.Location = New System.Drawing.Point(858, 112)
        Me.bttnSubAdult.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnSubAdult.Name = "bttnSubAdult"
        Me.bttnSubAdult.Size = New System.Drawing.Size(31, 31)
        Me.bttnSubAdult.TabIndex = 70
        Me.bttnSubAdult.Text = "<"
        Me.bttnSubAdult.UseVisualStyleBackColor = True
        '
        'txtAdults
        '
        Me.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdults.Location = New System.Drawing.Point(778, 113)
        Me.txtAdults.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdults.Multiline = True
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.ReadOnly = True
        Me.txtAdults.Size = New System.Drawing.Size(67, 30)
        Me.txtAdults.TabIndex = 69
        Me.txtAdults.Text = "0"
        Me.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChildren
        '
        Me.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildren.Location = New System.Drawing.Point(778, 151)
        Me.txtChildren.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChildren.Multiline = True
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.ReadOnly = True
        Me.txtChildren.Size = New System.Drawing.Size(67, 30)
        Me.txtChildren.TabIndex = 68
        Me.txtChildren.Text = "0"
        Me.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnSearchRoom
        '
        Me.bttnSearchRoom.Location = New System.Drawing.Point(373, 151)
        Me.bttnSearchRoom.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnSearchRoom.Name = "bttnSearchRoom"
        Me.bttnSearchRoom.Size = New System.Drawing.Size(40, 32)
        Me.bttnSearchRoom.TabIndex = 67
        Me.bttnSearchRoom.Text = "..."
        Me.bttnSearchRoom.UseVisualStyleBackColor = True
        '
        'bttnSearchGuest
        '
        Me.bttnSearchGuest.Location = New System.Drawing.Point(500, 112)
        Me.bttnSearchGuest.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnSearchGuest.Name = "bttnSearchGuest"
        Me.bttnSearchGuest.Size = New System.Drawing.Size(40, 32)
        Me.bttnSearchGuest.TabIndex = 66
        Me.bttnSearchGuest.Text = "..."
        Me.bttnSearchGuest.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(785, 383)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(151, 43)
        Me.bttnCancel.TabIndex = 65
        Me.bttnCancel.Text = "C&ancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnReserve
        '
        Me.bttnReserve.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnReserve.Location = New System.Drawing.Point(625, 383)
        Me.bttnReserve.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnReserve.Name = "bttnReserve"
        Me.bttnReserve.Size = New System.Drawing.Size(151, 43)
        Me.bttnReserve.TabIndex = 64
        Me.bttnReserve.Text = "&Reserve"
        Me.bttnReserve.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(777, 275)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(159, 30)
        Me.txtTotal.TabIndex = 53
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(600, 272)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 28)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Total"
        '
        'txtAdvance
        '
        Me.txtAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvance.Location = New System.Drawing.Point(777, 236)
        Me.txtAdvance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdvance.Multiline = True
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(159, 30)
        Me.txtAdvance.TabIndex = 52
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(600, 235)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 28)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Advance Payment"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(599, 149)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 28)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "No. Of Children"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(777, 197)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(159, 30)
        Me.txtSubTotal.TabIndex = 49
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(600, 196)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 28)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Sub Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(599, 112)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 28)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "No. Of Adults"
        '
        'txtDaysNumber
        '
        Me.txtDaysNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDaysNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysNumber.Location = New System.Drawing.Point(212, 337)
        Me.txtDaysNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDaysNumber.Multiline = True
        Me.txtDaysNumber.Name = "txtDaysNumber"
        Me.txtDaysNumber.ReadOnly = True
        Me.txtDaysNumber.Size = New System.Drawing.Size(152, 30)
        Me.txtDaysNumber.TabIndex = 44
        Me.txtDaysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 342)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 28)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "No. Of Days"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 270)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 28)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Check In Date"
        '
        'dtCheckOutDate
        '
        Me.dtCheckOutDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckOutDate.Location = New System.Drawing.Point(212, 303)
        Me.dtCheckOutDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtCheckOutDate.Name = "dtCheckOutDate"
        Me.dtCheckOutDate.Size = New System.Drawing.Size(152, 26)
        Me.dtCheckOutDate.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 305)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 28)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Check Out Date"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomRate.Location = New System.Drawing.Point(212, 228)
        Me.txtRoomRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomRate.Multiline = True
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.ReadOnly = True
        Me.txtRoomRate.Size = New System.Drawing.Size(152, 30)
        Me.txtRoomRate.TabIndex = 42
        Me.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 28)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Room Rate"
        '
        'txtRoomType
        '
        Me.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.Location = New System.Drawing.Point(212, 190)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomType.Multiline = True
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(152, 30)
        Me.txtRoomType.TabIndex = 40
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 28)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Room Type"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(212, 151)
        Me.txtRoomNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomNumber.Multiline = True
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(152, 30)
        Me.txtRoomNumber.TabIndex = 38
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 28)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Room Number"
        '
        'txtGuestName
        '
        Me.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.Location = New System.Drawing.Point(212, 113)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuestName.Multiline = True
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(279, 30)
        Me.txtGuestName.TabIndex = 35
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 28)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Guest Name"
        '
        'txtTransID
        '
        Me.txtTransID.BackColor = System.Drawing.Color.White
        Me.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransID.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTransID.Location = New System.Drawing.Point(212, 75)
        Me.txtTransID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransID.Multiline = True
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(153, 31)
        Me.txtTransID.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 28)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Transaction ID"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 39)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Reservation Form"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(4, 4)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(979, 453)
        Me.ShapeContainer1.TabIndex = 76
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.MenuText
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 11
        Me.LineShape1.X2 = 715
        Me.LineShape1.Y1 = 47
        Me.LineShape1.Y2 = 47
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.bttnCheckin)
        Me.TabPage2.Controls.Add(Me.bttnCancelReserve)
        Me.TabPage2.Controls.Add(Me.dtOut)
        Me.TabPage2.Controls.Add(Me.dtIn)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reservation List"
        '
        'bttnCheckin
        '
        Me.bttnCheckin.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCheckin.Location = New System.Drawing.Point(657, 407)
        Me.bttnCheckin.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnCheckin.Name = "bttnCheckin"
        Me.bttnCheckin.Size = New System.Drawing.Size(125, 37)
        Me.bttnCheckin.TabIndex = 41
        Me.bttnCheckin.Text = "&Checkin"
        Me.bttnCheckin.UseVisualStyleBackColor = True
        '
        'bttnCancelReserve
        '
        Me.bttnCancelReserve.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancelReserve.Location = New System.Drawing.Point(791, 406)
        Me.bttnCancelReserve.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnCancelReserve.Name = "bttnCancelReserve"
        Me.bttnCancelReserve.Size = New System.Drawing.Size(173, 37)
        Me.bttnCancelReserve.TabIndex = 40
        Me.bttnCancelReserve.Text = "Cancel &Reservation"
        Me.bttnCancelReserve.UseVisualStyleBackColor = True
        '
        'dtOut
        '
        Me.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOut.Location = New System.Drawing.Point(825, 30)
        Me.dtOut.Margin = New System.Windows.Forms.Padding(4)
        Me.dtOut.Name = "dtOut"
        Me.dtOut.Size = New System.Drawing.Size(137, 22)
        Me.dtOut.TabIndex = 39
        Me.dtOut.Visible = False
        '
        'dtIn
        '
        Me.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIn.Location = New System.Drawing.Point(692, 30)
        Me.dtIn.Margin = New System.Windows.Forms.Padding(4)
        Me.dtIn.Name = "dtIn"
        Me.dtIn.Size = New System.Drawing.Size(124, 22)
        Me.dtIn.TabIndex = 38
        Me.dtIn.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoEllipsis = True
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 19)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(221, 39)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Reservation List"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(209, 567)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 17)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total"
        Me.lblTotal.Visible = False
        '
        'lblDiscountRate
        '
        Me.lblDiscountRate.AutoSize = True
        Me.lblDiscountRate.Location = New System.Drawing.Point(200, 539)
        Me.lblDiscountRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscountRate.Name = "lblDiscountRate"
        Me.lblDiscountRate.Size = New System.Drawing.Size(93, 17)
        Me.lblDiscountRate.TabIndex = 9
        Me.lblDiscountRate.Text = "DiscountRate"
        Me.lblDiscountRate.Visible = False
        '
        'lblDiscountID
        '
        Me.lblDiscountID.AutoSize = True
        Me.lblDiscountID.Location = New System.Drawing.Point(15, 596)
        Me.lblDiscountID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscountID.Name = "lblDiscountID"
        Me.lblDiscountID.Size = New System.Drawing.Size(76, 17)
        Me.lblDiscountID.TabIndex = 8
        Me.lblDiscountID.Text = "DiscountID"
        Me.lblDiscountID.Visible = False
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(15, 539)
        Me.lblGuestID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(59, 17)
        Me.lblGuestID.TabIndex = 7
        Me.lblGuestID.Text = "GuestID"
        Me.lblGuestID.Visible = False
        '
        'lblNoOfOccupancy
        '
        Me.lblNoOfOccupancy.AutoSize = True
        Me.lblNoOfOccupancy.Location = New System.Drawing.Point(15, 566)
        Me.lblNoOfOccupancy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoOfOccupancy.Name = "lblNoOfOccupancy"
        Me.lblNoOfOccupancy.Size = New System.Drawing.Size(112, 17)
        Me.lblNoOfOccupancy.TabIndex = 6
        Me.lblNoOfOccupancy.Text = "NoOfOccupancy"
        Me.lblNoOfOccupancy.Visible = False
        '
        'lblDateNow
        '
        Me.lblDateNow.AutoSize = True
        Me.lblDateNow.Location = New System.Drawing.Point(207, 597)
        Me.lblDateNow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateNow.Name = "lblDateNow"
        Me.lblDateNow.Size = New System.Drawing.Size(63, 17)
        Me.lblDateNow.TabIndex = 11
        Me.lblDateNow.Text = "dateNow"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(942, 329)
        Me.DataGridView1.TabIndex = 42
        '
        'frmReserve
        '
        Me.AcceptButton = Me.bttnReserve
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1023, 528)
        Me.Controls.Add(Me.lblDateNow)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscountRate)
        Me.Controls.Add(Me.lblDiscountID)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.lblNoOfOccupancy)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblAdvancePayment As System.Windows.Forms.Label
    Friend WithEvents bttnAddChildren As System.Windows.Forms.Button
    Friend WithEvents bttnAddAdult As System.Windows.Forms.Button
    Friend WithEvents bttnSubChildren As System.Windows.Forms.Button
    Friend WithEvents bttnSubAdult As System.Windows.Forms.Button
    Friend WithEvents txtAdults As System.Windows.Forms.TextBox
    Friend WithEvents txtChildren As System.Windows.Forms.TextBox
    Friend WithEvents bttnSearchRoom As System.Windows.Forms.Button
    Friend WithEvents bttnSearchGuest As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnReserve As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDaysNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtCheckOutDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRoomRate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTransID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dtOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtCheckInDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscountRate As System.Windows.Forms.Label
    Friend WithEvents lblDiscountID As System.Windows.Forms.Label
    Friend WithEvents lblGuestID As System.Windows.Forms.Label
    Friend WithEvents lblNoOfOccupancy As System.Windows.Forms.Label
    Friend WithEvents bttnCheckin As System.Windows.Forms.Button
    Friend WithEvents bttnCancelReserve As System.Windows.Forms.Button
    Friend WithEvents lblDateNow As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridView1 As DataGridView
End Class
