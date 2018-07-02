Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class ThemSach
    Private sBUS As SachBUS
    Private tinhtrangBUS As TinhTrangSachBUS
    Private theloaiBUS As TheLoaiBUS
    Private Sub ThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sBUS = New SachBUS()
        tinhtrangBUS = New TinhTrangSachBUS()
        theloaiBUS = New TheLoaiBUS()

        Dim listtinhtrang = New List(Of TinhtrangsachDTO)
        Dim result As Result
        result = tinhtrangBUS.selectALL(listtinhtrang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If


        Dim listtheloai = New List(Of TheLoaiDTO)

        result = theloaiBUS.selectALL(listtheloai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbtheloai.DataSource = New BindingSource(listtheloai, String.Empty)
        cbtheloai.DisplayMember = "Tentheloai"
        cbtheloai.ValueMember = "Matheloai"
        'set MSSH auto
        Dim nextMss = "1"
        result = sBUS.buildMSS(nextMss)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tự động mã sách không thành công GUI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtmasach.Text = nextMss

    End Sub

    Private Sub btnhap_Click(sender As Object, e As EventArgs) Handles btnhap.Click
        Dim sach As SachDTO
        sach = New SachDTO()
        '1
        sach.Masach = txtmasach.Text
        sach.Tensach = txttensach.Text
        sach.Matheloai = Convert.ToInt32(cbtheloai.SelectedValue)
        sach.Matinhtrang = 1
        sach.Tacgia = txttacgia.Text
        sach.Nhaxuatban = txtnhaxuatban.Text
        sach.Namxuatban = Convert.ToInt32(txtnamxuatban.Text)
        sach.Ngaynhap = dtpnngaynhap.Value
        sach.Trigia = txttrigia.Text
        ' txtkhoangcachnam.Text = DateTime.Now.Year - sach.Namxuatban
        sach.Khoangcachnam = DateTime.Now.Year - sach.Namxuatban
        '2  
        If (sBUS.isValidName(sach) = False) Then
            MessageBox.Show("Tên sách không đúng")
            txttensach.Focus()
            Return
        End If
        If (sBUS.isValidTacgia(sach) = False) Then
            MessageBox.Show("Tác giả không hợp lệ")
            txttacgia.Focus()
            Return
        End If
        If (sBUS.isValidNXB(sach) = False) Then
            MessageBox.Show("Nhà xuất bản không hợp lệ")
            txtnhaxuatban.Focus()
            Return
        End If
        If (sBUS.isValidTrigia(sach) = False) Then
            MessageBox.Show("Trị giá không hợp lệ")
            txttrigia.Focus()
            Return
        End If
        If (sBUS.isValidKhoangCachsNam(sach) = False) Then
            MessageBox.Show("Sách quá hạn")
            txtnamxuatban.Focus()
            Return
        End If

        '3
        Dim result As Result
        result = sBUS.insert(sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMss = "1"
            result = sBUS.buildMSS(nextMss)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã sách không thành công GUI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtmasach.Text = nextMss
            txttensach.Text = String.Empty
            txttacgia.Text = String.Empty
            txtnhaxuatban.Text = String.Empty
            txttrigia.Text = String.Empty
            txtnamxuatban.Text = String.Empty

        Else
            MessageBox.Show("Thêm sách không thành công. GUI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnhapthoat_Click(sender As Object, e As EventArgs) Handles btnhapthoat.Click
        Dim sach As SachDTO
        sach = New SachDTO()
        '1
        sach.Masach = txtmasach.Text
        sach.Tensach = txttensach.Text
        sach.Matheloai = Convert.ToInt32(cbtheloai.SelectedValue)
        sach.Matinhtrang = 1
        sach.Tacgia = txttacgia.Text
        sach.Nhaxuatban = txtnhaxuatban.Text
        sach.Namxuatban = Convert.ToInt32(txtnamxuatban.Text)
        sach.Ngaynhap = dtpnngaynhap.Value
        sach.Trigia = Convert.ToInt32(txttrigia.Text)
        '2

        If (sBUS.isValidName(sach) = False) Then
            MessageBox.Show("Tên sách không đúng")
            txttensach.Focus()
            Return
        End If
        If (sBUS.isValidTacgia(sach) = False) Then
            MessageBox.Show("Tác giả không hợp lệ")
            txttacgia.Focus()
            Return
        End If
        If (sBUS.isValidNXB(sach) = False) Then
            MessageBox.Show("Nhà xuất bản không hợp lệ")
            txtnhaxuatban.Focus()
            Return
        End If
        If (sBUS.isValidTrigia(sach) = False) Then
            MessageBox.Show("Trị giá không hợp lệ")
            txttrigia.Focus()
            Return
        End If
        If (sBUS.isValidKhoangCachsNam(sach) = False) Then
            MessageBox.Show("Sách quá hạn")
            txtnamxuatban.Focus()
            Return
        End If
        '3
        Dim result As Result
        result = sBUS.insert(sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm sách thành công ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            MessageBox.Show("Thêm sách không thành công GUI", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub txtnamxuatban_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtnamxuatban_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnamxuatban.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub txttrigia_TextChanged(sender As Object, e As EventArgs) Handles txttrigia.TextChanged

    End Sub

    Private Sub txtnhaxuatban_TextChanged(sender As Object, e As EventArgs) Handles txtnhaxuatban.TextChanged

    End Sub

    Private Sub txtnamxuatban_TextChanged_1(sender As Object, e As EventArgs) Handles txtnamxuatban.TextChanged

    End Sub

    Private Sub txttacgia_TextChanged(sender As Object, e As EventArgs) Handles txttacgia.TextChanged

    End Sub

    Private Sub txttensach_TextChanged(sender As Object, e As EventArgs) Handles txttensach.TextChanged

    End Sub

    Private Sub txtmasach_TextChanged(sender As Object, e As EventArgs) Handles txtmasach.TextChanged

    End Sub
End Class