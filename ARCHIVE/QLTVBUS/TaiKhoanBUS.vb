Imports Utility
Imports QLTVDTO
Imports QLTVDAL
Public Class TaiKhoanBUS
    Private taikhoanDAL As TaiKhoanDAL
    Public Sub New()
        taikhoanDAL = New TaiKhoanDAL()
    End Sub
    Public Sub New(ConnectionString As String)
        taikhoanDAL = New TaiKhoanDAL(ConnectionString)
    End Sub
    Public Function isValidName(tk As TaiKhoanDTO) As Boolean
        If (tk.Tentaikhoan.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidpass(tk As TaiKhoanDTO) As Boolean
        If (tk.Matkhau.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function Dangky(tk As TaiKhoanDTO) As Result
        Return taikhoanDAL.insert(tk)
    End Function
    Public Function selectALL(ByRef listtaikhoan As List(Of TaiKhoanDTO)) As Result
        Return taikhoanDAL.selectALL(listtaikhoan)
    End Function


End Class
