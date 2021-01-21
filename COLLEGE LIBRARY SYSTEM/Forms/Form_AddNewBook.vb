Imports System.Data.OleDb
Public Class Form_AddNewBook
    Dim subjectID As Integer
    Dim shelfID As Integer
    Private Sub Reset()
        txtBookNo.Focus()
        txtBookNo.Clear()
        txtTitle.Clear()
        txtAuthors.Clear()
        txtPublisher.Clear()
        txtCopyrightYear.Clear()
        txtOriginalTotalPages.Clear()
        txtCurrentTotalPages.Clear()
        txtQuantity.Clear()
    End Sub
    Private Sub Form_AddNewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        RetrieveAllSubjects()
        RetrieveAllShelfs()
    End Sub


    Public Sub RetrieveAllSubjects()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_subjects]", con) With {
            .CommandType = CommandType.Text
        }
            dr = cmd.ExecuteReader()
            While dr.Read()
                cmbboxSubject.Items.Add(dr("subject"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub

    Public Sub RetrieveAllShelfs()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_shelfs]", con) With {
            .CommandType = CommandType.Text
        }
            dr = cmd.ExecuteReader()
            While dr.Read()
                cmbboxShelf.Items.Add(dr("shelf"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtBookNo.Text = "" Then
            MsgBox("No Book No Found!", MsgBoxStyle.Critical, "Error")
            txtBookNo.Focus()
        ElseIf txtTitle.Text = "" Then
            MsgBox("No Title Found!", MsgBoxStyle.Critical, "Error")
            txtTitle.Focus()
        ElseIf txtAuthors.Text = "" Then
            MsgBox("No Authors Found!", MsgBoxStyle.Critical, "Error")
            txtAuthors.Focus()
        ElseIf txtPublisher.Text = "" Then
            MsgBox("No Publisher Found!", MsgBoxStyle.Critical, "Error")
            txtPublisher.Focus()
        ElseIf txtCopyrightYear.Text = "" Then
            MsgBox("No Copyright Year Found!", MsgBoxStyle.Critical, "Error")
            txtCopyrightYear.Focus()

        ElseIf txtOriginalTotalPages.Text = "" Then
            MsgBox("No Original Total Pages Found!", MsgBoxStyle.Critical, "Error")
            txtOriginalTotalPages.Focus()

        ElseIf txtCurrentTotalPages.Text = "" Then
            MsgBox("No Current Total Pages Found!", MsgBoxStyle.Critical, "Error")
            txtCurrentTotalPages.Focus()

        ElseIf txtQuantity.Text = "" Then
            MsgBox("No Quantity Found!", MsgBoxStyle.Critical, "Error")
            txtQuantity.Focus()

        ElseIf cmbboxShelf.Text = "" Then
            MsgBox("No Shelf Found!", MsgBoxStyle.Critical, "Error")
            cmbboxShelf.Focus()
        Else
            ValidationForBookNo()
        End If
    End Sub

    Public Sub ValidationForBookNo()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_books] WHERE [book_no] = @book_no", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@book_no", txtBookNo.Text)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                MsgBox("This Book No is already exist. Please try different Book No!", MsgBoxStyle.Critical, "ATTENTION")
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
            cmd = New OleDbCommand("SELECT * FROM [tbl_subjects] WHERE [subject]=@subject", con) With {
            .CommandType = CommandType.Text
        }
            cmd.Parameters.AddWithValue("@subject", cmbboxSubject.Text)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                subjectID = dr.Item("ID")
            End If

            cmd.Dispose()
            dr.Close()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_shelfs] WHERE [shelf]=@shelf", con) With {
            .CommandType = CommandType.Text
        }
            cmd.Parameters.AddWithValue("@shelf", cmbboxShelf.Text)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                shelfID = dr.Item("ID")
            End If

            cmd.Dispose()
            dr.Close()
            con.Close()


            Dim dateNow As String = Form_Main.lblDateToday.Text
            Dim timeNow As String = Form_Main.lblTimeNow.Text


            con.Open()
            cmd = New OleDbCommand("spInsertNewBook", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New OleDbParameter("@book_no", txtBookNo.Text))
            cmd.Parameters.Add(New OleDbParameter("@full_name", txtTitle.Text))
            cmd.Parameters.Add(New OleDbParameter("@subject_id", subjectID))
            cmd.Parameters.Add(New OleDbParameter("@authors", txtAuthors.Text))
            cmd.Parameters.Add(New OleDbParameter("@publisher", txtPublisher.Text))
            cmd.Parameters.Add(New OleDbParameter("@copyright_year", txtCopyrightYear.Text))
            cmd.Parameters.Add(New OleDbParameter("@original_totalpages", txtOriginalTotalPages.Text))
            cmd.Parameters.Add(New OleDbParameter("@current_totalpages", txtCurrentTotalPages.Text))
            cmd.Parameters.Add(New OleDbParameter("@quantity", txtQuantity.Text))
            cmd.Parameters.Add(New OleDbParameter("@date", dateNow))
            cmd.Parameters.Add(New OleDbParameter("@time", timeNow))
            cmd.Parameters.Add(New OleDbParameter("@shelf_id", shelfID))
            cmd.Parameters.Add(New OleDbParameter("@admin_id", Form_Main.userIdGetter))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("SUCCESSFULLY ADDED", MsgBoxStyle.Information, "ATTENTION")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            Reset()
            cmbboxSubject.Items.Clear()
            cmbboxShelf.Items.Clear()
            RetrieveAllSubjects()
            RetrieveAllShelfs()
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "BACK" Then
            Me.Hide()
            Reset()
            Form_BookList.GetData()
            Form_BookList.Show()
        Else
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_BookList.GetData()
                Form_BookList.Show()
            End If
        End If
    End Sub

    Private Sub txtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles txtBookNo.TextChanged
        If txtBookNo.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
    Private Sub txtStudentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBookNo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCopyrightYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCopyrightYear.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtOriginalTotalPages_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOriginalTotalPages.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCurrentTotalPages_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrentTotalPages.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class