Public Class frmHoaDon
    'Khai báo biến để truy xuất DB từ lớp DataBaseSQL
    Private _DBSQL As New DataBaseSQL

    'Khai báo biến trạng thái kiểm tra dữ liệu đang load
    Private _isLoading As Boolean = False

    'Định nghia thủ thục load dữ liệu từ bảng Chuyên mục vào combobox
    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "Select MaCM,TenCm FROM dbo.ChuyenMuc WHERE MaCM='1'"
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.cmbCM.DataSource = dTable
        Me.cmbCM.ValueMember = "MaCM"
        Me.cmbCM.DisplayMember = "TenCm"
    End Sub

    'Định nghĩa thủ tục load dữ liệu từ bảng Sản phẩm theo từng Chuyên mục vào Gridview
    Private Sub LoadDataHDOnGridView(MaCM As String)
        Dim sqlQuery As String =
            String.Format("SELECT MaHD,MaNV,TenNV,TenKH,DiaChi,SDT,NgayTaoHD,SubTotal,Total FROM dbo.HoaDon WHERE MaCM='{0}'", MaCM)
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        dgvCommon.RowTemplate.Height = 70
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaHD"
            .Columns(1).HeaderText = "MaNV"
            .Columns(2).HeaderText = "TenNV"
            .Columns(3).HeaderText = "TenKH"
            .Columns(4).HeaderText = "DiaChi"
            .Columns(5).HeaderText = "SDT"
            .Columns(6).HeaderText = "NgayTaoHD"
            .Columns(7).HeaderText = "SubTotal"
            .Columns(8).HeaderText = "Total"
        End With
    End Sub


    Private Sub frmQuanLyBanMayTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub TimKiemHoaDon(MaCM As String, value As String)
        Dim sqlQuery As String =
            String.Format("SELECT MaHD,MaNV,TenNV,TenKH,DiaChi,SDT,NgayTaoHD,SubTotal,Total FROM dbo.HoaDon WHERE MaCM='{0}'", MaCM)
        If Me.cmbTimKiem.SelectedIndex = 0 Then 'Tìm theo Mã
            sqlQuery += String.Format(" AND MaHD LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 1 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND MaNV LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 2 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND TenNV LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 3 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND TenKH LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 4 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND DiaChi LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 5 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND SDT LIKE '%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaHD"
            .Columns(1).HeaderText = "MaNV"
            .Columns(2).HeaderText = "TenNV"
            .Columns(3).HeaderText = "TenKH"
            .Columns(4).HeaderText = "DiaChi"
            .Columns(5).HeaderText = "SDT"
            .Columns(6).HeaderText = "NgayTaoHD"
            .Columns(7).HeaderText = "SubTotal"
            .Columns(8).HeaderText = "Total"
        End With
    End Sub
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        TimKiemHoaDon(Me.cmbCM.SelectedValue, Me.txtTimKiem.Text)
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

    End Sub
End Class