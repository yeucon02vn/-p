<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoMuonTre
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
        Me.dgvbaocaomuontre = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbaocao = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvbaocaomuontre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvbaocaomuontre
        '
        Me.dgvbaocaomuontre.BackgroundColor = System.Drawing.Color.White
        Me.dgvbaocaomuontre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbaocaomuontre.Location = New System.Drawing.Point(12, 44)
        Me.dgvbaocaomuontre.Name = "dgvbaocaomuontre"
        Me.dgvbaocaomuontre.RowTemplate.Height = 24
        Me.dgvbaocaomuontre.Size = New System.Drawing.Size(776, 196)
        Me.dgvbaocaomuontre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Báo Cáo Sách Trể"
        '
        'txtbaocao
        '
        Me.txtbaocao.BackColor = System.Drawing.Color.White
        Me.txtbaocao.Location = New System.Drawing.Point(300, 243)
        Me.txtbaocao.Name = "txtbaocao"
        Me.txtbaocao.Size = New System.Drawing.Size(210, 47)
        Me.txtbaocao.TabIndex = 2
        Me.txtbaocao.Text = "Báo Cáo"
        Me.txtbaocao.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(766, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "X"
        '
        'BaoCaoMuonTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 302)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbaocao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvbaocaomuontre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BaoCaoMuonTre"
        Me.Text = "BaoCaoMuonTre"
        CType(Me.dgvbaocaomuontre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvbaocaomuontre As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbaocao As Button
    Friend WithEvents Label2 As Label
End Class
