Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class QuanLyPhieuTraSach
    Private phieumuonsachBUS As PhieuMuonSachBUS
    Dim docgia As DocGiaDTO
    Dim docgiaBUS As DocGiaBUS
    Dim sachBUS As SachBUS
    Dim sach As SachDTO
    Dim masach As String
    Dim madocgia As String
    Dim day As Integer
    Dim quydinhBUS As QuyDinhBUS
    Dim quydinh As QuyDinhDTO
    Private Sub dgvtrasach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvtrasach.SelectionChanged
        Dim currentRowIndex As Integer = dgvtrasach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK

        If (-1 < currentRowIndex And currentRowIndex < dgvtrasach.RowCount) Then
            Try
                Dim pms = CType(dgvtrasach.Rows(currentRowIndex).DataBoundItem, PhieuMuonSacDTO)
                txtmaphieu.Text = pms.Maphieumuon
                txtmadocgia.Text = pms.Madocgia
                txtmasach.Text = pms.Masach

                dtpngaymuon.Value = pms.Ngaymuonsach
                dtpngaytra.Value = dtpngaymuon.Value.AddDays(4)
                dtpngaytrathucte.Value = pms.Ngaytrasach
                loaddocgia(txtmadocgia.Text)
                loadsach(txtmasach.Text)
                txttendocgia.Text = docgia.Tendocgia
                txttacgia.Text = sach.Tacgia
                txttheloai.Text = sach.Matheloai
                txttensach.Text = sach.Tensach
                madocgia = pms.Madocgia
                masach = pms.Masach
                tinhtienphat(dtpngaytra.Value, day)
                txtngaytratre.Text = day
                txttienphat.Text = pms.Tienphat
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub LoadListPhieuMuonSach()
        Dim listphieumuonsach = New List(Of PhieuMuonSacDTO)
        Dim result As Result
        result = phieumuonsachBUS.SelectALL(listphieumuonsach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu mượn sách không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvtrasach.Columns.Clear()
        dgvtrasach.DataSource = Nothing

        dgvtrasach.AutoGenerateColumns = False
        dgvtrasach.AllowUserToAddRows = False
        dgvtrasach.DataSource = listphieumuonsach

        Dim clmaphieu = New DataGridViewTextBoxColumn()
        clmaphieu.Name = "Maphieumuon"
        clmaphieu.HeaderText = "Mã Phiếu mượn Sách"
        clmaphieu.DataPropertyName = "Maphieumuon"
        dgvtrasach.Columns.Add(clmaphieu)

        Dim clngaytrasach = New DataGridViewTextBoxColumn()
        clngaytrasach.Name = "Madocgia"
        clngaytrasach.HeaderText = "Mã Độc Giả"
        clngaytrasach.DataPropertyName = "Madocgia"
        dgvtrasach.Columns.Add(clngaytrasach)

        Dim clmasach = New DataGridViewTextBoxColumn()
        clmasach.Name = "Masach"
        clmasach.HeaderText = "Mã Sách"
        clmasach.DataPropertyName = "Masach"
        dgvtrasach.Columns.Add(clmasach)

        Dim clngaymuon = New DataGridViewTextBoxColumn()
        clngaymuon.Name = "Ngaymuonsach"
        clngaymuon.HeaderText = "Ngày Mượn Sách"
        clngaymuon.DataPropertyName = "Ngaymuonsach"
        dgvtrasach.Columns.Add(clngaymuon)

        Dim clngaytra = New DataGridViewTextBoxColumn()
        clngaytra.Name = "Ngaytrasach"
        clngaytra.HeaderText = "Ngày trả sách"
        clngaytra.DataPropertyName = "Ngaytrasach"
        dgvtrasach.Columns.Add(clngaytra)

        Dim cltienphat = New DataGridViewTextBoxColumn()
        cltienphat.Name = "Tienphat"
        cltienphat.HeaderText = "Tiền Phạt"
        cltienphat.DataPropertyName = "Tienphat"
        dgvtrasach.Columns.Add(cltienphat)





    End Sub

    Private Sub QuanLyPhieuTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieumuonsachBUS = New PhieuMuonSachBUS()
        LoadListPhieuMuonSach()
        docgiaBUS = New DocGiaBUS()
        docgia = New DocGiaDTO()
        sach = New SachDTO()
        sachBUS = New SachBUS()
        quydinhBUS = New QuyDinhBUS()
        quydinh = New QuyDinhDTO()
    End Sub
    Private Function loadquydinh()
        quydinhBUS.selectALL(quydinh)
    End Function
    Private Function loaddocgia(ma As String)
        docgiaBUS.selectALL_MaDocGia(ma, docgia)
    End Function
    Public Function loadsach(ma As String)
        sachBUS.selectma(ma, sach)
    End Function


    Private Sub txtmaocgia_TextChanged(sender As Object, e As EventArgs) Handles txtmadocgia.TextChanged
        loaddocgia(txtmadocgia.Text)
        txttendocgia.Text = docgia.Tendocgia
    End Sub

    Private Sub txtmasach_TextChanged(sender As Object, e As EventArgs) Handles txtmasach.TextChanged
        loadsach(txtmasach.Text)
        txttensach.Text = sach.Tensach
        txttheloai.Text = sach.Matheloai
        txttacgia.Text = sach.Tacgia
    End Sub
    Private Function tinhtienphat(nt As DateTime, ByRef n As Integer)
        loadquydinh()
        Dim elapse As TimeSpan
        elapse = DateTime.Now.Subtract(nt)
        day = elapse.TotalDays
        day -= quydinh.Songaymuontoida


    End Function

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.Close()
    End Sub
End Class