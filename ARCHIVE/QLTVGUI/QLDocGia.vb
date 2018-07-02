Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Imports System.Configuration
Public Class QLDocGia
    Private dgBUS As DocGiaBUS
    Private ldgBUS As LoaiDocGiaBUS
    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim currentRowIndex As Integer = dgvdanhsachdocgia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachdocgia.RowCount) Then
            Try
                Dim docgia As DocGiaDTO
                docgia = New DocGiaDTO()

                '1. Mapping data from GUI control
                docgia.Madocgia = txtmadocgia.Text
                docgia.Tendocgia = txttendocgia.Text
                docgia.Email = txtemail.Text
                docgia.Diachi = txtdiachi.Text
                docgia.Ngaylapthe = dtpngaylapthe.Value
                docgia.Ngaysinh = dtpngaysinh.Value
                docgia.Ngayhethan = dtpngayhethan.Value
                docgia.Maloaidocgia = Convert.ToInt32(cbmaloaidocgiacapnhat.SelectedValue)
                docgia.Sosachmuon = txtsosachmuon.Text
                docgia.Tinhtrang = txttrinhtrangthe.Text
                '2. Business .....
                If (dgBUS.isValidName(docgia) = False) Then
                    MessageBox.Show("Họ tên độc giả không đúng")
                    txttendocgia.Focus()
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
                Else
                    If (dgBUS.isValiEmailFormat(txtemail.Text) = False) Then
                        MessageBox.Show("Email Không Hợp Lệ")
                        txtemail.Focus()
                    End If

                End If
                If (dgBUS.isValidDiaChi(docgia) = False) Then
                    MessageBox.Show("Địa chỉ không đúng")
                    txtdiachi.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = dgBUS.update(docgia)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListDocGia(cbmaloaidocgia.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvdanhsachdocgia.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub


    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgvdanhsachdocgia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachdocgia.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa độc giả có mã số: " + txtmadocgia.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = dgBUS.delete(txtmadocgia.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListDocGia(cbmaloaidocgia.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvdanhsachdocgia.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvdanhsachdocgia.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa độc giả  thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select


        End If
    End Sub
    Private Sub loadListDocGia()
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBUS.selectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvdanhsachdocgia.Columns.Clear()
        dgvdanhsachdocgia.DataSource = Nothing

        dgvdanhsachdocgia.AutoGenerateColumns = False
        dgvdanhsachdocgia.AllowUserToAddRows = False
        dgvdanhsachdocgia.DataSource = listDocGia

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Madocgia"
        clMa.HeaderText = "Mã Độc Giả"
        clMa.DataPropertyName = "Madocgia"
        dgvdanhsachdocgia.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "Tendocgia"
        clHoTen.HeaderText = "Họ Tên"
        clHoTen.DataPropertyName = "Tendocgia"
        dgvdanhsachdocgia.Columns.Add(clHoTen)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "Ngaysinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "Ngaysinh"
        dgvdanhsachdocgia.Columns.Add(clNgaySinh)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "Diachi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "Diachi"
        dgvdanhsachdocgia.Columns.Add(clDiaChi)

        Dim clNgayLapThe = New DataGridViewTextBoxColumn()
        clNgayLapThe.Name = "Ngaylapthe"
        clNgayLapThe.HeaderText = "Ngày Lập Thẻ"
        clNgayLapThe.DataPropertyName = "Ngaylapthe"
        dgvdanhsachdocgia.Columns.Add(clNgayLapThe)

        Dim clNgayHetHan = New DataGridViewTextBoxColumn()
        clNgayHetHan.Name = "Ngayhethan"
        clNgayHetHan.HeaderText = "Ngày Hết Hạn"
        clNgayHetHan.DataPropertyName = "Ngayhethan"
        dgvdanhsachdocgia.Columns.Add(clNgayHetHan)

        Dim clSoSachDangMuon = New DataGridViewTextBoxColumn()
        clSoSachDangMuon.Name = "Sosachmuon"
        clSoSachDangMuon.HeaderText = "Số sách đang mượn"
        clSoSachDangMuon.DataPropertyName = "Sosachmuon"
        dgvdanhsachdocgia.Columns.Add(clSoSachDangMuon)

        Dim clTinhTrang = New DataGridViewTextBoxColumn()
        clTinhTrang.Name = "Tinhtrang"
        clTinhTrang.HeaderText = "Tình Trạng"
        clTinhTrang.DataPropertyName = "Tinhtrang"
        dgvdanhsachdocgia.Columns.Add(clTinhTrang)
    End Sub

    Private Sub QLDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBUS = New DocGiaBUS()
        ldgBUS = New LoaiDocGiaBUS()

        ' Load LoaiHocSinh list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBUS.selectALL(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbmaloaidocgia.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbmaloaidocgia.DisplayMember = "Tenloaidocgia"
        cbmaloaidocgia.ValueMember = "Maloaidocgia"

        cbmaloaidocgiacapnhat.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbmaloaidocgiacapnhat.DisplayMember = "Tenloaidocgia"
        cbmaloaidocgiacapnhat.ValueMember = "Maloaidocgia"


    End Sub



    Private Sub cbmaloaidocgia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmaloaidocgia.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbmaloaidocgia.SelectedValue)
            loadListDocGia(maLoai)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub loadListDocGia(maloai As String)
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBUS.selectALL_ByType(maloai, listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvdanhsachdocgia.Columns.Clear()
        dgvdanhsachdocgia.DataSource = Nothing

        dgvdanhsachdocgia.AutoGenerateColumns = False
        dgvdanhsachdocgia.AllowUserToAddRows = False
        dgvdanhsachdocgia.DataSource = listDocGia

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Madocgia"
        clMa.HeaderText = "Mã Độc Giả"
        clMa.DataPropertyName = "Madocgia"
        dgvdanhsachdocgia.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "Tendocgia"
        clHoTen.HeaderText = "Họ Tên"
        clHoTen.DataPropertyName = "Tendocgia"
        dgvdanhsachdocgia.Columns.Add(clHoTen)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "Ngaysinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "Ngaysinh"
        dgvdanhsachdocgia.Columns.Add(clNgaySinh)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "Diachi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "Diachi"
        dgvdanhsachdocgia.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvdanhsachdocgia.Columns.Add(clEmail)

        Dim clNgayLapThe = New DataGridViewTextBoxColumn()
        clNgayLapThe.Name = "Ngaylapthe"
        clNgayLapThe.HeaderText = "Ngày Lập Thẻ"
        clNgayLapThe.DataPropertyName = "Ngaylapthe"
        dgvdanhsachdocgia.Columns.Add(clNgayLapThe)

        Dim clNgayHetHan = New DataGridViewTextBoxColumn()
        clNgayHetHan.Name = "Ngayhethan"
        clNgayHetHan.HeaderText = "Ngày Hết Hạn"
        clNgayHetHan.DataPropertyName = "Ngayhethan"
        dgvdanhsachdocgia.Columns.Add(clNgayHetHan)

        Dim clSoSachDangMuon = New DataGridViewTextBoxColumn()
        clSoSachDangMuon.Name = "Sosachmuon"
        clSoSachDangMuon.HeaderText = "Số sách đang mượn"
        clSoSachDangMuon.DataPropertyName = "Sosachmuon"
        dgvdanhsachdocgia.Columns.Add(clSoSachDangMuon)

        Dim clTinhTrang = New DataGridViewTextBoxColumn()
        clTinhTrang.Name = "Tinhtrang"
        clTinhTrang.HeaderText = "Tình Trạng"
        clTinhTrang.DataPropertyName = "Tinhtrang"
        dgvdanhsachdocgia.Columns.Add(clTinhTrang)
        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgvdanhsachdocgia.SelectionChanged
        Dim currentRowIndex As Integer = dgvdanhsachdocgia.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachdocgia.RowCount) Then
            Try
                Dim dg = CType(dgvdanhsachdocgia.Rows(currentRowIndex).DataBoundItem, DocGiaDTO)
                txtmadocgia.Text = dg.Madocgia
                txttendocgia.Text = dg.Tendocgia
                txtdiachi.Text = dg.Diachi
                dtpngaysinh.Value = dg.Ngaysinh
                dtpngayhethan.Value = dg.Ngayhethan
                dtpngaylapthe.Value = dg.Ngaylapthe
                txttrinhtrangthe.Text = dg.Tinhtrang
                txtsosachmuon.Text = dg.Sosachmuon
                txtemail.Text = dg.Email
                cbmaloaidocgiacapnhat.SelectedIndex = cbmaloaidocgia.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cbmaloaidocgiacapnhat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmaloaidocgiacapnhat.SelectedIndexChanged

    End Sub

    Private Sub txtmadocgia_TextChanged(sender As Object, e As EventArgs) Handles txtmadocgia.TextChanged

    End Sub

    Private Sub txttendocgia_TextChanged(sender As Object, e As EventArgs) Handles txttendocgia.TextChanged

    End Sub

    Private Sub txtdiachi_TextChanged(sender As Object, e As EventArgs) Handles txtdiachi.TextChanged

    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txtsosachmuon_TextChanged(sender As Object, e As EventArgs) Handles txtsosachmuon.TextChanged

    End Sub

    Private Sub txttrinhtrangthe_TextChanged(sender As Object, e As EventArgs) Handles txttrinhtrangthe.TextChanged

    End Sub
End Class