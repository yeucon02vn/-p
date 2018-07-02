Public Class PhieuMuonSacDTO
    Private strmaphieumuon As String
    Private strmadocgia As String
    Private strmasach As String
    Private datengaymuonsach As DateTime
    Private datengaytrasach As DateTime
    Private strtienphat As String
    Public Sub New()

    End Sub

    Public Sub New(Maphieumuon As String, Madocgia As String, Masach As String, Ngaymuonsach As DateTime, Ngaytrasach As DateTime, Tienphat As String)
        Me.strmaphieumuon = Maphieumuon
        Me.strmadocgia = Madocgia
        Me.strmasach = Masach
        Me.datengaymuonsach = Ngaymuonsach
        Me.datengaytrasach = Ngaytrasach
        Me.strtienphat = Tienphat

    End Sub
    Public Sub New(Maphieumuon As String, Madocgia As String, Masach As String, Ngaymuonsach As DateTime, Ngaytrasach As DateTime)
        Me.strmaphieumuon = Maphieumuon
        Me.strmadocgia = Madocgia
        Me.strmasach = Masach
        Me.datengaymuonsach = Ngaymuonsach
        Me.datengaytrasach = Ngaytrasach


    End Sub
    Property Maphieumuon() As String
        Get
            Return Me.strmaphieumuon
        End Get
        Set(value As String)
            Me.strmaphieumuon = value
        End Set
    End Property
    Property Madocgia() As String
        Get
            Return Me.strmadocgia
        End Get
        Set(value As String)
            Me.strmadocgia = value
        End Set
    End Property
    Property Masach() As String
        Get
            Return Me.strmasach
        End Get
        Set(value As String)
            Me.strmasach = value
        End Set
    End Property

    Property Ngaymuonsach() As DateTime
        Get
            Return Me.datengaymuonsach
        End Get
        Set(value As DateTime)
            Me.datengaymuonsach = value
        End Set
    End Property
    Property Ngaytrasach() As DateTime
        Get
            Return Me.datengaytrasach
        End Get
        Set(value As DateTime)
            Me.datengaytrasach = value
        End Set
    End Property
    Property Tienphat() As String
        Get
            Return Me.strtienphat
        End Get
        Set(value As String)
            Me.strtienphat = value
        End Set
    End Property

End Class
