Imports QLTVDAL
Imports QLTVDTO
Imports Utility
Public Class BaoCaoMuonSachBUS
    Private baoCaoTinhHinhMuonSachTheoTheLoaiDAL As BaoCaoMuonSachDAL

    Public Sub New(connectionString As String)
        baoCaoTinhHinhMuonSachTheoTheLoaiDAL = New BaoCaoMuonSachDAL(connectionString)
    End Sub

    Public Sub New()
        baoCaoTinhHinhMuonSachTheoTheLoaiDAL = New BaoCaoMuonSachDAL()
    End Sub
    Public Function SelectALL(month As Integer, year As Integer) As List(Of BaoCaoMuonSachDTO)
        Return baoCaoTinhHinhMuonSachTheoTheLoaiDAL.SelectAll(month, year)
    End Function
End Class
