Imports Utility
Imports QLTVDTO
Imports QLTVDAL
Public Class TheLoaiBUS
    Private theloaiDAL As TheLoaiDAL
    Private quydinhDAL As QuyDinhDAL
    Private quydinh As QuyDinhDTO
    Public Sub New()
        theloaiDAL = New TheLoaiDAL()
        quydinhDAL = New QuyDinhDAL()
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub New(ConnectionString As String)
        theloaiDAL = New TheLoaiDAL(ConnectionString)
        quydinhDAL = New QuyDinhDAL(ConnectionString)
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub loadquydinh()
        quydinhDAL.selectALL(quydinh)
    End Sub
    Public Function isValidcount() As Boolean
        loadquydinh()
        If (theloaiDAL.count() > quydinh.Soluongtheloai) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidName(tt As TheLoaiDTO) As Boolean
        If (tt.Tentheloai.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(tt As TheLoaiDTO) As Result
        Return theloaiDAL.insert(tt)
    End Function
    Public Function update(tt As TheLoaiDTO) As Result
        Return theloaiDAL.update(tt)
    End Function
    Public Function delete(maloai As String) As Result
        Return theloaiDAL.delete(maloai)
    End Function
    Public Function selectALL(ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Return theloaiDAL.selectALL(listTheLoai)
    End Function
    Public Function selectma(ma As Integer, ByRef theloai As TheLoaiDTO) As Result
        Return theloaiDAL.selectma(ma, theloai)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return theloaiDAL.getNextID(nextID)
    End Function
End Class
