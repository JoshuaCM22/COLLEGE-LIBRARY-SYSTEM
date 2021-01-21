Public Class Form_Main
    Public usernameGetter As String = ""
    Public passwordGetter As String = ""
    Public userIdGetter As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeNow.Text = TimeOfDay.ToString("h:mm:ss tt")
        lblDateToday.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDayToday.Text = WeekdayName(Weekday(Now))
    End Sub

    Public Sub Reset()
        lblTitle.Focus()
    End Sub
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblTimeNow.Focus()
        lblDateToday.Text = Date.Now.ToString("MMMM d, yyyy")
        lblDayToday.Text = WeekdayName(Weekday(Now))

    End Sub
    Private Sub Toolstrip_CreateAnotherAccount_Click(sender As Object, e As EventArgs) Handles toolstrip_CreateAnotherAccount.Click
        Me.Hide()
        Form_CreateAnotherAccount.Show()
        Form_CreateAnotherAccount.txtUsername.Focus()
    End Sub
    Private Sub Toolstrip_ChangePassword_Click(sender As Object, e As EventArgs) Handles toolstrip_ChangePassword.Click
        Me.Hide()
        Form_ChangePassword.Show()
        Form_ChangePassword.txtCurrentPassword.Focus()
    End Sub
    Private Sub Toolstrip_Logout_Click(sender As Object, e As EventArgs) Handles toolstrip_Logout.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to log-out ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Me.Hide()
            userIdGetter = 0
            Form_Login.Show()
            Form_Login.Reset()
        End If
    End Sub

    Private Sub btnBookList_Click(sender As Object, e As EventArgs) Handles btnBookList.Click
        Me.Hide()
        Form_BookList.GetData()
        Form_BookList.Show()
        Form_BookList.txtSearch.Focus()
    End Sub

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles btnStudentList.Click
        Me.Hide()
        Form_StudentList.GetData()
        Form_StudentList.Show()
        Form_StudentList.txtSearch.Focus()
    End Sub

    Private Sub btnBorrowedDetails_Click(sender As Object, e As EventArgs) Handles btnBorrowedDetails.Click
        Me.Hide()
        Form_BorrowedDetails.ComputeAllowedDaysAndPenalty()
        Form_BorrowedDetails.GetData()
        Form_BorrowedDetails.Show()
        Form_BorrowedDetails.txtSearch.Focus()
    End Sub

    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        Me.Hide()
        Form_BorrowBook.Show()
        Form_BorrowBook.Reset()
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        Me.Hide()
        Form_ReturnBook.Show()
        Form_ReturnBook.Reset()
    End Sub
End Class