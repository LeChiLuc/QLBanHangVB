Public Class Login
    'Khai báo biến truy xuất DB từ lớp DBSQL
    Private _DBSQL As New DataBaseSQL

    'Dinh nghia ham kiem tra taikhoan,matkhau nhap vao co dung hay khong
    Private Function CheckLogin(user As String, pass As String)
        Dim sqlQuery As String = String.Format("SELECT * FROM TaiKhoan WHERE TaiKhoan='{0}' and MatKhau='{1}'", user, pass)
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Return dTable.Rows.Count > 0
    End Function

    'DInh nghia ham kiem tra user,pass nhap vao co rong hay khong
    Private Function IsEmpty() As Boolean
        'Ham tra ve true neu taikhoan va mat khoan rong
        Return String.IsNullOrEmpty(Me.txtTaikhoan.Text) OrElse String.IsNullOrEmpty(Me.txtMatkhau.Text)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.Enter, Button1.KeyPress
        'Kiem tra tai khoan va mat khau co nhap vao hay khong
        If IsEmpty() Then
            MessageBox.Show("Tài khoản hoặc mật khẩu không được trống!")
        Else
            If CheckLogin(Me.txtTaikhoan.Text.ToLower, Me.txtMatkhau.Text.ToLower) Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub txtTaikhoan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTaikhoan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub txtMatkhau_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatkhau.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmDangki.ShowDialog()
    End Sub
End Class