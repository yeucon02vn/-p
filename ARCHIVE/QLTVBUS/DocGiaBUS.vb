Imports QLTVDTO
Imports Utility
Imports QLTVDAL
Public Class DocGiaBUS
    Private dgDAL As DocGiaDAL
    Private quydinhDAL As QuyDinhDAL
    Private quydinh As QuyDinhDTO
    Public Sub New()
        dgDAL = New DocGiaDAL()
        quydinhDAL = New QuyDinhDAL()
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub New(ConnectionString As String)
        dgDAL = New DocGiaDAL(ConnectionString)
        quydinhDAL = New QuyDinhDAL(ConnectionString)
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub loadquydinh()
        quydinhDAL.selectALL(quydinh)
    End Sub
    Public Function isValidOld(dg As DocGiaDTO) As Boolean
        loadquydinh()
        If (DateTime.Now.Year - dg.Ngaysinh.Year < quydinh.Tuoitoithieu Or DateTime.Now.Year - dg.Ngaysinh.Year > quydinh.Tuoitoida) Then
            Return False
        End If
        Return True
    End Function

    Public Function isValidName(dg As DocGiaDTO) As Boolean
        If (dg.Tendocgia.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidEmail(dg As DocGiaDTO) As Boolean
        If (dg.Email.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValiEmailFormat(ByVal adr As String) As Boolean
        Try
            Dim Email As New System.Net.Mail.MailAddress(adr)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function isValidDiaChi(dg As DocGiaDTO) As Boolean
        If (dg.Diachi.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(dg As DocGiaDTO) As Result
        Return dgDAL.insert(dg)
    End Function
    Public Function selectAll(ByRef listDG As List(Of DocGiaDTO)) As Result
        Return dgDAL.selectALL(listDG)
    End Function
    Public Function update(dg As DocGiaDTO) As Result
        Return dgDAL.update(dg)
    End Function
    Public Function delete(ma As Integer) As Result
        Return dgDAL.delete(ma)
    End Function
    Public Function buildMSDG(ByRef nextMsdg As Integer) As Result
        Return dgDAL.builMSDG(nextMsdg)
    End Function
    Public Function selectALL_ByType(maloai As Integer, ByRef listDG As List(Of DocGiaDTO)) As Result
        Return dgDAL.selectALL_ByType(maloai, listDG)
    End Function
    Public Function selectALL_MaDocGia(madocgia As String, ByRef DG As DocGiaDTO) As Result
        Return dgDAL.selectALL_MaDocGia(madocgia, DG)
    End Function

End Class
