<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemHoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHD = New System.Windows.Forms.Button()
        Me.btnKH = New System.Windows.Forms.Button()
        Me.btnSP = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKhachHang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTong = New System.Windows.Forms.Button()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGiamGia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTong = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvCommon = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMaCM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCommon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMaCM)
        Me.GroupBox1.Controls.Add(Me.btnHD)
        Me.GroupBox1.Controls.Add(Me.btnKH)
        Me.GroupBox1.Controls.Add(Me.btnSP)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSDT)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNV)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKhachHang)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MaID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1302, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đặt sản phẩm"
        '
        'btnHD
        '
        Me.btnHD.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHD.Location = New System.Drawing.Point(1078, 161)
        Me.btnHD.Name = "btnHD"
        Me.btnHD.Size = New System.Drawing.Size(189, 38)
        Me.btnHD.TabIndex = 21
        Me.btnHD.Text = "Thêm hóa đơn"
        Me.btnHD.UseVisualStyleBackColor = True
        '
        'btnKH
        '
        Me.btnKH.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnKH.Location = New System.Drawing.Point(857, 161)
        Me.btnKH.Name = "btnKH"
        Me.btnKH.Size = New System.Drawing.Size(189, 38)
        Me.btnKH.TabIndex = 20
        Me.btnKH.Text = "Thêm khách hàng"
        Me.btnKH.UseVisualStyleBackColor = True
        '
        'btnSP
        '
        Me.btnSP.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSP.Location = New System.Drawing.Point(634, 161)
        Me.btnSP.Name = "btnSP"
        Me.btnSP.Size = New System.Drawing.Size(189, 38)
        Me.btnSP.TabIndex = 19
        Me.btnSP.Text = "Chọn sản phẩm"
        Me.btnSP.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1061, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(229, 32)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(914, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Ngày tạo HĐ:"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(663, 101)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(231, 32)
        Me.txtSDT.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(518, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Số điện thoại:"
        '
        'txtNV
        '
        Me.txtNV.Location = New System.Drawing.Point(1059, 63)
        Me.txtNV.Name = "txtNV"
        Me.txtNV.Size = New System.Drawing.Size(231, 32)
        Me.txtNV.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(914, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Người lập HĐ:"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(1059, 25)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(231, 32)
        Me.txtMaNV.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(914, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mã nhân viên:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(663, 63)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(231, 32)
        Me.txtDiaChi.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(518, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Địa chỉ:"
        '
        'txtKhachHang
        '
        Me.txtKhachHang.Location = New System.Drawing.Point(663, 25)
        Me.txtKhachHang.Name = "txtKhachHang"
        Me.txtKhachHang.Size = New System.Drawing.Size(231, 32)
        Me.txtKhachHang.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(518, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Khách hàng:"
        '
        'MaID
        '
        Me.MaID.AutoSize = True
        Me.MaID.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MaID.ForeColor = System.Drawing.Color.Red
        Me.MaID.Location = New System.Drawing.Point(177, 50)
        Me.MaID.Name = "MaID"
        Me.MaID.Size = New System.Drawing.Size(66, 72)
        Me.MaID.TabIndex = 1
        Me.MaID.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTong)
        Me.GroupBox2.Controls.Add(Me.txtThanhTien)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtGiamGia)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTong)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 520)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1302, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tổng tiền"
        '
        'btnTong
        '
        Me.btnTong.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTong.Location = New System.Drawing.Point(176, 93)
        Me.btnTong.Name = "btnTong"
        Me.btnTong.Size = New System.Drawing.Size(189, 38)
        Me.btnTong.TabIndex = 18
        Me.btnTong.Text = "Tổng"
        Me.btnTong.UseVisualStyleBackColor = True
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(962, 42)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(231, 32)
        Me.txtThanhTien.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(817, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Thành tiền:"
        '
        'txtGiamGia
        '
        Me.txtGiamGia.Location = New System.Drawing.Point(553, 42)
        Me.txtGiamGia.Name = "txtGiamGia"
        Me.txtGiamGia.Size = New System.Drawing.Size(231, 32)
        Me.txtGiamGia.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(442, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 24)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Giảm giá:"
        '
        'txtTong
        '
        Me.txtTong.Location = New System.Drawing.Point(176, 42)
        Me.txtTong.Name = "txtTong"
        Me.txtTong.Size = New System.Drawing.Size(231, 32)
        Me.txtTong.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(101, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 24)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tổng:"
        '
        'dgvCommon
        '
        Me.dgvCommon.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCommon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvCommon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCommon.Location = New System.Drawing.Point(3, 16)
        Me.dgvCommon.Name = "dgvCommon"
        Me.dgvCommon.Size = New System.Drawing.Size(1296, 284)
        Me.dgvCommon.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "MaSP"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tên sản phẩm"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 350
        '
        'Column3
        '
        Me.Column3.HeaderText = "Giá"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Số lượng"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tổng"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 300
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvCommon)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1302, 303)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'txtMaCM
        '
        Me.txtMaCM.Location = New System.Drawing.Point(203, 141)
        Me.txtMaCM.Name = "txtMaCM"
        Me.txtMaCM.ReadOnly = True
        Me.txtMaCM.Size = New System.Drawing.Size(23, 32)
        Me.txtMaCM.TabIndex = 22
        Me.txtMaCM.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Mã chuyên mục:"
        '
        'frmThemHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1302, 679)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmThemHoaDon"
        Me.Text = "frmThemHoaDon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCommon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCommon As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MaID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKhachHang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnHD As Button
    Friend WithEvents btnKH As Button
    Friend WithEvents btnSP As Button
    Friend WithEvents btnTong As Button
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtGiamGia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTong As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaCM As TextBox
End Class
