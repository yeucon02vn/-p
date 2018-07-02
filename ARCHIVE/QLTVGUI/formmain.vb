Public Class formmain
    Private Sub LoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiĐộcGiảToolStripMenuItem.Click, MyBase.ContextMenuStripChanged

    End Sub

    Private Sub ThêmLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐộcGiảToolStripMenuItem.Click
        Dim f As FormLoaiDocGia = New FormLoaiDocGia

        f.Show()
    End Sub

    Private Sub ThêmĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmĐộcGiảToolStripMenuItem.Click
        Dim f As FormDocGia = New FormDocGia

        f.Show()
    End Sub

    Private Sub QuảnLýĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýĐộcGiảToolStripMenuItem.Click
        Dim f As QLLoaiDocGia = New QLLoaiDocGia

        f.Show()
    End Sub

    Private Sub QuảnLýLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýLoạiĐộcGiảToolStripMenuItem.Click
        Dim f As QLDocGia = New QLDocGia

        f.Show()
    End Sub

    Private Sub ThêmTìnhTrạngSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmTìnhTrạngSáchToolStripMenuItem.Click
        Dim f As FormThemTinhTrang = New FormThemTinhTrang
        f.Show()
    End Sub

    Private Sub QuảnLýTrìnhTrạngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýTrìnhTrạngToolStripMenuItem.Click
        Dim f As QLTinhTrangSach = New QLTinhTrangSach
        f.Show()
    End Sub

    Private Sub ThêmThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmThểLoạiToolStripMenuItem.Click
        Dim f As FormThemTheLoai = New FormThemTheLoai
        f.Show()
    End Sub

    Private Sub QuảnLýThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýThểLoạiToolStripMenuItem.Click
        Dim f As QLTheloai = New QLTheloai
        f.Show()
    End Sub

    Private Sub ThêmSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSáchToolStripMenuItem.Click
        Dim f As ThemSach = New ThemSach
        f.Show()
    End Sub

    Private Sub QảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QảnLýSáchToolStripMenuItem.Click
        Dim f As QLSach = New QLSach
        f.Show()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        Dim f As TraCuuSach = New TraCuuSach
        f.Show()
    End Sub



    Private Sub PhiếuMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuMượnSáchToolStripMenuItem.Click
        Dim f As pms = New pms()
        f.Show()
    End Sub

    Private Sub QuảnLýPhiếuMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuMượnSáchToolStripMenuItem.Click
        Dim f As QuanLyPhieuMuonSach = New QuanLyPhieuMuonSach()
        f.Show()
    End Sub

    Private Sub PhiếuTrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuTrảSáchToolStripMenuItem.Click
        Dim f As bttrasach = New bttrasach()
        f.Show()
    End Sub

    Private Sub QuảnLýPhiếuTrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuTrảSáchToolStripMenuItem.Click
        Dim f As QuanLyPhieuTraSach = New QuanLyPhieuTraSach()
        f.Show()
    End Sub

    Private Sub BáoCáoMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoMượnSáchToolStripMenuItem.Click
        Dim f As BaoCaoMuonSach = New BaoCaoMuonSach()
        f.Show()
    End Sub

    Private Sub BáoCáoSáchMượnTrểToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoSáchMượnTrểToolStripMenuItem.Click
        Dim f As BaoCaoMuonTre = New BaoCaoMuonTre()
        f.Show()
    End Sub

    Private Sub LậpThẻMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpThẻMượnSáchToolStripMenuItem.Click
        Dim f As ThayDoiQuyDinh = New ThayDoiQuyDinh()
        f.Show()
    End Sub
End Class
