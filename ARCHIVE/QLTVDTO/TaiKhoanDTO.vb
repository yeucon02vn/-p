Public Class TaiKhoanDTO
    Private strtentaikhoan As String
    Private strmatkhau As String
    Public Sub New()

    End Sub
    Public Sub New(Tentaikhoan As String, Matkhau As String)
        Me.strtentaikhoan = Tentaikhoan
        Me.strmatkhau = Matkhau
    End Sub
    Property Tentaikhoan() As String
        Get
            Return Me.strtentaikhoan
        End Get
        Set(value As String)
            Me.strtentaikhoan = value
        End Set
    End Property
    Property Matkhau() As String
        Get
            Return Me.strmatkhau
        End Get
        Set(value As String)
            Me.strmatkhau = value
        End Set
    End Property
End Class
