Imports System.Data.OleDb
Public Class Form_ReturnBook
    Dim studentID As Integer
    Dim courseID As Integer
    Dim bookID As Integer
    Dim convertedDate As String
    Dim adminFullName As String
    Dim myArrayList As New List(Of Integer)

    Public Sub Reset()
        txtStudentNo.Text = ""
        txtBookNo.Text = ""
        txtStudentNo.Enabled = True
        txtStudentNo.Focus()
        lblFullName.Text = "FULL NAME:"
        lblCourse.Text = "COURSE:"
        lblYearLevel.Text = "YEAR LEVEL:"
        btnBack.Visible = True
        txtBookNo.Enabled = False
        dgvBooks.Enabled = False
        lblTotalEntry.Enabled = False
        lblTotalEntry.Text = "TOTAL ENTRY:"
        btnSubmit.Enabled = False
        btnReturn.Enabled = False

        While dgvBooks.Rows.Count > 0
            dgvBooks.Rows.RemoveAt(0)
        End While

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Reset()
        Me.Hide()
        Form_Main.Show()
    End Sub

    Private Sub Form_ReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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



        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub




    Public Sub retrieveStudentInfo()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_students] WHERE [student_no] = @student_no", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@student_no", txtStudentNo.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                txtStudentNo.Enabled = False


                studentID = dr.Item("ID")


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
                txtBookNo.Enabled = True
                dgvBooks.Enabled = True
                lblTotalEntry.Enabled = True

                txtBookNo.Focus()
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



    Public Sub retrieveBorrowedBooks()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_borrowed_details] WHERE [student_id] = @student_id AND [received_by] = @received_by", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@student_id", studentID)
            cmd.Parameters.AddWithValue("@received_by", "")
            dr = cmd.ExecuteReader()

            While dr.Read = True
                myArrayList.Add(dr.Item("book_id"))
            End While

            For Each x As Integer In myArrayList
                addingRowsToTable(x)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try

    End Sub

    Public Sub addingRowsToTable(retrievedBookID As Integer)
        Try
            con.Close()
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_books] WHERE [id] = @id", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@id", retrievedBookID)

            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                Dim book_no As String = ""
                Dim title As String = ""

                book_no = dr.Item("book_no")
                title = dr.Item("title")
                Dim row As String() = New String() {book_no, title}

                dgvBooks.Rows.Add(row)
                lblTotalEntry.Text = "TOTAL ENTRY: " + dgvBooks.Rows.Count.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try


    End Sub

    Private Sub txtStudentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentNo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub ReturningBook()
        Try
            dr.Close()
            con.Close()



            For i As Integer = 0 To dgvBooks.Rows.Count - 1
                If txtBookNo.Text = dgvBooks.Rows(i).Cells(0).Value Then

                    con.Open()
                    cmd = New OleDbCommand("SELECT * FROM [tbl_books] WHERE [book_no] = @book_no", con) With {
        .CommandType = CommandType.Text
    }
                    cmd.Parameters.AddWithValue("@book_no", txtBookNo.Text)
                    dr = cmd.ExecuteReader()
                    If dr.Read = True Then
                        bookID = dr.Item("ID")
                        dr.Close()
                        con.Close()

                        con.Open()
                        cmd = New OleDbCommand("SELECT * FROM [tbl_borrowed_details] WHERE [received_by]=@received_by AND [book_id]=@book_id", con) With {
            .CommandType = CommandType.Text
        }

                        cmd.Parameters.AddWithValue("@received_by", "")
                        cmd.Parameters.AddWithValue("@book_id", bookID)
                        dr = cmd.ExecuteReader()
                        If dr.Read = True Then
                            Dim retrievedStudentID As Integer = dr.Item("student_id")
                            updatingTheStudentStatusToAllowed(retrievedStudentID)
                        End If

                        convertedDate = lblDateToday.Text

                        cmd.Dispose()
                        dr.Close()
                        con.Close()


                        con.Open()
                        cmd = New OleDbCommand("SELECT * FROM [tbl_admins] WHERE [id] = @id", con) With {
                            .CommandType = CommandType.Text
                        }
                        cmd.Parameters.AddWithValue("@id", Form_Main.userIdGetter)
                        dr = cmd.ExecuteReader()
                        If dr.Read = True Then
                            adminFullName = dr.Item("full_name")
                        End If

                        dr.Close()
                        con.Close()


                        con.Open()
                        cmd = New OleDbCommand("spReturningBook", con) With {
            .CommandType = CommandType.StoredProcedure
        }
                        cmd.Parameters.Add(New OleDbParameter("@actual_return_date", convertedDate))
                        cmd.Parameters.Add(New OleDbParameter("@received_by", adminFullName))
                        cmd.Parameters.Add(New OleDbParameter("@book_id", bookID))
                        cmd.Parameters.Add(New OleDbParameter("@student_id", studentID))

                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        dr.Close()
                        con.Close()

                        dgvBooks.Rows.RemoveAt(i)
                        Exit For

                    End If
                End If

            Next

            dr.Close()
            con.Close()


            Dim currentRows As Integer = dgvBooks.Rows.Count
            If currentRows = 0 Then
                Reset()
            End If

            lblTotalEntry.Text = "TOTAL ENTRY: " + currentRows.ToString()
            txtBookNo.Text = ""
            txtBookNo.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub

    Public Sub updatingTheStudentStatusToAllowed(retrievedStudentID As Integer)
        con.Close()
        con.Open()
        cmd = New OleDbCommand("UPDATE [tbl_students] SET [status] = @status WHERE [id] = @id", con) With {
            .CommandType = CommandType.Text
        }
        cmd.Parameters.AddWithValue("@status", 0)
        cmd.Parameters.AddWithValue("@id", studentID)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub txtBookNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBookNo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If Not dgvBooks.Rows.Count = 0 Or Not lblTotalEntry.Text = "TOTAL ENTRY:" Then
            ReturningBook()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not txtStudentNo.Text = "" Then
            retrieveStudentInfo()
            retrieveBorrowedBooks()
            btnSubmit.Enabled = False

        End If
    End Sub

    Private Sub txtBookNo_TextChanged(sender As Object, e As EventArgs) Handles txtBookNo.TextChanged
        If txtBookNo.Text.Length = 0 Then
            btnReturn.Enabled = False
        Else
            btnReturn.Enabled = True
        End If
    End Sub

    Private Sub txtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNo.TextChanged
        If txtStudentNo.Text.Length = 0 Then
            btnSubmit.Enabled = False
        Else
            btnSubmit.Enabled = True
        End If
    End Sub
End Class
