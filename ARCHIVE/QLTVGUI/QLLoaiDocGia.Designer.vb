<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLLoaiDocGia
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
        Me.dgvdanhsachloaidocgia = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmaloaidocgia = New System.Windows.Forms.TextBox()
        Me.txttenloaidocgia = New System.Windows.Forms.TextBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvdanhsachloaidocgia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdanhsachloaidocgia
        '
        Me.dgvdanhsachloaidocgia.BackgroundColor = System.Drawing.Color.White
        Me.dgvdanhsachloaidocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsachloaidocgia.GridColor = System.Drawing.Color.Black
        Me.dgvdanhsachloaidocgia.Location = New System.Drawing.Point(12, 58)
        Me.dgvdanhsachloaidocgia.Name = "dgvdanhsachloaidocgia"
        Me.dgvdanhsachloaidocgia.RowTemplate.Height = 24
        Me.dgvdanhsachloaidocgia.Size = New System.Drawing.Size(670, 186)
        Me.dgvdanhsachloaidocgia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(244, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Danh Sách Loại Độc Giả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Loại Độc Giả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(8, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên Loại Độc Giả"
        '
        'txtmaloaidocgia
        '
        Me.txtmaloaidocgia.BackColor = System.Drawing.Color.White
        Me.txtmaloaidocgia.ForeColor = System.Drawing.Color.Black
        Me.txtmaloaidocgia.Location = New System.Drawing.Point(180, 273)
        Me.txtmaloaidocgia.Name = "txtmaloaidocgia"
        Me.txtmaloaidocgia.Size = New System.Drawing.Size(502, 22)
        Me.txtmaloaidocgia.TabIndex = 4
        '
        'txttenloaidocgia
        '
        Me.txttenloaidocgia.BackColor = System.Drawing.Color.White
        Me.txttenloaidocgia.ForeColor = System.Drawing.Color.Black
        Me.txttenloaidocgia.Location = New System.Drawing.Point(180, 324)
        Me.txttenloaidocgia.Name = "txttenloaidocgia"
        Me.txttenloaidocgia.Size = New System.Drawing.Size(502, 22)
        Me.txttenloaidocgia.TabIndex = 5
        '
        'btxoa
        '
        Me.btxoa.BackColor = System.Drawing.Color.White
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Location = New System.Drawing.Point(607, 361)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 38)
        Me.btxoa.TabIndex = 6
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = False
        '
        'btcapnhat
        '
        Me.btcapnhat.BackColor = System.Drawing.Color.White
        Me.btcapnhat.ForeColor = System.Drawing.Color.Black
        Me.btcapnhat.Location = New System.Drawing.Point(180, 361)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(75, 38)
        Me.btcapnhat.TabIndex = 7
        Me.btcapnhat.Text = "Cập Nhật"
        Me.btcapnhat.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(659, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "X"
        '
        'QLLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 411)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.txttenloaidocgia)
        Me.Controls.Add(Me.txtmaloaidocgia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdanhsachloaidocgia)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QLLoaiDocGia"
        Me.Text = "QLLoaiDocGia"
        CType(Me.dgvdanhsachloaidocgia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvdanhsachloaidocgia As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmaloaidocgia As TextBox
    Friend WithEvents txttenloaidocgia As TextBox
    Friend WithEvents btxoa As Button
    Friend WithEvents btcapnhat As Button
    Friend WithEvents Label4 As Label
End Class
