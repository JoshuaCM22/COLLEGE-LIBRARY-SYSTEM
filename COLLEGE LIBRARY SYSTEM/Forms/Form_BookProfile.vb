Imports System.Data.OleDb
Public Class Form_BookProfile

    Dim subjectID As Integer
    Dim shelfID As Integer

    Private Sub Reset()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = True
        btnClose.Text = "CLOSE"
        txtTitle.Enabled = False
        cmbboxSubject.Enabled = False
        txtAuthors.Enabled = False
        txtPublisher.Enabled = False
        txtCopyrightYear.Enabled = False
        txtOriginalTotalPages.Enabled = False
        txtCurrentTotalPages.Enabled = False
        txtQuantity.Enabled = False
        cmbboxShelf.Enabled = False
    End Sub
    Private Sub Form_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        RetrieveAllSubjects()
        RetrieveAllShelfs()
    End Sub
    Public Sub RetrieveAllSubjects()
        Try
            con.Close()
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
            con.Close()
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

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        btnEdit.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnClose.Text = "CANCEL"
        txtTitle.Enabled = True
        cmbboxSubject.Enabled = True
        txtAuthors.Enabled = True
        txtPublisher.Enabled = True
        txtCopyrightYear.Enabled = True
        txtOriginalTotalPages.Enabled = True
        txtCurrentTotalPages.Enabled = True
        txtQuantity.Enabled = True
        cmbboxShelf.Enabled = True

    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to update ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Validation()
        End If
    End Sub
    Public Sub Validation()
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
            Updating()
        End If
    End Sub

    Public Sub Updating()
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

            dr.Close()
            con.Close()

            Dim dateNow As String = Form_Main.lblDateToday.Text
            Dim timeNow As String = Form_Main.lblTimeNow.Text

            con.Open()
            cmd = New OleDbCommand("spUpdateExistingBook", con) With {
                .CommandType = CommandType.StoredProcedure
            }

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
            cmd.Parameters.Add(New OleDbParameter("@book_no", txtBookNo.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information, "ATTENTION")
            Reset()
            Form_BookList.GetData()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to delete ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Try
                con.Open()
                cmd = New OleDbCommand("spDeleteExistingBook", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                cmd.Parameters.AddWithValue("@book_no", txtBookNo.Text)
                cmd.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY DELETED", MsgBoxStyle.Information, "ATTENTION")
                con.Close()
                Reset()
                Me.Hide()
                Form_BookList.GetData()
                Form_BookList.Enabled = True
                Form_BookList.btnBack.Visible = True
                Form_BookList.BringToFront()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "CANCEL" = True Then
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_BookList.Enabled = True
                Form_BookList.btnBack.Visible = True
                Form_BookList.Show()
                Form_BookList.BringToFront()
            End If
        Else
            Me.Hide()
            Form_BookList.Enabled = True
            Form_BookList.btnBack.Visible = True
            Form_BookList.Show()
            Form_BookList.BringToFront()
        End If
    End Sub
End Class