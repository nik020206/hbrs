<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.txtemployeeid = New System.Windows.Forms.TextBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 509)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage1.Controls.Add(Me.bttnCancel)
        Me.TabPage1.Controls.Add(Me.bttnDelete)
        Me.TabPage1.Controls.Add(Me.bttnUpdate)
        Me.TabPage1.Controls.Add(Me.bttnSave)
        Me.TabPage1.Controls.Add(Me.txtemployeeid)
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
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1004, 480)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Form"
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(855, 421)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(133, 38)
        Me.bttnCancel.TabIndex = 75
        Me.bttnCancel.Text = "&Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(714, 421)
        Me.bttnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(133, 38)
        Me.bttnDelete.TabIndex = 74
        Me.bttnDelete.Text = "&Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnUpdate
        '
        Me.bttnUpdate.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUpdate.Location = New System.Drawing.Point(571, 421)
        Me.bttnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(133, 38)
        Me.bttnUpdate.TabIndex = 73
        Me.bttnUpdate.Text = "&Update"
        Me.bttnUpdate.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSave.Location = New System.Drawing.Point(430, 421)
        Me.bttnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(133, 38)
        Me.bttnSave.TabIndex = 72
        Me.bttnSave.Text = "&Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'txtemployeeid
        '
        Me.txtemployeeid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployeeid.Location = New System.Drawing.Point(174, 85)
        Me.txtemployeeid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemployeeid.Multiline = True
        Me.txtemployeeid.Name = "txtemployeeid"
        Me.txtemployeeid.Size = New System.Drawing.Size(216, 30)
        Me.txtemployeeid.TabIndex = 71
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(174, 350)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(216, 30)
        Me.txtEmail.TabIndex = 69
        '
        'labEmailAdd
        '
        Me.labEmailAdd.AutoSize = True
        Me.labEmailAdd.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmailAdd.Location = New System.Drawing.Point(19, 350)
        Me.labEmailAdd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEmailAdd.Name = "labEmailAdd"
        Me.labEmailAdd.Size = New System.Drawing.Size(130, 28)
        Me.labEmailAdd.TabIndex = 70
        Me.labEmailAdd.Text = "Email Address"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(174, 316)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(216, 24)
        Me.cboGender.TabIndex = 68
        '
        'labGender
        '
        Me.labGender.AutoSize = True
        Me.labGender.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labGender.Location = New System.Drawing.Point(19, 311)
        Me.labGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labGender.Name = "labGender"
        Me.labGender.Size = New System.Drawing.Size(72, 28)
        Me.labGender.TabIndex = 67
        Me.labGender.Text = "Gender"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(174, 276)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber.Multiline = True
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(216, 30)
        Me.txtNumber.TabIndex = 65
        '
        'labContactNumber
        '
        Me.labContactNumber.AutoSize = True
        Me.labContactNumber.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labContactNumber.Location = New System.Drawing.Point(19, 276)
        Me.labContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labContactNumber.Name = "labContactNumber"
        Me.labContactNumber.Size = New System.Drawing.Size(150, 28)
        Me.labContactNumber.TabIndex = 66
        Me.labContactNumber.Text = "Contact Number"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(174, 238)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(216, 30)
        Me.txtAddress.TabIndex = 63
        '
        'LabAddress
        '
        Me.LabAddress.AutoSize = True
        Me.LabAddress.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAddress.Location = New System.Drawing.Point(19, 238)
        Me.LabAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabAddress.Name = "LabAddress"
        Me.LabAddress.Size = New System.Drawing.Size(77, 28)
        Me.LabAddress.TabIndex = 64
        Me.LabAddress.Text = "Address"
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(174, 161)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMName.Multiline = True
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(216, 30)
        Me.txtMName.TabIndex = 61
        '
        'LabMiddleName
        '
        Me.LabMiddleName.AutoSize = True
        Me.LabMiddleName.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMiddleName.Location = New System.Drawing.Point(19, 161)
        Me.LabMiddleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMiddleName.Name = "LabMiddleName"
        Me.LabMiddleName.Size = New System.Drawing.Size(122, 28)
        Me.LabMiddleName.TabIndex = 62
        Me.LabMiddleName.Text = "Middle Name"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(174, 200)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.Multiline = True
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(216, 30)
        Me.txtLName.TabIndex = 59
        '
        'LabLastName
        '
        Me.LabLastName.AutoSize = True
        Me.LabLastName.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLastName.Location = New System.Drawing.Point(19, 201)
        Me.LabLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLastName.Name = "LabLastName"
        Me.LabLastName.Size = New System.Drawing.Size(101, 28)
        Me.LabLastName.TabIndex = 60
        Me.LabLastName.Text = "Last Name"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(174, 123)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.Multiline = True
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(216, 30)
        Me.txtFName.TabIndex = 57
        '
        'labFirstName
        '
        Me.labFirstName.AutoSize = True
        Me.labFirstName.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFirstName.Location = New System.Drawing.Point(19, 124)
        Me.labFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labFirstName.Name = "labFirstName"
        Me.labFirstName.Size = New System.Drawing.Size(105, 28)
        Me.labFirstName.TabIndex = 58
        Me.labFirstName.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Subheading", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 28)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Employee ID"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 35)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Employee Form"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1004, 480)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Employee List"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(990, 468)
        Me.DataGridView1.TabIndex = 0
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmEmployee"
        Me.Text = "frmEmployee"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtemployeeid As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents labEmailAdd As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents labGender As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents labContactNumber As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents LabAddress As Label
    Friend WithEvents txtMName As TextBox
    Friend WithEvents LabMiddleName As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents LabLastName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents labFirstName As Label
    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnUpdate As Button
    Friend WithEvents bttnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
