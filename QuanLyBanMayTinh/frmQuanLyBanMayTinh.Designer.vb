<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyBanMayTinh
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
        Me.dgvCommon = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCM = New System.Windows.Forms.ComboBox()
        Me.cmbTimKiem = New System.Windows.Forms.ComboBox()
        CType(Me.dgvCommon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCommon
        '
        Me.dgvCommon.AllowUserToAddRows = False
        Me.dgvCommon.AllowUserToDeleteRows = False
        Me.dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCommon.Location = New System.Drawing.Point(30, 103)
        Me.dgvCommon.MultiSelect = False
        Me.dgvCommon.Name = "dgvCommon"
        Me.dgvCommon.ReadOnly = True
        Me.dgvCommon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCommon.Size = New System.Drawing.Size(728, 305)
        Me.dgvCommon.TabIndex = 0
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.Location = New System.Drawing.Point(827, 105)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(116, 46)
        Me.btnThem.TabIndex = 1
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSua.Location = New System.Drawing.Point(827, 167)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(116, 46)
        Me.btnSua.TabIndex = 1
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(827, 229)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(116, 46)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tìm kiếm"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(209, 77)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(549, 20)
        Me.txtTimKiem.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCM)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(776, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
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
        'cmbTimKiem
        '
        Me.cmbTimKiem.FormattingEnabled = True
        Me.cmbTimKiem.Items.AddRange(New Object() {"MaSP", "Ten"})
        Me.cmbTimKiem.Location = New System.Drawing.Point(82, 77)
        Me.cmbTimKiem.Name = "cmbTimKiem"
        Me.cmbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cmbTimKiem.TabIndex = 14
        '
        'frmQuanLyBanMayTinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 506)
        Me.Controls.Add(Me.cmbTimKiem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvCommon)
        Me.Name = "frmQuanLyBanMayTinh"
        Me.Text = "Quan Ly Ban May Tính"
        CType(Me.dgvCommon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCommon As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCM As ComboBox
    Friend WithEvents cmbTimKiem As ComboBox
End Class
