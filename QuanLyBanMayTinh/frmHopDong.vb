Public Class frmHopDong
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
    Private Function ThemHopDong() As Boolean
        Dim sqlQuery As String = "INSERT INTO HopDongLaoDong (MaNV,LuongCB,PhuCapCV,PhuCapKhac,HDTuNgay,HDDenNgay,GhiChu,MaCM)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7})", txtMaNV.Text, txtLuongCB.Text, txtPhuCapCV.Text, txtPhuCapKhac.Text, txtHDTuNgay.Text, txtHDDenNgay.Text, txtGhiChu.Text, txtCM.Text)
        Return _DBSQL.ExecuteNoneQuery(sqlQuery)
    End Function

    'Dinh nghia ham update
    Private Function SuaNhanVien() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE HopDongLaoDong SET MaNV='{0}',LuongCB='{1}',PhuCapCV='{2}',PhuCapKhac='{3}',HDTuNgay='{4}',HDDenNgay='{5}',GhiChu='{6}'WHERE MaNV='{7}'",
                                               Me.txtMaNV.Text, Me.txtLuongCB.Text, Me.txtPhuCapCV.Text, Me.txtPhuCapKhac.Text, Me.txtHDTuNgay.Text, Me.txtHDDenNgay.Text, Me.txtGhiChu.Text, Me.txtMaNV.Text)
        Return _DBSQL.ExecuteNoneQuery(sqlQuery)
    End Function

    'Dinh nghia ham kiem tra gia tri truoc khi insert du lieu vao database
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtMaNV.Text) OrElse String.IsNullOrEmpty(txtLuongCB.Text) OrElse String.IsNullOrEmpty(txtPhuCapCV.Text) OrElse
        String.IsNullOrEmpty(txtPhuCapKhac.Text) OrElse String.IsNullOrEmpty(txtHDTuNgay.Text) OrElse String.IsNullOrEmpty(txtHDDenNgay.Text) OrElse String.IsNullOrEmpty(txtGhiChu.Text)
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
                If ThemHopDong() Then 'Neu Insert thanh cong thi thong bao
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