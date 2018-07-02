Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class TraCuuSach
    Private sachBUS As SachBUS
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgvsach.SelectionChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cbtimkientheo.Text = "Tên sách") Then
            LoadListSachTenSach(txttensach.Text)
        End If
        If (String.Compare(cbtimkientheo.Text, "Mã sách") = 0) Then
            LoadListSachMa(txttensach.Text)
        End If
        If (String.Compare(cbtimkientheo.Text, "Tác giả") = 0) Then
            LoadListSachTacGia(txttensach.Text)
        End If
        If (cbtimkientheo.Text = "Thể loại") Then
            LoadListSachTheLoai(txttensach.Text)
        End If
        If (String.Compare(cbtimkientheo.Text, "Tình trạng") = 0) Then
            LoadListSachTinhtrang(txttensach.Text)
        End If
        If (String.Compare(cbtimkientheo.Text, "Nhà xuất bản") = 0) Then
            LoadListSachNhaXuatBan(txttensach.Text)
        End If

    End Sub

    Private Sub cbtimkientheo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtimkientheo.SelectedIndexChanged

    End Sub
    Private Sub LoadListSachMa(ma As String)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selectmasach(ma, listsach)
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




        Dim cltinhtrang = New DataGridViewTextBoxColumn()
        cltinhtrang.Name = "Matinhtrang"
        cltinhtrang.HeaderText = "Tình Trạng"
        cltinhtrang.DataPropertyName = "Matinhtrang"
        dgvsach.Columns.Add(cltinhtrang)

        Dim cltheloai = New DataGridViewTextBoxColumn()
        cltheloai.Name = "Matheloai"
        cltheloai.HeaderText = "Thể Loại"
        cltheloai.DataPropertyName = "Matheloai"
        dgvsach.Columns.Add(cltheloai)


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
    Private Sub LoadListSachTacGia(ma As String)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selecttacgia(ma, listsach)
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




        Dim cltinhtrang = New DataGridViewTextBoxColumn()
        cltinhtrang.Name = "Matinhtrang"
        cltinhtrang.HeaderText = "Tình Trạng"
        cltinhtrang.DataPropertyName = "Matinhtrang"
        dgvsach.Columns.Add(cltinhtrang)

        Dim cltheloai = New DataGridViewTextBoxColumn()
        cltheloai.Name = "Matheloai"
        cltheloai.HeaderText = "Thể Loại"
        cltheloai.DataPropertyName = "Matheloai"
        dgvsach.Columns.Add(cltheloai)


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
    Private Sub LoadListSachTenSach(ma As String)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selecttensach(ma, listsach)
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




        Dim cltinhtrang = New DataGridViewTextBoxColumn()
        cltinhtrang.Name = "Matinhtrang"
        cltinhtrang.HeaderText = "Tình Trạng"
        cltinhtrang.DataPropertyName = "Matinhtrang"
        dgvsach.Columns.Add(cltinhtrang)

        Dim cltheloai = New DataGridViewTextBoxColumn()
        cltheloai.Name = "Matheloai"
        cltheloai.HeaderText = "Thể Loại"
        cltheloai.DataPropertyName = "Matheloai"
        dgvsach.Columns.Add(cltheloai)



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
    Private Sub LoadListSachTinhtrang(ma As String)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selecttinhtrang(ma, listsach)
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




        Dim cltinhtrang = New DataGridViewTextBoxColumn()
        cltinhtrang.Name = "Matinhtrang"
        cltinhtrang.HeaderText = "Tình Trạng"
        cltinhtrang.DataPropertyName = "Matinhtrang"
        dgvsach.Columns.Add(cltinhtrang)

        Dim cltheloai = New DataGridViewTextBoxColumn()
        cltheloai.Name = "Matheloai"
        cltheloai.HeaderText = "Thể Loại"
        cltheloai.DataPropertyName = "Matheloai"
        dgvsach.Columns.Add(cltheloai)



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
    Private Sub LoadListSachTheLoai(ma As String)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selecttheloai(ma, listsach)
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




        Dim cltinhtrang = New DataGridViewTextBoxColumn()
        cltinhtrang.Name = "Matinhtrang"
        cltinhtrang.HeaderText = "Tình Trạng"
        cltinhtrang.DataPropertyName = "Matinhtrang"
        dgvsach.Columns.Add(cltinhtrang)

        Dim cltheloai = New DataGridViewTextBoxColumn()
        cltheloai.Name = "Matheloai"
        cltheloai.HeaderText = "Thể Loại"
        cltheloai.DataPropertyName = "Matheloai"
        dgvsach.Columns.Add(cltheloai)
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
    Private Sub LoadListSachNhaXuatBan(ma As String)
        Dim listsach = New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selectnhaxuatban(ma, listsach)
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




        Dim cltinhtrang = New DataGridViewTextBoxColumn()
        cltinhtrang.Name = "Matinhtrang"
        cltinhtrang.HeaderText = "Tình Trạng"
        cltinhtrang.DataPropertyName = "Matinhtrang"
        dgvsach.Columns.Add(cltinhtrang)

        Dim cltheloai = New DataGridViewTextBoxColumn()
        cltheloai.Name = "Matheloai"
        cltheloai.HeaderText = "Thể Loại"
        cltheloai.DataPropertyName = "Matheloai"
        dgvsach.Columns.Add(cltheloai)

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


    Private Sub TraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBUS = New SachBUS()

        cbtimkientheo.Items.Add("Tên sách")
        cbtimkientheo.Items.Add("Mã sách")
        cbtimkientheo.Items.Add("Tác giả")
        cbtimkientheo.Items.Add("Nhà xuất bản")
        cbtimkientheo.Items.Add("Thể loại")
        cbtimkientheo.Items.Add("Tình trạng")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class