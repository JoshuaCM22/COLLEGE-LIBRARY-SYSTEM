Imports System.Data.OleDb
Public Class Form_AddNewStudent
    Dim gender As Integer
    Dim yearLevel As Integer
    Dim courseID As Integer
    Private Sub Reset()
        txtStudentNo.Focus()
        txtStudentNo.Clear()
        txtFullName.Clear()
        rbtnMale.Checked = False
        rbtnFemale.Checked = False
        cmbboxMonth.Text = "Month"
        cmbboxDay.Text = "Day"
        txtYear.Text = "Year"
        txtAge.Clear()
        txtAddress.Clear()
        txtContactNumber.Clear()
        cmbboxYearLevel.Text = ""
    End Sub
    Private Sub Form_AddNewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        RetrieveAllCourses()
    End Sub

    Public Sub RetrieveAllCourses()
        Try
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


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtStudentNo.Text = "" Then
            MsgBox("No Student No Found!", MsgBoxStyle.Critical, "Error")
            txtStudentNo.Focus()
        ElseIf txtFullName.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
            txtFullName.Focus()
        ElseIf rbtnMale.Checked = False And rbtnFemale.Checked = False Then
            MsgBox("No Gender Found!", MsgBoxStyle.Critical, "Error")
        ElseIf cmbboxMonth.Text = "Month" Then
            MsgBox("No Month Found!", MsgBoxStyle.Critical, "Error")
            cmbboxMonth.Focus()
        ElseIf cmbboxDay.Text = "Day" Then
            MsgBox("No Day Found!", MsgBoxStyle.Critical, "Error")
            cmbboxDay.Focus()
        ElseIf txtYear.Text = "Year" Then
            MsgBox("No Year Found!", MsgBoxStyle.Critical, "Error")
            txtYear.Focus()
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

        Else
            ValidationForStudentNo()
        End If
    End Sub

    Public Sub ValidationForStudentNo()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_students] WHERE [student_no] = @student_no", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@student_no", txtStudentNo.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                MsgBox("This Student No is already exist. Please try different Student No!", MsgBoxStyle.Critical, "ATTENTION")
                dr.Close()
                con.Close()
            ElseIf dr.Read = False Then
                dr.Close()
                con.Close()
                Inserting()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())


        End Try
    End Sub

    Public Sub Inserting()
        Try
            Dim combine As String
            combine = cmbboxMonth.Text & Space(1) + cmbboxDay.Text + (",") & Space(1) + txtYear.Text

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
            cmd = New OleDbCommand("SELECT * FROM [tbl_courses]", con) With {
    .CommandType = CommandType.Text
}
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                courseID = dr.Item("ID")
            End If

            dr.Close()
            con.Close()


            con.Open()
            cmd = New OleDbCommand("spInsertNewStudent", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New OleDbParameter("@student_no", txtStudentNo.Text))
            cmd.Parameters.Add(New OleDbParameter("@full_name", txtFullName.Text))
            cmd.Parameters.Add(New OleDbParameter("@gender", gender))
            cmd.Parameters.Add(New OleDbParameter("@date_of_birth", combine))
            cmd.Parameters.Add(New OleDbParameter("@age", txtAge.Text))
            cmd.Parameters.Add(New OleDbParameter("@address", txtAddress.Text))
            cmd.Parameters.Add(New OleDbParameter("@contact_number", txtContactNumber.Text))
            cmd.Parameters.Add(New OleDbParameter("@year_level", yearLevel))
            cmd.Parameters.Add(New OleDbParameter("@course_id", courseID))
            cmd.Parameters.Add(New OleDbParameter("@status", 0))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("SUCCESSFULLY ADDED", MsgBoxStyle.Information, "ATTENTION")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            Reset()
            cmbboxCourse.Items.Clear()
            RetrieveAllCourses()
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "BACK" Then
            Me.Hide()
            Reset()
            Form_StudentList.GetData()
            Form_StudentList.Show()
        Else
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_StudentList.GetData()
                Form_StudentList.Show()
            End If
        End If
    End Sub
    Private Sub rbtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMale.CheckedChanged
        gender = 1
    End Sub
    Private Sub rbtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFemale.CheckedChanged
        gender = 0
    End Sub
    Private Sub CmbboxMonth_Click(sender As Object, e As EventArgs) Handles cmbboxMonth.Click
        Me.cmbboxMonth.Text = ""
    End Sub
    Private Sub CmbboxMonth_Layout(sender As Object, e As LayoutEventArgs) Handles cmbboxMonth.Layout
        Me.cmbboxMonth.Text = "Month"
    End Sub
    Private Sub CmbboxMonth_Leave(sender As Object, e As EventArgs) Handles cmbboxMonth.Leave
        If cmbboxMonth.Text = "" Then
            Me.cmbboxMonth.Text = "Month"
        End If
    End Sub

    Private Sub CmbboxYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        Dim todayYear As Integer = Today.Year
        Dim todayDay As Integer = Today.Day
        Dim todayMonth As Integer = Today.Month
        Dim getValueOfYear As Integer = Val(txtYear.Text)
        Dim getValueOfDay As Integer = Val(cmbboxDay.Text)
        Dim getValueOfMonth As String = cmbboxMonth.SelectedIndex + 1
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
    Private Sub CmbboxYear_Layout(sender As Object, e As LayoutEventArgs) Handles txtYear.Layout
        Me.txtYear.Text = "Year"
    End Sub
    Private Sub CmbboxYear_Click(sender As Object, e As EventArgs) Handles txtYear.Click
        Me.txtYear.Clear()
    End Sub
    Private Sub CmbboxYear_Leave(sender As Object, e As EventArgs) Handles txtYear.Leave
        If txtYear.Text = "" Then
            Me.txtYear.Text = "Year"
        End If
    End Sub
    Private Sub CmbboxDay_Click(sender As Object, e As EventArgs) Handles cmbboxDay.Click
        Me.cmbboxDay.Text = ""
    End Sub
    Private Sub CmbboxDay_Layout(sender As Object, e As LayoutEventArgs) Handles cmbboxDay.Layout
        Me.cmbboxDay.Text = "Day"
    End Sub
    Private Sub CmbboxDay_Leave(sender As Object, e As EventArgs) Handles cmbboxDay.Leave
        If cmbboxDay.Text = "" Then
            Me.cmbboxDay.Text = "Day"
        End If
    End Sub
    Private Sub txtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNo.TextChanged
        If txtStudentNo.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
    Private Sub txtStudentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentNo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtAge_Leave(sender As Object, e As EventArgs) Handles txtAge.Leave
        If txtAge.Text = "2021" Then
            Me.txtAge.Clear()
        End If
    End Sub
End Class