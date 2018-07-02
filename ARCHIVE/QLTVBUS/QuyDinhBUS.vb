Imports Utility
Imports QLTVDTO
Imports QLTVDAL
Public Class QuyDinhBUS
    Private quydinhDAL As QuyDinhDAL
    Public Sub New()
        quydinhDAL = New QuyDinhDAL()
    End Sub
    Public Sub New(ConnectionString As String)
        quydinhDAL = New QuyDinhDAL(ConnectionString)
    End Sub
    Public Function update(tt As QuyDinhDTO) As Result
        Return quydinhDAL.update(tt)
    End Function
    Public Function selectALL(ByRef quydinh As QuyDinhDTO) As Result
        Return quydinhDAL.selectALL(quydinh)
    End Function
End Class
