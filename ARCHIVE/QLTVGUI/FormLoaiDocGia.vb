Imports QLTVBUS
Imports Utility
Imports QLTVDTO
Public Class FormLoaiDocGia
    Private ldgBUS As LoaiDocGiaBUS
    Private Sub btnhap_Click(sender As Object, e As EventArgs) Handles btnhap.Click
        Dim ldg As LoaiDocGiaDTO
        ldg = New LoaiDocGiaDTO()

        ldg.Maloaidocgia = Convert.ToInt32(txtmaloaidocgia.Text)
        ldg.Tenloaidocgia = txttenloaidocgia.Text
        If (ldgBUS.isValidName(ldg) = False) Then
            MessageBox.Show("ten loai doc gia khong dung ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttenloaidocgia.Focus()
            Return
        End If
        Dim result As Result
        result = ldgBUS.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("them loai doc gia thanh cong", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttenloaidocgia.Text = String.Empty

            Dim nextID As Integer
            result = ldgBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtmaloaidocgia.Text = nextID.ToString()
            Else
                MessageBox.Show("lay id ke tiep cua loai doc gia khong thanh cong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("them loai doc gia khong thanh cong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnhapdong_Click(sender As Object, e As EventArgs) Handles btnhapdong.Click
        Dim ldg As LoaiDocGiaDTO
        ldg = New LoaiDocGiaDTO()

        ldg.Maloaidocgia = Convert.ToInt32(txtmaloaidocgia.Text)
        ldg.Tenloaidocgia = txttenloaidocgia.Text
        If (ldgBUS.isValidName(ldg) = False) Then
            MessageBox.Show("ten loai doc gia khong dung ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttenloaidocgia.Focus()
            Return
        End If
        Dim result As Result
        result = ldgBUS.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại doc gia thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm loại doc gia không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub FormLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldgBUS = New LoaiDocGiaBUS()
        Dim nextID As Integer
        Dim result As Result
        result = ldgBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtmaloaidocgia.Text = nextID.ToString()
        Else
            MessageBox.Show("lay id ke tiep khong thanh cong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub
End Class