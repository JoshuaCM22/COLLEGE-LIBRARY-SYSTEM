Imports System.Data.OleDb
Public Class Form_AddNewCourse
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Validation()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "CANCEL" = True Then
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_CourseList.GetData()
                Form_CourseList.Show()
                Form_CourseList.BringToFront()
                Form_CourseList.txtSearch.Focus()
            End If
        Else
            Me.Hide()
            Reset()
            Form_CourseList.GetData()
            Form_CourseList.Show()
            Form_CourseList.BringToFront()
            Form_CourseList.txtSearch.Focus()
        End If
    End Sub

    Public Sub Reset()
        txtCourse.Text = ""
        txtCourse.Focus()
    End Sub

    Public Sub Validation()
        If txtCourse.Text = "" Then
            MsgBox("No Course Found!", MsgBoxStyle.Critical, "Error")
            txtCourse.Focus()
        Else
            ValidationForCourse()
        End If
    End Sub

    Public Sub ValidationForCourse()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_courses] WHERE [course] = @course", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@course", txtCourse.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                MsgBox("This Course is already exist. Please try different Course!", MsgBoxStyle.Critical, "ATTENTION")
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

            con.Open()
            cmd = New OleDbCommand("spInsertNewCourse", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New OleDbParameter("@course", txtCourse.Text))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("SUCCESSFULLY ADDED", MsgBoxStyle.Information, "ATTENTION")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            Reset()
        End Try
    End Sub

    Private Sub Form_AddCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged
        If txtCourse.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
End Class