Imports System.Data.OleDb

Public Class Form_CourseList
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form_StudentList.GetData()
        Form_StudentList.Show()
        Form_StudentList.txtSearch.Focus()
    End Sub



    Public Sub GetData()
        Objects.da = New OleDbDataAdapter()
        Objects.dt = New DataTable()
        Objects.ds = New DataSet()
        Try
            con.Open()
            da = New OleDbDataAdapter("vWGetAllCourses", con)
            da.SelectCommand.CommandType = CommandType.TableDirect
            da.Fill(ds)
            dgvCourseList.DataSource = ds.Tables(0)
            dgvCourseList.Columns(0).Visible = False
            dgvCourseList.Columns(1).Width = 445

            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            txtSearch.Text = ""

        End Try
        lblTotalEntry.Text = "TOTAL ENTRY: " + dgvCourseList.RowCount.ToString
    End Sub

    Private Sub Form_CourseList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            da = New OleDbDataAdapter("spGetCourseByCourse", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@course", txtSearch.Text & "%")
            da.Fill(ds)
            dgvCourseList.DataSource = ds.Tables(0)
            dgvCourseList.Columns(0).Visible = False
            dgvCourseList.Columns(1).Width = 445


            con.Close()
            lblTotalEntry.Text = "TOTAL ENTRY:" + dgvCourseList.RowCount.ToString
        End If
    End Sub

    Private Sub dgvCourseList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourseList.CellClick
        con.Open()
        Dim row As DataGridViewRow = dgvCourseList.CurrentRow
        Try
            Me.Hide()
            Form_CourseProfile.Show()
            Form_CourseProfile.lblCourse.Focus()
            Form_CourseProfile.courseID = row.Cells(0).Value.ToString()
            Form_CourseProfile.txtCourse.Text = row.Cells(1).Value.ToString()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()

        Form_AddNewCourse.Reset()
        Form_AddNewCourse.Show()
        Form_AddNewCourse.txtCourse.Focus()

    End Sub
End Class