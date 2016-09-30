Public Class frmTrangChu
    'Khai bao bien nhan ket qua tra ve cua form login
    Private _LoginResult As DialogResult
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim frm As New Login
        frm.ShowDialog()
        _LoginResult = frm.DialogResult
    End Sub

    Private Sub QuảnLýNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNhânViênToolStripMenuItem.Click
        frmQuanLyNhanSu.Show()
    End Sub

    Private Sub QuảnLýHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHóaĐơnToolStripMenuItem.Click
        frmHoaDon.Show()
    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        frmQuanLyBanMayTinh.Show()
    End Sub

    Private Sub ThêmHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHóaĐơnToolStripMenuItem.Click
        frmThemHoaDon.Show()
    End Sub

    Private Sub HợpĐồngLaoĐộngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HợpĐồngLaoĐộngToolStripMenuItem1.Click
        frmQuanLyHopDong.Show()
    End Sub

    Private Sub frmTrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _LoginResult <> DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class