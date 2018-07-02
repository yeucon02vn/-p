Imports QLTVDTO
Imports Utility
Imports QLTVBUS
Public Class QuanLyPhieuMuonSach
    Private phieumuonsachBUS As PhieuMuonSachBUS
    Dim docgia As DocGiaDTO
    Dim docgiaBUS As DocGiaBUS
    Dim sachBUS As SachBUS
    Dim sach As SachDTO
    Dim masach As String
    Dim madocgia As String
    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim currentRowIndex As Integer = dgvquanluphieumuonsach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvquanluphieumuonsach.RowCount) Then
            Try
                Dim pms As PhieuMuonSacDTO
                pms = New PhieuMuonSacDTO()


                '1. Mapping data from GUI control
                pms.Maphieumuon = txtmaphieu.Text
                pms.Masach = txtmasach.Text
                pms.Madocgia = txtmadocgia.Text
                pms.Ngaymuonsach = dtpngaymuon.Value
                pms.Ngaytrasach = dtpngaytrasach.Value
                pms.Tienphat = txttienphat.Text
                If (txtmadocgia.Text <> madocgia) Then
                    capnhatdocgia1(txtmadocgia.Text)
                    loaddocgia(txtmadocgia.Text)
                    If (phieumuonsachBUS.kiemtratinhtrangthe(docgia) = False) Then
                        MessageBox.Show("Thẻ Độc Giả Hết Hạn")
                        Return
                    End If
                    capnhatdocgia(madocgia)
                End If
                If (txtmasach.Text <> masach) Then
                    capnhatsach1(txtmasach.Text)
                    If (phieumuonsachBUS.kiemtrasach(sach) = False) Then
                        MessageBox.Show("Sách Đã được mượn")
                        Return
                    End If
                    capnhatsach(masach)
                End If
                '2. Business .....       

                '3. Insert to DB

                Dim result As Result
                result = phieumuonsachBUS.update(pms)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    LoadListPhieuMuonSach()
                    ' Hightlight the row has been updated on table
                    dgvquanluphieumuonsach.Rows(currentRowIndex).Selected = True
                    Try
                        Dim phieumuonsach = CType(dgvquanluphieumuonsach.Rows(currentRowIndex).DataBoundItem, PhieuMuonSacDTO)
                        txtmaphieu.Text = phieumuonsach.Maphieumuon
                        txtmadocgia.Text = phieumuonsach.Madocgia
                        txtmasach.Text = phieumuonsach.Masach
                        txttienphat.Text = phieumuonsach.Tienphat
                        dtpngaymuon.Value = phieumuonsach.Ngaymuonsach
                        dtpngaytrasach.Value = phieumuonsach.Ngaytrasach
                        loaddocgia(txtmadocgia.Text)
                        loadsach(txtmasach.Text)
                        txttendocgia.Text = docgia.Tendocgia
                        txttacgia.Text = sach.Tacgia
                        txttheloai.Text = sach.Matheloai
                        TextBox6.Text = sach.Tensach

                        capnhatdocgia(txtmadocgia.Text)
                        capnhatsach(txtmasach.Text)
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập phiếu mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật phiếu mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub



    Private Sub dgvquanluphieumuonsach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvquanluphieumuonsach.SelectionChanged
        Dim currentRowIndex As Integer = dgvquanluphieumuonsach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK

        If (-1 < currentRowIndex And currentRowIndex < dgvquanluphieumuonsach.RowCount) Then
            Try
                Dim pms = CType(dgvquanluphieumuonsach.Rows(currentRowIndex).DataBoundItem, PhieuMuonSacDTO)
                txtmaphieu.Text = pms.Maphieumuon
                txtmadocgia.Text = pms.Madocgia
                txtmasach.Text = pms.Masach
                txttienphat.Text = pms.Tienphat
                dtpngaymuon.Value = pms.Ngaymuonsach
                dtpngaytrasach.Value = pms.Ngaytrasach
                loaddocgia(txtmadocgia.Text)
                loadsach(txtmasach.Text)
                txttendocgia.Text = docgia.Tendocgia
                txttacgia.Text = sach.Tacgia
                txttheloai.Text = sach.Matheloai
                TextBox6.Text = sach.Tensach
                madocgia = pms.Madocgia
                masach = pms.Masach
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub QuanLyPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieumuonsachBUS = New PhieuMuonSachBUS()
        LoadListPhieuMuonSach()
        docgiaBUS = New DocGiaBUS()
        docgia = New DocGiaDTO()
        sach = New SachDTO()
        sachBUS = New SachBUS()
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
        dgvquanluphieumuonsach.Columns.Clear()
        dgvquanluphieumuonsach.DataSource = Nothing

        dgvquanluphieumuonsach.AutoGenerateColumns = False
        dgvquanluphieumuonsach.AllowUserToAddRows = False
        dgvquanluphieumuonsach.DataSource = listphieumuonsach

        Dim clmaphieu = New DataGridViewTextBoxColumn()
        clmaphieu.Name = "Maphieumuon"
        clmaphieu.HeaderText = "Mã Phiếu mượn Sách"
        clmaphieu.DataPropertyName = "Maphieumuon"
        dgvquanluphieumuonsach.Columns.Add(clmaphieu)

        Dim clngaytrasach = New DataGridViewTextBoxColumn()
        clngaytrasach.Name = "Madocgia"
        clngaytrasach.HeaderText = "Mã Độc Giả"
        clngaytrasach.DataPropertyName = "Madocgia"
        dgvquanluphieumuonsach.Columns.Add(clngaytrasach)

        Dim clmasach = New DataGridViewTextBoxColumn()
        clmasach.Name = "Masach"
        clmasach.HeaderText = "Mã Sách"
        clmasach.DataPropertyName = "Masach"
        dgvquanluphieumuonsach.Columns.Add(clmasach)

        Dim clngaymuon = New DataGridViewTextBoxColumn()
        clngaymuon.Name = "Ngaymuonsach"
        clngaymuon.HeaderText = "Ngày Mượn Sách"
        clngaymuon.DataPropertyName = "Ngaymuonsach"
        dgvquanluphieumuonsach.Columns.Add(clngaymuon)

        Dim clngaytra = New DataGridViewTextBoxColumn()
        clngaytra.Name = "Ngaytrasach"
        clngaytra.HeaderText = "Ngày trả sách"
        clngaytra.DataPropertyName = "Ngaytrasach"
        dgvquanluphieumuonsach.Columns.Add(clngaytra)

        Dim cltienphat = New DataGridViewTextBoxColumn()
        cltienphat.Name = "Tienphat"
        cltienphat.HeaderText = "Tiền Phạt"
        cltienphat.DataPropertyName = "Tienphat"
        dgvquanluphieumuonsach.Columns.Add(cltienphat)





    End Sub
    Private Function loaddocgia(ma As String)
        docgiaBUS.selectALL_MaDocGia(ma, docgia)
    End Function
    Public Function loadsach(ma As String)
        sachBUS.selectma(ma, sach)
    End Function
    Public Function capnhatdocgia(ma As String)
        Try
            loaddocgia(ma)
            docgia.Madocgia = docgia.Madocgia
            docgia.Tendocgia = docgia.Tendocgia
            docgia.Email = docgia.Email
            docgia.Diachi = docgia.Diachi
            docgia.Ngaylapthe = docgia.Ngaylapthe
            docgia.Ngaysinh = docgia.Ngaysinh
            docgia.Ngayhethan = docgia.Ngayhethan
            docgia.Maloaidocgia = docgia.Maloaidocgia
            docgia.Sosachmuon = docgia.Sosachmuon - 1
            Dim a As Integer
            a = docgia.Sosachmuon
            docgia.Tinhtrang = docgia.Tinhtrang
            '2. Business .....
            Dim result As Result
            result = docgiaBUS.update(docgia)
            If (result.FlagResult = True) Then

                MessageBox.Show("Cập nhật độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
        docgiaBUS.update(docgia)
    End Function
    Public Function capnhatsach(ma As String)
        loadsach(ma)
        Try
            '1. Mapping data from GUI control
            sach.Masach = sach.Masach
            sach.Tensach = sach.Tensach
            sach.Tacgia = sach.Tacgia
            sach.Nhaxuatban = sach.Nhaxuatban
            sach.Trigia = sach.Trigia
            sach.Namxuatban = sach.Namxuatban
            sach.Khoangcachnam = sach.Khoangcachnam
            sach.Ngaynhap = sach.Ngaynhap
            sach.Matheloai = sach.Matheloai
            sach.Matinhtrang = 1

            '3. Insert to DB
            Dim result As Result
            result = sachBUS.update(sach)
            If (result.FlagResult = True) Then
                ' Re-Load HocSinh list

                MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
        sachBUS.update(sach)
    End Function
    Public Function capnhatdocgia1(ma As String)
        Try
            loaddocgia(ma)
            docgia.Madocgia = docgia.Madocgia
            docgia.Tendocgia = docgia.Tendocgia
            docgia.Email = docgia.Email
            docgia.Diachi = docgia.Diachi
            docgia.Ngaylapthe = docgia.Ngaylapthe
            docgia.Ngaysinh = docgia.Ngaysinh
            docgia.Ngayhethan = docgia.Ngayhethan
            docgia.Maloaidocgia = docgia.Maloaidocgia
            docgia.Sosachmuon += 1
            Dim s As Integer
            s = docgia.Sosachmuon
            docgia.Tinhtrang = docgia.Tinhtrang
            '2. Business .....
            Dim result As Result
            result = docgiaBUS.update(docgia)
            If (result.FlagResult = True) Then

                MessageBox.Show("Cập nhật độc giả thành công" + docgia.Sosachmuon, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
        docgiaBUS.update(docgia)
    End Function
    Public Function capnhatsach1(ma As String)
        loadsach(ma)
        Try
            '1. Mapping data from GUI control
            sach.Masach = sach.Masach
            sach.Tensach = sach.Tensach
            sach.Tacgia = sach.Tacgia
            sach.Nhaxuatban = sach.Nhaxuatban
            sach.Trigia = sach.Trigia
            sach.Namxuatban = sach.Namxuatban
            sach.Khoangcachnam = sach.Khoangcachnam
            sach.Ngaynhap = sach.Ngaynhap
            sach.Matheloai = sach.Matheloai
            sach.Matinhtrang = 2

            '3. Insert to DB
            Dim result As Result
            result = sachBUS.update(sach)
            If (result.FlagResult = True) Then
                ' Re-Load HocSinh list

                MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
        sachBUS.update(sach)
    End Function

    Private Sub dtpngaymuon_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaymuon.ValueChanged
        dtpngaytrasach.Value = dtpngaymuon.Value.AddDays(4)
    End Sub

    Private Sub txtmadocgia_TextChanged(sender As Object, e As EventArgs) Handles txtmadocgia.TextChanged
        loaddocgia(txtmadocgia.Text)
        txttendocgia.Text = docgia.Tendocgia
    End Sub

    Private Sub txtmasach_TextChanged(sender As Object, e As EventArgs) Handles txtmasach.TextChanged
        loadsach(txtmasach.Text)
        TextBox6.Text = sach.Tensach
        txttheloai.Text = sach.Matheloai
        txttacgia.Text = sach.Tacgia
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub


End Class