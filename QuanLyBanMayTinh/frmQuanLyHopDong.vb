Public Class frmQuanLyHopDong
    'Khai báo biến để truy xuất DB từ lớp DataBaseSQL
    Private _DBSQL As New DataBaseSQL

    'Khai báo biến trạng thái kiểm tra dữ liệu đang load
    Private _isLoading As Boolean = False
    'Định nghia thủ thục load dữ liệu từ bảng Chuyên mục vào combobox
    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "Select MaCM,TenCm FROM dbo.ChuyenMuc WHERE  MaCM='2' OR TenCm='Hợp Đồng Lao Động'"
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.cmbCM.DataSource = dTable
        Me.cmbCM.ValueMember = "MaCM"
        Me.cmbCM.DisplayMember = "TenCm"
    End Sub
    'Định nghĩa thủ tục load dữ liệu từ bảng Nhân viên theo từng Chuyên mục vào Gridview
    Private Sub LoadDataHDOnGridView(MaCM As String)
        Dim sqlQuery As String =
            String.Format("SELECT NhanVien.MaNV,HoTen,LuongCB,PhuCapCV,PhuCapKhac,HDTuNgay,HDDenNgay,GhiChu FROM HopDongLaoDong inner join NhanVien on NhanVien.MaNV=HopDongLaoDong.MaNV WHERE HopDongLaoDong.MaCM={0}", MaCM)
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        dgvCommon.RowTemplate.Height = 70
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaNV"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "LuongCB"
            .Columns(3).HeaderText = "PhuCapCV"
            .Columns(4).HeaderText = "PhuCapKhac"
            .Columns(5).HeaderText = "HDTuNgay"
            .Columns(6).HeaderText = "HDDenNgay"
            .Columns(7).HeaderText = "GhiChu"
        End With
    End Sub


    Private Sub frmQuanLyHopDong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True 'True khi dữ liệu bắt đầu load
        LoadDataOnComBobox()
        LoadDataHDOnGridView(Me.cmbCM.SelectedValue)
        _isLoading = False 'False khi dữ liệu load xong
    End Sub

    Private Sub cmbCM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCM.SelectedIndexChanged
        If Not _isLoading Then 'Nếu load dữ liệu xong
            LoadDataHDOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub
    'Định nghĩa thủ tục hiển thị kết quả Tìm Kiếm: theo phương pháp tương tự-Tìm kiếm tương tự
    Private Sub TimKiemNhanSu(MaCM As String, value As String)
        Dim sqlQuery As String =
            String.Format("SELECT NhanVien.MaNV,HoTen,LuongCB,PhuCapCV,PhuCapKhac,HDTuNgay,HDDenNgay,GhiChu FROM HopDongLaoDong inner join NhanVien on NhanVien.MaNV=HopDongLaoDong.MaNV WHERE HopDongLaoDong.MaCM={0}", MaCM)
        If Me.cmbTimKiem.SelectedIndex = 0 Then 'Tìm theo Mã
            sqlQuery += String.Format(" AND NhanVien.MaNV LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 1 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND HoTen LIKE '%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaNV"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "LuongCB"
            .Columns(3).HeaderText = "PhuCapCV"
            .Columns(4).HeaderText = "PhuCapKhac"
            .Columns(5).HeaderText = "HDTuNgay"
            .Columns(6).HeaderText = "HDDenNgay"
            .Columns(7).HeaderText = "GhiChu"
        End With
    End Sub
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        TimKiemNhanSu(Me.cmbCM.SelectedValue, Me.txtTimKiem.Text)
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmHopDong(False)
        frm.txtCM.Text = Me.cmbCM.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then 'Them du lieu thanh cong thi load lai du lieu
            'Load dữ liệu
            LoadDataHDOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim frm As New frmHopDong(True)
        frm.txtCM.Text = Me.cmbCM.SelectedValue
        With Me.dgvCommon
            frm.txtMaNV.Text = .Rows(.CurrentCell.RowIndex).Cells("MaNV").Value
            frm.txtLuongCB.Text = .Rows(.CurrentCell.RowIndex).Cells("LuongCB").Value
            frm.txtPhuCapCV.Text = .Rows(.CurrentCell.RowIndex).Cells("PhuCapCV").Value
            frm.txtPhuCapKhac.Text = .Rows(.CurrentCell.RowIndex).Cells("PhuCapKhac").Value
            frm.txtHDTuNgay.Text = .Rows(.CurrentCell.RowIndex).Cells("HDTuNgay").Value
            frm.txtHDDenNgay.Text = .Rows(.CurrentCell.RowIndex).Cells("HDDenNgay").Value
            frm.txtGhiChu.Text = .Rows(.CurrentCell.RowIndex).Cells("GhiChu").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then 'Sua du lieu thanh cong thi load lai du lieu 
            LoadDataHDOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        'Khai bao bien lay MaNV ma can xoa da duoc chon tren gridview
        Dim MaNV As String = Me.dgvCommon.Rows(Me.dgvCommon.CurrentCell.RowIndex).Cells("MaNV").Value
        'Khai bao cau lenh Query de xoa
        Dim sqlQuery As String = String.Format("DELETE HopDongLaoDong WHERE MaNV = '{0}'", MaNV)
        'Thuc hien xoa
        If _DBSQL.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa dữ liệu thành công!")
            'Load lai du lieu tren Gridview
            LoadDataHDOnGridView(Me.cmbCM.SelectedValue)
        Else
            MessageBox.Show("Lỗi xóa dữ liệu!")
        End If
    End Sub
End Class