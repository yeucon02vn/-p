Imports QLTVDTO
Imports QLTVBUS
Imports Utility
Public Class FormThemTinhTrang
    Private lttBUS As TinhTrangSachBUS
    Private Sub FormThemTinhTrang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lttBUS = New TinhTrangSachBUS()
        Dim nextID As Integer
        Dim result As Result
        result = lttBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtmatinhtrang.Text = nextID.ToString()
        Else
            MessageBox.Show("Láy ID kế tiếp không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnhap_Click(sender As Object, e As EventArgs) Handles btnhap.Click
        Dim ltt As TinhtrangsachDTO
        ltt = New TinhtrangsachDTO()

        ltt.Matinhtrang = Convert.ToInt32(txtmatinhtrang.Text)
        ltt.tentinhtrang = txttentinhtrang.Text

        If (lttBUS.isValidName(ltt) = False) Then
            MessageBox.Show("Tên Loại Tình trạng Không Đúng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttentinhtrang.Focus()
            Return
        End If
        Dim result As Result
        result = lttBUS.insert(ltt)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tình trạng sách thành công", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttentinhtrang.Text = String.Empty

            Dim nextID As Integer
            result = lttBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtmatinhtrang.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế Tiếp Không Thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm tình trạng sách không thành công ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnhapthoat_Click(sender As Object, e As EventArgs) Handles btnhapthoat.Click
        Dim ltt As TinhtrangsachDTO
        ltt = New TinhtrangsachDTO()

        ltt.Matinhtrang = Convert.ToInt32(txtmatinhtrang.Text)
        ltt.tentinhtrang = txttentinhtrang.Text
        If (lttBUS.isValidName(ltt) = False) Then
            MessageBox.Show("Tên tình trạng không đúng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttentinhtrang.Focus()
            Return
        End If
        Dim result As Result
        result = lttBUS.insert(ltt)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tình trạng thành công", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm tình tràng không thành công", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class