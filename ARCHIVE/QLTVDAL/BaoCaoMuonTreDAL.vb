Imports Utility
Imports QLTVDTO
Imports System.Configuration
Imports System.Data.SqlClient
Public Class BaoCaoMuonTreDAL
    Private connectionString As String


    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function thongkemuontre() As List(Of BaoCaoMunTreDTO)
        Dim ngaytra As DateTime
        Dim phieumuonsachDAL = New PhieuMuonSachDAL()
        Dim listphieumuon = New List(Of PhieuMuonSacDTO)
        Dim sachDAL = New SachDAL()
        Dim sach = New SachDTO()
        phieumuonsachDAL.selectALL(listphieumuon)
        Dim listThongKe = New List(Of BaoCaoMunTreDTO)
        For Each phieumuon In listphieumuon
            ngaytra = phieumuon.Ngaymuonsach.AddDays(4)
            If tinhsongaytre(ngaytra) > 0 Then
                sachDAL.selectMa(phieumuon.Masach, sach)
                listThongKe.Add(New BaoCaoMunTreDTO(sach.Tensach, phieumuon.Ngaytrasach, tinhsongaytre(ngaytra)))

            End If
        Next
        Return listThongKe
    End Function
    Private Function tinhsongaytre(nt As DateTime)
        Dim day As Integer
        Dim elapse As TimeSpan
        elapse = DateTime.Now.Subtract(nt)
        day = elapse.TotalDays
        day -= 4
        Return day


    End Function
End Class
