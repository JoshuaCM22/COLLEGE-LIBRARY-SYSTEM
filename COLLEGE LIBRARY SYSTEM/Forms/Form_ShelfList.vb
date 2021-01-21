Imports System.Data.OleDb

Public Class Form_ShelfList
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form_BookList.GetData()
        Form_BookList.Show()
        Form_BookList.txtSearch.Focus()
    End Sub



    Public Sub GetData()
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()
        Try
            con.Open()
            da = New OleDbDataAdapter("vWGetAllShelfs", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvShelfList.DataSource = ds.Tables(0)
            dgvShelfList.Columns(0).Visible = False
            dgvShelfList.Columns(1).Width = 445

            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            txtSearch.Text = ""

        End Try
        lblTotalEntry.Text = "TOTAL ENTRY: " + dgvShelfList.RowCount.ToString
    End Sub

    Private Sub Form_ShelfList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()

        If txtSearch.Text = "" Then
            GetData()
        Else
            con.Open()
            da = New OleDbDataAdapter("spGetShelfByShelf", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@shelf", txtSearch.Text & "%")
            da.Fill(ds)
            dgvShelfList.DataSource = ds.Tables(0)
            dgvShelfList.Columns(0).Visible = False
            dgvShelfList.Columns(1).Width = 445


            con.Close()
            lblTotalEntry.Text = "TOTAL ENTRY:" + dgvShelfList.RowCount.ToString
        End If
    End Sub

    Private Sub dgvShelfList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShelfList.CellClick
        con.Open()
        Dim row As DataGridViewRow = dgvShelfList.CurrentRow
        Try
            Me.Hide()
            Form_ShelfProfile.Show()
            Form_ShelfProfile.lblShelf.Focus()
            Form_ShelfProfile.shelfID = row.Cells(0).Value.ToString()
            Form_ShelfProfile.txtShelf.Text = row.Cells(1).Value.ToString()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()

        Form_AddNewShelf.Reset()
        Form_AddNewShelf.Show()
        Form_AddNewShelf.txtShelf.Focus()

    End Sub
End Class