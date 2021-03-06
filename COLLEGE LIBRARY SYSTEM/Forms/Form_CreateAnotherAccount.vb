﻿Imports System.Data.OleDb
Public Class Form_CreateAnotherAccount
    Private Sub Reset()

        txtUsername.Clear()
        txtPassword.Clear()
        cmbboxSecretQuestion.Text = "None"
        txtSecretAnswer.Clear()
        chckbox_ShowPassword.Checked = False
        chckbox_ShowSecretAnswer.Checked = False
    End Sub
    Private Sub Form_CreateAnotherAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Form_CreateAnotherAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnRegister.PerformClick()
        End If
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" And txtPassword.Text = "" And cmbboxSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up your account details", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "Error")
            txtPassword.Focus()
        ElseIf txtFullName.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
            txtFullName.Focus()
        ElseIf cmbboxSecretQuestion.Text = "None" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "Error")
            cmbboxSecretQuestion.Focus()
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "Error")
            txtSecretAnswer.Focus()
        Else
            CheckingUsername()
        End If
    End Sub
    Private Sub CheckingUsername()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT [username] FROM [tbl_admins] WHERE [username]=@username ", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New OleDbParameter("@username", txtUsername.Text))
            dr = cmd.ExecuteReader()
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            Select Case count
                Case 1
                    MsgBox("Username is already exist. Please try another username!", MsgBoxStyle.Critical, "ATTENTION")
                Case Else
                    con.Close()
                    dr.Close()
                    CreatingAccount()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub CreatingAccount()
        Try
            con.Open()
            cmd = New OleDbCommand("spInsertNewAdmin", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New OleDbParameter("@username", txtUsername.Text))
            cmd.Parameters.Add(New OleDbParameter("@password", BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)))
            cmd.Parameters.Add(New OleDbParameter("@full_name", txtFullName.Text))
            cmd.Parameters.Add(New OleDbParameter("@secret_question", cmbboxSecretQuestion.Text))
            cmd.Parameters.Add(New OleDbParameter("@secret_answer", BCrypt.Net.BCrypt.HashPassword(txtSecretAnswer.Text)))
            cmd.ExecuteNonQuery()
            MsgBox("SUCCESSFULLY REGISTERED", MsgBoxStyle.Information, "ATTENTION")
            con.Close()
            Reset()
            Me.Hide()
            Form_Main.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Reset()
        Form_Main.Show()
    End Sub
    Private Sub chckbox_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowPassword.CheckedChanged
        If chckbox_ShowPassword.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
        lblUsername.Focus()
    End Sub
    Private Sub chckbox_ShowSecretAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowSecretAnswer.CheckedChanged
        If chckbox_ShowSecretAnswer.Checked = False Then
            txtSecretAnswer.UseSystemPasswordChar = True
        Else
            txtSecretAnswer.UseSystemPasswordChar = False
        End If
        lblUsername.Focus()
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class