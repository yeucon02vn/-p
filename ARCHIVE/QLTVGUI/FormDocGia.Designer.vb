<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDocGia
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmadocgia = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.dtpngaysinh = New System.Windows.Forms.DateTimePicker()
        Me.dtpngayhethan = New System.Windows.Forms.DateTimePicker()
        Me.cbmaloaidocgia = New System.Windows.Forms.ComboBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.btnhap = New System.Windows.Forms.Button()
        Me.dtpngaylapthe = New System.Windows.Forms.DateTimePicker()
        Me.btnhapthoat = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(489, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lập Thẻ Độc Giả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Độc Giả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Họ Tên Độc Giả"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(578, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ngày Sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 285)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Địa Chỉ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(578, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ngày Lập Thẻ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(578, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ngày Hết Hạn"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(578, 278)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 224)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Mã Loại Độc Giả"
        '
        'txtmadocgia
        '
        Me.txtmadocgia.BackColor = System.Drawing.Color.White
        Me.txtmadocgia.Location = New System.Drawing.Point(184, 99)
        Me.txtmadocgia.Name = "txtmadocgia"
        Me.txtmadocgia.ReadOnly = True
        Me.txtmadocgia.Size = New System.Drawing.Size(369, 30)
        Me.txtmadocgia.TabIndex = 1
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(184, 159)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(369, 30)
        Me.txthoten.TabIndex = 2
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(184, 278)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(369, 30)
        Me.txtdiachi.TabIndex = 3
        '
        'dtpngaysinh
        '
        Me.dtpngaysinh.Location = New System.Drawing.Point(763, 99)
        Me.dtpngaysinh.Name = "dtpngaysinh"
        Me.dtpngaysinh.Size = New System.Drawing.Size(369, 30)
        Me.dtpngaysinh.TabIndex = 5
        '
        'dtpngayhethan
        '
        Me.dtpngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngayhethan.Location = New System.Drawing.Point(763, 218)
        Me.dtpngayhethan.Name = "dtpngayhethan"
        Me.dtpngayhethan.Size = New System.Drawing.Size(369, 30)
        Me.dtpngayhethan.TabIndex = 6
        '
        'cbmaloaidocgia
        '
        Me.cbmaloaidocgia.FormattingEnabled = True
        Me.cbmaloaidocgia.Location = New System.Drawing.Point(184, 221)
        Me.cbmaloaidocgia.Name = "cbmaloaidocgia"
        Me.cbmaloaidocgia.Size = New System.Drawing.Size(369, 31)
        Me.cbmaloaidocgia.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(763, 278)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(369, 30)
        Me.txtemail.TabIndex = 8
        '
        'btnhap
        '
        Me.btnhap.BackColor = System.Drawing.Color.White
        Me.btnhap.ForeColor = System.Drawing.Color.Black
        Me.btnhap.Location = New System.Drawing.Point(184, 334)
        Me.btnhap.Name = "btnhap"
        Me.btnhap.Size = New System.Drawing.Size(164, 32)
        Me.btnhap.TabIndex = 9
        Me.btnhap.Text = "Nhập"
        Me.btnhap.UseVisualStyleBackColor = False
        '
        'dtpngaylapthe
        '
        Me.dtpngaylapthe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngaylapthe.Location = New System.Drawing.Point(763, 156)
        Me.dtpngaylapthe.Name = "dtpngaylapthe"
        Me.dtpngaylapthe.Size = New System.Drawing.Size(369, 30)
        Me.dtpngaylapthe.TabIndex = 5
        '
        'btnhapthoat
        '
        Me.btnhapthoat.BackColor = System.Drawing.Color.White
        Me.btnhapthoat.ForeColor = System.Drawing.Color.Black
        Me.btnhapthoat.Location = New System.Drawing.Point(763, 334)
        Me.btnhapthoat.Name = "btnhapthoat"
        Me.btnhapthoat.Size = New System.Drawing.Size(164, 32)
        Me.btnhapthoat.TabIndex = 9
        Me.btnhapthoat.Text = "Nhập Và Thoát"
        Me.btnhapthoat.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(545, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "X"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1109, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 23)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "X"
        '
        'FormDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 385)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnhapthoat)
        Me.Controls.Add(Me.btnhap)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.cbmaloaidocgia)
        Me.Controls.Add(Me.dtpngayhethan)
        Me.Controls.Add(Me.dtpngaylapthe)
        Me.Controls.Add(Me.dtpngaysinh)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtmadocgia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormDocGia"
        Me.Text = "FormDocGia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtmadocgia As TextBox
    Friend WithEvents txthoten As TextBox
    Friend WithEvents txtdiachi As TextBox
    Friend WithEvents dtpngaysinh As DateTimePicker
    Friend WithEvents dtpngayhethan As DateTimePicker
    Friend WithEvents cbmaloaidocgia As ComboBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents btnhap As Button
    Friend WithEvents dtpngaylapthe As DateTimePicker
    Friend WithEvents btnhapthoat As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
