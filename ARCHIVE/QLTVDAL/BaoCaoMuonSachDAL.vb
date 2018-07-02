Imports Utility
Imports QLTVDTO
Imports System.Configuration
Imports System.Data.SqlClient
Public Class BaoCaoMuonSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function SelectAll(month As Integer, year As Integer) As List(Of BaoCaoMuonSachDTO)
        Dim listTheLoaiSach = New List(Of TheLoaiDTO)
        Dim theLoaiSach = New TheLoaiDAL
        Dim theloai1 = New TheLoaiDTO
        'Dim theLoaiDAL = New TheLoaiSachDAL
        theLoaiSach.selectALL(listTheLoaiSach)

        Dim tongSoLanMuon As Integer = 0
        Dim listThongKe = New List(Of BaoCaoMuonSachDTO)
        For Each theloai In listTheLoaiSach
            If theLoaiSach.DemSoLanMuon(theloai.Matheloai, month, year) > 0 Then
                theLoaiSach.selectma(theloai.Matheloai, theloai1)
                listThongKe.Add(New BaoCaoMuonSachDTO(theloai1.Tentheloai, theLoaiSach.DemSoLanMuon(theloai.Matheloai, month, year), 0))

            End If
        Next

        For Each dt In listThongKe
            tongSoLanMuon += dt.SoLuotMuon
        Next

        Dim tile As Integer = 0
        For Each dt In listThongKe
            dt.TiLe = dt.SoLuotMuon * 100 / tongSoLanMuon
        Next

        Return listThongKe
    End Function

End Class
