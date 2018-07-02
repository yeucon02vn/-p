Public Class QuyDinhDTO
    Private ituoitoithieu As Integer
    Private ituoitoida As Integer
    Private ithoihanthe As Integer
    Private isoluongtheloai As Integer
    Private ikhoangcachnam As Integer
    Private isosachmuontoida As Integer
    Private isongaymuontoida As Integer
    Public Sub New()

    End Sub
    Public Sub New(Tuoitoithieu As Integer, Tuoitoida As Integer, Thoihanthe As Integer, Soluongtheloai As Integer, Khoangcachnam As Integer, Sosachmuontoida As Integer, Songaymuontoida As Integer)
        Me.ituoitoithieu = Tuoitoithieu
        Me.ituoitoida = Tuoitoida
        Me.ithoihanthe = Thoihanthe
        Me.isoluongtheloai = Soluongtheloai
        Me.ikhoangcachnam = Khoangcachnam
        Me.isosachmuontoida = Sosachmuontoida
        Me.isongaymuontoida = Songaymuontoida
    End Sub
    Property Tuoitoithieu() As Integer
        Get
            Return Me.ituoitoithieu
        End Get
        Set(value As Integer)
            Me.ituoitoithieu = value
        End Set
    End Property
    Property Tuoitoida() As Integer
        Get
            Return Me.ituoitoida
        End Get
        Set(value As Integer)
            Me.ituoitoida = value
        End Set
    End Property
    Property Thoihanthe() As Integer
        Get
            Return Me.ithoihanthe
        End Get
        Set(value As Integer)
            Me.ithoihanthe = value
        End Set
    End Property
    Property Soluongtheloai() As Integer
        Get
            Return Me.isoluongtheloai
        End Get
        Set(value As Integer)
            Me.isoluongtheloai = value
        End Set
    End Property
    Property Khoangcachnam() As Integer
        Get
            Return Me.ikhoangcachnam
        End Get
        Set(value As Integer)
            Me.ikhoangcachnam = value
        End Set
    End Property
    Property Sosachmuontoida() As Integer
        Get
            Return Me.isosachmuontoida
        End Get
        Set(value As Integer)
            Me.isosachmuontoida = value
        End Set
    End Property
    Property Songaymuontoida() As Integer
        Get
            Return Me.isongaymuontoida
        End Get
        Set(value As Integer)
            Me.isongaymuontoida = value
        End Set
    End Property
End Class
