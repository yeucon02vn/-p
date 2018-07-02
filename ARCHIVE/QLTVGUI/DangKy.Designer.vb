<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangKy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DangKy))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btdangky = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.txttentaikhoan = New System.Windows.Forms.TextBox()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Tài Khoản"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mật Khẩu"
        '
        'btdangky
        '
        Me.btdangky.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdangky.Location = New System.Drawing.Point(89, 165)
        Me.btdangky.Name = "btdangky"
        Me.btdangky.Size = New System.Drawing.Size(82, 28)
        Me.btdangky.TabIndex = 3
        Me.btdangky.Text = "Đăng Ký"
        Me.btdangky.UseVisualStyleBackColor = True
        '
        'btthoat
        '
        Me.btthoat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.Location = New System.Drawing.Point(275, 165)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(95, 28)
        Me.btthoat.TabIndex = 4
        Me.btthoat.Text = "Thoát"
        Me.btthoat.UseVisualStyleBackColor = True
        '
        'txttentaikhoan
        '
        Me.txttentaikhoan.Location = New System.Drawing.Point(138, 79)
        Me.txttentaikhoan.Name = "txttentaikhoan"
        Me.txttentaikhoan.Size = New System.Drawing.Size(232, 22)
        Me.txttentaikhoan.TabIndex = 6
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(138, 127)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.Size = New System.Drawing.Size(232, 22)
        Me.txtmatkhau.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(158, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'DangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(386, 214)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.txttentaikhoan)
        Me.Controls.Add(Me.btthoat)
        Me.Controls.Add(Me.btdangky)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DangKy"
        Me.Text = "DangKy"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btdangky As Button
    Friend WithEvents btthoat As Button
    Friend WithEvents txttentaikhoan As TextBox
    Friend WithEvents txtmatkhau As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
