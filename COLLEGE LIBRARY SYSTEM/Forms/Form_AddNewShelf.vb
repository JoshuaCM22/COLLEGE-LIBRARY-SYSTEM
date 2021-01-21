Imports System.Data.OleDb
Public Class Form_AddNewShelf
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
                Form_ShelfList.GetData()
                Form_ShelfList.Show()
                Form_ShelfList.BringToFront()
                Form_ShelfList.txtSearch.Focus()
            End If
        Else
            Me.Hide()
            Reset()
            Form_ShelfList.GetData()
            Form_ShelfList.Show()
            Form_ShelfList.BringToFront()
            Form_ShelfList.txtSearch.Focus()
        End If
    End Sub

    Public Sub Reset()
        txtShelf.Text = ""
        txtShelf.Focus()
    End Sub

    Public Sub Validation()
        If txtShelf.Text = "" Then
            MsgBox("No Shelf Found!", MsgBoxStyle.Critical, "Error")
            txtShelf.Focus()
        Else
            ValidationForShelf()
        End If
    End Sub

    Public Sub ValidationForShelf()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_shelfs] WHERE [shelf] = @shelf", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@shelf", txtShelf.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                MsgBox("This Shelf is already exist. Please try different Shelf!", MsgBoxStyle.Critical, "ATTENTION")
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
            cmd = New OleDbCommand("spInsertNewShelf", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New OleDbParameter("@shelf", txtShelf.Text))

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

    Private Sub Form_AddShelf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub txtShelf_TextChanged(sender As Object, e As EventArgs) Handles txtShelf.TextChanged
        If txtShelf.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
End Class