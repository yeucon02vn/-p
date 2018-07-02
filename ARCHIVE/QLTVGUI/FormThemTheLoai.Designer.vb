<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormThemTheLoai
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
        Me.txtmatheloai = New System.Windows.Forms.TextBox()
        Me.txttentheloai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnhap = New System.Windows.Forms.Button()
        Me.btnhapthoat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtmatheloai
        '
        Me.txtmatheloai.BackColor = System.Drawing.Color.White
        Me.txtmatheloai.ForeColor = System.Drawing.Color.White
        Me.txtmatheloai.Location = New System.Drawing.Point(201, 104)
        Me.txtmatheloai.Margin = New System.Windows.Forms.Padding(5)
        Me.txtmatheloai.Name = "txtmatheloai"
        Me.txtmatheloai.ReadOnly = True
        Me.txtmatheloai.Size = New System.Drawing.Size(480, 34)
        Me.txtmatheloai.TabIndex = 0
        '
        'txttentheloai
        '
        Me.txttentheloai.BackColor = System.Drawing.Color.White
        Me.txttentheloai.ForeColor = System.Drawing.Color.White
        Me.txttentheloai.Location = New System.Drawing.Point(201, 178)
        Me.txttentheloai.Margin = New System.Windows.Forms.Padding(5)
        Me.txttentheloai.Name = "txttentheloai"
        Me.txttentheloai.Size = New System.Drawing.Size(480, 34)
        Me.txttentheloai.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Thể Loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Thể Loại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(261, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 43)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Thêm Thể Loại"
        '
        'btnhap
        '
        Me.btnhap.BackColor = System.Drawing.Color.White
        Me.btnhap.ForeColor = System.Drawing.Color.Black
        Me.btnhap.Location = New System.Drawing.Point(201, 234)
        Me.btnhap.Margin = New System.Windows.Forms.Padding(5)
        Me.btnhap.Name = "btnhap"
        Me.btnhap.Size = New System.Drawing.Size(170, 30)
        Me.btnhap.TabIndex = 5
        Me.btnhap.Text = "Nhập"
        Me.btnhap.UseVisualStyleBackColor = False
        '
        'btnhapthoat
        '
        Me.btnhapthoat.BackColor = System.Drawing.Color.White
        Me.btnhapthoat.ForeColor = System.Drawing.Color.Black
        Me.btnhapthoat.Location = New System.Drawing.Point(504, 234)
        Me.btnhapthoat.Margin = New System.Windows.Forms.Padding(5)
        Me.btnhapthoat.Name = "btnhapthoat"
        Me.btnhapthoat.Size = New System.Drawing.Size(177, 33)
        Me.btnhapthoat.TabIndex = 6
        Me.btnhapthoat.Text = "Nhập Và thoát"
        Me.btnhapthoat.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(714, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "X"
        '
        'FormThemTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 286)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnhapthoat)
        Me.Controls.Add(Me.btnhap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttentheloai)
        Me.Controls.Add(Me.txtmatheloai)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormThemTheLoai"
        Me.Text = "FormThemTheLoai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmatheloai As TextBox
    Friend WithEvents txttentheloai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnhap As Button
    Friend WithEvents btnhapthoat As Button
    Friend WithEvents Label4 As Label
End Class
