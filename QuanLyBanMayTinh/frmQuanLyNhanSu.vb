Public Class frmQuanLyNhanSu
    'Khai báo biến để truy xuất DB từ lớp DataBaseSQL
    Private _DBSQL As New DataBaseSQL

    'Khai báo biến trạng thái kiểm tra dữ liệu đang load
    Private _isLoading As Boolean = False
    'Định nghia thủ thục load dữ liệu từ bảng Chuyên mục vào combobox
    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "Select MaCM,TenCm FROM dbo.ChuyenMuc WHERE  MaCM='6' OR TenCm='Nhân Viên'"
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.cmbCM.DataSource = dTable
        Me.cmbCM.ValueMember = "MaCM"
        Me.cmbCM.DisplayMember = "TenCm"
    End Sub
    'Định nghĩa thủ tục load dữ liệu từ bảng Nhân viên theo từng Chuyên mục vào Gridview
    Private Sub LoadDataNVOnGridView(MaCM As String)
        Dim sqlQuery As String =
            String.Format("SELECT MaNV,HoTen,NgaySinh,GioiTinh,DiaChi,SDT,ChucVu FROM dbo.NhanVien WHERE MaCM='{0}'", MaCM)
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        dgvCommon.RowTemplate.Height = 70
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaNV"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "NgaySinh"
            .Columns(3).HeaderText = "GioiTinh"
            .Columns(4).HeaderText = "DiaChi"
            .Columns(5).HeaderText = "SDT"
            .Columns(6).HeaderText = "ChucVu"
        End With
    End Sub


    Private Sub frmQuanLyNhanSu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True 'True khi dữ liệu bắt đầu load
        LoadDataOnComBobox()
        LoadDataNVOnGridView(Me.cmbCM.SelectedValue)
        _isLoading = False 'False khi dữ liệu load xong
    End Sub

    Private Sub cmbCM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCM.SelectedIndexChanged
        If Not _isLoading Then 'Nếu load dữ liệu xong
            LoadDataNVOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub
    'Định nghĩa thủ tục hiển thị kết quả Tìm Kiếm: theo phương pháp tương tự-Tìm kiếm tương tự
    Private Sub TimKiemNhanSu(MaCM As String, value As String)
        Dim sqlQuery As String =
            String.Format("SELECT MaNV,HoTen,NgaySinh,GioiTinh,DiaChi,SDT,ChucVu FROM dbo.NhanVien WHERE MaCM='{0}'", MaCM)
        If Me.cmbTimKiem.SelectedIndex = 0 Then 'Tìm theo Mã
            sqlQuery += String.Format(" AND MaNV LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 1 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND HoTen LIKE '%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaNV"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "NgaySinh"
            .Columns(3).HeaderText = "GioiTinh"
            .Columns(4).HeaderText = "DiaChi"
            .Columns(5).HeaderText = "SDT"
            .Columns(6).HeaderText = "ChucVu"
        End With
    End Sub
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        TimKiemNhanSu(Me.cmbCM.SelectedValue, Me.txtTimKiem.Text)
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmNhanSu(False)
        frm.txtCM.Text = Me.cmbCM.SelectedValue
        frm.txtMaNV.ReadOnly = True
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then 'Them du lieu thanh cong thi load lai du lieu
            'Load dữ liệu
            LoadDataNVOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim frm As New frmNhanSu(True)
        frm.txtCM.Text = Me.cmbCM.SelectedValue
        frm.txtMaNV.ReadOnly = True
        With Me.dgvCommon
            frm.txtMaNV.Text = .Rows(.CurrentCell.RowIndex).Cells("MaNV").Value
            frm.txtHoTen.Text = .Rows(.CurrentCell.RowIndex).Cells("HoTen").Value
            frm.txtNgaySinh.Text = .Rows(.CurrentCell.RowIndex).Cells("NgaySinh").Value
            frm.txtGioiTinh.Text = .Rows(.CurrentCell.RowIndex).Cells("GioiTinh").Value
            frm.txtDiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            frm.txtSDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            frm.txtChucVu.Text = .Rows(.CurrentCell.RowIndex).Cells("ChucVu").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then 'Sua du lieu thanh cong thi load lai du lieu 
            LoadDataNVOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        'Khai bao bien lay MaNV ma can xoa da duoc chon tren gridview
        Dim MaNV As String = Me.dgvCommon.Rows(Me.dgvCommon.CurrentCell.RowIndex).Cells("MaNV").Value
        'Khai bao cau lenh Query de xoa
        Dim sqlQuery As String = String.Format("DELETE NhanVien WHERE MaNV = '{0}'", MaNV)
        'Thuc hien xoa
        If _DBSQL.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa dữ liệu thành công!")
            'Load lai du lieu tren Gridview
            LoadDataNVOnGridView(Me.cmbCM.SelectedValue)
        Else
            MessageBox.Show("Lỗi xóa dữ liệu!")
        End If
    End Sub
End Class