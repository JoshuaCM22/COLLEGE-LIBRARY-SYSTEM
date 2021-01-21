<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_BookList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BookList))
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddNewBook = New System.Windows.Forms.Button()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.cmbboxFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnShelfList = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSubjectList = New System.Windows.Forms.Button()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox.SuspendLayout()
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBooks.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvBooks.Location = New System.Drawing.Point(28, 144)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
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
        Me.dgvBooks.Size = New System.Drawing.Size(1301, 429)
        Me.dgvBooks.TabIndex = 56
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(825, 599)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 30)
        Me.btnBack.TabIndex = 58
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddNewBook
        '
        Me.btnAddNewBook.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddNewBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewBook.FlatAppearance.BorderSize = 0
        Me.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBook.ForeColor = System.Drawing.Color.White
        Me.btnAddNewBook.Location = New System.Drawing.Point(1131, 81)
        Me.btnAddNewBook.Name = "btnAddNewBook"
        Me.btnAddNewBook.Size = New System.Drawing.Size(198, 41)
        Me.btnAddNewBook.TabIndex = 59
        Me.btnAddNewBook.Text = "ADD A NEW BOOK"
        Me.btnAddNewBook.UseVisualStyleBackColor = False
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBox.Controls.Add(Me.cmbboxFilter)
        Me.groupBox.Controls.Add(Me.txtSearch)
        Me.groupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.ForeColor = System.Drawing.Color.White
        Me.groupBox.Location = New System.Drawing.Point(33, 53)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(472, 69)
        Me.groupBox.TabIndex = 60
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "SEARCH BY :"
        '
        'cmbboxFilter
        '
        Me.cmbboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxFilter.FormattingEnabled = True
        Me.cmbboxFilter.Items.AddRange(New Object() {"None", "Book No", "Title", "Subject", "Authors", "Publisher", "Copyright Year", "Original Total Pages", "Current Total Pages", "Quantity", "Date", "Time", "Shelf", "Admin Name"})
        Me.cmbboxFilter.Location = New System.Drawing.Point(14, 28)
        Me.cmbboxFilter.Name = "cmbboxFilter"
        Me.cmbboxFilter.Size = New System.Drawing.Size(199, 24)
        Me.cmbboxFilter.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(223, 28)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(25, 595)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(104, 18)
        Me.lblTotal.TabIndex = 61
        Me.lblTotal.Text = "TOTAL LABEL"
        '
        'btnShelfList
        '
        Me.btnShelfList.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnShelfList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShelfList.FlatAppearance.BorderSize = 0
        Me.btnShelfList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShelfList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShelfList.ForeColor = System.Drawing.Color.White
        Me.btnShelfList.Location = New System.Drawing.Point(981, 599)
        Me.btnShelfList.Name = "btnShelfList"
        Me.btnShelfList.Size = New System.Drawing.Size(163, 30)
        Me.btnShelfList.TabIndex = 62
        Me.btnShelfList.Text = "SHELF LIST"
        Me.btnShelfList.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(578, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(157, 31)
        Me.lblTitle.TabIndex = 63
        Me.lblTitle.Text = "BOOK LIST"
        '
        'btnSubjectList
        '
        Me.btnSubjectList.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSubjectList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubjectList.FlatAppearance.BorderSize = 0
        Me.btnSubjectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjectList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjectList.ForeColor = System.Drawing.Color.White
        Me.btnSubjectList.Location = New System.Drawing.Point(1166, 599)
        Me.btnSubjectList.Name = "btnSubjectList"
        Me.btnSubjectList.Size = New System.Drawing.Size(163, 30)
        Me.btnSubjectList.TabIndex = 64
        Me.btnSubjectList.Text = "SUBJECT LIST"
        Me.btnSubjectList.UseVisualStyleBackColor = False
        '
        'Form_BookList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1359, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubjectList)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnShelfList)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.btnAddNewBook)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_BookList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBooks As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAddNewBook As System.Windows.Forms.Button
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbboxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnShelfList As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSubjectList As Button
End Class
