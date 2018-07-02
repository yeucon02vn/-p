Imports QLTVDTO
Imports Utility
Imports QLTVBUS

Public Class QLTinhTrangSach
    Private lttBUS As TinhTrangSachBUS
    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim currentRowIndex As Integer = dgvtinhtrangsach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvtinhtrangsach.RowCount) Then
            Try
                Dim ltt As TinhtrangsachDTO
                ltt = New TinhtrangsachDTO()

                '1. Mapping data from GUI control
                ltt.Matinhtrang = Convert.ToInt32(txtmatinhtrang.Text)
                ltt.tentinhtrang = txttentinhtrang.Text

                '2. Business .....
                If (lttBUS.isValidName(ltt) = False) Then
                    MessageBox.Show("Tên Loại Tình Trạng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txttentinhtrang.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = lttBUS.update(ltt)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    LoadListtinhTrang()
                    ' Hightlight the row has been updated on table
                    dgvtinhtrangsach.Rows(currentRowIndex).Selected = True
                    Try
                        ltt = CType(dgvtinhtrangsach.Rows(currentRowIndex).DataBoundItem, TinhtrangsachDTO)
                        txtmatinhtrang.Text = ltt.Matinhtrang
                        txttentinhtrang.Text = ltt.tentinhtrang
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật tình trạng giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgvtinhtrangsach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvtinhtrangsach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa tình trạng có mã: " + txtmatinhtrang.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = lttBUS.delete(Convert.ToInt32(txtmatinhtrang.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListtinhTrang()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvtinhtrangsach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvtinhtrangsach.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ltt = CType(dgvtinhtrangsach.Rows(currentRowIndex).DataBoundItem, TinhtrangsachDTO)
                                    txtmatinhtrang.Text = ltt.Matinhtrang
                                    txttentinhtrang.Text = ltt.tentinhtrang
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa tình trạng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub QLTinhTrangSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lttBUS = New TinhTrangSachBUS()
        LoadListtinhTrang()
    End Sub
    Private Sub LoadListtinhTrang()
        Dim listTinhTrang = New List(Of TinhtrangsachDTO)
        Dim result As Result
        result = lttBUS.selectALL(listTinhTrang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả tình trạng sách không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvtinhtrangsach.Columns.Clear()
        dgvtinhtrangsach.DataSource = Nothing

        dgvtinhtrangsach.AutoGenerateColumns = False
        dgvtinhtrangsach.AllowUserToAddRows = False
        dgvtinhtrangsach.DataSource = listTinhTrang

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "Matinhtrang"
        clMaLoai.HeaderText = "Mã Tình Trang"
        clMaLoai.DataPropertyName = "Matinhtrang"
        dgvtinhtrangsach.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "tentinhtrang"
        clTenLoai.HeaderText = "Tên Tình Trạng"
        clTenLoai.DataPropertyName = "tentinhtrang"
        dgvtinhtrangsach.Columns.Add(clTenLoai)
    End Sub

    Private Sub dgvtinhtrangsach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvtinhtrangsach.SelectionChanged
        Dim currentRowIndex As Integer = dgvtinhtrangsach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvtinhtrangsach.RowCount) Then
            Try
                Dim ltt = CType(dgvtinhtrangsach.Rows(currentRowIndex).DataBoundItem, TinhtrangsachDTO)
                txtmatinhtrang.Text = ltt.Matinhtrang
                txttentinhtrang.Text = ltt.tentinhtrang
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class