Imports QLTVDTO
Imports Utility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class DocGiaDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function builMSDG(ByRef nextMsdg As String) As Result

        nextMsdg = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMsdg = x + "000000"
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaDocGia] "
        query &= "FROM [tblDocGia]"
        query &= "ORDER BY [MaDocGia] DESC"
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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("MaDocGia")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextMsdg = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMsdg = nextMsdg + tmp
                        System.Console.WriteLine(nextMsdg)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(dg As DocGiaDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDocGia]([MaDocGia],[Hoten],[Ngaysinh],[Diachi],[Email],[Ngaylapthe],[Ngayhethan],[MaLoaiDocGia],[Sosachdangmuon],[Tinhtrangthe])"
        query &= "VALUES (@MaDocGia,@Hoten,@Ngaysinh,@Diachi,@Email,@Ngaylapthe,@Ngayhethan,@MaLoaiDocGia,@Sosachdangmuon,@Tinhtrangthe)"

        '
        Dim nextMsdg = "1"
        builMSDG(nextMsdg)
        dg.Madocgia = nextMsdg

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDocGia", dg.Madocgia)
                    .Parameters.AddWithValue("@Hoten", dg.Tendocgia)
                    .Parameters.AddWithValue("@Ngaysinh", dg.Ngaysinh)
                    .Parameters.AddWithValue("@Diachi", dg.Diachi)
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@Ngaylapthe", dg.Ngaylapthe)
                    .Parameters.AddWithValue("@Ngayhethan", dg.Ngayhethan)
                    .Parameters.AddWithValue("@MaLoaiDocGia", dg.Maloaidocgia)
                    .Parameters.AddWithValue("@Sosachdangmuon", dg.Sosachmuon)
                    .Parameters.AddWithValue("@Tinhtrangthe", dg.Tinhtrang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL(ByRef listDocGia As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaDocGia],[Hoten],[Ngaysinh],[Diachi],[Email],[Ngaylapthe],[Ngayhethan],[MaLoaiDocGia],[Sosachdangmuon],[Tinhtrangthe]"
        query &= "FROM [tblDocGia]"


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
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add(New DocGiaDTO(reader("MaDocGia"), reader("Hoten"), reader("Ngaysinh"), reader("Diachi"), reader("Email"), reader("Ngaylapthe"), reader("Ngayhethan"), reader("MaLoaiDocGia"), reader("Sosachdangmuon"), reader("Tinhtrangthe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByType(maLoai As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaDocGia],[Hoten],[Ngaysinh],[Diachi],[Email],[Ngaylapthe],[Ngayhethan],[MaLoaiDocGia],[Sosachdangmuon],[Tinhtrangthe] "
        query &= "FROM [tblDocGia] "
        query &= "WHERE [MaLoaiDocGia] = @MaLoaiDocGia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDocGia", maLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add((New DocGiaDTO(reader("MaDocGia"), reader("Hoten"), reader("Ngaysinh"), reader("Diachi"), reader("Email"), reader("Ngaylapthe"), reader("Ngayhethan"), reader("MaLoaiDocGia"), reader("Sosachdangmuon"), reader("Tinhtrangthe"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc Giả theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL_MaDocGia(madocgia As String, ByRef docgia As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaDocGia],[Hoten],[Ngaysinh],[Diachi],[Email],[Ngaylapthe],[Ngayhethan],[MaLoaiDocGia],[Sosachdangmuon],[Tinhtrangthe] "
        query &= "FROM [tblDocGia] "
        query &= "WHERE [MaDocGia] = @MaDocGia "
        'docgia.Tendocgia
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDocGia", madocgia)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        'docgia.Tendocgia = reader("Hoten")
                        While reader.Read()
                            docgia = New DocGiaDTO(reader("MaDocGia"), reader("Hoten"), reader("Ngaysinh"), reader("Diachi"), reader("Email"), reader("Ngaylapthe"), reader("Ngayhethan"), reader("MaLoaiDocGia"), reader("Sosachdangmuon"), reader("Tinhtrangthe"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc Giả theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function update(dg As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDocGia] SET"
        query &= " [Hoten] = @Hoten "
        query &= " ,[Ngaysinh] = @Ngaysinh "
        query &= " ,[Diachi] = @Diachi "
        query &= " ,[Email] = @Email "
        query &= " ,[Ngaylapthe] = @Ngaylapthe "
        query &= " ,[Ngayhethan] = @Ngayhethan "
        query &= " ,[MaLoaiDocGia] = @MaLoaiDocGia "
        query &= " ,[Sosachdangmuon] = @Sosachdangmuon "
        query &= " ,[Tinhtrangthe] = @Tinhtrangthe "
        query &= " WHERE "
        query &= " [MaDocGia] = @MaDocGia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Hoten", dg.Tendocgia)
                    .Parameters.AddWithValue("@Ngaysinh", dg.Ngaysinh)
                    .Parameters.AddWithValue("@Diachi", dg.Diachi)
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@Ngaylapthe", dg.Ngaylapthe)
                    .Parameters.AddWithValue("@Ngayhethan", dg.Ngayhethan)
                    .Parameters.AddWithValue("@MaLoaiDocGia", dg.Maloaidocgia)
                    .Parameters.AddWithValue("@Sosachdangmuon", dg.Sosachmuon)
                    .Parameters.AddWithValue("@Tinhtrangthe", dg.Tinhtrang)
                    .Parameters.AddWithValue("@MaDocGia", dg.Madocgia)
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



    Public Function delete(maDocGia As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblDocGia] "
        query &= " WHERE "
        query &= " [MaDocGia] = @MaDocGia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDocGia", maDocGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
