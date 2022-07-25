<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuest
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.labGuestID = New System.Windows.Forms.Label()
        Me.txtGuestID = New System.Windows.Forms.TextBox()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.labEmailAdd = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.labGender = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.labContactNumber = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.LabAddress = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.LabMiddleName = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.LabLastName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.labFirstName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgGuestlist = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgGuestlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 16)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(905, 469)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage1.Controls.Add(Me.labGuestID)
        Me.TabPage1.Controls.Add(Me.txtGuestID)
        Me.TabPage1.Controls.Add(Me.bttnCancel)
        Me.TabPage1.Controls.Add(Me.bttnSave)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.labEmailAdd)
        Me.TabPage1.Controls.Add(Me.cboGender)
        Me.TabPage1.Controls.Add(Me.labGender)
        Me.TabPage1.Controls.Add(Me.txtNumber)
        Me.TabPage1.Controls.Add(Me.labContactNumber)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.LabAddress)
        Me.TabPage1.Controls.Add(Me.txtMName)
        Me.TabPage1.Controls.Add(Me.LabMiddleName)
        Me.TabPage1.Controls.Add(Me.txtLName)
        Me.TabPage1.Controls.Add(Me.LabLastName)
        Me.TabPage1.Controls.Add(Me.txtFName)
        Me.TabPage1.Controls.Add(Me.labFirstName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(897, 440)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Guest"
        '
        'labGuestID
        '
        Me.labGuestID.AutoSize = True
        Me.labGuestID.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labGuestID.Location = New System.Drawing.Point(53, 84)
        Me.labGuestID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labGuestID.Name = "labGuestID"
        Me.labGuestID.Size = New System.Drawing.Size(84, 28)
        Me.labGuestID.TabIndex = 61
        Me.labGuestID.Text = "Guest ID"
        '
        'txtGuestID
        '
        Me.txtGuestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestID.Location = New System.Drawing.Point(209, 82)
        Me.txtGuestID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuestID.Multiline = True
        Me.txtGuestID.Name = "txtGuestID"
        Me.txtGuestID.Size = New System.Drawing.Size(216, 30)
        Me.txtGuestID.TabIndex = 60
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(725, 370)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(133, 38)
        Me.bttnCancel.TabIndex = 59
        Me.bttnCancel.Text = "&Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSave.Location = New System.Drawing.Point(584, 370)
        Me.bttnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(133, 38)
        Me.bttnSave.TabIndex = 58
        Me.bttnSave.Text = "&Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 39)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "New Guest Form"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(209, 347)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(216, 30)
        Me.txtEmail.TabIndex = 55
        '
        'labEmailAdd
        '
        Me.labEmailAdd.AutoSize = True
        Me.labEmailAdd.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmailAdd.Location = New System.Drawing.Point(53, 354)
        Me.labEmailAdd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEmailAdd.Name = "labEmailAdd"
        Me.labEmailAdd.Size = New System.Drawing.Size(130, 28)
        Me.labEmailAdd.TabIndex = 56
        Me.labEmailAdd.Text = "Email Address"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(209, 313)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(216, 24)
        Me.cboGender.TabIndex = 54
        '
        'labGender
        '
        Me.labGender.AutoSize = True
        Me.labGender.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labGender.Location = New System.Drawing.Point(53, 315)
        Me.labGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labGender.Name = "labGender"
        Me.labGender.Size = New System.Drawing.Size(72, 28)
        Me.labGender.TabIndex = 53
        Me.labGender.Text = "Gender"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(209, 273)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber.Multiline = True
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(216, 30)
        Me.txtNumber.TabIndex = 50
        '
        'labContactNumber
        '
        Me.labContactNumber.AutoSize = True
        Me.labContactNumber.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labContactNumber.Location = New System.Drawing.Point(53, 280)
        Me.labContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labContactNumber.Name = "labContactNumber"
        Me.labContactNumber.Size = New System.Drawing.Size(150, 28)
        Me.labContactNumber.TabIndex = 51
        Me.labContactNumber.Text = "Contact Number"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(209, 235)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(216, 30)
        Me.txtAddress.TabIndex = 48
        '
        'LabAddress
        '
        Me.LabAddress.AutoSize = True
        Me.LabAddress.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAddress.Location = New System.Drawing.Point(53, 242)
        Me.LabAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabAddress.Name = "LabAddress"
        Me.LabAddress.Size = New System.Drawing.Size(77, 28)
        Me.LabAddress.TabIndex = 49
        Me.LabAddress.Text = "Address"
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(209, 158)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMName.Multiline = True
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(216, 30)
        Me.txtMName.TabIndex = 46
        '
        'LabMiddleName
        '
        Me.LabMiddleName.AutoSize = True
        Me.LabMiddleName.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMiddleName.Location = New System.Drawing.Point(53, 165)
        Me.LabMiddleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMiddleName.Name = "LabMiddleName"
        Me.LabMiddleName.Size = New System.Drawing.Size(122, 28)
        Me.LabMiddleName.TabIndex = 47
        Me.LabMiddleName.Text = "Middle Name"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(209, 197)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.Multiline = True
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(216, 30)
        Me.txtLName.TabIndex = 44
        '
        'LabLastName
        '
        Me.LabLastName.AutoSize = True
        Me.LabLastName.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLastName.Location = New System.Drawing.Point(53, 205)
        Me.LabLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLastName.Name = "LabLastName"
        Me.LabLastName.Size = New System.Drawing.Size(101, 28)
        Me.LabLastName.TabIndex = 45
        Me.LabLastName.Text = "Last Name"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(209, 120)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.Multiline = True
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(216, 30)
        Me.txtFName.TabIndex = 42
        '
        'labFirstName
        '
        Me.labFirstName.AutoSize = True
        Me.labFirstName.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFirstName.Location = New System.Drawing.Point(53, 128)
        Me.labFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labFirstName.Name = "labFirstName"
        Me.labFirstName.Size = New System.Drawing.Size(105, 28)
        Me.labFirstName.TabIndex = 43
        Me.labFirstName.Text = "First Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage2.Controls.Add(Me.DgGuestlist)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(897, 440)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guest List"
        '
        'DgGuestlist
        '
        Me.DgGuestlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgGuestlist.Location = New System.Drawing.Point(34, 90)
        Me.DgGuestlist.Name = "DgGuestlist"
        Me.DgGuestlist.RowHeadersWidth = 51
        Me.DgGuestlist.RowTemplate.Height = 24
        Me.DgGuestlist.Size = New System.Drawing.Size(835, 308)
        Me.DgGuestlist.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 39)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Guest List"
        '
        'frmGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(937, 502)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgGuestlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents LabLastName As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents labFirstName As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents LabMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents labEmailAdd As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents labGender As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents labContactNumber As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents LabAddress As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents labGuestID As Label
    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents DgGuestlist As DataGridView
End Class
