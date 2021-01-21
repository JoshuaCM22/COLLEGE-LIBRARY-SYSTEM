Imports System.Data.OleDb
Public Class Form_BorrowBook
    Dim studentID As Integer
    Dim courseID As Integer
    Dim bookID As Integer
    Dim convertedDate As String
    Dim borrowToday As Boolean
    Public Sub Reset()
        txtStudentNo.Text = ""
        txtStudentNo.Enabled = True
        txtStudentNo.Focus()
        txtBookNo.Text = ""
        lblStatus.Text = "STATUS:"
        lblFullName.Text = "FULL NAME:"
        lblCourse.Text = "COURSE:"
        lblYearLevel.Text = "YEAR LEVEL:"
        btnBack.Visible = True
        btnCancel.Visible = False
        txtBookNo.Enabled = False
        dgvBooks.Enabled = False
        chkSelectAll.Enabled = False
        lblTotalEntry.Enabled = False
        lblBorrowedUntil.Enabled = False
        dtpBorrowedUntil.Enabled = False
        btnRemove.Enabled = False
        btnBorrow.Enabled = False
        lblTotalEntry.Text = "TOTAL ENTRY:"

        While dgvBooks.Rows.Count > 0
            dgvBooks.Rows.RemoveAt(0)
        End While
        dtpBorrowedUntil.MinDate = DateTime.Now
        dtpBorrowedUntil.CustomFormat = " "
        dtpBorrowedUntil.Tag = dtpBorrowedUntil.Value
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Reset()
        Me.Hide()
        Form_Main.Show()
    End Sub

    Private Sub Form_BorrowBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Reset()
        Timer1.Start()
        lblTimeNow.Focus()
        lblDateToday.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDayToday.Text = WeekdayName(Weekday(Now))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeNow.Text = TimeOfDay.ToString("h:mm:ss tt")
        lblDateToday.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDayToday.Text = WeekdayName(Weekday(Now))
    End Sub



    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to remove ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Try
                Dim rows = dgvBooks.Rows.Count
                For x As Integer = rows - 1 To x >= 1 Step -1
                    If dgvBooks.Rows(x).Cells(0).Value = True Then
                        dgvBooks.Rows.RemoveAt(x)
                    End If
                Next

                checkIftblBorrowBookIsEmptyOrNot()
                dtpBorrowedUntil.CustomFormat = " "
                dtpBorrowedUntil.Tag = dtpBorrowedUntil.Value

                txtBookNo.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            Finally
                dr.Close()
                con.Close()
            End Try
        End If
        If lblTotalEntry.Text = "TOTAL ENTRY: 0" Then
            btnBack.Visible = True
            btnCancel.Visible = False
        Else
            btnBack.Visible = False
            btnCancel.Visible = True
        End If
    End Sub
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        validation()
        If lblTotalEntry.Text = "TOTAL ENTRY: 0" Then
            btnBack.Visible = True
            btnCancel.Visible = False
        Else
            btnBack.Visible = False
            btnCancel.Visible = True
        End If
    End Sub

    Public Sub validation()
        Try

            For i As Integer = 0 To dgvBooks.Rows.Count - 1

                If dgvBooks.Rows(i).Cells(0).Value = True Then

                    con.Open()
                    cmd = New OleDbCommand("SELECT * FROM [tbl_books] WHERE [book_no] = @book_no", con) With {
        .CommandType = CommandType.Text
    }
                    cmd.Parameters.AddWithValue("@book_no", dgvBooks.Rows(i).Cells(1).Value.ToString())
                    dr = cmd.ExecuteReader()
                    If dr.Read = True Then

                        bookID = dr.Item("ID")
                        dr.Close()
                        con.Close()
                        inserting()
                    End If
                End If
            Next

            MsgBox("Successfully Borrowed!!", MsgBoxStyle.Information, "ATTENTION")

            Dim rows = dgvBooks.Rows.Count
            For x As Integer = rows - 1 To x >= 1 Step -1
                If dgvBooks.Rows(x).Cells(0).Value = True Then
                    dgvBooks.Rows.RemoveAt(x)
                End If
            Next

            checkIftblBorrowBookIsEmptyOrNot()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub


    Public Sub inserting()


        convertedDate = dtpBorrowedUntil.Value.ToString("MMMM dd, yyyy")



        con.Open()
        cmd = New OleDbCommand("spInsertNewBorrowBook", con) With {
            .CommandType = CommandType.StoredProcedure
        }
        cmd.Parameters.Add(New OleDbParameter("@book_id", bookID))
        cmd.Parameters.Add(New OleDbParameter("@student_id", studentID))
        cmd.Parameters.Add(New OleDbParameter("@borrowed_from_date", lblDateToday.Text))
        cmd.Parameters.Add(New OleDbParameter("@borrowed_until_date", convertedDate))
        cmd.Parameters.Add(New OleDbParameter("@actual_return_date", ""))
        cmd.Parameters.Add(New OleDbParameter("@lent_by", Form_Main.userIdGetter))
        cmd.Parameters.Add(New OleDbParameter("@received_by", ""))
        cmd.Parameters.Add(New OleDbParameter("@allowed_days", 0))
        cmd.Parameters.Add(New OleDbParameter("@penalty", 0))
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.Close()


        con.Open()
        cmd = New OleDbCommand("Update tbl_students SET status = [@status] WHERE [id] =[@id]", con) With {
            .CommandType = CommandType.Text
        }
        cmd.Parameters.Add(New OleDbParameter("@status", 1))
        cmd.Parameters.Add(New OleDbParameter("@student_id", studentID))
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        lblTitle.Focus()

        Dim haveSelectedRow As Boolean = False

        For Each row As DataGridViewRow In dgvBooks.Rows
            Dim cell As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)

            If chkSelectAll.Checked = True Then
                haveSelectedRow = True
                cell.Value = haveSelectedRow
            Else
                cell.Value = False
            End If
        Next

        If haveSelectedRow = True Then
            btnRemove.Enabled = True
            btnBorrow.Enabled = True
            dtpBorrowedUntil.Enabled = True
        Else
            btnRemove.Enabled = False
            btnBorrow.Enabled = False
            dtpBorrowedUntil.Enabled = False
        End If

    End Sub

    Public Sub checkIfThereWasSelected()
        Dim haveSelectedRow As Boolean = False
        For Each row As DataGridViewRow In dgvBooks.Rows
            Dim cell As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)

            If cell.Value = True Then
                haveSelectedRow = True
            Else
                cell.Value = False
            End If
        Next
    End Sub


    Public Sub CheckForStudentNo()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_students] WHERE [student_no] = @student_no", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@student_no", txtStudentNo.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                txtStudentNo.Enabled = False
                btnCancel.Visible = True
                btnBack.Visible = False
                studentID = dr.Item("ID")
                Dim status = dr.Item("status")
                If status = 0 Then
                    lblStatus.Text += " Allowed"
                ElseIf status = 1 Then
                    lblStatus.Text += " Not Allowed"
                End If
                lblFullName.Text += " " + dr.Item("full_name")
                courseID = dr.Item("course_id")
                Dim yearLevel = dr.Item("year_level")
                If yearLevel = 0 Then
                    lblYearLevel.Text += " 1st"
                ElseIf yearLevel = 1 Then
                    lblYearLevel.Text += " 2nd"
                ElseIf yearLevel = 2 Then
                    lblYearLevel.Text += " 3rd"
                ElseIf yearLevel = 3 Then
                    lblYearLevel.Text += " 4th"
                ElseIf yearLevel = 4 Then
                    lblYearLevel.Text += " 5th"
                End If
                dr.Close()
                con.Close()
                GetCourse()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub

    Public Sub GetCourse()
        cmd.Dispose()
        dr.Close()
        con.Close()

        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_courses] WHERE [id] = @id", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@id", courseID)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                lblCourse.Text += " " + dr.Item("course")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try

    End Sub

    Private Sub txtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNo.TextChanged
        CheckForStudentNo()
        If lblStatus.Text = "STATUS: Allowed" Then
            enableds()
        End If
        If lblTotalEntry.Text = "TOTAL ENTRY: 0" Or lblTotalEntry.Text = "TOTAL ENTRY:" Then
            btnBack.Visible = True
            btnCancel.Visible = False
        Else
            btnBack.Visible = False
            btnCancel.Visible = True
        End If

    End Sub

    Private Sub txtStudentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentNo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub CheckForBookNo()
        Try
            dr.Close()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_books] WHERE [book_no] = @book_no", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@book_no", txtBookNo.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                Dim book_no As String = ""
                Dim title As String = ""
                book_no = dr.Item("book_no")
                title = dr.Item("title")


                Dim row As String() = New String() {False, book_no, title}

                dgvBooks.Rows.Add(row)
                txtBookNo.Text = ""
                txtBookNo.Focus()
                checkIftblBorrowBookIsEmptyOrNot()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub

    Private Sub txtBookNo_TextChanged(sender As Object, e As EventArgs) Handles txtBookNo.TextChanged
        CheckForBookNo()
        If lblTotalEntry.Text = "TOTAL ENTRY: 0" Then
            btnBack.Visible = True
            btnCancel.Visible = False
        Else
            btnBack.Visible = False
            btnCancel.Visible = True
        End If
    End Sub

    Private Sub txtBookNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBookNo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Reset()
        End If
    End Sub

    Public Sub enableds()
        txtBookNo.Enabled = True
        dgvBooks.Enabled = True
        chkSelectAll.Enabled = True
        lblTotalEntry.Enabled = True
        lblBorrowedUntil.Enabled = True
        dtpBorrowedUntil.Enabled = True
        btnRemove.Enabled = True
        btnBorrow.Enabled = True
        txtBookNo.Focus()
        checkIftblBorrowBookIsEmptyOrNot()
    End Sub
    Public Sub checkIftblBorrowBookIsEmptyOrNot()
        lblTotalEntry.Text = "TOTAL ENTRY: " + dgvBooks.RowCount.ToString
        If lblTotalEntry.Text = "TOTAL ENTRY: 0" Or lblTotalEntry.Text = "TOTAL ENTRY:" Then
            chkSelectAll.Checked = False
            chkSelectAll.Enabled = False
            btnRemove.Enabled = False
            btnBorrow.Enabled = False
            dtpBorrowedUntil.Enabled = False
        ElseIf lblTotalEntry.Text = "TOTAL ENTRY: 1" Then
            chkSelectAll.Checked = False
            chkSelectAll.Enabled = False
        Else
            chkSelectAll.Enabled = True
        End If
    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If chkSelectAll.Checked = False Then
            Dim row As DataGridViewRow = dgvBooks.CurrentRow
            If Convert.ToBoolean(row.Cells(0).Value) Then
                row.Cells(0).Value = False
                btnRemove.Enabled = False
                btnBorrow.Enabled = False
                dtpBorrowedUntil.Enabled = False
            Else
                row.Cells(0).Value = True
                btnRemove.Enabled = True
                btnBorrow.Enabled = True
                dtpBorrowedUntil.Enabled = True
            End If

        End If

    End Sub

    Private Sub dtpBorrowedUntil_ValueChanged(sender As Object, e As EventArgs) Handles dtpBorrowedUntil.ValueChanged
        dtpBorrowedUntil.Format = DateTimePickerFormat.Short
    End Sub
End Class
