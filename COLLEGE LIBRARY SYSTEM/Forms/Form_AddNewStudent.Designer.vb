<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddNewStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AddNewStudent))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStudentNo = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.cmbboxDay = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cmbboxMonth = New System.Windows.Forms.ComboBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.cmbboxCourse = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbboxYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(317, 375)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 33)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(534, 374)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(168, 33)
        Me.btnBack.TabIndex = 0
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
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
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.White
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.Black
        Me.txtFullName.Location = New System.Drawing.Point(398, 37)
        Me.txtFullName.MaxLength = 16
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(245, 27)
        Me.txtFullName.TabIndex = 2
        '
        'txtStudentNo
        '
        Me.txtStudentNo.BackColor = System.Drawing.Color.White
        Me.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentNo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNo.ForeColor = System.Drawing.Color.Black
        Me.txtStudentNo.Location = New System.Drawing.Point(120, 37)
        Me.txtStudentNo.MaxLength = 11
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(185, 27)
        Me.txtStudentNo.TabIndex = 1
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
        'cmbboxDay
        '
        Me.cmbboxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDay.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxDay.FormattingEnabled = True
        Me.cmbboxDay.Items.AddRange(New Object() {"Day", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbboxDay.Location = New System.Drawing.Point(463, 78)
        Me.cmbboxDay.MaxLength = 2
        Me.cmbboxDay.Name = "cmbboxDay"
        Me.cmbboxDay.Size = New System.Drawing.Size(76, 28)
        Me.cmbboxDay.TabIndex = 6
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.Location = New System.Drawing.Point(677, 80)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(95, 22)
        Me.txtAge.TabIndex = 8
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
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.White
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.Black
        Me.txtYear.Location = New System.Drawing.Point(545, 80)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Multiline = True
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(91, 22)
        Me.txtYear.TabIndex = 7
        '
        'cmbboxMonth
        '
        Me.cmbboxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxMonth.FormattingEnabled = True
        Me.cmbboxMonth.Items.AddRange(New Object() {"Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbboxMonth.Location = New System.Drawing.Point(359, 79)
        Me.cmbboxMonth.MaxLength = 9
        Me.cmbboxMonth.Name = "cmbboxMonth"
        Me.cmbboxMonth.Size = New System.Drawing.Size(98, 28)
        Me.cmbboxMonth.TabIndex = 5
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(642, 82)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 20)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age"
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.Color.Transparent
        Me.groupbox.Controls.Add(Me.cmbboxCourse)
        Me.groupbox.Controls.Add(Me.lblCourse)
        Me.groupbox.Controls.Add(Me.cmbboxYearLevel)
        Me.groupbox.Controls.Add(Me.lblYearLevel)
        Me.groupbox.Controls.Add(Me.txtContactNumber)
        Me.groupbox.Controls.Add(Me.lblContactNumber)
        Me.groupbox.Controls.Add(Me.lblAge)
        Me.groupbox.Controls.Add(Me.cmbboxMonth)
        Me.groupbox.Controls.Add(Me.txtYear)
        Me.groupbox.Controls.Add(Me.lblDateOfBirth)
        Me.groupbox.Controls.Add(Me.txtAge)
        Me.groupbox.Controls.Add(Me.cmbboxDay)
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
        Me.groupbox.Location = New System.Drawing.Point(43, 51)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(946, 276)
        Me.groupbox.TabIndex = 0
        Me.groupbox.TabStop = False
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
        'Form_AddNewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 448)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.groupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_AddNewStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD NEW STUDENT"
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblStudentNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents cmbboxDay As ComboBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents cmbboxMonth As ComboBox
    Friend WithEvents lblAge As Label
    Friend WithEvents groupbox As GroupBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents cmbboxCourse As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbboxYearLevel As ComboBox
    Friend WithEvents lblYearLevel As Label
End Class
