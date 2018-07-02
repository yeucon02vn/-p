Imports Utility
Imports QLTVDTO
Imports System.Configuration
Imports System.Data.SqlClient
Public Class PhieuMuonSachDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextId As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuMuon]"
        query &= "FROM [tblPhieuMuonTra]"
        query &= "ORDER BY [MaPhieuMuon] DESC"
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
                            idOnDB = reader("MaPhieuMuon")

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
    Public Function insert(phieumuonsach As PhieuMuonSacDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuMuonTra]([MaPhieuMuon],[MaDocGia],[MaSach],[Ngaymuonsach],[Ngaytrasach],[Tienphat])"
        query &= "VALUES (@MaPhieuMuon,@MaDocGia,@MaSach,@Ngaymuonsach,@Ngaytrasach,@Tienphat)"
        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        phieumuonsach.Maphieumuon = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuMuon", phieumuonsach.Maphieumuon)
                    .Parameters.AddWithValue("@MaDocGia", phieumuonsach.Madocgia)
                    .Parameters.AddWithValue("@MaSach", phieumuonsach.Masach)
                    .Parameters.AddWithValue("@Ngaymuonsach", phieumuonsach.Ngaymuonsach)
                    .Parameters.AddWithValue("@Ngaytrasach", phieumuonsach.Ngaytrasach)
                    .Parameters.AddWithValue("@Tienphat", phieumuonsach.Tienphat)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Lập phiếu mượn sách  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function update(phieumuonsach As PhieuMuonSacDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuMuonTra] SET"
        query &= " [MaDocGia] = @MaDocGia "
        query &= " ,[MaSach] = @MaSach "
        query &= " ,[Ngaymuonsach] = @Ngaymuonsach "
        query &= " ,[Ngaytrasach] = @Ngaytrasach "
        query &= " ,[Tienphat] = @Tienphat "
        query &= " WHERE "
        query &= " [MaPhieuMuon] = @MaPhieuMuon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuMuon", phieumuonsach.Maphieumuon)
                    .Parameters.AddWithValue("@MaDocGia", phieumuonsach.Madocgia)
                    .Parameters.AddWithValue("@MaSach", phieumuonsach.Masach)
                    .Parameters.AddWithValue("@Ngaymuonsach", phieumuonsach.Ngaymuonsach)
                    .Parameters.AddWithValue("@Ngaytrasach", phieumuonsach.Ngaytrasach)
                    .Parameters.AddWithValue("@Tienphat", phieumuonsach.Tienphat)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật phiếu mượn sách không thành công", ex.StackTrace)


                End Try

            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL(ByRef listphieumuon As List(Of PhieuMuonSacDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblPhieuMuonTra]"
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
                        listphieumuon.Clear()
                        While reader.Read()
                            listphieumuon.Add(New PhieuMuonSacDTO(reader("MaPhieuMuon"), reader("MaDocGia"), reader("MaSach"), reader("Ngaymuonsach"), reader("Ngaytrasach"), reader("Tienphat")))

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả phiếu mượn sách không thành công ", ex.StackTrace)

                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectma(ma As String, ByRef phieumuonsach As PhieuMuonSacDTO) As Result
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblPhieuMuonTra]"
        query &= "WHERE [MaPhieuMuon] = @MaPhieuMuon "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuMuon", ma)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        'docgia.Tendocgia = reader("Hoten")
                        While reader.Read()
                            phieumuonsach = New PhieuMuonSacDTO(reader("MaPhieuMuon"), reader("MaDocGia"), reader("MaSach"), reader("Ngaymuonsach"), reader("Ngaytrasach"), reader("Tienphat"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy phiếu mượn sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(ma As String) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuMuonTra] "
        query &= " WHERE "
        query &= " [MaPhieuMuon] = @MaPhieuMuon "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuMuon", ma)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Xóa phiếu mượn thành công", ex.StackTrace)
                End Try
            End Using

        End Using
        Return New Result(True)
    End Function
    Public Function thongtin(ma As Integer, ByRef listphieumuon As List(Of PhieuMuonSacDTO))
        Dim query As String = String.Empty
        query &= " SELECT * "
        query &= " FROM [tblPhieuMuonTra] , [tblDocGia] "
        query &= " WHERE [tblPhieuMuonTra].[MaDocGia] =[tblDocGia].[MaDocGia] AND [MaDocGia] = @MaDocGia "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDocGia", ma)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listphieumuon.Clear()
                        While reader.Read()
                            listphieumuon.Add(New PhieuMuonSacDTO(reader("MaPhieuMuon"), reader("MaDocGia"), reader("MaSach"), reader("Ngaymuonsach"), reader("Ngaytrasach"), reader("Tienphat")))

                        End While

                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy danh sach không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
    End Function


End Class
