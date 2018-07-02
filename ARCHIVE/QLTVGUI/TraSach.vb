Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class bttrasach
    Private phieumuonsachBUS As PhieuMuonSachBUS
    Private phieumuonsach As PhieuMuonSacDTO
    Dim docgia As DocGiaDTO
    Dim docgiaBUS As DocGiaBUS
    Dim sachBUS As SachBUS
    Dim sach As SachDTO
    Dim day As Integer
    Dim tienphat As Integer
    Dim quydinhBUS As QuyDinhBUS
    Dim quydinh As QuyDinhDTO
    Private Sub bttrasach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieumuonsachBUS = New PhieuMuonSachBUS()
        docgiaBUS = New DocGiaBUS()
        docgia = New DocGiaDTO()
        sach = New SachDTO()
        sachBUS = New SachBUS()
        phieumuonsach = New PhieuMuonSacDTO()
        quydinhBUS = New QuyDinhBUS()
        quydinh = New QuyDinhDTO()
    End Sub
    Private Function loadquydinh()
        quydinhBUS.selectALL(quydinh)
    End Function
    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttra.Click
        capnhatdocgia(txtmadocgia.Text)
        capnhatsach(txtmasach.Text)
        capnhatphieutra(txtmaphieu.Text)

    End Sub
    Private Function loadphieumuonsach(ma As String)
        phieumuonsachBUS.selectma(ma, phieumuonsach)
    End Function
    Private Function loaddocgia(ma As String)
        docgiaBUS.selectALL_MaDocGia(ma, docgia)
    End Function
    Public Function loadsach(ma As String)
        sachBUS.selectma(ma, sach)
    End Function
    Public Function capnhatphieutra(ma As String)
        phieumuonsachBUS.selectma(ma, phieumuonsach)
        Try
            phieumuonsach.Maphieumuon = phieumuonsach.Maphieumuon
            phieumuonsach.Madocgia = phieumuonsach.Madocgia
            phieumuonsach.Masach = phieumuonsach.Masach
            phieumuonsach.Ngaymuonsach = phieumuonsach.Ngaymuonsach
            phieumuonsach.Ngaytrasach = DateTime.Now
            phieumuonsach.Tienphat = tienphat

            '2. Business .....
            Dim result As Result
            result = docgiaBUS.update(docgia)
            If (result.FlagResult = True) Then

                MessageBox.Show("Cập nhật  thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
        phieumuonsachBUS.update(phieumuonsach)

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
            '2. Business .....

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

    Private Sub txtmaphieu_TextChanged(sender As Object, e As EventArgs) Handles txtmaphieu.TextChanged
        loadphieumuonsach(txtmaphieu.Text)
        txtmadocgia.Text = phieumuonsach.Madocgia
        loaddocgia(txtmadocgia.Text)
        txttendocgia.Text = docgia.Tendocgia
        txtmasach.Text = phieumuonsach.Masach
        loadsach(txtmasach.Text)
        txttensach.Text = sach.Tensach
        txttheloai.Text = sach.Matheloai
        txttacgia.Text = sach.Tacgia
        dtpngaymuon.Value = phieumuonsach.Ngaymuonsach
        dtpngaytra.Value = phieumuonsach.Ngaytrasach
        tinhtienphat(dtpngaytra.Value, tienphat)
        txttienphat.Text = tienphat
        ' tienphat(dtpngaytra.Value)
    End Sub
    Private Function tinhtienphat(nt As DateTime, ByRef n As Integer)
        loadquydinh()
        Dim elapse As TimeSpan
        elapse = DateTime.Now.Subtract(nt)
        day = elapse.TotalDays
        If (day > 4) Then
            day -= quydinh.Songaymuontoida
            n = day * 1000
        Else
            n = 0
        End If

    End Function



    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Close()
    End Sub
End Class