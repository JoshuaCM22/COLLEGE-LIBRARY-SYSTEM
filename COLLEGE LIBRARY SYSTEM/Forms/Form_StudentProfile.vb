Imports System.Data.OleDb
Public Class Form_StudentProfile
    Dim gender As Integer
    Dim yearLevel As Integer
    Dim course As Integer
    Dim status As Integer

    Private Sub Reset()
        txtStudentNo.Enabled = False
        txtFullName.Enabled = False
        rbtnMale.Enabled = False
        rbtnFemale.Enabled = False
        dtpDateOfBirth.Enabled = False
        txtAge.Enabled = False
        txtAddress.Enabled = False
        txtContactNumber.Enabled = False
        cmbboxYearLevel.Enabled = False
        cmbboxCourse.Enabled = False
        cmbboxStatus.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = True
        btnClose.Text = "CLOSE"
    End Sub
    Private Sub Form_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        RetrieveAllCourses()
    End Sub
    Public Sub RetrieveAllCourses()
        Try
            con.Close()
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_courses]", con) With {
            .CommandType = CommandType.Text
        }
            dr = cmd.ExecuteReader()
            While dr.Read()
                cmbboxCourse.Items.Add(dr("course"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        txtFullName.Enabled = True
        rbtnMale.Enabled = True
        rbtnFemale.Enabled = True
        dtpDateOfBirth.Enabled = True
        txtAge.Enabled = True
        txtAddress.Enabled = True
        txtContactNumber.Enabled = True
        cmbboxYearLevel.Enabled = True
        cmbboxCourse.Enabled = True
        cmbboxStatus.Enabled = True
        btnClose.Text = "CANCEL"
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to update ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Validation()
        End If
    End Sub
    Public Sub Validation()
        If txtFullName.Text = "" And rbtnMale.Checked = False And rbtnFemale.Checked = False And dtpDateOfBirth.Value = Date.Now.ToString("MMMM dd, yyyy") And txtAge.Text = "" And txtAddress.Text = "" And txtContactNumber.Text = "" And cmbboxYearLevel.Text = "" And cmbboxCourse.Text = "" And cmbboxStatus.Text = "" Then
            MsgBox("Fill up all the details", MsgBoxStyle.Critical, "ATTENTION")
            txtFullName.Focus()
        ElseIf txtFullName.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
            txtFullName.Focus()
        ElseIf rbtnMale.Checked = False And rbtnFemale.Checked = False Then
            MsgBox("No Gender Found!", MsgBoxStyle.Critical, "Error")
        ElseIf dtpDateOfBirth.Value = Date.Now.ToString("MMMM dd, yyyy") Then
            MsgBox("Date today is not valid!", MsgBoxStyle.Critical, "Error")
            dtpDateOfBirth.Focus()
        ElseIf txtAge.Text = "" Then
            MsgBox("No Age Found!", MsgBoxStyle.Critical, "Error")
            txtAge.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("No Address Found!", MsgBoxStyle.Critical, "Error")
            txtAddress.Focus()
        ElseIf txtContactNumber.Text = "" Then
            MsgBox("No Contact Number Found!", MsgBoxStyle.Critical, "Error")
            txtContactNumber.Focus()
        ElseIf cmbboxYearLevel.Text = "" Then
            MsgBox("No Year Level Found!", MsgBoxStyle.Critical, "Error")
            cmbboxYearLevel.Focus()
        ElseIf cmbboxCourse.Text = "" Then
            MsgBox("No Course Found!", MsgBoxStyle.Critical, "Error")
            cmbboxCourse.Focus()
        ElseIf cmbboxStatus.Text = "" Then
            MsgBox("No Status Found!", MsgBoxStyle.Critical, "Error")
            cmbboxStatus.Focus()
        Else
            Updating()
        End If
    End Sub

    Public Sub Updating()
        Try

            If rbtnMale.Checked = True Then
                gender = 1
            End If

            If rbtnFemale.Checked = True Then
                gender = 0
            End If


            If cmbboxYearLevel.Text = "1st" Then
                yearLevel = 0
            ElseIf cmbboxYearLevel.Text = "2nd" Then
                yearLevel = 1
            ElseIf cmbboxYearLevel.Text = "3rd" Then
                yearLevel = 2
            ElseIf cmbboxYearLevel.Text = "4th" Then
                yearLevel = 3
            ElseIf cmbboxYearLevel.Text = "5th" Then
                yearLevel = 4
            End If


            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_courses] WHERE [course]=@course", con) With {
            .CommandType = CommandType.Text
        }
            cmd.Parameters.AddWithValue("@course", cmbboxCourse.Text)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                course = dr.Item("ID")
            End If

            dr.Close()
            con.Close()



            If cmbboxStatus.Text = "Allowed" Then
                status = 0
            ElseIf cmbboxStatus.Text = "Not Allowed" Then
                status = 1
            End If

            con.Open()
            cmd = New OleDbCommand("spUpdateExistingStudent", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New OleDbParameter("@full_name", txtFullName.Text))
            cmd.Parameters.Add(New OleDbParameter("@gender", gender))
            cmd.Parameters.Add(New OleDbParameter("@date_of_birth", dtpDateOfBirth.Value.ToString("MMMM dd, yyyy")))
            cmd.Parameters.Add(New OleDbParameter("@age", txtAge.Text))
            cmd.Parameters.Add(New OleDbParameter("@address", txtAddress.Text))
            cmd.Parameters.Add(New OleDbParameter("@contact_number", txtContactNumber.Text))
            cmd.Parameters.Add(New OleDbParameter("@year_level", yearLevel))
            cmd.Parameters.Add(New OleDbParameter("@course_id", course))
            cmd.Parameters.Add(New OleDbParameter("@status", status))
            cmd.Parameters.Add(New OleDbParameter("@student_no", txtStudentNo.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information, "ATTENTION")
            Reset()
            Form_StudentList.GetData()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to delete ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Try
                con.Open()
                cmd = New OleDbCommand("spDeleteExistingStudent", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                cmd.Parameters.AddWithValue("@student_no", txtStudentNo.Text)
                cmd.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY DELETED", MsgBoxStyle.Information, "ATTENTION")
                con.Close()
                Reset()
                Me.Hide()
                Form_StudentList.GetData()
                Form_StudentList.Enabled = True
                Form_StudentList.btnBack.Visible = True
                Form_StudentList.BringToFront()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "CANCEL" = True Then
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_StudentList.Enabled = True
                Form_StudentList.btnBack.Visible = True
                Form_StudentList.Show()
                Form_StudentList.BringToFront()
            End If
        Else
            Me.Hide()
            Form_StudentList.Enabled = True
            Form_StudentList.btnBack.Visible = True
            Form_StudentList.Show()
            Form_StudentList.BringToFront()
        End If
    End Sub

    Private Sub rbtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMale.CheckedChanged
        gender = 1
    End Sub
    Private Sub rbtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFemale.CheckedChanged
        gender = 0
    End Sub




    Private Sub TxtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtpDateOfBirth_Leave(sender As Object, e As EventArgs) Handles dtpDateOfBirth.Leave
        Dim todayYear As Integer = Today.Year
        Dim todayDay As Integer = Today.Day
        Dim todayMonth As Integer = Today.Month
        Dim getValueOfYear As Integer = dtpDateOfBirth.Value.ToString("yyyy")
        Dim getValueOfDay As Integer = dtpDateOfBirth.Value.ToString("dd")
        Dim getValueOfMonth As String = dtpDateOfBirth.Value.ToString("MM")
        Dim finalOutput As Integer = todayYear - getValueOfYear
        If todayMonth = getValueOfMonth Then
            If todayDay < getValueOfDay Then
                finalOutput -= 1
            End If
        ElseIf todayMonth < getValueOfMonth Then
            finalOutput -= 1
        End If
        txtAge.Text = finalOutput
    End Sub
End Class