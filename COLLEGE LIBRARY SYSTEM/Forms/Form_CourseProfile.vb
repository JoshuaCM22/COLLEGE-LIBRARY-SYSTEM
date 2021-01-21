Imports System.Data.OleDb

Public Class Form_CourseProfile
    Public courseID As Integer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If btnBack.Text = "CANCEL" = True Then
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_CourseList.Show()
                Form_CourseList.GetData()
                Form_CourseList.txtSearch.Focus()
            End If
        Else
            Me.Hide()
            Reset()
            Form_CourseList.Show()
            Form_CourseList.GetData()
            Form_CourseList.txtSearch.Focus()
        End If

    End Sub

    Private Sub Reset()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = True
        btnBack.Text = "CLOSE"
        txtCourse.Enabled = False
    End Sub

    Private Sub Form_CourseProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        txtCourse.Enabled = True
        btnBack.Text = "CANCEL"
    End Sub

    Public Sub Validation()
        If txtCourse.Text = "" Then
            MsgBox("No Course Found!", MsgBoxStyle.Critical, "Error")
            txtCourse.Focus()
        Else
            Updating()
        End If
    End Sub

    Public Sub Updating()
        Try

            con.Open()
            cmd = New OleDbCommand("spUpdateExistingCourse", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New OleDbParameter("@course", txtCourse.Text))
            cmd.Parameters.Add(New OleDbParameter("@id", courseID))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information, "ATTENTION")
            Reset()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to update ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Validation()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to delete ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Try


                con.Open()
                cmd = New OleDbCommand("spDeleteExistingCourse", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                cmd.Parameters.AddWithValue("@course", txtCourse.Text)
                cmd.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY DELETED", MsgBoxStyle.Information, "ATTENTION")
                con.Close()
                Reset()
                Me.Hide()
                Form_CourseList.Show()
                Form_CourseList.GetData()
                Form_CourseList.BringToFront()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class