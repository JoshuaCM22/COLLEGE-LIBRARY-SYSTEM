<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StudentProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StudentProfile))
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.groupboxButtons = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.cmbboxStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbboxCourse = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbboxYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblStudentNo = New System.Windows.Forms.Label()
        Me.groupboxButtons.SuspendLayout()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(359, 82)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(163, 22)
        Me.dtpDateOfBirth.TabIndex = 159
        Me.dtpDateOfBirth.Value = New Date(2021, 1, 13, 0, 0, 0, 0)
        '
        'groupboxButtons
        '
        Me.groupboxButtons.BackColor = System.Drawing.Color.Transparent
        Me.groupboxButtons.Controls.Add(Me.btnDelete)
        Me.groupboxButtons.Controls.Add(Me.btnEdit)
        Me.groupboxButtons.Controls.Add(Me.btnUpdate)
        Me.groupboxButtons.ForeColor = System.Drawing.Color.Black
        Me.groupboxButtons.Location = New System.Drawing.Point(336, 387)
        Me.groupboxButtons.Name = "groupboxButtons"
        Me.groupboxButtons.Size = New System.Drawing.Size(344, 69)
        Me.groupboxButtons.TabIndex = 157
        Me.groupboxButtons.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(229, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 33)
        Me.btnDelete.TabIndex = 145
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(19, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 33)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(125, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 33)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(879, 27)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(148, 33)
        Me.btnClose.TabIndex = 146
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(389, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(237, 29)
        Me.lblTitle.TabIndex = 158
        Me.lblTitle.Text = "STUDENT PROFILE"
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.Color.Transparent
        Me.groupbox.Controls.Add(Me.cmbboxStatus)
        Me.groupbox.Controls.Add(Me.dtpDateOfBirth)
        Me.groupbox.Controls.Add(Me.lblStatus)
        Me.groupbox.Controls.Add(Me.cmbboxCourse)
        Me.groupbox.Controls.Add(Me.lblCourse)
        Me.groupbox.Controls.Add(Me.cmbboxYearLevel)
        Me.groupbox.Controls.Add(Me.lblYearLevel)
        Me.groupbox.Controls.Add(Me.txtContactNumber)
        Me.groupbox.Controls.Add(Me.lblContactNumber)
        Me.groupbox.Controls.Add(Me.lblAge)
        Me.groupbox.Controls.Add(Me.lblDateOfBirth)
        Me.groupbox.Controls.Add(Me.txtAge)
        Me.groupbox.Controls.Add(Me.lblFemale)
        Me.groupbox.Controls.Add(Me.lblMale)
        Me.groupbox.Controls.Add(Me.rbtnFemale)
        Me.groupbox.Controls.Add(Me.rbtnMale)
        Me.groupbox.Controls.Add(Me.txtAddress)
        Me.groupbox.Controls.Add(Me.txtStudentNo)
        Me.groupbox.Controls.Add(Me.txtFullName)
        Me.groupbox.Controls.Add(Me.lblFullName)
        Me.groupbox.Controls.Add(Me.lblAddress)
        Me.groupbox.Controls.Add(Me.lblGender)
        Me.groupbox.Controls.Add(Me.lblStudentNo)
        Me.groupbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox.ForeColor = System.Drawing.Color.Black
        Me.groupbox.Location = New System.Drawing.Point(35, 88)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(946, 276)
        Me.groupbox.TabIndex = 160
        Me.groupbox.TabStop = False
        '
        'cmbboxStatus
        '
        Me.cmbboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxStatus.FormattingEnabled = True
        Me.cmbboxStatus.Items.AddRange(New Object() {"", "Allowed", "Not Allowed"})
        Me.cmbboxStatus.Location = New System.Drawing.Point(620, 214)
        Me.cmbboxStatus.MaxLength = 9
        Me.cmbboxStatus.Name = "cmbboxStatus"
        Me.cmbboxStatus.Size = New System.Drawing.Size(160, 28)
        Me.cmbboxStatus.TabIndex = 13
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(555, 217)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(50, 20)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status"
        '
        'cmbboxCourse
        '
        Me.cmbboxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxCourse.FormattingEnabled = True
        Me.cmbboxCourse.Location = New System.Drawing.Point(362, 214)
        Me.cmbboxCourse.MaxLength = 9
        Me.cmbboxCourse.Name = "cmbboxCourse"
        Me.cmbboxCourse.Size = New System.Drawing.Size(171, 28)
        Me.cmbboxCourse.TabIndex = 12
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.Black
        Me.lblCourse.Location = New System.Drawing.Point(297, 217)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(56, 20)
        Me.lblCourse.TabIndex = 0
        Me.lblCourse.Text = "Course"
        '
        'cmbboxYearLevel
        '
        Me.cmbboxYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxYearLevel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxYearLevel.FormattingEnabled = True
        Me.cmbboxYearLevel.Items.AddRange(New Object() {"", "1st", "2nd", "3rd", "4th", "5th"})
        Me.cmbboxYearLevel.Location = New System.Drawing.Point(116, 211)
        Me.cmbboxYearLevel.MaxLength = 9
        Me.cmbboxYearLevel.Name = "cmbboxYearLevel"
        Me.cmbboxYearLevel.Size = New System.Drawing.Size(156, 28)
        Me.cmbboxYearLevel.TabIndex = 11
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevel.ForeColor = System.Drawing.Color.Black
        Me.lblYearLevel.Location = New System.Drawing.Point(32, 214)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(78, 20)
        Me.lblYearLevel.TabIndex = 0
        Me.lblYearLevel.Text = "Year Level"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.White
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(155, 166)
        Me.txtContactNumber.MaxLength = 50
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(409, 27)
        Me.txtContactNumber.TabIndex = 10
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.Black
        Me.lblContactNumber.Location = New System.Drawing.Point(29, 170)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(122, 20)
        Me.lblContactNumber.TabIndex = 0
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(534, 82)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 20)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfBirth.Location = New System.Drawing.Point(258, 82)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(96, 20)
        Me.lblDateOfBirth.TabIndex = 0
        Me.lblDateOfBirth.Text = "Date of Birth"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.Location = New System.Drawing.Point(569, 80)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(95, 22)
        Me.txtAge.TabIndex = 8
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.BackColor = System.Drawing.Color.Transparent
        Me.lblFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.Black
        Me.lblFemale.Location = New System.Drawing.Point(189, 82)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(58, 20)
        Me.lblFemale.TabIndex = 0
        Me.lblFemale.Text = "Female"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.BackColor = System.Drawing.Color.Transparent
        Me.lblMale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.ForeColor = System.Drawing.Color.Black
        Me.lblMale.Location = New System.Drawing.Point(125, 82)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(43, 20)
        Me.lblMale.TabIndex = 0
        Me.lblMale.Text = "Male"
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFemale.ForeColor = System.Drawing.Color.White
        Me.rbtnFemale.Location = New System.Drawing.Point(174, 86)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(14, 13)
        Me.rbtnFemale.TabIndex = 4
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMale.ForeColor = System.Drawing.Color.White
        Me.rbtnMale.Location = New System.Drawing.Point(105, 86)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(14, 13)
        Me.rbtnMale.TabIndex = 3
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(99, 123)
        Me.txtAddress.MaxLength = 80
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(805, 20)
        Me.txtAddress.TabIndex = 9
        '
        'txtStudentNo
        '
        Me.txtStudentNo.BackColor = System.Drawing.Color.White
        Me.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentNo.Enabled = False
        Me.txtStudentNo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNo.ForeColor = System.Drawing.Color.Black
        Me.txtStudentNo.Location = New System.Drawing.Point(120, 37)
        Me.txtStudentNo.MaxLength = 11
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(185, 27)
        Me.txtStudentNo.TabIndex = 1
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.White
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.Black
        Me.txtFullName.Location = New System.Drawing.Point(398, 37)
        Me.txtFullName.MaxLength = 50
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(245, 27)
        Me.txtFullName.TabIndex = 2
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.Black
        Me.lblFullName.Location = New System.Drawing.Point(313, 41)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(79, 20)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(30, 123)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(63, 20)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(30, 82)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 20)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender"
        '
        'lblStudentNo
        '
        Me.lblStudentNo.AutoSize = True
        Me.lblStudentNo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNo.ForeColor = System.Drawing.Color.Black
        Me.lblStudentNo.Location = New System.Drawing.Point(29, 41)
        Me.lblStudentNo.Name = "lblStudentNo"
        Me.lblStudentNo.Size = New System.Drawing.Size(87, 20)
        Me.lblStudentNo.TabIndex = 0
        Me.lblStudentNo.Text = "Student No"
        '
        'Form_StudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupbox)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.groupboxButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_StudentProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupboxButtons.ResumeLayout(False)
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupboxButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupbox As GroupBox
    Friend WithEvents cmbboxStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbboxCourse As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbboxYearLevel As ComboBox
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblFemale As Label
    Friend WithEvents lblMale As Label
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblStudentNo As Label
End Class
