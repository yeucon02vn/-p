Imports QLTVDTO
Imports QLTVBUS
Imports Utility
Public Class FormDocGia
    Private dgBUS As DocGiaBUS
    Private ldgBUS As LoaiDocGiaBUS
    Private quydinhBUS As QuyDinhBUS
    Private quydinh As QuyDinhDTO
    Private Sub btnhap_Click(sender As Object, e As EventArgs) Handles btnhap.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()
        '1
        docgia.Madocgia = txtmadocgia.Text
        docgia.Tendocgia = txthoten.Text
        docgia.Email = txtemail.Text
        docgia.Diachi = txtdiachi.Text
        docgia.Ngaylapthe = dtpngaylapthe.Value
        docgia.Ngaysinh = dtpngaysinh.Value
        docgia.Ngayhethan = dtpngayhethan.Value
        docgia.Maloaidocgia = Convert.ToInt32(cbmaloaidocgia.SelectedValue)
        docgia.Sosachmuon = 0
        docgia.Tinhtrang = "Thẻ còn hạn"
        '2
        If (dgBUS.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên độc giả không đúng")
            txthoten.Focus()
            Return
        End If
        If (dgBUS.isValidOld(docgia) = False) Then
            MessageBox.Show("Tuổi độc giả không hợp lệ")
            txtemail.Focus()
            Return
        End If
        If (dgBUS.isValidEmail(docgia) = False) Then
            MessageBox.Show("Email độc giả không đúng")
            txtemail.Focus()
            Return
        Else
            If (dgBUS.isValiEmailFormat(txtemail.Text) = False) Then
                MessageBox.Show("Email Không Hợp Lệ")
                txtemail.Focus()
                Return
            End If

        End If
        If (dgBUS.isValidDiaChi(docgia) = False) Then
            MessageBox.Show("Địa chỉ không đúng")
            txtdiachi.Focus()
            Return
        End If

        '3
        Dim result As Result
        result = dgBUS.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMsdg = "1"
            result = dgBUS.buildMSDG(nextMsdg)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Độc Giả không thành công GUI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtmadocgia.Text = nextMsdg
            txtdiachi.Text = String.Empty
            txthoten.Text = String.Empty
            txtemail.Text = String.Empty

        Else
            MessageBox.Show("Thêm Độc giả không thành công. GUI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnhapthoat_Click(sender As Object, e As EventArgs) Handles btnhapthoat.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()
        '1
        docgia.Madocgia = txtmadocgia.Text
        docgia.Tendocgia = txthoten.Text
        docgia.Email = txtemail.Text
        docgia.Diachi = txtdiachi.Text
        docgia.Ngaylapthe = dtpngaylapthe.Value
        docgia.Ngaysinh = dtpngaysinh.Value
        docgia.Maloaidocgia = Convert.ToInt32(cbmaloaidocgia.SelectedValue)
        docgia.Ngayhethan = dtpngayhethan.Value
        docgia.Sosachmuon = 0
        docgia.Tinhtrang = "Thẻ còn hạn"
        '2
        If (dgBUS.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên độc giả không đúng")
            txthoten.Focus()
            Return

        End If
        If (dgBUS.isValidDiaChi(docgia) = False) Then
            MessageBox.Show("Địa chỉ độc giả không đúng")
            txtdiachi.Focus()
            Return

        End If
        If (dgBUS.isValidEmail(docgia) = False) Then
            MessageBox.Show("Email độc giả không đúng")
            txtemail.Focus()
            Return
        Else
            If (dgBUS.isValiEmailFormat(txtemail.Text) = False) Then
                MessageBox.Show("Email Không Hợp Lệ")
                txtemail.Focus()
                Return
            End If

        End If
        If (dgBUS.isValidOld(docgia) = False) Then
            MessageBox.Show("Tuổi độc giả không hợp lệ")
            dtpngaysinh.Focus()
            Return

        End If
        '3
        Dim result As Result
        result = dgBUS.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm độc giả thành công ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            MessageBox.Show("Thêm độc giả không thành công GUI", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub FormDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBUS = New DocGiaBUS()
        ldgBUS = New LoaiDocGiaBUS()
        quydinhBUS = New QuyDinhBUS()
        quydinh = New QuyDinhDTO()

        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBUS.selectALL(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbmaloaidocgia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbmaloaidocgia.DisplayMember = "Tenloaidocgia"
        cbmaloaidocgia.ValueMember = "Maloaidocgia"

        'set MSSH auto
        Dim nextMsdg = "1"
        result = dgBUS.buildMSDG(nextMsdg)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tự động mã Độc Giả không thành công GUI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtmadocgia.Text = nextMsdg

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtpngaylapthe_ValueChanged(sender As Object, e As EventArgs) Handles dtpngaylapthe.ValueChanged
        loadquydinh()
        dtpngayhethan.Value = dtpngaylapthe.Value.AddMonths(quydinh.Thoihanthe)
    End Sub
    Private Sub loadquydinh()
        Dim result As Result
        result = quydinhBUS.selectALL(quydinh)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub
End Class