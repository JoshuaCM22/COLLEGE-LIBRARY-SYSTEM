Imports System.Data.OleDb
Public Class Form_ForgotPassword
    Private Sub Form_ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Public Sub Reset()
        txtUsername.Focus()
        txtUsername.Clear()
        cmbboxSecretQuestion.Text = ""
        txtSecretAnswer.Clear()
        chckboxSecretAnswer.Checked = False
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtUsername.Text = ""
        cmbboxSecretQuestion.Text = ""
        txtSecretAnswer.Text = ""
        Form_Login.txtUsername.Text = ""
        Form_Login.txtPassword.Text = ""
        Form_Login.Show()
        Form_Login.txtUsername.Focus()
        Me.Hide()
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtUsername.Text = "" And cmbboxSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up account details", MsgBoxStyle.Critical, "ATTENTION")
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
        ElseIf cmbboxSecretQuestion.Text = "" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "ATTENTION")
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "ATTENTION")
        Else

            Try
                con.Open()
                cmd = New OleDbCommand("SELECT * FROM [tbl_admins] WHERE [username]=@username AND [secret_question]=@Secret_question", con) With {
                    .CommandType = CommandType.Text
                }
                cmd.Parameters.Add(New OleDbParameter("@username", txtUsername.Text))
                cmd.Parameters.Add(New OleDbParameter("@Secret_question", cmbboxSecretQuestion.Text))
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    If (BCrypt.Net.BCrypt.Verify(txtSecretAnswer.Text, dr.Item("secret_answer"))) Then
                        Form_SetANewPassword.userIDGetter = dr.Item("ID")
                        con.Close()
                        dr.Close()
                        Reset()
                        Me.Hide()
                        Form_SetANewPassword.Show()
                    Else
                        MsgBox("Your details is incorrect!", MsgBoxStyle.Critical, "ATTENTION")
                        dr.Close()
                        con.Close()
                        txtSecretAnswer.Clear()
                        txtSecretAnswer.Focus()
                    End If
                ElseIf dr.Read = False Then
                    MsgBox("Your details is incorrect!", MsgBoxStyle.Critical, "Error")
                    con.Close()
                    dr.Close()
                    Reset()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                con.Close()
            End Try


        End If
    End Sub
    Private Sub ChckboxSecretAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxSecretAnswer.CheckedChanged
        If chckboxSecretAnswer.Checked = False Then
            txtSecretAnswer.UseSystemPasswordChar = True
        Else
            txtSecretAnswer.UseSystemPasswordChar = False
        End If
        lblUsername.Focus()
    End Sub
    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        con.Open()
        cmd = New OleDbCommand("SELECT * FROM [tbl_admins] WHERE [username]=@username ", con) With {
            .CommandType = CommandType.Text
        }
        cmd.Parameters.Add(New OleDbParameter("@username", txtUsername.Text))
        dr = cmd.ExecuteReader()
        If dr.Read Then
            cmbboxSecretQuestion.Text = dr("secret_question").ToString
        Else
            cmbboxSecretQuestion.Text = ""
        End If
        con.Close()
    End Sub
    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtSecretAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecretAnswer.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class