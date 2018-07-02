Imports QLTVDTO
Imports Utility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class LoaiDocGiaDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextId As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaLoaiDocGia]"
        query &= "FROM [tblLoaiDocGia]"
        query &= "ORDER BY [MaLoaiDocGia] DESC"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaLoaiDocGia")

                        End While
                    End If
                    nextId = idOnDB + 1

                Catch ex As Exception
                    conn.Close()
                    nextId = 1
                    Return New Result(False, "Lấy ID kế tiếp không thành công", ex.StackTrace)

                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function insert(ldg As LoaiDocGiaDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiDocGia]([MaLoaiDocGia],[Tenloaidocgia])"
        query &= "VALUES (@MaLoaiDocGia,@Tenloaidocgia)"
        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ldg.Maloaidocgia = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDocGia", ldg.Maloaidocgia)
                    .Parameters.AddWithValue("@Tenloaidocgia", ldg.Tenloaidocgia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm Loại độc giả không thành công", ex.StackTrace)


                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function update(ldg As LoaiDocGiaDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaiDocGia] SET"
        query &= " [Tenloaidocgia] = @Tenloaidocgia "
        query &= "WHERE "
        query &= " [MaLoaiDocGia] = @MaLoaiDocGia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDocGia", ldg.Maloaidocgia)
                    .Parameters.AddWithValue("@Tenloaidocgia", ldg.Tenloaidocgia)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật loại độc giả không thành công", ex.StackTrace)


                End Try

            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL(ByRef listLoaiDG As List(Of LoaiDocGiaDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaLoaiDocGia], [Tenloaidocgia]"
        query &= " FROM [tblLoaiDocGia]"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiDG.Clear()
                        While reader.Read()
                            listLoaiDG.Add(New LoaiDocGiaDTO(reader("MaLoaiDocGia"), reader("Tenloaidocgia")))

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả loại độc giả không thành công ", ex.StackTrace)

                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function delete(maloai As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaiDocGia] "
        query &= " WHERE "
        query &= " [MaLoaiDocGia] = @MaLoaiDocGia "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDocGia", maloai)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Xóa loại độc giả thành công", ex.StackTrace)
                End Try
            End Using

        End Using
        Return New Result(True)
    End Function
End Class
