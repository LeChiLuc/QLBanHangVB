Imports System.Data.SqlClient
Public Class frmThemHoaDon
    Dim cn As New SqlConnection("Data Source=.;Initial Catalog=QLBanMayTinh;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim dr As SqlDataReader

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        dgvCommon.RowTemplate.Height = 70
        loadid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSP.Click
        frmQuanLyBanMayTinh.Show()
    End Sub
    Sub loadid()
        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "SELECT MaHD FROM HoaDon ORDER BY MaHD DESC"
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MaID.Text = Val(dr.Item(0)) + 1
        End If
        cn.Close()
    End Sub

    Private Sub btnTong_Click(sender As Object, e As EventArgs) Handles btnTong.Click
        Dim i As Integer
        For i = 0 To dgvCommon.RowCount - 1
            txtTong.Text = Val(Format(txtTong.Text, "General Number")) + Val(dgvCommon.Rows.Item(i).Cells(4).Value)
            txtTong.Text = Format(txtTong.Text, "standard")
        Next
    End Sub


    Private Sub txtGiamGia_Leave(sender As Object, e As EventArgs) Handles txtGiamGia.Leave
        txtThanhTien.Text = Val((txtTong.Text) - Val((txtTong.Text) * (txtGiamGia.Text)) / 100)
        txtThanhTien.Text = Format(txtThanhTien.Text, "standard")
    End Sub

    Private Sub btnHD_Click(sender As Object, e As EventArgs) Handles btnHD.Click
        Dim i As Integer = MaID.Text
        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "INSERT INTO HoaDon(MaNV,TenNV,TenKH,DiaChi,SDT,NgayTaoHD,SubTotal,Total,MaCM) VALUES('" & txtMaNV.Text & "','" & txtNV.Text & "','" & txtKhachHang.Text & "','" & txtDiaChi.Text & "','" & txtSDT.Text & "', convert(date,'" & DateTimePicker1.Value & "',103) ,'" & txtTong.Text & "','" & txtThanhTien.Text & "','" & txtMaCM.Text & "')"
            .ExecuteNonQuery()
        End With
        For Each row As DataGridViewRow In dgvCommon.Rows
            With cmd
                .Connection = cn
                .CommandText = "INSERT INTO ChiTietHoaDon(MaHD,MaSP,TenSP,SoLuong,Gia) Values('" & i & "','" & CStr(row.Cells(0).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & CStr(row.Cells(3).FormattedValue) & "','" & CStr(row.Cells(2).FormattedValue) & "')"
                .ExecuteNonQuery()
            End With
            With cmd
                .Connection = cn
                .CommandText = "UPDATE SanPham SET SoLuong=SoLuong - '" & CStr(row.Cells(3).FormattedValue) & "' WHERE MaSP='" & CStr(row.Cells(0).FormattedValue) & "'"
                .ExecuteNonQuery()
            End With
        Next
        MessageBox.Show("Thêm dữ liệu thành công", "Infomation", MessageBoxButtons.OK)
        cn.Close()
    End Sub

    Private Sub btnKH_Click(sender As Object, e As EventArgs) Handles btnKH.Click
        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "INSERT INTO KhachHang(HoTen,DiaChi,SDT) VALUES('" & txtKhachHang.Text & "','" & txtDiaChi.Text & "','" & txtSDT.Text & "')"
            .ExecuteNonQuery()
        End With
        cn.Close()
    End Sub

End Class