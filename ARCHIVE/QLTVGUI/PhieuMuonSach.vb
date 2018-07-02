Imports Utility
Imports QLTVBUS
Imports QLTVDTO
Public Class pms
    Private phieumuonsachBUS As PhieuMuonSachBUS
    Dim docgia As DocGiaDTO
    Dim docgiaBUS As DocGiaBUS
    Dim sachBUS As SachBUS
    Dim sach As SachDTO
    Private quydinhBUS As QuyDinhBUS
    Private quydinh As QuyDinhDTO

    Private Sub btlap_Click(sender As Object, e As EventArgs) Handles btlapphieu.Click
        Dim phieumuonsach As PhieuMuonSacDTO
        phieumuonsach = New PhieuMuonSacDTO()

        '
        phieumuonsach.Madocgia = cbmadocgia.Text
        phieumuonsach.Masach = cbmasach.Text
        phieumuonsach.Ngaymuonsach = dtpngaymuon.Value
        phieumuonsach.Ngaytrasach = dtpngaytra.Value
        phieumuonsach.Tienphat = 0

        loaddocgia(cbmadocgia.Text)
        loadsach(cbmasach.Text)
        '
        '  Dim list As List(Of PhieuMuonSacDTO)
        '  If (phieumuonsachBUS.ktsachqh(cbmadocgia.Text, list) = False) Then
        'MessageBox.Show("Độc Giả Hiện Đang Có Sách Quá Hạn Chưa Trả")
        'Return
        ' End If

        If (phieumuonsachBUS.kiemtratinhtrangthe(docgia) = False) Then
            MessageBox.Show("Thẻ Độc Giả Hết Hạn")
            Return
        End If
        If (phieumuonsachBUS.kiemtrasach(sach) = False) Then
            MessageBox.Show("Sách Đã được mượn")
            Return
        End If
        If (phieumuonsachBUS.kiemtrasachdamuon(docgia) = False) Then
            MessageBox.Show("Quá số sách được mượn")
            Return
        End If

        capnhatdocgia(cbmadocgia.Text)
        capnhatsach(cbmasach.Text)
        '
        Dim result As Result
        result = phieumuonsachBUS.insert(phieumuonsach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Lập phiếu mượn sách thành công", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim nextMspm = "1"
            result = phieumuonsachBUS.getNextID(nextMspm)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã không thành công GUI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtmaphieumuonsach.Text = nextMspm
            cbmadocgia.Text = String.Empty
            txttendocgia.Text = String.Empty
            txttacgia.Text = String.Empty
            txttheloai.Text = String.Empty
            cbmasach.Text = String.Empty
        Else
            MessageBox.Show("Lập phiếu mượn sách không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
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
            docgia.Sosachmuon = docgia.Sosachmuon + 1
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
            sach.Matinhtrang = 2
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

    Private Sub PhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieumuonsachBUS = New PhieuMuonSachBUS()
        docgiaBUS = New DocGiaBUS()
        docgia = New DocGiaDTO()
        sach = New SachDTO()
        sachBUS = New SachBUS()
        quydinhBUS = New QuyDinhBUS()
        quydinh = New QuyDinhDTO()
        Dim result As Result
        Dim nextMms = "1"
        result = phieumuonsachBUS.getNextID(nextMms)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã tự động không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtmaphieumuonsach.Text = nextMms


    End Sub

    Private Sub btlapvathoat_Click(sender As Object, e As EventArgs) Handles btlapvathoat.Click
        Me.Close()
    End Sub




    Private Sub cbmadocgia_TextChanged(sender As Object, e As EventArgs) Handles cbmadocgia.TextChanged
        loaddocgia(cbmadocgia.Text)
        txttendocgia.Text = docgia.Tendocgia
    End Sub

    Private Sub cbmadocgia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbmadocgia.SelectedValueChanged
        loaddocgia(cbmadocgia.Text)
        txttendocgia.Text = docgia.Tendocgia
    End Sub

    Private Sub cbmasach_TextChanged(sender As Object, e As EventArgs) Handles cbmasach.TextChanged
        loadsach(cbmasach.Text)
        txttensach.Text = sach.Tensach
        txttheloai.Text = sach.Matheloai
        txttacgia.Text = sach.Tacgia
    End Sub

    Private Sub dtpngaymuon_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaymuon.ValueChanged
        loadquydinh()
        dtpngaytra.Value = dtpngaymuon.Value.AddDays(quydinh.Songaymuontoida)
    End Sub
    Private Sub loadquydinh()
        Dim result As Result
        result = quydinhBUS.selectALL(quydinh)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txttacgia_TextChanged(sender As Object, e As EventArgs) Handles txttacgia.TextChanged

    End Sub

    Private Sub txttheloai_TextChanged(sender As Object, e As EventArgs) Handles txttheloai.TextChanged

    End Sub

    Private Sub txttensach_TextChanged(sender As Object, e As EventArgs) Handles txttensach.TextChanged

    End Sub

    Private Sub cbmasach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmasach.SelectedIndexChanged

    End Sub

    Private Sub txttendocgia_TextChanged(sender As Object, e As EventArgs) Handles txttendocgia.TextChanged

    End Sub

    Private Sub cbmadocgia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmadocgia.SelectedIndexChanged

    End Sub

    Private Sub txtmaphieumuonsach_TextChanged(sender As Object, e As EventArgs) Handles txtmaphieumuonsach.TextChanged

    End Sub
End Class