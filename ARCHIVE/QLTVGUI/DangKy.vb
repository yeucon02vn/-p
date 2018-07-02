Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class DangKy
    Private taikhoanBUS As TaiKhoanBUS
    Private Sub DangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taikhoanBUS = New TaiKhoanBUS()
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Close()
    End Sub

    Private Sub btdangky_Click(sender As Object, e As EventArgs) Handles btdangky.Click
        Dim taikhoan = New TaiKhoanDTO()
        Dim listtaikhoan = New List(Of TaiKhoanDTO)
        taikhoanBUS.selectALL(listtaikhoan)
        taikhoan.Tentaikhoan = txttentaikhoan.Text
        taikhoan.Matkhau = txtmatkhau.Text

        If (taikhoanBUS.isValidName(taikhoan) = False) Then
            MessageBox.Show("Nhập đầy đủ thông tin tài khoản", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttentaikhoan.Focus()
            Return
        End If
        If (taikhoanBUS.isValidpass(taikhoan) = False) Then
            MessageBox.Show("Nhập đầy đủ thông tin tài khoản", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmatkhau.Focus()
            Return
        End If
        For Each taikhoan1 In listtaikhoan
            If (txttentaikhoan.Text = taikhoan1.Tentaikhoan) Then
                MessageBox.Show("Tài Khoản đã tồn tại")
            End If
        Next
        Dim result As Result
        result = taikhoanBUS.Dangky(taikhoan)
        If (result.FlagResult = True) Then
            MessageBox.Show("Đăng ký thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            txttentaikhoan.Text = String.Empty
            txtmatkhau.Text = String.Empty

        Else
            MessageBox.Show("Đăng ký tài khoản không thành công. GUI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub
End Class