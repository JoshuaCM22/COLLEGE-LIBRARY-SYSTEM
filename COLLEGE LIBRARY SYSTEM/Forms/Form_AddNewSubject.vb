Imports System.Data.OleDb
Public Class Form_AddNewSubject
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
                Form_SubjectList.GetData()
                Form_SubjectList.Show()
                Form_SubjectList.BringToFront()
                Form_SubjectList.txtSearch.Focus()
            End If
        Else
            Me.Hide()
            Reset()
            Form_SubjectList.GetData()
            Form_SubjectList.Show()
            Form_SubjectList.BringToFront()
            Form_SubjectList.txtSearch.Focus()
        End If
    End Sub

    Public Sub Reset()
        txtSubject.Text = ""
        txtSubject.Focus()
    End Sub

    Public Sub Validation()
        If txtSubject.Text = "" Then
            MsgBox("No Subject Found!", MsgBoxStyle.Critical, "Error")
            txtSubject.Focus()
        Else
            ValidationForSubject()
        End If
    End Sub

    Public Sub ValidationForSubject()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_subjects] WHERE [subject] = @subject", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                MsgBox("This Subject is already exist. Please try different Subject!", MsgBoxStyle.Critical, "ATTENTION")
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
            cmd = New OleDbCommand("spInsertNewSubject", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New OleDbParameter("@subject", txtSubject.Text))

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

    Private Sub Form_AddSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs) Handles txtSubject.TextChanged
        If txtSubject.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
End Class