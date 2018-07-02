<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLSach
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
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.txtmasach = New System.Windows.Forms.TextBox()
        Me.txttensach = New System.Windows.Forms.TextBox()
        Me.txttacgia = New System.Windows.Forms.TextBox()
        Me.txtnhaxuatban = New System.Windows.Forms.TextBox()
        Me.txttrigia = New System.Windows.Forms.TextBox()
        Me.dtpngaynhap = New System.Windows.Forms.DateTimePicker()
        Me.txtkhoangcachnam = New System.Windows.Forms.TextBox()
        Me.txtnamxuatban = New System.Windows.Forms.TextBox()
        Me.cbtheloaicapnhat = New System.Windows.Forms.ComboBox()
        Me.cbtrinhtrangcapnhat = New System.Windows.Forms.ComboBox()
        Me.cbtheloai = New System.Windows.Forms.ComboBox()
        Me.cbtrinhtrang = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvsach
        '
        Me.dgvsach.BackgroundColor = System.Drawing.Color.White
        Me.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsach.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvsach.Location = New System.Drawing.Point(8, 86)
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.RowTemplate.Height = 24
        Me.dgvsach.Size = New System.Drawing.Size(845, 235)
        Me.dgvsach.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(363, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quản Lý Sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên Sách"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Thể Loại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tác Giả"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nhà Xuât Bản"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(445, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Năm Xuất Bản"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(445, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Trị Giá"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(445, 409)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Khoảng Cách Năm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(445, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Trình Trạng"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(445, 490)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Ngày Nhập"
        '
        'btcapnhat
        '
        Me.btcapnhat.BackColor = System.Drawing.Color.White
        Me.btcapnhat.ForeColor = System.Drawing.Color.Black
        Me.btcapnhat.Location = New System.Drawing.Point(108, 518)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(112, 37)
        Me.btcapnhat.TabIndex = 12
        Me.btcapnhat.Text = "Cập Nhật"
        Me.btcapnhat.UseVisualStyleBackColor = False
        '
        'btxoa
        '
        Me.btxoa.BackColor = System.Drawing.Color.White
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Location = New System.Drawing.Point(581, 518)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(98, 37)
        Me.btxoa.TabIndex = 13
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = False
        '
        'txtmasach
        '
        Me.txtmasach.BackColor = System.Drawing.Color.White
        Me.txtmasach.ForeColor = System.Drawing.Color.Black
        Me.txtmasach.Location = New System.Drawing.Point(108, 327)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.Size = New System.Drawing.Size(304, 25)
        Me.txtmasach.TabIndex = 14
        '
        'txttensach
        '
        Me.txttensach.BackColor = System.Drawing.Color.White
        Me.txttensach.ForeColor = System.Drawing.Color.Black
        Me.txttensach.Location = New System.Drawing.Point(108, 369)
        Me.txttensach.Name = "txttensach"
        Me.txttensach.Size = New System.Drawing.Size(304, 25)
        Me.txttensach.TabIndex = 15
        '
        'txttacgia
        '
        Me.txttacgia.BackColor = System.Drawing.Color.White
        Me.txttacgia.ForeColor = System.Drawing.Color.Black
        Me.txttacgia.Location = New System.Drawing.Point(108, 446)
        Me.txttacgia.Name = "txttacgia"
        Me.txttacgia.Size = New System.Drawing.Size(304, 25)
        Me.txttacgia.TabIndex = 16
        '
        'txtnhaxuatban
        '
        Me.txtnhaxuatban.BackColor = System.Drawing.Color.White
        Me.txtnhaxuatban.ForeColor = System.Drawing.Color.Black
        Me.txtnhaxuatban.Location = New System.Drawing.Point(108, 487)
        Me.txtnhaxuatban.Name = "txtnhaxuatban"
        Me.txtnhaxuatban.Size = New System.Drawing.Size(304, 25)
        Me.txtnhaxuatban.TabIndex = 17
        '
        'txttrigia
        '
        Me.txttrigia.BackColor = System.Drawing.Color.White
        Me.txttrigia.ForeColor = System.Drawing.Color.Black
        Me.txttrigia.Location = New System.Drawing.Point(581, 369)
        Me.txttrigia.Name = "txttrigia"
        Me.txttrigia.Size = New System.Drawing.Size(272, 25)
        Me.txttrigia.TabIndex = 18
        '
        'dtpngaynhap
        '
        Me.dtpngaynhap.Location = New System.Drawing.Point(581, 490)
        Me.dtpngaynhap.Name = "dtpngaynhap"
        Me.dtpngaynhap.Size = New System.Drawing.Size(272, 25)
        Me.dtpngaynhap.TabIndex = 19
        '
        'txtkhoangcachnam
        '
        Me.txtkhoangcachnam.BackColor = System.Drawing.Color.White
        Me.txtkhoangcachnam.ForeColor = System.Drawing.Color.Black
        Me.txtkhoangcachnam.Location = New System.Drawing.Point(581, 409)
        Me.txtkhoangcachnam.Name = "txtkhoangcachnam"
        Me.txtkhoangcachnam.Size = New System.Drawing.Size(272, 25)
        Me.txtkhoangcachnam.TabIndex = 20
        '
        'txtnamxuatban
        '
        Me.txtnamxuatban.BackColor = System.Drawing.Color.White
        Me.txtnamxuatban.ForeColor = System.Drawing.Color.Black
        Me.txtnamxuatban.Location = New System.Drawing.Point(581, 327)
        Me.txtnamxuatban.Name = "txtnamxuatban"
        Me.txtnamxuatban.Size = New System.Drawing.Size(272, 25)
        Me.txtnamxuatban.TabIndex = 21
        '
        'cbtheloaicapnhat
        '
        Me.cbtheloaicapnhat.BackColor = System.Drawing.Color.White
        Me.cbtheloaicapnhat.ForeColor = System.Drawing.Color.Black
        Me.cbtheloaicapnhat.FormattingEnabled = True
        Me.cbtheloaicapnhat.Location = New System.Drawing.Point(108, 409)
        Me.cbtheloaicapnhat.Name = "cbtheloaicapnhat"
        Me.cbtheloaicapnhat.Size = New System.Drawing.Size(304, 25)
        Me.cbtheloaicapnhat.TabIndex = 22
        '
        'cbtrinhtrangcapnhat
        '
        Me.cbtrinhtrangcapnhat.BackColor = System.Drawing.Color.White
        Me.cbtrinhtrangcapnhat.ForeColor = System.Drawing.Color.Black
        Me.cbtrinhtrangcapnhat.FormattingEnabled = True
        Me.cbtrinhtrangcapnhat.Location = New System.Drawing.Point(581, 446)
        Me.cbtrinhtrangcapnhat.Name = "cbtrinhtrangcapnhat"
        Me.cbtrinhtrangcapnhat.Size = New System.Drawing.Size(272, 25)
        Me.cbtrinhtrangcapnhat.TabIndex = 23
        '
        'cbtheloai
        '
        Me.cbtheloai.BackColor = System.Drawing.Color.White
        Me.cbtheloai.ForeColor = System.Drawing.Color.Black
        Me.cbtheloai.FormattingEnabled = True
        Me.cbtheloai.Location = New System.Drawing.Point(84, 55)
        Me.cbtheloai.Name = "cbtheloai"
        Me.cbtheloai.Size = New System.Drawing.Size(304, 25)
        Me.cbtheloai.TabIndex = 24
        '
        'cbtrinhtrang
        '
        Me.cbtrinhtrang.BackColor = System.Drawing.Color.White
        Me.cbtrinhtrang.ForeColor = System.Drawing.Color.Black
        Me.cbtrinhtrang.FormattingEnabled = True
        Me.cbtrinhtrang.Location = New System.Drawing.Point(485, 55)
        Me.cbtrinhtrang.Name = "cbtrinhtrang"
        Me.cbtrinhtrang.Size = New System.Drawing.Size(368, 25)
        Me.cbtrinhtrang.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(3, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Thể Loại"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(394, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Trình Trạng"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(825, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 26)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "X"
        '
        'QLSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(865, 560)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbtrinhtrang)
        Me.Controls.Add(Me.cbtheloai)
        Me.Controls.Add(Me.cbtrinhtrangcapnhat)
        Me.Controls.Add(Me.cbtheloaicapnhat)
        Me.Controls.Add(Me.txtnamxuatban)
        Me.Controls.Add(Me.txtkhoangcachnam)
        Me.Controls.Add(Me.dtpngaynhap)
        Me.Controls.Add(Me.txttrigia)
        Me.Controls.Add(Me.txtnhaxuatban)
        Me.Controls.Add(Me.txttacgia)
        Me.Controls.Add(Me.txttensach)
        Me.Controls.Add(Me.txtmasach)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvsach)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QLSach"
        Me.Text = "QLSach"
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btcapnhat As Button
    Friend WithEvents btxoa As Button
    Friend WithEvents txtmasach As TextBox
    Friend WithEvents txttensach As TextBox
    Friend WithEvents txttacgia As TextBox
    Friend WithEvents txtnhaxuatban As TextBox
    Friend WithEvents txttrigia As TextBox
    Friend WithEvents dtpngaynhap As DateTimePicker
    Friend WithEvents txtkhoangcachnam As TextBox
    Friend WithEvents txtnamxuatban As TextBox
    Friend WithEvents cbtheloaicapnhat As ComboBox
    Friend WithEvents cbtrinhtrangcapnhat As ComboBox
    Friend WithEvents cbtheloai As ComboBox
    Friend WithEvents cbtrinhtrang As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
