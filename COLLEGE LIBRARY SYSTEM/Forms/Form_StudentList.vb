Imports System.Data.OleDb
Public Class Form_StudentList
    Public Sub GetData()
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()
        Try
            con.Open()
            da = New OleDbDataAdapter("vWGetAllStudents", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)
            dgvStudents.Columns(0).Visible = False
            dgvStudents.Columns(1).Width = 200
            dgvStudents.Columns(2).Width = 250
            dgvStudents.Columns(3).Width = 100
            dgvStudents.Columns(4).Width = 150
            dgvStudents.Columns(5).Width = 90
            dgvStudents.Columns(6).Width = 400
            dgvStudents.Columns(7).Width = 300
            dgvStudents.Columns(8).Width = 150
            dgvStudents.Columns(9).Width = 150
            dgvStudents.Columns(10).Width = 150
            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            txtSearch.Text = ""

        End Try
        lblTotal.Text = "TOTAL ENTRY: " + dgvStudents.RowCount.ToString
    End Sub
    Private Sub Form_StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetData()
        cmbboxFilter.Text = "None"
        txtSearch.Focus()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        cmbboxFilter.Text = "None"
        Form_Main.Show()
    End Sub
    Private Sub btnAddNewStudent_Click(sender As Object, e As EventArgs) Handles btnAddNewStudent.Click
        Form_AddNewStudent.Show()
        Form_AddNewStudent.txtStudentNo.Focus()
        Me.Hide()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()

        If txtSearch.Text = "" Then
            GetData()
        ElseIf cmbboxFilter.Text = "Student No" Then
            con.Open()
            da = New OleDbDataAdapter("spGetStudentByStudentNo", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@student_no", txtSearch.Text & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Full Name" Then
            con.Open()
            da = New OleDbDataAdapter("spGetStudentByFullName", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@full_name", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Gender" Then

            Dim genderNumber As Integer

            If txtSearch.Text = "M" Or txtSearch.Text = "m" Then
                genderNumber = 1
            ElseIf txtSearch.Text = "F" Or txtSearch.Text = "f" Then
                genderNumber = 0
            End If

            con.Open()
            da = New OleDbDataAdapter("spGetStudentByGender", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@gender", "%" & genderNumber & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Date of Birth" Then

            con.Open()
            da = New OleDbDataAdapter("spGetStudentByDateOfBirth", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@date_of_birth", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Age" Then
            con.Open()
            da = New OleDbDataAdapter("spGetStudentByAge", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@age", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Address" Then
            con.Open()
            da = New OleDbDataAdapter("spGetStudentByAddress", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@address", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Contact Number" Then
            con.Open()
            da = New OleDbDataAdapter("spGetStudentByContactNumber", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@contact_number", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Year Level" Then

            Dim yearLevelNumber As Integer

            If txtSearch.Text = "1st" Then
                yearLevelNumber = 0
            ElseIf txtSearch.Text = "2nd" Then
                yearLevelNumber = 1
            ElseIf txtSearch.Text = "3rd" Then
                yearLevelNumber = 2
            ElseIf txtSearch.Text = "4th" Then
                yearLevelNumber = 3
            ElseIf txtSearch.Text = "5th" Then
                yearLevelNumber = 4
            End If


            con.Open()
            da = New OleDbDataAdapter("spGetStudentByYearLevel", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@year_level", "%" & yearLevelNumber & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Course" Then
            con.Open()
            da = New OleDbDataAdapter("spGetStudentByCourse", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@course", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Status" Then

            Dim statusNumber As Integer

            If txtSearch.Text = "Allowed" Or txtSearch.Text = "allowed" Then
                statusNumber = 0
            ElseIf txtSearch.Text = "Not Allowed" Or txtSearch.Text = "not allowed" Then
                statusNumber = 1

            End If

            con.Open()
            da = New OleDbDataAdapter("spGetStudentByStatus", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@status", "%" & statusNumber & "%")
            da.Fill(ds)
            dgvStudents.DataSource = ds.Tables(0)


        End If

        dgvStudents.Columns(0).Visible = False
        dgvStudents.Columns(1).Width = 200
        dgvStudents.Columns(2).Width = 250
        dgvStudents.Columns(3).Width = 100
        dgvStudents.Columns(4).Width = 150
        dgvStudents.Columns(5).Width = 90
        dgvStudents.Columns(6).Width = 400
        dgvStudents.Columns(7).Width = 300
        dgvStudents.Columns(8).Width = 150
        dgvStudents.Columns(9).Width = 150
        dgvStudents.Columns(10).Width = 150


        con.Close()
        lblTotal.Text = "TOTAL ENTRY:" + dgvStudents.RowCount.ToString
    End Sub
    Private Sub cmbboxFilter_Leave(sender As Object, e As EventArgs) Handles cmbboxFilter.Leave
        If cmbboxFilter.Text = "" Then
            GetData()
            cmbboxFilter.Text = "None"
            txtSearch.Clear()
        End If
        txtSearch.Focus()
    End Sub
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        con.Open()
        Dim row As DataGridViewRow = dgvStudents.CurrentRow
        Try
            Me.Enabled = False
            Form_StudentProfile.Show()
            Form_StudentProfile.lblTitle.Focus()
            btnBack.Visible = False

            Form_StudentProfile.txtStudentNo.Text = row.Cells(1).Value.ToString()
            Form_StudentProfile.txtFullName.Text = row.Cells(2).Value.ToString()
            Dim getGender
            getGender = row.Cells(3).Value.ToString
            If getGender = 1 Then
                Form_StudentProfile.rbtnMale.Checked = True
            ElseIf getGender = 0 Then
                Form_StudentProfile.rbtnFemale.Checked = True
            End If
            Form_StudentProfile.dtpDateOfBirth.Value = row.Cells(4).Value.ToString
            Form_StudentProfile.txtAge.Text = row.Cells(5).Value.ToString()
            Form_StudentProfile.txtAddress.Text = row.Cells(6).Value.ToString()
            Form_StudentProfile.txtContactNumber.Text = row.Cells(7).Value.ToString()

            Dim getYearLevel
            getYearLevel = row.Cells(8).Value.ToString()

            If getYearLevel = 0 Then
                Form_StudentProfile.cmbboxYearLevel.Text = "1st"
            ElseIf getYearLevel = 1 Then
                Form_StudentProfile.cmbboxYearLevel.Text = "2nd"
            ElseIf getYearLevel = 2 Then
                Form_StudentProfile.cmbboxYearLevel.Text = "3rd"
            ElseIf getYearLevel = 3 Then
                Form_StudentProfile.cmbboxYearLevel.Text = "4th"
            ElseIf getYearLevel = 4 Then
                Form_StudentProfile.cmbboxYearLevel.Text = "5th"
            End If

            Form_StudentProfile.cmbboxCourse.Text = row.Cells(9).Value.ToString()

            Dim getStatus
            getStatus = row.Cells(10).Value.ToString()

            If getStatus = 0 Then
                Form_StudentProfile.cmbboxStatus.Text = "Allowed"
            ElseIf getStatus = 1 Then
                Form_StudentProfile.cmbboxStatus.Text = "Not Allowed"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Dim stringHolder As String = cmbboxFilter.Text
        Select Case stringHolder
            Case "None"
                If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case "Student No"
                If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            Case "Gender"
                If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            Case "Age"
                If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case "Year Level"
                If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case "Course"
                If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case "Status"
                If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
        End Select
    End Sub

    Private Sub dgvStudents_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvStudents.CellFormatting
        If e.ColumnIndex = 3 Then
            e.FormattingApplied = True
            Dim temp As String = dgvStudents.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

            Select Case temp
                Case 0
                    e.Value = "F"
                Case 1
                    e.Value = "M"

            End Select
        End If


        If e.ColumnIndex = 8 Then
            e.FormattingApplied = True
            Dim temp As String = dgvStudents.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            Select Case temp
                Case 0
                    e.Value = "1st"
                Case 1
                    e.Value = "2nd"
                Case 2
                    e.Value = "3rd"
                Case 3
                    e.Value = "4th"
                Case 4
                    e.Value = "5th"
            End Select
        End If

        If e.ColumnIndex = 10 Then
            e.FormattingApplied = True
            Dim temp As String = dgvStudents.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            Select Case temp
                Case 0
                    e.Value = "Allowed"
                Case 1
                    e.Value = "Not Allowed"
            End Select
        End If

    End Sub

    Private Sub cmbboxFilter_TextChanged(sender As Object, e As EventArgs) Handles cmbboxFilter.TextChanged
        txtSearch.Focus()
    End Sub

    Private Sub btnCourseList_Click(sender As Object, e As EventArgs) Handles btnCourseList.Click
        Me.Hide()
        Form_CourseList.txtSearch.Text = ""
        Form_CourseList.Show()
        Form_CourseList.txtSearch.Focus()
    End Sub
End Class
