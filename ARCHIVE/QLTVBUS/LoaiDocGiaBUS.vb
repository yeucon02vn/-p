Imports QLTVDAL
Imports QLTVDTO
Imports Utility
Public Class LoaiDocGiaBUS
    Private ldgDAL As LoaiDocGiaDAL
    Public Sub New()
        ldgDAL = New LoaiDocGiaDAL()
    End Sub
    Public Sub New(ConnectionString As String)
        ldgDAL = New LoaiDocGiaDAL(ConnectionString)
    End Sub
    Public Function isValidName(ldg As LoaiDocGiaDTO) As Boolean
        If (ldg.Tenloaidocgia.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(ldg As LoaiDocGiaDTO) As Result
        Return ldgDAL.insert(ldg)
    End Function
    Public Function update(ldg As LoaiDocGiaDTO) As Result
        Return ldgDAL.update(ldg)
    End Function
    Public Function delete(maloai As Integer) As Result
        Return ldgDAL.delete(maloai)
    End Function
    Public Function selectALL(ByRef listLoaiDG As List(Of LoaiDocGiaDTO)) As Result
        Return ldgDAL.selectALL(listLoaiDG)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ldgDAL.getNextID(nextID)
    End Function
End Class
