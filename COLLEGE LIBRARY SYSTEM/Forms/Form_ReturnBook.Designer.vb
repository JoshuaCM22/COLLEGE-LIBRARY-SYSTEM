<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ReturnBook
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ReturnBook))
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.book_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStudentNo = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.lblDayToday = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTotalEntry = New System.Windows.Forms.Label()
        Me.txtBookNo = New System.Windows.Forms.TextBox()
        Me.lblBookNo = New System.Windows.Forms.Label()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToResizeColumns = False
        Me.dgvBooks.AllowUserToResizeRows = False
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooks.ColumnHeadersHeight = 41
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.book_no, Me.title})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBooks.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvBooks.Location = New System.Drawing.Point(511, 130)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = "---------"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(800, 278)
        Me.dgvBooks.TabIndex = 0
        Me.dgvBooks.TabStop = False
        '
        'book_no
        '
        Me.book_no.HeaderText = "BOOK NO"
        Me.book_no.Name = "book_no"
        Me.book_no.ReadOnly = True
        Me.book_no.Width = 270
        '
        'title
        '
        Me.title.HeaderText = "TITLE"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 487
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(23, 597)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 30)
        Me.btnBack.TabIndex = 0
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblStudentNo
        '
        Me.lblStudentNo.AutoSize = True
        Me.lblStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNo.ForeColor = System.Drawing.Color.White
        Me.lblStudentNo.Location = New System.Drawing.Point(60, 134)
        Me.lblStudentNo.Name = "lblStudentNo"
        Me.lblStudentNo.Size = New System.Drawing.Size(110, 18)
        Me.lblStudentNo.TabIndex = 0
        Me.lblStudentNo.Text = "STUDENT NO:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(554, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(214, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "RETURN BOOK"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNo.Location = New System.Drawing.Point(182, 133)
        Me.txtStudentNo.MaxLength = 11
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(235, 22)
        Me.txtStudentNo.TabIndex = 1
        Me.txtStudentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(60, 234)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(95, 18)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "FULL NAME:"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.White
        Me.lblCourse.Location = New System.Drawing.Point(60, 282)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(77, 18)
        Me.lblCourse.TabIndex = 0
        Me.lblCourse.Text = "COURSE:"
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTimeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeNow.ForeColor = System.Drawing.Color.White
        Me.lblTimeNow.Location = New System.Drawing.Point(1067, 603)
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
        Me.lblDayToday.Location = New System.Drawing.Point(836, 603)
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
        Me.lblDateToday.Location = New System.Drawing.Point(543, 603)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(131, 24)
        Me.lblDateToday.TabIndex = 0
        Me.lblDateToday.Text = "DATE TODAY"
        '
        'lblTotalEntry
        '
        Me.lblTotalEntry.AutoSize = True
        Me.lblTotalEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntry.ForeColor = System.Drawing.Color.White
        Me.lblTotalEntry.Location = New System.Drawing.Point(1113, 420)
        Me.lblTotalEntry.Name = "lblTotalEntry"
        Me.lblTotalEntry.Size = New System.Drawing.Size(117, 18)
        Me.lblTotalEntry.TabIndex = 0
        Me.lblTotalEntry.Text = "TOTAL ENTRY: "
        '
        'txtBookNo
        '
        Me.txtBookNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNo.Location = New System.Drawing.Point(608, 93)
        Me.txtBookNo.MaxLength = 11
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.Size = New System.Drawing.Size(235, 22)
        Me.txtBookNo.TabIndex = 2
        Me.txtBookNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBookNo
        '
        Me.lblBookNo.AutoSize = True
        Me.lblBookNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookNo.ForeColor = System.Drawing.Color.White
        Me.lblBookNo.Location = New System.Drawing.Point(515, 96)
        Me.lblBookNo.Name = "lblBookNo"
        Me.lblBookNo.Size = New System.Drawing.Size(83, 18)
        Me.lblBookNo.TabIndex = 0
        Me.lblBookNo.Text = "BOOK NO:"
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevel.ForeColor = System.Drawing.Color.White
        Me.lblYearLevel.Location = New System.Drawing.Point(60, 329)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(100, 18)
        Me.lblYearLevel.TabIndex = 0
        Me.lblYearLevel.Text = "YEAR LEVEL:"
        '
        'Timer1
        '
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(856, 91)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(132, 26)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.TabStop = False
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(228, 173)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(132, 26)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.TabStop = False
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form_ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1359, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblYearLevel)
        Me.Controls.Add(Me.txtBookNo)
        Me.Controls.Add(Me.lblBookNo)
        Me.Controls.Add(Me.lblTotalEntry)
        Me.Controls.Add(Me.lblTimeNow)
        Me.Controls.Add(Me.lblDayToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.txtStudentNo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStudentNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_ReturnBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBooks As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblStudentNo As System.Windows.Forms.Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblTimeNow As Label
    Friend WithEvents lblDayToday As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lblTotalEntry As Label
    Friend WithEvents txtBookNo As TextBox
    Friend WithEvents lblBookNo As Label
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents book_no As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSubmit As Button
End Class
