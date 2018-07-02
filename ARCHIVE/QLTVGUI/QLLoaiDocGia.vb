Imports Utility
Imports QLTVBUS
Imports QLTVDTO
Imports System.Configuration
Public Class QLLoaiDocGia
    Private ldgBUS As LoaiDocGiaBUS
    Private Sub QLLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldgBUS = New LoaiDocGiaBUS()
        loadListLoaiDocGia()
    End Sub
    Private Sub LoadListLoaiDocGia()
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBUS.selectALL(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại độc giả không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvdanhsachloaidocgia.Columns.Clear()
        dgvdanhsachloaidocgia.DataSource = Nothing

        dgvdanhsachloaidocgia.AutoGenerateColumns = False
        dgvdanhsachloaidocgia.AllowUserToAddRows = False
        dgvdanhsachloaidocgia.DataSource = listLoaiDocGia

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "Maloaidocgia"
        clMaLoai.HeaderText = "Mã Loại"
        clMaLoai.DataPropertyName = "Maloaidocgia"
        dgvdanhsachloaidocgia.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "Tenloaidocgia"
        clTenLoai.HeaderText = "Tên Loại"
        clTenLoai.DataPropertyName = "Tenloaidocgia"
        dgvdanhsachloaidocgia.Columns.Add(clTenLoai)
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim currentRowIndex As Integer = dgvdanhsachloaidocgia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachloaidocgia.RowCount) Then
            Try
                Dim ldg As LoaiDocGiaDTO
                ldg = New LoaiDocGiaDTO()

                '1. Mapping data from GUI control
                ldg.Maloaidocgia = Convert.ToInt32(txtmaloaidocgia.Text)
                ldg.Tenloaidocgia = txttenloaidocgia.Text

                '2. Business .....
                If (ldgBUS.isValidName(ldg) = False) Then
                    MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txttenloaidocgia.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ldgBUS.update(ldg)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    LoadListLoaiDocGia()
                    ' Hightlight the row has been updated on table
                    dgvdanhsachloaidocgia.Rows(currentRowIndex).Selected = True
                    Try
                        ldg = CType(dgvdanhsachloaidocgia.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                        txtmaloaidocgia.Text = ldg.Maloaidocgia
                        txttenloaidocgia.Text = ldg.Tenloaidocgia
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgvdanhsachloaidocgia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachloaidocgia.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa loại độc giả có mã: " + txtmaloaidocgia.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldgBUS.delete(Convert.ToInt32(txtmaloaidocgia.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListLoaiDocGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvdanhsachloaidocgia.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvdanhsachloaidocgia.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldg = CType(dgvdanhsachloaidocgia.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                                    txtmaloaidocgia.Text = ldg.Maloaidocgia
                                    txttenloaidocgia.Text = ldg.Tenloaidocgia
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvdanhsachloaidocgia_SelectionChanged(sender As Object, e As EventArgs) Handles dgvdanhsachloaidocgia.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvdanhsachloaidocgia.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachloaidocgia.RowCount) Then
            Try
                Dim ldg = CType(dgvdanhsachloaidocgia.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                txtmaloaidocgia.Text = ldg.Maloaidocgia
                txttenloaidocgia.Text = ldg.Tenloaidocgia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class