Public Class frmDangki
    Private _DBSQL As New DataBaseSQL
    Private Function ThemTaiKhoan() As Boolean
        Dim sqlQuery As String = "INSERT INTO TaiKhoan(TaiKhoan,MatKhau)"
        sqlQuery += String.Format("VALUES ('{0}','{1}')", txtTaiKhoan.Text, txtMatKhau.Text)
        Return _DBSQL.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtMatKhau.Text) OrElse String.IsNullOrEmpty(txtMatKhau.Text)
    End Function
    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        If IsEmpty() Then 'Kiem tra truong du lieu truoc khi thuc hien them, sua
            MessageBox.Show("Hãy nhâp giá trị vào trước khi ghi vào database", "Error", MessageBoxButtons.OK)
        Else
            If ThemTaiKhoan() Then 'Neu update thanh cong thi thong bao
                MessageBox.Show("Thêm dữ liệu thành công!", "Infomation", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            Else 'Neu co loi khi sua thi thong bao loi
                MessageBox.Show("Lỗi dữ liệu!", "Error", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            End If
            Me.Close()
        End If
    End Sub
End Class