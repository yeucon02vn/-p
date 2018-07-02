<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormThemTinhTrang
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
        Me.txtmatinhtrang = New System.Windows.Forms.TextBox()
        Me.txttentinhtrang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnhap = New System.Windows.Forms.Button()
        Me.btnhapthoat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtmatinhtrang
        '
        Me.txtmatinhtrang.BackColor = System.Drawing.Color.White
        Me.txtmatinhtrang.ForeColor = System.Drawing.Color.Black
        Me.txtmatinhtrang.Location = New System.Drawing.Point(121, 105)
        Me.txtmatinhtrang.Name = "txtmatinhtrang"
        Me.txtmatinhtrang.ReadOnly = True
        Me.txtmatinhtrang.Size = New System.Drawing.Size(419, 22)
        Me.txtmatinhtrang.TabIndex = 0
        '
        'txttentinhtrang
        '
        Me.txttentinhtrang.BackColor = System.Drawing.Color.White
        Me.txttentinhtrang.ForeColor = System.Drawing.Color.Black
        Me.txttentinhtrang.Location = New System.Drawing.Point(121, 169)
        Me.txttentinhtrang.Name = "txttentinhtrang"
        Me.txttentinhtrang.Size = New System.Drawing.Size(419, 22)
        Me.txttentinhtrang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Tình Trạng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Tình Trạng"
        '
        'btnhap
        '
        Me.btnhap.BackColor = System.Drawing.Color.White
        Me.btnhap.Location = New System.Drawing.Point(121, 223)
        Me.btnhap.Name = "btnhap"
        Me.btnhap.Size = New System.Drawing.Size(184, 45)
        Me.btnhap.TabIndex = 4
        Me.btnhap.Text = "Nhập"
        Me.btnhap.UseVisualStyleBackColor = False
        '
        'btnhapthoat
        '
        Me.btnhapthoat.BackColor = System.Drawing.Color.White
        Me.btnhapthoat.Location = New System.Drawing.Point(356, 223)
        Me.btnhapthoat.Name = "btnhapthoat"
        Me.btnhapthoat.Size = New System.Drawing.Size(184, 45)
        Me.btnhapthoat.TabIndex = 5
        Me.btnhapthoat.Text = "Nhập Và Thoát"
        Me.btnhapthoat.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(152, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Thêm Tình Trạng Sách"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(519, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "X"
        '
        'FormThemTinhTrang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(557, 285)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnhapthoat)
        Me.Controls.Add(Me.btnhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttentinhtrang)
        Me.Controls.Add(Me.txtmatinhtrang)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormThemTinhTrang"
        Me.Text = "FormThemTinhTrang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmatinhtrang As TextBox
    Friend WithEvents txttentinhtrang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnhap As Button
    Friend WithEvents btnhapthoat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
