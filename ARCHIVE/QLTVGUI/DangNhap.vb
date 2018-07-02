Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class DangNhap
    Private taikhoanBUS As TaiKhoanBUS
    Private listtaikhoan As List(Of TaiKhoanDTO)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btdangnhap.Click
        load()

        For Each taikhoan In listtaikhoan
            If (txttentaikhoan.Text = taikhoan.Tentaikhoan.Trim() And txtmatkhau.Text = taikhoan.Matkhau.Trim()) Then
                MessageBox.Show("Đăng nhập thành công")
                Dim f As formmain = New formmain()
                Me.Hide()
                f.Show()
                Return

            End If
        Next
        MessageBox.Show("Tài Khoản hoặc tài khoản không đúng ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btdangky.Click
        Dim f As DangKy = New DangKy()
        f.Show()
    End Sub

    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taikhoanBUS = New TaiKhoanBUS()
        listtaikhoan = New List(Of TaiKhoanDTO)


    End Sub
    Private Sub load()
        taikhoanBUS.selectALL(listtaikhoan)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class
