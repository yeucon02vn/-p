Imports QLTVBUS
Imports QLTVDTO
Imports Utility
Public Class ThayDoiQuyDinh
    Private quydinhBUS As QuyDinhBUS
    Private quydinh As QuyDinhDTO
    Private Sub ThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quydinhBUS = New QuyDinhBUS()
        quydinh = New QuyDinhDTO()
        loadquydinh()

    End Sub

    Private Sub btthaydoi_Click(sender As Object, e As EventArgs) Handles btthaydoi.Click
        Try


            quydinh.Tuoitoithieu = Convert.ToInt32(txttuoitoithieu.Text)
            quydinh.Tuoitoida = Convert.ToInt32(txttuoitoida.Text)
            quydinh.Thoihanthe = Convert.ToInt32(txtthoihanthe.Text)
            quydinh.Sosachmuontoida = Convert.ToInt32(txtsosachmuon.Text)
            quydinh.Songaymuontoida = Convert.ToInt32(txtsongaymuon.Text)
            quydinh.Soluongtheloai = Convert.ToInt32(txtsoluongtheloai.Text)
            quydinh.Khoangcachnam = Convert.ToInt32(txtkhoangcachnam.Text)

            Dim result As Result
            result = quydinhBUS.update(quydinh)
            If (result.FlagResult = True) Then
                MessageBox.Show("Cập nhật thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
    Private Sub loadquydinh()
        Dim result As Result
        result = quydinhBUS.selectALL(quydinh)
        txttuoitoithieu.Text = quydinh.Tuoitoithieu
        txttuoitoida.Text = quydinh.Tuoitoida
        txtthoihanthe.Text = quydinh.Thoihanthe
        txtsosachmuon.Text = quydinh.Sosachmuontoida
        txtsongaymuon.Text = quydinh.Songaymuontoida
        txtsoluongtheloai.Text = quydinh.Soluongtheloai
        txtkhoangcachnam.Text = quydinh.Khoangcachnam
    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Application.Exit()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub txttuoitoithieu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttuoitoithieu.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttuoitoida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttuoitoida.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsoluongtheloai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsoluongtheloai.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtthoihanthe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtthoihanthe.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsosachmuon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsosachmuon.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsongaymuon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsongaymuon.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtkhoangcachnam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkhoangcachnam.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class