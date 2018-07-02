Public Class LoaiDocGiaDTO
    Private strmaloaidocgia As Integer
    Private strtenloaidocgia As String
    Public Sub New()

    End Sub
    Public Sub New(Madocgia As Integer, Tendocgia As String)
        Me.strmaloaidocgia = Madocgia
        Me.strtenloaidocgia = Tendocgia
    End Sub
    Property Maloaidocgia() As Integer
        Get
            Return Me.strmaloaidocgia
        End Get
        Set(value As Integer)
            Me.strmaloaidocgia = value
        End Set
    End Property
    Property Tenloaidocgia() As String
        Get
            Return Me.strtenloaidocgia
        End Get
        Set(value As String)
            Me.strtenloaidocgia = value
        End Set
    End Property
End Class
