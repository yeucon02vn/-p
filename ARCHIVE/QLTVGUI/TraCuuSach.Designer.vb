<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraCuuSach
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
        Me.txttensach = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbtimkientheo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttensach
        '
        Me.txttensach.BackColor = System.Drawing.Color.White
        Me.txttensach.ForeColor = System.Drawing.Color.Black
        Me.txttensach.Location = New System.Drawing.Point(12, 138)
        Me.txttensach.Name = "txttensach"
        Me.txttensach.Size = New System.Drawing.Size(546, 22)
        Me.txttensach.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(564, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 71)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tra Cứu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvsach
        '
        Me.dgvsach.BackgroundColor = System.Drawing.Color.White
        Me.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsach.Location = New System.Drawing.Point(12, 190)
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.RowTemplate.Height = 24
        Me.dgvsach.Size = New System.Drawing.Size(694, 306)
        Me.dgvsach.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(245, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tra Cứu Sách"
        '
        'cbtimkientheo
        '
        Me.cbtimkientheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtimkientheo.FormattingEnabled = True
        Me.cbtimkientheo.Location = New System.Drawing.Point(12, 89)
        Me.cbtimkientheo.Name = "cbtimkientheo"
        Me.cbtimkientheo.Size = New System.Drawing.Size(546, 24)
        Me.cbtimkientheo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(699, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X"
        '
        'TraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(730, 497)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbtimkientheo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvsach)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttensach)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TraCuuSach"
        Me.Text = "TraCuuSach"
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttensach As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbtimkientheo As ComboBox
    Friend WithEvents Label2 As Label
End Class
