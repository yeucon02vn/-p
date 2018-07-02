Imports Utility
Imports QLTVDTO
Imports QLTVDAL
Public Class BaoCaoMuonTreBUS
    Dim baocaomuontreDAL As BaoCaoMuonTreDAL
    Public Sub New()
        baocaomuontreDAL = New BaoCaoMuonTreDAL()
    End Sub
    Public Sub New(connectionString As String)
        baocaomuontreDAL = New BaoCaoMuonTreDAL(connectionString)
    End Sub
    Public Function baocao() As List(Of BaoCaoMunTreDTO)
        Return baocaomuontreDAL.thongkemuontre()
    End Function
End Class
