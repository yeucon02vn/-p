Imports Utility
Imports QLTVDTO
Imports System.Configuration
Imports System.Data.SqlClient
Public Class TaiKhoanDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function insert(taikhoan As TaiKhoanDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [TaiKhoan]([TenTaiKhoan],[Matkhau])"
        query &= "VALUES (@TenTaiKhoan,@Matkhau)"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenTaiKhoan", taikhoan.Tentaikhoan)
                    .Parameters.AddWithValue("@Matkhau", taikhoan.Matkhau)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Đăng ký tài khoản không thành công", ex.StackTrace)


                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function update(taikhoan As TaiKhoanDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [TaiKhoan] SET"
        query &= " [TenTaiKhoan] = @TenTaiKhoan "
        query &= " ,[Matkhau] = @Matkhau "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenTaiKhoan", taikhoan.Tentaikhoan)
                    .Parameters.AddWithValue("@Matkhau", taikhoan.Matkhau)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật thông tin tài khoản không thành công", ex.StackTrace)


                End Try

            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL(ByRef listtaikhoan As List(Of TaiKhoanDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [TaiKhoan]"
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
                        listtaikhoan.Clear()
                        While reader.Read()
                            listtaikhoan.Add(New TaiKhoanDTO(reader("TenTaiKhoan"), reader("Matkhau")))

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả tài khoản không thành công ", ex.StackTrace)

                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
