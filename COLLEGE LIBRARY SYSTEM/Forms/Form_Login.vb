Imports System.Data.OleDb
Public Class Form_Login
    Public Sub Reset()
        txtUsername.Select()
        chckboxShowPassword.Checked = False
        txtUsername.Clear()
        txtPassword.Clear()
        AcceptButton = btnLogin
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Form_Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnForgotPassword.PerformClick()
        End If
    End Sub
    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUsername.Text = "" And txtPassword.Text = "" Then
                MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtUsername.Text = "" Then
                MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtPassword.Focus()
            Else
                lblPassword.Focus()
                LoginValidation()
            End If
        End If
    End Sub
    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUsername.Text = "" And txtPassword.Text = "" Then
                MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtUsername.Text = "" Then
                MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtPassword.Focus()
            Else
                lblPassword.Focus()
                LoginValidation()
            End If
        End If
    End Sub
    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub ChckboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPassword.CheckedChanged
        If chckboxShowPassword.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
        lblUsername.Focus()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtPassword.Focus()
        Else
            lblPassword.Focus()
            LoginValidation()
        End If
    End Sub
    Private Sub LoginValidation()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_admins] WHERE [username] = @username", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                If (BCrypt.Net.BCrypt.Verify(txtPassword.Text, dr.Item("password"))) Then

                    Form_Main.userIdGetter = dr.Item("ID")
                    Form_Main.usernameGetter = txtUsername.Text
                    Form_Main.passwordGetter = txtPassword.Text
                    dr.Close()
                    con.Close()
                    Me.Hide()

                    Form_Main.Show()
                Else
                    MsgBox("Incorrect Username And/Or Password!", MsgBoxStyle.Critical, "ATTENTION")
                    txtPassword.Clear()
                    txtPassword.Focus()
                End If
            ElseIf dr.Read = False Then
                dr.Close()
                con.Close()
                MsgBox("Incorrect Username And/Or Password!", MsgBoxStyle.Critical, "ATTENTION")
                Reset()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Me.Hide()
        Form_ForgotPassword.Show()
        Form_ForgotPassword.txtUsername.Focus()
    End Sub
End Class