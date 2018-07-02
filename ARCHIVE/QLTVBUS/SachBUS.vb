Imports Utility
Imports QLTVDAL
Imports QLTVDTO
Public Class SachBUS
    Private sDAL As SachDAL
    Private quydinhDAL As QuyDinhDAL
    Private quydinh As QuyDinhDTO
    Public Sub New()
        sDAL = New SachDAL()
        quydinhDAL = New QuyDinhDAL()
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub New(ConnectionString As String)
        sDAL = New SachDAL(ConnectionString)
        quydinhDAL = New QuyDinhDAL(ConnectionString)
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub loadquydinh()
        quydinhDAL.selectALL(quydinh)
    End Sub
    Public Function isValidName(s As SachDTO) As Boolean
        If (s.Tensach.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidTacgia(s As SachDTO) As Boolean
        If (s.Tacgia.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidKhoangCachsNam(s As SachDTO) As Boolean
        loadquydinh()
        If (s.Khoangcachnam > quydinh.Khoangcachnam) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidNXB(s As SachDTO) As Boolean
        If (s.Nhaxuatban.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidTrigia(s As SachDTO) As Boolean
        If (s.Trigia.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(s As SachDTO) As Result
        Return sDAL.insert(s)
    End Function
    Public Function update(s As SachDTO) As Result
        Return sDAL.update(s)
    End Function
    Public Function delete(ma As Integer) As Result
        Return sDAL.delete(ma)
    End Function
    Public Function selectALL(ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selectALL(listsach)
    End Function
    Public Function selecttinhtrang(ma As String, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selectttinhtrang(ma, listsach)
    End Function
    Public Function selecttheloai(ma As String, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selecttheloai(ma, listsach)
    End Function
    Public Function selecttinhtrang1(ma As String, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selectttinhtrang1(ma, listsach)
    End Function
    Public Function selecttheloai1(ma As String, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selecttheloai1(ma, listsach)
    End Function
    Public Function buildMSS(ByRef nextMss As Integer) As Result
        Return sDAL.builMSS(nextMss)
    End Function
    Public Function selecttacgia(ma As String, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selecttacgia(ma, listsach)
    End Function
    Public Function selectnhaxuatban(ma As String, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selectnhaxuatban(ma, listsach)
    End Function
    Public Function selectmasach(ma As Integer, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selectmasach(ma, listsach)
    End Function
    Public Function selecttensach(ma As String, ByRef listsach As List(Of SachDTO)) As Result
        Return sDAL.selectten(ma, listsach)
    End Function
    Public Function selectma(ma As String, ByRef sach As SachDTO)
        Return sDAL.selectMa(ma, sach)
    End Function

    '  viet xong ma the loai

End Class
