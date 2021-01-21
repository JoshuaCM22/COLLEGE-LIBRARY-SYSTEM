<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_BookProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BookProfile))
        Me.groupboxButtons = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtCurrentTotalPages = New System.Windows.Forms.TextBox()
        Me.lblCurrentTotalPages = New System.Windows.Forms.Label()
        Me.txtOriginalTotalPages = New System.Windows.Forms.TextBox()
        Me.lblOriginalTotalPages = New System.Windows.Forms.Label()
        Me.txtAuthors = New System.Windows.Forms.TextBox()
        Me.lblAuthors = New System.Windows.Forms.Label()
        Me.cmbboxSubject = New System.Windows.Forms.ComboBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.cmbboxShelf = New System.Windows.Forms.ComboBox()
        Me.lblShelf = New System.Windows.Forms.Label()
        Me.txtCopyrightYear = New System.Windows.Forms.TextBox()
        Me.lblCopyrightYear = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookNo = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblBookNo = New System.Windows.Forms.Label()
        Me.groupboxButtons.SuspendLayout()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblTitle.Location = New System.Drawing.Point(409, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(191, 29)
        Me.lblTitle.TabIndex = 158
        Me.lblTitle.Text = "BOOK PROFILE"
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.Color.Transparent
        Me.groupbox.Controls.Add(Me.txtQuantity)
        Me.groupbox.Controls.Add(Me.lblQuantity)
        Me.groupbox.Controls.Add(Me.txtCurrentTotalPages)
        Me.groupbox.Controls.Add(Me.lblCurrentTotalPages)
        Me.groupbox.Controls.Add(Me.txtOriginalTotalPages)
        Me.groupbox.Controls.Add(Me.lblOriginalTotalPages)
        Me.groupbox.Controls.Add(Me.txtAuthors)
        Me.groupbox.Controls.Add(Me.lblAuthors)
        Me.groupbox.Controls.Add(Me.cmbboxSubject)
        Me.groupbox.Controls.Add(Me.lblSubject)
        Me.groupbox.Controls.Add(Me.cmbboxShelf)
        Me.groupbox.Controls.Add(Me.lblShelf)
        Me.groupbox.Controls.Add(Me.txtCopyrightYear)
        Me.groupbox.Controls.Add(Me.lblCopyrightYear)
        Me.groupbox.Controls.Add(Me.txtPublisher)
        Me.groupbox.Controls.Add(Me.txtBookNo)
        Me.groupbox.Controls.Add(Me.txtTitle)
        Me.groupbox.Controls.Add(Me.Label1)
        Me.groupbox.Controls.Add(Me.lblPublisher)
        Me.groupbox.Controls.Add(Me.lblBookNo)
        Me.groupbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox.ForeColor = System.Drawing.Color.Black
        Me.groupbox.Location = New System.Drawing.Point(47, 92)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(946, 276)
        Me.groupbox.TabIndex = 159
        Me.groupbox.TabStop = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(94, 212)
        Me.txtQuantity.MaxLength = 9
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(192, 27)
        Me.txtQuantity.TabIndex = 22
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.Black
        Me.lblQuantity.Location = New System.Drawing.Point(22, 216)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 21
        Me.lblQuantity.Text = "Quantity"
        '
        'txtCurrentTotalPages
        '
        Me.txtCurrentTotalPages.BackColor = System.Drawing.Color.White
        Me.txtCurrentTotalPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentTotalPages.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentTotalPages.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentTotalPages.Location = New System.Drawing.Point(790, 163)
        Me.txtCurrentTotalPages.MaxLength = 50
        Me.txtCurrentTotalPages.Name = "txtCurrentTotalPages"
        Me.txtCurrentTotalPages.Size = New System.Drawing.Size(116, 27)
        Me.txtCurrentTotalPages.TabIndex = 20
        '
        'lblCurrentTotalPages
        '
        Me.lblCurrentTotalPages.AutoSize = True
        Me.lblCurrentTotalPages.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTotalPages.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTotalPages.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentTotalPages.Location = New System.Drawing.Point(640, 167)
        Me.lblCurrentTotalPages.Name = "lblCurrentTotalPages"
        Me.lblCurrentTotalPages.Size = New System.Drawing.Size(142, 20)
        Me.lblCurrentTotalPages.TabIndex = 19
        Me.lblCurrentTotalPages.Text = "Current Total Pages"
        '
        'txtOriginalTotalPages
        '
        Me.txtOriginalTotalPages.BackColor = System.Drawing.Color.White
        Me.txtOriginalTotalPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOriginalTotalPages.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalTotalPages.ForeColor = System.Drawing.Color.Black
        Me.txtOriginalTotalPages.Location = New System.Drawing.Point(504, 163)
        Me.txtOriginalTotalPages.MaxLength = 50
        Me.txtOriginalTotalPages.Name = "txtOriginalTotalPages"
        Me.txtOriginalTotalPages.Size = New System.Drawing.Size(116, 27)
        Me.txtOriginalTotalPages.TabIndex = 18
        '
        'lblOriginalTotalPages
        '
        Me.lblOriginalTotalPages.AutoSize = True
        Me.lblOriginalTotalPages.BackColor = System.Drawing.Color.Transparent
        Me.lblOriginalTotalPages.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginalTotalPages.ForeColor = System.Drawing.Color.Black
        Me.lblOriginalTotalPages.Location = New System.Drawing.Point(353, 167)
        Me.lblOriginalTotalPages.Name = "lblOriginalTotalPages"
        Me.lblOriginalTotalPages.Size = New System.Drawing.Size(145, 20)
        Me.lblOriginalTotalPages.TabIndex = 17
        Me.lblOriginalTotalPages.Text = "Original Total Pages"
        '
        'txtAuthors
        '
        Me.txtAuthors.BackColor = System.Drawing.Color.White
        Me.txtAuthors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthors.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthors.ForeColor = System.Drawing.Color.Black
        Me.txtAuthors.Location = New System.Drawing.Point(101, 84)
        Me.txtAuthors.MaxLength = 80
        Me.txtAuthors.Multiline = True
        Me.txtAuthors.Name = "txtAuthors"
        Me.txtAuthors.Size = New System.Drawing.Size(805, 20)
        Me.txtAuthors.TabIndex = 16
        '
        'lblAuthors
        '
        Me.lblAuthors.AutoSize = True
        Me.lblAuthors.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthors.ForeColor = System.Drawing.Color.Black
        Me.lblAuthors.Location = New System.Drawing.Point(30, 84)
        Me.lblAuthors.Name = "lblAuthors"
        Me.lblAuthors.Size = New System.Drawing.Size(63, 20)
        Me.lblAuthors.TabIndex = 15
        Me.lblAuthors.Text = "Authors"
        '
        'cmbboxSubject
        '
        Me.cmbboxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxSubject.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxSubject.FormattingEnabled = True
        Me.cmbboxSubject.Location = New System.Drawing.Point(689, 36)
        Me.cmbboxSubject.MaxLength = 9
        Me.cmbboxSubject.Name = "cmbboxSubject"
        Me.cmbboxSubject.Size = New System.Drawing.Size(215, 28)
        Me.cmbboxSubject.TabIndex = 14
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.Color.Black
        Me.lblSubject.Location = New System.Drawing.Point(623, 39)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(59, 20)
        Me.lblSubject.TabIndex = 13
        Me.lblSubject.Text = "Subject"
        '
        'cmbboxShelf
        '
        Me.cmbboxShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxShelf.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxShelf.FormattingEnabled = True
        Me.cmbboxShelf.Location = New System.Drawing.Point(361, 211)
        Me.cmbboxShelf.MaxLength = 9
        Me.cmbboxShelf.Name = "cmbboxShelf"
        Me.cmbboxShelf.Size = New System.Drawing.Size(204, 28)
        Me.cmbboxShelf.TabIndex = 11
        '
        'lblShelf
        '
        Me.lblShelf.AutoSize = True
        Me.lblShelf.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShelf.ForeColor = System.Drawing.Color.Black
        Me.lblShelf.Location = New System.Drawing.Point(304, 214)
        Me.lblShelf.Name = "lblShelf"
        Me.lblShelf.Size = New System.Drawing.Size(43, 20)
        Me.lblShelf.TabIndex = 0
        Me.lblShelf.Text = "Shelf"
        '
        'txtCopyrightYear
        '
        Me.txtCopyrightYear.BackColor = System.Drawing.Color.White
        Me.txtCopyrightYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopyrightYear.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopyrightYear.ForeColor = System.Drawing.Color.Black
        Me.txtCopyrightYear.Location = New System.Drawing.Point(132, 163)
        Me.txtCopyrightYear.MaxLength = 4
        Me.txtCopyrightYear.Name = "txtCopyrightYear"
        Me.txtCopyrightYear.Size = New System.Drawing.Size(197, 27)
        Me.txtCopyrightYear.TabIndex = 10
        '
        'lblCopyrightYear
        '
        Me.lblCopyrightYear.AutoSize = True
        Me.lblCopyrightYear.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyrightYear.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyrightYear.ForeColor = System.Drawing.Color.Black
        Me.lblCopyrightYear.Location = New System.Drawing.Point(18, 167)
        Me.lblCopyrightYear.Name = "lblCopyrightYear"
        Me.lblCopyrightYear.Size = New System.Drawing.Size(111, 20)
        Me.lblCopyrightYear.TabIndex = 0
        Me.lblCopyrightYear.Text = "Copyright Year"
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.White
        Me.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPublisher.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.ForeColor = System.Drawing.Color.Black
        Me.txtPublisher.Location = New System.Drawing.Point(102, 123)
        Me.txtPublisher.MaxLength = 80
        Me.txtPublisher.Multiline = True
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(805, 20)
        Me.txtPublisher.TabIndex = 9
        '
        'txtBookNo
        '
        Me.txtBookNo.BackColor = System.Drawing.Color.White
        Me.txtBookNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookNo.Enabled = False
        Me.txtBookNo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNo.ForeColor = System.Drawing.Color.Black
        Me.txtBookNo.Location = New System.Drawing.Point(101, 37)
        Me.txtBookNo.MaxLength = 11
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.Size = New System.Drawing.Size(185, 27)
        Me.txtBookNo.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.White
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.Black
        Me.txtTitle.Location = New System.Drawing.Point(336, 37)
        Me.txtTitle.MaxLength = 30
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(279, 27)
        Me.txtTitle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(291, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.ForeColor = System.Drawing.Color.Black
        Me.lblPublisher.Location = New System.Drawing.Point(22, 123)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(73, 20)
        Me.lblPublisher.TabIndex = 0
        Me.lblPublisher.Text = "Publisher"
        '
        'lblBookNo
        '
        Me.lblBookNo.AutoSize = True
        Me.lblBookNo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookNo.ForeColor = System.Drawing.Color.Black
        Me.lblBookNo.Location = New System.Drawing.Point(29, 41)
        Me.lblBookNo.Name = "lblBookNo"
        Me.lblBookNo.Size = New System.Drawing.Size(69, 20)
        Me.lblBookNo.TabIndex = 0
        Me.lblBookNo.Text = "Book No"
        '
        'Form_BookProfile
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
        Me.Name = "Form_BookProfile"
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
    Friend WithEvents groupbox As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtCurrentTotalPages As TextBox
    Friend WithEvents lblCurrentTotalPages As Label
    Friend WithEvents txtOriginalTotalPages As TextBox
    Friend WithEvents lblOriginalTotalPages As Label
    Friend WithEvents txtAuthors As TextBox
    Friend WithEvents lblAuthors As Label
    Friend WithEvents cmbboxSubject As ComboBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents cmbboxShelf As ComboBox
    Friend WithEvents lblShelf As Label
    Friend WithEvents txtCopyrightYear As TextBox
    Friend WithEvents lblCopyrightYear As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtBookNo As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblBookNo As Label
End Class
