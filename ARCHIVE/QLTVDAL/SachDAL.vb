Imports QLTVDTO
Imports Utility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class SachDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function builMSS(ByRef nextMss As String) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaSach]"
        query &= "FROM [tblSach]"
        query &= "ORDER BY [MaSach] DESC"
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
                            idOnDB = reader("MaSach")

                        End While
                    End If
                    nextMss = idOnDB + 1

                Catch ex As Exception
                    conn.Close()
                    nextMss = 1
                    Return New Result(False, "Lấy ID kế tiếp không thành công", ex.StackTrace)

                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(s As SachDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblSach]([MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang])"
        query &= "VALUES (@MaSach,@Tensach,@MaTheLoai,@Tacgia,@Nhaxuatban,@Namxuatban,@Ngaynhap,@Trigia,@Khoangcachxuatban,@MaTinhTrang)"

        '
        Dim nextMss = "1"
        builMSS(nextMss)
        s.Masach = nextMss

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", s.Masach)
                    .Parameters.AddWithValue("@Tensach", s.Tensach)
                    .Parameters.AddWithValue("@MaTheloai", s.Matheloai)
                    .Parameters.AddWithValue("@Tacgia", s.Tacgia)
                    .Parameters.AddWithValue("@Nhaxuatban", s.Nhaxuatban)
                    .Parameters.AddWithValue("@Namxuatban", s.Namxuatban)
                    .Parameters.AddWithValue("@Ngaynhap", s.Ngaynhap)
                    .Parameters.AddWithValue("@Trigia", s.Trigia)
                    .Parameters.AddWithValue("@Khoangcachxuatban", s.Khoangcachnam)
                    .Parameters.AddWithValue("@MaTinhTrang", s.Matinhtrang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectALL(ByRef listSach As List(Of SachDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblSach] "


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
                    If reader.HasRows = True Then
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Sach không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selecttheloai(tentheloai As String, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblSach] , [tblTheLoai] "
        query &= "Where [tblSach].[MaTheLoai] = [tblTheLoai].[MaTheLoai] AND [Tentheloai] = @tentheloai "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tentheloai", tentheloai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selecttheloai1(tentheloai As String, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang]"
        query &= "FROM [tblSach] "
        query &= "WHERE [MaTheLoai] LIKE N'" & tentheloai & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTheLoai", tentheloai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectMa(ma As String, ByRef sach As SachDTO)
        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang]"
        query &= "FROM [tblSach] "
        query &= "WHERE [MaSach] LIKE N'" & ma & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", ma)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        While reader.Read()
                            sach = New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))
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

    Public Function selecttacgia(tacgia As String, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang]"
        query &= "FROM [tblSach] "
        query &= "WHERE [Tacgia] LIKE N'" & tacgia & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Tacgia", tacgia)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectnhaxuatban(nhaxuatban As String, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang]"
        query &= "FROM [tblSach] "
        query &= "WHERE [Nhaxuatban] LIKE N'" & nhaxuatban & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Nhaxuatban", nhaxuatban)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectmasach(masach As Integer, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang]"
        query &= "FROM [tblSach] "
        query &= "WHERE [MaSach] LIKE N'" & masach & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", masach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectten(tensach As String, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang]"
        query &= "FROM [tblSach] "
        query &= "WHERE [Tensach] LIKE N'" & tensach & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Tensach", tensach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While



                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectttinhtrang(tentinhtrang As String, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblSach] , [tblTinhTrang] "
        query &= "Where [tblSach].[MaTinhTrang] = [tblTinhTrang].[MaTinhTrang] AND [Tentinhtrang] LIKE N'" & tentinhtrang & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tentinhtrang", tentinhtrang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectttinhtrang1(tentinhtrang As String, ByRef listsach As List(Of SachDTO))
        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[Tensach],[MaTheLoai],[Tacgia],[Nhaxuatban],[Namxuatban],[Ngaynhap],[Trigia],[Khoangcachxuatban],[MaTinhTrang]"
        query &= "FROM [tblSach] "
        query &= "WHERE [MaTinhTrang] LIKE N'" & tentinhtrang & "%'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTinhTrang", tentinhtrang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listsach.Clear()
                        While reader.Read()
                            listsach.Add((New SachDTO(reader("MaSach"), reader("Tensach"), reader("MaTheLoai"), reader("Tacgia"), reader("Nhaxuatban"), reader("Namxuatban"), reader("Ngaynhap"), reader("Trigia"), reader("Khoangcachxuatban"), reader("MaTinhTrang"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả sách theo trình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(s As SachDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblSach] SET"
        query &= " [Tensach] = @Tensach "
        query &= " ,[MaTheLoai] = @MaTheLoai "
        query &= " ,[Tacgia] = @Tacgia "
        query &= " ,[Nhaxuatban] = @Nhaxuatban "
        query &= " ,[Namxuatban] = @Namxuatban "
        query &= " ,[Ngaynhap] = @Ngaynhap "
        query &= " ,[Trigia] = @Trigia "
        query &= " ,[Khoangcachxuatban] = @Khoangcachxuatban "
        query &= " ,[MaTinhTrang] = @MaTinhTrang "
        query &= " WHERE "
        query &= " [MaSach] = @MaSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", s.Masach)
                    .Parameters.AddWithValue("@Tensach", s.Tensach)
                    .Parameters.AddWithValue("@MaTheloai", s.Matheloai)
                    .Parameters.AddWithValue("@Tacgia", s.Tacgia)
                    .Parameters.AddWithValue("@Nhaxuatban", s.Nhaxuatban)
                    .Parameters.AddWithValue("@Namxuatban", s.Namxuatban)
                    .Parameters.AddWithValue("@Ngaynhap", s.Ngaynhap)
                    .Parameters.AddWithValue("@Trigia", s.Trigia)
                    .Parameters.AddWithValue("@Khoangcachxuatban", s.Khoangcachnam)
                    .Parameters.AddWithValue("@MaTinhTrang", s.Matinhtrang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maSach As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblSach] "
        query &= " WHERE "
        query &= " [MaSach] = @MaSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", maSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function

End Class
