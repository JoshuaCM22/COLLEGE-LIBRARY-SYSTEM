Imports System.Data.OleDb
Public Class Form_BookList
    Public Sub GetData()
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()
        Try
            con.Open()
            da = New OleDbDataAdapter("vWGetAllBooks", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)
            dgvBooks.Columns(0).Visible = False
            dgvBooks.Columns(1).Width = 200
            dgvBooks.Columns(2).Width = 300
            dgvBooks.Columns(3).Width = 250
            dgvBooks.Columns(4).Width = 800
            dgvBooks.Columns(5).Width = 350
            dgvBooks.Columns(6).Width = 150
            dgvBooks.Columns(7).Width = 200
            dgvBooks.Columns(8).Width = 200
            dgvBooks.Columns(9).Width = 100
            dgvBooks.Columns(10).Width = 180
            dgvBooks.Columns(11).Width = 150
            dgvBooks.Columns(12).Width = 150
            dgvBooks.Columns(13).Width = 320
            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            txtSearch.Text = ""

        End Try
        lblTotal.Text = "TOTAL ENTRY: " + dgvBooks.RowCount.ToString
    End Sub
    Private Sub Form_BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetData()
        cmbboxFilter.Text = "None"
        txtSearch.Focus()

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        cmbboxFilter.Text = "None"
        Form_Main.Show()
    End Sub
    Private Sub btnAddNewBook_Click(sender As Object, e As EventArgs) Handles btnAddNewBook.Click
        Form_AddNewBook.Show()
        Form_AddNewBook.txtBookNo.Focus()
        Me.Hide()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()

        If txtSearch.Text = "" Then
            GetData()
        ElseIf cmbboxFilter.Text = "Book No" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBookByBookNo", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@book_no", txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Title" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBookByTitle", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@title", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Subject" Then


            con.Open()
            da = New OleDbDataAdapter("spGetBookBySubject", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@subject", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Authors" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBookByAuthors", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@authors", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Publisher" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBookByPublisher", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@publisher", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Copyright Year" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBookByCopyrightYear", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@copyright_year", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Original Total Pages" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBookByOriginalTotalPages", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@original_totalpages", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Current Total Pages" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBookByCurrentTotalPages", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@current_totalpages", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Quantity" Then
            con.Open()
            da = New OleDbDataAdapter("spGetBookByQuantity", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@quantity", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Date" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBookByDate", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@date", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        ElseIf cmbboxFilter.Text = "Time" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBookByTime", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@time", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Shelf" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBookByShelf", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@shelf", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)

        ElseIf cmbboxFilter.Text = "Admin Name" Then

            con.Open()
            da = New OleDbDataAdapter("spGetBookByAdminName", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@full_name", "%" & txtSearch.Text & "%")
            da.Fill(ds)
            dgvBooks.DataSource = ds.Tables(0)


        End If


        dgvBooks.Columns(0).Visible = False
        dgvBooks.Columns(1).Width = 200
        dgvBooks.Columns(2).Width = 300
        dgvBooks.Columns(3).Width = 250
        dgvBooks.Columns(4).Width = 800
        dgvBooks.Columns(5).Width = 350
        dgvBooks.Columns(6).Width = 150
        dgvBooks.Columns(7).Width = 200
        dgvBooks.Columns(8).Width = 200
        dgvBooks.Columns(9).Width = 100
        dgvBooks.Columns(10).Width = 180
        dgvBooks.Columns(11).Width = 150
        dgvBooks.Columns(12).Width = 150
        dgvBooks.Columns(13).Width = 320

        con.Close()
        lblTotal.Text = "TOTAL ENTRY:" + dgvBooks.RowCount.ToString
    End Sub
    Private Sub cmbboxFilter_Leave(sender As Object, e As EventArgs) Handles cmbboxFilter.Leave
        If cmbboxFilter.Text = "" Then
            GetData()
            cmbboxFilter.Text = "None"
            txtSearch.Clear()
        End If
        txtSearch.Focus()
    End Sub
    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        con.Open()
        Dim row As DataGridViewRow = dgvBooks.CurrentRow
        Try
            Me.Enabled = False
            Form_BookProfile.Show()
            Form_BookProfile.lblTitle.Focus()
            btnBack.Visible = False

            Form_BookProfile.txtBookNo.Text = row.Cells(1).Value.ToString()
            Form_BookProfile.txtTitle.Text = row.Cells(2).Value.ToString()
            Form_BookProfile.cmbboxSubject.Text = row.Cells(3).Value.ToString()
            Form_BookProfile.txtAuthors.Text = row.Cells(4).Value.ToString()
            Form_BookProfile.txtPublisher.Text = row.Cells(5).Value.ToString
            Form_BookProfile.txtCopyrightYear.Text = row.Cells(6).Value.ToString()
            Form_BookProfile.txtOriginalTotalPages.Text = row.Cells(7).Value.ToString()
            Form_BookProfile.txtCurrentTotalPages.Text = row.Cells(8).Value.ToString()
            Form_BookProfile.txtQuantity.Text = row.Cells(9).Value.ToString()
            Form_BookProfile.cmbboxShelf.Text = row.Cells(12).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cmbboxFilter_TextChanged(sender As Object, e As EventArgs) Handles cmbboxFilter.TextChanged
        txtSearch.Focus()
    End Sub

    Private Sub btnShelfList_Click(sender As Object, e As EventArgs) Handles btnShelfList.Click
        Me.Hide()
        Form_ShelfList.txtSearch.Text = ""
        Form_ShelfList.Show()
        Form_ShelfList.txtSearch.Focus()
    End Sub

    Private Sub btnSubjectList_Click(sender As Object, e As EventArgs) Handles btnSubjectList.Click
        Me.Hide()
        Form_SubjectList.txtSearch.Text = ""
        Form_SubjectList.Show()
        Form_SubjectList.txtSearch.Focus()
    End Sub
End Class
