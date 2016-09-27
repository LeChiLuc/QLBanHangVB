<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyHopDong
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
        Me.cmbTimKiem = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCM = New System.Windows.Forms.ComboBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvCommon = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCommon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTimKiem
        '
        Me.cmbTimKiem.FormattingEnabled = True
        Me.cmbTimKiem.Items.AddRange(New Object() {"MaNV", "HoTen"})
        Me.cmbTimKiem.Location = New System.Drawing.Point(61, 56)
        Me.cmbTimKiem.Name = "cmbTimKiem"
        Me.cmbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cmbTimKiem.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCM)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(841, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chuyên mục"
        '
        'cmbCM
        '
        Me.cmbCM.FormattingEnabled = True
        Me.cmbCM.Location = New System.Drawing.Point(6, 39)
        Me.cmbCM.Name = "cmbCM"
        Me.cmbCM.Size = New System.Drawing.Size(188, 24)
        Me.cmbCM.TabIndex = 0
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(188, 56)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(621, 20)
        Me.txtTimKiem.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tìm kiếm"
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(885, 200)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(116, 39)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSua.Location = New System.Drawing.Point(885, 139)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(116, 39)
        Me.btnSua.TabIndex = 16
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.Location = New System.Drawing.Point(885, 81)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(116, 39)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvCommon
        '
        Me.dgvCommon.AllowUserToAddRows = False
        Me.dgvCommon.AllowUserToDeleteRows = False
        Me.dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCommon.Location = New System.Drawing.Point(12, 85)
        Me.dgvCommon.MultiSelect = False
        Me.dgvCommon.Name = "dgvCommon"
        Me.dgvCommon.ReadOnly = True
        Me.dgvCommon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCommon.Size = New System.Drawing.Size(797, 305)
        Me.dgvCommon.TabIndex = 14
        '
        'frmQuanLyHopDong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 476)
        Me.Controls.Add(Me.cmbTimKiem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvCommon)
        Me.Name = "frmQuanLyHopDong"
        Me.Text = "frmHopDong"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCommon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTimKiem As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCM As ComboBox
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvCommon As DataGridView
End Class
