<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.toolstrip_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrip_CreateAnotherAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrip_ChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrip_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStudentList = New System.Windows.Forms.Button()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.lblDayToday = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBookList = New System.Windows.Forms.Button()
        Me.btnBorrowedDetails = New System.Windows.Forms.Button()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrip_Settings})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.menuStrip.Size = New System.Drawing.Size(800, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'toolstrip_Settings
        '
        Me.toolstrip_Settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrip_CreateAnotherAccount, Me.toolstrip_ChangePassword, Me.toolstrip_Logout})
        Me.toolstrip_Settings.Name = "toolstrip_Settings"
        Me.toolstrip_Settings.Size = New System.Drawing.Size(69, 20)
        Me.toolstrip_Settings.Text = "SETTINGS"
        '
        'toolstrip_CreateAnotherAccount
        '
        Me.toolstrip_CreateAnotherAccount.Name = "toolstrip_CreateAnotherAccount"
        Me.toolstrip_CreateAnotherAccount.Size = New System.Drawing.Size(232, 22)
        Me.toolstrip_CreateAnotherAccount.Text = "CREATE ANOTHER ACCOUNT "
        '
        'toolstrip_ChangePassword
        '
        Me.toolstrip_ChangePassword.Name = "toolstrip_ChangePassword"
        Me.toolstrip_ChangePassword.Size = New System.Drawing.Size(232, 22)
        Me.toolstrip_ChangePassword.Text = "CHANGE PASSWORD"
        '
        'toolstrip_Logout
        '
        Me.toolstrip_Logout.Name = "toolstrip_Logout"
        Me.toolstrip_Logout.Size = New System.Drawing.Size(232, 22)
        Me.toolstrip_Logout.Text = "LOG-OUT"
        '
        'btnStudentList
        '
        Me.btnStudentList.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnStudentList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentList.ForeColor = System.Drawing.Color.White
        Me.btnStudentList.Location = New System.Drawing.Point(458, 149)
        Me.btnStudentList.Name = "btnStudentList"
        Me.btnStudentList.Size = New System.Drawing.Size(219, 44)
        Me.btnStudentList.TabIndex = 0
        Me.btnStudentList.TabStop = False
        Me.btnStudentList.Text = "STUDENT LIST"
        Me.btnStudentList.UseVisualStyleBackColor = False
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTimeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeNow.ForeColor = System.Drawing.Color.White
        Me.lblTimeNow.Location = New System.Drawing.Point(589, 403)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(107, 24)
        Me.lblTimeNow.TabIndex = 0
        Me.lblTimeNow.Text = "TIME NOW"
        '
        'lblDayToday
        '
        Me.lblDayToday.AutoSize = True
        Me.lblDayToday.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblDayToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayToday.ForeColor = System.Drawing.Color.White
        Me.lblDayToday.Location = New System.Drawing.Point(358, 403)
        Me.lblDayToday.Name = "lblDayToday"
        Me.lblDayToday.Size = New System.Drawing.Size(118, 24)
        Me.lblDayToday.TabIndex = 0
        Me.lblDayToday.Text = "DAY TODAY"
        '
        'lblDateToday
        '
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblDateToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.White
        Me.lblDateToday.Location = New System.Drawing.Point(65, 403)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(131, 24)
        Me.lblDateToday.TabIndex = 0
        Me.lblDateToday.Text = "DATE TODAY"
        '
        'Timer1
        '
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(186, 66)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(433, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "COLLEGE LIBRARY SYSTEM"
        '
        'btnBookList
        '
        Me.btnBookList.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookList.FlatAppearance.BorderSize = 0
        Me.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookList.ForeColor = System.Drawing.Color.White
        Me.btnBookList.Location = New System.Drawing.Point(138, 149)
        Me.btnBookList.Name = "btnBookList"
        Me.btnBookList.Size = New System.Drawing.Size(219, 44)
        Me.btnBookList.TabIndex = 0
        Me.btnBookList.TabStop = False
        Me.btnBookList.Text = "BOOK LIST"
        Me.btnBookList.UseVisualStyleBackColor = False
        '
        'btnBorrowedDetails
        '
        Me.btnBorrowedDetails.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBorrowedDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowedDetails.FlatAppearance.BorderSize = 0
        Me.btnBorrowedDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowedDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowedDetails.ForeColor = System.Drawing.Color.White
        Me.btnBorrowedDetails.Location = New System.Drawing.Point(294, 223)
        Me.btnBorrowedDetails.Name = "btnBorrowedDetails"
        Me.btnBorrowedDetails.Size = New System.Drawing.Size(219, 44)
        Me.btnBorrowedDetails.TabIndex = 0
        Me.btnBorrowedDetails.TabStop = False
        Me.btnBorrowedDetails.Text = "BORROWED DETAILS"
        Me.btnBorrowedDetails.UseVisualStyleBackColor = False
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBorrowBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowBook.FlatAppearance.BorderSize = 0
        Me.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowBook.ForeColor = System.Drawing.Color.White
        Me.btnBorrowBook.Location = New System.Drawing.Point(138, 292)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(219, 44)
        Me.btnBorrowBook.TabIndex = 0
        Me.btnBorrowBook.TabStop = False
        Me.btnBorrowBook.Text = "BORROW BOOK"
        Me.btnBorrowBook.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturnBook.FlatAppearance.BorderSize = 0
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.ForeColor = System.Drawing.Color.White
        Me.btnReturnBook.Location = New System.Drawing.Point(458, 292)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(219, 44)
        Me.btnReturnBook.TabIndex = 0
        Me.btnReturnBook.TabStop = False
        Me.btnReturnBook.Text = "RETURN BOOK"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(800, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.btnBorrowBook)
        Me.Controls.Add(Me.btnBorrowedDetails)
        Me.Controls.Add(Me.btnBookList)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTimeNow)
        Me.Controls.Add(Me.lblDayToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.btnStudentList)
        Me.Controls.Add(Me.menuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents toolstrip_Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrip_CreateAnotherAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrip_ChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrip_Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStudentList As System.Windows.Forms.Button
    Friend WithEvents lblTimeNow As System.Windows.Forms.Label
    Friend WithEvents lblDayToday As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBookList As Button
    Friend WithEvents btnBorrowedDetails As Button
    Friend WithEvents btnBorrowBook As Button
    Friend WithEvents btnReturnBook As Button
End Class
