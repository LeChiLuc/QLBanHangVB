Public Class SuaHoaDon
    'Khai báo biến truy xuất DB từ lớp DBSQL
    Private _DBSQL As New DataBaseSQL

    'Dinh nghia ham update
    Private Function SuaHoaDon() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE HoaDon SET MaNV = '{0}',TenNV='{1}',TenKH='{2}',DiaChi='{3}',SDT='{4}',NgayTaoHD='{5}',SubTotal='{6}',Total='{7}',MaCM='{8}' WHERE MaHD='{9}'",
                                               Me.txtMaNV.Text, Me.txtTenNV.Text, Me.txtTenKH.Text, Me.txtDC.Text, Me.txtSDT.Text, Me.DateTimePicker1.Text, Me.txtTong.Text, Me.txtThanhTien.Text, Me.txtMaCM.Text, Me.txtMaHD.Text)
        Return _DBSQL.ExecuteNoneQuery(sqlQuery)
    End Function

    'Dinh nghia ham kiem tra gia tri truoc khi insert du lieu vao database
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtMaNV.Text) OrElse String.IsNullOrEmpty(txtTenNV.Text) OrElse String.IsNullOrEmpty(txtTenKH.Text) OrElse
        String.IsNullOrEmpty(txtDC.Text) OrElse String.IsNullOrEmpty(txtSDT.Text) OrElse String.IsNullOrEmpty(DateTimePicker1.Text) OrElse String.IsNullOrEmpty(txtTong.Text) OrElse String.IsNullOrEmpty(txtThanhTien.Text)
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then 'Kiem tra truong du lieu truoc khi thuc hien them, sua
            MessageBox.Show("Hãy nhâp giá trị vào trước khi ghi vào database", "Error", MessageBoxButtons.OK)
        Else
            If SuaHoaDon() Then 'Neu update thanh cong thi thong bao
                MessageBox.Show("Sua du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            Else 'Neu co loi khi sua thi thong bao loi
                MessageBox.Show("Loi sua du lieu", "Error", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub SuaHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
    End Sub
End Class