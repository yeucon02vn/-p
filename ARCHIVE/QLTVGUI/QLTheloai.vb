Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class QLTheloai
    Private theloaiBUS As TheLoaiBUS
    Private Sub QLTheloai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theloaiBUS = New TheLoaiBUS()
        LoadlistTheLoai()
    End Sub
    Private Sub LoadlistTheLoai()
        Dim listTheLoai = New List(Of TheLoaiDTO)
        Dim result As Result
        result = theloaiBUS.selectALL(listTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvtheloai.Columns.Clear()
        dgvtheloai.DataSource = Nothing

        dgvtheloai.AutoGenerateColumns = False
        dgvtheloai.AllowUserToAddRows = False
        dgvtheloai.DataSource = listTheLoai

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "Matheloai"
        clMaLoai.HeaderText = "Mã Thể Loại"
        clMaLoai.DataPropertyName = "Matheloai"
        dgvtheloai.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "Tentheloai"
        clTenLoai.HeaderText = "Tên Thể Loại"
        clTenLoai.DataPropertyName = "Tentheloai"
        dgvtheloai.Columns.Add(clTenLoai)
    End Sub
    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim currentRowIndex As Integer = dgvtheloai.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvtheloai.RowCount) Then
            Try
                Dim theloai As TheLoaiDTO
                theloai = New TheLoaiDTO()

                '1. Mapping data from GUI control
                theloai.Matheloai = Convert.ToInt32(txtmatheloai.Text)
                theloai.Tentheloai = txttentheloai.Text

                '2. Business .....
                If (theloaiBUS.isValidName(theloai) = False) Then
                    MessageBox.Show("Tên thể loại giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txttentheloai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = theloaiBUS.update(theloai) ' tra false
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    LoadlistTheLoai()
                    ' Hightlight the row has been updated on table
                    dgvtheloai.Rows(currentRowIndex).Selected = True
                    Try
                        theloai = CType(dgvtheloai.Rows(currentRowIndex).DataBoundItem, TheLoaiDTO)
                        txtmatheloai.Text = theloai.Matheloai
                        txttentheloai.Text = theloai.Tentheloai
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgvtheloai.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvtheloai.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa thể loại có mã: " + txtmatheloai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = theloaiBUS.delete(Convert.ToInt32(txtmatheloai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadlistTheLoai()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvtheloai.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvtheloai.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim theloai = CType(dgvtheloai.Rows(currentRowIndex).DataBoundItem, TheLoaiDTO)
                                    txtmatheloai.Text = theloai.Matheloai
                                    txttentheloai.Text = theloai.Tentheloai
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvtheloai_SelectionChanged(sender As Object, e As EventArgs) Handles dgvtheloai.SelectionChanged
        Dim currentRowIndex As Integer = dgvtheloai.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvtheloai.RowCount) Then
            Try
                Dim theloai = CType(dgvtheloai.Rows(currentRowIndex).DataBoundItem, TheLoaiDTO)
                txtmatheloai.Text = theloai.Matheloai
                txttentheloai.Text = theloai.Tentheloai
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub txtmatheloai_TextChanged(sender As Object, e As EventArgs) Handles txtmatheloai.TextChanged

    End Sub

    Private Sub txttentheloai_TextChanged(sender As Object, e As EventArgs) Handles txttentheloai.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class