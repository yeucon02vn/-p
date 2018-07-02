Imports Utility
Imports QLTVDTO
Imports QLTVDAL
Imports System.Configuration
Imports System.Data.SqlClient
Public Class QuyDinhDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function update(ByRef quydinh As QuyDinhDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblQuiDinh] SET"
        query &= " [Tuoitoithieu] = @Tuoitoithieu "
        query &= " ,[Tuoitoida] = @Tuoitoida "
        query &= " ,[thoihanthe] = @thoihanthe "
        query &= " ,[Soluongtheloaitoida] = @Soluongtheloaitoida "
        query &= " ,[Khoangcachnam] = @Khoangcachnam "
        query &= " ,[Soluongmuontoida] = @Soluongmuontoida "
        query &= " ,[Ngaymuontoida] = @Ngaymuontoida "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Tuoitoithieu", quydinh.Tuoitoithieu)
                    .Parameters.AddWithValue("@Tuoitoida", quydinh.Tuoitoida)
                    .Parameters.AddWithValue("@thoihanthe", quydinh.Thoihanthe)
                    .Parameters.AddWithValue("@Soluongtheloaitoida", quydinh.Soluongtheloai)
                    .Parameters.AddWithValue("@Khoangcachnam", quydinh.Khoangcachnam)
                    .Parameters.AddWithValue("@Soluongmuontoida", quydinh.Sosachmuontoida)
                    .Parameters.AddWithValue("@Ngaymuontoida", quydinh.Songaymuontoida)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật quy định không thành công", ex.StackTrace)


                End Try

            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL(ByRef quydinh As QuyDinhDTO)
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblQuiDinh]"
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
                        While reader.Read()
                            quydinh = New QuyDinhDTO(reader("Tuoitoithieu"), reader("Tuoitoida"), reader("thoihanthe"), reader("Soluongtheloaitoida"), reader("Khoangcachnam"), reader("Soluongmuontoida"), reader("Ngaymuontoida"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất quy định không thành công ", ex.StackTrace)
                End Try
            End Using
        End Using
    End Function
End Class
