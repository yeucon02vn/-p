Imports Utility
Imports QLTVDTO
Imports QLTVBUS
Public Class FormThemTheLoai
    Private theloaiBUS As TheLoaiBUS
    Private Sub FormThemTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theloaiBUS = New TheLoaiBUS()
        Dim nextID As Integer
        Dim result As Result
        result = theloaiBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtmatheloai.Text = nextID.ToString()
        Else
            MessageBox.Show("Láy ID kế tiếp không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnhap_Click(sender As Object, e As EventArgs) Handles btnhap.Click
        Dim theloai As TheLoaiDTO
        theloai = New TheLoaiDTO()

        theloai.Matheloai = Convert.ToInt32(txtmatheloai.Text)
        theloai.Tentheloai = txttentheloai.Text
        If (theloaiBUS.isValidcount() = False) Then
            MessageBox.Show("Vượt quá số lượng thể loại quy định", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (theloaiBUS.isValidName(theloai) = False) Then
            MessageBox.Show("Tên thể loại Không Đúng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttentheloai.Focus()
            Return
        End If
        Dim result As Result
        result = theloaiBUS.insert(theloai)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thể loại sách thành công", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttentheloai.Text = String.Empty

            Dim nextID As Integer
            result = theloaiBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtmatheloai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế Tiếp Không Thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm thể loại sách không thành công ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnhapthoat_Click(sender As Object, e As EventArgs) Handles btnhapthoat.Click
        Dim theloai As TheLoaiDTO
        theloai = New TheLoaiDTO()

        theloai.Matheloai = Convert.ToInt32(txtmatheloai.Text)
        theloai.Tentheloai = txttentheloai.Text
        If (theloaiBUS.isValidName(theloai) = False) Then
            MessageBox.Show("Tên thể loại không đúng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttentheloai.Focus()
            Return
        End If
        Dim result As Result
        result = theloaiBUS.insert(theloai)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thể loại  thành công", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm thể loại không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub txtmatheloai_TextChanged(sender As Object, e As EventArgs) Handles txtmatheloai.TextChanged

    End Sub

    Private Sub txttentheloai_TextChanged(sender As Object, e As EventArgs) Handles txttentheloai.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class