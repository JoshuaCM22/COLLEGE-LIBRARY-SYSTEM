Imports System.Data.OleDb
Public Class Form_ChangePassword
    Public passwordGetter As String
    Public Sub Reset()
        txtCurrentPassword.Focus()
        txtCurrentPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmNewPassword.Clear()
        chckbox_ShowPassword1.Checked = False
        chckbox_ShowPassword2.Checked = False
    End Sub
    Private Sub Form_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Form_ChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
        End If
    End Sub
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtCurrentPassword.Text = "" And txtNewPassword.Text = "" And txtConfirmNewPassword.Text = "" Then
            MsgBox("Fill up your password details", MsgBoxStyle.Critical, "ATTENTION")
            txtCurrentPassword.Focus()
        ElseIf txtCurrentPassword.Text = "" Then
            MsgBox("No Current Password Found!", MsgBoxStyle.Critical, "Error")
            txtCurrentPassword.Focus()
        ElseIf txtNewPassword.Text = "" Then
            MsgBox("No New Password Found!", MsgBoxStyle.Critical, "Error")
            txtNewPassword.Focus()
        ElseIf txtConfirmNewPassword.Text = "" Then
            MsgBox("No Confirm New Password Found!", MsgBoxStyle.Critical, "Error")
            txtConfirmNewPassword.Focus()
        Else
            Try
                con.Open()
                cmd = New OleDbCommand("SELECT * FROM [tbl_admins] WHERE [username]=@username", con) With {
                    .CommandType = CommandType.Text
                }
                cmd.Parameters.Add(New OleDbParameter("@username", Form_Main.usernameGetter))
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    If (BCrypt.Net.BCrypt.Verify(txtCurrentPassword.Text, dr.Item("password"))) Then
                        dr.Close()
                        con.Close()
                        Comparing()
                    Else
                        dr.Close()
                        con.Close()
                        MsgBox("Current Password is incorrect!", MsgBoxStyle.Critical, "Error")
                        txtCurrentPassword.Clear()
                        txtCurrentPassword.Focus()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub Comparing()
        If Not txtNewPassword.Text = txtConfirmNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not the same!", MsgBoxStyle.Critical, "Error")
        ElseIf Not txtConfirmNewPassword.Text = txtNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not the same!", MsgBoxStyle.Critical, "Error")
        Else
            Try
                con.Open()
                cmd = New OleDbCommand("SELECT * FROM [tbl_admins] WHERE [username]=@username", con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add(New OleDbParameter("@username", Form_Main.usernameGetter))
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    If (BCrypt.Net.BCrypt.Verify(txtConfirmNewPassword.Text, dr.Item("password"))) Then
                        MsgBox("Your New Password and Confirm New Password is currently used. Please try another password!", MsgBoxStyle.Critical, "ATTENTION")
                    Else
                        dr.Close()
                        con.Close()
                        Updating()
                    End If
                End If
                dr.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Public Sub Updating()
        Try
            con.Open()
            cmd = New OleDbCommand("UPDATE [tbl_admins] set [password]=@password WHERE [username]=@username", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New OleDbParameter("@password", BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text)))
            cmd.Parameters.Add(New OleDbParameter("@username", Form_Main.usernameGetter))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("SUCCESSFULLY CHANGED YOUR PASSWORD", MsgBoxStyle.Information, "ATTENTION")
            passwordGetter = txtNewPassword.Text
            txtCurrentPassword.Clear()
            txtNewPassword.Clear()
            txtConfirmNewPassword.Clear()
            chckbox_ShowPassword1.Checked = False
            chckbox_ShowPassword2.Checked = False
            Me.Hide()
            Form_Main.BringToFront()
            Form_Main.Show()
            Form_Main.Reset()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "BACK" Then
            Reset()
            Form_Main.BringToFront()
            Form_Main.Show()
            Form_Main.lblTitle.Focus()
            Me.Hide()
        Else
            Dim question As String
            question = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If question = vbYes Then
                Reset()
                Form_Main.BringToFront()
                Form_Main.Show()
                Form_Main.lblTitle.Focus()
                Form_Main.Reset()
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub txtCurrentPassword_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentPassword.TextChanged
        If txtCurrentPassword.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
    Private Sub txtConfirmNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCurrentPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrentPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub chckbox_ShowPassword1_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowPassword1.CheckedChanged
        If chckbox_ShowPassword1.Checked = False Then
            txtCurrentPassword.UseSystemPasswordChar = True
        Else
            txtCurrentPassword.UseSystemPasswordChar = False
        End If
        lblCurrentPassword.Focus()
    End Sub
    Private Sub chckbox_ShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowPassword2.CheckedChanged
        If chckbox_ShowPassword2.Checked = False Then
            txtNewPassword.UseSystemPasswordChar = True
            txtConfirmNewPassword.UseSystemPasswordChar = True
        Else
            txtNewPassword.UseSystemPasswordChar = False
            txtConfirmNewPassword.UseSystemPasswordChar = False
        End If
        lblCurrentPassword.Focus()
    End Sub
End Class