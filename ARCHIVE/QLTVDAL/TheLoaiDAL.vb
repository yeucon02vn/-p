
Imports Utility
Imports QLTVDTO
Imports System.Configuration
Imports System.Data.SqlClient
Public Class TheLoaiDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextId As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaTheLoai]"
        query &= "FROM [tblTheLoai]"
        query &= "ORDER BY [MaTheLoai] DESC"
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
                            idOnDB = reader("MaTheLoai")

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
    Public Function insert(theloai As TheLoaiDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTheLoai]([MaTheLoai],[Tentheloai])"
        query &= "VALUES (@MaTheLoai,@Tentheloai)"
        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        theloai.Matheloai = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoai", theloai.Matheloai)
                    .Parameters.AddWithValue("@Tentheloai", theloai.Tentheloai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm Thể Loại không thành công", ex.StackTrace)


                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function update(theloai As TheLoaiDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblTheLoai] SET"
        query &= " [Tentheloai] = @Tentheloai "
        query &= "WHERE "
        query &= " [MaTheLoai] = @MaTheLoai "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoai", theloai.Matheloai)
                    .Parameters.AddWithValue("@Tentheloai", theloai.Tentheloai)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật thể loại không thành công", ex.StackTrace)


                End Try

            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL(ByRef listTheloai As List(Of TheLoaiDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaTheLoai], [Tentheloai]"
        query &= " FROM [tblTheLoai]"
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
                        listTheloai.Clear()
                        While reader.Read()
                            listTheloai.Add(New TheLoaiDTO(reader("MaTheLoai"), reader("Tentheloai")))

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả thể loại không thành công ", ex.StackTrace)

                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectma(ma As Integer, ByRef theloai As TheLoaiDTO) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaTheLoai], [Tentheloai]"
        query &= " FROM [tblTheLoai]"
        query &= "WHERE [MaTheLoai] = @MaTheLoai"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoai", ma)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            theloai = New TheLoaiDTO(reader("MaTheLoai"), reader("Tentheloai"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(matheloai As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblTheLoai] "
        query &= " WHERE "
        query &= " [MaTheLoai] = @MaTheLoai "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoai", matheloai)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Xóa thể loại giả thành công", ex.StackTrace)
                End Try
            End Using

        End Using
        Return New Result(True)
    End Function
    Public Function count() As Integer
        Dim sl As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT ([MaTheLoai]) AS Sotheloai "
        sqlQuery &= "FROM [tblTheLoai] "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            sl = reader("Sotheloai")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return sl
    End Function
    Public Function DemSoLanMuon(iMaTheLoai As Integer, iThang As Integer, iNam As Integer) As Integer
        Dim soLanMuon As Integer
        Dim query As String = String.Empty
        query &= " SELECT COUNT (*) AS SoLanMuon "
        query &= " FROM [tblPhieuMuonTra] AS pms, [tblTheLoai] AS theloai, [tblSach] AS sach "
        query &= " WHERE sach.[MaSach] = pms.[MaSach] AND pms.[MaSach] = sach.[MaSach] 
					  AND sach.[MaTheLoai] = theloai.[MaTheLoai]
					  AND theloai.[MaTheLoai] = @MaTheLoai
					  AND YEAR([Ngaymuonsach]) = @Nam
					  AND MONTH([Ngaymuonsach]) = @Thang "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoai", iMaTheLoai)
                    .Parameters.AddWithValue("@Nam", iNam)
                    .Parameters.AddWithValue("@Thang", iThang)
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            soLanMuon = reader("SoLanMuon")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return soLanMuon
    End Function
End Class
