Imports QLTVDTO
Imports Utility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class TinhtrangsachDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextId As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaTinhTrang]"
        query &= "FROM [tblTinhTrang]"
        query &= "ORDER BY [MaTinhTrang] DESC"
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
                            idOnDB = reader("MaTinhTrang")

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
    Public Function insert(ltt As TinhtrangsachDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTinhTrang]([MaTinhTrang],[Tentinhtrang])"
        query &= "VALUES (@MaTinhTrang,@Tentinhtrang)"
        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ltt.Matinhtrang = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTinhTrang", ltt.Matinhtrang)
                    .Parameters.AddWithValue("@Tentinhtrang", ltt.tentinhtrang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm tình trạng sách không thành công", ex.StackTrace)


                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function update(ltt As TinhtrangsachDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblTinhTrang] SET"
        query &= " [Tentinhtrang] = @Tentinhtrang "
        query &= "WHERE "
        query &= "[MaTinhTrang] = @MaTinhTrang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTinhTrang", ltt.Matinhtrang)
                    .Parameters.AddWithValue("@Tentinhtrang", ltt.tentinhtrang)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật tình trạng sách không thành công", ex.StackTrace)


                End Try

            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL(ByRef listTinhTrangSach As List(Of TinhtrangsachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaTinhTrang], [Tentinhtrang]"
        query &= " FROM [tblTinhTrang]"
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
                        listTinhTrangSach.Clear()
                        While reader.Read()
                            listTinhTrangSach.Add(New TinhtrangsachDTO(reader("MaTinhTrang"), reader("Tentinhtrang")))

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả tình trạng sách  không thành công ", ex.StackTrace)

                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function delete(maloai As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblTinhTrang] "
        query &= " WHERE "
        query &= " [MaTinhTrang] = @MaTinhTrang "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTinhTrang", maloai)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Xóa tình trạng sách thành công", ex.StackTrace)
                End Try
            End Using

        End Using
        Return New Result(True)
    End Function
End Class
