<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLTheloai
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
        Me.dgvtheloai = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmatheloai = New System.Windows.Forms.TextBox()
        Me.txttentheloai = New System.Windows.Forms.TextBox()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvtheloai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvtheloai
        '
        Me.dgvtheloai.BackgroundColor = System.Drawing.Color.White
        Me.dgvtheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtheloai.Location = New System.Drawing.Point(19, 54)
        Me.dgvtheloai.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvtheloai.Name = "dgvtheloai"
        Me.dgvtheloai.RowTemplate.Height = 24
        Me.dgvtheloai.Size = New System.Drawing.Size(424, 140)
        Me.dgvtheloai.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(16, 208)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Thể Loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 255)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Thể Loại"
        '
        'txtmatheloai
        '
        Me.txtmatheloai.BackColor = System.Drawing.Color.White
        Me.txtmatheloai.ForeColor = System.Drawing.Color.Black
        Me.txtmatheloai.Location = New System.Drawing.Point(153, 202)
        Me.txtmatheloai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmatheloai.Name = "txtmatheloai"
        Me.txtmatheloai.Size = New System.Drawing.Size(290, 28)
        Me.txtmatheloai.TabIndex = 3
        '
        'txttentheloai
        '
        Me.txttentheloai.BackColor = System.Drawing.Color.White
        Me.txttentheloai.ForeColor = System.Drawing.Color.Black
        Me.txttentheloai.Location = New System.Drawing.Point(153, 255)
        Me.txttentheloai.Margin = New System.Windows.Forms.Padding(4)
        Me.txttentheloai.Name = "txttentheloai"
        Me.txttentheloai.Size = New System.Drawing.Size(290, 28)
        Me.txttentheloai.TabIndex = 4
        '
        'btcapnhat
        '
        Me.btcapnhat.BackColor = System.Drawing.Color.White
        Me.btcapnhat.ForeColor = System.Drawing.Color.Black
        Me.btcapnhat.Location = New System.Drawing.Point(153, 300)
        Me.btcapnhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(97, 28)
        Me.btcapnhat.TabIndex = 5
        Me.btcapnhat.Text = "Cập nhật"
        Me.btcapnhat.UseVisualStyleBackColor = False
        '
        'btxoa
        '
        Me.btxoa.BackColor = System.Drawing.Color.White
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Location = New System.Drawing.Point(327, 300)
        Me.btxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(116, 28)
        Me.btxoa.TabIndex = 6
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(103, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quản Lý Thể Loại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(420, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "X"
        '
        'QLTheloai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(460, 333)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.txttentheloai)
        Me.Controls.Add(Me.txtmatheloai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvtheloai)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "QLTheloai"
        Me.Text = "QLTheloai"
        CType(Me.dgvtheloai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvtheloai As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmatheloai As TextBox
    Friend WithEvents txttentheloai As TextBox
    Friend WithEvents btcapnhat As Button
    Friend WithEvents btxoa As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
