Imports System.Data.OleDb

Public Class Form_SubjectList
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
            da = New OleDbDataAdapter("vWGetAllSubjectS", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvSubjectList.DataSource = ds.Tables(0)
            dgvSubjectList.Columns(0).Visible = False
            dgvSubjectList.Columns(1).Width = 445

            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            txtSearch.Text = ""

        End Try
        lblTotalEntry.Text = "TOTAL ENTRY: " + dgvSubjectList.RowCount.ToString
    End Sub

    Private Sub Form_SubjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            da = New OleDbDataAdapter("spGetSubjectBySubject", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@subject", txtSearch.Text & "%")
            da.Fill(ds)
            dgvSubjectList.DataSource = ds.Tables(0)
            dgvSubjectList.Columns(0).Visible = False
            dgvSubjectList.Columns(1).Width = 445


            con.Close()
            lblTotalEntry.Text = "TOTAL ENTRY:" + dgvSubjectList.RowCount.ToString
        End If
    End Sub

    Private Sub dgvCourseList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectList.CellClick
        con.Open()
        Dim row As DataGridViewRow = dgvSubjectList.CurrentRow
        Try
            Me.Hide()
            Form_SubjectProfile.Show()
            Form_SubjectProfile.lblSubject.Focus()
            Form_SubjectProfile.subjectID = row.Cells(0).Value.ToString()
            Form_SubjectProfile.txtSubject.Text = row.Cells(1).Value.ToString()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()

        Form_AddNewSubject.Reset()
        Form_AddNewSubject.Show()
        Form_AddNewSubject.txtSubject.Focus()

    End Sub
End Class