Public Class SachDTO
    Private imasach As Integer
    Private strtensach As String
    Private imatheloai As Integer
    Private strtacgia As String
    Private strnhaxauatban As String
    Private inamxuatban As Integer
    Private datengaynhap As DateTime
    Private strtrigia As String
    Private ikhoangcachxuatban As Integer
    Private imatinhtrang As Integer
    Public Sub New()

    End Sub
    Public Sub New(iMasach As Integer, strTensach As String, iMatheloai As Integer, strTacgia As String, strNhaxuatban As String, iNamxuatban As Integer, dateNgaynhap As DateTime, strTrigia As String, iKhoangcachxuatban As Integer, iMatinhtrang As Integer)
        Me.imasach = iMasach
        Me.strtensach = strTensach
        Me.imatheloai = iMatheloai
        Me.strtacgia = strTacgia
        Me.strnhaxauatban = strNhaxuatban
        Me.inamxuatban = iNamxuatban
        Me.datengaynhap = dateNgaynhap
        Me.strtrigia = strTrigia
        Me.ikhoangcachxuatban = iKhoangcachxuatban
        Me.imatinhtrang = iMatinhtrang
    End Sub
    Property Masach() As Integer
        Get
            Return Me.imasach
        End Get
        Set(value As Integer)
            Me.imasach = value
        End Set
    End Property
    Property Tensach() As String
        Get
            Return Me.strtensach
        End Get
        Set(value As String)
            Me.strtensach = value
        End Set
    End Property
    Property Matheloai() As Integer
        Get
            Return Me.imatheloai
        End Get
        Set(value As Integer)
            Me.imatheloai = value
        End Set
    End Property
    Property Tacgia() As String
        Get
            Return Me.strtacgia

        End Get
        Set(value As String)
            Me.strtacgia = value
        End Set
    End Property
    Property Nhaxuatban() As String
        Get
            Return Me.strnhaxauatban
        End Get
        Set(value As String)
            Me.strnhaxauatban = value
        End Set
    End Property
    Property Namxuatban() As Integer
        Get
            Return Me.inamxuatban
        End Get
        Set(value As Integer)
            Me.inamxuatban = value
        End Set
    End Property
    Property Ngaynhap() As DateTime
        Get
            Return Me.datengaynhap
        End Get
        Set(value As DateTime)
            Me.datengaynhap = value
        End Set
    End Property
    Property Trigia() As String
        Get
            Return Me.strtrigia
        End Get
        Set(value As String)
            Me.strtrigia = value
        End Set
    End Property
    Property Khoangcachnam() As Integer
        Get
            Return Me.ikhoangcachxuatban
        End Get
        Set(value As Integer)
            Me.ikhoangcachxuatban = value
        End Set
    End Property
    Property Matinhtrang() As Integer
        Get
            Return Me.imatinhtrang
        End Get
        Set(value As Integer)
            Me.imatinhtrang = value
        End Set
    End Property
End Class
