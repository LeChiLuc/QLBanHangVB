﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaCM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'txtMaSP
        '
        Me.txtMaSP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaSP.Location = New System.Drawing.Point(188, 91)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(244, 26)
        Me.txtMaSP.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Sản Phẩm:"
        '
        'txtTenSP
        '
        Me.txtTenSP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenSP.Location = New System.Drawing.Point(188, 126)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(244, 26)
        Me.txtTenSP.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Giá:"
        '
        'txtGia
        '
        Me.txtGia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtGia.Location = New System.Drawing.Point(188, 158)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(244, 26)
        Me.txtGia.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số Lượng:"
        '
        'txtSL
        '
        Me.txtSL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSL.Location = New System.Drawing.Point(188, 190)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(244, 26)
        Me.txtSL.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(131, 237)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(278, 237)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã Chuyên Mục:"
        '
        'txtMaCM
        '
        Me.txtMaCM.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaCM.Location = New System.Drawing.Point(188, 53)
        Me.txtMaCM.Name = "txtMaCM"
        Me.txtMaCM.ReadOnly = True
        Me.txtMaCM.Size = New System.Drawing.Size(244, 26)
        Me.txtMaCM.TabIndex = 1
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 320)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaCM)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSanPham"
        Me.Text = "Sản Phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSL As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaCM As TextBox
End Class
