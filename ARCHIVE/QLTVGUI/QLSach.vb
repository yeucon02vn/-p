Imports Utility
Imports QLTVBUS
Imports QLTVDTO
Public Class QLSach
    Private sachBUS As SachBUS
    Private tinhtrangBUS As TinhTrangSachBUS
    Private theloaiBUS As TheLoaiBUS
    Private Sub dgvsach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvsach.SelectionChanged
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvsach.RowCount) Then
            Try
                Dim sach = CType(dgvsach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                txtmasach.Text = sach.Masach
                txttensach.Text = sach.Tensach
                txtnhaxuatban.Text = sach.Nhaxuatban
                txttacgia.Text = sach.Tacgia
                txttrigia.Text = sach.Trigia
                txtnamxuatban.Text = sach.Namxuatban
                txtkhoangcachnam.Text = sach.Khoangcachnam
                dtpngaynhap.Value = sach.Ngaynhap
                cbtheloaicapnhat.SelectedIndex = cbtheloai.SelectedIndex
                cbtrinhtrangcapnhat.SelectedIndex = cbtrinhtrang.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If



    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvsach.RowCount) Then
            Try
                Dim sach As SachDTO
                sach = New SachDTO()

                '1. Mapping data from GUI control
                sach.Masach = txtmasach.Text
                sach.Tensach = txttensach.Text
                sach.Tacgia = txttacgia.Text
                sach.Nhaxuatban = txtnhaxuatban.Text
                sach.Trigia = txttrigia.Text
                sach.Namxuatban = txtnamxuatban.Text
                sach.Khoangcachnam = DateTime.Now.Year - sach.Namxuatban
                sach.Ngaynhap = dtpngaynhap.Value
                sach.Matheloai = Convert.ToInt32(cbtheloaicapnhat.SelectedValue)
                sach.Matinhtrang = Convert.ToInt32(cbtrinhtrangcapnhat.SelectedValue)
                '2. Business .....
                If (sachBUS.isValidName(sach) = False) Then
                    MessageBox.Show("Tên sách không đúng")
                    txttensach.Focus()
                    Return
                End If
                If (sachBUS.isValidTacgia(sach) = False) Then
                    MessageBox.Show("Tác giả không hợp lệ")
                    txttacgia.Focus()
                    Return
                End If
                If (sachBUS.isValidNXB(sach) = False) Then
                    MessageBox.Show("Nhà xuất bản không hợp lệ")
                    txtnhaxuatban.Focus()
                    Return
                End If
                If (sachBUS.isValidTrigia(sach) = False) Then
                    MessageBox.Show("Trị giá không hợp lệ")
                    txttrigia.Focus()
                    Return
                End If
                If (sachBUS.isValidKhoangCachsNam(sach) = False) Then
                    MessageBox.Show("Sách quá hạn")
                    txtnamxuatban.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = sachBUS.update(sach)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListSach(cbtrinhtrang.SelectedValue)
                    loadListSach(cbtheloai.SelectedValue, 1)
                    ' Hightlight the row has been updated on table
                    dgvsach.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvsach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa sách có mã số: " + txtmasach.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = sachBUS.delete(txtmasach.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListSach(cbtrinhtrang.SelectedValue)
                            loadListSach(cbtheloai.SelectedValue)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvsach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvsach.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa sách  thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub QLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBUS = New SachBUS()
        tinhtrangBUS = New TinhTrangSachBUS()
        theloaiBUS = New TheLoaiBUS()
        '
        Dim listtinhtrang = New List(Of TinhtrangsachDTO)
        Dim listtheloai = New List(Of TheLoaiDTO)
        Dim result = New Result
        result = tinhtrangBUS.selectALL(listtinhtrang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tình trạng sách không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbtrinhtrang.DataSource = New BindingSource(listtinhtrang, String.Empty)
        cbtrinhtrang.DisplayMember = "tentinhtrang"
        cbtrinhtrang.ValueMember = "Matinhtrang"

        cbtrinhtrangcapnhat.DataSource = New BindingSource(listtinhtrang, String.Empty)
        cbtrinhtrangcapnhat.DisplayMember = "tentinhtrang"
        cbtrinhtrangcapnhat.ValueMember = "Matinhtrang"

        result = theloaiBUS.selectALL(listtheloai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbtheloai.DataSource = New BindingSource(listtheloai, String.Empty)
        cbtheloai.DisplayMember = "Tentheloai"
        cbtheloai.ValueMember = "Matheloai"

        cbtheloaicapnhat.DataSource = New BindingSource(listtheloai, String.Empty)
        cbtheloaicapnhat.DisplayMember = "Tentheloai"
        cbtheloaicapnhat.ValueMember = "Matheloai"

    End Sub


    Private Sub loadListSach(ma As String, n As Integer)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selecttheloai1(ma, listsach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvsach.Columns.Clear()
        dgvsach.DataSource = Nothing

        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listsach




        Dim cltinhtrang = New DataGridView()
        Dim cltheloai = New DataGridView()

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Masach"
        clMa.HeaderText = "Mã sách"
        clMa.DataPropertyName = "Masach"
        dgvsach.Columns.Add(clMa)



        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "Tensach"
        clHoTen.HeaderText = "Tên Sách"
        clHoTen.DataPropertyName = "Tensach"
        dgvsach.Columns.Add(clHoTen)

        Dim clTacgia = New DataGridViewTextBoxColumn()
        clTacgia.Name = "Tacgia"
        clTacgia.HeaderText = "Tác Giả"
        clTacgia.DataPropertyName = "Tacgia"
        dgvsach.Columns.Add(clTacgia)

        Dim clNhaxuatban = New DataGridViewTextBoxColumn()
        clNhaxuatban.Name = "Nhaxuatban"
        clNhaxuatban.HeaderText = "Nhà xuất bản"
        clNhaxuatban.DataPropertyName = "Nhaxuatban"
        dgvsach.Columns.Add(clNhaxuatban)

        Dim clNamxuatban = New DataGridViewTextBoxColumn()
        clNamxuatban.Name = "Namxuatban"
        clNamxuatban.HeaderText = "Năm xuất bản"
        clNamxuatban.DataPropertyName = "Namxuatban"
        dgvsach.Columns.Add(clNamxuatban)

        Dim clNgaynhap = New DataGridViewTextBoxColumn()
        clNgaynhap.Name = "Ngaynhap"
        clNgaynhap.HeaderText = "Ngày Nhập"
        clNgaynhap.DataPropertyName = "Ngaynhap"
        dgvsach.Columns.Add(clNgaynhap)

        Dim clTrigia = New DataGridViewTextBoxColumn()
        clTrigia.Name = "Trigia"
        clTrigia.HeaderText = "Trị giá"
        clTrigia.DataPropertyName = "Trigia"
        dgvsach.Columns.Add(clTrigia)

        Dim clKhoangcachnam = New DataGridViewTextBoxColumn()
        clKhoangcachnam.Name = "Khoangcachnam"
        clKhoangcachnam.HeaderText = "Khoảng cách năm"
        clKhoangcachnam.DataPropertyName = "Khoangcachnam"
        dgvsach.Columns.Add(clKhoangcachnam)

    End Sub


    Private Sub loadListSach(ma As String)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selecttinhtrang1(ma, listsach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvsach.Columns.Clear()
        dgvsach.DataSource = Nothing

        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listsach




        Dim cltinhtrang = New DataGridView()
        Dim cltheloai = New DataGridView()

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Masach"
        clMa.HeaderText = "Mã sách"
        clMa.DataPropertyName = "Masach"
        dgvsach.Columns.Add(clMa)

        Dim cbtinhtrang = New DataGridView()
        Dim cbtheloai = New DataGridView()


        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "Tensach"
        clHoTen.HeaderText = "Tên Sách"
        clHoTen.DataPropertyName = "Tensach"
        dgvsach.Columns.Add(clHoTen)

        Dim clTacgia = New DataGridViewTextBoxColumn()
        clTacgia.Name = "Tacgia"
        clTacgia.HeaderText = "Tác Giả"
        clTacgia.DataPropertyName = "Tacgia"
        dgvsach.Columns.Add(clTacgia)

        Dim clNhaxuatban = New DataGridViewTextBoxColumn()
        clNhaxuatban.Name = "Nhaxuatban"
        clNhaxuatban.HeaderText = "Nhà xuất bản"
        clNhaxuatban.DataPropertyName = "Nhaxuatban"
        dgvsach.Columns.Add(clNhaxuatban)

        Dim clNamxuatban = New DataGridViewTextBoxColumn()
        clNamxuatban.Name = "Namxuatban"
        clNamxuatban.HeaderText = "Năm xuất bản"
        clNamxuatban.DataPropertyName = "Namxuatban"
        dgvsach.Columns.Add(clNamxuatban)

        Dim clNgaynhap = New DataGridViewTextBoxColumn()
        clNgaynhap.Name = "Ngaynhap"
        clNgaynhap.HeaderText = "Ngày Nhập"
        clNgaynhap.DataPropertyName = "Ngaynhap"
        dgvsach.Columns.Add(clNgaynhap)

        Dim clTrigia = New DataGridViewTextBoxColumn()
        clTrigia.Name = "Trigia"
        clTrigia.HeaderText = "Trị giá"
        clTrigia.DataPropertyName = "Trigia"
        dgvsach.Columns.Add(clTrigia)

        Dim clKhoangcachnam = New DataGridViewTextBoxColumn()
        clKhoangcachnam.Name = "Khoangcachnam"
        clKhoangcachnam.HeaderText = "Khoảng cách năm"
        clKhoangcachnam.DataPropertyName = "Khoangcachnam"
        dgvsach.Columns.Add(clKhoangcachnam)



    End Sub

    Private Sub loadListSach()
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selectALL(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvsach.Columns.Clear()
        dgvsach.DataSource = Nothing

        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listSach

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "Masach"
        clMa.HeaderText = "Mã sách"
        clMa.DataPropertyName = "Masach"
        dgvsach.Columns.Add(clMa)

        Dim cltinhtrang = New DataGridView()
        Dim cltheloai = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "Tensach"
        clHoTen.HeaderText = "Tên Sách"
        clHoTen.DataPropertyName = "Tensach"
        dgvsach.Columns.Add(clHoTen)

        Dim clTacgia = New DataGridViewTextBoxColumn()
        clTacgia.Name = "Tacgia"
        clTacgia.HeaderText = "Tác Giả"
        clTacgia.DataPropertyName = "Tacgia"
        dgvsach.Columns.Add(clTacgia)

        Dim clNhaxuatban = New DataGridViewTextBoxColumn()
        clNhaxuatban.Name = "Nhaxuatban"
        clNhaxuatban.HeaderText = "Nhà xuất bản"
        clNhaxuatban.DataPropertyName = "Nhaxuatban"
        dgvsach.Columns.Add(clNhaxuatban)

        Dim clNamxuatban = New DataGridViewTextBoxColumn()
        clNamxuatban.Name = "Namxuatban"
        clNamxuatban.HeaderText = "Năm xuất bản"
        clNamxuatban.DataPropertyName = "Namxuatban"
        dgvsach.Columns.Add(clNamxuatban)

        Dim clNgaynhap = New DataGridViewTextBoxColumn()
        clNgaynhap.Name = "Ngaynhap"
        clNgaynhap.HeaderText = "Ngày Nhập"
        clNgaynhap.DataPropertyName = "Ngaynhap"
        dgvsach.Columns.Add(clNgaynhap)

        Dim clTrigia = New DataGridViewTextBoxColumn()
        clTrigia.Name = "Trigia"
        clTrigia.HeaderText = "Trị giá"
        clTrigia.DataPropertyName = "Trigia"
        dgvsach.Columns.Add(clTrigia)

        Dim clKhoangcachnam = New DataGridViewTextBoxColumn()
        clKhoangcachnam.Name = "Khoangcachnam"
        clKhoangcachnam.HeaderText = "Khoảng cách năm"
        clKhoangcachnam.DataPropertyName = "Khoangcachnam"
        dgvsach.Columns.Add(clKhoangcachnam)

    End Sub

    Private Sub cbtheloai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtheloai.SelectedIndexChanged
        Try
            Dim matheloai = Convert.ToInt32(cbtheloai.SelectedValue)
            loadListSach(matheloai, 1)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbtrinhtrang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtrinhtrang.SelectedIndexChanged
        Try
            Dim matinhtrang = Convert.ToInt32(cbtrinhtrang.SelectedValue)
            loadListSach(matinhtrang)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnamxuatban_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnamxuatban.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.Close()
    End Sub
End Class