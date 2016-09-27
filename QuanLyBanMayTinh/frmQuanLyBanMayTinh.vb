

Public Class frmQuanLyBanMayTinh
    'Khai báo biến để truy xuất DB từ lớp DataBaseSQL
    Private _DBSQL As New DataBaseSQL

    'Khai báo biến trạng thái kiểm tra dữ liệu đang load
    Private _isLoading As Boolean = False

    'Định nghia thủ thục load dữ liệu từ bảng Chuyên mục vào combobox
    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "Select MaCM,TenCm FROM dbo.ChuyenMuc WHERE MaCM='5'"
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.cmbCM.DataSource = dTable
        Me.cmbCM.ValueMember = "MaCM"
        Me.cmbCM.DisplayMember = "TenCm"
    End Sub

    'Định nghĩa thủ tục load dữ liệu từ bảng Sản phẩm theo từng Chuyên mục vào Gridview
    Private Sub LoadDataSPOnGridView(MaCM As String)
        Dim sqlQuery As String =
            String.Format("SELECT MaSP,Ten,Gia,SoLuong FROM dbo.SanPham WHERE MaCM='{0}'", MaCM)
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        dgvCommon.RowTemplate.Height = 70
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "Ten"
            .Columns(1).Width = 400
            .Columns(2).HeaderText = "Gia"
            .Columns(3).HeaderText = "SoLuong"
        End With
    End Sub


    Private Sub frmQuanLyBanMayTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True 'True khi dữ liệu bắt đầu load
        LoadDataOnComBobox()
        LoadDataSPOnGridView(Me.cmbCM.SelectedValue)
        _isLoading = False 'False khi dữ liệu load xong
    End Sub

    Private Sub cmbCM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCM.SelectedIndexChanged
        If Not _isLoading Then 'Nếu load dữ liệu xong
            LoadDataSPOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub
    'Định nghĩa thủ tục hiển thị kết quả Tìm Kiếm: theo phương pháp tương tự-Tìm kiếm tương tự
    Private Sub TimKiemSanPham(MaCM As String, value As String)
        Dim sqlQuery As String =
            String.Format("SELECT MaSP,Ten,Gia,SoLuong FROM dbo.SanPham WHERE MaCM='{0}'", MaCM)
        If Me.cmbTimKiem.SelectedIndex = 0 Then 'Tìm theo Mã
            sqlQuery += String.Format(" AND MaSP LIKE '%{0}%'", value)
        ElseIf Me.cmbTimKiem.SelectedIndex = 1 Then 'Tìm kiếm theo Tên
            sqlQuery += String.Format(" AND Ten LIKE '%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBSQL.GetDataTable(sqlQuery)
        Me.dgvCommon.DataSource = dTable
        With Me.dgvCommon
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "Ten"
            .Columns(2).HeaderText = "Gia"
            .Columns(3).HeaderText = "SoLuong"
        End With
    End Sub
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        TimKiemSanPham(Me.cmbCM.SelectedValue, Me.txtTimKiem.Text)
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmSanPham(False)
        frm.txtMaCM.Text = Me.cmbCM.SelectedValue
        frm.txtMaSP.ReadOnly = True
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then 'Them du lieu thanh cong thi load lai du lieu
            'Load dữ liệu
            LoadDataSPOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim frm As New frmSanPham(True)
        frm.txtMaCM.Text = Me.cmbCM.SelectedValue
        frm.txtMaSP.ReadOnly = True
        With Me.dgvCommon
            frm.txtMaSP.Text = .Rows(.CurrentCell.RowIndex).Cells("MaSP").Value
            frm.txtTenSP.Text = .Rows(.CurrentCell.RowIndex).Cells("Ten").Value
            frm.txtGia.Text = .Rows(.CurrentCell.RowIndex).Cells("Gia").Value
            frm.txtSL.Text = .Rows(.CurrentCell.RowIndex).Cells("SoLuong").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then 'Sua du lieu thanh cong thi load lai du lieu 
            LoadDataSPOnGridView(Me.cmbCM.SelectedValue)
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        'Khai bao bien lay MaSP ma can xoa da duoc chon tren gridview
        Dim MaSP As String = Me.dgvCommon.Rows(Me.dgvCommon.CurrentCell.RowIndex).Cells("MaSP").Value
        'Khai bao cau lenh Query de xoa
        Dim sqlQuery As String = String.Format("DELETE SanPham WHERE MaSP = '{0}'", MaSP)
        'Thuc hien xoa
        If _DBSQL.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa dữ liệu thành công!")
            'Load lai du lieu tren Gridview
            LoadDataSPOnGridView(Me.cmbCM.SelectedValue)
        Else
            MessageBox.Show("Lỗi xóa dữ liệu!")
        End If
    End Sub

    Private Sub dgvCommon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCommon.CellClick
        Dim i As Integer = InputBox("Nhập số lượng sản phẩm!")
        frmThemHoaDon.dgvCommon.Rows.Add(dgvCommon.Item(0, e.RowIndex).Value, dgvCommon.Item(1, e.RowIndex).Value, dgvCommon.Item(2, e.RowIndex).Value, i, Format(i * dgvCommon.Item(2, e.RowIndex).Value))
    End Sub

End Class