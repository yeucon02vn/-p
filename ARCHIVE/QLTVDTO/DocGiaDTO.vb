Public Class DocGiaDTO
    Private strmadocgia As String
    Private strtendocgia As String
    Private imaloaidocgia As Integer
    Private datengaysinh As DateTime
    Private strdiachi As String
    Private stremail As String
    Private datengaylapthe As DateTime
    Private datengayhethan As DateTime
    Private intsosachmuon As Integer
    Private strtinhtrang As String

    Public Sub New(strMadocgia As String, strHoten As String, dateNgaysinh As DateTime, StrDiachi As String, strEmail As String, dateNgaylapthe As DateTime, dateNgayhethan As DateTime, intMaloaidocgia As Integer, intSosachmuon As Integer, strTinhtrang As String)
        Me.strmadocgia = strMadocgia
        Me.strtendocgia = strHoten
        Me.datengaysinh = dateNgaysinh
        Me.strdiachi = StrDiachi
        Me.stremail = strEmail
        Me.datengaylapthe = dateNgaylapthe
        Me.datengayhethan = dateNgayhethan

        Me.imaloaidocgia = intMaloaidocgia
        Me.intsosachmuon = intSosachmuon
        Me.strtinhtrang = strTinhtrang
    End Sub
    Public Sub New()

    End Sub
    Property Madocgia() As String
        Get
            Return Me.strmadocgia
        End Get
        Set(value As String)
            Me.strmadocgia = value
        End Set
    End Property
    Property Tendocgia() As String
        Get
            Return Me.strtendocgia
        End Get
        Set(value As String)
            Me.strtendocgia = value
        End Set
    End Property
    Property Maloaidocgia() As Integer
        Get
            Return Me.imaloaidocgia
        End Get
        Set(value As Integer)
            Me.imaloaidocgia = value
        End Set
    End Property
    Property Ngaysinh() As DateTime
        Get
            Return Me.datengaysinh
        End Get
        Set(value As DateTime)
            Me.datengaysinh = value
        End Set
    End Property
    Property Diachi() As String
        Get
            Return strdiachi
        End Get
        Set(value As String)
            Me.strdiachi = value
        End Set
    End Property
    Property Email() As String
        Get
            Return Me.stremail
        End Get
        Set(value As String)
            Me.stremail = value
        End Set
    End Property
    Property Ngaylapthe() As DateTime
        Get
            Return Me.datengaylapthe
        End Get
        Set(value As DateTime)
            Me.datengaylapthe = value
        End Set
    End Property
    Property Ngayhethan() As DateTime
        Get
            Return Me.datengayhethan
        End Get
        Set(value As DateTime)
            Me.datengayhethan = value
        End Set
    End Property
    Property Sosachmuon() As Integer
        Get
            Return Me.intsosachmuon
        End Get
        Set(value As Integer)
            Me.intsosachmuon = value
        End Set
    End Property
    Property Tinhtrang() As String
        Get
            Return Me.strtinhtrang
        End Get
        Set(value As String)
            Me.strtinhtrang = value
        End Set
    End Property
End Class
