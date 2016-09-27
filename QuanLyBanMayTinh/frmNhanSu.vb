﻿Public Class frmNhanSu
    'Khai báo biến truy xuất DB từ lớp DBSQL
    Private _DBSQL As New DataBaseSQL
    'Khai bao bien de biet trang thai dang la Edit hay InSert
    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub
    'Định nghĩa hàm thêm bản ghi Nhân viên vào database
    Private Function ThemNhanVien() As Boolean
        Dim sqlQuery As String = "INSERT INTO NhanVien (HoTen,NgaySinh,GioiTinh,DiaChi,SDT,ChucVu,MaCM)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6})", txtHoTen.Text, txtNgaySinh.Text, txtGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, txtChucVu.Text, txtCM.Text)
        Return _DBSQL.ExecuteNoneQuery(sqlQuery)
    End Function

    'Dinh nghia ham update
    Private Function SuaNhanVien() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE NhanVien SET HoTen = '{0}',NgaySinh='{1}',GioiTinh='{2}',DiaChi='{3}',SDT='{4}',ChucVu='{5}'WHERE MaNV='{6}'",
                                               Me.txtHoTen.Text, Me.txtNgaySinh.Text, Me.txtGioiTinh.Text, Me.txtDiaChi.Text, Me.txtSDT.Text, Me.txtChucVu.Text, Me.txtMaNV.Text)
        Return _DBSQL.ExecuteNoneQuery(sqlQuery)
    End Function

    'Dinh nghia ham kiem tra gia tri truoc khi insert du lieu vao database
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtHoTen.Text) OrElse String.IsNullOrEmpty(txtGioiTinh.Text) OrElse String.IsNullOrEmpty(txtChucVu.Text) OrElse
        String.IsNullOrEmpty(txtSDT.Text) OrElse String.IsNullOrEmpty(txtDiaChi.Text) OrElse String.IsNullOrEmpty(txtCM.Text)
    End Function


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then 'Kiem tra truong du lieu truoc khi thuc hien them, sua
            MessageBox.Show("Hãy nhâp giá trị vào trước khi ghi vào database", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then 'Neu la Edit thi goi ham Update
                If SuaNhanVien() Then 'Neu update thanh cong thi thong bao
                    MessageBox.Show("Sua du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                Else 'Neu co loi khi sua thi thong bao loi
                    MessageBox.Show("Loi sua du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                End If
            Else            'Neu khong phai Edit thi goi ham Insert
                    If ThemNhanVien() Then 'Neu Insert thanh cong thi thong bao
                    MessageBox.Show("Thêm dữ liệu thành công!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK 'Khi thêm dữ liệu thành công sẽ load lại
                Else
                    MessageBox.Show("Lỗi thêm dữ liệu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.No
                End If
            End If

            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class