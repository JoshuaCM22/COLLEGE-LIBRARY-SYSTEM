Imports System.Data.OleDb
Public Class Form_BorrowedDetails
    Dim borrowedDetailsAllIDList As New List(Of Integer)
    Public Sub GetData()
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()
        Try
            con.Open()
            da = New OleDbDataAdapter("vWGetAllBorrowedDetails", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)
            dgvBorrowedDetails.Columns(0).Visible = False
            dgvBorrowedDetails.Columns(1).Width = 150
            dgvBorrowedDetails.Columns(2).Width = 150
            dgvBorrowedDetails.Columns(3).Width = 150
            dgvBorrowedDetails.Columns(4).Width = 150
            dgvBorrowedDetails.Columns(5).Width = 200
            dgvBorrowedDetails.Columns(6).Width = 300
            dgvBorrowedDetails.Columns(7).Width = 300
            dgvBorrowedDetails.Columns(8).Width = 150
            dgvBorrowedDetails.Columns(9).Width = 150

            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            txtSearch.Text = ""

        End Try
        lblTotal.Text = "TOTAL ENTRY: " + dgvBorrowedDetails.RowCount.ToString




    End Sub
    Private Sub Form_BorrowedDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComputeAllowedDaysAndPenalty()
        GetData()
        cmbboxFilter.Text = "None"
        cmbboxOpenProfile.Text = "None"
        txtSearch.Focus()

    End Sub

    Public Sub ComputeAllowedDaysAndPenalty()


        con.Open()
        cmd = New OleDbCommand("SELECT ID FROM tbl_borrowed_details; ", con) With {
                .CommandType = CommandType.Text
            }

        dr = cmd.ExecuteReader


        Do While dr.Read
            borrowedDetailsAllIDList.Add(dr.GetInt32(0))
        Loop

        dr.Close()
        cmd.Dispose()
        con.Close()


        Dim counter As Integer = 1
        For Each id In borrowedDetailsAllIDList



            con.Open()
            cmd = New OleDbCommand("SELECT * FROM [tbl_borrowed_details] WHERE [id] = @id AND [allowed_days] = @allowed_days AND [penalty] = @penalty", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@allowed_days", 0)
            cmd.Parameters.AddWithValue("@penalty", 0)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                dr.Close()
                cmd.Dispose()
                con.Close()
                UpdatingAllowedDays(id)
            Else
                dr.Close()
                cmd.Dispose()
                con.Close()
                UpdatingAllowedDays(id)
            End If

            counter += 1
        Next
    End Sub

    Public Sub UpdatingAllowedDays(id As Integer)
        Dim borrowedFromDate As String = ""
        Dim borrowedUntilDate As String = ""

        con.Open()
        cmd = New OleDbCommand("SELECT * FROM [tbl_borrowed_details] WHERE [id] = @id", con) With {
            .CommandType = CommandType.Text
        }
        cmd.Parameters.AddWithValue("@id", id)
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            borrowedFromDate = dr.Item("borrowed_from_date")
            borrowedUntilDate = dr.Item("borrowed_until_date")
        End If

        dr.Close()
        cmd.Dispose()
        con.Close()

        If Not borrowedFromDate = "" And Not borrowedUntilDate = "" Then

            Dim date1 As String = borrowedFromDate
            Dim oDate1 As DateTime = Convert.ToDateTime(date1)
            Dim d1 As Integer = oDate1.Day

            Dim date2 As String = borrowedUntilDate
            Dim oDate2 As DateTime = Convert.ToDateTime(date2)
            Dim d2 As Integer = oDate2.Day

            Dim answer As Integer = d2 - d1
            con.Open()
            cmd = New OleDbCommand("UPDATE tbl_borrowed_details SET [allowed_days] = @allowed_days WHERE [id] = @id ;
            ", con) With {
                .CommandType = CommandType.Text
            }
            cmd.Parameters.Add(New OleDbParameter("@allowed_days", answer))
            cmd.Parameters.Add(New OleDbParameter("@id", id))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

            UpdatingPenalty(id)
        End If
    End Sub

    Public Sub UpdatingPenalty(id As Integer)
        Dim actualReturnDate As String = ""
        Dim borrowedUntilDate As String = ""

        con.Open()
        cmd = New OleDbCommand("SELECT * FROM [tbl_borrowed_details] WHERE [id] = @id", con) With {
            .CommandType = CommandType.Text
        }
        cmd.Parameters.AddWithValue("@id", id)
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            actualReturnDate = dr.Item("actual_return_date")
            borrowedUntilDate = dr.Item("borrowed_until_date")
        End If

        dr.Close()
        cmd.Dispose()
        con.Close()

        If Not actualReturnDate = "" And Not borrowedUntilDate = "" Then

            Dim date1 As String = actualReturnDate
            Dim oDate1 As DateTime = Convert.ToDateTime(date1)
            Dim d1 As Integer = oDate1.Day

            Dim date2 As String = borrowedUntilDate
            Dim oDate2 As DateTime = Convert.ToDateTime(date2)
            Dim d2 As Integer = oDate2.Day


            If (d1 > d2) Then
                Dim answer As Integer = d1 - d2
                Dim penalty = answer * 10
                con.Open()
                cmd = New OleDbCommand("UPDATE tbl_borrowed_details SET [penalty] =@penalty WHERE [id]=@id ;
            ", con) With {
                .CommandType = CommandType.Text
            }
                cmd.Parameters.Add(New OleDbParameter("@penalty", penalty))
                cmd.Parameters.Add(New OleDbParameter("@id", id))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        borrowedDetailsAllIDList.Clear()
        cmbboxFilter.Text = "None"
        Form_Main.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()

        If txtSearch.Text = "" Then
            GetData()


        ElseIf cmbboxFilter.Text = "Book No" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByBookNo", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@book_no", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Student No" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByStudentNo", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@student_no", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Borrowed From" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByBorrowedFrom", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@borrowed_from_date", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Borrowed Until" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByBorrowedUntil", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@borrowed_until_date", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Actual Return Date" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByActualReturnDate", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@actual_return_date", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Lent by" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByLentBy", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@full_name", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Received by" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByReceivedBy", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@received_by", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Allowed Days" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByAllowedDays", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@allowed_days", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Penalty" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBorrowedDetailsByPenalty", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@penalty", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBorrowedDetails.DataSource = ds.Tables(0)

        End If

        dgvBorrowedDetails.Columns(0).Visible = False
        dgvBorrowedDetails.Columns(1).Width = 150
        dgvBorrowedDetails.Columns(2).Width = 150
        dgvBorrowedDetails.Columns(3).Width = 150
        dgvBorrowedDetails.Columns(4).Width = 150
        dgvBorrowedDetails.Columns(5).Width = 200
        dgvBorrowedDetails.Columns(6).Width = 300
        dgvBorrowedDetails.Columns(7).Width = 300
        dgvBorrowedDetails.Columns(8).Width = 150
        dgvBorrowedDetails.Columns(9).Width = 150

        con.Close()
        lblTotal.Text = "TOTAL ENTRY:" + dgvBorrowedDetails.RowCount.ToString
    End Sub
    Private Sub cmbboxFilter_Leave(sender As Object, e As EventArgs) Handles cmbboxFilter.Leave
        If cmbboxFilter.Text = "" Then
            GetData()
            cmbboxFilter.Text = "None"
            txtSearch.Clear()
        End If
        txtSearch.Focus()
    End Sub
    Private Sub dgvBorrowedDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowedDetails.CellClick


        con.Open()
        Dim row As DataGridViewRow = dgvBorrowedDetails.CurrentRow
        If cmbboxOpenProfile.Text = "Copy The Book No" Then

            Clipboard.SetText(row.Cells(1).Value.ToString())

            MsgBox("SUCCESSFULLY COPIED THE BOOK NO", MsgBoxStyle.Information, "ATTENTION")

        ElseIf cmbboxOpenProfile.Text = "Copy The Student No" Then

            Clipboard.SetText(row.Cells(2).Value.ToString())
            MsgBox("SUCCESSFULLY COPIED THE STUDENT NO", MsgBoxStyle.Information, "ATTENTION")

        End If

        con.Close()
    End Sub


    Private Sub cmbboxFilter_TextChanged(sender As Object, e As EventArgs) Handles cmbboxFilter.TextChanged
        txtSearch.Focus()
    End Sub

    Private Sub btnCourseList_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form_CourseList.txtSearch.Text = ""
        Form_CourseList.Show()
        Form_CourseList.txtSearch.Focus()
    End Sub


End Class
