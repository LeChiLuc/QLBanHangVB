<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuaHoaDon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTong = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaCM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn:"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(395, 31)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.ReadOnly = True
        Me.txtMaHD.Size = New System.Drawing.Size(317, 26)
        Me.txtMaHD.TabIndex = 1
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(395, 156)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(317, 26)
        Me.txtTenKH.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên khách hàng:"
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(395, 115)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(317, 26)
        Me.txtTenNV.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tên nhân viên"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(395, 73)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(317, 26)
        Me.txtMaNV.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mã nhân viên:"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(395, 241)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(317, 26)
        Me.txtSDT.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 244)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Số điện thoại:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ngày tạo HĐ:"
        '
        'txtTong
        '
        Me.txtTong.Location = New System.Drawing.Point(395, 324)
        Me.txtTong.Name = "txtTong"
        Me.txtTong.Size = New System.Drawing.Size(317, 26)
        Me.txtTong.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 327)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tổng:"
        '
        'txtDC
        '
        Me.txtDC.Location = New System.Drawing.Point(395, 199)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(317, 26)
        Me.txtDC.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(263, 202)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Địa chỉ:"
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(395, 366)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(317, 26)
        Me.txtThanhTien.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(263, 369)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Thành tiền:"
        '
        'txtMaCM
        '
        Me.txtMaCM.Location = New System.Drawing.Point(395, 408)
        Me.txtMaCM.Name = "txtMaCM"
        Me.txtMaCM.ReadOnly = True
        Me.txtMaCM.Size = New System.Drawing.Size(317, 26)
        Me.txtMaCM.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(263, 411)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Mã chuyên mục:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(297, 496)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(153, 55)
        Me.btnOK.TabIndex = 20
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(539, 496)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(153, 55)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(395, 286)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(317, 26)
        Me.DateTimePicker1.TabIndex = 22
        '
        'SuaHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 621)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtMaCM)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTong)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "SuaHoaDon"
        Me.Text = "SuaHoaDon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenNV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMaCM As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
