<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLTinhTrangSach
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmatinhtrang = New System.Windows.Forms.TextBox()
        Me.txttentinhtrang = New System.Windows.Forms.TextBox()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.dgvtinhtrangsach = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvtinhtrangsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Tình Trạng Sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Tình Trạng Sách"
        '
        'txtmatinhtrang
        '
        Me.txtmatinhtrang.BackColor = System.Drawing.Color.White
        Me.txtmatinhtrang.ForeColor = System.Drawing.Color.Black
        Me.txtmatinhtrang.Location = New System.Drawing.Point(169, 220)
        Me.txtmatinhtrang.Name = "txtmatinhtrang"
        Me.txtmatinhtrang.Size = New System.Drawing.Size(328, 22)
        Me.txtmatinhtrang.TabIndex = 2
        '
        'txttentinhtrang
        '
        Me.txttentinhtrang.BackColor = System.Drawing.Color.White
        Me.txttentinhtrang.ForeColor = System.Drawing.Color.Black
        Me.txttentinhtrang.Location = New System.Drawing.Point(169, 261)
        Me.txttentinhtrang.Name = "txttentinhtrang"
        Me.txttentinhtrang.Size = New System.Drawing.Size(328, 22)
        Me.txttentinhtrang.TabIndex = 2
        '
        'btcapnhat
        '
        Me.btcapnhat.BackColor = System.Drawing.Color.White
        Me.btcapnhat.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcapnhat.ForeColor = System.Drawing.Color.Black
        Me.btcapnhat.Location = New System.Drawing.Point(11, 294)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(101, 37)
        Me.btcapnhat.TabIndex = 3
        Me.btcapnhat.Text = "Cập Nhật"
        Me.btcapnhat.UseVisualStyleBackColor = False
        '
        'btxoa
        '
        Me.btxoa.BackColor = System.Drawing.Color.White
        Me.btxoa.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Location = New System.Drawing.Point(396, 294)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(101, 37)
        Me.btxoa.TabIndex = 4
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = False
        '
        'dgvtinhtrangsach
        '
        Me.dgvtinhtrangsach.BackgroundColor = System.Drawing.Color.White
        Me.dgvtinhtrangsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtinhtrangsach.Location = New System.Drawing.Point(11, 56)
        Me.dgvtinhtrangsach.Name = "dgvtinhtrangsach"
        Me.dgvtinhtrangsach.RowTemplate.Height = 24
        Me.dgvtinhtrangsach.Size = New System.Drawing.Size(486, 150)
        Me.dgvtinhtrangsach.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(87, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quản Lý Tình Trạng Sách"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(469, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "X"
        '
        'QLTinhTrangSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(503, 341)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvtinhtrangsach)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.txttentinhtrang)
        Me.Controls.Add(Me.txtmatinhtrang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QLTinhTrangSach"
        Me.Text = "QLTinhTrangSach"
        CType(Me.dgvtinhtrangsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmatinhtrang As TextBox
    Friend WithEvents txttentinhtrang As TextBox
    Friend WithEvents btcapnhat As Button
    Friend WithEvents btxoa As Button
    Friend WithEvents dgvtinhtrangsach As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
