<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoMuonSach
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
        Me.lbtongsoluotmuon = New System.Windows.Forms.Label()
        Me.btlapbaocao = New System.Windows.Forms.Button()
        Me.dgvbaocao = New System.Windows.Forms.DataGridView()
        Me.dttgbc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvbaocao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Báo Cáo Mượn Sách"
        '
        'lbtongsoluotmuon
        '
        Me.lbtongsoluotmuon.AutoSize = True
        Me.lbtongsoluotmuon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtongsoluotmuon.Location = New System.Drawing.Point(397, 255)
        Me.lbtongsoluotmuon.Name = "lbtongsoluotmuon"
        Me.lbtongsoluotmuon.Size = New System.Drawing.Size(183, 23)
        Me.lbtongsoluotmuon.TabIndex = 1
        Me.lbtongsoluotmuon.Text = "Tổng Số Lượt Mượn"
        '
        'btlapbaocao
        '
        Me.btlapbaocao.BackColor = System.Drawing.Color.White
        Me.btlapbaocao.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlapbaocao.Location = New System.Drawing.Point(243, 281)
        Me.btlapbaocao.Name = "btlapbaocao"
        Me.btlapbaocao.Size = New System.Drawing.Size(158, 41)
        Me.btlapbaocao.TabIndex = 2
        Me.btlapbaocao.Text = "Lập Báo Cáo"
        Me.btlapbaocao.UseVisualStyleBackColor = False
        '
        'dgvbaocao
        '
        Me.dgvbaocao.BackgroundColor = System.Drawing.Color.White
        Me.dgvbaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbaocao.Location = New System.Drawing.Point(1, 81)
        Me.dgvbaocao.Name = "dgvbaocao"
        Me.dgvbaocao.RowTemplate.Height = 24
        Me.dgvbaocao.Size = New System.Drawing.Size(632, 171)
        Me.dgvbaocao.TabIndex = 3
        '
        'dttgbc
        '
        Me.dttgbc.Location = New System.Drawing.Point(116, 55)
        Me.dttgbc.Name = "dttgbc"
        Me.dttgbc.Size = New System.Drawing.Size(401, 22)
        Me.dttgbc.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Thời Gian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tourist Trap", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "X"
        '
        'BaoCaoMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(637, 326)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dttgbc)
        Me.Controls.Add(Me.dgvbaocao)
        Me.Controls.Add(Me.btlapbaocao)
        Me.Controls.Add(Me.lbtongsoluotmuon)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BaoCaoMuonSach"
        Me.Text = "BaoCaoMuonSach"
        CType(Me.dgvbaocao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbtongsoluotmuon As Label
    Friend WithEvents btlapbaocao As Button
    Friend WithEvents dgvbaocao As DataGridView
    Friend WithEvents dttgbc As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
