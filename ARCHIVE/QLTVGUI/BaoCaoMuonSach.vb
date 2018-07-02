Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class BaoCaoMuonSach
    Private baocaomuonsachBUS As BaoCaoMuonSachBUS
    Private Sub BaoCaoMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baocaomuonsachBUS = New BaoCaoMuonSachBUS()

    End Sub

    Private Sub btlapbaocao_Click(sender As Object, e As EventArgs) Handles btlapbaocao.Click
        If dttgbc.Value <> Nothing Then
            LoadListChiTietBaoCao()
        End If
    End Sub
    Private Sub LoadListChiTietBaoCao()
        Dim tongSoLuotMuon As Integer = 0
        If dttgbc.Value <> Nothing Then
            Dim listTinhHinhMuonSach = New List(Of BaoCaoMuonSachDTO)
            listTinhHinhMuonSach = baocaomuonsachBUS.SelectALL(dttgbc.Value.Month, dttgbc.Value.Year)


            dgvbaocao.Columns.Clear()
            dgvbaocao.DataSource = Nothing

            dgvbaocao.AutoGenerateColumns = False
            dgvbaocao.AllowUserToAddRows = False
            dgvbaocao.DataSource = New BindingSource(listTinhHinhMuonSach, String.Empty)
            Dim cltensach = New DataGridViewTextBoxColumn()
            cltensach.Name = "Tentheloai"
            cltensach.HeaderText = "Tên Thể Loại"
            cltensach.DataPropertyName = "Tentheloai"
            dgvbaocao.Columns.Add(cltensach)

            Dim clslm = New DataGridViewTextBoxColumn()
            clslm.Name = "Soluotmuon"
            clslm.HeaderText = "Số Lượt Mượn"
            clslm.DataPropertyName = "Soluotmuon"
            dgvbaocao.Columns.Add(clslm)

            Dim cltile = New DataGridViewTextBoxColumn()
            cltile.Name = "Tile"
            cltile.HeaderText = "Tỉ Lệ Phần Trăm"
            cltile.DataPropertyName = "Tile"
            dgvbaocao.Columns.Add(cltile)


            For Each dt As BaoCaoMuonSachDTO In listTinhHinhMuonSach
                tongSoLuotMuon += dt.Soluotmuon
            Next
            lbtongsoluotmuon.Text = "Tổng số lượt mượn: " & tongSoLuotMuon
        End If
        dgvbaocao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub

    Private Sub dttgbc_ValueChanged(sender As Object, e As EventArgs) Handles dttgbc.ValueChanged
        LoadListChiTietBaoCao()
        dttgbc.CustomFormat = "MM:yyyy"
        dttgbc.Format = DateTimePickerFormat.Custom
        dttgbc.ShowUpDown = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class