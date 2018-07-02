Imports QLTVDTO
Imports QLTVDAL
Imports Utility
Public Class TinhTrangSachBUS
    Private lttDAL As TinhtrangsachDAL
    Public Sub New()
        lttDAL = New TinhtrangsachDAL()
    End Sub
    Public Sub New(ConnectionString As String)
        lttDAL = New TinhtrangsachDAL(ConnectionString)
    End Sub
    Public Function isValidName(tt As TinhtrangsachDTO) As Boolean
        If (tt.tentinhtrang.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(ltt As TinhtrangsachDTO) As Result
        Return lttDAL.insert(ltt)
    End Function
    Public Function update(ltt As TinhtrangsachDTO) As Result
        Return lttDAL.update(ltt)
    End Function
    Public Function delete(maloai As Integer) As Result
        Return lttDAL.delete(maloai)
    End Function
    Public Function selectALL(ByRef listLoaiTT As List(Of TinhtrangsachDTO)) As Result
        Return lttDAL.selectALL(listLoaiTT)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lttDAL.getNextID(nextID)
    End Function
End Class
