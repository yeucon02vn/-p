Imports Utility
Imports QLTVDTO
Imports QLTVDAL
Public Class PhieuMuonSachBUS
    Private phieumuonsachDAL As PhieuMuonSachDAL
    Private quydinhDAL As QuyDinhDAL
    Private quydinh As QuyDinhDTO
    Public Sub New()
        phieumuonsachDAL = New PhieuMuonSachDAL()
        quydinhDAL = New QuyDinhDAL()
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub New(ConnectionString As String)
        phieumuonsachDAL = New PhieuMuonSachDAL(ConnectionString)
        quydinhDAL = New QuyDinhDAL(ConnectionString)
        quydinh = New QuyDinhDTO()
    End Sub
    Public Sub loadquydinh()
        quydinhDAL.selectALL(quydinh)
    End Sub
    Public Function insert(phieumuon As PhieuMuonSacDTO) As Result
        Return phieumuonsachDAL.insert(phieumuon)
    End Function

    Public Function update(phieumuon As PhieuMuonSacDTO) As Result
        Return phieumuonsachDAL.update(phieumuon)
    End Function
    Public Function delete(ma As String) As Result
        Return phieumuonsachDAL.delete(ma)
    End Function
    Public Function SelectALL(ByRef listphieumuon As List(Of PhieuMuonSacDTO)) As Result
        Return phieumuonsachDAL.selectALL(listphieumuon)
    End Function
    Public Function selectma(ma As String, ByRef phieudocgia As PhieuMuonSacDTO)
        Return phieumuonsachDAL.selectma(ma, phieudocgia)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return phieumuonsachDAL.getNextID(nextID)
    End Function
    Public Function kiemtratinhtrangthe(docgia As DocGiaDTO) As Boolean
        If (String.Compare(docgia.Tinhtrang.ToString(), "Thẻ hết hạn         ") = 0) Then
            Return False
        End If
        Return True
    End Function
    Public Function kiemtrasach(sach As SachDTO) As Boolean
        If (sach.Matinhtrang = 1) Then
            Return True
        End If
        Return False
    End Function
    Public Function kiemtrasachdamuon(docgia As DocGiaDTO) As Boolean
        loadquydinh()
        If (docgia.Sosachmuon < quydinh.Sosachmuontoida) Then
            Return True
        End If
        Return False
    End Function
    Public Function kiemtrangay(phieumuon As PhieuMuonSacDTO) As Boolean
        If (DateTime.Compare(phieumuon.Ngaymuonsach, DateTime.Now) < 0) Then
            Return False
        End If
        Return True
    End Function
    Public Function ktsachqh(ma As Integer, ByRef listphieumuon As List(Of PhieuMuonSacDTO)) As Boolean
        phieumuonsachDAL.thongtin(ma, listphieumuon)
        For Each phieumuon In listphieumuon
            If (DateTime.Compare(phieumuon.Ngaytrasach, DateTime.Now) > 0) Then
                Return False
            End If

        Next
        Return True
    End Function
End Class
