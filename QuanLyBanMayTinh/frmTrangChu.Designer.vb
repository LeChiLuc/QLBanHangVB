<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrangChu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HợpĐồngLaoĐộngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HợpĐồngLaoĐộngToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuanToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.HợpĐồngLaoĐộngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuanToolStripMenuItem
        '
        Me.QuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýNhânViênToolStripMenuItem, Me.QuảnLýHóaĐơnToolStripMenuItem, Me.QuảnLýSảnPhẩmToolStripMenuItem})
        Me.QuanToolStripMenuItem.Name = "QuanToolStripMenuItem"
        Me.QuanToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuanToolStripMenuItem.Text = "Quản lý"
        '
        'QuảnLýNhânViênToolStripMenuItem
        '
        Me.QuảnLýNhânViênToolStripMenuItem.Name = "QuảnLýNhânViênToolStripMenuItem"
        Me.QuảnLýNhânViênToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.QuảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên"
        '
        'QuảnLýHóaĐơnToolStripMenuItem
        '
        Me.QuảnLýHóaĐơnToolStripMenuItem.Name = "QuảnLýHóaĐơnToolStripMenuItem"
        Me.QuảnLýHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.QuảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmHóaĐơnToolStripMenuItem})
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'ThêmHóaĐơnToolStripMenuItem
        '
        Me.ThêmHóaĐơnToolStripMenuItem.Name = "ThêmHóaĐơnToolStripMenuItem"
        Me.ThêmHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThêmHóaĐơnToolStripMenuItem.Text = "Thêm hóa đơn"
        '
        'HợpĐồngLaoĐộngToolStripMenuItem
        '
        Me.HợpĐồngLaoĐộngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HợpĐồngLaoĐộngToolStripMenuItem1})
        Me.HợpĐồngLaoĐộngToolStripMenuItem.Name = "HợpĐồngLaoĐộngToolStripMenuItem"
        Me.HợpĐồngLaoĐộngToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.HợpĐồngLaoĐộngToolStripMenuItem.Text = "Hợp đồng"
        '
        'HợpĐồngLaoĐộngToolStripMenuItem1
        '
        Me.HợpĐồngLaoĐộngToolStripMenuItem1.Name = "HợpĐồngLaoĐộngToolStripMenuItem1"
        Me.HợpĐồngLaoĐộngToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.HợpĐồngLaoĐộngToolStripMenuItem1.Text = "Hợp đồng lao động"
        '
        'frmTrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmTrangChu"
        Me.Text = "frmTrangChu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýNhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýHóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmHóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HợpĐồngLaoĐộngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HợpĐồngLaoĐộngToolStripMenuItem1 As ToolStripMenuItem
End Class
